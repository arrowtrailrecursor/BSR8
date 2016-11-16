#Region "Imported_Assemblies"

Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Collections.Specialized
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.CompilerServices

#End Region
#Region "Company_And_Author"

'<<--{{[[<-{[ BlackCrestSoft Encrypted User Configuration Binary Settings Module Made And Written By: William Stanley Davis (2013-2014) ]}->]]}}-->>'

#End Region
Namespace Settings

    Public Module BlackCrestSoftEncryptedBinaryFileSettings

#Region "Private_Code"
#Region "Private_Variables"

#Region "Settings_List"

        Private Settings As New List(Of List(Of Object))

#End Region

#End Region
#Region "Private_Enums"

        Private Enum PathType
            Directory = 0
            File = 1
        End Enum
#End Region
#Region "Private_Subroutines"

        Private Sub MakeSureUserConfigurationFilePropertiesHaveBeenAssigned()
            If Not UserConfigBinaryFilePath Like "?:\*.*" Then
                MessageBox.Show("You Must Specify A User Configuration Binary File Path To Store And Serialize Your Application's Settings! Valid Paths Must Contain At Least One Directory And A File Name With Extension Something Along The Lines Of Settings.UserConfigBinaryFilePath = " & ControlChars.Quote & "C:\MyCustomUserConfigFile.Bin" & ControlChars.Quote & ".", "Invalid User Configuration File Path!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If StringEncryptionPassword = "" Then
                MessageBox.Show("You Must Specify A Password For Encrypting The Strings In Your User Configuration Binary File That Contains The Settings For Your Application! Preferably One That Is Declared With The Access Modifier Protected ReadOnly. If You Are Paranoid.", "User Configuration File DES Encryption Password Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim AmountOfSalt As Integer = StringEncryptionSalt.GetUpperBound(0)
            If StringEncryptionSalt Is Nothing Or Not AmountOfSalt = 7 Then
                MessageBox.Show("You Must Specify A Salt Byte Array Of 8 Bytes For Encrypting The Strings In Your User Configuration Binary File That Contains The Settings For Your Application! Preferably One Declared With The Access Modifier Protected ReadOnly. If You Are Paranoid.", "User Configuration File DES Encryption Salt Byte Array Invalid Or Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End Sub

        Private Sub CreateTheUserConfigurationFileRootFolders()
            SuperCreateDirectory(UserConfigurationFileBaseDirectory(UserConfigBinaryFilePath))
        End Sub

        Private Sub SuperCreateDirectory(ByVal TheDirectoryPathToCreate As String)
            Dim TheDirectoryPath As String = Strings.Trim(TheDirectoryPathToCreate)
            IO.Directory.CreateDirectory(TheDirectoryPath)
        End Sub

        Private Sub LoadSettings()
            Settings.Clear()
            MakeSureUserConfigurationFilePropertiesHaveBeenAssigned()
            CreateTheUserConfigurationFileRootFolders()
            Dim Binary As New BinaryFormatter
            Dim Stream As New FileStream(UserConfigBinaryFilePath, FileMode.OpenOrCreate)
            Try
                Settings = CType(Binary.Deserialize(Stream), List(Of List(Of Object)))
                Stream.Close()
            Catch ex As Exception
                Stream.Close()
            End Try
        End Sub

        Private Sub RemoveOldForWritingNewSetting(ByVal SettingName As String)
            Dim IndexError As Boolean = True
            Dim SubSettings As List(Of Object)
            If Settings.Count > 0 Then
                Do Until Not IndexError
                    For Index As Integer = 0 To Settings.Count - 1
                        Try
                            SubSettings = New List(Of Object)
                            SubSettings = Settings(Index)
                            If CType(SubSettings.Item(0), String).DecryptText(StringEncryptionPassword) = SettingName Then
                                Settings.RemoveAt(Index)
                            End If
                            IndexError = False
                        Catch ex As Exception
                            IndexError = True
                        End Try
                    Next
                Loop
            End If
        End Sub

        Private Sub SaveSettings()
            Dim Binary As New BinaryFormatter
            Dim Stream As New FileStream(UserConfigBinaryFilePath, FileMode.Open)
            Try
                Binary.Serialize(Stream, Settings)
                Stream.Close()
            Catch ex As Exception
                Stream.Close()
            End Try
        End Sub

        Private Sub AddToSettingsList(ByVal SettingName As String, ByVal SettingValue As Object)
            Dim SettingNameAndValue As New List(Of Object)
            SettingNameAndValue.Add(SettingName.EncryptText(StringEncryptionPassword))
            SettingNameAndValue.Add(SettingValue)
            Settings.Add(SettingNameAndValue)
        End Sub

#End Region
#Region "Private_Functions"

#Region "Regular_Private_Functions"

        Private Function UserConfigurationFileBaseDirectory(ByVal TheConfigFilePath As String) As String
            Dim TheLengthOfTheFilePartOfTheConfigFilePath As Integer = Strings.Len("\" & Strings.Split(TheConfigFilePath, "\").Last)
            Dim TheBaseDirectoryPathOfTheConfigFilePath As String = Strings.Left(TheConfigFilePath, Strings.Len(TheConfigFilePath) - TheLengthOfTheFilePartOfTheConfigFilePath)
            Return TheBaseDirectoryPathOfTheConfigFilePath
        End Function

        Private Function ThePathExists(ByVal Path As String, ByVal PathType As PathType) As Boolean
            Dim ItExists As Boolean = False
            If PathType = PathType.Directory Then
                Dim Dir As New IO.DirectoryInfo(Path)
                If Dir.Exists Then
                    ItExists = True
                End If
            ElseIf PathType = PathType.File Then
                Dim File As New IO.FileInfo(Path)
                If File.Exists Then
                    ItExists = True
                End If
            End If
            Return ItExists
        End Function

        Private Function TheSettingExists(ByVal SettingName As String) As Boolean
            LoadSettings()
            Dim IndexError As Boolean = True
            Dim SubSettings As List(Of Object)
            If Settings.Count > 0 Then
                Do Until Not IndexError
                    For Index As Integer = 0 To Settings.Count - 1
                        Try
                            SubSettings = New List(Of Object)
                            SubSettings = Settings(Index)
                            If CType(SubSettings.Item(0), String).DecryptText(StringEncryptionPassword) = SettingName Then
                                Return True
                            End If
                            IndexError = False
                        Catch ex As Exception
                            IndexError = True
                        End Try
                    Next
                Loop
            End If
            Return False
        End Function

        Private Function GetSetting(ByVal SettingName As String) As Object
            Dim IndexError As Boolean = True
            Dim SubSettings As List(Of Object)
            Do Until Not IndexError
                For Index As Integer = 0 To Settings.Count - 1
                    Try
                        SubSettings = New List(Of Object)
                        SubSettings = Settings(Index)
                        If CType(SubSettings.Item(0), String).DecryptText(StringEncryptionPassword) = SettingName Then
                            Return CType(SubSettings.Item(1), Object)
                        End If
                        IndexError = False
                    Catch ex As Exception
                        IndexError = True
                    End Try
                Next
            Loop
            Return Nothing
        End Function

        Private Function EncryptIfNeeded(ByVal Value As Object) As Object
            Try
                If Value.GetType() Is GetType(String) Then
                    Value = Value.ToString.EncryptText(StringEncryptionPassword)
                End If
                If Value.GetType Is GetType(StringCollection) Then
                    Dim EncryptedCollection As New StringCollection
                    EncryptedCollection.Clear()
                    Dim RotatedPassword As String = StringEncryptionPassword
                    For Each Item As String In Value
                        RotatedPassword = Strings.Right(RotatedPassword, 1) & Strings.Left(RotatedPassword, (Strings.Len(RotatedPassword) - 1))
                        EncryptedCollection.Add(Item.EncryptText(RotatedPassword))
                    Next
                    Value = EncryptedCollection
                End If
                Return Value
            Catch ex As NullReferenceException
            End Try
            Return Value
        End Function

        Private Function DecryptIfNeeded(ByVal Value As Object) As Object
            If Not Value Is Nothing Then
                If Value.GetType() Is GetType(String) Then
                    Value = Value.ToString.DecryptText(StringEncryptionPassword)
                End If
                If Value.GetType Is GetType(StringCollection) Then
                    Dim DecryptedCollection As New StringCollection
                    DecryptedCollection.Clear()
                    Dim RotatedPassword As String = StringEncryptionPassword
                    For Each Item As String In Value
                        RotatedPassword = Strings.Right(RotatedPassword, 1) & Strings.Left(RotatedPassword, (Strings.Len(RotatedPassword) - 1))
                        DecryptedCollection.Add(Item.DecryptText(RotatedPassword))
                    Next
                    Value = DecryptedCollection
                End If
            End If
            Return Value
        End Function

#End Region

#Region "Private_Extension_Method_Functions"

        <Extension()> _
        Private Function RemoveStringAtEndOfText(ByVal Text As String, ByVal TheLastToRemove As String) As String
            If Strings.Right(Text, (Strings.Len(TheLastToRemove))) = TheLastToRemove Then
                Return Strings.Left(Text, Strings.Len(Text) - Strings.Len(TheLastToRemove))
            Else
                Return Text
            End If
        End Function

        <Extension()> _
        Private Function EncryptText(ByVal Text As String, ByVal Key As String) As String
            If Text Is Nothing Then Return ""
            Try
                Dim ByteKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Left(Key, 8))
                Dim InputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(Text)
                Dim DES As New DESCryptoServiceProvider
                Dim MemStream As New MemoryStream
                Dim CryptStream As New CryptoStream(MemStream, DES.CreateEncryptor(ByteKey, StringEncryptionSalt), CryptoStreamMode.Write)
                CryptStream.Write(InputByteArray, 0, InputByteArray.Length)
                CryptStream.FlushFinalBlock()
                Return Convert.ToBase64String(MemStream.ToArray())
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Encrypting User Config Setting Text!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return ""
            End Try
        End Function

        <Extension()> _
        Private Function DecryptText(ByVal Text As String, ByVal Key As String) As String
            Try
                Dim ByteKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Left(Key, 8))
                Dim InputByteArray(Text.Length) As Byte
                InputByteArray = Convert.FromBase64String(Text)
                Dim DES As New DESCryptoServiceProvider
                Dim MemStream As New MemoryStream
                Dim CryptStream As New CryptoStream(MemStream, DES.CreateDecryptor(ByteKey, StringEncryptionSalt), CryptoStreamMode.Write)
                CryptStream.Write(InputByteArray, 0, InputByteArray.Length)
                CryptStream.FlushFinalBlock()
                Dim Encoding As System.Text.Encoding = System.Text.Encoding.UTF8
                Return Encoding.GetString(MemStream.ToArray())
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Decrypting User Config Setting Text!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return ""
            End Try
        End Function

#End Region

#End Region
#End Region

#Region "Public_Code"
#Region "Public_Properties"

#Region "Config_File_Path"

        Public Property UserConfigBinaryFilePath As String

#End Region

#Region "Text_DES_Encryption"

#Region "Pass_Phrase_String"

        Public Property StringEncryptionPassword As String = ""

#End Region

#Region "8_Byte_Salt_Array"

        Public Property StringEncryptionSalt As Byte()

#End Region

#End Region

#End Region
#Region "Public_Subroutines"

        Public Sub DeleteAllSettings()
            Settings.Clear()
            IO.File.Delete(UserConfigBinaryFilePath)
        End Sub

        <Extension()> _
        Public Sub MakeDefaultSetting(ByVal SettingName As String, ByVal SettingValue As Object)
            If Not TheSettingExists(SettingName) Then
                AddToSettingsList(SettingName, EncryptIfNeeded(SettingValue))
                SaveSettings()
            End If
        End Sub

        <Extension()> _
        Public Sub MakeSetting(ByVal SettingName As String, ByVal SettingValue As Object)
            If TheSettingExists(SettingName) Then
                RemoveOldForWritingNewSetting(SettingName)
            End If
            AddToSettingsList(SettingName, EncryptIfNeeded(SettingValue))
            SaveSettings()
        End Sub

#End Region
#Region "Public_Functions"

        <Extension()> _
        Public Function RetrieveSetting(ByVal SettingName As String) As Object
            Dim ReturnValue As Object = Nothing
            If TheSettingExists(SettingName) Then
                ReturnValue = GetSetting(SettingName)
            End If
            Return DecryptIfNeeded(ReturnValue)
        End Function

#End Region
#End Region

    End Module

End Namespace