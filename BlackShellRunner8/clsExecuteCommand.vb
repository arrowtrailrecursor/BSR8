Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices

Public Class clsExecuteCommand
    Public Shared ThereIsADOSError = False
    <DllImport("shell32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Public Shared Function ShellExecute(
              ByVal hwnd As IntPtr,
              ByVal Operation As String,
              ByVal FileName As String,
              ByVal Parameters As String,
              ByVal Directory As String,
              ByVal ShowCmd As Integer) As Integer
    End Function
    Public Shared PlusX, PlusY As Integer
    Public Shared Property AddToTheCommandsList As Boolean = True
    Public Shared Property NoAssociatedProgram As Boolean = False
    Public Shared Property LoadDirectorylessAppsWithNoParametersIntoPanel As Boolean = True
    Public Enum CommandType
        PowerShell = 0
        MSDOS = 1
        ShellExecute = 2
        URL = 3
        BlackShellRunner = 5
        ShellExecuteParams = 6
    End Enum
    Public Enum ShellType As Integer
        Shell = 0
        PowerShell = 1
        MSDOS = 2
        None = 3
    End Enum
    Private Shared VisFrm As New List(Of Form)
    Public Shared Sub HideAllFormsButMain()
        VisFrm.Clear()
        For Each form As Form In TheBlackShellRunnerProject.Forms
            If Not form Is frmMain Then
                If form.Visible Then
                    VisFrm.Add(form)
                    form.Visible = False
                    form.Hide()
                    form.Refresh()
                End If
            End If
        Next
    End Sub
    Public Shared Sub ShowAllFormsButMain()
        For Each form As Form In VisFrm
            form.Visible = True
            form.Show()
            form.Refresh()
        Next
    End Sub
    Public Shared Sub ExecuteCommand(ByVal Command As String)
        On Error Resume Next
        If frmOptions.chkGraphics.Checked Then
            DisplayGraphics(frmMain, False)
        End If
        Dim CmdType As CommandType
        Dim TheShellType As ShellType = GetShellType(Command)
        If TheShellType = ShellType.MSDOS And Not Command.CNT("; ") Then ' Microsoft MS-DOS
            CmdType = CommandType.MSDOS
            GoTo TheEnd
        ElseIf TheShellType = ShellType.PowerShell And Not Command.CNT("&") Then ' Microsoft WindowsPowerShell
            CmdType = CommandType.PowerShell
            GoTo TheEnd
        ElseIf TheShellType = ShellType.Shell Then ' Environment Variable Shell Command
            CmdType = CommandType.ShellExecuteParams
            GoTo TheEnd
        End If
        If aDOSCmd(Command) And Command.CNT("&") Then
            ' command prompt
            CmdType = CommandType.MSDOS
            GoTo TheEnd
        End If
        If aPSCmd(Command) And Command.CNT("; ") Then
            ' powershell command
            CmdType = CommandType.PowerShell
            GoTo TheEnd
        End If
        If Command Like "?:\*.*" Or Command Like "*\*.*" And Not Command Like "*\\*.*" Then
            If PathExists(Command, TypeOfPath.File) Then
                'file with extention icon
                CmdType = CommandType.ShellExecute
                GoTo TheEnd
            End If
        ElseIf Command Like "?:\" Or Command = "\" And Not Command = "\\" Then
            If PathExists(Command, TypeOfPath.Directory) Then
                'drive icon
                CmdType = CommandType.ShellExecute
                GoTo TheEnd
            End If
        ElseIf Command Like "?:\*" Or Command Like "\*" And Not Command Like "\\*" And Not Command Like "*\\" Then
            If PathExists(Command, TypeOfPath.Directory) Then
                'folder icon
                CmdType = CommandType.ShellExecute
                GoTo TheEnd
            ElseIf PathExists(Command, TypeOfPath.File) Then
                'file icon
                CmdType = CommandType.ShellExecute
                GoTo TheEnd
            End If
        End If
        If Command.UC Like "SHELL:*" Then
            'shell gears icon
            CmdType = CommandType.ShellExecute
            GoTo TheEnd
        End If
        If aSpecialFolderCmd(Command) Then
            'folder icon
            CmdType = CommandType.ShellExecute
            GoTo TheEnd
        End If
        If aControlPanelCmd(Command) Then
            'control panel icon
            CmdType = CommandType.ShellExecute
            GoTo TheEnd
        End If
        If Command.TRM = "" Then
            GoTo TheEnd
        End If
        If Command.UC Like "CMD.EXE /C*" Or Command.UC Like "CMD.EXE /K*" Then
            'DOS Command
            CmdType = CommandType.ShellExecute
            GoTo TheEnd
        End If
        If Command.UC = "TILEVERTICALLY" Then
            'TILE VERTICALLY
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC = "TILEHORIZONTALLY" Then
            'TILE HORIZONTALLY
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC = "CASCADE" Then
            'CASCADE
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC = "UNMINIMIZEALL" Then
            'UNMINIMIZEALL
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC = "MINIMIZEALL" Then
            'MINIMIZEALL
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC Like "SUPERMKDIR*" Or Command.UC Like "SMD *" Then
            'stuffed folder icon for supermkdir
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC Like "SUPEROPENDIR *" Or Command.UC Like "SOD *" Then
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC Like "SB *" Or Command.UC Like "SAFERBROWSER *" Or Command.UC = "SB" Then
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If Command.UC Like "PANELLOADER *.EXE" Or Command.UC Like "PL *.EXE" Then
            CmdType = CommandType.BlackShellRunner
            GoTo TheEnd
        End If
        If clsExecuteCommand.IsAURL(Command) Then
            'INet
            CmdType = CommandType.URL
            GoTo TheEnd
        End If
TheEnd:
        Select Case CmdType
            Case CommandType.URL
                ExecuteURL(Command)
            Case CommandType.BlackShellRunner
                BlackShellRunnerCmd(Command, True)
            Case CommandType.MSDOS
                RunDosCommand(Command)
            Case CommandType.PowerShell
                ExecutePowerShellCommand(Command)
            Case CommandType.ShellExecute
                ShellExecute(Command)
            Case CommandType.ShellExecuteParams
                ' MsgBox("")
                ShellExecuteParams(Command.SPT(" ").First, Command.RSAtF(Command.SPT(" ").First))
        End Select
    End Sub
    Public Shared Sub ExecuteURL(ByVal URL As String)
        Dim TFBrws As Boolean = INIReadBoolean(INISettingsPath, "Internet", "UseSaferBrowser")
        If TFBrws Then
            SpawnNewBrowserWindow(URL)
        Else
            ShellExecute(URL)
        End If
    End Sub

    Public Shared Sub ShellExecute(ByVal Command As String)
        Dim ret As Integer = ShellExecute(0&, "open", Command, Nothing, Nothing, vbNormalNoFocus)
        If ret = 31 Then
            frmMain.scrmrMain.Stopped = False
            NoAssociatedProgram = True
            frmMain.scrmrMain.MarqueeText = "There is no associated program to open this type of file!"
            Exit Sub
        End If
        If Not ret <= 32 Then
            NoAssociatedProgram = False
            If AddToTheCommandsList Then AddLst(Command, frmMain.cmbCmd, True)
        End If
    End Sub
    Public Shared Sub ShellExecuteParams(ByVal Command As String, ByVal Params As String)
        Dim ret As Integer = ShellExecute(0&, "open", Command, Params, Nothing, vbNormalNoFocus)
        If ret = 31 Then
            frmMain.scrmrMain.Stopped = False
            NoAssociatedProgram = True
            frmMain.scrmrMain.MarqueeText = "There is no associated program to open this type of file!"
            Exit Sub
        End If
        If Not ret <= 32 Then
            NoAssociatedProgram = False
            If AddToTheCommandsList Then AddLst(Command, frmMain.cmbCmd, True)
        End If
    End Sub
    Friend Shared WithEvents frmOutput As frmOutput
    Public Shared Sub ExecutePowerShellCommand(ByVal Command As String)
        TheErrorText = ""
        Dim Output As String = RunScript(Command)
        frmMain.abRn.Text = "Run"
        If Output.LC.CNT("at line:1") Then
            TheErrorText = Output.RP(CL, "")
        End If
        If Output = "Stopped By User." Then Exit Sub
        If TheErrorText <> "" Then Output = TheErrorText
        frmOutput = New frmOutput
        frmOutput.Name = "frmOutput"
        frmMain.abRn.Refresh()
        TheBlackShellRunnerProject.Forms.Add(frmOutput)
        TheBlackShellRunnerProject.ColoredToolTips.Add(frmOutput.mcttMain)
        ColorFormsAndControls(frmOptions.picForeColor.BackColor, frmOptions.picBackColor.BackColor, frmOptions.picShadowColor.BackColor)
        SetSounds(frmOptions.chkSound.Checked)
        SetOpacity()
        DecorateForm(frmOutput, (frmOptions.tbTransparency.Value / 100), (frmOptions.tbPicOpacity.Value / 100), WindowDecoration.Animation)
        With frmOutput
            frmMain.HasOutputWindow = True
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
                .Text = Output
                .SelectionLength = 0
                .SelectionStart = .Text.Length
            End With
            If Not TheErrorText = "" Then
                frmMain.scrmrMain.Stopped = False
                frmMain.scrmrMain.MarqueeText = TheErrorText.RP(CL, "")
            End If
            .Show()
            .BringToFront()
            PlusX += (.Width / 8)
            PlusY += (.Height / 8)
            If _
                    (.Bottom > SR.Bottom) _
                    Or
                    (.Right > SR.Right) _
                    Or
                    (.Top < SR.Top) _
                    Or
                    (.Left < SR.Left) _
                    Then
                If frmOptions.chkGraphics.Checked Then
                    StraightenMeEdges(frmOutput, True)
                Else
                    StraightenMeEdges(frmOutput, False)
                End If
            End If
            .BringToFront()
        End With
        If TheErrorText = "" Then
            If AddToTheCommandsList Then AddLst(Command, frmMain.cmbCmd, True)
        Else
            If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound)
            If frmOptions.chkGraphics.Checked Then
                DisplayGraphics(frmMain, True)
            End If
        End If
    End Sub
    Private Shared Sub RunDosCommand(ByVal Cmd As String)
        If PathExists(DosDirectory & "\BSR_DOS.BAT", TypeOfPath.File) Then IO.File.Delete(DosDirectory & "\BSR_DOS.BAT")
        If PathExists(DosDirectory & "\BSR_OUT.DAT", TypeOfPath.File) Then IO.File.Delete(DosDirectory & "\BSR_OUT.DAT")
        WriteBSR_DOS(Cmd)
        If isNewerOS() Then
            RunDOSCommandAsAdmin()
        ElseIf frmMain.OSName.CNT("XP") Then
            ' Shell(DosDirectory & "\BSR_OUT.DAT", vbNormalFocus)
            ShellExecute(0&, "Open", DosDirectory & "\BSR_DOS.BAT", Nothing, Nothing, vbNormalFocus)
        Else
            ' Shell(DosDirectory & "\BSR_OUT.DAT", vbNormalFocus)
            ShellExecute(0&, "Open", DosDirectory & "\BSR_DOS.BAT", Nothing, Nothing, vbNormalFocus)
        End If
        DelayTilBSDOPExists()
        Dim AnError As Boolean = ReadBSR_OUT()
        'Make Sure The ipt Variable is The Following One Character Length The Function Returns Only The First Character Of A Length Of One
        If AnError Then
            ThereIsADOSError = True
            If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound)
            If frmOptions.chkGraphics.Checked Then
                DisplayGraphics(frmMain, True)
            End If
        Else
            ThereIsADOSError = False
            If AddToTheCommandsList Then AddLst(Cmd, frmMain.cmbCmd, True)
        End If
    End Sub

    Public Shared Function GetShellType(ByVal Command As String) As ShellType
        Dim ep As String = ""
        Dim EnvNames() As String
        Dim e As String = Settings.RetrieveSetting("FileNames")
        If Not e = "" Then
            If e.CNT(",") Then
                EnvNames = e.SPT(",")
                For Each ep In EnvNames
                    If ep.CNT(".") Then
                        If Command.UC Like ep.SPT(".").First.UC & " *?" And frmEnvironmentCommands.rbDOS.Checked Then
                            Return ShellType.MSDOS
                        ElseIf Command.UC Like ep.SPT(".").First.UC & " *?" And Not frmEnvironmentCommands.rbDOS.Checked Then
                            Return ShellType.PowerShell
                        End If
                    ElseIf Not ep.CNT(".") Then
                        If Command.UC Like ep.UC & " *?" And frmEnvironmentCommands.rbDOS.Checked Then
                            Return ShellType.MSDOS
                        ElseIf Command.UC Like ep.UC & " *?" And Not frmEnvironmentCommands.rbDOS.Checked Then
                            Return ShellType.PowerShell
                        End If
                    End If
                Next
            ElseIf Not e.CNT(",") Then
                ep = e
                If ep.CNT(".") Then
                    If Command.UC Like ep.SPT(".").First.UC & " *?" And frmEnvironmentCommands.rbDOS.Checked Then
                        Return ShellType.MSDOS
                    ElseIf Command.UC Like ep.SPT(".").First.UC & " *?" And Not frmEnvironmentCommands.rbDOS.Checked Then
                        Return ShellType.PowerShell
                    End If
                ElseIf Not ep.CNT(".") Then
                    If Command.UC Like ep.UC & " *?" And frmEnvironmentCommands.rbDOS.Checked Then
                        Return ShellType.MSDOS
                    ElseIf Command.UC Like ep.UC & " *?" And Not frmEnvironmentCommands.rbDOS.Checked Then
                        Return ShellType.PowerShell
                    End If
                End If
            End If
        End If
        If aShellCmd(Command) Then
            Return ShellType.Shell
        End If
        Return ShellType.None
    End Function
    Public Shared Sub DelayTilBSDOPExists()
        Do Until PathExists(DosDirectory & "\BSR_OUT.DAT", TypeOfPath.File)
            Application.DoEvents()
        Loop
    End Sub
    Public Shared Function isNewerOS() As Boolean
        Dim OS As String = frmMain.OSName.UC
        If OS.CNT(" 7") Or
            OS.CNT(" 8") Or
            OS.CNT(" 9") Or
            OS.CNT(" 10") Or
            OS.CNT(" VISTA") Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub BlackShellRunnerCmd(ByVal Cmd As String, Optional ByVal HasCombo As Boolean = False)
        Dim RegCase As String = Cmd
        Dim AddToList As Boolean = False
        Cmd = Cmd.UC.TRM
        If Cmd Like "SMD *" Or Cmd Like "SUPERMKDIR *" Then
            If Cmd Like "SMD *" Then SuperMkDir(RT(RegCase, LN(RegCase) - 4))
            If Cmd Like "SUPERMKDIR *" Then SuperMkDir(RT(RegCase, LN(RegCase) - 11))
            AddToList = True
        End If
        If Cmd Like "SOD *" Or Cmd Like "SUPEROPENDIR *" Then
            If Cmd Like "SOD *" Then SuperDirOpen(RT(RegCase, LN(RegCase) - 4))
            If Cmd Like "SUPEROPENDIR *" Then SuperDirOpen(RT(RegCase, LN(RegCase) - 13))
            AddToList = True
        End If
        If Cmd Like "SB *" Or Cmd Like "SAFERBROWSER *" Or Cmd = "SB" Then
            If Cmd Like "SB *" Then SpawnNewBrowserWindow(Cmd.RT(Cmd.LN) - 3)
            If Cmd Like "SAFERBROWSER *" Then SpawnNewBrowserWindow(Cmd.RT(Cmd.LN) - 13)
            If Cmd = "SB" Then SpawnNewBrowserWindow(frmWebBrowse.HomePage)
            AddToList = True
        End If
        If Cmd.UC Like "PANELLOADER *.EXE" Or Cmd.UC Like "PL *.EXE" Then
            LoadProcessIntoControlHandle(Cmd.SPT(" ").Last)
            AddToList = True
        End If
        Select Case Cmd
            Case "CASCADE"
                Delay(2)
                Cascade()
                AddToList = True
            Case "TILEHORIZONTALLY"
                Delay(2)
                TileHorizontal()
                AddToList = True
            Case "TILEVERTICALLY"
                Delay(2)
                TileVertical()
                AddToList = True
            Case "MINIMIZEALL"
                Delay(2)
                Minimize()
                AddToList = True
            Case "UNMINIMIZEALL"
                Delay(2)
                UndoMinimize()
                AddToList = True
        End Select
        If AddToList Then
            If AddToTheCommandsList Then AddLst(Command, frmMain.cmbCmd, True)
        End If
    End Sub
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
    Public Shared Sub SpawnNewBrowserWindow(ByVal Url As String,
                                            Optional ByVal Combo As Object = Nothing,
                                            Optional ByVal RepositionForm As Boolean = True,
                                            Optional ByVal InheritAttributesFromThisOne As frmWebBrowse = Nothing,
                                            Optional ByVal vURLs As StringCollection = Nothing,
                                            Optional ByVal vHostUrls As StringCollection = Nothing)
        Dim WebBrowser As frmWebBrowse
        If Not InheritAttributesFromThisOne Is Nothing Then
            If Not vURLs Is Nothing And Not vHostUrls Is Nothing Then
                WebBrowser = New frmWebBrowse(vURLs, vHostUrls)
            Else
                WebBrowser = New frmWebBrowse
            End If
            TheBlackShellRunnerProject.Forms.Add(WebBrowser)
            WebBrowser.tsslStatus.ForeColor = frmOptions.picForeColor.BackColor
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
        ColorFormsAndControls(frmOptions.picForeColor.BackColor, frmOptions.picBackColor.BackColor, frmOptions.picShadowColor.BackColor)
        SetSounds(frmOptions.chkSound.Checked)
        SetOpacity()
        DecorateForm(WebBrowser, frmMain.Opacity, frmMain.Opacity / 2, WindowDecoration.Animation)
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
                If INIReadBoolean(INISettingsPath, "Internet", "StoreSaferBrowserAddresses") Then If Not Combo Is Nothing Then If AddToTheCommandsList Then AddLst(Url, Combo, True)
                If Not Combo Is Nothing Then Combo.Text = ""
            Catch ex As Exception
                If frmOptions.chkGraphics.Checked Then DisplayGraphics(frmMain, True)
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
                    Or
                    (.Right > SR.Right) _
                    Or
                    (.Top < SR.Top) _
                    Or
                    (.Left < SR.Left) _
                    Then
                    If frmOptions.chkGraphics.Checked Then
                        StraightenMeEdges(WebBrowser, True)
                    Else
                        StraightenMeEdges(WebBrowser, False)
                    End If
                End If
            End If
        End With
    End Sub
    Public Shared Sub WriteBSR_DOS(ByVal Cmd As String)
        Dim Path As String = DosDirectory & "\BSR_DOS.BAT"
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
            .WriteLine("if %ERRORLEVEL% GEQ 1 (cd " & DosDirectory & "" & "&&echo 1_Error>BSR_OUT.DAT" & pws & "&&exit)")
            .WriteLine("if %ERRORLEVEL% LSS 1 (cd " & DosDirectory & "" & "&&echo 0_NotError>BSR_OUT.DAT" & pws & "&&exit)")
            .Close()
        End With
    End Sub

    Public Shared Sub CleanUpByDeletingFiles()
        If Not INIReadBoolean(INISettingsPath, "MS-DOS", "KeepGeneratedBatchFile") Then
            FileIO.FileSystem.DeleteFile(DosDirectory & "\BSR_DOS.BAT")
        End If
        FileIO.FileSystem.DeleteFile(DosDirectory & "\BSR_OUT.DAT")
    End Sub
    Public Shared Function ReadBSR_OUT() As Boolean
        Dim ipt As Integer
        ipt = CInt(IO.File.ReadAllText(DosDirectory & "\BSR_OUT.DAT").LT(1))
        Return CBool(ipt)
    End Function
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
        Pro.StartInfo.FileName = DosDirectory & "\BSR_DOS.BAT"
        Pro.StartInfo.WorkingDirectory = ""
        Pro.StartInfo.Verb = "runas"
        Pro.Start()
        ' Pro.Close()
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


    Private Shared Sub frmOutput_FormClosing(sender As Object, e As FormClosingEventArgs) Handles frmOutput.FormClosing
        e.Cancel = True
        frmOutput.Hide()
    End Sub
End Class
