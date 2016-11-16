Public Class frmHistory

#Region "NonEventMethods"

    Private Sub AddToLstCmds()
        Dim Cmd As String = cmbCmd.Text.TRM
        cmbCmd.Text = Cmd
        If cmbCmd.Text = "" Then Exit Sub
        AddLst(Cmd, frmMain.cmbCmd, True, , , False)
        AddLst(Cmd, lstCmds, False, , , False)
        With frmMain.cmbCmd
            .Items.Clear()
            .Text = cmbCmd.Text
        End With
        cmbCmd.Text = ""
        LoadLists()
    End Sub

    Private Sub RemoveFromLstCmds()
        On Error Resume Next
        cmbCmd.Text = cmbCmd.Text.TRM
        If Not cmbCmd.Text = lstCmds.Items(lstCmds.SelectedIndex) Then
            MessageBox.Show("This Command Does Not Exist In History Therefore It Cannot Be Removed." &
                   "Try Typing With Correct Spelling Of List Item Or Selecting The Item In " &
                   "The List By Clicking It And Then Removing It.", "BlackShellRunner Remove From History", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If cmbCmd.Text = frmMain.cmbCmd.Text Then frmMain.cmbCmd.Text = ""
        Dim LCmd As String = INIRead(INISettingsPath, "Settings", "LastCommand")
        If Not LCmd = "" Then
            If cmbCmd.Text = LCmd Then
                INIWrite(INISettingsPath, "Settings", "LastCommand", "")
            End If
        End If
        Dim ListItem As Integer = 0
        My.Computer.FileSystem.CreateDirectory(BinaryFileDirectoryPath)
        RmLst(lstCmds.SelectedItem, lstCmds, True)
        cmbCmd.Text = ""
        With frmMain
            If lstCmds.SelectedItem = .cmbCmd.Text Then
                .cmbCmd.Text = ""
                INIWrite(INISettingsPath, "Settings", "LastCommand", "")
            End If
        End With
        LoadLists()
    End Sub

    Private Sub LoadLists()
        LoadLst(lstCmds)
        With lstCmds
        End With
        LoadLst(cmbCmd)
        LoadLst(frmMain.cmbCmd)
    End Sub

    Private Sub ClearHistory()
        Dim copy = lstCmds.Items.OfType(Of String)().ToList()
        For Each item As String In copy
            RmLst(item, lstCmds, True)
        Next
        cmbCmd.Text = ""
        With frmMain
            .cmbCmd.Text = ""
        End With
        INIWrite(INISettingsPath, "Settings", "LastCommand", "")
        LoadLists()
    End Sub

#End Region

#Region "EventMethods"

    Private Sub frmHistory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadLists()
    End Sub

    Private Sub frmHistory_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LoadLists()
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub abAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abAdd.Click
        AddToLstCmds()
    End Sub

    Private Sub abRm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abRm.Click
        RemoveFromLstCmds()
    End Sub

    Private Sub abClear_Click(sender As System.Object, e As System.EventArgs) Handles abClear.Click
        ClearHistory()
    End Sub

    Private Sub abExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abExit.Click
        Hide()
    End Sub

    Private Sub abTest_Click(sender As System.Object, e As System.EventArgs) Handles abTest.Click
        TheBlackShellRunnerProject.RunCommand(cmbCmd.Text)
    End Sub

    Private Sub txtCmd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCmd.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) And LN(cmbCmd.Text) Then
            tmrAutoCom.Enabled = False
        Else
            tmrAutoCom.Enabled = True
        End If
        If e.KeyChar = Chr(Keys.Return) Then
            AddToLstCmds()
        End If
    End Sub

    Private Sub lstCmds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCmds.SelectedIndexChanged
        On Error Resume Next
        cmbCmd.Text = lstCmds.Items(lstCmds.SelectedIndex)
    End Sub

#End Region

End Class