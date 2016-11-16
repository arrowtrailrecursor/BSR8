Imports System.IO

Module modFlash

    Public Function ReturnBSRPath() As String
        On Error Resume Next
        Do
            For Each Drive As DriveInfo In DriveInfo.GetDrives()
                Dim Type As String = Drive.DriveType.ToString
                Dim Label As String = Drive.VolumeLabel.ToString
                Dim Path As String = Drive.Name.ToString
                If Type = "Removable" And Label = "BSR_DRIVE" Or Type = "Removable" And PathExists(Path & "BSR_CFG.INI", TypeOfPath.File) Then
                    Return Path.RSAtE("\")
                End If
            Next
            MessageBox.Show("BlackShellRunner8 Portable Requires A Writable Flash Drive Labeled BSR_DRIVE To Store File Settings." _
                            & vbNewLine & "Rename Your Drive BSR_DRIVE And Click OK To Continue.", _
                            "Path For Settings Not Found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loop
    End Function

    Public Function IsFlashDirectory() As Boolean
        On Error Resume Next
        For Each Drive As DriveInfo In DriveInfo.GetDrives()
            If Drive.IsReady Then
                Dim Label As String = Drive.VolumeLabel.ToString
                Dim Path As String = Drive.Name.ToString
                If Label = "U3 System" And Application.ExecutablePath.ToUpper Like Path.ToUpper & "*" Then
                    If PathExists(Path & "BlackShellRunner.exe", TypeOfPath.File) Then
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function

    Public Function ReturnU3Path() As String
        On Error Resume Next
        For Each Drive As DriveInfo In DriveInfo.GetDrives()
            Dim Label As String = Drive.VolumeLabel.ToString
            Dim Path As String = Drive.Name.ToString
            If Label = "U3 System" And PathExists(Path & "BlackShellRunner.exe", TypeOfPath.File) Then
                Return Path
                Exit Function
            End If
        Next
    End Function

End Module