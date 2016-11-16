'<-{-----------------------------------------------------}->
'<-{-Acid List Box William Stanley Davis 2015-}->
'<-{-----------------------------------------------------}->

Public Class AcidListBox

    'Inherits a .Net List Boxes Attributes
    Inherits System.Windows.Forms.ListBox

#Region "Enumerators"

    Private Enum DrawType
        Selected = 0
        Regular = 1
        SelectedShadow = 2
        RegularShadow = 3
        Focus = 4
    End Enum

#End Region
#Region "Static Variables"

#Region "Regular Static Variables"

    Private ScreenPoint As Point
    Private FocusText As String = ""

#End Region
#Region "Scroll Event Declaration"

    Public Event Scroll()
    Private components As System.ComponentModel.IContainer

#End Region
#Region "Parent Form"
#Region "ParentForm Declaration"

    Private ParentForm As Form

#End Region
#End Region
#Region "Property Static Variants"

    Private vBorderLineWidth As Integer = 2
    Private vFinalValue As Integer = 1
    Private vTextShadowDisplacement As Integer = 1
    Private vShadowDivisionFactor As Integer = 2
    Private vHasRoundedRectangle As Boolean = False
    Private vShiftOnClick As Boolean = False
    Private vMouseEnterShadow As Boolean = False
    Private vSelectedItemHasShadow As Boolean = True
    Private vShowExtenderToolTips = True
    Private vShadow As Boolean = False
    Private vSelectionForeColor As Color = Color.Green
    Private vSelectionBackColor As Color = Color.Lime
    Private vShadowColor As Color = Color.Green
    Private vShadowColorShift As Color = Color.Lime
    Private vForeColorShift As Color = Color.Green
    Private vForeColor As Color = Color.Lime
    Private vBackColor As Color = Color.Black
    Private vRegularShadowRectangleStyle As DashStyle = DashStyle.Solid
    Private vSelectedShadowRectangleStyle As DashStyle = DashStyle.Dash
    Private vSelectedItemFontStyle As FontStyle = FontStyle.Bold
    Private vSelectedRectangleStyle As DashStyle = DashStyle.Dash
    Private vRegularRectangleStyle As DashStyle = DashStyle.Solid
    Private vFocusRectangleStyle As DashStyle = DashStyle.Dot
    Private vListSelectedItemRectanglement As Boolean = False
    Private vQuantumItemRectanglement As Boolean = False

#End Region

#End Region
#Region "Properties"

#Region "Appearance Properties"

    <Category("Appearance")>
    Public Property SelectedItemFontStyle As FontStyle
        Get
            Return vSelectedItemFontStyle
        End Get
        Set(value As FontStyle)
            vSelectedItemFontStyle = value
            Invalidate()
        End Set
    End Property

#End Region
#Region "Rectangle Properties"

    <Category("Rectangle")>
    Public Property RegularShadowRectangleStyle As DashStyle
        Get
            Return vRegularRectangleStyle
        End Get
        Set(value As DashStyle)
            vRegularShadowRectangleStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property SelectedShadowRectangleStyle As DashStyle ' = DashStyle.Dash
        Get
            Return vSelectedShadowRectangleStyle
        End Get
        Set(value As DashStyle)
            vSelectedShadowRectangleStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property SelectedRectangleStyle As DashStyle
        Get
            Return vSelectedRectangleStyle
        End Get
        Set(value As DashStyle)
            vSelectedRectangleStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property RegularRectangleStyle As DashStyle
        Get
            Return vRegularRectangleStyle
        End Get
        Set(value As DashStyle)
            vRegularRectangleStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property FocusRectangleStyle As DashStyle
        Get
            Return vFocusRectangleStyle
        End Get
        Set(value As DashStyle)
            vFocusRectangleStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property ListSelectedItemRectanglement As Boolean
        Get
            Return vListSelectedItemRectanglement
        End Get
        Set(value As Boolean)
            vListSelectedItemRectanglement = value
            Invalidate()
        End Set
    End Property

    <Category("Rectangle")>
    Public Property QuantumItemRectanglement As Boolean
        Get
            Return vQuantumItemRectanglement
        End Get
        Set(value As Boolean)
            vQuantumItemRectanglement = value
            Invalidate()
        End Set
    End Property

#End Region
#Region "Color Properties"

    <Category("Color")>
    Public Property SelectionForeColor As Color
        Get
            Return vSelectionForeColor
        End Get
        Set(ByVal value As Color)
            vSelectionForeColor = value
        End Set
    End Property

    <Category("Color")>
    Public Property SelectionBackColor As Color
        Get
            Return vSelectionBackColor
        End Get
        Set(ByVal value As Color)
            vSelectionBackColor = value
        End Set
    End Property

    <Category("Color")>
    Public Property ShadowColor As Color
        Get
            Return vShadowColor
        End Get
        Set(value As Color)
            vShadowColor = value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Overrides Property ForeColor() As Color
        Get
            Return vForeColor
        End Get
        Set(ByVal value As Color)
            Try
                ToolTipComponent.ForeColor = value
            Catch ex As Exception
            End Try
            vForeColor = value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Overrides Property BackColor() As Color
        Get
            Return vBackColor
        End Get
        Set(ByVal value As Color)
            Try
                ToolTipComponent.BackColor = value
            Catch ex As Exception
            End Try
            vBackColor = value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Property ShiftShadowColor() As Color
        Get
            Return vShadowColorShift
        End Get
        Set(ByVal Value As Color)
            vShadowColorShift = Value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Property ShiftForeColor() As Color
        Get
            Return vForeColorShift
        End Get
        Set(ByVal value As Color)
            vForeColorShift = value
            Invalidate()
        End Set
    End Property

#End Region
#Region "ToolTip Properties"

    <Category("ToolTip")>
    Public Property ShowExtenderToolTips As Boolean
        Get
            Return vShowExtenderToolTips
        End Get
        Set(ByVal value As Boolean)
            vShowExtenderToolTips = value
        End Set
    End Property

#End Region
#Region "Shadow Properties"

    <Category("Shadow")>
    Public Property SelectedItemHasShadow As Boolean
        Get
            Return vSelectedItemHasShadow
        End Get
        Set(value As Boolean)
            vSelectedItemHasShadow = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public Property Shadow As Boolean
        Get
            Return vShadow
        End Get
        Set(value As Boolean)
            If value Then SelectedItemHasShadow = value
            Try
                ToolTipComponent.Shadow = value
            Catch ex As Exception
            End Try
            vShadow = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public ReadOnly Property ShadowDivisorFinalValue As Integer
        Get
            Return vFinalValue
        End Get
    End Property

    <Category("Shadow")>
    Public Property TextShadowDisplacement As Integer
        Get
            Return vTextShadowDisplacement
        End Get
        Set(value As Integer)
            vTextShadowDisplacement = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public Property ShadowDivisor As Integer
        Get
            Return vShadowDivisionFactor
        End Get
        Set(value As Integer)
            If value <= 1 Then value = 2
            If value > LineSize Then value = (LineSize - 1)
            vShadowDivisionFactor = value
            Invalidate()
        End Set
    End Property

#End Region
#Region "Mouse Effects Properties"

    <Category("Mouse Effects")>
    Public Property ShadowOnMouseEnter As Boolean
        Get
            Return vMouseEnterShadow
        End Get
        Set(value As Boolean)
            vMouseEnterShadow = value
            Invalidate()
        End Set
    End Property

    <Category("Mouse Effects")>
    <Description("Sets whether the forecolor and shadow color are toggled during a mouse click.")>
    Public Property ShiftOnClick As Boolean
        Get
            Return vShiftOnClick
        End Get
        Set(ByVal value As Boolean)
            vShiftOnClick = value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Border Properties"

    <Category("Border")>
    Public Property LineSize As Integer
        Get
            Return vBorderLineWidth
        End Get
        Set(value As Integer)
            If IsEven(vShadowDivisionFactor) Then
                If Not IsEven(value) Then
                    vFinalValue = value + 1
                End If
            Else
                If IsEven(value) Then
                    vFinalValue = value - 1
                End If
            End If
            vBorderLineWidth = value
            Invalidate()
        End Set
    End Property

    <Category("Border")>
    <Description("Sets Whether Text Will Be Resized With Control Resize")>
    Public Property HasRoundedRectangle As Boolean
        Get
            Return vHasRoundedRectangle
        End Get
        Set(value As Boolean)
            vHasRoundedRectangle = value
            Invalidate()
        End Set
    End Property

#End Region

#End Region
#Region "Methods"

    '\/---The Overrides Probably Are Not Even Needed Says Billy
#Region "Mouse and focus Overrides"

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        MyBase.OnLostFocus(e)
    End Sub

    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
    End Sub

    Protected Overrides Sub OnMouseHover(ByVal e As System.EventArgs)
        MyBase.OnMouseHover(e)
    End Sub

#End Region
#Region "DrawTheListBox"

    Private Sub DrawText(ByVal Text As String, ByVal e As System.Windows.Forms.DrawItemEventArgs, Type As DrawType)
        Dim SelectedFont As Font = New Font(e.Font.FontFamily, e.Font.Size, SelectedItemFontStyle)
        If Type = DrawType.Selected Or Type = DrawType.SelectedShadow Then
            'BackGround
            e.Graphics.FillRectangle(New SolidBrush(SelectionBackColor), e.Bounds)
        Else
            'BackGround
            e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
        End If
        If Items.Count > 0 Then
            Select Case Type
                Case DrawType.SelectedShadow
                    'Drop Shadow
                    e.Graphics.DrawString(Text, SelectedFont, New SolidBrush(BackColor), New Point(e.Bounds.X - 1, e.Bounds.Y - 1))
                    'The Text
                    e.Graphics.DrawString(Text, SelectedFont, New SolidBrush(SelectionForeColor), New Point(e.Bounds.X, e.Bounds.Y))
                Case DrawType.Selected
                    'The Text
                    e.Graphics.DrawString(Text, SelectedFont, New SolidBrush(SelectionForeColor), New Point(e.Bounds.X, e.Bounds.Y))
                Case DrawType.RegularShadow
                    'Drop Shadow
                    e.Graphics.DrawString(Text, e.Font, New SolidBrush(ShadowColor), New Point(e.Bounds.X - 1, e.Bounds.Y - 1))
                    'The Text
                    e.Graphics.DrawString(Text, e.Font, New SolidBrush(ForeColor), New Point(e.Bounds.X, e.Bounds.Y))
                Case DrawType.Regular
                    'The Text
                    e.Graphics.DrawString(Text, e.Font, New SolidBrush(ForeColor), New Point(e.Bounds.X, e.Bounds.Y))
            End Select
        End If
    End Sub

    Private Sub DrawRect(ByVal e As System.Windows.Forms.DrawItemEventArgs, Type As DrawType)
        Dim BoldedFont As Font = New Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold)
        Dim rec As Rectangle = New System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1)
        Dim p, p2 As Pen
        '  e.DrawBackground()
        Select Case Type
            Case DrawType.SelectedShadow
                'Drop Shadow
                p = New Pen(BackColor)
                p.DashStyle = SelectedShadowRectangleStyle
                e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width - 1, rec.Height - 1))
                'The Border
                p2 = New Pen(ForeColor)
                p2.DashStyle = SelectedRectangleStyle
                e.Graphics.DrawRectangle(p2, New Rectangle(rec.X + 1, rec.Y + 1, rec.Width - 1, rec.Height - 1))
            Case DrawType.Selected
                'The Border
                p = New Pen(ForeColor)
                p.DashStyle = SelectedRectangleStyle
                e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width, rec.Height))
            Case DrawType.RegularShadow
                'Drop Shadow
                p = New Pen(ShadowColor)
                p.DashStyle = RegularShadowRectangleStyle
                e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width - 1, rec.Height - 1))
                'The Border
                p2 = New Pen(ForeColor)
                p2.DashStyle = RegularRectangleStyle
                e.Graphics.DrawRectangle(p2, New Rectangle(rec.X + 1, rec.Y + 1, rec.Width - 1, rec.Height - 1))
            Case DrawType.Regular
                'The Border
                p = New Pen(ForeColor)
                p.DashStyle = RegularRectangleStyle
                If Not e.Index = (Items.Count - 1) Then
                    e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width, rec.Height + 1))
                Else
                    e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width, rec.Height))
                End If
            Case DrawType.Focus
                If Shadow Then
                    'Drop Shadow
                    DrawText(FocusText, e, DrawType.SelectedShadow)
                Else
                    'The Text
                    DrawText(FocusText, e, DrawType.Selected)
                End If
                If Shadow Then
                    'Drop Shadow
                    p = New Pen(BackColor)
                    p.DashStyle = FocusRectangleStyle
                    e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width - 1, rec.Height - 1))
                    'The Border
                    p2 = New Pen(ForeColor)
                    p2.DashStyle = FocusRectangleStyle
                    e.Graphics.DrawRectangle(p2, New Rectangle(rec.X + 1, rec.Y + 1, rec.Width - 1, rec.Height - 1))
                Else
                    'The Border
                    p = New Pen(ForeColor)
                    p.DashStyle = FocusRectangleStyle
                    e.Graphics.DrawRectangle(p, New Rectangle(rec.X, rec.Y, rec.Width, rec.Height))
                End If
        End Select
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_VSCROLL Then RaiseEvent Scroll()
        If m.Msg = WM_HSCROLL Then RaiseEvent Scroll()
        MyBase.WndProc(m)
        Select Case m.Msg
            Case &HF
                DrawTheBorder()
                MyBase.WndProc(m)
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub DrawTheBorder()
        Dim g As Graphics = CreateGraphics()
        Dim sf, lw, ww, hw, sw, sh, sx, sy, x, y, w, h As Integer
        Dim nsr, cr As Rectangle
        Dim p, sp As Pen
        Dim fc, sc As Color
        fc = ForeColor
        sc = ShadowColor
        cr = ClientRectangle
        sf = ShadowDivisor
        lw = LineSize
        ww = lw * sf
        hw = lw / sf
        If Not Shadow Then
            nsr = ClientRectangle
            With cr
                nsr.X = cr.X
                nsr.Y = cr.Y
                nsr.Width = cr.Width
                nsr.Height = cr.Height
            End With
            p = New Pen(fc, lw)
            'Regular Color Pen
            g.DrawRectangle(p, nsr)
        Else
            'Border Draw With Shadow
            With cr
                sx = .X
                sy = .Y
                sw = ((.Width - hw) + hw) - lw '((.Width - hw) + hw) - lw<-Tested an woks
                sh = ((.Height - hw) + hw) - lw
                x = (.X + hw) + hw
                y = (.Y + hw) + hw
                w = sw - hw
                h = sh - hw
            End With
            'Regular Color Pen
            p = New Pen(fc, lw)
            'Shadow Color Pen
            sp = New Pen(sc, lw)
            'Shadow
            g.DrawRectangle(sp, New Rectangle(sx, sy, sw, sh))
            'Regular
            g.DrawRectangle(p, New Rectangle(x, y, w, h))
        End If
    End Sub

    Private Sub MyColoredListBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        On Error Resume Next
        DrawTheBorder()
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim inx As String = 0
        Static Str As String
        If e.State = DrawItemState.Focus Then
            FocusText = Str
            DrawRect(e, DrawType.Focus)
            Str = ""
        Else
            FocusText = ""
        End If
        Static Pnt As Point
        Str = GetItemText(Items(e.Index))
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            Pnt = PointToScreen(New Point(e.Bounds.X, e.Bounds.Y))
            Dim BoldedFont As Font = New Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold)
            If Shadow Or SelectedItemHasShadow Then
                DrawText(Str, e, DrawType.SelectedShadow)
            Else
                DrawText(Str, e, DrawType.Selected)
            End If
            inx = e.Index
            If ListSelectedItemRectanglement Then
                If Shadow Or SelectedItemHasShadow Then
                    DrawRect(e, DrawType.SelectedShadow)
                Else
                    DrawRect(e, DrawType.Selected)
                End If
            End If
        Else
            If Shadow Then
                DrawText(Str, e, DrawType.RegularShadow)
            Else
                DrawText(Str, e, DrawType.Regular)
            End If
            If QuantumItemRectanglement Then
                If Shadow Then
                    DrawRect(e, DrawType.RegularShadow)
                Else
                    DrawRect(e, DrawType.Regular)
                End If
            End If
        End If
        DrawTheBorder()
        If vShowExtenderToolTips Then RefreshToolTipIndex(Pnt.X, Pnt.Y, Items(inx))
        With ClientRectangle
            Dim ScreenPoint = PointToScreen(.Location)
            If Pnt.Y < ScreenPoint.Y Then
                ToolTipComponent.Hide()
            End If
            If (Pnt.Y + ToolTipComponent.Height) > ScreenPoint.y + .Height Then
                ToolTipComponent.Hide()
            End If
        End With
    End Sub

#End Region
#Region "ToolTipMethods"

    Private Sub RefreshToolTipIndex(ByVal x As Integer, ByVal y As Integer, str As String)
        If ToolTipComponent.Visible Then
            ToolTipComponent.Hide()
        End If
        Using g As Graphics = CreateGraphics()
            Dim s As String = str
            Dim TextSize As SizeF = g.MeasureString(s, Font)
            If TextSize.Width > Width Then
                With ToolTipComponent
                    RaiseEvent ToolTipShown(Me, New EventArgs)
                    .ForeColor = SelectionForeColor
                    .BackColor = SelectionBackColor
                    .ShiftShadowColor = ForeColor
                    .ShiftForeColor = BackColor
                    .ShadowColor = BackColor
                    .SelectedItemFontStyle = SelectedItemFontStyle
                    .SelectedItemRectanglement = ListSelectedItemRectanglement
                    .RectangleStyle = SelectedRectangleStyle
                    .ShadowRectangleStyle = SelectedShadowRectangleStyle
                    .ShiftOnClick = ShiftOnClick
                    .Shadow = SelectedItemHasShadow
                    .Font = New Font(Font.FontFamily, Font.Size, FontStyle.Bold)
                    Dim TTSize As SizeF = g.MeasureString(s, .Font)
                    Dim FinalSize As Size = New Size(TTSize.Width + 2, TTSize.Height)
                    Dim ScreenRec As Rectangle = My.Computer.Screen.WorkingArea
                    If (x + FinalSize.Width) > ScreenRec.Right Then x = (ScreenRec.Width - FinalSize.Width)
                    .Size = FinalSize
                    .Text = s
                    .Location = New Point(x, y)
                    ttx = x
                    tty = y
                    .Show()
                    .BringToFront()
                End With
            End If
        End Using
    End Sub

#End Region
#Region "EventMethods"

#Region "Handled Event Methods"

    Private Sub AcidListBox_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        If ShadowOnMouseEnter Then
            Shadow = True
        End If
    End Sub

    Private Sub AcidListBox_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        If ShadowOnMouseEnter Then
            Shadow = False
        End If
    End Sub

    Private Sub AcidListBox_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        ResizeRedraw = True
    End Sub

    Private Sub AcidListBox_Scroll() Handles Me.Scroll
        Invalidate()
    End Sub

    Private Sub AcidListBox_ToolTipShown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ToolTipShown
        ParentForm = FindForm()
        AddHandler ParentForm.LocationChanged, AddressOf InvalidateTT
        AddHandler ParentForm.GotFocus, AddressOf InvalidateTT
        AddHandler ParentForm.VisibleChanged, AddressOf ParentVisibleTT
        AddHandler ParentForm.Deactivate, AddressOf HideTT
        AddHandler ParentForm.LostFocus, AddressOf HideTT
    End Sub

    Private Sub ParentVisibleTT()
        If Parent.Visible Then
            Invalidate()
        Else
            HideTT()
        End If
    End Sub

    Private Sub InvalidateTT()
        Invalidate()
    End Sub

    Private Sub HideTT()
        With ToolTipComponent
            If .Visible Then
                .Hide()
            End If
        End With
    End Sub

#End Region
#Region "Custom Events"

    Public Custom Event ToolTipShown As EventHandler

        AddHandler(ByVal value As EventHandler)
            Events.AddHandler("ToolTipShown", value)
        End AddHandler

        RemoveHandler(ByVal value As EventHandler)
            Events.RemoveHandler("ToolTipShown", value)
        End RemoveHandler

        RaiseEvent(ByVal sender As Object, ByVal e As System.EventArgs)
            CType(Events("ToolTipShown"), EventHandler).Invoke(sender, e)
        End RaiseEvent

    End Event

#End Region

#End Region
#Region "New Subroutine Method"

    Public Sub New()
        BorderStyle = Windows.Forms.BorderStyle.None
        IntegralHeight = False
        ResizeRedraw = True
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        SelectedItemHasShadow = True
    End Sub

#End Region

#End Region
#Region "Shift Color Handled Events"

    Private Sub Me_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If vShiftOnClick Then
            ForeColor = vForeColorShift
            ShadowColor = vShadowColorShift
        End If
    End Sub

    Public Sub Me_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If vShiftOnClick Then
            ForeColor = vShadowColorShift
            ShadowColor = vForeColorShift
        End If
    End Sub

    Private Sub Me_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        Me_MouseUp(sender, e)
    End Sub

    Private Sub Me_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        ForeColor = vForeColor
        ShadowColor = vShadowColor
    End Sub

#End Region

End Class