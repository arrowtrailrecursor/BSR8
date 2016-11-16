Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Collections.Specialized

Public Class clsRun

    Public Shared WithEvents bwPowerShell As New System.ComponentModel.BackgroundWorker
    Public Shared ccText As String = ""
    Public Shared ret As String = ""
    Public Shared ShellTypePath As String = ""
    Public Shared ThereIsADOSError = False
    Public Shared NoAssociatedProgram As Boolean = False
    Public Shared PlusX As Integer = 0
    Public Shared PlusY As Integer = 0
    Protected Browser As frmWebBrowse
    Public Enum CommandType
        PowerShell = 0
        Program = 1
        Path = 2
        URL = 3
        MSDOS = 4
    End Enum
    Public Enum ShellType As Integer
        Shell = 0
        PowerShell = 1
        MSDOS = 2
        None = 3
    End Enum

    <DllImport("shell32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function ShellExecute( _
              ByVal hwnd As IntPtr, _
              ByVal Operation As String, _
              ByVal FileName As String, _
              ByVal Parameters As String, _
              ByVal Directory As String, _
              ByVal ShowCmd As Integer) As Integer
    End Function

    Public Shared Sub DelayTilRetReturns()
        Do Until ret <> ""
            Application.DoEvents()
        Loop
    End Sub

    ' Public Shared Sub DelayTilOpen()
    'Do Until MyRunSpace.RunspaceStateInfo.State <> Management.Automation.Runspaces.RunspaceState.Opening
    '       Application.DoEvents()
    'Loop
    'End Sub

    Public Shared Sub DelayTilThreadNotBusy()
        Do Until bwPowerShell.IsBusy = False
            Application.DoEvents()
        Loop
    End Sub

    Public Shared Sub DelayTilBSDOPExists()
        Do Until PathExists("c:\BSR_DOP.txt", TypeOfPath.File)
            Application.DoEvents()
        Loop
    End Sub

    Public Shared Sub ComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        e.Handled = True
    End Sub

    Public Shared Sub ComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Public Shared Sub ToggleComboBoxReadonly(ByRef cmbToUse As ComboBox, ByVal bValue As Boolean)
        If bValue Then
            Dim intHeight As Integer
            intHeight = cmbToUse.Height
            cmbToUse.Tag = cmbToUse.DropDownStyle
            cmbToUse.DropDownStyle = ComboBoxStyle.Simple
            cmbToUse.Height = intHeight
            AddHandler cmbToUse.KeyDown, AddressOf ComboBox_KeyDown
            AddHandler cmbToUse.KeyPress, AddressOf ComboBox_KeyPress
        Else
            If cmbToUse.Tag IsNot Nothing Then
                cmbToUse.DropDownStyle = cmbToUse.Tag
                RemoveHandler cmbToUse.KeyDown, AddressOf ComboBox_KeyDown
                RemoveHandler cmbToUse.KeyPress, AddressOf ComboBox_KeyPress
            End If
        End If
    End Sub

    Public Shared Function isNewerOS() As Boolean
        Dim OS As String = frmMain.OSName.UC
        If OS.CNT(" 7") Or _
            OS.CNT(" 8") Or _
            OS.CNT(" 9") Or _
            OS.CNT(" 10") Or _
            OS.CNT(" VISTA") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function BlackShellRunnerCmd(ByVal Cmd As String, Optional ByVal HasCombo As Boolean = False) As Boolean
        Dim RegCase As String = Cmd
        Cmd = Cmd.UC.TRM
        If Cmd Like "SMD *" Or Cmd Like "SUPERMKDIR *" Then
            If Cmd Like "SMD *" Then SuperMkDir(RT(RegCase, LN(RegCase) - 4))
            If Cmd Like "SUPERMKDIR *" Then SuperMkDir(RT(RegCase, LN(RegCase) - 11))
            If HasCombo Then
                Return True
            Else
                Return False
            End If
        End If
        If Cmd Like "SOD *" Or Cmd Like "SUPEROPENDIR *" Then
            If Cmd Like "SOD *" Then SuperDirOpen(RT(RegCase, LN(RegCase) - 4))
            If Cmd Like "SUPEROPENDIR *" Then SuperDirOpen(RT(RegCase, LN(RegCase) - 13))
            If HasCombo Then
                Return True
            Else
                Return False
            End If
        End If
        If Cmd Like "SB *" Or Cmd Like "SAFERBROWSER *" Or Cmd = "SB" Then
            If Cmd Like "SB *" Then SpawnNewBrowserWindow(Cmd.RT(Cmd.LN) - 3)
            If Cmd Like "SAFERBROWSER *" Then SpawnNewBrowserWindow(Cmd.RT(Cmd.LN) - 13)
            If Cmd = "SB" Then SpawnNewBrowserWindow(frmWebBrowse.HomePage)
            If HasCombo Then
                Return True
            Else
                Return False
            End If
        End If
        Select Case Cmd
            Case "CASCADE"
                Delay(2)
                Cascade()
                If HasCombo Then
                    Return True
                Else
                    Return False
                End If
            Case "TILEHORIZONTALLY"
                Delay(2)
                TileHorizontal()
                If HasCombo Then
                    Return True
                Else
                    Return False
                End If
            Case "TILEVERTICALLY"
                Delay(2)
                TileVertical()
                If HasCombo Then
                    Return True
                Else
                    Return False
                End If
            Case "MINIMIZEALL"
                Delay(2)
                Minimize()
                If HasCombo Then
                    Return True
                Else
                    Return False
                End If
            Case "UNMINIMIZEALL"
                Delay(2)
                UndoMinimize()
                If HasCombo Then
                    Return True
                Else
                    Return False
                End If
        End Select
        Return False
    End Function
    Public Shared Sub SuperMkDir(ByVal ThePath As String)
        On Error Resume Next
        Dim TheDirPath As String = ThePath.TRM
        If TheDirPath.RT(1) <> "\" Then TheDirPath = TheDirPath & "\"
        If Not PathExists(TheDirPath.RSAtE("\"), TypeOfPath.Directory) Then
            IO.Directory.CreateDirectory(TheDirPath.RSAtE("\"))
        End If
    End Sub

    Public Shared Sub SuperDirOpen(ByVal ThePath As String)
        On Error Resume Next
        Dim TheDirPath As String = ThePath.TRM
        If TheDirPath.RT(1) <> "\" Then TheDirPath = TheDirPath & "\"
        Dim ThePathInStr() As String
        ThePathInStr = TheDirPath.SPT("\")
        Dim TheFinalPath As String = ""
        For i As Integer = 0 To ThePathInStr.GetUpperBound(0)
            TheFinalPath = TheFinalPath & ThePathInStr(i) & "\"
            If PathExists(TheFinalPath.RSAtE("\"), TypeOfPath.Directory) And TheFinalPath Like "?:\*\" Then
                ShellExecute(0&, "Open", TheFinalPath.RSAtE("\"), vbNullString, vbNullString, vbNormalNoFocus)
            End If
        Next
    End Sub

    Public Shared Sub WriteBSR_DOS(ByVal Cmd As String)

        Dim Path As String = TheFlashOrRegularDirectoryPath & "\BSR_DOS\BSR_DOS.bat"
        My.Computer.FileSystem.CreateDirectory(TheFlashOrRegularDirectoryPath & "\BSR_DOS")
        If PathExists(Path, TypeOfPath.File) Then FileIO.FileSystem.DeleteFile(Path)
        Dim pws As String
        Cmd = Cmd.TRM
        If frmMain.chkPws.Checked = True Then
            pws = "&&pause"
        Else
            pws = ""
        End If
        Dim fs As New FileStream(Path, FileMode.Create, FileAccess.Write)
        Dim s As New StreamWriter(fs)
        Dim BatchEcho As Boolean = INIReadBoolean(INISettingsPath, "MS-DOS", "Echo")
        Dim AllBatchEcho As Boolean = INIReadBoolean(INISettingsPath, "MS-DOS", "EchoEntireBatch")
        Dim ColorByte As String = INIRead(INISettingsPath, "MS-DOS", "BatchFileColorByte")
        With s
            If Not INIReadBoolean(INISettingsPath, "MS-DOS", "EchoEntireBatch") Then
                .WriteLine("@echo off")
            Else
                .WriteLine("@echo on")
            End If
            .WriteLine("title CMD.EXE")
            If Not ColorByte = "" Then .WriteLine("color " & ColorByte)
            .WriteLine("cd %HOMEDRIVE%%HOMEPATH%")
            If BatchEcho And Not AllBatchEcho Then .WriteLine("@echo on")
            .WriteLine(Cmd)
            If BatchEcho And Not AllBatchEcho Then .WriteLine("@echo off")
            .WriteLine("if %ERRORLEVEL% GEQ 1 (echo 1_Error>c:\BSR_DOP.txt" & pws & "&&exit)")
            .WriteLine("if %ERRORLEVEL% LSS 1 (echo 0_NotError>c:\BSR_DOP.txt" & pws & "&&exit)")
            .Close()
        End With
    End Sub

    Public Shared Function ReadBSR_DOP() As Boolean
        Dim ipt As Integer
        ipt = CInt(IO.File.ReadAllText("c:\BSR_DOP.txt").LT(1))
        Return CBool(ipt)
    End Function

    Public Shared Sub CleanUpByDeletingFiles()
        If Not INIReadBoolean(INISettingsPath, "MS-DOS", "KeepGeneratedBatchFile") Then
            FileIO.FileSystem.DeleteFile(TheFlashOrRegularDirectoryPath & "\BSR_DOS\BSR_DOS.bat")
        End If
        FileIO.FileSystem.DeleteFile("c:\BSR_DOP.txt")
    End Sub

    Public Shared Sub OpenBatOrCmd(ByVal Cmd As String)
        If PathExists(Cmd, TypeOfPath.File) Then
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = Cmd
            processStartInfo.Verb = "runas"
            processStartInfo.Arguments = ""
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            process = System.Diagnostics.Process.Start(processStartInfo)
        End If
    End Sub

    Public Shared Sub RunDOSCommandAsAdmin()
        Dim Pro As New Process
        Dim procInfo As New ProcessStartInfo()
        Pro.StartInfo.UseShellExecute = True
        Pro.StartInfo.FileName = TheFlashOrRegularDirectoryPath & "\BSR_DOS\BSR_DOS.bat"
        Pro.StartInfo.WorkingDirectory = ""
        Pro.StartInfo.Verb = "runas"
        Pro.Start()
        Pro.Close()
    End Sub

    Public Shared Sub AddToList(ByVal Cmd As String, ByVal Combo As ComboBox)
        If AddToTheCommandsList Then
            AddLst(Cmd, Combo, True)
        End If
    End Sub

    Public Shared Sub SpawnNewBrowserWindow(ByVal Url As String, _
                                            Optional ByVal Combo As Object = Nothing, _
                                            Optional ByVal RepositionForm As Boolean = True, _
                                            Optional ByVal InheritAttributesFromThisOne As frmWebBrowse = Nothing, _
                                            Optional ByVal vURLs As StringCollection = Nothing, _
                                            Optional ByVal vHostUrls As StringCollection = Nothing)
        Dim WebBrowser As frmWebBrowse
        If Not InheritAttributesFromThisOne Is Nothing Then
            If Not vURLs Is Nothing And Not vHostUrls Is Nothing Then
                WebBrowser = New frmWebBrowse(vURLs, vHostUrls)
            Else
                WebBrowser = New frmWebBrowse
            End If
            WebBrowser.tsslStatus.ForeColor = frmOptns.picForeColor.BackColor
            WebBrowser.cmbAddressBar.Items.Clear()
            With InheritAttributesFromThisOne
                WebBrowser.NewHost = .NewHost
                WebBrowser.Size = .Size
                WebBrowser.Location = .Location
                For Each item As String In .cmbAddressBar.Items
                    WebBrowser.cmbAddressBar.Items.Add(item)
                Next
            End With
        Else
            WebBrowser = New frmWebBrowse
        End If
        TheBlackShellRunnerProject.Forms.Add(WebBrowser)
        TheBlackShellRunnerProject.ColoredToolTips.Add(WebBrowser.mcttMain)
        '  DecorateForm(WebBrowser, frmMain.Opacity, frmMain.Opacity / 2, WindowDecoration.Picture)
        Dim SR As Rectangle = My.Computer.Screen.WorkingArea
        Dim SH As Integer = SR.Height
        Dim SW As Integer = SR.Width
        With WebBrowser
            Dim x As Integer
            Dim y As Integer
            Static PX As Integer = 0
            Static PY As Integer = 0
            If RepositionForm Then
                If TopLeft(frmMain) Then
                    y = ((SH / 2) - (.Height / 2)) + PY
                    x = ((SW / 2) - (.Width / 2)) + PX
                ElseIf TopRight(frmMain) Then
                    y = ((SH / 2) - (.Height / 2)) + PY
                    x = ((SW / 2) - (.Width / 2)) - PX
                ElseIf BottomLeft(frmMain) Then
                    y = ((SH / 2) - (.Height / 2)) - PY
                    x = ((SW / 2) - (.Width / 2)) + PX
                ElseIf BottomRight(frmMain) Then
                    y = ((SH / 2) - (.Height / 2)) - PY
                    x = ((SW / 2) - (.Width / 2)) - PX
                End If
                .StartPosition = FormStartPosition.Manual
            Else
                .StartPosition = FormStartPosition.Manual
                .Top = (My.Computer.Screen.WorkingArea.Height / 2) - (.Height / 2)
                .Left = (My.Computer.Screen.WorkingArea.Width / 2) - (.Width / 2)
            End If
            .Text = "BlackShellRunner Safer Browser > " & Url.TRM
            If RepositionForm Then
                PX += (.Width / 8)
                PY += (.Height / 8)
            End If
            Try
                .wbMain.Navigate(Url.TRM)
                If INIReadBoolean(INISettingsPath, "Internet", "StoreSaferBrowserAddresses") Then If Not Combo Is Nothing Then AddLst(Url, Combo, True)
                If Not Combo Is Nothing Then Combo.Text = ""
            Catch ex As Exception
                If frmOptns.chkGraphics.Checked Then DisplayGraphics(frmMain, True)
                Exit Sub
            End Try
            Do Until .wbMain.StatusText <> "Done"
                Application.DoEvents()
            Loop
            .Show()
            .BringToFront()
            If RepositionForm Then
                .Location = New Point(x, y)
                If _
                    (.Bottom > SR.Bottom) _
                    Or _
                    (.Right > SR.Right) _
                    Or _
                    (.Top < SR.Top) _
                    Or _
                    (.Left < SR.Left) _
                    Then
                    If frmOptns.chkGraphics.Checked Then
                        StraightenMeEdges(WebBrowser, True)
                    Else
                        StraightenMeEdges(WebBrowser, False)
                    End If
                End If
            End If
        End With
    End Sub

    Public Shared Function IsAURL(ByVal TheText As String) As Boolean
        Dim TXT As String = TheText
        If TXT Like "?.*.*" _
            Or TXT Like "??.*.*" _
            Or TXT Like "???.*.*" _
            Or TXT Like "????.*.*" _
            Or TXT Like "?????.*.*" _
            Or TXT Like "*?://*.*" Then
            'This just checks To Make Sure Its Not A Shell Command URL OR Path Shell Command
            If Not TXT Like ("*:\*") _
                And Not TXT.UC Like ("SHELL:*") Then Return True
        End If
        Return False
    End Function

    Public Shared Property LoadDirectorylessAppsIntoPanel As Boolean = True

    Public Shared Sub RunBlackShellShellOrDOSCmd(ByVal Cmd As String, Optional ByVal IsMSDOS As Boolean = False, Optional ByVal Combo As ComboBox = Nothing)
        If IsMSDOS Then GoTo MSDOS
        Dim GTEnd As Boolean = BlackShellRunnerCmd(Cmd, True)
        If GTEnd Then
            AddLst(Cmd, Combo, True)
            GoTo ThisIsTheEnd
        End If
        Dim ExecuteRetVal As Integer = 0
        If INIReadBoolean(INISettingsPath, "Internet", "UseSaferBrowser") Then
            If IsAURL(Cmd) Then
                SpawnNewBrowserWindow(Cmd, Combo)
                Exit Sub
            End If
        End If
        If ((Cmd.UC.TRM Like "*.EXE") And Not (Cmd.UC.TRM Like "?:\*.EXE") And LoadDirectorylessAppsIntoPanel) Then
            Cmd = Cmd.TRM
            If Cmd.UC Like "*EXPLORER.EXE" Then
                'MessageBox.Show("Cannot Load Explorer.exe into a Panel. Microsoft Windows Explorer Cannot Be Loaded Into BlackCrestSoft Panel Loader", "Panel Loader Cannot Load Windows Shell Program Explorer!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GoTo AfterPanelLoader
            End If
            LoadProcessIntoControlHandle(Cmd)
            If Not Combo Is Nothing Then
                AddToList(Cmd, Combo)
            End If
            Exit Sub
        End If
AfterPanelLoader:
        If isNewerOS() Then
            If Cmd.UC Like "?:\*.BAT" Or Cmd.UC Like "?:\*.CMD" Then
                OpenBatOrCmd(Cmd)
                If Not Combo Is Nothing Then
                    AddToList(Cmd, Combo)
                End If
                GoTo ThisIsTheEnd
            End If
            ExecuteRetVal = ShellExecute(0&, "open", Cmd, vbNullString, vbNullString, vbNormalNoFocus)
        Else
            ExecuteRetVal = ShellExecute(0&, "open", Cmd, vbNullString, vbNullString, vbNormalNoFocus)
        End If
        If ExecuteRetVal = 31 Then
            NoAssociatedProgram = True
            frmMain.scrmrMain.Stopped = False
            frmMain.scrmrMain.MarqueeText = "There is no associated program to open this type of file!"
            Exit Sub
        Else
            NoAssociatedProgram = False
        End If
        If ExecuteRetVal <= 32 Then
MSDOS:
            If PathExists("c:\BSR_DOP.txt", TypeOfPath.File) Then File.Delete("c:\BSR_DOP.txt")
            WriteBSR_DOS(Cmd)
            If isNewerOS() Then
                RunDOSCommandAsAdmin()
            ElseIf frmMain.OSName.CNT("XP") Then
                Shell(TheFlashOrRegularDirectoryPath & "\BSR_DOS\BSR_DOS.bat", vbNormalFocus)
            Else
                Shell(TheFlashOrRegularDirectoryPath & "\BSR_DOS\BSR_DOS.bat", vbNormalFocus)
            End If
            DelayTilBSDOPExists()
            Dim AnError As Boolean = ReadBSR_DOP()
            'Make Sure The ipt Variable is The Following One Character Length The Function Returns Only The First Character Of A Length Of One
            If AnError Then
                If frmOptns.chkGraphics.Checked Then DisplayGraphics(frmMain, True)
                If frmOptns.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.WaitToComplete)
                ThereIsADOSError = True
                If Not PathExists(Cmd, TypeOfPath.File) And Cmd Like "?:\*" Or Not PathExists(Cmd, TypeOfPath.Directory) And Cmd Like "?:\*" Then
                    frmMain.scrmrMain.MarqueeText = "The Path " & Qt & Cmd & Qt & " Was Not Found! Please Make Sure The Path Still Exists!"
                    frmMain.scrmrMain.Stopped = False
                End If
            Else
                ThereIsADOSError = False
                If Not Combo Is Nothing Then
                    AddToList(Cmd, Combo)
                End If
                GoTo ThisIsTheEnd
            End If
        ElseIf Not ExecuteRetVal <= 32 Then
            If Not Combo Is Nothing Then
                AddToList(Cmd, Combo)
            End If
            GoTo ThisIsTheEnd
        End If
ThisIsTheEnd:
        CleanUpByDeletingFiles()
        If Not Combo Is Nothing And Not ThereIsADOSError Then Combo.Text = ""
    End Sub

    Public Shared AddToTheCommandsList As Boolean = True

    Public Shared Function GetShellType(ByVal Command As String) As ShellType
        Dim EnvPaths() As String
        Dim ep As String = ""
        Dim e As String = INIRead(INISettingsPath, "Settings", "EnvironmentPaths")
        If Not e = "" Then
            If e.CNT("/") Then
                EnvPaths = e.SPT("/")
                For Each ep In EnvPaths
                    If ep.CNT(".") Then
                        If Command.UC Like ep.SPT(".").First.UC & " *?" And frmConsoleDetective.rbDOS.Checked Then
                            Return ShellType.MSDOS
                        ElseIf Command.UC Like ep.SPT(".").First.UC & " *?" And Not frmConsoleDetective.rbDOS.Checked Then
                            Return ShellType.PowerShell
                        End If
                    ElseIf Not ep.CNT(".") Then
                        If Command.UC Like ep.UC & " *?" And frmConsoleDetective.rbDOS.Checked Then
                            Return ShellType.MSDOS
                        ElseIf Command.UC Like ep.UC & " *?" And Not frmConsoleDetective.rbDOS.Checked Then
                            Return ShellType.PowerShell
                        End If
                    End If
                Next
            ElseIf Not e.CNT("/") Then
                ep = e
                If ep.CNT(".") Then
                    If Command.UC Like ep.SPT(".").First.UC & " *?" And frmConsoleDetective.rbDOS.Checked Then
                        Return ShellType.MSDOS
                    ElseIf Command.UC Like ep.SPT(".").First.UC & " *?" And Not frmConsoleDetective.rbDOS.Checked Then
                        Return ShellType.PowerShell
                    End If
                ElseIf Not ep.CNT(".") Then
                    If Command.UC Like ep.UC & " *?" And frmConsoleDetective.rbDOS.Checked Then
                        Return ShellType.MSDOS
                    ElseIf Command.UC Like ep.UC & " *?" And Not frmConsoleDetective.rbDOS.Checked Then
                        Return ShellType.PowerShell
                    End If
                End If
            End If
        End If
        Dim ShellTypeShell As String = aShellCmd(Command)
        If Not ShellTypeShell = "" Then
            ShellTypePath = ShellTypeShell
            Return ShellType.Shell
        End If
        Return ShellType.None
    End Function

    Public Shared Sub ExecuteCommand(ByVal Command As String, Optional ByVal Combo As ComboBox = Nothing)
        Command = Command.TRM
        If aDOSCmd(Command) And Command Like "*?&?*" Or aDOSCmd(Command) And Command Like "*?&&?*" Then
            RunBlackShellShellOrDOSCmd(Command, True, Combo)
            Exit Sub
        End If
        If Command Like "*; *" Then GoTo PowerShell
        If Command.UC = "CASCADE" _
            Or Command.UC = "MINIMIZEALL" _
            Or Command.UC = "UNMINIMIZEALL" _
            Or Command.UC = "TILEHORIZONTALLY" _
            Or Command.UC = "TILEVERTICALLY" _
            Or Command Like "SMD *" Or Command Like "SUPERMKDIR *" _
            Or Command Like "SOD *" Or Command Like "SUPEROPENDIR *" _
            Or Command Like "SB *" Or Command Like "SAFERBROWSER *" Or Command = "SB" Then
            If Not Combo Is Nothing Then
                RunBlackShellShellOrDOSCmd(Command, False, Combo)
            Else
                RunBlackShellShellOrDOSCmd(Command, False)
            End If
            Exit Sub
        End If
        If Command Like "?:\*" Then
            If PathExists(Command, TypeOfPath.File) Or PathExists(Command, TypeOfPath.Directory) Then
                If Not Combo Is Nothing Then
                    RunBlackShellShellOrDOSCmd(Command, False, Combo)
                Else
                    RunBlackShellShellOrDOSCmd(Command, False)
                End If
                Exit Sub
            End If
        End If
        Dim Dos_PwrSh_Sh As String = GetShellType(Command)
        If Dos_PwrSh_Sh = ShellType.MSDOS Then
            If Not Combo Is Nothing Then
                RunBlackShellShellOrDOSCmd(Command, True, Combo)
            Else
                RunBlackShellShellOrDOSCmd(Command, True)
            End If
            Exit Sub
        ElseIf Dos_PwrSh_Sh = ShellType.Shell Then
            If Not Combo Is Nothing Then
                RunBlackShellShellOrDOSCmd(Command, False, Combo)
            Else
                RunBlackShellShellOrDOSCmd(Command, False)
            End If
            Exit Sub
        End If
        If Command.UC Like "?:\*" Or _
            IsAURL(Command) Or _
                Command.UC Like "CMD /C *" Or _
                Command.UC Like "CMD /K *" Or _
                Command.UC Like "SHELL:*" Then
            If Not Combo Is Nothing Then
                RunBlackShellShellOrDOSCmd(Command, False, Combo)
            Else
                RunBlackShellShellOrDOSCmd(Command, False)
            End If
            Exit Sub
        End If
PowerShell:
        If frmMain.lblshpRn.Text = "Run" Then
            frmMain.lblshpRn.Text = "Stop"
            ccText = Command
            'run the script
            bwPowerShell.RunWorkerAsync()
            'wait till it returns a value
            DelayTilRetReturns()
            'filter results
            If ret = "ERROR" Then
                'or else there is a powershell error
                If Not Combo Is Nothing Then
                    RunBlackShellShellOrDOSCmd(Command, False, Combo)
                Else
                    RunBlackShellShellOrDOSCmd(Command, False)
                End If
            Else
                If ret <> vbNewLine Then
                    Dim frmOP As New frmOutput
                    frmMain.lblshpRn.Refresh()
                    TheBlackShellRunnerProject.Forms.Add(frmOP)
                    ' WindowDecoration.DecorateForm(frmOP, frmMain.Opacity, frmMain.Opacity / 2, WindowDecoration.Picture)
                    With frmOP
                        TheBlackShellRunnerProject.ColoredToolTips.Add(.mcttMain)
                        ColorFormsAndControls(frmOptns.picForeColor.BackColor, frmOptns.picBackColor.BackColor, frmOptns.picShadowColor.BackColor)
                        SetSounds(frmOptns.chkSound.Checked)
                        SetOpacity()
                        Dim SR As Rectangle = My.Computer.Screen.WorkingArea
                        Dim SH As Integer = SR.Height
                        Dim SW As Integer = SR.Width
                        If TopLeft(frmMain) Then
                            .Top = ((SH / 2) - (.Height / 2)) + PlusY
                            .Left = ((SW / 2) - (.Width / 2)) + PlusX
                        ElseIf TopRight(frmMain) Then
                            .Top = ((SH / 2) - (.Height / 2)) + PlusY
                            .Left = ((SW / 2) - (.Width / 2)) - PlusX
                        ElseIf BottomLeft(frmMain) Then
                            .Top = ((SH / 2) - (.Height / 2)) - PlusY
                            .Left = ((SW / 2) - (.Width / 2)) + PlusX
                        ElseIf BottomRight(frmMain) Then
                            .Top = ((SH / 2) - (.Height / 2)) - PlusY
                            .Left = ((SW / 2) - (.Width / 2)) - PlusX
                        End If
                        With .txtOutput
                            .Text = ret
                            .SelectionLength = 0
                            .SelectionStart = .Text.Length
                        End With
                        .Show()
                        .BringToFront()
                        PlusX += (.Width / 8)
                        PlusY += (.Height / 8)
                        If _
                            (.Bottom > SR.Bottom) _
                            Or _
                            (.Right > SR.Right) _
                            Or _
                            (.Top < SR.Top) _
                            Or _
                            (.Left < SR.Left) _
                            Then
                            If frmOptns.chkGraphics.Checked Then
                                StraightenMeEdges(frmOP, True)
                            Else
                                StraightenMeEdges(frmOP, False)
                            End If
                        End If
                        .BringToFront()
                    End With
                Else
                    frmOutput.Hide()
                End If
                If Not Combo Is Nothing Then AddToList(ccText, Combo)
            End If
            ret = ""
            frmMain.lblshpRn.Text = "Run"
        ElseIf frmMain.lblshpRn.Text = "Stop" Then
            'If MyRunSpace.RunspaceStateInfo.State = System.Management.Automation.Runspaces.RunspaceState.Opening Then
            'DelayTilOpen()
            'End If
            '   MyRunSpace.Close()
            DelayTilThreadNotBusy()
            frmMain.lblshpRn.Text = "Run"
        End If
    End Sub

    Public Shared Sub bwPowerShell_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwPowerShell.DoWork
        Try
            ret = RunScript(ccText)
        Catch ex As TypeInitializationException
        End Try
    End Sub

End Class