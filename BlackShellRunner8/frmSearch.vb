Public Class frmSearch

    Dim SearchTextCounter As Integer = 0
    Public LastCommand As String = ""

    Private Sub abSrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abSrch.Click
        On Error Resume Next
        tmrSearchText.Enabled = True
        If abSrch.Text = "Search" Then
            abSrch.Text = "Stop"
            dsMain.Cursor = Cursors.WaitCursor
            dsMain.SearchPath = txtPth.Text
            dsMain.SearchPattern = txtPttn.Text
            dsMain.BeginSearch()
        Else
            dsMain.StopSearch()
            abSearchingDir.Text = "Searching Directory > Not started yet."
        End If
    End Sub

    Private Sub abOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOk.Click
        frmMain.cmbCmd.Text = txtSlctd.Text
        If Not frmCustomCommads.cmbCstCmds.Text.TRM = "" Then frmCustomCommads.cmbCstCmdsCmds.Text = txtSlctd.Text
        Hide()

    End Sub

    Private Sub abCncl_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles abCncl.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Hide()
        End If
    End Sub

    Private Sub abCncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abCncl.Click
        Hide()

        frmMain.cmbCmd.Text = LastCommand
    End Sub

    Private Sub abBrws_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abBrws.Click
        frmFolderDialog.isEnvironmentBrws = False
        If frmFolderDialog.Visible Then
            frmFolderDialog.Hide()
            Delay(1)
        End If
        frmFolderDialog.Show()
    End Sub

    Private Sub tmrSearchText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSearchText.Tick
        SearchTextCounter += 1
        Select Case SearchTextCounter
            Case 1
                Text = "Searching | Found " & dsMain.Items.Count & " files so far. Please Wait!"
            Case 2
                Text = "Searching / Found " & dsMain.Items.Count & " files so far. Please Wait!"
            Case 3
                Text = "Searching - Found " & dsMain.Items.Count & " files so far. Please Wait!"
            Case 4
                Text = "Searching \ Found " & dsMain.Items.Count & " files so far. Please Wait!"
                SearchTextCounter = 0
        End Select
        abSearchingDir.Text = "Searching Directory > " & dsMain.CurrentlySearchingDirectory
    End Sub

    Private Sub abPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abPause.Click
        If abSrch.Text = "Stop" Then
            If abPause.Text = "Pause" Then
                abPause.Text = "Resume"
                tmrSearchText.Enabled = False
                SearchTextCounter = 0
                Text = "Paused"
                dsMain.Cursor = Cursors.Hand
                dsMain.SearchPause = True
            Else
                abPause.Text = "Pause"
                tmrSearchText.Enabled = True
                dsMain.Cursor = Cursors.WaitCursor
                dsMain.SearchPause = False
            End If
        End If
    End Sub

    Private Sub frmSrch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPth.Text = "C:\"
        LastCommand = frmMain.cmbCmd.Text
    End Sub

    Private Sub dsMain_SearchComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles dsMain.SearchComplete
        tmrSearchText.Enabled = False
        tmrSearchText.Stop()
        abSrch.Text = "Search"
        abSearchingDir.Text = "Search Complete Found " & dsMain.Items.Count & " Files"
        Text = "Search Complete Found " & dsMain.Items.Count & " Files"
        If dsMain.Items.Count > 0 Then
            dsMain.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub dsMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dsMain.SelectedIndexChanged
        Dim itm As ListViewItem
        For Each itm In dsMain.SelectedItems
            txtSlctd.Text = itm.Text
            frmMain.cmbCmd.Text = itm.Text
        Next
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

End Class