Module modShift
    Public Sub ShiftCol(ByVal ShiftObject As Object)
        Dim FC As Color = ShiftObject.ForeColor
        Dim SC As Color = ShiftObject.ShadowColor
        ShiftObject.ForeColor = SC
        ShiftObject.ShadowColor = FC
        If (TypeOf ShiftObject Is AcidControls.AcidButton) Then
            ShiftObject.ShiftForeColor = FC
            ShiftObject.ShiftShadowColor = SC
        End If
    End Sub
End Module