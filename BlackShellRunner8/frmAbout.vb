Public Class frmAbout

    Protected Sub frmAbout_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        alSMDExample.Text = alSMDExample.Text.RP("%|%", frmMain.CommandLineSeparator)
        alBSRCmds.Text = alBSRCmds.Text.RP("%|%", frmMain.CommandLineSeparator)
    End Sub

End Class
