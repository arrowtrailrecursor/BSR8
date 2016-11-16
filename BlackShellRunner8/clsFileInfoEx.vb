Public Class clsFileInfoEx

    Public FileInfo As System.IO.FileInfo = Nothing

    Public Sub New(ByVal Path As String)
        FileInfo = New System.IO.FileInfo(Path)
    End Sub

    Public Overrides Function ToString() As String
        Return FileInfo.Name
    End Function

End Class