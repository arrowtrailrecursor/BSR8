'=====================================================================================
'  clsIcon
'  class to work with icons
'=====================================================================================
'  Created By: Marc Cramer
'  Published Date: 12/31/2002
'  Legal Copyright: Marc Cramer © 12/31/2002
'=====================================================================================
'  Adapted From...
'  Author: spotchannel (spotchannel@hotmail.com)
'  Website: forum post at http://www.devcity.net/forums/topic.asp?tid=7422
'=====================================================================================

Imports System.Runtime.InteropServices

Public Class clsIcon

    '=====================================================================================
    ' Enumerations
    '=====================================================================================
    <Flags()> Protected Enum SHGFI
        SmallIcon = &H1
        LargeIcon = &H0
        Icon = &H100
        DisplayName = &H200
        Typename = &H400
        SysIconIndex = &H4000
        UseFileAttributes = &H10
    End Enum

    Public Enum IconSize
        SmallIcon = 1
        LargeIcon = 0
    End Enum

    '=====================================================================================
    ' Structures
    '=====================================================================================
    <StructLayout(LayoutKind.Sequential)> _
    Protected Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As Integer
        <MarshalAs(UnmanagedType.LPStr, SizeConst:=260)> Public szDisplayName As String
        <MarshalAs(UnmanagedType.LPStr, SizeConst:=80)> Public szTypeName As String

        Public Sub New(ByVal B As Boolean)
            hIcon = IntPtr.Zero
            iIcon = 0
            dwAttributes = 0
            szDisplayName = vbNullString
            szTypeName = vbNullString
        End Sub
    End Structure

    '=====================================================================================
    ' API Calls
    '=====================================================================================
    Protected Declare Auto Function SHGetFileInfo Lib "shell32" (ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, ByVal uFlagsn As SHGFI) As Integer

    '=====================================================================================
    ' Functions and Procedures...
    '=====================================================================================
    Public Shared Function GetDefaultIcon(ByVal Path As String, Optional ByVal IconSize As IconSize = IconSize.SmallIcon, Optional ByVal SaveIconPath As String = "") As Icon
        Try
            Dim info As New SHFILEINFO(True)
            Dim cbSizeInfo As Integer = Marshal.SizeOf(info)
            Dim flags As SHGFI = SHGFI.Icon Or SHGFI.UseFileAttributes
            flags = flags + IconSize
            SHGetFileInfo(Path, 256, info, cbSizeInfo, flags)
            Return Icon.FromHandle(info.hIcon)
            If SaveIconPath <> "" Then
                Dim FileStream As New IO.FileStream(SaveIconPath, IO.FileMode.Create)
                GetDefaultIcon.Save(FileStream)
                FileStream.Close()
            End If
        Catch ex As ArgumentException
            If Not IO.File.Exists("c:\Temp") Then IO.File.Create("c:\Temp")
            Return System.Drawing.Icon.ExtractAssociatedIcon("c:\Temp")
        End Try
    End Function      'GetDefaultIcon(ByVal Path As String, Optional ByVal IconSize As IconSize = IconSize.SmallIcon, Optional ByVal SaveIconPath As String = "") As Icon
    '=====================================================================================
    Public Shared Function ImageToIcon(ByVal SourceImage As Image) As Icon
        ' converts an image into an icon
        Dim TempBitmap As New Bitmap(SourceImage)
        ImageToIcon = Icon.FromHandle(TempBitmap.GetHicon())
        TempBitmap.Dispose()
    End Function      'ImageToIcon(ByVal SourceImage As Image) As Icon
    '=====================================================================================

End Class