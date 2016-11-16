Option Strict On
Imports Microsoft.VisualBasic.Strings
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module StringExtensions

    Public Qt As String = """"
    Public CL As String = vbCrLf
    Public KeyForHash As String = ""
    Public SaltForHash() As Byte

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

    <Extension()> _
    Public Function Encrypt(ByVal strText As String, ByVal Key As String) As String
        Dim bykey() As Byte
        Dim InputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
        Dim DES As DESCryptoServiceProvider
        Dim ms As MemoryStream
        Dim cs As CryptoStream
        Try
            bykey = System.Text.Encoding.UTF8.GetBytes(Left(Key, 8))
            InputByteArray = System.Text.Encoding.UTF8.GetBytes(strText)
            DES = New DESCryptoServiceProvider
            ms = New MemoryStream
            cs = New CryptoStream(ms, DES.CreateEncryptor(bykey, SaltForHash), CryptoStreamMode.Write)
            cs.Write(InputByteArray, 0, InputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            Return ""
        End Try
    End Function

    <Extension()>
    Public Function Decrypt(ByVal strText As String, ByVal Key As String) As String
        Dim inputByteArray(strText.Length) As Byte
        Dim DES As DESCryptoServiceProvider
        Dim ms As MemoryStream
        Dim cs As CryptoStream
        Try
            Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Left(Key, 8))
            DES = New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(strText)
            ms = New MemoryStream
            cs = New CryptoStream(ms, DES.CreateDecryptor(byKey, SaltForHash), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Module