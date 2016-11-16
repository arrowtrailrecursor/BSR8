Public Class frmEnvironmentVariables

    Protected HasPATHChanged As Boolean = False
    Protected HasPATHEXTChanged As Boolean = False
    Protected retPth As String = ""
    Protected retPthExt As String = ""

    Private Sub frmEnvironment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvPATH.Columns(0).Width = lvPATH.Width
        lvPATHEXT.Columns(0).Width = lvPATHEXT.Width
    End Sub

    Private Sub LoadList()
        lvPATH.Items.Clear()
        lvPATHEXT.Items.Clear()
        'Dim retP As String = RunScript("[Environment]::GetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & "Machine" & Qt & ")")
        'Dim retPE As String = RunScript("[Environment]::GetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & "Machine" & Qt & ")")
        Dim retP As String = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine)
        Dim retPE As String = Environment.GetEnvironmentVariable("PATHEXT", EnvironmentVariableTarget.Machine)
        retPth = retP.RP(vbCrLf, "")
        retPthExt = retPE.RP(vbCrLf, "")
        If Not Settings.RetrieveSetting("AlreadySavedRevert") Then
            Settings.MakeSetting("RevertPath", retPth)
            Settings.MakeSetting("RevertPATHEXT", retPthExt)
            Settings.MakeSetting("AlreadySavedRevert", True)
        End If
        Dim PTHS() As String = retPth.SPT(";")
        Dim PTHEXTS() As String = retPthExt.SPT(";")
        lvPATH.Items.AddRange(PTHS.Select(Function(x) New ListViewItem(x)).ToArray)
        lvPATHEXT.Items.AddRange(PTHEXTS.Select(Function(x) New ListViewItem(x)).ToArray)
    End Sub

    Private Sub ApplyEnvironmentVariables()
        On Error Resume Next
        Dim itm1 As ListViewItem
        Dim itm2 As ListViewItem
        Dim ePth As String = ""
        Dim ePthExt As String = ""
        Dim PATHYesNo As System.Windows.Forms.DialogResult
        Dim PATHEXTYesNo As System.Windows.Forms.DialogResult
        Dim VarChanged As Boolean = False
        Dim WaitAndWantChange As String = " There will be a short wait to set the environment variable. ARE YOU ABSOLUTLY SURE YOU WISH TO CHANGE THIS?"
        If HasPATHChanged Then
            For Each itm1 In lvPATH.Items
                ePth += itm1.Text & ";"
            Next
            ePth = RSAtE(ePth, ";")
            PATHYesNo = MessageBox.Show("Path will change from " _
                                        & Qt &
                                        "Path=" & retPth _
                                        & Qt &
                                        " to " _
                                        & Qt &
                                        "Path=" & ePth _
                                        & Qt &
                                        WaitAndWantChange, "Path Change Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If PATHYesNo = DialogResult.Yes Then
                ' RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & ePth & Qt & ", " & Qt & "Machine" & Qt & ")")
                'RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & ePth & Qt & ", " & Qt & "User" & Qt & ")")
                'RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & ePth & Qt & ", " & Qt & "Process" & Qt & ")")
                Environment.SetEnvironmentVariable("Path", ePth, EnvironmentVariableTarget.Machine)
                Environment.SetEnvironmentVariable("Path", ePth, EnvironmentVariableTarget.User)
                Environment.SetEnvironmentVariable("Path", ePth, EnvironmentVariableTarget.Process)
                VarChanged = True
            End If
        End If
        If HasPATHEXTChanged Then
            For Each itm2 In lvPATHEXT.Items
                ePthExt += itm2.Text & ";"
            Next
            ePthExt = RSAtE(ePthExt, ";")
            PATHEXTYesNo = MessageBox.Show("PATHEXT will change from " _
                                           & Qt &
                                           "PATHEXT=" & retPthExt _
                                           & Qt &
                                           " to " _
                                           & Qt &
                                           "PATHEXT=" & ePthExt _
                                           & Qt &
                                           WaitAndWantChange, "PATHEXT Change prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If PATHEXTYesNo = DialogResult.Yes Then
                ' RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & ePthExt & Qt & ", " & Qt & "Machine" & Qt & ")")
                'RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & ePthExt & Qt & ", " & Qt & "User" & Qt & ")")
                'RunScript("[Environment]::SetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & ePthExt & Qt & ", " & Qt & "Process" & Qt & ")")
                Environment.SetEnvironmentVariable("PATHEXT", ePthExt, EnvironmentVariableTarget.Machine)
                Environment.SetEnvironmentVariable("PATHEXT", ePthExt, EnvironmentVariableTarget.User)
                Environment.SetEnvironmentVariable("PATHEXT", ePthExt, EnvironmentVariableTarget.Process)
                VarChanged = True
            End If
        End If
        Close()
        Dim HCYesNo As System.Windows.Forms.DialogResult
        If VarChanged Then
            HCYesNo = MessageBox.Show("Your Environment Variables Have Changed. Do you wish to reload environment commands?", "Environment Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If HCYesNo = DialogResult.Yes Then
                frmEnvironmentCommands.Complete = False
                frmEnvironmentCommands.Hide()
                frmEnvironmentCommands.Show()
            End If
        End If
    End Sub

    Private Sub abApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abApply.Click
        ApplyEnvironmentVariables()
    End Sub

    Private Sub RemoveFromListViewByName(ByVal ListView As ListView, ByVal TextToRemove As String)
        For Each item As ListViewItem In ListView.Items
            If item.Text = TextToRemove Then
                item.Remove()
                If ListView.Name = "lvPATH" Then HasPATHChanged = True
                If ListView.Name = "lvPATHEXT" Then HasPATHEXTChanged = True
                Exit For
            End If
        Next
    End Sub

    Private Sub abCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abCncl.Click
        Dim HaveChangedYesNo As DialogResult

        Hide()
    End Sub

    Protected Function isAlreadyInList(ByVal Item As String, ByVal listview As ListView) As Boolean
        For Each itm As ListViewItem In listview.Items
            If itm.Text.UC = Item.UC Then Return True
        Next
    End Function

    Protected Function CleanSlashAtEnd(ByVal DirPath As String) As String
        If RT(DirPath, 1) = "\" Then
            Return RSAtE(DirPath, "\")
        End If
        Return DirPath
    End Function

    Protected Function isSystemDirectory(ByVal Dir As String) As Boolean
        Dir = CleanSlashAtEnd(Dir)
        If Dir.UC Like "?:\WINDOWS\SYSTEM32" _
            Or Dir.UC Like "?:\WINDOWS" _
            Or Dir.UC Like "?:\WINDOWS\SYSTEM32\WBEM" _
            Or Dir.UC Like "?:\WINDOWS\SYSTEM32\WINDOWSPOWERSHELL\V1.0" Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Function isSystemExtension(ByVal Extension As String) As Boolean
        Dim SystemExts As String = ".COM;.EXE;.BAT;.CMD;.VBS;.VBE;.JS;.JSE;.WSF;.WSH;.MSC"
        Dim sEXTS() As String = SystemExts.SPT(";")
        For inx As Integer = 0 To sEXTS.GetUpperBound(0)
            If sEXTS(inx) = Extension.UC Then Return True
        Next
        Return False
    End Function

    Private Sub LblshpRemovePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblshpRemovePath.Click
        txtPATH.Text = txtPATH.Text.TRM
        If Not isAlreadyInList(txtPATH.Text, lvPATH) Then
            If isSystemDirectory(txtPATH.Text) Then
                MessageBox.Show("This is a system directory removing it could cause BlackShellRunner and Microsoft Windows to work in the wrong way. Path cannot be removed!",
                         "System Directory!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If Not txtPATH.Text = "" Then
            RemoveFromListViewByName(lvPATH, txtPATH.Text)
            txtPATH.Text = ""
        End If
    End Sub

    Private Sub abRemovePathExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abRemovePathExt.Click
        txtPATHEXT.Text = txtPATHEXT.Text.TRM
        If Not isAlreadyInList(txtPATHEXT.Text, lvPATHEXT) Then
            If isSystemExtension(txtPATHEXT.Text) Then
                MessageBox.Show("This is a system extension removing it could cause BlackShellRunner and Microsoft Windows to work in the wrong way. Extension cannot be removed!",
                         "System Extension!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If Not txtPATHEXT.Text = "" Then
            RemoveFromListViewByName(lvPATHEXT, txtPATHEXT.Text)
            txtPATHEXT.Text = ""
        End If
    End Sub

    Private Sub LblshpAddPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abAddPath.Click
        Dim inx As Integer = 0
        txtPATH.Text = txtPATH.Text.TRM
        If Not txtPATH.Text = "" Then
            If Not isAlreadyInList(txtPATH.Text, lvPATH) Then
                If PathExists(txtPATH.Text, TypeOfPath.Directory) Then
                    lvPATH.Items.Add(txtPATH.Text)
                    txtPATH.Text = ""
                    HasPATHChanged = True
                Else
                    MessageBox.Show("Directory that was going to be added does not exist!", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Cannot add path because it already exists in you Path list!", "Path Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub abAddPathExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abAddPathExt.Click
        Dim inx As Integer = 0
        txtPATHEXT.Text = txtPATHEXT.Text.TRM
        If Not txtPATHEXT.Text = "" Then
            If Not isAlreadyInList(txtPATHEXT.Text, lvPATHEXT) Then
                If txtPATHEXT.Text Like ".?*" Then
                    lvPATHEXT.Items.Add(txtPATHEXT.Text.UC)
                    txtPATHEXT.Text = ""
                    HasPATHEXTChanged = True
                Else
                    MessageBox.Show("Invalid path extension!", "Invalid Extension", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Cannot add path extension because it already exists in you PATHEXT list!", "Path Extension Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub abBrws_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abBrws.Click
        frmFolderDialog.isEnvironmentBrws = True
        If frmFolderDialog.Visible Then
            frmFolderDialog.Hide()
            Delay(1)
        End If
        frmFolderDialog.Show()
    End Sub

    Private Sub frmEnvironment_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Visible Then
            HasPATHChanged = False
            HasPATHEXTChanged = False
            LoadList()
        End If
    End Sub

    Private Sub lvPATH_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPATH.Resize
        lvPATH.Columns(0).Width = lvPATH.Width
    End Sub

    Private Sub lvPATHEXT_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPATHEXT.Resize
        lvPATHEXT.Columns(0).Width = lvPATHEXT.Width
    End Sub

    Private Sub lvPATH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPATH.SelectedIndexChanged
        For Each item As ListViewItem In lvPATH.SelectedItems
            txtPATH.Text = item.Text
            Exit Sub
        Next
    End Sub

    Private Sub lvPATHEXT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPATHEXT.SelectedIndexChanged
        For Each item As ListViewItem In lvPATHEXT.SelectedItems
            txtPATHEXT.Text = item.Text
            Exit Sub
        Next
    End Sub

    Private Sub abRevert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abRevert.Click
        If retPth = Settings.RetrieveSetting("RevertPath") And retPthExt = Settings.RetrieveSetting("RevertPATHEXT") Then
            MessageBox.Show("It appears as if your environment variables are already at the state they were in when you first opened this window. It would be a waste of time to revert.", "No Need To Revert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim PTHEXTS() As String
        Dim PTHS() As String
        If Not retPth = Settings.RetrieveSetting("RevertPath") Then
            lvPATH.Items.Clear()
            PTHS = Settings.RetrieveSetting("RevertPath").ToString.SPT(";")
            lvPATH.Items.AddRange(PTHS.Select(Function(x) New ListViewItem(x)).ToArray)
            HasPATHChanged = True
        End If
        If Not retPthExt = Settings.RetrieveSetting("RevertPATHEXT") Then
            lvPATHEXT.Items.Clear()
            PTHEXTS = Settings.RetrieveSetting("RevertPATHEXT").ToString.SPT(";")
            lvPATHEXT.Items.AddRange(PTHEXTS.Select(Function(x) New ListViewItem(x)).ToArray)
            HasPATHEXTChanged = True
        End If
        Dim ApplyYesNo As DialogResult = MessageBox.Show("You will need to apply these varibles before revert will take effect. Do you wish to do this now?", "Revert Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ApplyYesNo = DialogResult.Yes Then
            ApplyEnvironmentVariables()
        End If
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub abReboot_Click(sender As Object, e As EventArgs) Handles abReboot.Click
        Shell("shutdown -r")
    End Sub
End Class