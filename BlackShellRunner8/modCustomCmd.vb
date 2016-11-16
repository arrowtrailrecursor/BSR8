Imports BSR.clsExecuteCommand
Imports System.Collections.Specialized
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Module modCustomCmd

    Public DelaySeconds As Double = 2
    Public MarqueeTextOrientation As AcidControls.AcidScrollingMarquee.TextOrientation

    Public Function ItIsACustomCommand(ByVal TheCommandToTest As String) As Boolean
        On Error Resume Next
        Dim CustomCommands As New StringCollection
        Dim CustomCommandFiles() As String = Directory.GetFiles(BinaryFileDirectoryPath)
        For Index As Integer = 0 To CustomCommandFiles.GetUpperBound(0)
            Dim File As New IO.FileInfo(CustomCommandFiles(Index))
            If Not File.Name = "BSR_LST.BIN" Then CustomCommands.Add(File.Name.RSAtE(".BIN"))
        Next
        For Each Command As String In CustomCommands
            If Command.UC = TheCommandToTest.UC And Command <> "" Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub ToSeeAsCustomOrJustExecute()
        On Error Resume Next
        ' PlusX = 0
        'PlusY = 0
        With frmMain
            If .cmbCmd.Text.TRM = "" _
                Or .cmbCmd.Text.RT(2) = "\\" And .cmbCmd.Text.LT(2) = "\\" _
                Or .cmbCmd.Text.TRM.CNT(frmMain.CommandLineSeparator & frmMain.CommandLineSeparator) _
                Or .cmbCmd.Text.TRM.LT(frmMain.CommandLineSeparator.LN) = frmMain.CommandLineSeparator _
                Or .cmbCmd.Text.TRM.RT(frmMain.CommandLineSeparator.LN) = frmMain.CommandLineSeparator Then
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.WaitToComplete)
                If frmOptions.chkGraphics.Checked Then
                    DisplayGraphics(frmMain, True)
                End If
                .scrmrMain.Stopped = False
                If .cmbCmd.Text.LT(frmMain.CommandLineSeparator.LN) = frmMain.CommandLineSeparator Or .cmbCmd.Text.RT(frmMain.CommandLineSeparator.LN) = frmMain.CommandLineSeparator Then
                    .scrmrMain.MarqueeText = "A Command That Contains BSR Command Separator '" & frmMain.CommandLineSeparator & "' At The Beginning Or End Of The Command Line Is Invalid!"
                End If
                If .cmbCmd.Text.TRM = "" Then .scrmrMain.MarqueeText = "Nothing Has Been Entered BlackShellRunner Cannot Run A Null Command!"
                If .cmbCmd.Text.TRM.CNT(frmMain.CommandLineSeparator & frmMain.CommandLineSeparator) Then .scrmrMain.MarqueeText = "A Command That Contains BSR Command Separators '" & frmMain.CommandLineSeparator & frmMain.CommandLineSeparator & "' With No Command Between Them Is Invalid!"
                If .cmbCmd.Text.LT(2) = "\\" Or .cmbCmd.Text.RT(2) = "\\" Then .scrmrMain.MarqueeText = "A Path With Double '\\' Characters At End Or Beginning Of Command Is Invalid!"
                If .cmbCmd.Text = frmMain.CommandLineSeparator & "" Then .scrmrMain.MarqueeText = "A Command That Contains Only BSR Command Separator '" & frmMain.CommandLineSeparator & "' Is Invalid!"
                Exit Sub
            End If
            If frmOptions.chkGraphics.Checked And Not frmOptions.chkPic.Checked Then
                DisplayGraphics(frmMain, False)
            End If
            Dim Ex As Integer = 0
            Dim AnyErrors As Boolean = False
            Dim b As Boolean
            Dim l As Boolean
            Dim item As String
            Dim itemSp As String
            Dim SplitBSRcmds() As String = .cmbCmd.Text.SPT(frmMain.CommandLineSeparator)
            If Not .cmbCmd.Text.CNT(frmMain.CommandLineSeparator & "") Then
                If ItIsACustomCommand(.cmbCmd.Text.TRM) Then
                    DisplayCommandOnMarquee(.cmbCmd.Text.TRM)
                    ExecuteSubCommands(.cmbCmd.Text.TRM)
                    Delay(DelaySeconds)
                    GoTo AfterMath
                End If
                DisplayCommandOnMarquee(.cmbCmd.Text)
                ExecuteCommand(.cmbCmd.Text)
            Else
                For Each itemSp In SplitBSRcmds
                    If ItIsACustomCommand(itemSp.TRM) Then
                        DisplayCommandOnMarquee(itemSp)
                        ExecuteSubCommands(itemSp)
                        GoTo NextCmd
                    End If
                    DisplayCommandOnMarquee(itemSp)
                    ExecuteCommand(itemSp)
NextCmd:
                    Delay(DelaySeconds)
                Next
            End If
AfterMath:
            If ThereIsADOSError And Not TheErrorText = "" Then
                .scrmrMain.Stopped = False
                .scrmrMain.MarqueeText = TheErrorText
            End If
            If TheErrorText = "" And Not clsExecuteCommand.NoAssociatedProgram And Not ThereIsADOSError Then
                If Not INIReadBoolean(INISettingsPath, "Internet", "StoreSaferBrowserAddresses") And frmMain.cmbCmd.Text.TRM Like "*.*.*" Then
                    GoTo NoStoreAddress
                End If
                If clsExecuteCommand.AddToTheCommandsLIst Then
                    AddLst(.cmbCmd.Text.TRM, .cmbCmd, True)
                    INIWrite(INISettingsPath, "Settings", "LastCommand", .cmbCmd.Text.TRM)
                End If
NoStoreAddress:
                .cmbCmd.Text = ""
                .scrmrMain.Stopped = True
                .scrmrMain.MarqueeText = frmMain.MarqueeDefaultText
                .scrmrMain.StoppedTextOrientation = AcidControls.AcidScrollingMarquee.TextOrientation.Left
            End If
        End With
        TheErrorText = ""
        clsExecuteCommand.NoAssociatedProgram = False
        ThereIsADOSError = False
        frmMain.HasOutputWindow = False
        frmMain.IsClosed = True
    End Sub

    Private Sub DisplayCommandOnMarquee(ByVal Command As String)
        With frmMain
            'Make Damn Sure Text Is Set Before Setting Orientation Or Else It Will Show Up All Crooked
            .abRn.Enabled = False
            .abBrws.Enabled = False
            .abSrch.Enabled = False
            .abOptns.Enabled = False
            .scrmrMain.MarqueeText = Command
            With .scrmrMain
                .StoppedTextOrientation = MarqueeTextOrientation
                .Stopped = True
                .Refresh()
            End With
            Delay(DelaySeconds)
            .scrmrMain.Stopped = False
        End With
    End Sub

    Sub ExecuteSubCommands(ByVal CustomCommand As String)
        On Error Resume Next
        With frmMain
            If Not .abRn.Text = "Stop" Then
                Dim StrCol As New StringCollection
                Dim Binary As New BinaryFormatter
                Dim CustomStream As New FileStream(TheFlashOrRegularDirectoryPath & "\BSR_BIN\" & CustomCommand & ".BIN", FileMode.OpenOrCreate)
                StrCol = CType(Binary.Deserialize(CustomStream), StringCollection)
                CustomStream.Close()
                Dim SplitBSRcmds() As String
                Dim ItmDC As String = ""
                Dim AllCustomItem As String = ""
                For Each item As String In StrCol
                    ItmDC = item.Decrypt(KeyForHash)
                    If Not ItmDC = "" Then
                        item = ItmDC
                        If Not item.CNT(frmMain.CommandLineSeparator & "") Then
                            If ItIsACustomCommand(item) Then
                                DisplayCommandOnMarquee(item)
                                ExecuteSubCommands(item)
                                GoTo after1
                            End If
                            DisplayCommandOnMarquee(item)
                            ExecuteCommand(item)
after1:
                            Delay(DelaySeconds)
                        Else
                            SplitBSRcmds = item.SPT(frmMain.CommandLineSeparator & "")
                            For Each item2 As String In SplitBSRcmds
                                If ItIsACustomCommand(item2) Then
                                    DisplayCommandOnMarquee(item2)
                                    ExecuteSubCommands(item2)
                                    GoTo after2
                                End If
                                DisplayCommandOnMarquee(item2)
                                ExecuteCommand(item2)
after2:
                                Delay(DelaySeconds)
                            Next
                        End If
                    End If
                Next
                If Not clsExecuteCommand.NoAssociatedProgram Then
                    .scrmrMain.MarqueeText = frmMain.MarqueeDefaultText
                    .scrmrMain.StoppedTextOrientation = AcidControls.AcidScrollingMarquee.TextOrientation.Left
                    .scrmrMain.Stopped = True
                End If
                If ThereIsADOSError Then
                    .scrmrMain.Stopped = False
                    .scrmrMain.MarqueeText = modPowerShell.TheErrorText
                End If
            Else
                ' If MyRunSpace.RunspaceStateInfo.State = System.Management.Automation.Runspaces.RunspaceState.Opening Then
                'DelayTilOpen()
                'End If
                '  MyRunSpace.Close()
                ' DelayTilThreadNotBusy()
                '.abRn.Text = "Run"
            End If
        End With
    End Sub

End Module