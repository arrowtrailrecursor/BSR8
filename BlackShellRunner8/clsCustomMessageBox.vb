Public Class CustomMsg

    Public messageBox As New frmMessageBox

    Public Function BSRMsg(ByVal Title As String, ByVal Text As String, ByVal Buttons As MessageBoxButtons, ByVal Icon As MessageBoxIcon) As Integer
        clicked = False
        xcenter = (Screen.PrimaryScreen.WorkingArea.Width - messageBox.Width) / 2
        ycenter = (Screen.PrimaryScreen.WorkingArea.Height - messageBox.Height) / 2
        messageBox.Left = xcenter
        messageBox.Top = ycenter
        names.Clear()
        Select Case Buttons
            Case MessageBoxButtons.OK
                names.Add("Ok")
            Case MessageBoxButtons.OKCancel
                names.Add("Ok")
                names.Add("Cancel")
            Case MessageBoxButtons.YesNo
                names.Add("Yes")
                names.Add("No")
            Case MessageBoxButtons.AbortRetryIgnore
                names.Add("Abort")
                names.Add("Retry")
                names.Add("Ignore")
            Case MessageBoxButtons.RetryCancel
                names.Add("Retry")
                names.Add("Cancel")
            Case MessageBoxButtons.YesNoCancel
                names.Add("Yes")
                names.Add("No")
                names.Add("Cancel")
        End Select
        messageBox.ShowMsg(Text, Title)
        messageBox.ShowBtn()
        messageBox.ShowPic(Icon)
        messageBox.ShowDialog()
        clicked = False
        If result = "Ok" Then Return vbOK
        If result = "Yes" Then Return vbYes
        If result = "No" Then Return vbNo
        If result = "Cancel" Then Return vbCancel
        If result = "Abort" Then Return vbAbort
        If result = "Retry" Then Return vbRetry
        If result = "Ignore" Then Return vbIgnore
    End Function

End Class