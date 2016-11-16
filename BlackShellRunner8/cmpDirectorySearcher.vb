Option Explicit On
Imports System.IO
Imports System.Threading
Imports System.Runtime.InteropServices

Public Class cmpDirectorySearcher

    Inherits ListView
    Delegate Sub FileListDelegate(ByVal file As String) ', ByVal inx As Integer)
    Protected _searchCriteria As String
    Protected _searching As Boolean
    Protected _deferSearch As Boolean
    Protected _searchThread As Thread
    Protected _fileListDelegate As FileListDelegate
    Protected _onSearchComplete As EventHandler
    Protected _isMostAllFileSearch As Boolean = False
    Protected _Images As New ImageList
    Protected _ImageIndexList As New List(Of String)
    Protected _CurrentIndex As Integer = 0
    'Protected _BlankIcoPath As String = TempIconDirectoryPath & "\BlankIco.ICO"
    Protected shinfo As SHFILEINFO
    Protected hImgSmall As IntPtr
    Public SearchPattern As String
    Public SearchPath As String
    Public SearchPause As Boolean = False
    Public CurrentlySearchingDirectory As String
    Public TempIconDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BlackCrestSoft\BlackShellRunner\BSR_TMP"
    Public Event SearchComplete As EventHandler

    Protected Structure SHFILEINFO
        Public hIcon As IntPtr ' : icon
        Public iIcon As Integer ' : icondex
        Public dwAttributes As Integer ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)> _
    Shared Function ExtractIconEx(ByVal szFileName As String, _
             ByVal nIconIndex As Integer, _
             ByVal phiconLarge() As IntPtr, _
             ByVal phiconSmall() As IntPtr, _
             ByVal nIcons As UInteger) As UInteger
    End Function

    <DllImport("user32.dll", EntryPoint:="DestroyIcon", SetLastError:=True)> _
    Public Shared Function DestroyIcon(ByVal hIcon As IntPtr) As Integer
    End Function

    Protected Const SHGFI_ICON = &H100
    Protected Const SHGFI_SMALLICON = &H1
    Protected Const SHGFI_LARGEICON = &H0         ' Large icon
    Protected nIndex = 0

    Public Declare Function ExtractIconEx Lib "shell32.dll" (ByVal lpszFile As String, ByVal nIconIndex As IntPtr, ByRef phiconLarge As IntPtr, ByRef phiconSmall As IntPtr, ByVal nIcons As Integer) As IntPtr

    Dim regKey As String = My.Computer.Registry.ClassesRoot.ToString & "\"

    Protected Function getIconFromEx(ByVal file As String, ByVal index As Integer) As Icon
        On Error GoTo Top
        Dim iconPtr As IntPtr
        Dim myicon As Icon
Top:
        ExtractIconEx(file, index, Nothing, iconPtr, 1)
        'ExtractIconEx(file, index, iconPtr, Nothing, 1)
        ' Try
        myicon = Icon.FromHandle(iconPtr)
        'Catch ex As ArgumentException
        '   myicon = New Icon(_BlankIcoPath)
        ' End Try
        Return myicon
    End Function

    Function GetIcon(ByVal ext As String) As Icon
        'Get the register value for the specified key
        Dim regVal As String = My.Computer.Registry.GetValue(regKey & ext, "", Nothing)
        Dim iconVal As String = ""
        Dim filen As String
        Dim MyIndex As Integer
        Try
            'Specify the icon for .exe files
            If ext = ".exe" Then
                iconVal = "shell32.dll,2"

                'Specifi the common procedure
            ElseIf regVal <> "" Then
                If Not My.Computer.Registry.GetValue(regKey & regVal & "\DefaultIcon", "", Nothing) = Nothing Then
                    iconVal = My.Computer.Registry.GetValue(regKey & regVal & "\DefaultIcon", "", Nothing)
                Else
                    iconVal = "shell32.dll,0"
                End If

            ElseIf ext = "dir" Then
                iconVal = "shell32.dll,4"
            End If

            If iconVal.Length < 5 Then
                iconVal = "shell32.dll,0"
            End If
        Catch ex As Exception

            MessageBox.Show("Error in icon")
        End Try

        Dim splt() As String = iconVal.Split(",")

        filen = splt(0).Trim(" ").Trim(Char.ConvertFromUtf32(34))
        Dim icon As Icon
        Try
            MyIndex = splt(1).Trim(" ")
            icon = getIconFromEx(filen, MyIndex)
        Catch ex As IndexOutOfRangeException
            ' icon = System.Drawing.Icon.ExtractAssociatedIcon(_BlankIcoPath) 'New Icon(_BlankIcoPath)
        End Try
        Return icon
    End Function

    'Protected Function GetIcon(ByVal Extension As String, Optional ByVal UseShellFileInfo As Boolean = False) As Icon
    'Dim strDummyFile As String = TempIconDirectoryPath & "\0" & Extension.ToLower
    'Dim ico As Icon = SystemIcons.WinLogo
    'If UseShellFileInfo Then
    'shinfo = New SHFILEINFO
    'End If
    '        If File.Exists(strDummyFile) Then
    'If UseShellFileInfo Then hImgSmall = SHGetFileInfo(strDummyFile, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
    '       Else
    '          File.Create(strDummyFile)
    'If UseShellFileInfo Then hImgSmall = SHGetFileInfo(strDummyFile, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
    '     End If
    '    If UseShellFileInfo Then
    'If Not hImgSmall = 0 Thenr
    ' readIconCount = ExtractIconEx(strDummyFile, 0, hDummy, hIconEx, 1)
    '       ico = ExtractIconFromFile(strDummyFile, False) 'System.Drawing.Icon.FromHandle(shinfo.hIcon) '= System.Drawing.Icon.ExtractAssociatedIcon(strDummyFile)
    ' Else
    '    ico = New Icon(_BlankIcoPath)
    ' End If
    ' Else
    '      ico = System.Drawing.Icon.ExtractAssociatedIcon(strDummyFile)
    'End If
    '   Return ico
    'End Function

    Public Sub New()
        _fileListDelegate = New FileListDelegate(AddressOf AddFiles)
        _onSearchComplete = New EventHandler(AddressOf OnSearchComplete)
    End Sub

    Public Property SearchCriteria() As String
        Set(ByVal value As String)
            Dim wasSearching As Boolean = Searching
            If wasSearching Then
                StopSearch()
            End If
            Items.Clear()
            _searchCriteria = value
            If wasSearching Then
                BeginSearch()
            End If
        End Set
        Get
            Return _searchCriteria
        End Get
    End Property

    Public ReadOnly Property Searching() As Boolean
        Get
            Return _searching
        End Get
    End Property

    Protected Function getIconIndex(ByVal File As String)
        Dim ExtensionString As String = New IO.FileInfo(File).Extension
        Dim ContainsExtension As Boolean = False
        Dim TheItem As String
        For Each Item As String In _ImageIndexList
            If Item.Contains(ExtensionString & "|^|*") Then
                ContainsExtension = True
                TheItem = Item
                Exit For
            End If
        Next
        Static IconIndex As Integer = 1 '0 is blankico inx
        Dim inx As Integer
        Dim Spt() As String
        If ContainsExtension Then
            Spt = Strings.Split(TheItem, "|^|")
            IconIndex = CInt(Spt(1)) ' CInt Goes Up To 2,147,483,647 Indexes Thats What We Need Here Says Billy
        ElseIf Not ContainsExtension Then
            Try
                Dim icon As Icon = GetIcon(ExtensionString)
                _Images.Images.Add(icon)
                icon.Dispose()
                DestroyIcon(icon.Handle)
                _ImageIndexList.Add(ExtensionString & "|^|" & IconIndex)
                inx = IconIndex
                IconIndex += 1
                Return inx
            Catch ex As Exception
                Return 0
            End Try
        End If
        Return IconIndex
    End Function

    Private Sub AddFiles(ByVal File As String)
        Items.Add(File)
        Items(Items.Count - 1).EnsureVisible()
    End Sub

    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        If Not RecreatingHandle Then
            StopSearch()
        End If
        MyBase.OnHandleDestroyed(e)
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        If _deferSearch Then
            _deferSearch = False
            BeginSearch()
        End If
    End Sub

    Private Sub OnSearchComplete(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent SearchComplete(sender, e)
    End Sub

    Public Sub DeleteTemporaryIconFolder()
        If Directory.Exists(TempIconDirectoryPath) Then Directory.Delete(TempIconDirectoryPath, True)
    End Sub

    Public Sub BeginSearch()
        On Error Resume Next
        If Searching Then
            Return
        End If
        'Create Temp For Dummy Icons
        DeleteTemporaryIconFolder()
        If Not Directory.Exists(TempIconDirectoryPath) Then Directory.CreateDirectory(TempIconDirectoryPath)
        'Clear Images in Image List And Image Index String List
        _Images.Images.Clear()
        _ImageIndexList.Clear()
        _CurrentIndex = 0
        ' My.Computer.FileSystem.WriteAllBytes(_BlankIcoPath, My.Resources.IconBlank1, False)
        '  _Images.Images.Add(New Icon(_BlankIcoPath, New Size(16, 16)))
        'Set Search Pattern
        If SearchPattern = "*.*" Or SearchPattern = "*" Then _isMostAllFileSearch = True
        'Set ListView Properties For Search
        View = System.Windows.Forms.View.Details
        Items.Clear()
        Columns.Clear()
        Columns.Add("File Path")
        Columns.Item(0).Width = Width
        SmallImageList = _Images
        'Set Search Thread
        If IsHandleCreated Then
            _searchThread.SetApartmentState(ApartmentState.STA)
            _searchThread = New Thread(New ThreadStart(AddressOf ThreadProcedure))
            _searching = True
            _searchThread.Start()
            Application.Run()
        Else
            _deferSearch = True
        End If
    End Sub

    Public Sub StopSearch()
        If Not _searching Then
            Return
        End If
        If _searchThread.IsAlive Then
            _searchThread.Abort()
            _searchThread.Join()
        End If
        _searchThread = Nothing
        _searching = False
        DeleteTemporaryIconFolder()
    End Sub

    Public Function Search(ByVal SearchPath As String, ByVal SearchPattern As String) As IEnumerable(Of String)
        Dim dirs As Queue(Of String) = New Queue(Of String)()
        dirs.Enqueue(SearchPath)
        CurrentlySearchingDirectory = SearchPath
        Do While dirs.Count > 0
            Dim dir As String = dirs.Dequeue()
            CurrentlySearchingDirectory = dir
            Do While SearchPause
                clsWinFormUtils.DoPaintEvents()
            Loop
            clsWinFormUtils.Delay(0.05)
            Dim paths() As String = Nothing
            Try
                paths = Directory.GetFiles(dir, SearchPattern) ' swallow
            Catch
            End Try
            Dim r As IAsyncResult
            If paths IsNot Nothing AndAlso paths.Length > 0 Then
                For Each file As String In paths
                    r = BeginInvoke(_fileListDelegate, New Object() {file})
                    Do While SearchPause
                        clsWinFormUtils.DoPaintEvents()
                    Loop
                    clsWinFormUtils.Delay(0.05)
                Next file
            End If
            ' sub-directories
            paths = Nothing
            Try
                paths = Directory.GetDirectories(dir) ' swallow
            Catch
            End Try
            If paths IsNot Nothing AndAlso paths.Length > 0 Then
                For Each subDir As String In paths
                    CurrentlySearchingDirectory = subDir
                    Do While SearchPause
                        clsWinFormUtils.DoPaintEvents()
                    Loop
                    clsWinFormUtils.Delay(0.05)
                    dirs.Enqueue(subDir)
                Next subDir
            End If
        Loop
    End Function

    Private Sub ThreadProcedure()
        Try
            Search(SearchPath, SearchPattern)
        Finally
            _searching = False
            BeginInvoke(_onSearchComplete, New Object() {Me, EventArgs.Empty})
        End Try
    End Sub

    Private Sub DirectorySearcher_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Columns.Count > 0 Then
            Columns.Item(0).Width = Width
        End If
    End Sub

    Private Sub DirectorySearcher_SearchComplete(sender As Object, e As System.EventArgs) Handles Me.SearchComplete
        DeleteTemporaryIconFolder()
    End Sub

    Public NotInheritable Class clsWinFormUtils

        Private Sub New()
        End Sub

        Public Shared Sub DoPaintEvents()
            'MessageFilter registration
            Application.AddMessageFilter(PaintMessageFilter.Instance)
            'Process messages in the queue
            Application.DoEvents()
            'MessageFilter desregistration
            Application.RemoveMessageFilter(PaintMessageFilter.Instance)
        End Sub

        Public Shared Sub Delay(ByVal dblSecs As Double)
            Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
            Dim dblWaitTil As Date
            Now.AddSeconds(OneSec)
            dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
            Do Until Now > dblWaitTil
                Application.AddMessageFilter(PaintMessageFilter.Instance)
                My.Application.DoEvents() ' Allow windows messages to be processed
                Application.RemoveMessageFilter(PaintMessageFilter.Instance)
            Loop
        End Sub

        ''' <summary> Custom message filter </summary>
        Protected Class PaintMessageFilter

            Implements IMessageFilter

            Public Shared Instance As IMessageFilter = New PaintMessageFilter()

#Region "IMessageFilter Members"

            Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements IMessageFilter.PreFilterMessage
                Return (m.Msg <> &HF) 'WM_PAINT -> we only let WM_PAINT messages through
            End Function

#End Region

        End Class

    End Class
End Class