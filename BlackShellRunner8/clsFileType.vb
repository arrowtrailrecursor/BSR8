Imports Microsoft.Win32
Public Class clsFileType
    Public Shared Function GetFileType(ByVal fileExtension As String) As String
        On Error Resume Next
        Dim fileType As String = ""
        'Search all keys under HKEY_CLASSES_ROOT
        For Each subKey As String In Registry.ClassesRoot.GetSubKeyNames()
            If String.IsNullOrEmpty(subKey) Then
                Continue For
            End If
            If subKey.CompareTo(fileExtension) = 0 Then
                'File extension found. Get Default Value
                Dim defaultValue As String = Registry.ClassesRoot.OpenSubKey(subKey).GetValue("").ToString()
                If defaultValue.Length = 0 Then
                    'No File Type specified
                    Exit For
                End If
                If fileType.Length = 0 Then
                    'Get Initial File Type and search for the full File Type Description
                    fileType = defaultValue
                    fileExtension = fileType
                Else
                    'File Type Description found
                    If defaultValue.Length > 0 Then
                        fileType = defaultValue
                    End If
                    Exit For
                End If
            End If
        Next
        Return fileType
    End Function
End Class