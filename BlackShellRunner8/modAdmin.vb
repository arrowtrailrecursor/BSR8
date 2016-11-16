Module modAdmin
    Public Function IsAdministrator() As Boolean
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
2:          Return True
3:      Else
4:          Return False
5:      End If
        Return False
    End Function
End Module