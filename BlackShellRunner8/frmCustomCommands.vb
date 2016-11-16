#Region "Imports"


#End Region

Imports System.Collections.Specialized
Imports System.IO

Public Class frmCustomCommads

#Region "NonEventMethods"

#Region "NonEventSubRoutines"

    Property DiscourageZombies As Boolean = False

    Private Sub LoadLists()
        On Error Resume Next
        LoadLst(cmbCstCmdsCmds, "BSR_LST.BIN", False)
        Dim CustomCommandFiles() As String = Directory.GetFiles(BinaryFileDirectoryPath)
        lstCstCmds.Items.Clear()
        cmbCstCmds.Items.Clear()
        For Index As Integer = 0 To CustomCommandFiles.GetUpperBound(0)
            Dim File As New IO.FileInfo(CustomCommandFiles(Index))
            If Not File.Name = "BSR_LST.BIN" Then
                lstCstCmds.Items.Add(File.Name.UC.RSAtE(".BIN"))
                cmbCstCmds.Items.Add(File.Name.UC.RSAtE(".BIN"))
            End If
        Next
        LoadLst(cmbCstCmdsCmds, lstCstCmds.SelectedItem.ToString.UC & ".BIN", False)
        If DiscourageZombies Then
            SplitContainer1.Panel1Collapsed = True
        Else
            SplitContainer1.Panel1Collapsed = False
            abOverCommand.Size = SplitContainer1.Panel1.Size
        End If
    End Sub

    Private Sub LoadCustomCommandsCombo()
        cmbCstCmds.Items.Clear()
        For Each item As String In lstCstCmds.Items
            cmbCstCmds.Items.Add(item)
        Next
    End Sub

    Private Sub AddToLstCstCmds()
        'BLANK
        If cmbCstCmds.Text.TRM = "" Then
            If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.Background)
            Exit Sub
        End If
        'INVALID CHARACTERS
        ''\/:*?"<>|''
        If cmbCstCmds.Text.CNT("\") _
            Or cmbCstCmds.Text.CNT("/") _
            Or cmbCstCmds.Text.CNT(":") _
            Or cmbCstCmds.Text.CNT("*") _
            Or cmbCstCmds.Text.CNT("?") _
            Or cmbCstCmds.Text.CNT("""") _
            Or cmbCstCmds.Text.CNT("<") _
            Or cmbCstCmds.Text.CNT(">") _
            Or cmbCstCmds.Text.CNT("|") Then
            MessageBox.Show("Custom Command Must Not Contain The Following Characters \/:*?" & Qt & "<>|", "Illegal Characters In Command Name!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'INVALID CHARACTER LENGTH
        If Len(TheFlashOrRegularDirectoryPath & "\BSR_ICO\") + Len(cmbCstCmds.Text) > 255 Then
            MessageBox.Show("Custom Command Path Length Cannot Be Larger Then 255 Characters", "Command Name To Long!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim exists As Boolean = False
        For Each item As String In lstCstCmds.Items
            If cmbCstCmds.Text.TRM.UC = item.UC Then exists = True
        Next
        If Not exists Then
            With lstCstCmds
                .Items.Add(cmbCstCmds.Text.TRM)
                .SelectedItem = cmbCstCmds.Text
            End With
            cmbCstCmdsCmds.Focus()
            Dim BSRSTPFileDir As String = TheFlashOrRegularDirectoryPath & "\BSR_STP"
            If Not PathExists(BSRSTPFileDir, TypeOfPath.Directory) Then IO.Directory.CreateDirectory(BSRSTPFileDir)
            Try
                Dim STPFilePath As String = BSRSTPFileDir & "\" & cmbCstCmds.Text.UC.TRM & ".STP"
                If Not PathExists(STPFilePath, TypeOfPath.File) Then IO.File.Create(STPFilePath).Dispose()
            Catch ex As Exception
            End Try
        End If
        LoadLists()
    End Sub

    Private Sub RemoveFromLstCstCmds()
        On Error Resume Next
        If cmbCstCmds.Text.TRM = "" Then
            If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.Background)
            Exit Sub
        End If
        If Not cmbCstCmds.Text = lstCstCmds.Items(lstCstCmds.SelectedIndex) Then
            MessageBox.Show("This Command Does Not Exist in Custom Command History Therefore it Cannot be Removed." &
                   "Try Typing With Correct Spelling of List Item or Selecting The Item in " &
                   "the List By Clicking it then Removing it.", "BlackShellRunner Remove From History", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If cmbCstCmds.Text = frmMain.cmbCmd.Text Then frmMain.cmbCmd.Text = ""
        My.Computer.FileSystem.DeleteFile(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & cmbCstCmds.Text & ".ICO")
        My.Computer.FileSystem.DeleteFile(BinaryFileDirectoryPath & "\" & cmbCstCmds.Text & ".BIN")
        My.Computer.FileSystem.DeleteFile(TheFlashOrRegularDirectoryPath & "\BSR_STP\" & cmbCstCmds.Text & ".STP")
        Dim inx As Integer = lstCstCmds.SelectedIndex
        lstCstCmds.Items.RemoveAt(inx)
        cmbCstCmds.Text = ""
        LoadLists()
        If lstCstCmds.Items.Count > 0 Then lstCstCmds.SelectedIndex = 0
    End Sub

    Private Sub AddToLstCstCmdsCmds()
        Try
            cmbCstCmdsCmds.Text = cmbCstCmdsCmds.Text.TRM
            If cmbCstCmdsCmds.Text.TRM = "" Then
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.Background)
                Exit Sub
            End If
            If cmbCstCmdsCmds.Text.UC.CNT("PAUSE") Then
                MessageBox.Show("Command cannot contain pause! Use DOS Pause Checkbox to make DOS pause.", "DOS Pause Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim Exists As Boolean = False
            For Each item As String In lstCstCmds.Items
                If item.LC = cmbCstCmds.Text.LC Then
                    Exists = True
                    Exit For
                End If
            Next
            If Exists Then AddLst(cmbCstCmdsCmds.Text.LC, lstCstCmdsCmds, True, cmbCstCmds.Text.UC & ".BIN", True, False)
            '                                                 ^ByVal lstCstCmds.Items(lstCstCmds.SelectedIndex) needed for command file name
            lstCstCmdsCmds.SelectedItem = cmbCstCmdsCmds.Text
            Dim SetText As String = cmbCstCmds.Text
            Dim STPFile As String = My.Application.Info.DirectoryPath & "\BSR_DIR\BSR_STP\" & SetText & ".STP"
            If Not PathExists(STPFile, TypeOfPath.File) Then IO.File.Create(STPFile).Close()
            cmbCstCmdsCmds.Text = ""
        Catch ex As IndexOutOfRangeException
        End Try
        LoadLists()
    End Sub

    Private Sub RemoveFromLstCstCmdsCmds()
        On Error Resume Next
        If Not cmbCstCmdsCmds.Text = lstCstCmdsCmds.Items(lstCstCmdsCmds.SelectedIndex) Then
            MessageBox.Show("This Command Does Not Exist in Custom Commands Sub Command History Therefore it Cannot be Removed." &
                   "Try Typing With Correct Spelling of List Item or Selecting The Item in " &
                   "the List By Clicking it then Removing it.", "BlackShellRunner Remove From History", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim ListItem As Integer = 0
        RmLst(cmbCstCmdsCmds.Text, lstCstCmdsCmds, True, lstCstCmds.Items.Item(lstCstCmds.SelectedIndex) & ".BIN")
        cmbCstCmdsCmds.Text = ""
        LoadLists()
    End Sub

    Private Sub UpDateBinFile()
        Dim exists As Boolean = False
        For Each item As String In lstCstCmds.Items
            If item = cmbCstCmds.Text Then
                exists = True
                lstCstCmds.SelectedItem = cmbCstCmds.Text
            End If
        Next
        With cmbCstCmds
            If exists Then WriteListToFile(lstCstCmdsCmds, cmbCstCmds.Text.UC.TRM & ".BIN")
        End With
    End Sub

    Private Sub SetPanelMinSize(ByVal ab As AcidControls.AcidButton, ByVal str As String)
        Dim widthlen As Integer = TextRenderer.MeasureText(str, ab.Font).Width
        Dim wlp = (widthlen + 15)
        With SplitContainer2
            .Panel2MinSize = 65
            .SplitterDistance = .Width - (wlp - .SplitterWidth)
        End With
    End Sub

    Private Sub SelectListItemByName(ByVal TheListControl As ListBox, ByVal TheTextToFind As String)
        Dim inx As Integer = 0
        For Each item As String In TheListControl.Items
            If TheTextToFind.TRM = item Then
                TheListControl.SelectedIndex = inx
            End If
            inx += 1
        Next
    End Sub

    Sub SetCustomTheCustomCommandIcon()
        picMain.BackgroundImageLayout = ImageLayout.Stretch
        frmMain.cmbCmd.Text = ""
        frmMain.cmbCmd.Text = cmbCstCmds.Text
        frmMain.SetIcon()
        picMain.BackgroundImage = frmMain.picMain.Image
    End Sub

    Protected CurrentSeparator As String = frmMain.CommandLineSeparator

    Sub ChangeButtonLblshpSeparatorText(ByVal TheSeparatorText As String)
        With abFrontToBack
            .Text = ">-'" & TheSeparatorText & "'"
        End With
        With abBackToFront
            .Text = "'" & TheSeparatorText & "'-<"
        End With
        With abDownLastToBelow
            .Text = "\/->'" & TheSeparatorText & "'"
        End With
        With abUpBelowToLast
            .Text = "'" & TheSeparatorText & "'<-/\"
        End With
        With abCollapseToOneCommand
            .Text = "- All '" & frmMain.CommandLineSeparator & "'"
        End With
        With abExpandFromOneCommand
            .Text = "'" & frmMain.CommandLineSeparator & "' llA +"
        End With
    End Sub

#End Region

#End Region

#Region "Event Methods"

    Private Sub frmCstmCmds_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        picMain.BringToFront()
    End Sub

    Private Sub Me_Visible_Focus(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged, Me.GotFocus
        On Error Resume Next
        If Visible Then
            LoadLists()
            Dim StartUpText As String = INIRead(INISettingsPath, "Settings", "RunThisCommandAtStartUp")
            cmbStartUpCommand.Text = StartUpText
            For Each item As String In cmbSep.Items
                If item = frmMain.CommandLineSeparator Then Exit Sub
            Next
            cmbSep.Items.Add(frmMain.CommandLineSeparator)
            cmbSep.SelectedIndex = (cmbSep.Items.Count - 1)
        End If
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Protected Function GetIndexOfText(ByVal Text As String) As Integer
        Dim Inx As Integer = 0
        For Each item As String In cmbCstCmds.Items
            If item = Text Then Return Inx
            Inx += 1
        Next
        Return Inx
    End Function

    Private Sub tmrSetIcon_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSetIcon.Tick
        Static ot As String = ""
        If Not cmbCstCmds.Text = ot Then
            ot = cmbCstCmds.Text
            Try
                lstCstCmds.SelectedIndex = GetIndexOfText(cmbCstCmds.Text)
            Catch ex As Exception
            End Try
            SetCustomTheCustomCommandIcon()
        End If
    End Sub

    Private Sub cmbCstCmds_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCstCmds.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            AddToLstCstCmds()
        End If
    End Sub

    Private Sub cmbCstCmdsCmds_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCstCmdsCmds.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Return) Then
            AddToLstCstCmdsCmds()
        End If
    End Sub

    Private Sub cmbStartUpCommand_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbStartUpCommand.KeyUp
        INIWrite(INISettingsPath, "Settings", "RunThisCommandAtStartUp", cmbStartUpCommand.Text)
    End Sub

    Private Sub cmbCstCmdsCmds_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCstCmdsCmds.KeyUp
        On Error Resume Next
        If Not cmbCstCmdsCmds.Text = "" Then
            lstCstCmds.SelectedItem = cmbCstCmdsCmds.Text
        End If
    End Sub

    Private Sub cmbStartUpCommand_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbStartUpCommand.SelectedIndexChanged
        INIWrite(INISettingsPath, "Settings", "RunThisCommandAtStartUp", cmbStartUpCommand.Items.Item(cmbStartUpCommand.SelectedIndex))
    End Sub

    Private Sub lstCstCmds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCstCmds.SelectedIndexChanged
        On Error Resume Next
        cmbCstCmds.Text = lstCstCmds.Items(lstCstCmds.SelectedIndex)
        LoadLst(lstCstCmdsCmds, lstCstCmds.Items(lstCstCmds.SelectedIndex) & ".BIN")
        Dim Count As Integer = lstCstCmdsCmds.Items.Count
        Dim TopInx As Integer = (Count - 1)
        If Count > 0 Then lstCstCmdsCmds.SelectedIndex = TopInx
    End Sub

    Private Sub lstCstCmdsCmds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCstCmdsCmds.SelectedIndexChanged
        On Error Resume Next
        Dim SelText As String = lstCstCmdsCmds.Items.Item(lstCstCmdsCmds.SelectedIndex).ToString
        cmbCstCmdsCmds.Text = SelText
        If Not SelText.CNT(frmMain.CommandLineSeparator) Then
            If SelText.CNT("; ") Then
                cmbSep.SelectedIndex = 0
            End If
            If SelText.CNT("&&") Then
                cmbSep.SelectedIndex = 1
            End If
        Else
            cmbSep.SelectedIndex = 2
            SetPanelMinSize(abUpBelowToLast, abUpBelowToLast.Text)
        End If
    End Sub

    Private Sub abOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abOk.Click
        Hide()
    End Sub

    Private Sub abAddCst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abAddCst.Click
        AddToLstCstCmds()
        lstCstCmds.Focus()
    End Sub

    Private Sub abAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abAdd.Click
        AddToLstCstCmdsCmds()
        lstCstCmdsCmds.Focus()
    End Sub

    Private Sub abRmCst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abRmCst.Click
        RemoveFromLstCstCmds()
        lstCstCmdsCmds.Items.Clear()
        lstCstCmds.Focus()
    End Sub

    Private Sub abRmCstCmdsCmds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abRm.Click
        RemoveFromLstCstCmdsCmds()
        lstCstCmdsCmds.Focus()
    End Sub

    Private Sub lstCstCmds_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCstCmds.Click
        On Error Resume Next
        cmbCstCmds.Text = lstCstCmds.Items(lstCstCmds.SelectedIndex)
    End Sub

    Private Sub lstCstCmdsCmds_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCstCmdsCmds.Click
        On Error Resume Next
        cmbCstCmdsCmds.Text = lstCstCmdsCmds.Items(lstCstCmdsCmds.SelectedIndex)
    End Sub

    Private Sub abOverCommand_Click(sender As System.Object, e As System.EventArgs) Handles abOverCommand.Click
        On Error Resume Next
        If lstCstCmds.Items.Count < 1 Then Exit Sub
        Dim YNAddZomb As DialogResult = MessageBox.Show("This Could Potentially Create A Zombie Command That Calls Itself. Do You Wish To Continue?",
                                                        "BlackShellRunner Night Of The Living Dead Question",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)
        If YNAddZomb = Windows.Forms.DialogResult.Yes Then
            If Not lstCstCmds.Focused Then
                lstCstCmds.Focus()
                lstCstCmds.SelectedIndex = 0
            End If
            Dim SelectedText As String = lstCstCmds.Items.Item(lstCstCmds.SelectedIndex)
            Dim CmbText As String = cmbCstCmds.Text
            SelectListItemByName(lstCstCmds, CmbText)
            lstCstCmdsCmds.Items.Add(CmbText.UC.TRM)
            Dim TopInx As Integer = lstCstCmdsCmds.Items.Count - 1
            lstCstCmdsCmds.SelectedIndex = TopInx
            UpDateBinFile()
        End If
    End Sub

    Private Sub picMain_Click(sender As System.Object, e As System.EventArgs) Handles picMain.Click
        On Error Resume Next
        If lstCstCmds.Items.Count = 0 Then Exit Sub
        If Not lstCstCmds.Focused Then : lstCstCmds.Focus() : lstCstCmds.SelectedIndex = 0 : End If
        frmMain.cmbCmd.Text = lstCstCmds.Items.Item(lstCstCmds.SelectedIndex).ToString.LC
        frmIconList.Show()
        Do Until frmIconList.Visible = False
            Application.DoEvents()
        Loop
        picMain.BackgroundImageLayout = ImageLayout.Stretch
        picMain.BackgroundImage = frmMain.picMain.Image
    End Sub

    Private Sub abMinus_Click(sender As System.Object, e As System.EventArgs) Handles abMinus.Click
        On Error Resume Next
        Dim SelInx, NewInx, TopInx, BotInx As Integer
        Dim SelText As String
        With lstCstCmdsCmds
            If .Items.Count <= 1 Then Exit Sub
            TopInx = (.Items.Count - 1)
            If Not .Focused Then
                .Focus()
                .SelectedIndex = TopInx
            End If
            SelInx = .SelectedIndex
            NewInx = SelInx - 1
            BotInx = 0
            SelText = .Items.Item(SelInx)
            If NewInx < BotInx Then NewInx = TopInx
            .Items.RemoveAt(SelInx)
            .Items.Insert(NewInx, SelText)
            UpDateBinFile()
            .SelectedIndex = NewInx
        End With
    End Sub

    Private Sub abPlus_Click(sender As Object, e As System.EventArgs) Handles abPlus.Click
        On Error Resume Next
        Dim SelInx, NewInx, TopInx, BotInx As Integer
        Dim SelText As String
        With lstCstCmdsCmds
            If .Items.Count <= 1 Then Exit Sub
            BotInx = 0
            If Not .Focused Then
                .Focus()
                .SelectedIndex = BotInx
            End If
            SelInx = .SelectedIndex
            NewInx = SelInx + 1
            TopInx = (.Items.Count - 1)
            SelText = .Items.Item(SelInx)
            If NewInx > TopInx Then NewInx = BotInx
            .Items.RemoveAt(SelInx)
            .Items.Insert(NewInx, SelText)
            UpDateBinFile()
            .SelectedIndex = NewInx
        End With
    End Sub

    Sub FrontToBack(ByVal Separator As String)
        On Error Resume Next
        Dim SelInx, Inx As Integer
        Dim SelText, TextNoBack, TextAtBack, NewText, SepText As String
        With lstCstCmdsCmds
            SepText = Separator
            Inx = 0
            If Not .Focused And Not .Items.Count = 0 Then
                .Focus()
                .SelectedIndex = 0
                Dim copy = .Items.OfType(Of String)().ToList()
                For Each item As String In copy
                    If item.CNT(SepText) Then
                        .SelectedIndex = Inx
                        Exit For
                    End If
                    Inx += 1
                Next
            ElseIf .Items.Count = 0 Then
                Exit Sub
            End If
            SelInx = .SelectedIndex
            SelText = .Items.Item(SelInx)
            If Not SelText.CNT(SepText) Then Exit Sub
            TextNoBack = SelText.LT(SelText.LN - (SelText.SPT(SepText).Last.LN + SepText.LN))
            TextAtBack = SelText.SPT(SepText).Last
            NewText = TextAtBack & SepText & TextNoBack
            .Items.RemoveAt(SelInx)
            .Items.Insert(SelInx, NewText.ToString)
            UpDateBinFile()
            .SelectedIndex = SelInx
        End With
    End Sub

    Sub BackToFront(ByVal Separator As String)
        On Error Resume Next
        Dim SelInx, Inx As Integer
        Dim SelText, TextNoFront, TextAtFront, NewText, SepText As String
        With lstCstCmdsCmds
            SepText = Separator
            Inx = 0
            If Not .Focused And Not .Items.Count = 0 Then
                .Focus()
                .SelectedIndex = 0
                Dim copy = .Items.OfType(Of String)().ToList()
                For Each item As String In copy
                    If item.CNT(SepText) Then
                        .SelectedIndex = Inx
                        Exit For
                    End If
                    Inx += 1
                Next
            ElseIf .Items.Count = 0 Then
                Exit Sub
            End If
            SelInx = .SelectedIndex
            SelText = .Items.Item(SelInx)
            If Not SelText.CNT(SepText) Then Exit Sub
            TextNoFront = SelText.RT(SelText.LN - (SelText.SPT(SepText).First.LN + SepText.LN))
            TextAtFront = SelText.SPT(SepText).First
            NewText = TextNoFront & SepText & TextAtFront
            .Items.RemoveAt(SelInx)
            .Items.Insert(SelInx, NewText.ToString)
            UpDateBinFile()
            .SelectedIndex = SelInx
        End With
    End Sub

    Sub DownLastToBelow(ByVal Separator As String)
        On Error Resume Next
        Dim SelInx, Inx As Integer
        Dim SelText, TextNoBack, TextAtBack, NewText, SepText As String
        With lstCstCmdsCmds
            SepText = Separator
            Inx = 0
            If Not .Focused And Not .Items.Count = 0 Then
                .Focus()
                .SelectedIndex = 0
                Dim copy = .Items.OfType(Of String)().ToList()
                For Each item As String In copy
                    If item.CNT(SepText) Then
                        .SelectedIndex = Inx
                        Exit For
                    End If
                    Inx += 1
                Next
            ElseIf .Items.Count = 0 Then
                Exit Sub
            End If
            SelInx = .SelectedIndex
            If SelInx < 0 Then Exit Sub
            SelText = .Items.Item(SelInx)
            If Not SelText.CNT(SepText) Then Exit Sub
            TextNoBack = SelText.LT(SelText.LN - (SelText.SPT(SepText).Last.LN + SepText.LN))
            TextAtBack = SelText.SPT(SepText).Last
            .Items.RemoveAt(SelInx)
            .Items.Insert(SelInx, TextNoBack)
            .Items.Insert(SelInx + 1, TextAtBack)
            UpDateBinFile()
            .SelectedIndex = SelInx
        End With
    End Sub

    Sub UpBelowToLast(ByVal Separator As String)
        On Error Resume Next
        Dim SelInx, TopInx As Integer
        Dim SelText, TextWithNewBack, TextBelow, SepText As String
        With lstCstCmdsCmds
            TopInx = (.Items.Count - 1)
            If TopInx >= 1 Then
                If Not .Focused Then
                    .Focus()
                End If
                SepText = Separator
                SelInx = .SelectedIndex
                If SelInx = TopInx Then Exit Sub
                SelText = .Items.Item(SelInx)
                TextBelow = .Items.Item(SelInx + 1)
                TextWithNewBack = SelText & SepText & TextBelow
                .Items.RemoveAt(SelInx)
                .Items.Insert(SelInx, TextWithNewBack)
                .Items.RemoveAt(SelInx + 1)
                UpDateBinFile()
                .SelectedIndex = SelInx
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub abCollapseToOneCommand_Click(sender As System.Object, e As System.EventArgs) Handles abCollapseToOneCommand.Click
        On Error Resume Next
        With lstCstCmdsCmds
            If .Items.Count < 1 Then Exit Sub
            Dim BotInx As Integer = 0
            Dim CollapsedText As String = ""
            Dim SepText As String = frmMain.CommandLineSeparator
            For Each Command As String In .Items
                CollapsedText = CollapsedText & SepText & Command
            Next
            .Items.Clear()
            .Items.Add(CollapsedText.RSAtF(SepText))
            UpDateBinFile()
            .SelectedIndex = BotInx
        End With
    End Sub

    Private Sub abExpandFromOneCommand_Click(sender As System.Object, e As System.EventArgs) Handles abExpandFromOneCommand.Click
        On Error Resume Next
        With lstCstCmdsCmds
            If .Items.Count < 1 Then Exit Sub
            Dim ExpandedArray As New List(Of String)
            Dim SptCmds() As String
            Dim SepText As String = frmMain.CommandLineSeparator
            ExpandedArray.Clear()
            For Each Command As String In .Items
                If Command.CNT(SepText) Then
                    SptCmds = Command.SPT(SepText)
                    For Each SubCommand As String In SptCmds
                        ExpandedArray.Add(SubCommand)
                    Next
                Else
                    ExpandedArray.Add(Command)
                End If
            Next
            .Items.Clear()
            .Items.AddRange(ExpandedArray.ToArray)
            UpDateBinFile()
            Dim TopInx As Integer = (.Items.Count - 1)
            .SelectedIndex = TopInx
        End With
    End Sub

    Private Sub abFrontToBack_Click(sender As System.Object, e As System.EventArgs) Handles abFrontToBack.Click
        FrontToBack(CurrentSeparator)
    End Sub

    Private Sub abBackToFront_Click(sender As System.Object, e As System.EventArgs) Handles abBackToFront.Click
        BackToFront(CurrentSeparator)
    End Sub

    Private Sub abDownLastToBelow_Click(sender As System.Object, e As System.EventArgs) Handles abDownLastToBelow.Click
        DownLastToBelow(CurrentSeparator)
    End Sub

    Private Sub abUpBelowToLast_Click(sender As System.Object, e As System.EventArgs) Handles abUpBelowToLast.Click
        UpBelowToLast(CurrentSeparator)
    End Sub

    Private Sub abTestCstmCmd_Click(sender As System.Object, e As System.EventArgs) Handles abTestCstmCmd.Click
        TheBlackShellRunnerProject.RunCommand(cmbCstCmds.Text)
    End Sub

    Private Sub abTestCstmCmdCmd_Click(sender As System.Object, e As System.EventArgs) Handles abTestCstmCmdCmd.Click
        TheBlackShellRunnerProject.RunCommand(cmbCstCmdsCmds.Text)
    End Sub

    Private Sub cmbSep_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbSep.SelectedIndexChanged
        On Error Resume Next
        Dim SelItem As String = cmbSep.Items.Item(cmbSep.SelectedIndex)
        CurrentSeparator = SelItem
        ChangeButtonLblshpSeparatorText(SelItem)
    End Sub

    Private Sub CstCmdsCmd(sender As Object, e As EventArgs) Handles cmbCstCmds.TextChanged, lstCstCmds.SelectedIndexChanged
        UpdateIcons()
    End Sub
    Private Sub UpdateIcons()
        On Error Resume Next
        If lstCstCmdsCmds.Items.Count > 0 Then
            With frmMain
                .cmbCmd.Text = cmbCstCmds.Text
                .SetIcon(True)
                .Refresh()
                picMain.BackgroundImage = .picMain.Image
            End With
        Else
            frmMain.picMain.Image = Nothing
            frmMain.Refresh()
            picMain.BackgroundImage = Nothing
            Refresh()
        End If
    End Sub
#End Region

End Class