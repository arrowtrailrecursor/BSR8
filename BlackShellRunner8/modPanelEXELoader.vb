Module modPanelEXELoader

#Region "API"

#Region "API Functions"

    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

#End Region
#Region "API Constants"

    Public Const WM_SYSCOMMAND As Integer = 274
    Public Const SC_MAXIMIZE As Integer = 61488

#End Region

#End Region

    Public Property RunAsAdmin As Boolean = True

    Function LoadProcessIntoControlHandle(ByVal TheProgramFilePath As String) As Form
        On Error Resume Next
        Dim proc As New Process
        Dim psi As ProcessStartInfo
        With psi
            .CreateNoWindow = True
            .WindowStyle = ProcessWindowStyle.Hidden
            If RunAsAdmin And clsExecuteCommand.isNewerOS Then
                .Verb = "RunAs"
            ElseIf Not clsExecuteCommand.isNewerOS Then
                .Verb = "Open"
            End If
        End With
        With proc
            .PriorityClass = ProcessPriorityClass.AboveNormal
            .PriorityBoostEnabled = True
            .StartInfo = psi
        End With
        proc = Process.Start(TheProgramFilePath)
        Dim TheParentForm As frmPanelLoader = New frmPanelLoader
        With TheParentForm
            Dim TheControl As Panel = .pnlMain
            Dim ip As IntPtr = IntPtr.Zero
            .Text = proc.MainWindowTitle & " BlackCrestSoft Panel Loader"
            Dim s As String = ""
            With proc
                Do Until Not ip = IntPtr.Zero
                    ip = .MainWindowHandle
                    SetParentAndMax(ip, TheControl.Handle)
                    Application.DoEvents()
                Loop
            End With
            .Show()
            .BringToFront()
        End With
    End Function

    Private Sub SetParentAndMax(ByVal ParentHandle As IntPtr, ByVal ControlHandle As IntPtr)
        SetParent(ParentHandle, ControlHandle)
        SendMessage(ParentHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub

End Module