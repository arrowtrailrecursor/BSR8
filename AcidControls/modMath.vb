Public Module modMath

    Public Function IsEven(ByVal TheNumberToTest As Integer) As Boolean
        If (TheNumberToTest And 1) = 1 Then
            Return False
        Else
            Return True
        End If
    End Function

End Module