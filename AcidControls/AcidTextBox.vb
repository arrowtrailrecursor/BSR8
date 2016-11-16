'<-{------------------------------------------------------}->
'<-{-Acid Text Box William Stanley Davis 2015-}->
'<-{------------------------------------------------------}->

Public Class AcidTextBox

    'Inherits a .Net TextBox Control
    Inherits System.Windows.Forms.TextBox

#Region "Static Variables"
#Region "Regular Static Variants"

    Private ForeColorBrush As Brush

#End Region
#Region "Static Property Variants"

    Private vText As String = ""
    Private vShadowColor As Color = Color.Green
    Private vShadow As Boolean = False
    Private vShadowDivisionFactor As Integer = 2
    Private vBorderLineWidth As Integer = 2
    Private vFinalValue As Integer = 1
    Private vShiftOnClick As Boolean = False
    Private vShadowColorShift As Color
    Private vForeColorShift As Color
    Private vMouseEnterShadow As Boolean = False
    Private vForeColor As Color
    Private vBackColor As Color
    Private vEnterCharacterClipBoardPasteJoiner As String = " "

#End Region
#Region "Static Event Declarations"

    Event Scroll()

#End Region
#End Region
#Region "Properties"

#Region "Overload Properties"

    <Browsable(False)>
    Public Overloads Property BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Set(ByVal value)
            MyBase.BorderStyle = value
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
#Region "Color"

    <Category("Color")>
    Public Overrides Property ForeColor() As Color
        Get
            Return vForeColor
        End Get
        Set(ByVal value As Color)
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

#End Region
#Region "Shadow"

    <Category("Shadow")>
    Public Property Shadow As Boolean
        Get
            Return vShadow
        End Get
        Set(value As Boolean)
            vShadow = value
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
#Region "Border"

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

#End Region
#Region "Input Properties"
    <Category("User Input")>
    Public Property PasteMultilineJoiningCharacter As String
        Get
            Return vEnterCharacterClipBoardPasteJoiner
        End Get
        Set(ByVal value As String)
            vEnterCharacterClipBoardPasteJoiner = value
        End Set
    End Property
#End Region

#End Region
#Region "Methods"
#Region "New Subroutine Method"

    Public Sub New()
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ForeColor = Color.Lime
        ForeColorBrush = New SolidBrush(ForeColor)
        BackColor = Color.Black
        ShiftForeColor = Color.Green
        ShiftShadowColor = Color.Lime
    End Sub

#End Region
#Region "Regular Draw Subroutine Method"
    Private Sub draw()
        Dim g As Graphics = CreateGraphics()
        Dim sf, lw, ww, hw, sw, sh, sx, sy, x, y, w, h As Integer
        Dim nsr, cr As Rectangle
        Dim p, sp As Pen
        'Dim bcb As Brush = New SolidBrush(BackColor)
        Dim fc, sc As Color
        fc = ForeColor
        sc = ShadowColor
        cr = ClientRectangle
        sf = ShadowDivisor
        lw = LineSize
        ww = lw * sf
        hw = lw / sf
        'g.FillRectangle(bcb, cr)
        If Not Shadow Then
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
#End Region
#Region "Handled Event Methods"

    Private Sub MyColoredText_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ResizeRedraw = True
    End Sub

    Private Sub MyColoredText_Scroll() Handles Me.Scroll
        Invalidate()
    End Sub

    Private Sub Me_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        If ShadowOnMouseEnter Then
            Shadow = True
        End If
    End Sub

    Private Sub Me_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        If ShadowOnMouseEnter Then
            Shadow = False
        End If
    End Sub
#End Region
#Region "Overrides Methods"
#Region "WndProc Subroutine Override"

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_VSCROLL Then RaiseEvent Scroll()
        If m.Msg = WM_HSCROLL Then RaiseEvent Scroll()
        MyBase.WndProc(m)
        Select Case m.Msg
            Case &HF
                draw()
            Case Else
                Exit Select
        End Select
    End Sub

#End Region
#Region "Mouse and focus Overrides"
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        ForeColorBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        If Focused Then Exit Sub
        ForeColorBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        MyBase.OnLostFocus(e)
        ForeColorBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        ForeColorBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(ByVal e As System.EventArgs)
        MyBase.OnMouseHover(e)
        ForeColorBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub
#End Region
#End Region
#Region "Shift Color Handled Events"

    Private Sub Me_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If vShiftOnClick Then
            ForeColor = vForeColorShift
            ShadowColor = vShadowColorShift
        End If
        If Not Multiline Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim Str() As String = Clipboard.GetText.SPT(vbCrLf)
                Dim All As String = ""
                For inx As Integer = 0 To Str.GetUpperBound(0)
                    All += TRM(Str(inx)) & vbCrLf
                Next
                All = All.RSAtE(vbCrLf)
                Dim SepText As String = vEnterCharacterClipBoardPasteJoiner
                Dim Converted As String = All.RP(vbCrLf, SepText).RSAtE(SepText).RSAtF(SepText)
                Clipboard.SetText(Converted)
            End If
        End If
    End Sub

    Public Sub Me_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If vShiftOnClick Then
            ForeColor = vShadowColorShift
            ShadowColor = vForeColorShift
        End If
    End Sub

    Private Sub Me_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        If vShiftOnClick Then
            ForeColor = vForeColor
            ShadowColor = vShadowColor
        End If
    End Sub

#End Region
#End Region

End Class