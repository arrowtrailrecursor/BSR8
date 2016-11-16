Module modAmountInString
    Function AmountInString(ByVal Text As String, ByVal FindString As String) As Integer
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim amount As Integer = 0
        Do
            x = y + 1
            z = z + 1
            y = InStr(x, Text, FindString)
        Loop Until (y = 0)
        amount = z - 1
        AmountInString = amount
    End Function
End Module