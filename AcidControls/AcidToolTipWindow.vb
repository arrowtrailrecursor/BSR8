'<-{----------------------------------------------------------------------------------------------------------------------------------}->
'<-{-Acid ToolTipWindowComponent For List And Combo Box Extender ToolTips William Stanley Davis 2015-}->
'<-{----------------------------------------------------------------------------------------------------------------------------------}->
Imports System.Security
Namespace ListComoBoxToolTip
    <SecuritySafeCritical>
    <System.ComponentModel.ToolboxItem(False)>
    Public Class cmpAcidToolTipWindow

        'Inherits The Attributes Of  A Plain Old .Net Control
        Inherits Control

#Region "Static Variables"

#Region "Property Values"

        Private vForeColor As Color = Color.Lime
        Private vBackColor As Color = Color.Black
        Private vHasBorder As Boolean = False
        Private vSelectedItemRectanglement As Boolean = False
        Private vShadow As Boolean = False
        Private vSelectedItemFontStyle As FontStyle = FontStyle.Bold
        Private vShadowColor As Color = Color.Green
        Private vShadowRectangleStyle As DashStyle = DashStyle.Dash
        Private vRectangleStyle As DashStyle = DashStyle.Dash
        Private vShiftOnClick As Boolean = False
        Private vShadowColorShift As Color = Color.Lime
        Private vForeColorShift As Color = Color.Black

#End Region
#Region "ToolTipWindowHandle"
        Private h As IntPtr = IntPtr.Zero
#End Region
#Region "Events Friends"
        Friend WithEvents tmrBringToolToTop As New System.Windows.Forms.Timer
#End Region

#End Region
#Region "Properties"

#Region "Overrides"

#Region "CreateParams"

        Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
            Get
                Dim p As CreateParams = MyBase.CreateParams
                p.ExStyle = p.ExStyle Or (WS_EX_NOACTIVATE Or WS_EX_TOOLWINDOW Or WS_EX_TOPMOST)
                p.Parent = IntPtr.Zero
                Return p
            End Get
        End Property

#End Region
#Region "Colors"

        Public Overrides Property ForeColor As Color
            Get
                Return vForeColor
            End Get
            Set(value As Color)
                vForeColor = value
                Invalidate()
            End Set
        End Property

        Public Overrides Property BackColor As Color
            Get
                Return vBackColor
            End Get
            Set(value As Color)
                vBackColor = value
                Invalidate()
            End Set
        End Property
#End Region

#End Region
#Region "Public"

#Region "Rectangle"

        Public Property ShadowRectangleStyle As DashStyle
            Get
                Return vShadowRectangleStyle
            End Get
            Set(value As DashStyle)
                vShadowRectangleStyle = value
                Invalidate()
            End Set
        End Property

        Public Property RectangleStyle As DashStyle
            Get
                Return vRectangleStyle
            End Get
            Set(value As DashStyle)
                vRectangleStyle = value
                Invalidate()
            End Set
        End Property

        Public Property SelectedItemRectanglement As Boolean
            Get
                Return vSelectedItemRectanglement
            End Get
            Set(value As Boolean)
                vSelectedItemRectanglement = value
                Invalidate()
            End Set
        End Property

#End Region
#Region "Color"

        Public Property ShadowColor As Color
            Get
                Return vShadowColor
            End Get
            Set(value As Color)
                vShadowColor = value
                Invalidate()
            End Set
        End Property

        Public Property ShiftShadowColor() As Color
            Get
                Return vShadowColorShift
            End Get
            Set(ByVal Value As Color)
                vShadowColorShift = Value
                Invalidate()
            End Set
        End Property

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
#Region "Font Style"

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
#Region "Shadow"

        Public Property Shadow As Boolean
            Get
                Return vShadow
            End Get
            Set(value As Boolean)
                vShadow = value
                Invalidate()
            End Set
        End Property

#End Region
#Region "Border"

        Public Property HasBorder As Boolean
            Get
                Return vHasBorder
            End Get
            Set(value As Boolean)
                vHasBorder = value
                Invalidate()
            End Set
        End Property

#End Region
#Region "Mouse"

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

#End Region

#End Region
#Region "Methods"

#Region "Regular Methods"

        Public Function MakeTopMost()
            Return SetWindowPos(h, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        End Function

        Public Function MakeNoTopMost()
            Return SetWindowPos(h, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        End Function

#End Region
#Region "Overloads Methods"
        <SecuritySafeCritical>
        Public Overloads Sub Show()
            If (Handle.Equals(IntPtr.Zero)) Then CreateControl()
            h = Handle
            If Not Visible Then SetParent(h, IntPtr.Zero)
            ShowWindow(h, 1)
            MakeTopMost()
        End Sub
        <SecuritySafeCritical>
        Public Overloads Sub Hide()
            h = Handle
            If Visible Then SetParent(h, IntPtr.Zero)
            MakeNoTopMost()
            ShowWindow(h, 0)
        End Sub

#End Region
#Region "Paint"
        <SecuritySafeCritical>
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            If String.IsNullOrEmpty(Text) Then Return
            Dim Style As FontStyle = SelectedItemFontStyle
            Dim TheFont As Font = New Font(Font.FontFamily, Font.Size, Style)
            Dim p1, p2 As Pen
            Dim pnt As Point = New Point(0, 0)
            Dim rec2 As Rectangle = New System.Drawing.Rectangle(0, 0, Width - 1, Height - 1)
            If Shadow Then
                e.Graphics.DrawString(Text, TheFont, New SolidBrush(ShadowColor), New Point(pnt.X - 1, pnt.Y - 1))
            End If
            e.Graphics.DrawString(Text, TheFont, New SolidBrush(ForeColor), New Point(pnt.X, pnt.Y))
            If SelectedItemRectanglement Then
                If Shadow Then
                    p1 = New Pen(ShadowColor)
                    p1.DashStyle = ShadowRectangleStyle
                    e.Graphics.DrawRectangle(p1, New Rectangle(rec2.X, rec2.Y, rec2.Width - 1, rec2.Height - 1))
                    p2 = New Pen(ForeColor)
                    p2.DashStyle = RectangleStyle
                    e.Graphics.DrawRectangle(p2, New Rectangle(rec2.X + 1, rec2.Y + 1, rec2.Width - 1, rec2.Height - 1))
                Else
                    p1 = New Pen(ForeColor)
                    p1.DashStyle = RectangleStyle
                    e.Graphics.DrawRectangle(p1, New Rectangle(rec2.X, rec2.Y, rec2.Width, rec2.Height))
                End If
            End If
            Cursor = Cursors.Hand
        End Sub

#End Region
#Region "Handled Event Methods"
        <SecuritySafeCritical>
        Private Sub tmrBringToolToTop_Tick(sender As Object, e As System.EventArgs) Handles tmrBringToolToTop.Tick
            MakeTopMost()
        End Sub
        <SecuritySafeCritical>
        Private Sub cmpToolTipWindow_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
            Hide()
        End Sub

#End Region

#End Region

#Region "Shift Color Handled Events"
        <SecuritySafeCritical>
        Private Sub Me_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
            If vShiftOnClick Then
                ForeColor = vForeColorShift
                ShadowColor = vShadowColorShift
            End If
        End Sub
        <SecuritySafeCritical>
        Public Sub Me_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If vShiftOnClick Then
                ForeColor = vShadowColorShift
                ShadowColor = vForeColorShift
            End If
        End Sub
        <SecuritySafeCritical>
        Private Sub Me_Click(sender As Object, e As System.EventArgs) Handles Me.Click
            If vShiftOnClick Then
                ForeColor = vForeColor
                ShadowColor = vShadowColor
            End If
        End Sub

#End Region
    End Class

End Namespace