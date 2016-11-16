Public Class TheBlackShellRunnerProject

    Public Shared Forms As New List(Of Form)
    Public Shared ColoredToolTips As New List(Of AcidControls.AcidToolTip)

    Public Shared Sub RunCommand(ByVal Command As String)
        With frmMain
            clsExecuteCommand.AddToTheCommandsList = False
            .cmbCmd.Text = Command.TRM
            .Run()
            clsExecuteCommand.AddToTheCommandsList = True
        End With
    End Sub

End Class