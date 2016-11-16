#Region "Imports"

Imports System.ComponentModel
Imports System.IO
Imports System.Security.Principal
Imports System.Text
Imports BSR.clsExecuteCommand


#End Region
Public Class frmMain

#Region "Static_Variables"

    Public IgnoreFlashRunAtStartUp As Boolean = False
    Public IsLoading As Boolean = False
    Public FormsThatWereVisible As New List(Of Form)
    Public autocom As New AutoCompleteStringCollection
    Public IsWow64 As Boolean = System.Environment.Is64BitOperatingSystem
    Public OSName As String = My.Computer.Info.OSFullName
    Protected ReadOnly BSRBinaryFilePassword As String = "P21M32SaLtIn232ThEGodDAMnSnaILy"
    Protected ReadOnly BSRBinaryFileSalt() As Byte = {&HCB, &H32, &H41, &H98, &H12, &HAB, &HC5, &H2C}

#End Region

#Region "Non_Event_Blocks"

#Region "Protected"

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#End Region
#Region "Properties"

    Property StartUpCommand As String = ""
    Property BackGroundImagePath As String = "C:\Users\BlackCrest\Desktop\GIF\Cubes.gif"
    Property BackGroundLayerOpacity As Double = 0.25
    Property MarqueeDefaultText As String = "Run PowerShell Program Path URL Or MS-DOS Command"
    Property MaximumSizeDivisor As Double = 2

    Protected vMarqueeStretch As Boolean = False

    Protected Property StretchMarquee() As Boolean
        Get
            Return vMarqueeStretch
        End Get
        Set(value As Boolean)
            vMarqueeStretch = value
            If value Then
                scrmrMain.Width = ((Width - cmbCmd.Left) - ((Width - alHide.Right) - alHide.LineSize))
            Else
                scrmrMain.Width = cmbCmd.Width
            End If
            SetGraphicsPath()
            Refresh()
        End Set
    End Property

    Protected vMarqueeMaxFontSize As Integer = 72

    Protected Property MaxScrollingMarqueeFontSize() As Integer
        Get
            Return vMarqueeMaxFontSize
        End Get
        Set(value As Integer)
            vMarqueeMaxFontSize = value
            If value > 72 Then vMarqueeMaxFontSize = 72
            If value < 6 Then vMarqueeMaxFontSize = 6
            Refresh()
        End Set
    End Property

    Protected vCommandLineSeparator As String = "%|%"

    Property CommandLineSeparator As String
        Get
            Return vCommandLineSeparator
        End Get
        Set(value As String)
            If value.LN >= 2 Or value.TRM = "" Then
                If Not value = "; " And Not value = "&&" Then
                    vCommandLineSeparator = value
                ElseIf value = "; " Or value = "&&" Then
                    vCommandLineSeparator = "%|%"
                    INIWrite(INISettingsPath, "Settings", "CommandLineSeparator", "%|%")
                    MessageBox.Show("Command Line Separator Cannot Be ""&&"" or ""; "" Must Be Equal To Or More Than 2 Characters In Length And Should Be Made Of Special Characters !@#$%^&*(){}[]|\/. Command Separator Will Be Set To Its Default ""%|%"".",
                                    "Invalid Command Separator",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                End If
            Else
                vCommandLineSeparator = "%|%"
                INIWrite(INISettingsPath, "Settings", "CommandLineSeparator", "%|%")
                MessageBox.Show("Command Line Separator Must Be Two Or More Characters And Cannot Be Null. Command Separator Will Be Set To Its Default ""%|%"".",
                                "Invalid Command Separator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
            Refresh()
        End Set
    End Property

#End Region
#Region "New"

    Sub New()
        'On Error Resume Next
        ' This call is required by the designer.
        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess
        myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        SetGraphicsPath()
        TheBlackShellRunnerProject.Forms.Add(Me)
        Para = ReadParameters()
    End Sub

    Private Sub SetGraphicsPath()
        SetParentFormGraphicsRectanglePath(Me, abBrdr)
    End Sub

#End Region
#Region "Misc"

    Shared Function BytesToString(ByVal byteCount As Long) As String
        Dim suf() As String = {"B", "KB", "MB", "GB", "TB", "PB", "EB"} 'Longs run out around EB
        If byteCount = 0 Then
            Return "0" & suf(0)
        End If
        Dim bytes As Long = Math.Abs(byteCount)
        Dim place As Integer = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)))
        Dim num As Double = Math.Round(bytes / Math.Pow(1024, place), 1)
        Return (Math.Sign(byteCount) * num).ToString() & suf(place)
    End Function

    Public Sub Run()
        On Error Resume Next
        abRn.Enabled = False
        abBrws.Enabled = False
        abSrch.Enabled = False
        abOptns.Enabled = False
        clsExecuteCommand.HideAllFormsButMain()
        If cmbCmd.Text.UC.CNT("PAUSE") Then
            MessageBox.Show("Command cannot contain pause! Use DOS Pause Checkbox to make DOS pause.", "DOS Pause Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If abRn.Text = "Run" Then
            ToSeeAsCustomOrJustExecute()
            cmbCmd.Focus()
        ElseIf abRn.Text = "Stop" Then
            StopScript()
            If Not clsExecuteCommand.NoAssociatedProgram Then
                scrmrMain.MarqueeText = MarqueeDefaultText
                scrmrMain.Stopped = True
            End If
            If clsExecuteCommand.ThereIsADOSError Then
                scrmrMain.Stopped = False
                scrmrMain.MarqueeText = modPowerShell.TheErrorText
            End If
            abRn.Text = "Run"
        End If
        abRn.Enabled = True
        abBrws.Enabled = True
        abSrch.Enabled = True
        abOptns.Enabled = True
        clsExecuteCommand.ShowAllFormsButMain()
        BringToFront()
    End Sub

#End Region
#Region "Form_Subs"

    Public Sub HideAllForms(Optional ByVal IsJustMeHide As Boolean = False)
        FormsThatWereVisible.Clear()
        If Not IsJustMeHide Then
            For Each frm As Form In TheBlackShellRunnerProject.Forms
                If frm.Visible Then
                    FormsThatWereVisible.Add(frm)
                    frm.Hide()
                End If
            Next
        ElseIf IsJustMeHide Then
            FormsThatWereVisible.Add(Me)
            Hide()
        End If
        If frmOptions.chkClassicHide.Checked Then
            If TopLeft() Then
                frmHidden.Show()
                frmHidden.Top = Top
                frmHidden.Left = Left
            ElseIf TopRight() Then
                frmHidden.Show()
                frmHidden.Top = Top
                frmHidden.Left = Left + Width - frmHidden.Width
            ElseIf BottomLeft() Then
                frmHidden.Show()
                frmHidden.Top = Top + Height - frmHidden.Height
                frmHidden.Left = Left
            ElseIf BottomRight() Then
                frmHidden.Show()
                frmHidden.Top = Top + Height - frmHidden.Height
                frmHidden.Left = Left + Width - frmHidden.Width
            End If
            frmHidden.tmrMoveToCorner.Enabled = True
            frmHidden.tmrMoveToCorner.Start()
        ElseIf Not frmOptions.chkClassicHide.Checked Then
            notico.Visible = True
        End If
    End Sub

    Public Sub ShowAllForms()
        For Each frm As Form In FormsThatWereVisible
            frm.Show()
        Next
    End Sub

    Public Sub SnapToGrid()
        If TopLeft() Then
            GoTopLeft()
        End If
        If TopRight() Then
            GoTopRight()
        End If
        If BottomLeft() Then
            GoBottomLeft()
        End If
        If BottomRight() Then
            GoBottomRight()
        End If
        SavePosition(Me)
    End Sub

#End Region
#Region "LoadSettings"

    Private Sub BuildConstructor(Optional ByVal Clear As Boolean = False)
        'Clear Constructor In Case Of Revert Boolean Value Set To True Otherwise It Will Add More Then Is Needed
        If Clear Then
            TheBlackShellRunnerProject.Forms.Clear()
            TheBlackShellRunnerProject.ColoredToolTips.Clear()
            Do Until TheBlackShellRunnerProject.Forms.Count = 0 And TheBlackShellRunnerProject.ColoredToolTips.Count = 0
                Application.DoEvents()
            Loop
        End If
        'Build The Constructor
        With TheBlackShellRunnerProject.Forms
            .Add(Me) 'needed for constructor to work
            .Add(frmOptions) 'needed for constructor to work
            .Add(frmSearch) 'also needed for constructor to work
            .Add(frmHistory) 'also needed for constructor to work
            .Add(frmCustomCommads) 'also needed for constructor to work
            .Add(frmBrowse) 'also needed for constructor to work
            .Add(frmFolderDialog) 'also needed for constructor to work
            .Add(frmAbout) 'also needed for constructor to work
            .Add(frmHidden) 'also needed for constructor to work
            .Add(frmEnvironmentCommands) 'also needed for constructor to work
            .Add(frmEnvironmentVariables) 'also needed for constructor to work
            .Add(frmIconList) 'also needed for constructor to work
            .Add(frmCorners) 'also needed for constructor to work
            .Add(frmMessageBox) 'also needed for constructor to work
        End With
        'Ditto
        With TheBlackShellRunnerProject.ColoredToolTips
            .Add(mcttMain)
            .Add(frmOptions.mcttMain)
            .Add(frmSearch.mcttMain)
            .Add(frmHistory.mcttMain)
            .Add(frmCustomCommads.mcttMain)
            .Add(frmBrowse.mcttMain)
            .Add(frmFolderDialog.mcttMain)
            .Add(frmHidden.mcttMain)
            .Add(frmEnvironmentCommands.mcttMain)
            .Add(frmEnvironmentVariables.mcttMain)
            .Add(frmIconList.mcttMain)
        End With
    End Sub

    Private Sub SetDefaultProperties()
        'Set Top Most Default Property
        Dim OnTop As Boolean = INIReadBoolean(INISettingsPath, "Settings", "SubWindowsOnTop")
        If OnTop Then
            For Each Window As Form In TheBlackShellRunnerProject.Forms
                With Window
                    .TopMost = False
                    If Not .Name = frmHidden.Name Then
                        .TopMost = True
                    End If
                End With
            Next
        End If
        'Enable Set Icon Timer
        With tmrSetIcon
            .Interval = 100
            .Enabled = True
        End With
        'Set Me Default Properties
        Dim ScaleFactor = 20
        Dim warec As Rectangle = My.Computer.Screen.WorkingArea
        MaximumSize = New Size(((warec.Width / ScaleFactor) * (ScaleFactor - 1)), ((warec.Height / ScaleFactor) * (ScaleFactor - 1)))
        Top = 1
        Left = 1
        KeyPreview = True
        'Set Blank Icon Image
        picMain.Image = Nothing
        'Set Main Form Position
        SetPosition(Me)
    End Sub

    Private Sub DisplayLicenseAgreementAndSetDefaultUserConfigSettings()
        'Settings Via my homemade binary settings module
        If Not PathExists(Settings.UserConfigBinaryFilePath, TypeOfPath.File) _
            And Not PathExists(INISettingsPath, TypeOfPath.File) Then
            Dim YNAgreement As DialogResult = MessageBox.Show("READ THIS IMPORTANT END USER LICENSE AGREEMENT!" _
                                                              & vbCrLf _
                                                              & vbCrLf _
                                                              & "This Power Tool BlackShellRunner8 STP (Shell Terminating Program) Full Version is FreeWare!" _
                                                              & vbCrLf _
                                                              & vbCrLf _
                                                              & "This program is provided for free as is without any guarantee or warranty of any kind. It was designed to be the ultimate systems administrator power tool. Using this program for evil and or malicious intent is entirely the fault of the user and shall not be associated with the architect/writer/designer CrestFallenBlackSheep AKA William Stanley Davis Or BlackCrestSoft. Any attempts to decompile and or reverse engineer this application is illegal and highly discouraged, and unappreciated by its developer. This is my way of saying use and don't steal my shit!" _
                                                              & vbCrLf _
                                                              & vbCrLf _
                                                              & "DO YOU FULLY AGREE AND ACCEPT THESE TERMS?",
                                                              "BlackCrestSoft End User License Agreement",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question)
            If YNAgreement = Windows.Forms.DialogResult.No Then
                End
            End If
        End If
        Settings.StringEncryptionPassword = BSRBinaryFilePassword
        Settings.StringEncryptionSalt = BSRBinaryFileSalt
        Settings.MakeDefaultSetting("ScreenPosition", New Point(1, 1)) 'New Point((My.Computer.Screen.WorkingArea.Width - Width), (My.Computer.Screen.WorkingArea.Height - Height)))
        Settings.MakeDefaultSetting("Size", New Size(627, 64))
        Settings.MakeDefaultSetting("DefaultText", "")
        Settings.MakeDefaultSetting("AlreadySavedRevert", False)
        Settings.MakeDefaultSetting("RevertPath", "")
        Settings.MakeDefaultSetting("RevertPATHEXT", "")
        Settings.MakeDefaultSetting("VersionStamp", "")
        Settings.MakeDefaultSetting("DirectoryPath", "")
        Settings.MakeDefaultSetting("FilePaths", Nothing)
        Settings.MakeDefaultSetting("EnvironmentIndices", Nothing)
        Settings.MakeDefaultSetting("OldSeparator", "%|%")
        Settings.MakeDefaultSetting("FileNames", "")
        '--------------------------------------------------------------'
        KeyForHash = BSRBinaryFilePassword
        SaltForHash = BSRBinaryFileSalt
    End Sub

    Private Sub KillProcessIfOpenByProgram(ByVal FilePath As String)
        Dim FileToCheckFor As String = FilePath.SPT("\").Last
        Dim ProcessList() As Process = Process.GetProcesses
        Dim CurrentTitle As String = ""
        For Index As Integer = 0 To ProcessList.GetUpperBound(0)
            CurrentTitle = ProcessList(Index).MainWindowTitle.ToString
            If CurrentTitle.CNT(FileToCheckFor) Then
                ProcessList(Index).Kill()
            End If
        Next
    End Sub

    Public Function ReadParameters() As String
        Dim FullParams As String = ""
        Dim Fp() As String = Nothing
        Fp = Environment.GetCommandLineArgs()
        FullParams = Fp.ToArray.JN(" ").SPT(".exe ").Last
        FullParams = FullParams.RSAtE("""").RSAtF("""")
        If FullParams.Length = 2 And FullParams Like "?:" Then FullParams = FullParams & "\"
        If FullParams.UC Like "?:\*.STP" Then
            FullParams = FullParams.SPT("\").Last.SPT(".").First.LC
        End If
        FullParams = FullParams.RP(Application.ExecutablePath, "").TRM.RP(".vshost", "")
        If FullParams.UC.CNT("\BLACKSHELLRUNNER.EXE") Then
            RestartElevated()
            Return ""
        End If
        RestartElevated(FullParams)
        Return FullParams
    End Function

    Private Sub CheckForRevert()
        Dim RvtBool As Boolean
        If PathExists(INISettingsPath, TypeOfPath.File) Then
            If Not INIRead(INISettingsPath, "Settings", "RevertToFactorySettings") = "" Then
                RvtBool = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "RevertToFactorySettings"))
                If RvtBool Then
                    RevertSettings()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub LoadINISettings()
        'Load INI Settings
        'NOTE The last value as Boolean can be found on frm1 shown event it controls the hide at startup option
        Dim val1, val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13 As Boolean
        If PathExists(INISettingsPath, TypeOfPath.File) Then
            LoadColors()
            If Not INIRead(INISettingsPath, "Settings", "Sound") = "" Then
                val1 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "Sound"))
                frmOptions.chkSound.Checked = val1
                'SetSounds(val1)
            End If
            Dim Sep As String = INIRead(INISettingsPath, "Settings", "CommandLineSeparator")
            Dim OSep As String = Settings.RetrieveSetting("OldSeparator")
            Dim Last As String = INIRead(INISettingsPath, "Settings", "LastCommand")
            If Not Last.TRM = "" Then
                cmbCmd.Text = Last
            End If
            If Not OSep = Sep Then
                cmbCmd.Text = ""
            End If
            ' Dim Opaque As String = INIRead(INISettingsPath, "Settings", "OpacityPercent")
            Dim gsVal, SpeedVal As Integer
            If Not INIRead(INISettingsPath, "Settings", "GraphicStrength") = "" Then
                gsVal = INIRead(INISettingsPath, "Settings", "GraphicStrength")
                modGraphics.BaseSleepTime = gsVal
            End If
            If Not INIRead(INISettingsPath, "Settings", "MoveSpeed") = "" Then
                SpeedVal = INIRead(INISettingsPath, "Settings", "MoveSpeed")
                modGraphics.MoveSpeed = SpeedVal
            End If
            If Not INIRead(INISettingsPath, "Settings", "Graphics") = "" Then
                val2 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "Graphics"))
                frmOptions.chkGraphics.Checked = val2
                modGraphics.HasGraphics = frmOptions.chkGraphics.Checked
            End If
            If Not INIRead(INISettingsPath, "Settings", "MS-DOS_PauseCheckNotVisible") = "" Then
                val3 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "MS-DOS_PauseCheckNotVisible"))
                frmOptions.chkDOSPause.Checked = val3
            End If
            If Not INIRead(INISettingsPath, "Settings", "IgnoreFlashRunAtStartUp") = "" Then
                val4 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "IgnoreFlashRunAtStartUp"))
                IgnoreFlashRunAtStartUp = val4
            End If
            If Not INIRead(INISettingsPath, "Settings", "RunAtStartUp") = "" Then
                val5 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "RunAtStartUp"))
                frmOptions.chkRunAtStartUp.Checked = val5
            End If
            If Not INIRead(INISettingsPath, "Settings", "MS-DOS_PauseChecked") = "" Then
                val6 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "MS-DOS_PauseChecked"))
                chkPws.Checked = val6
            End If
            If Not INIRead(INISettingsPath, "Settings", "ClassicHideMode") = "" Then
                val7 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "ClassicHideMode"))
                frmOptions.chkClassicHide.Checked = val7
            End If
            If Not INIRead(INISettingsPath, "Settings", "SnapToCorners") = "" Then
                val8 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "SnapToCorners"))
                frmOptions.chkSnap.Checked = val8
            End If
            If Not INIRead(INISettingsPath, "Settings", "ShowCornerGrid") = "" Then
                val9 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "ShowCornerGrid"))
                frmOptions.chkShowCorner.Checked = val9
            End If
            If Not INIRead(INISettingsPath, "Settings", "ResizeMarqueeFontSizeOnWindowResize") = "" Then
                val11 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "ResizeMarqueeFontSizeOnWindowResize"))
                If val11 Then
                    scrmrMain.ResizeTextFontOnResize = True
                Else
                    scrmrMain.ResizeTextFontOnResize = False
                End If
            End If
            If Not INIRead(INISettingsPath, "Settings", "StrechMarqueeToFitWindowSize") = "" Then
                val12 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "StrechMarqueeToFitWindowSize"))
                If val12 Then
                    StretchMarquee = True
                Else
                    StretchMarquee = False
                End If
            End If
            If Not INIRead(INISettingsPath, "Settings", "ExtenderToolTipStandardListBoxes") = "" Then
                val13 = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "ExtenderToolTipStandardListBoxes"))
                If val13 Then
                    ToolTipBoxStyle = ToolTipControlBoxStyle.BothCombosAndLists
                Else
                    ToolTipBoxStyle = ToolTipControlBoxStyle.JustCombos
                End If
            End If
            'Panel Loader
            If Not INIRead(INISettingsPath, "PanelLoader", "UseLoaderToLoadPathlessEXEFiles") = "" Then
                val13 = Convert.ToBoolean(INIRead(INISettingsPath, "PanelLoader", "UseLoaderToLoadPathlessEXEFiles"))
                If val13 Then
                    clsExecuteCommand.LoadDirectorylessAppsWithNoParametersIntoPanel = True
                Else
                    clsExecuteCommand.LoadDirectorylessAppsWithNoParametersIntoPanel = False
                End If
            End If
            'INIWrite(INISettingsPath, "Settings", "ExtenderToolTipStandardListBoxes", "False")
            If Not INIRead(INISettingsPath, "Settings", "RunThisCommandAtStartUp") = "" Then
                StartUpCommand = INIRead(INISettingsPath, "Settings", "RunThisCommandAtStartUp")
                frmCustomCommads.cmbStartUpCommand.Text = StartUpCommand
            End If
            Dim FileOrList As String = ""
            If Not INIRead(INISettingsPath, "Settings", "AutoCompleteMode") = "" Then
                FileOrList = INIRead(INISettingsPath, "Settings", "AutoCompleteMode")
                If FileOrList = "File" Then
                    frmOptions.rbFileSystem.Checked = True
                ElseIf FileOrList = "List" Then
                    frmOptions.rbListItems.Checked = True
                End If
            End If
            Dim MSDOSOrPowerShell As String = ""
            If Not INIRead(INISettingsPath, "Settings", "ConsoleMode") = "" Then
                MSDOSOrPowerShell = INIRead(INISettingsPath, "Settings", "ConsoleMode")
                If MSDOSOrPowerShell = "MS-DOS" Then
                    frmEnvironmentCommands.rbDOS.Checked = True
                ElseIf MSDOSOrPowerShell = "PowerShell" Then
                    frmEnvironmentCommands.rbPowerShell.Checked = True
                End If
            End If
            Dim BSRDelay As Double = 2
            If Not INIRead(INISettingsPath, "Settings", "CommandSeparatorDelay") = "" Then
                BSRDelay = Convert.ToDouble(INIRead(INISettingsPath, "Settings", "CommandSeparatorDelay"))
                If BSRDelay >= 1 And BSRDelay <= 10 Then
                    DelaySeconds = BSRDelay
                Else
                    DelaySeconds = 2
                End If
            End If
            Dim TOrientation As String = "Left"
            If Not INIRead(INISettingsPath, "Settings", "MarqueeCommandTextOrientation") = "" Then
                TOrientation = INIRead(INISettingsPath, "Settings", "MarqueeCommandTextOrientation")
                Dim SVal As AcidControls.AcidScrollingMarquee.TextOrientation
                Select Case TOrientation.UC.LT(1)
                    Case "L"
                        SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Left
                    Case "M"
                        SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Middle
                    Case "R"
                        SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Right
                End Select
                If TOrientation.UC Like "R*N*" Then SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Random
                Try
                    Select Case Convert.ToInt32(TOrientation.UC.LT(1))
                        Case Is = 0
                            SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Left
                        Case Is = 1
                            SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Middle
                        Case Is = 2
                            SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Right
                        Case Is = 3
                            SVal = AcidControls.AcidScrollingMarquee.TextOrientation.Random
                    End Select
                Catch
                End Try
                MarqueeTextOrientation = SVal
            End If
            Dim MaxFont As String = INIRead(INISettingsPath, "Settings", "StopWindowSizeChangeOnThisMarqueeFontSize")
            If Not MaxFont.TRM = "" Then
                Try
                    MaxScrollingMarqueeFontSize = Convert.ToInt32(MaxFont)
                Catch ex As Exception
                End Try
            End If
            Dim Home As String = ""
            If Not INIRead(INISettingsPath, "Internet", "SaferBrowserHomePage") = "" Then
                Home = INIRead(INISettingsPath, "Internet", "SaferBrowserHomePage")
                frmWebBrowse.HomePage = Home
            End If
            Dim Spawn As Boolean = False
            If Not INIRead(INISettingsPath, "Internet", "SpawnNewWindowOnChangingHostSite") = "" Then
                Spawn = INIReadBoolean(INISettingsPath, "Internet", "SpawnNewWindowOnChangingHostSite")
                frmWebBrowse.SpawnNewWindowOnHostSwitch = Spawn
            End If
        End If
    End Sub
    ' Private Sub CheckForAdmin()
    ' If Not IsAdministrator() Then
    '   MessageBox.Show("You must be an administrator to run this program.", "Admin Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    'Application.Exit()
    'End If
    'End Sub

    Private Sub FinalCheckForLoad()
        'Check To See I She'll Run
        Dim a As DialogResult
        If Not PathExists("c:\Windows\System32\WindowsPowerShell", TypeOfPath.Directory) Then
            If IsFlashDirectory() Then
                a = MessageBox.Show("You need Microsoft Windows PowerShell to run this program. Installation files for PowerShell and the .Net Framework 2.0 Sevice Pack 1 it may require can be found on your BlackShellRunner Portable disk image. Do you wish to open and view this flash drive directory?",
                                    "PowerShell Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If a = vbYes Then
                    clsExecuteCommand.ShellExecute(0&, "Open", ReturnU3Path, vbNullString, vbNullString, vbNormalNoFocus)
                End If
            Else
                a = MessageBox.Show("You need Windows PowerShell to run this program. Do you wish to search for PowerShell download for your version of Windows on Google?",
                                    "PowerShell Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If a = vbYes Then
                    Dim WhatOS As String = OSName
                    clsExecuteCommand.ShellExecute(0&, "Open", "https://www.google.com/#sclient=psy-ab&q=where+can+I+download+powershell+for+" & WhatOS.RP(" ", "+"), vbNullString, vbNullString, vbNormalNoFocus)
                End If
            End If
            Delay(5)
            End
        End If
        Dim ToHaveNewMachineEnvironmentCommandListWindowVisible As Boolean = True
        If PathExists(INISettingsPath, TypeOfPath.File) Then
            Dim Visible As String = INIRead(INISettingsPath, "Settings", "NewMachineCommandListBuildVisible")
            If Not Visible = "" Then ToHaveNewMachineEnvironmentCommandListWindowVisible = Convert.ToBoolean(Visible)
        End If
        If Not ToHaveNewMachineEnvironmentCommandListWindowVisible Then
            If Settings.RetrieveSetting("FilePaths") Is Nothing Then
                With frmEnvironmentCommands
                    .WindowState = FormWindowState.Minimized
                    .Show()
                    Do Until .Complete
                        Application.DoEvents()
                    Loop
                    .Hide()
                    .WindowState = FormWindowState.Normal
                End With
            End If
        Else
            If Settings.RetrieveSetting("FilePaths") Is Nothing Then
                With frmEnvironmentCommands
                    Dim RevertColor As Color = .alConsoleMode.ForeColor
                    Dim RevertText As String = .alConsoleMode.Text
                    .StartPosition = FormStartPosition.CenterScreen
                    .alConsoleMode.Text = "BlackCrestSoft Welcomes You! Building New Machine Specific Environment Variable Command List. BlackShellRunner Will Launch Soon! Please Be Patient."
                    .BuildingListForFirstBSRRunOnThisComputer = True
                    .Show()
                    Do Until .Complete
                        Application.DoEvents()
                    Loop
                    .Hide()
                    .BuildingListForFirstBSRRunOnThisComputer = False
                    .alConsoleMode.ForeColor = RevertColor
                    .alConsoleMode.Text = RevertText
                    .StartPosition = FormStartPosition.CenterParent
                End With
            End If
        End If
    End Sub

    Protected FullINITitleComment As String = ""

    Protected Function GetFullINIComment()
        'Set Assembly Version Info
        Dim BSRMajor As String = ""
        Dim BSRMinor As String = ""
        With My.Application.Info.Version
            BSRMajor = .Major
            BSRMinor = .Minor
        End With
        Dim BSRVersion As String = BSRMajor & "." & BSRMinor
        Settings.MakeSetting("VersionStamp", BSRVersion)
        'Set INI User Config File Tiitle
        Dim INITitleLeft As String = "#<{"
        Dim INITitleRight As String = "}>#"
        Dim BSRName = " BLaCkSheLLRuNNeR "
        If FlashDirectory Then
            BSRName = BSRName & "PorTAbLe "
        End If
        Dim INICommentTitle As String = INITitleLeft & BSRName & BSRVersion & " INI User Config Settings (Made And Written By: William Stanley Davis)" & INITitleRight
        Dim INILineLength As Integer = INICommentTitle.LN - (((INITitleLeft.LN + INITitleRight.LN) \ 2) * 2)
        Dim INILine As New String("-"c, INILineLength)
        Dim INITitleLine As String = INITitleLeft & INILine & INITitleRight
        FullINITitleComment =
                          INITitleLine &
                           CL & INICommentTitle &
                           CL & INITitleLine &
                           CL & CL & "#These Are General Settings Set Mostly In Part By The GUI"
        Return FullINITitleComment
    End Function

    Protected Property WelcomeMessage As String = ""

    Protected Function UpdateINIUserConfigVersionComment() As Boolean
        Dim TheINITitleComment As String = GetFullINIComment()
        'Replace With New Version Info
        Dim INIText As String = IO.File.ReadAllText(INISettingsPath)
        If Not INIText.CNT(Settings.RetrieveSetting("VersionStamp").ToString & " ") Then
            Dim TheFirstComment As Integer
            Dim INITextWithoutOldVersion As String ''
            Dim BSRStartUpMessage As String = "BlackCrestSoft Welcomes You To BlackShellRunner "
            TheFirstComment = InStr(INIText, "[Settings]", CompareMethod.Text)
            INITextWithoutOldVersion = INIText.RT((INIText.LN - TheFirstComment) + 1)
            IO.File.WriteAllText(INISettingsPath, INITextWithoutOldVersion)
            INICommentSection(INISettingsPath, "Settings", TheINITitleComment)
            If FlashDirectory Then
                BSRStartUpMessage = BSRStartUpMessage & " Portable "
            End If
            Size = Settings.RetrieveSetting("Size")
            WelcomeMessage = BSRStartUpMessage & " Version " & Settings.RetrieveSetting("VersionStamp") & " !"
            Return True
        End If
        Return False
    End Function

    Private Sub MakeSomeDefaultSettingsAndCommands()
        'If INI Settings Don't Exist Make Some Default Settings
        If Not PathExists(INISettingsPath, TypeOfPath.File) Then
            INIWrite(INISettingsPath, "Settings", "RevertToFactorySettings", "False")
            'This One Is Loaded Upon Setting Default Properties It Must Have A Default Value Of True To Begin With To Be Completly Accurate
            INIWrite(INISettingsPath, "Settings", "SubWindowsOnTop", "True")
            'These Are In The Order Of Which They Are Loaded
            INIWrite(INISettingsPath, "Settings", "Sound", "True")
            INIWrite(INISettingsPath, "Settings", "LastCommand", "")
            INIWrite(INISettingsPath, "Settings", "GraphicStrength", "")
            INIWrite(INISettingsPath, "Settings", "MoveSpeed", "7")
            INIWrite(INISettingsPath, "Settings", "Graphics", "True")
            If FlashDirectory Then
                INIWrite(INISettingsPath, "Settings", "IgnoreFlashRunAtStartUp", "False")
            End If
            INIWrite(INISettingsPath, "Settings", "StartHidden", "False")
            INIWrite(INISettingsPath, "Settings", "RunAtStartUp", "False")
            INIWrite(INISettingsPath, "Settings", "MS-DOS_PauseCheckNotVisible", "False")
            INIWrite(INISettingsPath, "Settings", "MS-DOS_PauseChecked", "False")
            INIWrite(INISettingsPath, "Settings", "ClassicHideMode", "False")
            INIWrite(INISettingsPath, "Settings", "SnapToCorners", "True")
            INIWrite(INISettingsPath, "Settings", "ShowCornerGrid", "True")
            INIWrite(INISettingsPath, "Settings", "ShowExtenderToolTips", "True")
            INIWrite(INISettingsPath, "Settings", "ExtenderToolTipStandardListBoxes", "True")
            INIWrite(INISettingsPath, "Settings", "AutoRaiseWindows", "False")
            'Some Non Boolean String And Integer Settings
            INIWrite(INISettingsPath, "Settings", "RunThisCommandAtStartUp", "")
            INIWrite(INISettingsPath, "Settings", "AutoCompleteMode", "File")
            INIWrite(INISettingsPath, "Settings", "ConsoleMode", "PowerShell")
            INIWrite(INISettingsPath, "Settings", "CommandLineSeparator", "%|%")
            INIWrite(INISettingsPath, "Settings", "CommandSeparatorDelay", "2")
            'This Is Used On Final Check For Load Sub
            INIWrite(INISettingsPath, "Settings", "NewMachineCommandListBuildVisible", "True")
            'This Is Activated On Setting Final Properties
            INIWrite(INISettingsPath, "Settings", "OpacityPercent", "80")
            INIWrite(INISettingsPath, "Settings", "MarqueePixelsPerTick", "1")
            INIWrite(INISettingsPath, "Settings", "PacManMode", "True")
            INIWrite(INISettingsPath, "Settings", "MarqueeCommandTextOrientation", "Left")
            INIWrite(INISettingsPath, "Settings", "StrechMarqueeToFitWindowSize", "True")
            INIWrite(INISettingsPath, "Settings", "ResizeMarqueeFontSizeOnWindowResize", "True")
            INIWrite(INISettingsPath, "Settings", "MarqueeDefaultText", "Run PowerShell Program Path URL Or MS-DOS Command")
            INIWrite(INISettingsPath, "Settings", "ResizeWindowOnMarqueeTextChange", "True")
            INIWrite(INISettingsPath, "Settings", "StopWindowSizeChangeOnThisMarqueeFontSize", "24")
            INIWrite(INISettingsPath, "Settings", "AlwaysAddShellExtension", "False")
            INIWrite(INISettingsPath, "Settings", "CloseAfterExecutingParameters", "True")
            INIWrite(INISettingsPath, "Settings", "IgnoreAssociationQuestion", "False")
            INIWrite(INISettingsPath, "Settings", "NeverAssociateSTPFiles", "False")
            INIWrite(INISettingsPath, "Settings", "HasBackground", "False")
            'These INI Settings Are Loaded On Executing A Web Address
            INIWrite(INISettingsPath, "Internet", "UseSaferBrowser", "False")
            INIWrite(INISettingsPath, "Internet", "SaferBrowserHomePage", "www.google.com")
            INIWrite(INISettingsPath, "Internet", "StoreSaferBrowserAddresses", "True")
            INIWrite(INISettingsPath, "Internet", "PromptForCleanup", "True")
            INIWrite(INISettingsPath, "Internet", "SpawnNewWindowOnChangingHostSite", "True")
            'These INI Settings Are Loaded On Running A MS-DOS Command
            INIWrite(INISettingsPath, "MS-DOS", "BatchFileColorByte", "0F")
            INIWrite(INISettingsPath, "MS-DOS", "KeepGeneratedBatchFile", "True")
            INIWrite(INISettingsPath, "MS-DOS", "EchoEntireBatch", "False")
            INIWrite(INISettingsPath, "MS-DOS", "Echo", "True")
            'Encrypted Color Settings Loaded On Run
            INIWrite(INISettingsPath, "Encrypted Settings", "ForeColor", "")
            INIWrite(INISettingsPath, "Encrypted Settings", "BackColor", "")
            INIWrite(INISettingsPath, "Encrypted Settings", "ShadowColor", "")
            'Add INI Comments
            INIClearCommentedSections()
            'Settings Comment
            INICommentSection(INISettingsPath, "Settings", FullINITitleComment)
            'Internet Comment
            INICommentSection(INISettingsPath, "Internet",
                              CL & "#These Are Internet Web Settings For Opening Addresses In Default Or BSR Safer Browser")
            'MS-DOS Comment
            INICommentSection(INISettingsPath, "MS-DOS",
                              CL & "#These Are MS-DOS Batch File Options")
            'PanelLoader Comment
            INICommentSection(INISettingsPath, "PanelLoader",
                              CL & "#This Determine Using Panel Loader To Open Files Such As Notepad" &
                              CL & "#By Calling A Command Such As 'notepad.exe'" &
                              CL & "#As Well As Other Settings For The Panel Loader")
            'Encrypted Comment
            INICommentSection(INISettingsPath, "Encrypted Settings",
                              CL & "#These Are Color Settings Set By The GUI" &
                              CL & "#The Reason They Are Encrypted Is So No One Changes All Of Them To The Same Color" &
                              CL & "#This Would Make It Impossible To See The Controls. By Default They Are All Set To " & Qt & Qt &
                              CL & "#Which Triggers It To Load Default Colors ( Lime, Black, And Green )")
        End If
        'Make Default Commands So List Is Not Null''
        If Not PathExists(TheFlashOrRegularDirectoryPath & "\BSR_BIN\BSR_LST.BIN", TypeOfPath.File) Then
            AddLst("Cascade", cmbCmd, True, , , False)
            AddLst("MinimizeAll", cmbCmd, True, , , False)
            AddLst("UnMinimizeAll", cmbCmd, True, , , False)
            AddLst("TileVertically", cmbCmd, True, , , False) '
            AddLst("TileHorizontally", cmbCmd, True, , , False)
            AddLst("echo Hello&&echo World", cmbCmd, True, , , False)
            AddLst("echo Hello; echo World", cmbCmd, True, , , False)
            AddLst("echo Hello&&echo World" & CommandLineSeparator & "echo Hello; echo World", cmbCmd, True, , , False)
            AddLst("SMD C:\Hello\World" & CommandLineSeparator & "SOD C:\Hello\World", cmbCmd, True, , , False)
        End If
    End Sub

    Private Sub FormShown()
        modGraphics.MainForm = Me
        SetAllMainProperties()
        ' If TopLeft Then
        'pnlResizeRightBottom.Visible = True
        'Else
        'pnlResizeRightBottom.Visible = False
        'End If
        LoadLst(cmbCmd)
        Dim TheText As String = INIRead(INISettingsPath, "Settings", "MarqueeDefaultText")
        SetBackToDefaultMarqueeText()
        MarqueeDefaultText = TheText
        Size = Settings.RetrieveSetting("Size")
        ' With scrmrMain
        ' MinimumSize = New Size(627, 64) '(Width - cmbCmd.Width) + TextRenderer.MeasureText(TheText,
        '                                                                           New Font(.Font.FontFamily, .DefaultFont.Size, .Font.Style)).Width,
        'MinimumSize.Height)
        ' End With
        If INIReadBoolean(INISettingsPath, "Settings", "ResizeWindowOnMarqueeTextChange") Then
            If Not TheText = Settings.RetrieveSetting("DefaultText") Then
                With scrmrMain
                    Settings.MakeSetting("DefaultText", TheText)
                    Size = New Size((Width - cmbCmd.Width) + TextRenderer.MeasureText(TheText,
                                                                                            New Font(.Font.FontFamily, DefaultFont.Size, .Font.Style)).Width,
                                                                                        MinimumSize.Height)
                End With
            End If
        End If
        StraightenMeEdges(False)
        If frmOptions.chkSound.Checked Then
            My.Computer.Audio.Play(HideShowSound, AudioPlayMode.Background)
        End If
        Dim PixelsPerTick As String = INIRead(INISettingsPath, "Settings", "MarqueePixelsPerTick")
        Dim MarqueeTimerSpeed As String = INIRead(INISettingsPath, "Settings", "MarqueeSpeed")
        If Not PixelsPerTick = "" Then
            Dim PPT As Integer = CInt(PixelsPerTick)
            If PPT > 10 Then PPT = 10
            If PixelsPerTick < 1 Then PixelsPerTick = 1
            scrmrMain.PixelsPerTick = PixelsPerTick
        End If
        If Not MarqueeTimerSpeed = "" Then
            Dim MTS As Double = CDbl(MarqueeTimerSpeed)
            scrmrMain.DelaySeconds = MTS
        End If
        Dim val As Boolean
        Dim IsJustMeHide As Boolean = True
        If PathExists(INISettingsPath, TypeOfPath.File) Then
            If Not INIRead(INISettingsPath, "Settings", "StartHidden") = "" Then
                val = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "StartHidden"))
                frmOptions.chkStartHidden.Checked = val
                If val = True Then
                    If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(HideShowSound, AudioPlayMode.Background)
                    HideAllForms(IsJustMeHide)
                End If
            End If
        End If
        'Display Welcome Message
        Dim UpdatedVersion As Boolean = UpdateINIUserConfigVersionComment()
        If UpdatedVersion And Not WelcomeMessage = MarqueeDefaultText Then
            With scrmrMain
                .Stopped = True
                .Refresh()
                .MarqueeText = WelcomeMessage
                .Refresh()
                .Stopped = False
                Do Until .StartPosition <= (.Width / 2) - (TextRenderer.MeasureText(.MarqueeText, .Font).Width / 2)
                    Application.DoEvents()
                Loop
                .StoppedTextOrientation = AcidControls.AcidScrollingMarquee.TextOrientation.Middle
                .Stopped = True
                SetBackToDefaultMarqueeText()
            End With
        End If
        '  pnlResizeRightBottom.Visible = True
        Dim HasPacMan As Boolean = INIReadBoolean(INISettingsPath, "Settings", "PacManMode")
        If HasPacMan Then
            FormsList = TheBlackShellRunnerProject.Forms
            TurnOnPacMan()
        End If
        Dim enabled As Boolean = INIReadBoolean(INISettingsPath, "Settings", "HasBackground")
        If enabled Then
            Dim BackGroundOpacity As String = ""
            BackGroundOpacity = INIRead(INISettingsPath, "Settings", "BackgroundTransparency")
            If BackGroundOpacity <> "" Then
                frmOptions.tbPicOpacity.Value = Convert.ToInt32(BackGroundOpacity)
            End If
            Dim FileName As String = ""
            FileName = INIRead(INISettingsPath, "Settings", "Background")
            If FileName <> "" Then
                PicturePath = GifDirectory & "\" & FileName
                SetBackGroundAnimation(PicturePath)
            End If
        End If
        frmOptions.chkPic.Checked = enabled
        If Not Para = "" Then
            Dim CloseBool As Boolean = INIReadBoolean(INISettingsPath, "Settings", "CloseAfterExecutingParameters")
            If CloseBool Then
                TheBlackShellRunnerProject.RunCommand(Para)
                If HasOutputWindow() Then
                    Do Until IsClosed
                        Application.DoEvents()
                    Loop
                End If
                End
            Else
                TheBlackShellRunnerProject.RunCommand(Para)
            End If
        Else
            Dim StartupCmd As String = INIRead(INISettingsPath, "Settings", "RunThisCommandAtStartup")
            If Not StartupCmd = "" Then
                TheBlackShellRunnerProject.RunCommand(StartupCmd)
            End If
        End If
    End Sub

    Public Sub MakeAllKeysAndExtensions()
        If Not FlashDirectory Then
            MakeShellExtension("*")
            MakeShellExtension("Drive")
            MakeShellExtension("Directory")
            AssociateSTPExtension()
            frmOptions.abMakeShellExtension.Text = "Associated!"
        Else
            Dim YN As DialogResult = MessageBox.Show("BlackShellRunner May Be Running From A Flash Drive Associate Still?", "Associate Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If YN = DialogResult.Yes Then
                MakeShellExtension("*")
                MakeShellExtension("Drive")
                MakeShellExtension("Directory")
                AssociateSTPExtension()
                frmOptions.abMakeShellExtension.Text = "Associated!"
            End If
        End If
    End Sub
    Public Shared Sub RestartElevated(Optional ByVal args As String = "")
        ' Elevate the process if it is not run as administrator.
        If (Not IsRunningAsAdmin()) Then
            ' Launch itself as administrator
            Dim proc As New ProcessStartInfo
            proc.UseShellExecute = True
            proc.WorkingDirectory = Environment.CurrentDirectory
            proc.FileName = Application.ExecutablePath
            proc.Verb = "runas"
            proc.Arguments = args

            Try
                Process.Start(proc)
            Catch
                ' The user refused the elevation.
                Return
            End Try

            End ' Quit itself
        Else
            'The process is already running as administrator
        End If
    End Sub

    Public Shared Function IsRunningAsAdmin() As Boolean
        Dim principal As New WindowsPrincipal(WindowsIdentity.GetCurrent)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Public Sub LoadAllSettings(Optional ByVal ClearConstructor As Boolean = False)
        'Put hEr In a Try Catch Block 4 bug squashing
        Try
            '<---------------------------------------------------------------------------------------------->'
            '<-This-Set-The-Paths-Is-A-Shortcut-Subroutine-to-ModFile-SetAllBSRPaths->'
            SetThePaths()
            '<---------------------------------------------------------------------------------------------->'
            '<-Checks-To-See-If-Revert-Is-being-requested-by-the-user---------------------->'
            CheckForRevert()
            '<---------------------------------------------------------------------------------------------->'
            '<-KIlls-Open-Processes-That-May-Interfere-With-Loading-Process------------>'
            KillProcessIfOpenByProgram(Settings.UserConfigBinaryFilePath)
            KillProcessIfOpenByProgram(INISettingsPath)
            '<---------------------------------------------------------------------------------------------->'
            '<-Builds-The-Constructor-For-Properties---------------------------------------------->'
            BuildConstructor(ClearConstructor)
            '<---------------------------------------------------------------------------------------------->'
            '<-Shows-License-And-Sets-Config----------------------------------------------------->'
            DisplayLicenseAgreementAndSetDefaultUserConfigSettings()
            '<---------------------------------------------------------------------------------------------->'
            '<-Sets-Default-Properties--------------------------------------------------------------->'
            SetDefaultProperties()
            '<---------------------------------------------------------------------------------------------->'
            '<-Makes-Default-Config------------------------------------------------------------------>'
            MakeSomeDefaultSettingsAndCommands()
            '<---------------------------------------------------------------------------------------------->'
            '<-Loads-INI-User-Configuration-File-------------------------------------------------->'
            LoadINISettings()
            '<--------------------------------------------------------------------------------------------->'
            '<-Final-Check-To-See-If-She-Will-Work-Correctly--------------------------------->'
            FinalCheckForLoad()
            Dim warec As Rectangle = My.Computer.Screen.WorkingArea
            MaximumSize = New Size((warec.Width / MaximumSizeDivisor), (warec.Height / MaximumSizeDivisor))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "BlackShellRunner Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub SetThePaths()
        SetAllBSRDirectoryPaths()
    End Sub

    Private Sub RevertSettings()
        Dim YNRevert As DialogResult = MessageBox.Show("This Will Revert To Factory BlackShellRunner Settings. Do You Wish To Continue?", "Revert BlackShellRunner Settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If YNRevert = DialogResult.Yes Then
            Dim LogStr As New StringBuilder
            Dim YNRevertCustom As DialogResult = MessageBox.Show("Do You Wish To Revert Custom Commands? Not Reverting Custom Commands Should Not Effect The Way BlackShellRunner Operates, And Will Not Fix Any Problems You Are Having. ", "Revert Custom Commands?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If YNRevertCustom = DialogResult.Yes Then
                'Delete Icons
                If PathExists(IconDirectoryPath, TypeOfPath.Directory) Then
                    IO.Directory.Delete(IconDirectoryPath, True)
                    LogStr.AppendLine("Deleted Custom Commands Icon Directory > " & IconDirectoryPath)
                End If
                'Delete Custom Commands
                If PathExists(BinaryFileDirectoryPath, TypeOfPath.Directory) Then
                    IO.Directory.Delete(BinaryFileDirectoryPath, True)
                    LogStr.AppendLine("Deleted Custom Commands And Main List Binary Directory > " & BinaryFileDirectoryPath)
                End If
                'Create New Binary Directory
                If Not PathExists(BinaryFileDirectoryPath, TypeOfPath.Directory) Then
                    IO.Directory.CreateDirectory(BinaryFileDirectoryPath)
                    LogStr.AppendLine("Created New Blank Custom Commands And Main List Binary Directory > " & BinaryFileDirectoryPath)
                End If
            End If
            'Delete INI File
            If PathExists(INISettingsPath, TypeOfPath.File) Then
                IO.File.Delete(INISettingsPath)
                LogStr.AppendLine("Deleted INI User Configuration Settings File > " & INISettingsPath)
            End If
            If PathExists(UserConfigFolder, TypeOfPath.Directory) Then
                IO.Directory.Delete(UserConfigFolder)
            End If
            'Delete STP Folder
            If PathExists(STPFolder, TypeOfPath.Directory) Then
                My.Computer.FileSystem.DeleteDirectory(STPFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)
                LogStr.AppendLine("Deleted STP Command File Directory > " & STPFolder)
            End If
            'Delete Binary File Directory
            If PathExists(SoundDirectoryPath, TypeOfPath.Directory) Then
                IO.Directory.Delete(SoundDirectoryPath, True)
                LogStr.AppendLine("Deleted Sound Directory > " & SoundDirectoryPath)
            End If
            'Delete Sound File Directory
            If PathExists(ListHistoryPath, TypeOfPath.File) Then
                IO.File.Delete(ListHistoryPath)
                LogStr.AppendLine("Deleted Combo List History > " & ListHistoryPath)
            End If
            'Delete User Binary Encrypted User Configuration File
            If PathExists(UserConfigPath, TypeOfPath.File) Then
                IO.File.Delete(UserConfigPath)
                LogStr.AppendLine("Deleted BlackShellRunner Binary User Configuration Application Data File > " & UserConfigPath)
            End If
            IO.File.WriteAllText(RevertTextLogPath, LogStr.ToString)
            MessageBox.Show("A Revert Log Has Been Created At > " & RevertTextLogPath, "Revert Log Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Reload Settings
            LoadAllSettings(True)
        ElseIf YNRevert = Windows.Forms.DialogResult.No Then
            'The User Does Not Wish To Revert To Factory Settings
            INIWrite(INISettingsPath, "Settings", "RevertToFactorySettings", "False")
        End If
    End Sub

    Private Sub SetBackToDefaultMarqueeText()
        With scrmrMain
            .MarqueeText = MarqueeDefaultText
            .StoppedTextOrientation = AcidControls.AcidScrollingMarquee.TextOrientation.Left
            .Stopped = True
        End With
    End Sub

#End Region

#End Region

#Region "Event_Blocks"

    Private Sub frm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAllSettings()
    End Sub

    Private Sub frm1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each form As Form In TheBlackShellRunnerProject.Forms
            form.Visible = False
            form.Dispose()
        Next
        If e.CloseReason = CloseReason.WindowsShutDown Then
            Application.Exit()
        End If
        Application.Exit()
    End Sub

    Private Sub frm1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'clockwise
        If e.KeyCode = Keys.F1 Then
            If TopLeft() = True Then
                If Left > 1 Or Top > 1 Then
                    GoTopLeft(True, True)
                Else
                    GoRight()
                End If
                GoTo SavePos
            End If
            If TopRight() = True Then
                If Left + Width < My.Computer.Screen.WorkingArea.Width Or Top > 1 Then
                    GoTopRight(True, False)
                Else
                    GoDown()
                End If
                GoTo SavePos
            End If
            If BottomRight() = True Then
                If Left + Width < My.Computer.Screen.WorkingArea.Width Or Top + Height < My.Computer.Screen.WorkingArea.Height Then
                    GoBottomRight(True, True)
                Else
                    GoLeft()
                End If
                GoTo SavePos
            End If
            If BottomLeft() = True Then
                If Left > 1 Or Top + Height < My.Computer.Screen.WorkingArea.Height Then
                    GoBottomLeft(True, False)
                Else
                    GoUp()
                End If
                GoTo SavePos
            End If
        End If
        'counter clockwise
        If e.KeyCode = Keys.F2 Then
            If TopLeft() = True Then
                If Left > 1 Or Top > 1 Then
                    GoTopLeft(True, False)
                Else
                    GoDown()
                End If
                GoTo SavePos
            End If
            If BottomLeft() = True Then
                If Left > 1 Or Top + Height < My.Computer.Screen.WorkingArea.Height Then
                    GoBottomLeft(True, True)
                Else
                    GoRight()
                End If
                GoTo SavePos
            End If
            If BottomRight() = True Then
                If Left + Width < My.Computer.Screen.WorkingArea.Width Or Top + Height < My.Computer.Screen.WorkingArea.Height Then
                    GoBottomRight(True, False)
                Else
                    GoUp()
                End If
                GoTo SavePos
            End If
            If TopRight = True Then
                If Left + Width < My.Computer.Screen.WorkingArea.Width Or Top > 1 Then
                    GoTopRight(True, True)
                Else
                    GoLeft()
                End If
                GoTo SavePos
            End If
        End If
SavePos:
        SavePosition(Me)
    End Sub

    Public Shared frmLastWidth As Integer = 0
    Public Shared frmLastHeight As Integer = 0
    Public Shared frmWidth As Integer
    Public Shared frmHeight As Integer
    Public Shared frmIsResizing As Boolean = False
    Protected frmRectangle As New System.Drawing.Rectangle()

    Private Sub ResizeMe_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlResizeRightBottom.MouseUp
        If frmIsResizing Then
            frmRectangle.Location = New System.Drawing.Point(Left, Top)
            frmRectangle.Size = New System.Drawing.Size(frmWidth, frmHeight)
            Width = frmWidth
            Height = frmHeight
            frmIsResizing = False
        End If
        Size = New Size(frmRectangle.Width, frmRectangle.Height)
        StraightenMeEdges(frmOptions.chkGraphics.Checked)
        Settings.MakeSetting("Size", Size)
        SavePosition(Me)
    End Sub

    Private Sub ResizeMe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlResizeRightBottom.MouseDown
        frmRectangle.Location = New System.Drawing.Point(Left, Top)
        frmRectangle.Size = New System.Drawing.Size(frmWidth, frmHeight)
        Size = New Size(frmRectangle.Width, frmRectangle.Height)
    End Sub

    Private Sub ResizeMe_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlResizeRightBottom.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim sizeageX As Integer
            sizeageX = MousePosition.X - Left
            Dim sizeageY As Integer
            sizeageY = MousePosition.Y - Top
            ' Use this to restrict Width
            If sizeageX < MinimumSize.Width Then
                sizeageX = MinimumSize.Width
            End If
            If sizeageX > MaximumSize.Width Then
                sizeageX = MaximumSize.Width
            End If
            ' Use this to restrict Height
            If sizeageY < MinimumSize.Height Then
                sizeageY = MinimumSize.Height
            End If
            If sizeageY > MaximumSize.Height Then
                sizeageY = MaximumSize.Height
            End If
            frmWidth = sizeageX
            frmHeight = sizeageY
            If frmLastWidth = 0 Then
                frmLastWidth = frmWidth
            End If
            If frmLastHeight = 0 Then
                frmLastHeight = frmHeight
            End If
            If frmIsResizing Then
                frmRectangle.Location = New System.Drawing.Point(Left, Top)
                frmRectangle.Size = New System.Drawing.Size(frmLastWidth, frmLastHeight)
                Size = New Size(frmRectangle.Width, frmRectangle.Height)
                Refresh()
            End If
            frmIsResizing = True
            frmLastWidth = frmWidth
            frmLastHeight = frmHeight
            frmRectangle.Location = New System.Drawing.Point(Left, Top)
            frmRectangle.Size = New System.Drawing.Size(frmWidth, frmHeight)
        End If
    End Sub

    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles alDOSPause.MouseDown, scrmrMain.MouseDown, abBrdr.MouseDown
        'clsObjectMover.FocusObject(Handle)
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Top 'Sets variable mousey
        Cursor = Cursors.SizeAll
        If frmOptions.chkShowCorner.Checked Then
            clsExecuteCommand.HideAllFormsButMain()
            frmCorners.Show()
        End If
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles alDOSPause.MouseMove, scrmrMain.MouseMove, abBrdr.MouseMove
        ' clsObjectMover.MoveObject(Handle)
        'If drag is set to true then move the form accordingly.
        If drag Then
            Top = Windows.Forms.Cursor.Position.Y - mousey
            Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles alDOSPause.MouseUp, scrmrMain.MouseUp, abBrdr.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
        Cursor = Cursors.Default
        frmCorners.Hide()
        ' StopPacMan()
        If frmOptions.chkSnap.Checked Then
            SnapToGrid()
        End If
        clsExecuteCommand.ShowAllFormsButMain()
        Try
            If Not frmOptions.chkSnap.Checked Then SavePosition(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrReturnTxt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReturnTxt.Tick
        If Not clsExecuteCommand.NoAssociatedProgram Then
            scrmrMain.MarqueeText = MarqueeDefaultText
            scrmrMain.Stopped = True
        End If
        If clsExecuteCommand.ThereIsADOSError Then
            scrmrMain.Stopped = False
            scrmrMain.MarqueeText = modPowerShell.TheErrorText
        End If
        tmrReturnTxt.Enabled = False
    End Sub

    Private Sub tmrSetIcon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSetIcon.Tick
        SetIcon()
    End Sub

    Private Sub alX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abX.Click
        On Error Resume Next
        SavePosition(Me)
        'If FlashDirectory Then RemoveShellExtension()
        Close()
    End Sub

    Private Sub abRn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abRn.Click
        Run()
    End Sub

    Private Sub abBrws_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abBrws.Click
        frmBrowse.LastCommand = cmbCmd.Text
        frmBrowse.Show()
    End Sub

    Private Sub abOptns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abOptns.Click
        frmOptions.Show()
    End Sub

    Private Sub abSrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abSrch.Click
        frmSearch.LastCommand = cmbCmd.Text
        frmSearch.Show()
    End Sub

    Private Sub tmrInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInfo.Tick
        On Error Resume Next
        Static old As String = ""
        If Not cmbCmd.Text = old Then
            old = cmbCmd.Text
            If cmbCmd.Text Like "?:\*" Or cmbCmd.Text Like "\*" Then
                Dim SpcNum As Single = 20
                Dim fileat As New IO.FileInfo(cmbCmd.Text)
                Dim filetype As String = clsFileType.GetFileType(fileat.Extension)
                If PathExists(cmbCmd.Text, TypeOfPath.File) And Not cmbCmd.Text.Contains("\\") Then
                    scrmrMain.MarqueeText =
                     "File Name > " & fileat.Name &
                    Space(SpcNum) & "In Directory > " & fileat.DirectoryName &
                    Space(SpcNum) & "Created On > " & fileat.CreationTime &
                    Space(SpcNum) & "Last Modified > " & FileDateTime(cmbCmd.Text) &
                    Space(SpcNum) & "Size > " & BytesToString(fileat.Length) &
                    Space(SpcNum) & "File Type > " & filetype &
                    Space(SpcNum) & "File Extension > " & fileat.Extension
                    scrmrMain.Stopped = False
                    mcttMain.SetToolTip(cmbCmd, "File Name > " & fileat.Name &
                    vbCrLf & "In Directory > " & fileat.DirectoryName &
                    vbCrLf & "Created On > " & fileat.CreationTime &
                    vbCrLf & "Last Modified > " & FileDateTime(cmbCmd.Text) &
                    vbCrLf & "Size > " & BytesToString(fileat.Length) &
                    vbCrLf & "File Type > " & filetype &
                    vbCrLf & "File Extension > " & fileat.Extension)
                ElseIf PathExists(cmbCmd.Text, TypeOfPath.Directory) And Not cmbCmd.Text.Contains("\\") Then
                    Dim MT As String = JN(Directory.GetFiles(cmbCmd.Text), ", ")
                    Dim MTT As String = JN(Directory.GetFiles(cmbCmd.Text), vbCrLf)
                    If Not MT = "" Then
                        scrmrMain.Stopped = False
                        scrmrMain.MarqueeText =
                            "Files Inside Directory " & cmbCmd.Text & " > " & MT
                    End If
                    If Not MTT = "" Then
                        mcttMain.SetToolTip(cmbCmd, "Files Inside Directory >" & vbCrLf & MTT)
                    End If
                Else
                    mcttMain.SetToolTip(cmbCmd, "Enter Your Command And Press Enter.")
                    scrmrMain.MarqueeText = MarqueeDefaultText
                    scrmrMain.Stopped = True
                End If
            Else
                mcttMain.SetToolTip(cmbCmd, "Enter Your Command And Press Enter.")
                scrmrMain.MarqueeText = MarqueeDefaultText
                scrmrMain.Stopped = True
            End If
            If cmbCmd.Text.TRM = "" Then
                mcttMain.SetToolTip(cmbCmd, "Enter Your Command And Press Enter.")
                scrmrMain.MarqueeText = MarqueeDefaultText
                scrmrMain.Stopped = True
            End If
        End If
    End Sub

    Private Sub notico_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notico.MouseClick
        If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(HideShowSound, AudioPlayMode.Background)
        ShowAllForms()
        notico.Visible = False
    End Sub

    Private Sub LblshpHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alHide.Click
        HideAllForms()
    End Sub

    Private Sub HideAllFormsButOutput()
        For Each Form As Form In TheBlackShellRunnerProject.Forms
            If Not Form Is frmOutput And Not Form.Name = "frmOutput" Then Form.Hide()
        Next
    End Sub

    Property HasOutputWindow() As Boolean = False
    'For Each Form As Form In TheBlackShellRunnerProject.Forms
    ' If Form Is frmOutput Or Form.Name = "frmOutput" Then Return True
    ' Next
    ' Return False
    'End Function
    Private old As String = ""
    Public IsClosed As Boolean = False
    Public CustomCommandIconNameStr As String = ""
    Public Sub SetIcon(Optional ByVal IgnoreComboChange As Boolean = False)
        On Error Resume Next
        If IgnoreComboChange Then GoTo IgnoreText
        If Not cmbCmd.Text = old Then
IgnoreText:
            old = cmbCmd.Text
            picMain.Image = Nothing
            If ItIsACustomCommand(cmbCmd.Text) Then
                picMain.Cursor = Cursors.Hand
                CustomCommandIconNameStr = cmbCmd.Text
                picMain.Image = imglstIcons.Images.Item(3)
                If PathExists(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & cmbCmd.Text & ".ICO", TypeOfPath.File) Then
                    picMain.Image = Drawing.Icon.ExtractAssociatedIcon(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & cmbCmd.Text & ".ICO").ToBitmap()
                    Exit Sub
                End If
            Else
                picMain.Cursor = Cursors.Arrow
            End If
            If cmbCmd.Text.CNT(CommandLineSeparator) Then
                picMain.Image = imglstIcons.Images.Item(14) 'BlackShellRunner Command
                Exit Sub
            End If
            Dim TheShellType As ShellType = GetShellType(cmbCmd.Text)
            If TheShellType = ShellType.MSDOS And Not cmbCmd.Text.CNT("; ") Then ' Microsoft MS-DOS
                picMain.Image = imglstIcons.Images.Item(2)
                Exit Sub
            ElseIf TheShellType = ShellType.PowerShell And Not cmbCmd.Text.CNT("&") Then ' Microsoft WindowsPowerShell
                picMain.Image = imglstIcons.Images.Item(7)
                Exit Sub
            ElseIf TheShellType = ShellType.Shell Then ' Environment Variable Shell Command
                picMain.Image = Drawing.Icon.ExtractAssociatedIcon(ShellCommandPath(cmbCmd.Text)).ToBitmap()
                Exit Sub
            End If
            If aDOSCmd(cmbCmd.Text) And cmbCmd.Text.CNT("&") Then
                picMain.Image = imglstIcons.Images.Item(2) ' command prompt
                Exit Sub
            End If
            If aPSCmd(cmbCmd.Text) And cmbCmd.Text.CNT("; ") Then
                picMain.Image = imglstIcons.Images.Item(7) ' powershell command
                Exit Sub
            End If
            If cmbCmd.Text Like "?:\*.*" Or cmbCmd.Text Like "*\*.*" And Not cmbCmd.Text Like "*\\*.*" Then
                If PathExists(cmbCmd.Text, TypeOfPath.File) Then
                    picMain.Image = Drawing.Icon.ExtractAssociatedIcon(cmbCmd.Text).ToBitmap() 'file with extention icon
                    Exit Sub
                End If
            ElseIf cmbCmd.Text Like "?:\" Or cmbCmd.Text = "\" And Not cmbCmd.Text = "\\" Then
                If PathExists(cmbCmd.Text, TypeOfPath.Directory) Then
                    picMain.Image = imglstIcons.Images.Item(6) 'drive icon
                    Exit Sub
                End If
            ElseIf cmbCmd.Text Like "?:\*" Or cmbCmd.Text Like "\*" And Not cmbCmd.Text Like "\\*" And Not cmbCmd.Text Like "*\\" Then
                If PathExists(cmbCmd.Text, TypeOfPath.Directory) Then
                    picMain.Image = imglstIcons.Images.Item(0) 'folder icon
                    Exit Sub
                ElseIf PathExists(cmbCmd.Text, TypeOfPath.File) Then
                    picMain.Image = imglstIcons.Images.Item(1) 'file icon
                    Exit Sub
                End If
            End If
            If cmbCmd.Text.UC Like "SHELL:*" Then
                picMain.Image = imglstIcons.Images.Item(3) 'shell gears icon
                Exit Sub
            End If
            If aSpecialFolderCmd(cmbCmd.Text) Then
                picMain.Image = imglstIcons.Images.Item(0) 'folder icon
                Exit Sub
            End If
            If aControlPanelCmd(cmbCmd.Text) Then
                picMain.Image = imglstIcons.Images.Item(5) 'control panel icon
                Exit Sub
            End If
            If cmbCmd.Text.TRM = "" Then
                picMain.Image = Nothing
                Exit Sub
            End If
            If cmbCmd.Text.UC Like "CMD.EXE /C*" Or cmbCmd.Text.UC Like "CMD.EXE /K*" Then
                picMain.Image = imglstIcons.Images.Item(2) 'DOS Command
                Exit Sub
            End If
            If cmbCmd.Text.UC = "TILEVERTICALLY" Then
                picMain.Image = imglstIcons.Images.Item(8) 'TILE VERTICALLY
                Exit Sub
            End If
            If cmbCmd.Text.UC = "TILEHORIZONTALLY" Then
                picMain.Image = imglstIcons.Images.Item(9) 'TILE HORIZONTALLY
                Exit Sub
            End If
            If cmbCmd.Text.UC = "CASCADE" Then
                picMain.Image = imglstIcons.Images.Item(10) 'CASCADE
                Exit Sub
            End If
            If cmbCmd.Text.UC = "UNMINIMIZEALL" Then
                picMain.Image = imglstIcons.Images.Item(11) 'UNMINIMIZEALL
                Exit Sub
            End If
            If cmbCmd.Text.UC = "MINIMIZEALL" Then
                picMain.Image = imglstIcons.Images.Item(12) 'MINIMIZEALL
                Exit Sub
            End If
            If cmbCmd.Text.UC Like "SUPERMKDIR *" Or cmbCmd.Text.UC Like "SMD *" Then
                picMain.Image = imglstIcons.Images.Item(4) 'stuffed folder icon for smd
                Exit Sub
            End If
            If cmbCmd.Text.UC Like "SUPEROPENDIR *" Or cmbCmd.Text.UC Like "SOD *" Then
                picMain.Image = imglstIcons.Images.Item(4) 'stuffed folder icon for sod
                Exit Sub
            End If
            If cmbCmd.Text.UC Like "SB *" Or cmbCmd.Text.UC Like "SAFERBROWSER *" Or cmbCmd.Text.UC = "SB" Then
                picMain.Image = imglstIcons.Images.Item(13) 'INet
                Exit Sub
            End If
            If cmbCmd.Text.UC Like "PANELLOADER *.EXE" Or cmbCmd.Text.UC Like "PL *.EXE" Then
                picMain.Image = frmPanelLoader.Icon.ToBitmap
                Exit Sub
            End If
            If clsExecuteCommand.IsAURL(cmbCmd.Text) Then
                picMain.Image = imglstIcons.Images.Item(13) 'INet
                Exit Sub
            End If
        End If
    End Sub
    Private Sub frm1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        FormShown()
    End Sub

    Private Sub picMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMain.Click
        On Error Resume Next
        If picMain.Cursor = Cursors.Hand Then
            frmIconList.Show()
        End If
    End Sub

    Private Sub chkPws_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPws.CheckedChanged
        INIWrite(INISettingsPath, "Settings", "MS-DOS_PauseChecked", chkPws.Checked)
    End Sub

    Private Sub cmbCmd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCmd.KeyUp
        If e.KeyCode = Keys.Return Then
            Run()
        End If
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        Dim wawdb2 As Integer = (My.Computer.Screen.WorkingArea.Width / 2)
        Dim wahdb2 As Integer = (My.Computer.Screen.WorkingArea.Height / 2)
        Dim firstStr As String = ""
        Dim secondStr As String = ""
        If Math.Floor(Top + (Height / 2)) > wahdb2 Then
            frmCorners.Top = wahdb2
            firstStr = "Bottom"
        End If
        If Math.Floor(Left + (Width / 2)) > wawdb2 Then
            frmCorners.Left = wawdb2
            secondStr = "Right"
        End If
        If Math.Floor(Top + (Height / 2)) < wahdb2 Then
            frmCorners.Top = 0
            firstStr = "Top"
        End If
        If Math.Floor(Left + (Width / 2)) < wawdb2 Then
            frmCorners.Left = 0
            secondStr = "Left"
        End If
        frmCorners.abbrdr.Text = firstStr & ", " & secondStr
        'If TopLeft Then
        'pnlResizeRightBottom.Visible = True
        'Else
        'pnlResizeRightBottom.Visible = False
        'End If
        'SetShadows()
    End Sub

    Private Sub frm1_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        'If scrmrMain.Font.Size >= MaxScrollingMarqueeFontSize Then
        '    MaximumSize = Size
        'End If
        SetGraphicsPath()
    End Sub

    Private Sub scrmr_Resize(sender As Object, e As System.EventArgs) Handles scrmrMain.Resize
        scrmrMain.Refresh()
    End Sub
    Dim Para As String = ""


#End Region

End Class