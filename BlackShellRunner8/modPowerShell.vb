'Imports System.Management.Automation
'Imports System.Management.Automation.Runspaces
'Imports System.Text
Imports System.Runtime.InteropServices

Module modPowerShell
    <DllImport("shell32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Public Function ShellExecute(
              ByVal hwnd As IntPtr,
              ByVal Operation As String,
              ByVal FileName As String,
              ByVal Parameters As String,
              ByVal Directory As String,
              ByVal ShowCmd As Integer) As Integer
    End Function

    ' Public MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()
    Public TheErrorText As String = ""
    Public stopped As Boolean = False
    Public Function RunScript(ByVal scriptText As String) As String
        Dim StartingDir As String = TheFlashOrRegularDirectoryPath & "\BSR_PS1"
        My.Computer.FileSystem.CreateDirectory(StartingDir)
        Dim PS1Path As String = StartingDir & "\BSR_PS1.PS1"
        Dim BATPath As String = StartingDir & "\BSR_PS1.BAT"
        Dim PSOPath As String = StartingDir & "\BSR_OUT.DAT"
        TheErrorText = ""
        IO.File.WriteAllText(PS1Path, Resources.PowerShellScript)
        IO.File.WriteAllText(BATPath, Resources.PowerShellBatch)
        Dim batscript As String
        If Not clsExecuteCommand.isNewerOS Then
            batscript = IO.File.ReadAllText(BATPath)
            batscript = batscript.RP(" -Verb RunAs", "")
            IO.File.WriteAllText(BATPath, batscript)
        End If
        Dim script As String = IO.File.ReadAllText(PS1Path)
        script = script.RP("@BSRCMD@", scriptText.RP("""", "`""").RP("'", "`'").RP("``", "`"))
        script = script.RP("BlackShellRunnerOut", PSOPath.SPT("\").Last)
        IO.File.WriteAllText(PS1Path, script)
        ShellExecute(0&, "Open", BATPath, Nothing, Nothing, AppWinStyle.NormalFocus)
        stopped = False
        frmMain.abRn.Text = "Stop"
        Dim ret As String = ""
        Do Until PathExists(PSOPath, TypeOfPath.File) And ret <> "" Or stopped
            Application.DoEvents()
            Try
                ret = IO.File.ReadAllText(PSOPath)
                IO.File.Delete(PS1Path)
                IO.File.Delete(BATPath)
                IO.File.Delete(PSOPath)
                x = 0
                Return ret
            Catch
            End Try
        Loop
        If stopped Then
            IO.File.Delete(PS1Path)
            IO.File.Delete(BATPath)
            IO.File.Delete(PSOPath)
            Return "Stopped By User."
        End If
        Return ret
    End Function

    Sub StopScript()
        stopped = True
        ' Dim StartingDir As String = TheFlashOrRegularDirectoryPath & "\BSR_PS11"
        ' My.Computer.FileSystem.DeleteDirectory(StartingDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        For Each pro As Process In Process.GetProcessesByName("powershell")
            pro.Kill()
        Next
    End Sub
    '  Function RunScript(ByVal scriptText As String) As String
    ' create Powershell runspace
    '     MyRunSpace = RunspaceFactory.CreateRunspace()
    ' open it
    '    MyRunSpace.Open()
    ' create a pipeline and feed it the script text
    'Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()
    '   MyPipeline.Commands.AddScript(scriptText)
    ' add an extra command to transform the script output objects into nicely formatted strings
    '   remove this line To Get the actual objects that the script returns. For example, the script
    ' "Get-Process" returns a collection of System.Diagnostics.Process instances.
    '  MyPipeline.Commands.Add("Out-String")
    ' execute the script
    'Dim MyStringBuilder As New StringBuilder()
    'Try
    'For Each obj As PSObject In MyPipeline.Invoke
    '           MyStringBuilder.AppendLine(obj.ToString())
    'Next
    'Catch ex As Exception
    '       TheErrorText = "Windows PowerShell Error ! > " & ex.Message
    '      MyRunSpace.Close()
    'Return "ERROR"
    'End Try
    ' return the results of the script that has
    ' Now been converted To text
    '   MyRunSpace.Close()
    'Return MyStringBuilder.ToString()

    '    End Function

End Module