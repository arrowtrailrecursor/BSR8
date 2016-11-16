Imports System.Collections.Specialized

Module modRes
    Function aDOSCmd(ByVal DOSCmd As String) As Boolean
        On Error Resume Next
        Dim cmds() As String = My.Resources.MSDOSCmds.SPT(vbCrLf)
        Dim ub As Integer = cmds.GetUpperBound(0)
        For num As Integer = 0 To ub
            If DOSCmd.UC Like cmds(num).UC & " ?*" Then Return True
        Next
        Return False
    End Function

    Function aPSCmd(ByVal PSCmd As String) As Boolean
        On Error Resume Next
        Dim cmds() As String = My.Resources.PSCmds.SPT(vbCrLf)
        Dim ub As Integer = cmds.GetUpperBound(0)
        For num As Integer = 0 To ub
            If PSCmd.UC Like cmds(num).UC & " ?*" Then Return True
        Next
        Return False
    End Function

    Function aShellCmd(ByVal SCmd As String) As Boolean
        Dim sc As StringCollection = Settings.RetrieveSetting("FilePaths")
        For Each itm As String In sc
            If SCmd.UC Like itm.UC.SPT("\").Last & "*" Then
                If PathExists(itm, TypeOfPath.File) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Function ShellCommandPath(ByVal SCmd As String) As String
        Dim sc As StringCollection = Settings.RetrieveSetting("FilePaths")
        Dim itm As String = ""
        Dim res As String
        For Each itm In sc
            If SCmd.UC Like itm.UC.SPT("\").Last & "*" Then
                If PathExists(itm, TypeOfPath.File) Then
                    Return itm
                End If
            End If
        Next
        Return itm
    End Function

    Function aSpecialFolderCmd(ByVal SFCmd As String) As Boolean
        On Error Resume Next
        Dim AllSFCmds As String = My.Resources.Commands.SpecialDirs.LC
        Dim amount As Integer
        amount = AmountInString(AllSFCmds, Qt & SFCmd.LC & Qt)
        If amount = 1 Or amount = 2 Then
            aSpecialFolderCmd = True
        Else
            aSpecialFolderCmd = False
        End If
    End Function

    Function aControlPanelCmd(ByVal SFCmd As String) As Boolean
        On Error Resume Next
        Dim AllSFCmds As String = BSR.My.Resources.Commands.ControlPanelCmds.LC
        Dim amount As Integer
        amount = AmountInString(AllSFCmds, Qt & SFCmd.LC & Qt)
        If amount = 1 Or amount = 2 Then
            aControlPanelCmd = True
        Else
            aControlPanelCmd = False
        End If
    End Function
End Module