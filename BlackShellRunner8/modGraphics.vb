Imports System.Runtime.CompilerServices

Module modGraphics

    '--------------------------------------------------------------------------------------'
    '<<-|-|modGraphics_By:_William_Stanley_Davis_(2010-2015)|-|->>'
    '--------------------------------------------------------------------------------------'

#Region "PrivateStuff"

#Region "PrivateEnums"

#Region "CornersForBresenhamFormMove"

    Private Enum TypeOfMove
        TopLeft = 0
        TopRight = 1
        BottomLeft = 2
        BottormRight = 3
        NoneUseTheFollowingCoordinates = 4
    End Enum

#End Region

#End Region

#Region "PrivateSubs"

#Region "FormsMovingDelayPeriodAndStuff"

    Private Sub DelayFor(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            My.Application.DoEvents() ' Allow windows messages to be processed
        Loop
    End Sub

    Private Sub StartMoving(Frm As Form)
        IsMoving = True
    End Sub

    Private Sub StopMoving(Frm As Form)
        IsMoving = False
        Frm.Focus()
    End Sub

#End Region

#Region "FormMoveDirection"

    Private Sub GR(ByVal Frm As Form, Optional ByVal IsOffScreen As Boolean = False)
        Dim LtTo As Integer
        If Not IsOffScreen Then
            LtTo = (My.Computer.Screen.WorkingArea.Width - Frm.Width)
        ElseIf IsOffScreen Then
            LtTo = 1
        End If
        If Frm.Left = LtTo Then Exit Sub
        If HasGraphics Then
            For Lt As Integer = Frm.Left To LtTo Step MoveSpeed
                DelayFor(0.01)
                If Lt >= LtTo Then Exit For
                Frm.Left = Lt
            Next
            Frm.Left = LtTo
        ElseIf Not HasGraphics Then
            Frm.Left = LtTo
        End If
    End Sub

    Private Sub GD(ByVal Frm As Form, Optional ByVal IsOffScreen As Boolean = False)
        Dim TpTo As Integer
        If Not IsOffScreen Then
            TpTo = (My.Computer.Screen.WorkingArea.Height - Frm.Height)
        ElseIf IsOffScreen Then
            TpTo = 1
        End If
        If Frm.Top = TpTo Then Exit Sub
        If HasGraphics Then
            For Tp As Integer = Frm.Top To TpTo Step MoveSpeed
                DelayFor(0.01)
                If Tp >= TpTo Then Exit For
                Frm.Top = Tp
            Next
            Frm.Top = TpTo
        ElseIf Not HasGraphics Then
            Frm.Top = TpTo
        End If
    End Sub

    Private Sub GL(ByVal Frm As Form, Optional ByVal IsOffScreen As Boolean = False)
        Dim LtTo As Integer
        If Not IsOffScreen Then
            LtTo = 1
        ElseIf IsOffScreen Then
            LtTo = (My.Computer.Screen.WorkingArea.Width - Frm.Width)
        End If
        If Frm.Left = LtTo Then Exit Sub
        If HasGraphics Then
            For Lt As Integer = Frm.Left To LtTo Step -MoveSpeed
                DelayFor(0.01)
                If Lt <= LtTo Then Exit For
                Frm.Left = Lt
            Next
            Frm.Left = LtTo
        ElseIf Not HasGraphics Then
            Frm.Left = LtTo
        End If
    End Sub

    Private Sub GU(ByVal Frm As Form, Optional ByVal IsOffScreen As Boolean = False)
        Dim TpTo As Integer
        If Not IsOffScreen Then
            TpTo = 1
        ElseIf IsOffScreen Then
            TpTo = (My.Computer.Screen.WorkingArea.Height - Frm.Height)
        End If
        If Frm.Top = TpTo Then Exit Sub
        If HasGraphics Then
            For Tp As Integer = Frm.Top To TpTo Step -MoveSpeed
                DelayFor(0.01)
                If Tp <= TpTo Then Exit For
                Frm.Top = Tp
            Next
            Frm.Top = TpTo
        ElseIf Not HasGraphics Then
            Frm.Top = TpTo
        End If
    End Sub

#End Region

#Region "BresenhamLineAlgorithm"

    Private Sub Swap(Of T)(ByRef d1 As T, ByRef d2 As T)
        Dim d = d2
        d2 = d1
        d1 = d
    End Sub

    Private Sub LocateForm(Frm As Form, ByVal iTag As Boolean, ByVal curx As Integer, ByVal cury As Integer)
        If iTag Then
            Frm.Location = New Point(Math.Round(cury), Math.Round(curx))
        Else
            Frm.Location = New Point(Math.Round(curx), Math.Round(cury))
        End If
    End Sub

    Private Sub BresenhamFormMove(ByVal Frm As Form, _
                            Optional ByVal TypeOfMove As TypeOfMove = modGraphics.TypeOfMove.NoneUseTheFollowingCoordinates, _
                            Optional ByVal X1 As Integer = 1, _
                            Optional ByVal Y1 As Integer = 1, _
                            Optional ByVal X2 As Integer = 1, _
                            Optional ByVal Y2 As Integer = 1)
        Dim WidthS As Integer = My.Computer.Screen.WorkingArea.Width
        Dim HeightS As Integer = My.Computer.Screen.WorkingArea.Height
        If Not TypeOfMove = modGraphics.TypeOfMove.NoneUseTheFollowingCoordinates Then
            If TypeOfMove = modGraphics.TypeOfMove.TopLeft Then
                Dim TopLeftCornerOfScreen As Point = New Point(1, 1)
                X2 = TopLeftCornerOfScreen.X
                Y2 = TopLeftCornerOfScreen.Y
            ElseIf TypeOfMove = modGraphics.TypeOfMove.TopRight Then
                Dim TopRightCornerOfScreen As Point = New Point(WidthS, 1)
                X2 = TopRightCornerOfScreen.X - Frm.Width
                Y2 = TopRightCornerOfScreen.Y
            ElseIf TypeOfMove = modGraphics.TypeOfMove.BottomLeft Then
                Dim BottomLeftCornerOfScreen As Point = New Point(1, HeightS)
                X2 = BottomLeftCornerOfScreen.X
                Y2 = BottomLeftCornerOfScreen.Y - Frm.Height
            ElseIf TypeOfMove = modGraphics.TypeOfMove.BottormRight Then
                Dim BottomRightCornerOfScreen As Point = New Point(WidthS, HeightS)
                X2 = BottomRightCornerOfScreen.X - Frm.Width
                Y2 = BottomRightCornerOfScreen.Y - Frm.Height
            End If
            X1 = Frm.Left
            Y1 = Frm.Top
        End If
        If HasGraphics Then
            Dim iTag As Integer = 0
            Dim dx, dy As Integer
            Dim tx, ty As Integer
            Dim inc1, inc2 As Integer
            Dim d As Integer
            Dim curx, cury As Integer
            If X1 = X2 AndAlso Y1 = Y2 Then
                Return
            End If
            dx = Math.Abs(X2 - X1)
            dy = Math.Abs(Y2 - Y1)
            If dx < dy Then
                iTag = 1
                Swap(Of Integer)(X1, Y1)
                Swap(Of Integer)(X2, Y2)
                Swap(Of Integer)(dx, dy)
            End If
            If (X2 - X1) > 0 Then
                tx = 1
            Else
                tx = -1
            End If
            If (Y2 - Y1) > 0 Then
                ty = 1
            Else
                ty = -1
            End If
            cury = Y1
            curx = X1
            inc1 = 2 * dy
            inc2 = 2 * (dy - dx)
            d = inc1 - dx
            Dim Speed As Integer = 1
            Dim ex As Integer = 0
            Dim wy As Integer
            Do While Not curx = X2
                If d < 0 Then
                    d += inc1
                Else
                    cury += ty
                    d += inc2
                End If
                If Speed = MoveSpeed Then
                    Speed = 0
                    LocateForm(Frm, iTag, curx, cury)
                    DelayFor(0.01)
                End If
                Speed += 1
                curx += tx
            Loop
            LocateForm(Frm, iTag, curx, cury)
        ElseIf Not HasGraphics Then
            Frm.Location = New Point(X2, Y2)
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "PublicStuff"

#Region "PublicVariables"

    Public BaseSleepTime As Integer = 0
    Public MoveSpeed As Integer = 7 ' This Would be 700 pixels per second
    Public HasGraphics As Boolean = False
    Public UseBresenhamLineAlgorithm As Boolean = True
    Public IsMoving As Boolean = False

#End Region

#Region "PublicSubs"

#Region "CommandRunGraphics"

    <Extension()> _
    Public Sub DisplayGraphics(ByVal Frm As Form, ByVal Err As Boolean)
        If IsMoving Then
            Exit Sub
        End If
        Do Until Not IsMoving
            Application.DoEvents()
        Loop
        If frmOptions.chkGraphics.Checked Then
            IsMoving = True
            Dim Tp As Single = Frm.Top
            Dim Lt As Single = Frm.Left
            Dim TpPH As Single = Tp + (Frm.Height / 2)
            Dim LtPH As Single = Lt + (Frm.Width / 2)
            Dim SDH As Single = (My.Computer.Screen.WorkingArea.Height / 2)
            Dim SDW As Single = (My.Computer.Screen.WorkingArea.Width / 2)
            Dim SleepyTime As Single = (0.0001 * BaseSleepTime)
            Dim ErrSleepyTime As Single = (SleepyTime / 2)
            If Err Then
                For e As Integer = 1 To 25
                    If LtPH > SDW Then
                        Frm.Left = Lt - (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    Else
                        Frm.Left = Lt + (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    End If
                    If TpPH > SDH Then
                        Frm.Top = Tp - (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    Else
                        Frm.Top = Tp + (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    End If
                    DelayFor(ErrSleepyTime)
                    Frm.Left = Lt
                    Frm.Top = Tp
                Next
            ElseIf Not Err Then
                For e As Integer = 1 To 50
                    If LtPH > SDW Then
                        Frm.Left = Lt - (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    Else
                        Frm.Left = Lt + (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    End If
                    If TpPH > SDH Then
                        Frm.Top = Tp - (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    Else
                        Frm.Top = Tp + (((My.Computer.Screen.Bounds.Width / 15) - Frm.Height) / e)
                    End If
                    DelayFor(SleepyTime)
                Next
                Frm.Left = Lt
                Frm.Top = Tp
            End If
            IsMoving = False
        End If
    End Sub

#End Region

#Region "MoveOneDirectionGraphics"

    <Extension()> _
    Public Sub GoRight(ByVal Frm As Form)
        If IsMoving Then Exit Sub
        If Frm.Left = (My.Computer.Screen.WorkingArea.Width - Frm.Width) Then Exit Sub
        StartMoving(Frm)
        GR(Frm)
        StopMoving(Frm)
    End Sub

    <Extension()> _
    Public Sub GoDown(ByVal Frm As Form)
        If IsMoving Then Exit Sub
        If Frm.Top = (My.Computer.Screen.WorkingArea.Height - Frm.Height) Then Exit Sub
        StartMoving(Frm)
        GD(Frm)
        StopMoving(Frm)
    End Sub

    <Extension()> _
    Public Sub GoLeft(ByVal Frm As Form)
        If IsMoving Then Exit Sub
        If Frm.Left = 1 Then Exit Sub
        StartMoving(Frm)
        GL(Frm)
        StopMoving(Frm)
    End Sub

    <Extension()> _
    Public Sub GoUp(ByVal Frm As Form)
        If IsMoving Then Exit Sub
        If Frm.Top = 1 Then Exit Sub
        StartMoving(Frm)
        GU(Frm)
        StopMoving(Frm)
    End Sub

#End Region

#Region "MoveToCornerGraphics"

    <Extension()> _
    Public Sub GoTopLeft(ByVal Frm As Form, Optional ByVal NotStatic As Boolean = False, Optional ByVal SidesFirst As Boolean = True)
        If IsMoving Then Exit Sub
        If Frm.Top = 1 And Frm.Left = 1 Then Exit Sub
        If UseBresenhamLineAlgorithm Then
            StartMoving(Frm)
            BresenhamFormMove(Frm, TypeOfMove.TopLeft)
            StopMoving(Frm)
        Else
            StartMoving(Frm)
            If NotStatic Then
                If SidesFirst Then
                    GL(Frm)
                    GU(Frm)
                Else
                    GU(Frm)
                    GL(Frm)
                End If
                StopMoving(Frm)
                Exit Sub
            End If
            Static X As Integer = 0
            X += 1
            Select Case X
                Case 1
                    GU(Frm)
                    GL(Frm)
                Case 2
                    GL(Frm)
                    GU(Frm)
                    X = 0
            End Select
            StopMoving(Frm)
        End If
    End Sub

    <Extension()> _
    Public Sub GoTopRight(ByVal Frm As Form, Optional ByVal NotStatic As Boolean = False, Optional ByVal SidesFirst As Boolean = True)
        If IsMoving Then Exit Sub
        If Frm.Top = 1 And Frm.Left = (My.Computer.Screen.WorkingArea.Width - Frm.Width) Then Exit Sub
        If UseBresenhamLineAlgorithm Then
            StartMoving(Frm)
            BresenhamFormMove(Frm, TypeOfMove.TopRight)
            StopMoving(Frm)
        Else
            StartMoving(Frm)
            If NotStatic Then
                If SidesFirst Then
                    GR(Frm)
                    GU(Frm)
                Else
                    GU(Frm)
                    GR(Frm)
                End If
                StopMoving(Frm)
                Exit Sub
            End If
            Static X As Integer = 0
            X += 1
            Select Case X
                Case 1
                    GU(Frm)
                    GR(Frm)
                Case 2
                    GR(Frm)
                    GU(Frm)
                    X = 0
            End Select
            StopMoving(Frm)
        End If
    End Sub

    <Extension()> _
    Public Sub GoBottomLeft(ByVal Frm As Form, Optional ByVal NotStatic As Boolean = False, Optional ByVal SidesFirst As Boolean = True)
        If IsMoving Then Exit Sub
        If Frm.Top = (My.Computer.Screen.WorkingArea.Height - Frm.Height) And Frm.Left = 1 Then Exit Sub
        If UseBresenhamLineAlgorithm Then
            StartMoving(Frm)
            BresenhamFormMove(Frm, TypeOfMove.BottomLeft)
            StopMoving(Frm)
        Else
            StartMoving(Frm)
            If NotStatic Then
                If SidesFirst Then
                    GL(Frm)
                    GD(Frm)
                Else
                    GD(Frm)
                    GL(Frm)
                End If
                StopMoving(Frm)
                Exit Sub
            End If
            Static X As Integer
            X += 1
            Select Case X
                Case 1
                    GD(Frm)
                    GL(Frm)
                Case 2
                    GL(Frm)
                    GD(Frm)
                    X = 0
            End Select
            StopMoving(Frm)
        End If
    End Sub

    <Extension()> _
    Public Sub GoBottomRight(ByVal Frm As Form, Optional ByVal NotStatic As Boolean = False, Optional ByVal SidesFirst As Boolean = True)
        If IsMoving Then Exit Sub
        If Frm.Top = (My.Computer.Screen.WorkingArea.Height - Frm.Height) And Frm.Left = (My.Computer.Screen.WorkingArea.Width - Frm.Width) Then Exit Sub
        If UseBresenhamLineAlgorithm Then
            StartMoving(Frm)
            BresenhamFormMove(Frm, TypeOfMove.BottormRight)
            StopMoving(Frm)
        Else
            StartMoving(Frm)
            If NotStatic Then
                If SidesFirst Then
                    GR(Frm)
                    GD(Frm)
                Else
                    GD(Frm)
                    GR(Frm)
                End If
                StopMoving(Frm)
                Exit Sub
            End If
            Static X As Integer
            X += 1
            Select Case X
                Case 1
                    GD(Frm)
                    GR(Frm)
                Case 2
                    GR(Frm)
                    GD(Frm)
                    X = 0
            End Select
            StopMoving(Frm)
        End If
    End Sub

#End Region

#Region "MakeSureItsAlignedOnScreen"

    <Extension()> _
    Public Sub StraightenMeEdges(ByVal Frm As Form, ByVal ShowGraphics As Boolean)
        Dim ScrWidth As Integer = My.Computer.Screen.WorkingArea.Width
        Dim ScrHeight As Integer = My.Computer.Screen.WorkingArea.Height
        If Not ShowGraphics Then
            If Frm.Left < 1 Then
                Frm.Left = 1
            End If
            If Frm.Top < 1 Then
                Frm.Top = 1
            End If
            If (Frm.Left + Frm.Width) > ScrWidth Then
                Frm.Left = (ScrWidth - Frm.Width)
            End If
            If (Frm.Top + Frm.Height) > ScrHeight Then
                Frm.Top = (ScrHeight - Frm.Height)
            End If
        Else
            If Not IsMoving Then
                If UseBresenhamLineAlgorithm Then
                    If Frm.TopLeft Then Frm.GoTopLeft()
                    If Frm.TopRight Then Frm.GoTopRight()
                    If Frm.BottomLeft Then Frm.GoBottomLeft()
                    If Frm.BottomRight Then Frm.GoBottomRight()
                Else
                    If Frm.Left < 1 Or Frm.Top < 1 Or (Frm.Left + Frm.Width) > ScrWidth Or (Frm.Top + Frm.Height) > ScrHeight Then
                        StartMoving(Frm)
                        If Frm.Left < 1 Then
                            GR(Frm, True)
                        End If
                        If Frm.Top < 1 Then
                            GD(Frm, True)
                        End If
                        If (Frm.Left + Frm.Width) > ScrWidth Then
                            GL(Frm, True)
                        End If
                        If (Frm.Top + Frm.Height) > ScrHeight Then
                            GU(Frm, True)
                        End If
                        StopMoving(Frm)
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "MoveFormOnLine"

    <Extension()> _
    Public Sub MoveFormOnALine(ByVal Frm As Form, ByVal DestinationX As Integer, ByVal DestinationY As Integer)
        If IsMoving Then Exit Sub
        If DestinationX = Frm.Left And DestinationY = Frm.Top Then Exit Sub
        StartMoving(Frm)
        'DDAFormMove(Frm, TypeOfMove.NoneUseTheFollowingCoordinates, Frm.Left, Frm.Top, DestinationX, DestinationY)
        BresenhamFormMove(Frm, TypeOfMove.NoneUseTheFollowingCoordinates, Frm.Left, Frm.Top, DestinationX, DestinationY)
        StopMoving(Frm)
    End Sub

#End Region

#End Region

#Region "PublicFunctions"

#Region "ClosestCornerDetection"

    <Extension()> _
    Public Function TopLeft(ByVal Frm As Form) As Boolean
        Dim Tp As Single = Frm.Top
        Dim Lt As Single = Frm.Left
        Dim TpPH As Single = Tp + (Frm.Height / 2)
        Dim LtPH As Single = Lt + (Frm.Width / 2)
        Dim SDH As Single = (My.Computer.Screen.WorkingArea.Height / 2)
        Dim SDW As Single = (My.Computer.Screen.WorkingArea.Width / 2)
        If LtPH < SDW And TpPH < SDH Then
            Return True
        Else
            Return False
        End If
    End Function

    <Extension()> _
    Public Function TopRight(ByVal Frm As Form) As Boolean
        Dim Tp As Single = Frm.Top
        Dim Lt As Single = Frm.Left
        Dim TpPH As Single = Tp + (Frm.Height / 2)
        Dim LtPH As Single = Lt + (Frm.Width / 2)
        Dim SDH As Single = (My.Computer.Screen.WorkingArea.Height / 2)
        Dim SDW As Single = (My.Computer.Screen.WorkingArea.Width / 2)
        If LtPH > SDW And TpPH < SDH Then
            Return True
        Else
            Return False
        End If
    End Function

    <Extension()> _
    Public Function BottomLeft(ByVal Frm As Form) As Boolean
        Dim Tp As Single = Frm.Top
        Dim Lt As Single = Frm.Left
        Dim TpPH As Single = Tp + (Frm.Height / 2)
        Dim LtPH As Single = Lt + (Frm.Width / 2)
        Dim SDH As Single = (My.Computer.Screen.WorkingArea.Height / 2)
        Dim SDW As Single = (My.Computer.Screen.WorkingArea.Width / 2)
        If LtPH < SDW And TpPH > SDH Then
            Return True
        Else
            Return False
        End If
    End Function

    <Extension()> _
    Public Function BottomRight(ByVal Frm As Form) As Boolean
        Dim Tp As Single = Frm.Top
        Dim Lt As Single = Frm.Left
        Dim TpPH As Single = Tp + (Frm.Height / 2)
        Dim LtPH As Single = Lt + (Frm.Width / 2)
        Dim SDH As Single = (My.Computer.Screen.WorkingArea.Height / 2)
        Dim SDW As Single = (My.Computer.Screen.WorkingArea.Width / 2)
        If LtPH > SDW And TpPH > SDH Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#End Region

#End Region

#Region "Pac Man"

    Public p As Point
    Private SR As Rectangle = My.Computer.Screen.WorkingArea
    Private PMDelay As Double = 0.1
    Public Property FormsList As New List(Of Form)

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Function SetCursorPos(ByVal X As Integer, ByVal Y As Integer) As Boolean
    End Function

    Public Sub TurnOnPacMan()
        For Each Frm As Form In FormsList
            AddHandler Frm.LocationChanged, AddressOf LocationChangedPacMan
        Next
    End Sub
    Public Sub TurnOffPacMan()
        For Each Frm As Form In TheBlackShellRunnerProject.Forms
            RemoveHandler Frm.LocationChanged, AddressOf LocationChangedPacMan
        Next
    End Sub
    Public Property PacManCornerDisplacement = 1
    Public MainForm As Form = Nothing

    Private Sub LocationChangedPacMan(ByVal sender As Object, ByVal e As EventArgs)
        p = System.Windows.Forms.Cursor.Position
        Dim pw As Integer = (SR.Width - (PacManCornerDisplacement + 1))
        Dim ph As Integer = (SR.Height - (PacManCornerDisplacement + 1))
        If p.X < 1 Then
            SetCursorPos(pw, p.Y)
        End If
        If p.Y < 1 Then
            SetCursorPos(p.X, ph)
        End If
        If p.X > pw Then
            SetCursorPos(PacManCornerDisplacement, p.Y)
        End If
        If p.Y > ph Then
            SetCursorPos(p.X, PacManCornerDisplacement)
        End If
        frmMain.cmbCmd.Refresh()
    End Sub

#End Region

End Module