Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Collections.Specialized
Imports System.IO
Imports Ionic.Zip

Module modFile

    Public AppDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public TheFlashOrRegularDirectoryPath As String = ""
    Public BinaryFileDirectoryPath As String = ""
    Public INISettingsPath As String = ""
    Public UserConfigFolder As String = ""
    Public UserConfigPath As String = ""
    Public ListHistoryPath As String = ""
    Public STPFolder As String = ""
    Public SoundDirectoryPath As String = ""
    Public IconDirectoryPath As String = ""
    Public RevertTextLogPath As String = ""
    Public GifDirectory As String = ""
    Public DosDirectory As String = ""
    Public ZipDirectory As String = ""
    Public FlashDirectory As Boolean = False

    Sub SetAllBSRDirectoryPaths()
        Settings.UserConfigBinaryFilePath = AppDataPath & "\BlackCrestSoft\BlackShellRunner\BSR_USR.BIN"
        Dim DirectoryPath As String = ""
        If IsFlashDirectory() Then
            FlashDirectory = True
            DirectoryPath = ReturnBSRPath()
        Else
            FlashDirectory = False
            DirectoryPath = My.Application.Info.DirectoryPath
        End If
        'Set Encrypted DES User Configuration Binary File Path
        UserConfigPath = AppDataPath & "\BlackCrestSoft\BlackShellRunner\BSR_USR.BIN"
        'Set Main BSR Directory
        TheFlashOrRegularDirectoryPath = DirectoryPath & "\BSR_DIR"
        'Set Binary Paths
        BinaryFileDirectoryPath = TheFlashOrRegularDirectoryPath & "\BSR_BIN"
        ListHistoryPath = BinaryFileDirectoryPath & "\BSR_LST.BIN"
        'Set INI Paths
        UserConfigFolder = TheFlashOrRegularDirectoryPath & "\BSR_INI"
        INISettingsPath = UserConfigFolder & "\BSR_CFG.INI"
        'Set STP Folder
        STPFolder = TheFlashOrRegularDirectoryPath & "\BSR_STP"
        'Set Icon Folder
        IconDirectoryPath = TheFlashOrRegularDirectoryPath & "\BSR_ICO"
        'Set WAV Sound Folder
        SoundDirectoryPath = TheFlashOrRegularDirectoryPath & "\BSR_SND"
        'Set Revert Log Path
        RevertTextLogPath = TheFlashOrRegularDirectoryPath & "\BSR_LOG.TXT"
        'Make Non Existent Directories
        GifDirectory = TheFlashOrRegularDirectoryPath & "\BSR_PIC"
        DosDirectory = TheFlashOrRegularDirectoryPath & "\BSR_DOS"
        ZipDirectory = TheFlashOrRegularDirectoryPath & "\BSR_ZIP"
        Dim ZipPath As String = ZipDirectory & "\BSR_PIC.zip"
        If Not PathExists(DirectoryPath, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(DirectoryPath)
        If Not PathExists(UserConfigFolder, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(UserConfigFolder)
        If Not PathExists(STPFolder, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(STPFolder)
        If Not PathExists(IconDirectoryPath, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(IconDirectoryPath)
        If Not PathExists(SoundDirectoryPath, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(SoundDirectoryPath)
        If Not PathExists(GifDirectory, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(GifDirectory)
        If Not PathExists(DosDirectory, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(DosDirectory)
        If Not PathExists(ZipDirectory, TypeOfPath.Directory) Then _
            IO.Directory.CreateDirectory(ZipDirectory)
        '  If Not PathExists(ZipPath, TypeOfPath.File) Then
        IO.File.WriteAllBytes(ZipPath, Resources.BSR_PIC)
            Decompress()
        ' End If
    End Sub

    Private Sub Decompress()
        Dim zipPath = ZipDirectory & "\BSR_PIC.zip"
        Dim extractPath As String = GifDirectory
        Try
            Using zip As ZipFile = ZipFile.Read(zipPath)
                zip.ExtractAll(extractPath, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
            End Using
        Catch ex1 As Exception
            Console.Error.WriteLine("exception: {0}", ex1.ToString)
        End Try
    End Sub
    Sub SavePosition(ByVal frm As Form)
        Settings.MakeSetting("ScreenPosition", New Point(frm.Left, frm.Top))
    End Sub

    Sub SetPosition(ByVal frm As Form)
        frm.Location = Settings.RetrieveSetting("ScreenPosition")
    End Sub

    Sub SaveColors(ByVal FC As Color, ByVal BC As Color, ByVal SC As Color)
        On Error Resume Next
        'IMPORTANT DO NOT USE FC, BC OR SC IN YOUR STRING KEY OR IT WILL SAVE BLANK SETTINGS
        'Delay(2)
        INIWrite(INISettingsPath, "Encrypted Settings", "ForeColor", FC.ToArgb.ToString.Encrypt("ForC" & KeyForHash), "%|BSR_DES|%")
        INIWrite(INISettingsPath, "Encrypted Settings", "BackColor", BC.ToArgb.ToString.Encrypt("BacC" & KeyForHash), "%|BSR_DES|%")
        INIWrite(INISettingsPath, "Encrypted Settings", "ShadowColor", SC.ToArgb.ToString.Encrypt("ShaC" & KeyForHash), "%|BSR_DES|%")
    End Sub

    Sub LoadColors()
        'Delay(2)
        'IMPORTANT The blank string in this is Default Value it will not work if it is not included...
        Dim ForeCol As String = INIRead(INISettingsPath, "Encrypted Settings", "ForeColor", "", "%|BSR_DES|%").Decrypt("ForC" & KeyForHash)
        Dim BackCol As String = INIRead(INISettingsPath, "Encrypted Settings", "BackColor", "", "%|BSR_DES|%").Decrypt("BacC" & KeyForHash)
        Dim ShadowCol As String = INIRead(INISettingsPath, "Encrypted Settings", "ShadowColor", "", "%|BSR_DES|%").Decrypt("ShaC" & KeyForHash)
        If ForeCol = "" Or BackCol = "" Or ShadowCol = "" Then
            ColorFormsAndControls(Color.Lime, Color.Black, Color.Green)
            Exit Sub
        End If
        ColorFormsAndControls(Color.FromArgb(ForeCol), Color.FromArgb(BackCol), Color.FromArgb(ShadowCol))
    End Sub

    Sub RmLst(ByVal TxtToRm As String, ByVal Obj As Object, ByVal WriteToFile As Boolean, Optional ByVal FileName As String = "BSR_LST.BIN", Optional ByVal AllowingRepeats As Boolean = False)
        TxtToRm = TxtToRm.TRM
        Obj.Items.Remove(TxtToRm)
        Dim StrCol As New StringCollection
        For Each Item As String In Obj.items
            StrCol.Add(Item.Encrypt(KeyForHash))
        Next
        Dim Binary As BinaryFormatter
        Dim Stream As FileStream
        If WriteToFile Then
            If Not PathExists(BinaryFileDirectoryPath, TypeOfPath.Directory) Then My.Computer.FileSystem.CreateDirectory(BinaryFileDirectoryPath)
            Binary = New BinaryFormatter
            Stream = New FileStream(BinaryFileDirectoryPath & "\" & FileName, FileMode.OpenOrCreate)
            Try
                Binary.Serialize(Stream, StrCol)
            Catch ex As Exception
            End Try
        End If
        Stream.Close()
    End Sub

    Sub AddLst(ByVal TxtToAdd As String, ByVal Obj As Object, ByVal WriteToFile As Boolean, Optional ByVal FileName As String = "BSR_LST.BIN", Optional ByVal AllowingRepeats As Boolean = False, Optional ByVal WriteLastCmdINISettring As Boolean = True, Optional ByVal JustWriteToFile As Boolean = False)
        TxtToAdd = TxtToAdd.TRM
        Dim AlreadyExists As Boolean = False
        For Each Item As String In Obj.Items
            If TxtToAdd.UC = Item.UC Then AlreadyExists = True
        Next
        If JustWriteToFile Then GoTo WriteToFile
        If AllowingRepeats Then
            Obj.Items.Add(TxtToAdd)
            If WriteLastCmdINISettring Then INIWrite(INISettingsPath, "Settings", "LastCommand", TxtToAdd)
        ElseIf Not AllowingRepeats Then
            If Not AlreadyExists Then
                Obj.Items.Add(TxtToAdd)
                If WriteLastCmdINISettring Then INIWrite(INISettingsPath, "Settings", "LastCommand", TxtToAdd)
            End If
        End If
WriteToFile:
        Dim StrCol As New StringCollection
        StrCol.Clear()
        For Each Item As String In Obj.Items
            Dim I As String = Item
            StrCol.Add(I.Encrypt(KeyForHash))
        Next
        Dim Binary As BinaryFormatter 'New BinaryFormatter
        Dim Stream As FileStream
        If WriteToFile Then
            If Not PathExists(BinaryFileDirectoryPath, TypeOfPath.Directory) Then My.Computer.FileSystem.CreateDirectory(BinaryFileDirectoryPath)
            Binary = New BinaryFormatter
            Stream = New FileStream(BinaryFileDirectoryPath & "\" & FileName, FileMode.OpenOrCreate)
            Binary.Serialize(Stream, StrCol)
            Stream.Close()
        End If
    End Sub

    Sub WriteListToFile(ByVal obj As Object, Optional ByVal FileName As String = "BSR_LST.BIN")
        Dim BinPath As String = BinaryFileDirectoryPath & "\" & FileName
        If PathExists(BinPath, TypeOfPath.File) Then IO.File.Delete(BinPath)
        Dim StrCol As New StringCollection
        StrCol.Clear()
        For Each Item As String In obj.Items
            Dim I As String = Item
            StrCol.Add(I.Encrypt(KeyForHash))
        Next
        Dim Binary As BinaryFormatter 'New BinaryFormatter
        Dim Stream As FileStream
        Dim BinDir As String = BinPath.RSAtE("\" & FileName)
        If Not PathExists(BinDir, TypeOfPath.Directory) Then
            My.Computer.FileSystem.CreateDirectory(BinDir)
        End If
        Binary = New BinaryFormatter
        Stream = New FileStream(BinPath, FileMode.CreateNew)
        Try
            Binary.Serialize(Stream, StrCol)
            Stream.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadLst(ByVal Obj As Object, Optional ByVal FileName As String = "BSR_LST.BIN", Optional ByVal LoadCustomCommands As Boolean = True)
        Obj.Items.Clear()
        Dim StrCol As New StringCollection
        Dim Binary As New BinaryFormatter
        Dim ItmDC As String = ""
        Dim Stream As New FileStream(BinaryFileDirectoryPath & "\" & FileName, FileMode.OpenOrCreate)
        StrCol = CType(Binary.Deserialize(Stream), StringCollection)
        Try
            For Each Item As String In StrCol
                ItmDC = Item.Decrypt(KeyForHash)
                If Not ItmDC = "" Then
                    If Not LoadCustomCommands Then If modCustomCmd.ItIsACustomCommand(ItmDC) Then GoTo SkipIt
                    Obj.Items.Add(ItmDC)
SkipIt:
                End If
            Next
            Stream.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub ChangeSeparator(ByVal NewSeparator As String)
        Dim StrCol As New StringCollection
        Dim strCol2 As New StringCollection
        Dim Binary As New BinaryFormatter
        Dim ItmDC As String = ""
        Dim BinFilePath As String = BinaryFileDirectoryPath
        Dim CurrentFile As String = ""
        If Not Settings.RetrieveSetting("OldSeparator") = NewSeparator Then
            'MsgBox(Settings.RetrieveSetting("OldSeparator") & " " & NewSeparator)
            For Each File As String In IO.Directory.GetFiles(BinFilePath)
                'MsgBox(File)
                Dim Stream As New FileStream(File, FileMode.Open)
                StrCol = CType(Binary.Deserialize(Stream), StringCollection)
                Stream.Close()
                Do Until Not PathExists(File, TypeOfPath.File)
                    IO.File.Delete(File)
                Loop
                For Each Item As String In StrCol
                    Dim De As String = Item.Decrypt(KeyForHash)
                    De = De.RP(Settings.RetrieveSetting("OldSeparator").ToString, NewSeparator)
                    'MsgBox(De)
                    strCol2.Add(De.Encrypt(KeyForHash))
                Next
                StrCol.Clear()
                Dim Stream2 As FileStream = New FileStream(File, FileMode.CreateNew)
                Binary.Serialize(Stream2, strCol2)
                Stream2.Close()
                strCol2.Clear()
            Next
        End If
        Settings.MakeSetting("OldSeparator", NewSeparator)
    End Sub

    Sub LoadCstmCmds()
        With frmCustomCommads
            .lstCstCmds.Items.Clear()
            .cmbCstCmds.Items.Clear()
        End With
        Dim CC() As String = System.IO.Directory.GetFiles(BinaryFileDirectoryPath)
        For d As Integer = 0 To CC.GetUpperBound(0)
            Dim a As New IO.FileInfo(CC(d))
            If Not a.Name = "BSR_LST.BIN" Then
                With frmCustomCommads
                    .lstCstCmds.Items.Add(a.Name.LC.RSAtE(".bin"))
                    .cmbCstCmds.Items.Add(a.Name.LC.RSAtE(".bin"))
                End With
            End If
        Next
        SetLstToTopInx(frmCustomCommads.lstCstCmds)
    End Sub

    Sub SetLstToTopInx(ListObj As Object)
        With ListObj
            Dim ItmCnt As Integer = .Items.Count
            Dim TopInx As Integer = (ItmCnt - 1)
            If ItmCnt > 0 Then
                .SelectedIndex = TopInx
            End If
        End With
    End Sub

End Module