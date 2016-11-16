'<-{----------------------------------------------------}->
'<-{-Acid ToolTip William Stanley Davis 2015-}->
'<-{----------------------------------------------------}->

Imports System.Security

<SecuritySafeCritical>
Public Class AcidToolTip

    'Inherits a .Net ToolTip Control
    Inherits System.Windows.Forms.ToolTip

#Region "Static Variables"

#Region "Regular Static Variants"

    Private Hwnd As System.IntPtr
    Private OpacityCount As Integer = 1

#End Region
#Region "Property Variants"

    Private vForeColor As Color = Color.Lime
    Private vBackColor As Color = Color.Black
    Private vFading As Boolean
    Property Font As Font = New Font("Arial", 8, FontStyle.Bold)
#End Region

#End Region
#Region "Properties"

    <Browsable(False)>
    Public Shadows Property UseFading As Boolean
        Get
            Return MyBase.UseFading
        End Get
        Set(ByVal value As Boolean)
            MyBase.UseFading = value
        End Set
    End Property

    Public Property UseTransparentFading As Boolean
        Get
            Return vFading
        End Get
        Set(ByVal value As Boolean)
            MyBase.UseFading = value
            UseFading = True
            vFading = value
        End Set
    End Property

    Public Overloads Property ForeColor() As Color
        Get
            Return vForeColor
        End Get
        Set(ByVal value As Color)
            vForeColor = value
        End Set
    End Property

    Public Overloads Property BackColor() As Color
        Get
            Return vBackColor
        End Get
        Set(ByVal value As Color)
            vBackColor = value
        End Set
    End Property

#End Region
#Region "Methods"

#Region "Handled Event Methods"
    Private Sub MyColoredToolTip_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles Me.Draw
        DrawToolTip(e)
    End Sub

    <SecuritySafeCritical>
    Private Sub tmrOpacity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOpacity.Tick
        Static OpacityCount As Integer = 0
        SetLayeredWindowAttributes(Hwnd, 0, OpacityCount, CUInt(LWA_ALPHA))
        OpacityCount += 1
        If OpacityCount = 255 Then
            OpacityCount = 1
            tmrOpacity.Enabled = False
            tmrOpacity.Stop()
        End If
    End Sub

#End Region
#Region "Regular Methods"
    Dim size As SizeF = New SizeF(0, 0)
    Private Sub DrawToolTip(ByVal e As System.Windows.Forms.DrawToolTipEventArgs)
        Dim i As Graphics = e.Graphics
        ' Dim lgb As LinearGradientBrush = New LinearGradientBrush(e.Bounds, Color.Red, Color.Green, LinearGradientMode.Horizontal)
        OpacityCount = 1
        tmrOpacity.Enabled = False
        tmrOpacity.Stop()
        Hwnd = GetToolTipHandle(Me)
        size = e.Graphics.MeasureString(e.ToolTipText, Font, e.Bounds.Width)
        i.FillRectangle(New SolidBrush(vBackColor), e.Bounds)
        Dim rect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height - 2)
        i.DrawRectangle(New Pen(New SolidBrush(vForeColor)), rect)
        If ToolTipTitle <> "" Then
            ' Dim myFontBold As New Font(e.Font.OriginalFontName, Font.SizeInPoints, FontStyle.Bold)
            i.DrawString(ToolTipTitle, Font, New SolidBrush(vForeColor), New Point(2, 2))
            Dim StringSize As New SizeF
            StringSize = e.Graphics.MeasureString(e.ToolTipText, Font)
            i.DrawString(e.ToolTipText, Font, New SolidBrush(vForeColor), New Point(6, StringSize.Height), StringFormat.GenericTypographic)
        Else
            i.DrawString(e.ToolTipText, Font, New SolidBrush(vForeColor), New Point(2, 2), StringFormat.GenericTypographic)
        End If
        If vFading Then
            tmrOpacity.Start()
        End If
    End Sub

    Public Shared Function GetToolTipHandle(ByVal ctrlToolTip As System.Windows.Forms.ToolTip) As IntPtr
        Dim obj As Object
        Dim hwnd As IntPtr
        Try
            hwnd = IntPtr.Zero
            obj = GetType(System.Windows.Forms.ToolTip).InvokeMember("Handle", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.GetProperty, Nothing, ctrlToolTip, Nothing)
            hwnd = CType(obj, IntPtr)
        Catch ex As Exception

        End Try
        Return hwnd
    End Function
    Public Enum SetWindowPosFlags As UInteger
        SWP_ASYNCWINDOWPOS = &H4000
        SWP_DEFERERASE = &H2000
        SWP_DRAWFRAME = SWP_FRAMECHANGED
        SWP_FRAMECHANGED = &H20
        SWP_HIDEWINDOW = &H80
        SWP_NOACTIVATE = &H10
        SWP_NOCOPYBITS = &H100
        SWP_NOMOVE = &H2
        SWP_NOOWNERZORDER = &H200
        SWP_NOREDRAW = &H8
        SWP_NOREPOSITION = SWP_NOOWNERZORDER
        SWP_NOSENDCHANGING = &H400
        SWP_NOSIZE = &H1
        SWP_NOZORDER = &H4
        SWP_SHOWWINDOW = &H40
    End Enum

    'Note: Cats these values to IntPtr
    Public Enum SpecialWindowHandles
        HWND_TOP = 0
        HWND_BOTTOM = 1
        HWND_TOPMOST = -1
        HWND_NOTOPMOST = -2
    End Enum
    Public Sub SetToolTipPosition(ByVal x As Integer, ByVal y As Integer)
        Dim hwnd = GetToolTipHandle(Me)
        Try 'SWP_NOSIZE)
            SetWindowPos(hwnd, IntPtr.Zero, x, y, 0, 0, SetWindowPosFlags.SWP_NOSIZE)
        Catch
        End Try
    End Sub

#End Region

#End Region

    Private Sub AcidToolTip_Popup(sender As Object, e As PopupEventArgs) Handles Me.Popup
        Dim Text As String = GetToolTip(e.AssociatedControl)
        Dim TTSize As Size = TextRenderer.MeasureText(Text, Font)
        e.ToolTipSize = New Size(TTSize.Width, TTSize.Height + (Font.Size / 2)) ' = New Size(size.Width, size.Height)
    End Sub
End Class