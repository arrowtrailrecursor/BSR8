Module modReturnValueTmr
    Sub ReturnValueTimer(ByVal Tmr As Object, Optional ByVal interval As Single = 2000)
        Tmr.Interval = 2000
        Tmr.Enabled = True
    End Sub
End Module