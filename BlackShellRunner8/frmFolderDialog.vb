Public Class frmFolderDialog
    Public Shared isEnvironmentBrws As Boolean = False

    Private Sub FolderView_NodeClick(ByVal sender As Object, ByVal e As LogicNP.FolderViewControl.FolderViewEventArgs) Handles FolderView.NodeClick
        On Error Resume Next
        If Not e.Node.Path Like "*{*}*" Then
            txtDir.Text = e.Node.Path
        Else
            txtDir.Text = ""
        End If
    End Sub

    Private Sub abOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOk.Click
        If Not isEnvironmentBrws Then
            frmSearch.txtPth.Text = txtDir.Text
        Else
            frmEnvironmentVariables.txtPATH.Text = txtDir.Text
        End If
        Hide()

    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

End Class