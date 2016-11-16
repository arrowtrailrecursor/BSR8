Imports Microsoft.Win32

Module modRegShellExAndAssociation

    Sub AssociateSTPExtension()
        If INIReadBoolean(INISettingsPath, "Settings", "NeverAssociateSTPFiles") Then Return
        RemoveDefaultIconAssociation()
        Registry.ClassesRoot.CreateSubKey(".stp").SetValue("", "STP", RegistryValueKind.String)
        Registry.ClassesRoot.CreateSubKey("STP\shell\open\command").SetValue("", """" & Application.ExecutablePath & """ ""%1"" ", RegistryValueKind.String)
        Registry.ClassesRoot.CreateSubKey("STP\DefaultIcon").SetValue("", """" & Application.ExecutablePath & """, -1", RegistryValueKind.String)
    End Sub

    Sub RemoveDefaultIconAssociation()
        Registry.ClassesRoot.DeleteSubKey(".stp", False)
        Registry.ClassesRoot.DeleteSubKey("STP\DefaultIcon", False)
        Registry.ClassesRoot.DeleteSubKey("STP\shell\open\command", False)
        Registry.ClassesRoot.DeleteSubKey("STP\shell\open", False)
        Registry.ClassesRoot.DeleteSubKey("STP\shell", False)
        Registry.ClassesRoot.DeleteSubKey("STP", False)
    End Sub

    Sub MakeShellExtension(ByVal StartingKey As String, Optional ByVal TheShellExtensionText As String = "Run With BlackShellRunner")
        Dim regmenu As RegistryKey = Nothing
        Dim regicon As RegistryKey = Nothing
        Dim regcmd As RegistryKey = Nothing
        Dim MenuNameKey As String = StartingKey & "\shell\" & TheShellExtensionText
        Dim TheCommandKey As String = StartingKey & "\shell\" & TheShellExtensionText & "\command"
        Dim TheIconPath As String = """" & Application.ExecutablePath & """, -1"
        Dim TheCommandPath = """" & Application.ExecutablePath & """ ""%1"""
        Try
            regmenu = Registry.ClassesRoot.CreateSubKey(MenuNameKey)
            If Not regmenu Is Nothing Then
                regmenu.SetValue("", TheShellExtensionText)
                regmenu.SetValue("Icon", TheIconPath)
            End If
            regcmd = Registry.ClassesRoot.CreateSubKey(TheCommandKey)
            If Not regcmd Is Nothing Then
                regcmd.SetValue("", TheCommandPath)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not regmenu Is Nothing Then
                regmenu.Close()
            End If
            If Not regcmd Is Nothing Then
                regcmd.Close()
            End If
        End Try
    End Sub

    Sub RemoveShellExtension(ByVal StartingKey As String, Optional ByVal TheShellExtensionText As String = "Run With BlackShellRunner")
        Dim MenuNameKey As String = StartingKey & "\shell\" & TheShellExtensionText
        Dim TheCommandKey As String = StartingKey & "\shell\" & TheShellExtensionText
        Try
            Dim reg As RegistryKey = Registry.ClassesRoot.OpenSubKey(TheCommandKey)
            If Not reg Is Nothing Then
                reg.Close()
                Registry.ClassesRoot.DeleteSubKey(TheCommandKey, False)
            End If
            reg = Registry.ClassesRoot.OpenSubKey(MenuNameKey, False)
            If Not reg Is Nothing Then
                reg.Close()
                Registry.ClassesRoot.DeleteSubKey(MenuNameKey, False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Module