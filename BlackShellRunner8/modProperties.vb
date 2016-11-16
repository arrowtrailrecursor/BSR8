Imports System.Runtime.InteropServices

Public Module modProperties

    Public SelectSound As String = ""
    Public HideShowSound As String = ""
    Public CloseSound As String = ""
    Public InfoSound As String = ""
    Public ErrorSound As String = ""

    Sub SetAllMainProperties()
        'SetFormOpacity
        SetOpacity()
        'SetLabelShapeAndMarqueeShadows
        SetShadows()
        'SetSoundsAndColors
        With frmOptions
            'Sound
            SetSounds(.chkSound.Checked)
            'Colors
            ColorFormsAndControls(.picForeColor.BackColor, .picBackColor.BackColor, .picShadowColor.BackColor)
        End With
        'SetsCompatibleTextForEarlierWindowsVersions
        MakeTextsCompatible()
        'SetsAutoRaisingOfWindowsIfSettingIsTrue
        AddMouseMoveEvents()
        'ChecksAndSetsCommandLineSeparator
        CheckForSeparator()
        'SetsComboBoxMultilinePastingCarriageReturnReplacementCharacter
        SetMultilinePasteComboJoiner()
        'Set The Extender ToolTips For Combos And Lists
        SetExtenderToolTips(ToolTipBoxStyle)
        'Set Line Size
        SetLineSize()
    End Sub

    Private Sub CheckForSeparator()
        Dim BSRCommandLineSeparator As String = INIRead(INISettingsPath, "Settings", "CommandLineSeparator")
        If Not BSRCommandLineSeparator.TRM = "" Then
            frmMain.CommandLineSeparator = BSRCommandLineSeparator
            ChangeSeparator(BSRCommandLineSeparator)
        End If
    End Sub

    Private Sub SetMultilinePasteComboJoinerRecursivly(ByVal Parent As Control)
        For Each ChildControl As Object In Parent.Controls
            If TypeOf ChildControl Is AcidControls.AcidComboBox Then
                ChildControl.PasteMultilineJoiningCharacter = frmMain.CommandLineSeparator
            End If
            Try
                SetMultilinePasteComboJoinerRecursivly(ChildControl)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Property ToolTipBoxStyle As ToolTipControlBoxStyle = ToolTipControlBoxStyle.BothCombosAndLists

    Public Enum ToolTipControlBoxStyle
        JustCombos = 0
        BothCombosAndLists = 1
    End Enum

    Public Property PicturePath As String
    Public Sub SetBackGroundAnimation(ByVal FilePath As String)
        With frmOptions
            .PicBackPic.BackgroundImage = Nothing
            .PicBackPic.BackgroundImage = New Bitmap(FilePath)
            Dim FileName As String = FilePath.SPT("\").Last
            Dim GifNewPath As String = GifDirectory & "\" & FileName
            If Not PathExists(GifNewPath, TypeOfPath.File) Then
                FileCopy(PicturePath, GifNewPath)
            End If
            INIWrite(INISettingsPath, "Settings", "Background", FileName)
            INIWrite(INISettingsPath, "Settings", "BackgroundTransparency", .tbPicOpacity.Value)
            .chkPic.Enabled = True
            .chkPic.Checked = False
            .chkPic.Checked = True
            INIWrite(INISettingsPath, "Settings", "HasBackground", .chkPic.Checked)
        End With
    End Sub

    Private Sub SetExtenderToolTipRecursivly(ByVal Parent As Control, ByVal HasToolTips As Boolean, Optional ByVal ControlTTBoxStyle As ToolTipControlBoxStyle = ToolTipControlBoxStyle.JustCombos)
        For Each ChildControl As Object In Parent.Controls
            If TypeOf ChildControl Is AcidControls.AcidComboBox Or TypeOf ChildControl Is AcidControls.AcidListBox Then
                With ChildControl
                    .ShowExtenderToolTips = False
                    If ControlTTBoxStyle = ToolTipControlBoxStyle.BothCombosAndLists Then
                        .ShowExtenderToolTips = HasToolTips
                    Else
                        If TypeOf ChildControl Is AcidControls.AcidComboBox Then .ShowExtenderToolTips = HasToolTips
                    End If
                    .SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
                    .SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
                End With
            End If
            Try
                SetExtenderToolTipRecursivly(ChildControl, HasToolTips, ControlTTBoxStyle)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub SetLineSizeRecursivly(ByVal Parent As Control, ByVal LineSize As Integer)
        For Each ChildControl As Object In Parent.Controls
            If TypeOf ChildControl Is AcidControls.AcidButton Or TypeOf ChildControl Is AcidControls.AcidListBox Then
                ChildControl.LineSize = LineSize
            End If
            Try
                SetLineSizeRecursivly(ChildControl, LineSize)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub SetShadowsRecursively(ByVal ParentControl As Control)
        Dim ParentWindow As Form
        With ParentControl
            For Each ChildControl As Object In .Controls
                If (TypeOf ChildControl Is AcidControls.AcidButton) Or (TypeOf ChildControl Is AcidControls.AcidScrollingMarquee) Then
                    ParentWindow = ChildControl.FindForm
                    With ParentWindow
                        If .TopLeft Then ChildControl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
                        If .TopRight Then ChildControl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopRight
                        If .BottomLeft Then ChildControl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.BottomLeft
                        If .BottomRight Then ChildControl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.BottomRight
                    End With
                End If
                If (TypeOf ChildControl Is AcidControls.AcidListBox) Or (TypeOf ChildControl Is AcidControls.AcidComboBox) Then
                    With ChildControl
                        .SelectedItemHasShadow = True
                        .ShadowOnMouseEnter = True
                        .ShiftOnClick = True
                    End With
                End If
                If (TypeOf ChildControl Is AcidControls.AcidTextBox) Then
                    With ChildControl
                        .ShadowOnMouseEnter = True
                        .ShiftOnClick = True
                    End With
                End If
                Try
                    SetShadowsRecursively(ChildControl)
                Catch ex As Exception
                End Try
            Next
        End With
    End Sub

    Sub SetLineSize()
        Dim LineSize As Integer = 2
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            SetLineSizeRecursivly(ParentWindow, LineSize)
        Next
    End Sub

    Sub SetMultilinePasteComboJoiner()
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            SetMultilinePasteComboJoinerRecursivly(ParentWindow)
        Next
    End Sub

    Sub SetExtenderToolTips(Optional ByVal ControlTTBoxStyle As ToolTipControlBoxStyle = ToolTipControlBoxStyle.JustCombos)
        Dim Val As Boolean
        If Not INIRead(INISettingsPath, "Settings", "ShowExtenderToolTips") = "" Then
            Val = Convert.ToBoolean(INIRead(INISettingsPath, "Settings", "ShowExtenderToolTips"))
        Else
            Exit Sub
        End If
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            SetExtenderToolTipRecursivly(ParentWindow, Val, ControlTTBoxStyle)
        Next
    End Sub

    Sub SetOpacity()
        Dim Opaque As String = INIRead(INISettingsPath, "Settings", "OpacityPercent")
        Dim OPA As Integer = 100
        If Not Opaque = "" Then
            OPA = Convert.ToInt32(Opaque)
            For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
                With ParentWindow
                    If Not OPA < 25 And Not OPA > 100 Then
                        .Opacity = Convert.ToDouble(OPA / 100)
                    End If
                    If OPA < 25 Then
                        .Opacity = 0.25
                    End If
                    If OPA > 100 Then
                        .Opacity = 1
                    End If
                End With
            Next
            With frmOptions.tbTransparency
                If OPA < 25 Or OPA > 100 Then
                    If OPA < 25 Then
                        .Value = 25
                        INIWrite(INISettingsPath, "Settings", "OpacityPercent", "25")
                    End If
                    If OPA > 100 Then
                        .Value = 100
                        INIWrite(INISettingsPath, "Settings", "OpacityPercent", "100")
                    End If
                End If
            End With
        End If
    End Sub

    Sub SetShadows()
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            SetShadowsRecursively(ParentWindow)
        Next
    End Sub
    Sub SetSounds(ByVal Enabled As Boolean)
        'Make sure sounds folder exists \/
        If Not PathExists(TheFlashOrRegularDirectoryPath & "\BSR_SND", TypeOfPath.Directory) Then
            IO.Directory.CreateDirectory(TheFlashOrRegularDirectoryPath & "\BSR_SND")
        End If
        '---------------------------------
        'Define Sound file Paths \/
        SelectSound = TheFlashOrRegularDirectoryPath & "\BSR_SND\BSR_SEL.wav"
        HideShowSound = TheFlashOrRegularDirectoryPath & "\BSR_SND\BSR_HSW.wav"
        CloseSound = TheFlashOrRegularDirectoryPath & "\BSR_SND\BSR_CSE.wav"
        InfoSound = TheFlashOrRegularDirectoryPath & "\BSR_SND\BSR_INF.wav"
        ErrorSound = TheFlashOrRegularDirectoryPath & "\BSR_SND\BSR_ERR.wav"
        '--------------------------
        'Extract the sounds \/
        'Just To Make Sure These ones exist first if not they will be extracted later with the recursion.
        If Not PathExists(SelectSound, TypeOfPath.File) Then
            Dim bytes(My.Resources.BSRbtnSel.Length) As Byte
            My.Resources.BSRbtnSel.Read(bytes, 0, bytes.Length)
            IO.File.WriteAllBytes(SelectSound, bytes)
        End If
        If Not PathExists(HideShowSound, TypeOfPath.File) Then
            Dim bytes(My.Resources.BSRbtnHideShow.Length) As Byte
            My.Resources.BSRbtnHideShow.Read(bytes, 0, bytes.Length)
            IO.File.WriteAllBytes(HideShowSound, bytes)
        End If
        If Not PathExists(CloseSound, TypeOfPath.File) Then
            Dim bytes(My.Resources.BSRbtnClose.Length) As Byte
            My.Resources.BSRbtnClose.Read(bytes, 0, bytes.Length)
            IO.File.WriteAllBytes(CloseSound, bytes)
        End If
        'Then The Rest
        If Not PathExists(InfoSound, TypeOfPath.File) Then
            Dim bytes(My.Resources.BSRInfo.Length) As Byte
            My.Resources.BSRInfo.Read(bytes, 0, bytes.Length)
            IO.File.WriteAllBytes(InfoSound, bytes)
        End If
        If Not PathExists(ErrorSound, TypeOfPath.File) Then
            Dim bytes(My.Resources.BSRError.Length) As Byte
            My.Resources.BSRError.Read(bytes, 0, bytes.Length)
            IO.File.WriteAllBytes(ErrorSound, bytes)
        End If
        'Lastly Set The Sounds recursivly
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            'Set Main LabelShape Sounds
            SetSoundsRecursivley(ParentWindow, Enabled)
            'SetFrms Hide/Show Sounds
            With ParentWindow
                If Not .Name = frmCorners.Name And Not .Name = "frmWebBrowse" Then
                    If Not .Name = frmMain.Name Then AddHandler .Shown, AddressOf ShowSound
                    AddHandler .FormClosing, AddressOf HideSoundAndClosingEvent
                End If
            End With
        Next
    End Sub

    Sub ColorFormsAndControls(ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        'Color Jus Bout Damn Near Everything
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            ParentWindow.ForeColor = ForeColor
            ParentWindow.BackColor = BackColor
            ColorRecursively(ParentWindow, ForeColor, BackColor, ShadowColor)
        Next
        'Then We be need to set the Tool Tips Colors
        For Each MainToolTip As AcidControls.AcidToolTip In TheBlackShellRunnerProject.ColoredToolTips
            With MainToolTip
                .ForeColor = ForeColor
                .BackColor = BackColor
                .ShowAlways = True
            End With
        Next
        'Finally Set Color Pickers Colors
        With frmOptions
            .picForeColor.BackColor = ForeColor
            .picBackColor.BackColor = BackColor
            .picShadowColor.BackColor = ShadowColor
        End With
    End Sub

    Sub MakeTextsCompatible()
        For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
            RecursiveMakeTextCompatable(ParentWindow)
        Next
    End Sub

    Sub AddMouseMoveEvents()
        On Error Resume Next
        Dim AutoRaise As Boolean = INIReadBoolean(INISettingsPath, "Settings", "AutoRaiseWindows")
        If AutoRaise Then
            For Each ParentWindow As Form In TheBlackShellRunnerProject.Forms
                RecursiveMouseEventCreate(ParentWindow) 'Set Mouse Events For Family Tree
            Next
        End If
    End Sub

    Private Sub SetSoundsRecursivley(ByVal Parent As Control, ByVal Enabled As Boolean)
        For Each Obj As Object In Parent.Controls
            If (TypeOf Obj Is AcidControls.AcidButton) Then
                Obj.HasSound = Enabled
                Obj.MouseEnterSound = SelectSound
                Obj.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
                If Obj.Text.ToString.UC = "OK" _
                        Or
                        Obj.Text.ToString.UC = "CANCEL" _
                        Or
                        Obj.Text.ToString.UC = "EXIT" _
                        Or
                        Obj.Text.ToString.UC = "X" _
                        Then
                    Obj.MouseClickSound = CloseSound
                    Obj.ClickHidesParent = True
                    If Obj.Text.ToString.UC = "X" Then
                        Obj.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
                    End If
                End If
                If Obj.Text.ToString.UC = "HIDE" _
                        Or
                        Obj.Text.ToString.UC = "SHOW" _
                        Then
                    Obj.MouseClickSound = HideShowSound
                    Obj.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
                End If
            End If
            Try
                SetSoundsRecursivley(Obj, Enabled)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub ColorLabelShapeMarqueeBorder(ByVal Obj As Object, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        With Obj
            .ForeColor = ForeColor
            .ShadowColor = ShadowColor
            .BackColor = BackColor
            .ShiftForeColor = ShadowColor
            .ShiftShadowColor = ForeColor
        End With
    End Sub

    Private Sub ColorList(ByVal list As AcidControls.AcidListBox, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        With list
            .ForeColor = ForeColor
            .BackColor = BackColor
            .SelectionForeColor = ForeColor
            .SelectionBackColor = ShadowColor
            .ShadowColor = ShadowColor
            .ShiftForeColor = ShadowColor
            .ShiftShadowColor = ForeColor
        End With
    End Sub

    Private Sub ColorCombo(ByVal list As AcidControls.AcidComboBox, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        With list
            .ForeColor = ForeColor
            .BackColor = BackColor
            .ShadowColor = ShadowColor
            .SelectionForeColor = ForeColor
            .SelectionBackColor = ShadowColor
            .ShiftForeColor = ShadowColor
            .ShiftShadowColor = ForeColor
        End With
    End Sub

    Private Sub ColorText(ByVal TextBox As AcidControls.AcidTextBox, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        With TextBox
            .ForeColor = ForeColor
            .BackColor = BackColor
            .ShadowColor = ShadowColor
            .ShiftForeColor = ShadowColor
            .ShiftShadowColor = ForeColor
        End With
    End Sub

    Private Sub ColorRecursively(ByVal Parent As Control, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ShadowColor As Color)
        For Each Obj As Object In Parent.Controls
            With Obj
                .ForeColor = ForeColor
                .BackColor = BackColor
                If (TypeOf Obj Is AcidControls.AcidButton) Or (TypeOf Obj Is AcidControls.AcidBorder) Or (TypeOf Obj Is AcidControls.AcidScrollingMarquee) Then
                    ColorLabelShapeMarqueeBorder(Obj, ForeColor, BackColor, ShadowColor)
                    If (TypeOf Obj Is AcidControls.AcidButton) Then
                        If .ShowBorder And Not .Text = "" Then .Cursor = Cursors.Hand
                    End If
                End If
                If (TypeOf Obj Is AcidControls.AcidTextBox) Then
                    ColorText(Obj, ForeColor, BackColor, ShadowColor)
                End If
                If (TypeOf Obj Is AcidControls.AcidComboBox) Then
                    ColorCombo(Obj, ForeColor, BackColor, ShadowColor)
                End If
                If (TypeOf Obj Is AcidControls.AcidListBox) Then
                    ColorList(Obj, ForeColor, BackColor, ShadowColor)
                End If
                If (TypeOf Obj Is LogicNP.FileViewControl.FileView) Then
                    Obj.ForeColor = ForeColor
                    Obj.BackColor = BackColor
                End If
                If (TypeOf Obj Is LogicNP.FolderViewControl.FolderView) Then
                    .ForeColor = ForeColor
                    .BackColor = BackColor
                    .LineColor = ForeColor
                End If
                If TypeOf Obj Is ListView Then
                    .ForeColor = ForeColor
                    .BackColor = BackColor
                End If
                If TypeOf Obj Is TreeView Then
                    .ForeColor = ForeColor
                    .Backcolor = BackColor
                    .LineColor = ForeColor
                End If
            End With
            Try
                ColorRecursively(Obj, ForeColor, BackColor, ShadowColor)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub RecursiveMakeTextCompatable(ByVal Parent As Control)
        For Each Child As Object In Parent.Controls
            Try
                Child.UseCompatibleTextRendering = True
            Catch ex As Exception
            End Try
            Try
                RecursiveMakeTextCompatable(Child)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub RecursiveMouseEventCreate(ByVal Parent As Control)
        For Each Child As Control In Parent.Controls
            AddMouseEvent(Child)
            Try
                RecursiveMouseEventCreate(Child)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub AddMouseEvent(ChildControl As Control)
        AddHandler ChildControl.MouseEnter, AddressOf BringParentWindowToTopOfZOrder
    End Sub

    Private Sub BringParentWindowToTopOfZOrder(ByVal sender As Object, ByVal e As EventArgs)
        Dim Control As Control = CType(sender, Control)
        Control.FindForm.BringToFront()
        Control.FindForm.Select()
    End Sub

    Private Sub ShowSound()
        If frmOptions.chkSound.Checked Then
            My.Computer.Audio.Play(HideShowSound, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub HideSoundAndClosingEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Dim PlayMode As AudioPlayMode
        Dim HideMe As Boolean
        Dim Form = CType(sender, Form)
        If Form Is frmMain Then
            PlayMode = AudioPlayMode.WaitToComplete
        Else
            PlayMode = AudioPlayMode.Background
        End If
        If Form Is frmMain Or Form Is frmOutput Or Form.Name.CNT("Web") Or Form Is frmCorners Or Form Is frmMessageBox Or Form Is frmHidden Then
            HideMe = False
        Else
            HideMe = True
        End If
        If HideMe Then
            ' If e.CloseReason <> CloseReason.FormOwnerClosing Then
            'e.Cancel = True
            'Form.Hide()
            'End If
            e.Cancel = True
            Form.Hide()
        End If
        If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(CloseSound, PlayMode)
    End Sub
End Module