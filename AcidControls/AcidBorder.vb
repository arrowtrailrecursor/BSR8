'<-{---------------------------------------------------}->
'<-{-Acid Border William Stanley Davis 2015-}->
'<-{---------------------------------------------------}->
Public Class AcidBorder

    Inherits AcidButton

    Private Sub AcidBorder_Invalidated(sender As Object, e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        SendToBack()
        Dock = DockStyle.Fill
        Text = ""
        SendToBack()
    End Sub
End Class