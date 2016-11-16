Public Class frmOutput
    Dim isClosed As Boolean = False
    Protected Declare Function ShowWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    Protected Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer

    Private Sub abOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOK.Click
        Close()
    End Sub

    Private Sub frmOutput_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        isClosed = True
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub Me_MouseMove(sender As Object, e As System.EventArgs) Handles abBorder.MouseMove, txtOutput.MouseMove, abOK.MouseMove
        BringToFront()
    End Sub

End Class