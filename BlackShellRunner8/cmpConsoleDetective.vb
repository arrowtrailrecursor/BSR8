Option Explicit On
Imports System.Threading
Imports System.IO
Public Class cmpConsoleDetective
    Inherits ListView

    Delegate Sub FileListDelegate(ByVal Text As String, ByVal ColumnText As String)
    Delegate Sub PathAddDelegate(ByVal Text As String)
    Delegate Sub PathNameAddDelegate(ByVal Text As String)
    Protected _fileListDelegate As FileListDelegate
    Protected _pathAddDelegate As PathAddDelegate
    Protected _pathNameAddDelegate As PathNameAddDelegate
    Protected _onSearchComplete As EventHandler
    Protected _searchThread As Thread
    Protected _deferSearch As Boolean
    Protected _searching As Boolean
    Public Shared EnvironmentPaths As New System.Collections.Specialized.StringCollection
    Public Shared EnvironmentPathsNames As New System.Collections.Specialized.StringCollection
    Public Event SearchComplete As EventHandler

    Public Sub New()
        _fileListDelegate = New FileListDelegate(AddressOf AddFiles)
        _pathAddDelegate = New PathAddDelegate(AddressOf AddPathToCollection)
        _pathNameAddDelegate = New PathNameAddDelegate(AddressOf AddPathNameToCollection)
        _onSearchComplete = New EventHandler(AddressOf OnSearchComplete)
    End Sub

    Private Sub OnSearchComplete(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent SearchComplete(sender, e)
    End Sub

    Public ReadOnly Property Searching() As Boolean
        Get
            Return _searching
        End Get
    End Property

    Private Sub AddFiles(ByVal Text As String, ByVal ColumnText As String)
        Dim lvi As ListViewItem = Items.Add(Text)
        lvi.SubItems.Add(ColumnText)
        Items(Items.Count - 1).EnsureVisible()
    End Sub

    Private Sub AddPathToCollection(ByVal Text As String)
        EnvironmentPaths.Add(Text)
    End Sub

    Private Sub AddPathNameToCollection(ByVal Text As String)
        EnvironmentPathsNames.Add(Text)
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

    Public Sub BeginSearch()
        ' Delay(2)
        If Searching Then
            Return
        End If
        EnvironmentPaths.Clear()
        EnvironmentPathsNames.Clear()
        View = System.Windows.Forms.View.Details
        Items.Clear()
        Columns.Clear()
        Columns.Add("Possible Console Commands")
        Columns.Add("Commmand Type")
        If Columns.Count > 0 Then
            Columns.Item(0).Width = Width / Columns.Count
            Columns.Item(1).Width = Width / Columns.Count
        End If
        Dim PS() As String = My.Resources.PSCmds.SPT(vbCrLf)
        Dim DOS() As String = My.Resources.MSDOSCmds.SPT(vbCrLf)
        Items.AddRange(PS.Select(Function(x) New ListViewItem(x)).ToArray)
        For Each item As ListViewItem In Items
            item.SubItems.Add("Known To Be PowerShell Compatible")
        Next
        Items.AddRange(DOS.Select(Function(x) New ListViewItem(x)).ToArray)
        For Each item As ListViewItem In Items
            item.SubItems.Add("Known To Be MS-DOS Compatible")
        Next
        If IsHandleCreated Then
            _searchThread = New Thread(New ThreadStart(AddressOf ThreadProcedure))
            _searching = True
            _searchThread.Start()
        Else
            _deferSearch = True
        End If
    End Sub

    Private Sub FillListWithConsoleApps()
        On Error Resume Next
        Dim IA As IAsyncResult
        Dim IA2 As IAsyncResult
        Dim IA3 As IAsyncResult
        '    Dim ret As String = RunScript("[Environment]::GetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & "Machine" & Qt & ")")
        '   Dim ret2 As String = RunScript("[Environment]::GetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & "Machine" & Qt & ")")

        Dim ret As String = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) 'RunScript("[Environment]::GetEnvironmentVariable(" & Qt & "Path" & Qt & ", " & Qt & "Machine" & Qt & ")")
        Dim ret2 As String = Environment.GetEnvironmentVariable("PATHEXT", EnvironmentVariableTarget.Machine) '"[Environment]::GetEnvironmentVariable(" & Qt & "PATHEXT" & Qt & ", " & Qt & "Machine" & Qt & ")")
        Dim EnvPaths() As String = ret.SPT(";")
        Dim EnvPathExts() As String = ret2.SPT(";")
        Dim FI As IO.FileInfo
        Dim Files() As String
        For Each p As String In EnvPaths
            For Each pe As String In EnvPathExts
                'Try
                Files = Directory.GetFiles(p, "*" & pe, SearchOption.TopDirectoryOnly)
                For Each f As String In Files
                    FI = New IO.FileInfo(f)
                    IA = BeginInvoke(_fileListDelegate, New Object() {FI.Name, "Environment File"})
                    IA2 = BeginInvoke(_pathAddDelegate, New Object() {f})
                    IA2 = BeginInvoke(_pathNameAddDelegate, New Object() {FI.Name})
                    clsWinFormUtils2.Delay(0.01)
                Next
                clsWinFormUtils2.Delay(0.01)
                'Catch ex As DirectoryNotFoundException
                'End Try
            Next
            clsWinFormUtils2.Delay(0.01)
        Next
    End Sub

    Private Sub Search()
        FillListWithConsoleApps()
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
    End Sub

    Private Sub ThreadProcedure()
        Try
            Search()
        Finally
            _searching = False
            BeginInvoke(_onSearchComplete, New Object() {Me, EventArgs.Empty})
        End Try
    End Sub

    Private Sub clsConsoleDetective_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Columns.Count > 0 Then
            Columns.Item(0).Width = Width / Columns.Count
            Columns.Item(1).Width = Width / Columns.Count
        End If
    End Sub

End Class

Public NotInheritable Class clsWinFormUtils2

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