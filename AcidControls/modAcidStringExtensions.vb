Option Strict On

Module StringExtensions

    Public Qt As String = """"
    Public CL As String = vbCrLf

    'REGULAR EXPRESSION TO FIND BROKEN STRING VARIBLES IN FIND AND REPLACE '''''''''''-> Dim:b:w:b=

    <Extension()> _
    Public Function TRM(ByVal Text As String) As String
        Return Strings.Trim(Text)
    End Function

    <Extension()> _
    Public Function UC(ByVal Text As String) As String
        Return Strings.UCase(Text)
    End Function

    <Extension()> _
    Public Function LC(ByVal Text As String) As String
        Return Strings.LCase(Text)
    End Function

    <Extension()> _
    Public Function RP(ByVal TheTextToReplace As String, ByVal FindThis As String, ByVal ReplaceWithThis As String) As String
        Return Strings.Replace(TheTextToReplace, FindThis, ReplaceWithThis)
    End Function

    <Extension()> _
    Public Function SPT(ByVal Text As String, ByVal SplitWithThis As String) As String()
        Return Strings.Split(Text.ToString, SplitWithThis)
    End Function

    <Extension()> _
    Public Function JN(ByVal TextArray() As String, ByVal JoinWithThis As String) As String
        Return Strings.Join(TextArray, JoinWithThis)
    End Function

    <Extension()> _
    Public Function LN(ByVal Text As String) As Integer
        Return Strings.Len(Text)
    End Function

    <Extension()> _
    Public Function LT(ByVal Text As String, ByVal Amount As Integer) As String
        Return Strings.Left(Text, Amount)
    End Function

    <Extension()> _
    Public Function RT(ByVal Text As String, ByVal Amount As Integer) As String
        Return Strings.Right(Text, Amount)
    End Function

    <Extension()> _
    Public Function RSAtE(ByVal Text As String, ByVal TheLastToRemove As String) As String
        If Text.RT(TheLastToRemove.LN) = TheLastToRemove Then
            Return Text.LT(Text.LN - TheLastToRemove.LN)
        Else
            Return Text
        End If
    End Function

    <Extension()> _
    Public Function RSAtF(ByVal Text As String, ByVal TheFrontToRemove As String) As String
        If Text.LT(TheFrontToRemove.LN) = TheFrontToRemove Then
            Return Text.RT(Text.LN - TheFrontToRemove.LN)
        Else
            Return Text
        End If
    End Function

    <Extension()> _
    Public Function CNT(ByVal Text As String, ByVal WhatContains As String) As Boolean
        Return Text.Contains(WhatContains)
    End Function

End Module