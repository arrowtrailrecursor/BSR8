MustInherit Class MessageBox

    Public Overloads Shared Function Show(ByVal text As String, Optional ByVal caption As String = "", Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Dim Result As MsgBoxResult
        Dim Message As New CustomMsg
        Result = Message.BSRMsg(caption, text, buttons, icon)
        Return Result
    End Function

End Class

Module Interaction

    Public Function MsgBox(ByVal Prompt As Object, Optional ByVal Buttons As MsgBoxStyle = MsgBoxStyle.OkOnly, Optional ByVal Title As Object = "") As DialogResult
        Dim Result As MsgBoxResult
        Dim Btns As Integer = 0
        Dim Icon As Integer = 0
        For BtnInx As Integer = 0 To 5
            Select Case (CType(Buttons, Integer) - BtnInx)
                Case Is = 0
                    Btns = BtnInx
                    Icon = 64 'Info Circle with i in it if no icon is given in the message style parameter
                    Exit For
                Case Is = 16, 32, 48, 64
                    Btns = BtnInx
                    Icon = (CType(Buttons, Integer) - BtnInx)
                    Exit For
            End Select
        Next
        Dim Message As New CustomMsg
        Result = Message.BSRMsg(Title.ToString, Prompt.ToString, Btns, Icon)
        Return Result
    End Function

End Module