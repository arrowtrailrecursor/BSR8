Option Strict On

Imports System.Collections.Specialized

Module modINIAccess

#Region "API Calls"
    ' standard API declarations for INI access
    ' changing only "As Long" to "As Int32" (As Integer would work also)
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
#End Region
    Dim SectionComments As New StringCollection
    Public INICommentDelimiter As String = "{i\\i//i}"

    Public Function INIReadBoolean(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) As Boolean
        Dim RetBool As String = ""
        If PathExists(INIPath, TypeOfPath.File) Then
            RetBool = INIRead(INIPath, SectionName, KeyName).TRM
            If Not RetBool = "" And RetBool.UC = "FALSE" _
                Or Not RetBool = "" And RetBool.UC = "TRUE" _
                Or Not RetBool = "" And RetBool.UC = "0" _
                Or Not RetBool = "" And RetBool.UC = "1" Then
                Return Convert.ToBoolean(RetBool)
            End If
        End If
        Return False
    End Function

    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal DefaultValue As String, Optional ByVal SurroundWithString As String = ControlChars.Quote) As String
        ' primary version of call gets single value given all parameters
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024) ' allocate some room
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
        sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            Return sData.Substring(0, n).RSAtF(SurroundWithString).RSAtE(SurroundWithString)
        Else
            Return ""
        End If
    End Function

#Region "INIRead Overloads"

    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) As String
        ' overload 1 assumes zero-length default
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function

#End Region

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal TheValue As String, Optional ByVal SurroundWithString As String = ControlChars.Quote)
        Call WritePrivateProfileString(SectionName, KeyName, SurroundWithString & TheValue & SurroundWithString, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) ' delete single line from section
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub

#Region "Added By: William Davis For BSR"

    'The following three subs was added By William Davis It Adds Comments
    Public Sub INICommentSection(ByVal INIPath As String, ByVal Section As String, ByVal Comment As String)
        SectionComments.Add(Section & INICommentDelimiter & Comment)
        INIAddAllSectionComments(INIPath)
    End Sub

    Private Sub INIAddAllSectionComments(ByVal INIPath As String)
        'This Just Cleans Her Up And Seperates The Sections
        Dim Str As String = IO.File.ReadAllText(INIPath)
        Dim SectionComment() As String
        For Each Comment As String In SectionComments
            'INDEX 0 SECTION
            'INDEX 1 COMMENT
            SectionComment = Comment.SPT(INICommentDelimiter)
            If Not Str.CNT(SectionComment(1)) Then
                If Not Str.CNT(SectionComment(1) & vbNewLine & "[" & SectionComment(0) & "]") Then
                    Str = Str.RP("[" & SectionComment(0) & "]", SectionComment(1) & vbNewLine & "[" & SectionComment(0) & "]")
                End If
            End If
        Next
        IO.File.WriteAllText(INIPath, Str)
    End Sub

    Public Sub INIClearCommentedSections()
        SectionComments.Clear()
    End Sub

#End Region

End Module