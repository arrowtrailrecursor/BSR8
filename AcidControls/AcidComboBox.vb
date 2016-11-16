'<-{-------------------------------------------}->
'<-{-Acid Combo Box William Stanley Davis 2015-}->
'<-{-------------------------------------------}->

Imports System.Security

<SecuritySafeCritical>
Public Class AcidComboBox

    'Inherits a .Net Combo Box's Attributes
    Inherits System.Windows.Forms.ComboBox

#Region "Enumerators"

    Private Enum DrawType
        Selected = 0
        Regular = 1
        SelectedShadow = 2
        RegularShadow = 3
    End Enum

    Private Enum ScrollBarDirection
        SB_HORZ = 0
        SB_VERT = 1
        SB_CTL = 2
        SB_BOTH = 3
    End Enum

    Private Enum ScrollInfoMask
        SIF_RANGE = &H1
        SIF_PAGE = &H2
        SIF_POS = &H4
        SIF_DISABLENOSCROLL = &H8
        SIF_TRACKPOS = &H16
        SIF_ALL = SIF_RANGE + SIF_PAGE + SIF_POS + SIF_TRACKPOS
    End Enum

#End Region
#Region "Static Variables"

#Region "Draw Brushes"

    Private BorderBrush As Brush = New SolidBrush(ForeColor)
    Private ArrowBrush As Brush = New SolidBrush(BackColor)

#End Region
#Region "Property Static Variants"

    Private vEnterCharacterClipBoardPasteJoiner As String = " "
    Private vArrowKeysDropList As Boolean = True
    Private vShowExtenderToolTips As Boolean = False
    Private vShiftOnClick As Boolean = False
    Private vMouseEnterShadow As Boolean = False
    Private vShadow As Boolean = False
    Private vListSelectedItemRectanglement As Boolean = False
    Private vQuantumItemRectanglement As Boolean = False
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

#End Region
#Region "Regular Static Private Variants"

    Private ListRECT As RECT
    Private LParam As System.IntPtr
    Private Ipos As Integer
    Private components As IContainer

#End Region
#Region "Scroll Event Declarations"

    Public Event VerticalScroll()
    Public Event ScrollUp()
    Public Event ScrollDown()

#End Region
#Region "Event Friend Timer"

    Friend WithEvents tmrScroll As Timer

#End Region

#End Region
#Region "Properties"

#Region "Rectangle Properties"

    <Category("Rectangle")>
    Public Property RegularShadowRectangleStyle As DashStyle
        Get
            Return vRegularRectangleStyle
        End Get
        Set(value As DashStyle)
            vRegularRectangleStyle = value
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
#Region "Shadow Properties"

    <Category("Shadow")>
    Public Property Shadow As Boolean
        Get
            Return vShadow
        End Get
        Set(value As Boolean)
            SelectedItemHasShadow = value
            vShadow = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public Property SelectedItemHasShadow As Boolean = True

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
#Region "Appearance Properties"

    <Category("Appearance")>
    Public Property SelectedItemFontStyle As FontStyle = FontStyle.Regular

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
#Region "Input Properties"

    <Category("User Input")>
    Public Property AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown As Boolean = True

    <Category("User Input")>
    Public Property PasteMultilineJoiningCharacter As String
        Get
            Return vEnterCharacterClipBoardPasteJoiner
        End Get
        Set(ByVal value As String)
            vEnterCharacterClipBoardPasteJoiner = value
        End Set
    End Property

    <Category("User Input")>
    Public Property ArrowKeysDropList As Boolean
        Get
            Return vArrowKeysDropList
        End Get
        Set(ByVal value As Boolean)
            vArrowKeysDropList = value
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

#End Region
#Region "Methods"

#Region "New Dispose Subroutine Methods"

    Public Sub New()
        FlatStyle = Windows.Forms.FlatStyle.Popup
        IntegralHeight = False
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

#End Region
#Region "Override Methods"

#Region "Mouse and focus Overrides"

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        BorderBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        If Focused Then Exit Sub
        BorderBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        MyBase.OnLostFocus(e)
        BorderBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        BorderBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(ByVal e As System.EventArgs)
        MyBase.OnMouseHover(e)
        BorderBrush = New SolidBrush(ForeColor)
        Invalidate()
    End Sub

#End Region

#End Region
#Region "Regular Private Methods"

    Private Sub RefreshToolTipIndex(ByVal x As Integer, ByVal y As Integer, str As String)
        If ToolTipComponent.Visible Then
            ToolTipComponent.Hide()
        End If
        Using g As Graphics = CreateGraphics()
            Dim s As String = str
            Dim TextSize As SizeF = g.MeasureString(s, Font)
            If TextSize.Width > Width Then
                With ToolTipComponent
                    .ForeColor = SelectionForeColor
                    .BackColor = SelectionBackColor
                    .ShadowColor = BackColor
                    .ShadowColor = BackColor
                    .SelectedItemFontStyle = SelectedItemFontStyle
                    .SelectedItemRectanglement = ListSelectedItemRectanglement
                    .RectangleStyle = SelectedRectangleStyle
                    .ShadowRectangleStyle = SelectedShadowRectangleStyle
                    .Shadow = SelectedItemHasShadow
                    .Font = New Font(Font.FontFamily, Font.Size, FontStyle.Bold)
                    Dim TTSize As SizeF = g.MeasureString(s, .Font)
                    Dim FinalSize As Size = New Size(TTSize.Width + 2, TTSize.Height + 2)
                    Dim ScreenRec As Rectangle = My.Computer.Screen.WorkingArea
                    If (x + FinalSize.Width) > ScreenRec.Right Then x = (ScreenRec.Width - FinalSize.Width)
                    .Size = FinalSize
                    .Text = s
                    .Location = New Point(x, y)
                    .Show()
                End With
            End If
        End Using
    End Sub

    Private Sub RepositionListWidthAndHeight()
        RepositionListWidth()
        RepositionListHeight()
    End Sub

    Private Sub RepositionListWidth()
        If Not ShowExtenderToolTips Then
            Dim itemwdt As Integer = 0
            Dim currentwdt As Integer = 0
            Dim finalWdt As Integer = Width
            For Each item As String In Items
                itemwdt = TextRenderer.MeasureText(item, Font).Width
                If itemwdt > currentwdt Then
                    currentwdt = itemwdt
                    finalWdt = itemwdt
                End If
            Next
            DropDownWidth = finalWdt
        Else
            DropDownWidth = Width
        End If
    End Sub
    <SecuritySafeCritical>
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case &HF
                draw()
            Case WM_VSCROLL
            Case WM_CTLCOLORLISTBOX
                Dim dropHeight As Integer = 0
                Dim topOfDropDown As Integer = 0
                Dim leftOfDropDown As Integer = 0
                Dim left As Integer = PointToScreen(New Point(0, 0)).X
                If DropDownWidth > Screen.PrimaryScreen.WorkingArea.Width - left Then
                    Dim comboRect As Rectangle = RectangleToScreen(ClientRectangle)
                    dropHeight = 0
                    Static i As Integer = 0
                    Do While (i < Items.Count) AndAlso (i < MaxDropDownItems)
                        dropHeight += ItemHeight
                        i += 1
                    Loop
                    If dropHeight < Screen.PrimaryScreen.WorkingArea.Height - PointToScreen(New Point(0, 0)).Y Then
                        topOfDropDown = comboRect.Top - dropHeight - 2
                    Else
                        topOfDropDown = comboRect.Bottom
                    End If
                    leftOfDropDown = comboRect.Left - (DropDownWidth - (Screen.PrimaryScreen.WorkingArea.Width - left))
                    SetWindowPos(m.LParam, IntPtr.Zero, leftOfDropDown, topOfDropDown, 0, 0, SWP_NOSIZE)
                End If
                LParam = m.LParam
                GetWindowRect(LParam, ListRECT)
                MyBase.WndProc(m)
            Case Else
        End Select
    End Sub

    Private Sub draw()
        'Draw Border
        Dim g As Graphics = CreateGraphics()
        Dim nsr, cr As Rectangle
        Dim p, sp As Pen
        Dim fc, sc As Color
        fc = ForeColor
        sc = ShadowColor
        cr = ClientRectangle
        nsr = ClientRectangle
        p = New Pen(fc, 1)
        sp = New Pen(sc, 1)
        Dim ButtonRect As Rectangle = New Rectangle(Width - 18, 0, 17, Height)
        If Not Shadow Then
            p.Width = 2
            sp.Width = 2
            'Regular Color Pen
            g.DrawRectangle(p, New Rectangle(nsr.X, nsr.Y, nsr.Width, nsr.Height))
            g.FillRectangle(New SolidBrush(ForeColor), ButtonRect)
        Else
            p.Width = 2 '() ' = New Pen(fc, 2)
            sp.Width = 2 ' = New Pen(sc, 2)
            g.SmoothingMode = SmoothingMode.HighQuality
            'Shadow
            g.FillRectangle(New SolidBrush(BackColor), cr)
            Dim rw As Integer = ((nsr.Width - 2) - ButtonRect.Width)
            Dim rh As Integer = ((nsr.Height - 2))
            g.DrawRectangle(sp, New Rectangle(nsr.X, nsr.Y, rw, rh))
            'Regular
            g.DrawRectangle(p, New Rectangle(nsr.X + 1, nsr.Y + 1, rw, rh))
            g.FillRectangle(New SolidBrush(ForeColor), New Rectangle(ButtonRect.X, ButtonRect.Y, ButtonRect.Width, ButtonRect.Height))
        End If

        'Draw the background of the dropdown button
        'g.FillRectangle(DropButtonBrush, ButtonRect)
        'Create the path for the arrow
        Dim pth As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim TopLeft As PointF = New PointF(Width - 13, (Height - 5) / 2)
        Dim TopRight As PointF = New PointF(Width - 6, (Height - 5) / 2)
        Dim Bottom As PointF = New PointF(Width - 9, (Height + 2) / 2)
        pth.AddLine(TopLeft, TopRight)
        pth.AddLine(TopRight, Bottom)
        ArrowBrush = New SolidBrush(BackColor)
        g.SmoothingMode = SmoothingMode.HighQuality
        'Draw the arrow
        g.FillPath(ArrowBrush, pth)
    End Sub

    Private Sub DrawListBound()
        Dim g As Graphics = CreateGraphics()
        Dim p2 As Pen = New Pen(ForeColor, 2)
        Dim rect As Rectangle = Bounds
        g.DrawRectangle(p2, rect)
    End Sub

    Private Sub SetCursor(Optional ByVal ResetToDefault As Boolean = False)
        Cursor = Nothing
        If ResetToDefault Then
            Cursor = Cursors.Default
        Else
            Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub DrawText(ByVal Text As String, ByVal e As System.Windows.Forms.DrawItemEventArgs, Type As DrawType)
        Dim SelectedFont As Font = New Font(e.Font.FontFamily, e.Font.Size, SelectedItemFontStyle)
        If Type = DrawType.Selected Or Type = DrawType.SelectedShadow Then
            'BackGround
            e.Graphics.FillRectangle(New SolidBrush(SelectionBackColor), e.Bounds)
        Else
            'BackGround
            e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
        End If
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
                '  End If
        End Select
    End Sub

    Private Sub DrawRect(ByVal e As System.Windows.Forms.DrawItemEventArgs, Type As DrawType)
        Dim rec As Rectangle = New System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1)
        Dim p, p2 As Pen
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
        End Select
    End Sub

    Private Sub SetComboText(ByVal Text As String)
        If Not Text.TRM = "" Then
            SelectedItem = Text
        End If
    End Sub

    Private Sub RepositionListHeight()
        Dim ItmHgt As Integer = ItemHeight + 2
        Dim DrpHgt As Integer = 0
        If Items.Count > MaxDropDownItems Then
            DrpHgt = (ItmHgt * MaxDropDownItems)
        Else
            DrpHgt = (ItmHgt * (Items.Count + 1))
        End If
        DropDownHeight = DrpHgt
        'This jus makes sure it don't leave a long blank list says Billy upon a clearing
        If Items.Count = 0 Or Items.Count = 1 Then
            DropDownHeight = ItmHgt
        End If
    End Sub

#End Region
#Region "Handled Event Methods"

    Private Sub Me_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DropDownClosed
        If ToolTipComponent IsNot Nothing And ToolTipComponent.Visible Then ToolTipComponent.Hide()
        SetCursor(True)
    End Sub

    <SecuritySafeCritical>
    Private Sub cmpMyColoredCombo_DropDown(sender As Object, e As System.EventArgs) Handles Me.DropDown
        Dim Pnt As Point
        If AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown Then
            Pnt = PointToScreen(ClientRectangle.Location)
            SetCursorPos(Pnt.X + (ClientRectangle.Width / 2), Pnt.Y + (ClientRectangle.Height / 2))
        End If
        SetCursor(False)
    End Sub

    Private Sub MyColoredCombo_HandleCreated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.GotFocus
        MaxDropDownItems = 100
        RepositionListWidthAndHeight()
    End Sub

    Private Sub MyColoredCombo_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        ResizeRedraw = True
    End Sub

    Private Sub MyColoredCombo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Refresh()
    End Sub

    Private Sub tmrScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScroll.Tick
        If LParam.ToString <> "" Then
            Dim si As New SCROLLINFO
            With si
                .fMask = ScrollInfoMask.SIF_POS
            End With
            Dim lRet As Integer = GetScrollInfo(LParam, ScrollBarDirection.SB_VERT, si)
            If lRet = True Then
                If Ipos <> si.nPos Then
                    RaiseEvent VerticalScroll()
                End If
                If Ipos < si.nPos Then
                    RaiseEvent ScrollDown()
                End If
                If Ipos > si.nPos Then
                    RaiseEvent ScrollUp()
                End If
                Ipos = si.nPos
            End If
        End If
    End Sub

    Private Sub MyColoredCombo_ScrollUp() Handles Me.ScrollUp
        If SelectedIndex > ((Items.Count - 1) / 2) Then
            ToolTipComponent.Hide()
        End If
    End Sub

    Private Sub MyColoredCombo_ScrollDown() Handles Me.ScrollDown
        If SelectedIndex < ((Items.Count - 1) / 2) Then
            ToolTipComponent.Hide()
        End If
    End Sub

    Private Sub MyColoredCombo_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        On Error Resume Next
        e.DrawBackground()
        ' e.DrawFocusRectangle
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim inx As String = 0
        Dim Str As String = GetItemText(Items(e.Index))
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            If Shadow Or SelectedItemHasShadow Then
                DrawText(Str, e, DrawType.SelectedShadow)
            Else
                DrawText(Str, e, DrawType.Selected)
            End If
            GetWindowRect(LParam, ListRECT)
            x = ListRECT.Left
            y = ListRECT.Top + (ItemHeight * e.Index + 1)
            inx = e.Index
            If ListSelectedItemRectanglement Then
                If Shadow Or SelectedItemHasShadow Then
                    DrawRect(e, DrawType.SelectedShadow)
                Else
                    DrawRect(e, DrawType.Selected)
                End If
            End If
            SetComboText(Items.Item(inx))
            If ShowExtenderToolTips Then
                RefreshToolTipIndex(x, y, Items(inx))
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

    Private Sub Me_MouseFocus(sender As Object, e As System.EventArgs) Handles Me.MouseEnter, Me.GotFocus
        RepositionListHeight()
    End Sub

    Private Sub cmpMyColoredCombo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim Key As Integer
        If ArrowKeysDropList Then
            Key = e.KeyCode
            If Key = Keys.Down Or Key = Keys.Up Then 'UP,DOWN
                If DroppedDown Then
                    Exit Sub
                End If
                Dim inx As Integer
                Try
                    inx = SelectedIndex
                Catch ex As IndexOutOfRangeException
                End Try
                RepositionListWidthAndHeight()
                DroppedDown = True
                If Items.Count > 0 Then
                    If Not inx = 0 Then
                        SelectedIndex = inx
                    Else
                        SelectedIndex = 0
                    End If
                End If
            ElseIf Key = Keys.Left Or Key = Keys.Right Or Key = Keys.Enter Then 'LEFT,RIGHT,ENTER
                DroppedDown = False
                SelectionLength = 0
                'Selection Start Is Not Needed here cause it will stop the arrow keys from moving the carat
            End If
        End If
    End Sub

#End Region
#Region "Shift Color Handled Events"

    Private Sub Me_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        On Error Resume Next
        If e.Button = Windows.Forms.MouseButtons.Left And vShiftOnClick Then
            ForeColor = vForeColorShift
            ShadowColor = vShadowColorShift
            Refresh()
        End If
        Dim lhWnd As IntPtr = FindWindowEx(Handle, IntPtr.Zero, "EDIT", Nothing)
        If e.Button = Windows.Forms.MouseButtons.Right And lhWnd <> 0 Then
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
    End Sub

    Public Sub Me_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If vShiftOnClick Then
            ForeColor = vShadowColorShift
            ShadowColor = vForeColorShift
            Refresh()
        End If
    End Sub

    Private Sub Me_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        If vShiftOnClick Then
            ForeColor = vForeColor
            ShadowColor = vShadowColor
            Refresh()
        End If
    End Sub

    Private Sub Me_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        ForeColor = vForeColor
        ShadowColor = vShadowColor
        Refresh()
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        '
        'AcidComboBox
        '
        ResumeLayout(False)

    End Sub
#End Region

#End Region

End Class