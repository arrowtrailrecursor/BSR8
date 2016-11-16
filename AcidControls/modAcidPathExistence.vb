Module modAcidPathExistence

    Public Enum TypeOfPath
        File = 0
        Directory = 1
    End Enum

    Public Function PathExists(ByVal Path As String, ByVal PathType As TypeOfPath) As Boolean
        If Path = String.Empty Then Return False
        If PathType = TypeOfPath.Directory Then
            Dim Dir As New IO.DirectoryInfo(Path)
            If Dir.Exists Then
                Return True
            End If
        Else
            Dim File As New IO.FileInfo(Path)
            If File.Exists Then
                Return True
            End If
        End If
        Return False
    End Function

End Module