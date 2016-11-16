Public Class frmMain
    Private Sub abReload_Click(sender As Object, e As EventArgs) Handles abReload.Click
        ReloadBSR()
    End Sub

    Private Sub abSave_Click(sender As Object, e As EventArgs) Handles abSave.Click
        WriteINI()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadINI()
    End Sub

    Private Sub abSaveReload_Click(sender As Object, e As EventArgs) Handles abSaveReload.Click
        WriteINI()
        ReloadBSR()
    End Sub

    Private Sub abExit_Click(sender As Object, e As EventArgs) Handles abExit.Click
        Application.Exit()
    End Sub

    Private Sub ReadINI()
        Try
            txtINI.Text = IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BSR_DIR\BSR_INI\BSR_CFG.INI")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WriteINI()
        IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BSR_DIR\BSR_INI\BSR_CFG.INI", txtINI.Text)
    End Sub

    Private Sub ReloadBSR()
        For Each p As Process In Process.GetProcesses
            If p.ProcessName.Contains("BlackShellRunner") Then p.Kill() 'Billy Davis says the contains is needed for debugging while executing from Visual Studio
        Next
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\BlackShellRunner.exe")
    End Sub

End Class
