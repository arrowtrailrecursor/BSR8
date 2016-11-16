Public Class frmEnvironmentCommands

    Public Complete As Boolean = False
    Public LastCommand As String = ""
    Public BuildingListForFirstBSRRunOnThisComputer As Boolean = False

    Private Sub abEnvironmet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abEnvironmet.Click
        If Not Complete Then MessageBox.Show("Wait until list is populated.", "Not ready to show environment varibles.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Do Until Complete
            Application.DoEvents()
        Loop
        frmEnvironmentVariables.Show()
    End Sub

    Private Sub rbPowerShell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPowerShell.CheckedChanged
        If rbPowerShell.Checked Then
            rbDOS.Checked = False
            INIWrite(INISettingsPath, "Settings", "ConsoleMode", "PowerShell")
        End If
        frmMain.SetIcon(True)
        frmMain.Refresh()
    End Sub

    Private Sub rbDOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDOS.CheckedChanged
        If rbDOS.Checked Then
            rbPowerShell.Checked = False
            INIWrite(INISettingsPath, "Settings", "ConsoleMode", "MS-DOS")
        End If
        frmMain.SetIcon(True)
        frmMain.Refresh()
    End Sub

    Private Sub Save()
        Dim idx As String
        Dim idx2 As String
        For i As Integer = 0 To cdMain.CheckedIndices.Count - 1
            idx &= (If(String.IsNullOrEmpty(idx), String.Empty, ",")) + Convert.ToString(cdMain.CheckedIndices(i))
        Next
        For i As Integer = 0 To cdMain.CheckedItems.Count - 1
            idx2 &= (If(String.IsNullOrEmpty(idx2), String.Empty, ",")) + cdMain.CheckedItems.Item(i).Text
        Next
        Settings.MakeSetting("EnvironmentIndices", idx)
        Settings.MakeSetting("FileNames", idx2)
    End Sub

    Private Sub frmConsoleDetective_Shown(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible And Not Complete Then
            With tmrFindingCommands
                .Enabled = True
                .Start()
                cdMain.BeginSearch()
                ' Complete = True
            End With
        End If
    End Sub

    Private Sub cdMain_SearchComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles cdMain.SearchComplete
        Dim a As String = ""
        If (Not String.IsNullOrEmpty(Settings.RetrieveSetting("EnvironmentIndices"))) Then
            Dim checkedIndicies() As String = Settings.RetrieveSetting("EnvironmentIndices").Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
            For i1 As Integer = 0 To checkedIndicies.Length - 1
                Dim idx As Integer
                If (Integer.TryParse(checkedIndicies(i1), idx)) AndAlso (cdMain.Items.Count >= (idx + 1)) Then
                    cdMain.Items.Item(idx).Checked = True
                    a += cdMain.Items.Item(idx).Text.LC & ","
                End If
            Next i1
        End If
        Complete = True
        tmrFindingCommands.Enabled = False
        tmrFindingCommands.Stop()
        Text = "Machine Level Environment Commands"
        Settings.MakeSetting("FilePaths", cdMain.EnvironmentPaths)
        Complete = True
    End Sub

    Private Sub tmrFindingCommands_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFindingCommands.Tick
        Static SearchTextCounter As Integer
        SearchTextCounter += 1
        If Not BuildingListForFirstBSRRunOnThisComputer Then
            Select Case SearchTextCounter
                Case 1
                    Text = "Finding Environment Commands |"
                Case 2
                    Text = "Finding Environment Commands /"
                Case 3
                    Text = "Finding Environment Commands -"
                Case 4
                    Text = "Finding Environment Commands \"
                    SearchTextCounter = 0
            End Select
        Else
            Select Case SearchTextCounter
                Case 1
                    Text = "Building Environment Commands List For First Launch On This Computer! PLEASE WAIT |"
                    alConsoleMode.ForeColor = Color.Gray
                Case 2
                    Text = "Building Environment Commands List For First Launch On This Computer! PLEASE WAIT /"
                    alConsoleMode.ForeColor = Color.DarkGray
                Case 3
                    Text = "Building Environment Commands List For First Launch On This Computer! PLEASE WAIT -"
                    alConsoleMode.ForeColor = Color.Gray
                Case 4
                    Text = "Building Environment Commands List For First Launch On This Computer! PLEASE WAIT \"
                    alConsoleMode.ForeColor = Color.DarkGray
                    SearchTextCounter = 0
            End Select
        End If
    End Sub

    Private Sub cdMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdMain.SelectedIndexChanged
        For Each item As ListViewItem In cdMain.SelectedItems
            If item.Text.CNT(".") And Not item.Text.CNT("..") Then
                txtSelected.Text = item.Text.SPT(".").First.LC
                If Complete Then
                    frmMain.SetIcon(True)
                    frmMain.Refresh()
                End If
            End If
            Exit Sub
        Next
    End Sub

    Private Sub abHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abHelp.Click
        If Not rbDOS.Checked And Not rbPowerShell.Checked Then
            MessageBox.Show("Please Select MS-DOS Or PowerShell To Show Help.", "Help With Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If rbDOS.Checked Then
            If txtSelected.Text.CNT(".") Then
                Shell("cmd.exe /k echo " & txtSelected.Text & "&&" & txtSelected.Text & " /?", AppWinStyle.NormalFocus)
            Else
                Shell("cmd.exe /k echo " & txtSelected.Text & "&&help " & txtSelected.Text, AppWinStyle.NormalFocus)
            End If
        ElseIf rbPowerShell.Checked Then
            If txtSelected.Text.CNT(".") Then
                Shell("powershell.exe -NoExit -Command " & Qt & "echo " & txtSelected.Text & "; " & txtSelected.Text & " -?" & Qt, AppWinStyle.NormalFocus)
            Else
                Shell("powershell.exe -NoExit -Command " & Qt & "echo " & txtSelected.Text & "; get-help " & txtSelected.Text & Qt, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub

    Private Sub abTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abTest.Click
        frmMain.cmbCmd.Text = txtSelected.Text & " " & txtParams.Text
        frmMain.Refresh()
    End Sub

    Private Sub abOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abOK.Click
        Hide()
    End Sub

    Private Sub Lblshp1_Click(sender As System.Object, e As System.EventArgs) Handles abCncl.Click
        frmMain.cmbCmd.Text = LastCommand
        Hide()
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub cdMain_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles cdMain.ItemChecked
        If Complete Then
            Save()
        End If
    End Sub
End Class