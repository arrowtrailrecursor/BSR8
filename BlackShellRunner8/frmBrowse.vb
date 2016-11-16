Public Class frmBrowse
    Public LastCommand As String = ""

    ' Protected Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    FolderView.FileView = FileView
    'End Sub

    Protected Sub abOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOK.Click
        If txtFile.Text.TRM <> "" Then frmMain.cmbCmd.Text = txtFile.Text
        Hide()
    End Sub

    Protected Sub abCncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abCncl.Click
        frmMain.cmbCmd.Text = LastCommand
        Hide()
    End Sub

    Protected Sub FolderView_AfterSelect(ByVal sender As System.Object, ByVal e As LogicNP.FolderViewControl.FolderViewEventArgs) Handles FolderView.AfterSelect
        If Not e.Node.Path Like "*{*}*" Then
            txtFile.Text = e.Node.Path
            frmMain.cmbCmd.Text = e.Node.Path
        Else
            txtFile.Text = ""
        End If
    End Sub

    Protected Sub FileView_AfterSelectionChange(ByVal sender As System.Object, ByVal e As LogicNP.FileViewControl.FileViewEventArgs) Handles FileView.AfterSelectionChange
        If Not e.Item.Path Like "*{*}*" Then
            txtFile.Text = e.Item.Path
            frmMain.cmbCmd.Text = e.Item.Path
        Else
            txtFile.Text = ""
        End If
    End Sub

    Protected Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

End Class