Module modPathExistence

    Public Enum TypeOfPath
        File = 0
        Directory = 1
    End Enum

    Public Function PathExists(ByVal FileOrDirPath As String, ByVal FileOrDir As TypeOfPath) As Boolean
        On Error Resume Next
        If FileOrDir = TypeOfPath.Directory Then
            Dim Dir As New IO.DirectoryInfo(FileOrDirPath)
            If Dir.Exists Then
                Return True
            End If
        ElseIf FileOrDir = TypeOfPath.File Then
            Dim File As New IO.FileInfo(FileOrDirPath)
            If File.Exists Then
                Return True
            End If
        End If
        Return False
    End Function

End Module