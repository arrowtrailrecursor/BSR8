﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Resources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BSR.Resources", GetType(Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Byte[].
    '''</summary>
    Friend Shared ReadOnly Property BSR_PIC() As Byte()
        Get
            Dim obj As Object = ResourceManager.GetObject("BSR_PIC", resourceCulture)
            Return CType(obj,Byte())
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
    '''</summary>
    Friend Shared ReadOnly Property BSRbtnClose() As System.IO.UnmanagedMemoryStream
        Get
            Return ResourceManager.GetStream("BSRbtnClose", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
    '''</summary>
    Friend Shared ReadOnly Property BSRbtnHideShow() As System.IO.UnmanagedMemoryStream
        Get
            Return ResourceManager.GetStream("BSRbtnHideShow", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
    '''</summary>
    Friend Shared ReadOnly Property BSRbtnSel() As System.IO.UnmanagedMemoryStream
        Get
            Return ResourceManager.GetStream("BSRbtnSel", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
    '''</summary>
    Friend Shared ReadOnly Property BSRError() As System.IO.UnmanagedMemoryStream
        Get
            Return ResourceManager.GetStream("BSRError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
    '''</summary>
    Friend Shared ReadOnly Property BSRInfo() As System.IO.UnmanagedMemoryStream
        Get
            Return ResourceManager.GetStream("BSRInfo", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Set WshShell = CreateObject(&quot;WScript.Shell&quot;) 
    '''WshShell.Run chr(34) &amp; &quot;BSRPath&quot; &amp; Chr(34), 0 
    '''Set WshShell = Nothing.
    '''</summary>
    Friend Shared ReadOnly Property BSRVBS() As String
        Get
            Return ResourceManager.GetString("BSRVBS", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
    '''</summary>
    Friend Shared ReadOnly Property CUR() As System.Drawing.Icon
        Get
            Dim obj As Object = ResourceManager.GetObject("CUR", resourceCulture)
            Return CType(obj,System.Drawing.Icon)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
    '''</summary>
    Friend Shared ReadOnly Property EXE() As System.Drawing.Icon
        Get
            Dim obj As Object = ResourceManager.GetObject("EXE", resourceCulture)
            Return CType(obj,System.Drawing.Icon)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
    '''</summary>
    Friend Shared ReadOnly Property ICO() As System.Drawing.Icon
        Get
            Dim obj As Object = ResourceManager.GetObject("ICO", resourceCulture)
            Return CType(obj,System.Drawing.Icon)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
    '''</summary>
    Friend Shared ReadOnly Property LNK() As System.Drawing.Icon
        Get
            Dim obj As Object = ResourceManager.GetObject("LNK", resourceCulture)
            Return CType(obj,System.Drawing.Icon)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to ASSOC
    '''ATTRIB
    '''BREAK
    '''BCDEDIT
    '''CACLS
    '''CALL
    '''CD
    '''CHCP
    '''CHDIR
    '''CHKDSK
    '''CHKNTFS
    '''CLS
    '''CMD
    '''COLOR
    '''COMP
    '''COMPACT
    '''CONVERT
    '''COPY
    '''DATE
    '''DEL
    '''DIR
    '''DISKCOMP
    '''DISKCOPY
    '''DISKPART
    '''DOSKEY
    '''DRIVERQUERY
    '''ECHO
    '''ENDLOCAL
    '''ERASE
    '''EXIT
    '''FC
    '''FIND
    '''FINDSTR
    '''FOR
    '''FORMAT
    '''FSUTIL
    '''FTYPE
    '''GOTO
    '''GPRESULT
    '''GRAFTABL
    '''HELP
    '''ICACLS
    '''IF
    '''LABEL
    '''MD
    '''MKDIR
    '''MKLINK
    '''MODE
    '''MORE
    '''MOVE
    '''OPENFILES
    '''PATH
    '''PAUSE
    '''POPD
    '''PRINT
    '''PROMPT
    '''PUSHD
    '''RD
    '''RECOVER
    '''REM
    '''REN
    '''RENAME
    '''REPLACE
    '''RMDIR
    '''ROBOCOPY
    '''SET
    '''SETLOCAL
    '''SC
    '''SCHTASKS
    '''SHIFT
    '''SHUTDOWN
    '''S [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property MSDOSCmds() As String
        Get
            Return ResourceManager.GetString("MSDOSCmds", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property PiratesGreen() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("PiratesGreen", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to @ECHO ON
    '''PowerShell.exe -NoProfile -Command &quot;&amp; {Start-Process PowerShell.exe -ArgumentList &apos;-NoProfile -ExecutionPolicy RemoteSigned -File &quot;&quot;%~dpn0.ps1&quot;&quot;&apos; -Verb RunAs}.
    '''</summary>
    Friend Shared ReadOnly Property PowerShellBatch() As String
        Get
            Return ResourceManager.GetString("PowerShellBatch", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to #USE THE FORCE STARWARS
    '''Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
    '''$in = (Get-Variable MyInvocation).Value
    '''$dp = Split-Path $in.MyCommand.Path
    '''cd $dp
    '''Write-Output &quot;Executing Command @BSRCMD@&quot;
    '''powershell -command &quot;@BSRCMD@&quot;|Out-File ./BlackShellRunnerOut.
    '''</summary>
    Friend Shared ReadOnly Property PowerShellScript() As String
        Get
            Return ResourceManager.GetString("PowerShellScript", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to %
    '''?
    '''A:
    '''ac
    '''Add-Computer
    '''Add-Content
    '''Add-History
    '''Add-Member
    '''Add-PSSnapin
    '''Add-Type
    '''asnp
    '''B:
    '''C:
    '''cat
    '''cd
    '''cd..
    '''cd\
    '''chdir
    '''Checkpoint-Computer
    '''clc
    '''clear
    '''Clear-Content
    '''Clear-EventLog
    '''Clear-History
    '''Clear-Host
    '''Clear-Item
    '''Clear-ItemProperty
    '''Clear-Variable
    '''clhy
    '''cli
    '''clp
    '''cls
    '''clv
    '''compare
    '''Compare-Object
    '''Complete-Transaction
    '''Connect-WSMan
    '''ConvertFrom-Csv
    '''ConvertFrom-SecureString
    '''ConvertFrom-StringData
    '''Convert-Path
    '''ConvertTo-Csv
    '''ConvertTo-Html
    '''ConvertTo-SecureString
    '''ConvertTo-Xml
    '''cop [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property PSCmds() As String
        Get
            Return ResourceManager.GetString("PSCmds", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Byte[].
    '''</summary>
    Friend Shared ReadOnly Property Roulette_Dares() As Byte()
        Get
            Dim obj As Object = ResourceManager.GetObject("Roulette_Dares", resourceCulture)
            Return CType(obj,Byte())
        End Get
    End Property
End Class
