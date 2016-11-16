Imports System.Security

<SecuritySafeCritical>
Public Module modAcidAPI

#Region "IntPtr"

    Public ReadOnly HWND_TOPMOST As New IntPtr(-1)
    Public ReadOnly HWND_NOTOPMOST As New IntPtr(-2)

#End Region
#Region "Constants"

    Public Const WM_VSCROLL As Integer = &H115
    Public Const WM_HSCROLL As Integer = &H114
    Public Const SWP_NOSIZE As Integer = &H1
    Public Const WM_CTLCOLORLISTBOX As UInt32 = &H134
    Public Const WM_MOUSEWHEEL As Integer = &H20A
    Public Const GWL_EXSTYLE As Integer = (-20)
    Public Const WS_EX_LAYERED As Integer = &H80000
    Public Const WS_EX_TRANSPARENT As Long = &H20L
    Public Const LWA_ALPHA As Long = &H2L
    Public Const LWA_COLORKEY As Integer = &H1
    Public Const WS_EX_TOOLWINDOW As Integer = &H80
    Public Const WS_EX_NOACTIVATE As Integer = &H8000000
    Public Const WS_EX_TOPMOST As Integer = &H8
    Public Const SWP_NOMOVE As Integer = &H2

#End Region
#Region "Structures"

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)>
    Public Structure SCROLLINFO
        Public cbSize As Integer
        Public fMask As UInteger
        Public nMin As Integer
        Public nMax As Integer
        Public nPage As UInteger
        Public nPos As Integer
        Public nTrackPos As Integer
    End Structure

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Explicit)>
    Public Structure RECT
        <System.Runtime.InteropServices.FieldOffset(0)> Friend Left As Integer
        <System.Runtime.InteropServices.FieldOffset(4)> Friend Top As Integer
        <System.Runtime.InteropServices.FieldOffset(8)> Friend Right As Integer
        <System.Runtime.InteropServices.FieldOffset(12)> Friend Bottom As Integer
    End Structure

#End Region
#Region "API Functions"

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll", SetLastError:=True)>
    Public Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll", SetLastError:=True)>
    Public Function FindWindowEx(hwndParent As IntPtr, hwndChildAfter As IntPtr, lpszClass As String, lpszWindow As String) As IntPtr
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Function SetCursorPos(ByVal X As Integer, ByVal Y As Integer) As Boolean
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("User32.dll", EntryPoint:="GetScrollInfo")>
    Public Function GetScrollInfo(ByVal hwnd As IntPtr, ByVal fnBar As Integer, ByRef lpsi As SCROLLINFO) As Boolean
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Boolean
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Function SetLayeredWindowAttributes(ByVal hwnd As IntPtr, ByVal crKey As UInteger, ByVal bAlpha As Byte, ByVal dwFlags As UInteger) As Boolean
    End Function

    <SecuritySafeCritical>
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SendMessageA")>
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As Point) As Boolean
    End Function

    <SecuritySafeCritical>
    Declare Function GetWindowRect Lib "user32" (ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Integer

    <SecuritySafeCritical>
    Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer

    <SecuritySafeCritical>
    Declare Function ShowWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Integer

#End Region

End Module