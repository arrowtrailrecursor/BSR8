Imports System.IO
Imports IWshRuntimeLibrary
Imports Microsoft.Win32
Imports Shell32

Public Class frmOptions

    Private Sub picShadowColor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShadowColor.Click
        Dim chk As Boolean = chkPic.Checked
        If chkPic.Enabled And chk Then chkPic.Checked = False
        Dim Res As DialogResult = colPicker.ShowDialog()
        If Res = Windows.Forms.DialogResult.OK Then
            picShadowColor.BackColor = colPicker.Color
            SaveColors(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
            ColorFormsAndControls(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
        End If
        chkPic.Checked = chk
        Refresh()
    End Sub
    Private Sub picForeColor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picForeColor.Click
        Dim chk As Boolean = chkPic.Checked
        If chkPic.Enabled And chk Then chkPic.Checked = False
        Dim Res As DialogResult = colPicker2.ShowDialog()
        If Res = Windows.Forms.DialogResult.OK Then
            picForeColor.BackColor = colPicker2.Color
            SaveColors(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
            ColorFormsAndControls(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
        End If
        chkPic.Checked = chk
        Refresh()
    End Sub

    Private Sub picBackColor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBackColor.Click
        Dim chk As Boolean = chkPic.Checked
        If chkPic.Enabled And chk Then chkPic.Checked = False
        Dim Res As DialogResult = colPicker3.ShowDialog()
        If Res = Windows.Forms.DialogResult.OK Then
            picBackColor.BackColor = colPicker3.Color
            SaveColors(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
            ColorFormsAndControls(picForeColor.BackColor, picBackColor.BackColor, picShadowColor.BackColor)
        End If
        chkPic.Checked = chk
        Refresh()
    End Sub

    Private Sub abOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOk.Click
        Hide()
    End Sub

    Private Sub abHstry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abHstry.Click
        frmHistory.Show()
    End Sub

    Private Sub abCstCmds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abCstCmds.Click
        frmCustomCommads.Show()
    End Sub

    Private Sub chkGraphics_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphics.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "Graphics", chkGraphics.Checked)
        modGraphics.HasGraphics = chkGraphics.Checked
        If Not chkGraphics.Checked Then
            tbGraphicStrength.Enabled = False
        Else
            tbGraphicStrength.Enabled = True
        End If
    End Sub

    Private Sub chkSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSound.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "Sound", chkSound.Checked)
        SetSounds(chkSound.Checked)
    End Sub

    Private Sub chkSnap_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkSnap.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "SnapToCorners", chkSnap.Checked)
        Static oldp As Point
        If chkSnap.Checked Then
            oldp = frmMain.Location
            Dim w As Integer = (My.Computer.Screen.WorkingArea.Width - frmMain.Width)
            Dim h As Integer = (My.Computer.Screen.WorkingArea.Height - frmMain.Height)
            If frmMain.TopLeft Then frmMain.Location = New Point(0, 0)
            If frmMain.TopRight Then frmMain.Location = New Point(w, 0)
            If frmMain.BottomLeft Then frmMain.Location = New Point(0, h)
            If frmMain.BottomRight Then frmMain.Location = New Point(w, h)
        Else
            frmMain.Location = oldp
        End If
    End Sub

    Private Sub chkShowCorner_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkShowCorner.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "ShowCornerGrid", chkShowCorner.Checked)
    End Sub

    Private Sub frmOptns_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tbTransparency.Value = (Opacity * 100)
        tbGraphicStrength.Value = modGraphics.BaseSleepTime
        tbSpeed.Value = modGraphics.MoveSpeed
    End Sub

    Private Sub abAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub tbTransparency_ValueChanged(sender As Object, e As System.EventArgs) Handles tbTransparency.ValueChanged
        If Visible Then ' < = This is important to stop setting opacity to 100% in Properties SetOpacity() Method
            INIWrite(INISettingsPath, "Settings", "OpacityPercent", tbTransparency.Value)
            SetOpacity()
            Opacity = Convert.ToDouble(Convert.ToInt32(INIRead(INISettingsPath, "Settings", "OpacityPercent")) / 100)
        End If
    End Sub

    Private Sub tbTransparency_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbTransparency.MouseUp
        abTrans.Text = "^ " & tbTransparency.Value & "% Opacity ^"
        Delay(1.5)
        abTrans.Text = "^ Transparency ^"
    End Sub

    Private Sub tbSpeed_ValueChanged(sender As Object, e As System.EventArgs) Handles tbSpeed.ValueChanged
        modGraphics.MoveSpeed = tbSpeed.Value
        If Visible Then INIWrite(INISettingsPath, "Settings", "MoveSpeed", tbSpeed.Value)
    End Sub

    Private Sub tbSpeed_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles tbSpeed.MouseUp
        abMoveSpeed.Text = "^ " & (tbSpeed.Value * 100) & "  Pixels  Per  Sec. ^"
        Delay(1.5)
        abMoveSpeed.Text = "^ Window  Move  Speed ^"
    End Sub

    Private Sub tbGraphicStrength_ValueChanged(sender As Object, e As System.EventArgs) Handles tbGraphicStrength.ValueChanged
        modGraphics.BaseSleepTime = tbGraphicStrength.Value
        If Visible Then INIWrite(INISettingsPath, "Settings", "GraphicStrength", tbGraphicStrength.Value)
    End Sub

    Private Sub tbGraphicStrength_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbGraphicStrength.MouseUp
        abGraphicStrength.Text = "100 Moves Per " & 0.1 * tbGraphicStrength.Value & " Sec."
        Delay(1.5)
        abGraphicStrength.Text = "^ Command Graphic Strength ^"
    End Sub

    'setvalue
    Public Sub RunAtStartup(ByVal ApplicationName As String, ByVal ApplicationPath As String)
        On Error Resume Next
        If Not Visible Then Exit Sub
        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath.RSAtE(".EXE") & ".exe")
    End Sub

    'remove value
    Public Sub RemoveValue(ByVal ApplicationName As String)
        On Error Resume Next
        If Not Visible Then Exit Sub
        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
    End Sub

    Private Sub chkDOSPause_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDOSPause.CheckedChanged
        If chkDOSPause.Checked Then
            frmMain.chkPws.Visible = False
            frmMain.alDOSPause.Visible = False
            frmMain.chkPws.Checked = False
        Else
            frmMain.chkPws.Visible = True
            frmMain.alDOSPause.Visible = True
        End If
        If Visible Then INIWrite(INISettingsPath, "Settings", "MS-DOS_PauseCheckNotVisible", chkDOSPause.Checked)
    End Sub

    Private Sub chkStartHidden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartHidden.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "StartHidden", chkStartHidden.Checked)
    End Sub

    Private Sub chkClassicHide_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkClassicHide.CheckedChanged
        If Visible Then INIWrite(INISettingsPath, "Settings", "ClassicHideMode", chkClassicHide.Checked)
    End Sub

    Private Sub chkRunAtStartUp_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRunAtStartUp.CheckedChanged
        If chkRunAtStartUp.Checked Then
            If Not frmMain.IgnoreFlashRunAtStartUp Then
                If FlashDirectory Then
                    MessageBox.Show("BlackShellRunner has detected you are using the settings from your U3 flash drive. You can not run BlackShellRunner at startup this way unless your flash drive is inserted. If you wish to have this program run at startup close BlackShellRunner.exe then copy BlackShellRunner.exe from your U3 CD-ROM disk image and all Settings files from BSR_DRIVE to the same folder on your hard drive, and then run BlackShellRunner.exe from your hard drive.", "U3 Flash Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkRunAtStartUp.Checked = False
                    Exit Sub
                End If
            End If
            RunAtStartup("BlackShellRunner", TheFlashOrRegularDirectoryPath & "\" & "BlackShellRunner.exe """"")
        Else
            RemoveValue("BlackShellRunner")
        End If
        If Visible Then INIWrite(INISettingsPath, "Settings", "RunAtStartUp", chkRunAtStartUp.Checked)
    End Sub
    Public Sub CreateShortcutInStartUp(ByVal Descrip As String)
        Dim WshShell As WshShell = New WshShell()
        Dim ShortcutPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(System.IO.Path.Combine(ShortcutPath, Application.ProductName) & ".lnk"), IWshShortcut)
        Shortcut.TargetPath = Application.ExecutablePath
        Shortcut.WorkingDirectory = Application.StartupPath
        Shortcut.Description = Descrip
        Shortcut.Save()
    End Sub

    Public Sub DeleteStartupFolderShortcuts(ByVal targetExeName As String)
        Dim startUpFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        Dim di As New DirectoryInfo(startUpFolderPath)
        Dim files() As FileInfo = di.GetFiles("*.lnk")

        For Each fi As FileInfo In files
            Dim shortcutTargetFile As String = GetShortcutTargetFile(fi.FullName)

            If shortcutTargetFile.EndsWith(targetExeName, StringComparison.InvariantCultureIgnoreCase) Then
                System.IO.File.Delete(fi.FullName)
            End If
        Next fi
    End Sub
    Private Sub rbFileSystem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFileSystem.CheckedChanged
        If rbFileSystem.Checked Then
            rbListItems.Checked = False
            If Visible Then INIWrite(INISettingsPath, "Settings", "AutoCompleteMode", "File")
            frmMain.cmbCmd.AutoCompleteSource = AutoCompleteSource.FileSystem
            frmMain.cmbCmd.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub
    Public Function GetShortcutTargetFile(ByVal shortcutFilename As String) As String
        Dim pathOnly As String = IO.Path.GetDirectoryName(shortcutFilename)
        Dim filenameOnly As String = IO.Path.GetFileName(shortcutFilename)
        Dim shell As Shell32.Shell = New Shell32.ShellClass()
        Dim folder As Shell32.Folder = shell.NameSpace(pathOnly)
        Dim folderItem As Shell32.FolderItem = folder.ParseName(filenameOnly)
        If folderItem IsNot Nothing Then
            Dim link As Shell32.ShellLinkObject = CType(folderItem.GetLink, Shell32.ShellLinkObject)
            Return link.Path
        End If
        Return String.Empty ' Not found
    End Function
    Private Sub rbListItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbListItems.CheckedChanged
        If rbListItems.Checked Then
            rbFileSystem.Checked = False
            If Visible Then INIWrite(INISettingsPath, "Settings", "AutoCompleteMode", "List")
            frmMain.cmbCmd.AutoCompleteSource = AutoCompleteSource.ListItems
            frmMain.cmbCmd.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub abConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abConsole.Click
        frmEnvironmentCommands.LastCommand = frmMain.cmbCmd.Text
        frmEnvironmentCommands.Show()
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub PicBackPic_Click(sender As Object, e As EventArgs) Handles PicBackPic.Click
        ofdPic.InitialDirectory = GifDirectory
        ofdPic.ShowDialog()
        frmMain.BringToFront()
    End Sub


    'Private Po As Integer = 0
    Private Sub tbPicOpacity_Scroll(sender As Object, e As EventArgs) Handles tbPicOpacity.ValueChanged, tbPicOpacity.MouseUp
        For Each Form As Form In WindowDecoration.FormAnimationLayerForms
            Form.Opacity = (tbPicOpacity.Value / 100)
        Next
        If Visible And Not tbPicOpacity.Value = 100 Then
            '   If Not tbPicOpacity.Value = 0 Then Po = tbPicOpacity.Value
            INIWrite(INISettingsPath, "Settings", "BackgroundTransparency", tbPicOpacity.Value)
        End If
    End Sub

    Dim ListOVisForm As New List(Of frmWithAniAndITSmod)

    Private Sub ofdPic_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPic.FileOk
        '
        'Dim Result As DialogResult = MessageBox.Show("This will disable basic command execution screen graphics for BlackShellRunner. Continue?",
        '                                             "Screen Graphics Prompt",
        'MessageBoxButtons.YesNo,
        'MessageBoxIcon.Question)
        'If Result = DialogResult.Yes Then
        PicturePath = ofdPic.FileName
        SetBackGroundAnimation(PicturePath)
        'End If
    End Sub

    Private Sub chkPic_CheckedChanged(sender As Object, e As EventArgs) Handles chkPic.CheckedChanged
        If chkPic.Enabled Then
            If chkPic.Checked Then
                SetFormAnimation(PicturePath, Opacity, tbPicOpacity.Value / 100, True)
                For Each form As frmWithAniAndITSmod In FormAnimationLayerForms
                    form.BringToFront()
                Next
                For Each form As Form In TheBlackShellRunnerProject.Forms
                    If form.Visible Then
                        form.Hide()
                        form.Show()
                    End If
                    form.BringToFront()
                Next
            Else
                DisposeOfDecorationForms()
            End If
            INIWrite(INISettingsPath, "Settings", "HasBackground", chkPic.Checked)
        End If
    End Sub

    Private Sub abMakeShellExtension_Click(sender As Object, e As EventArgs) Handles abMakeShellExtension.Click
        frmMain.MakeAllKeysAndExtensions()
    End Sub

    Private Sub abINI_Click(sender As Object, e As EventArgs) Handles abINI.Click
        Dim ExecuteRetVal As Integer = clsExecuteCommand.ShellExecute(0&, "open", My.Application.Info.DirectoryPath & "\BSR_INI_Editor.exe", Nothing, Nothing, AppWinStyle.NormalFocus)
        '  Dim ExecuteRetVal As Integer = clsExecuteCommand.ShellExecute(0&, "open", INISettingsPath, Nothing, Nothing, AppWinStyle.NormalFocus)
        ' Application.Exit()
    End Sub

    Private Sub abBSRDir_Click(sender As Object, e As EventArgs) Handles abBSRDir.Click
        Dim ExecuteRetVal As Integer = clsExecuteCommand.ShellExecute(0&, "open", TheFlashOrRegularDirectoryPath, Nothing, Nothing, AppWinStyle.NormalFocus)
        Application.Exit()
    End Sub
End Class