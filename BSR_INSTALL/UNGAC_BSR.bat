@ECHO OFF
color 0A
setlocal EnableDelayedExpansion
NET FILE 1>NUL 2>NUL
if '%errorlevel%' == '0' ( goto START ) else ( goto getPrivileges ) 

:getPrivileges
if '%1'=='ELEV' ( goto START )

set "batchPath=%~f0"
set "batchArgs=ELEV"

::Add quotes to the batch path, if needed
set "script=%0"
set script=%script:"=%
IF '%0'=='!script!' ( GOTO PathQuotesDone )
    set "batchPath=""%batchPath%"""
:PathQuotesDone

::Add quotes to the arguments, if needed.
:ArgLoop
IF '%1'=='' ( GOTO EndArgLoop ) else ( GOTO AddArg )
    :AddArg
    set "arg=%1"
    set arg=%arg:"=%
    IF '%1'=='!arg!' ( GOTO NoQuotes )
        set "batchArgs=%batchArgs% "%1""
        GOTO QuotesDone
        :NoQuotes
        set "batchArgs=%batchArgs% %1"
    :QuotesDone
    shift
    GOTO ArgLoop
:EndArgLoop

::Create and run the vb script to elevate the batch file
ECHO Set UAC = CreateObject^("Shell.Application"^) > "%temp%\OEgetPrivileges.vbs"
ECHO UAC.ShellExecute "cmd", "/c ""!batchPath! !batchArgs!""", "", "runas", 1 >> "%temp%\OEgetPrivileges.vbs"
"%temp%\OEgetPrivileges.vbs" 
exit /B

:START
::Remove the elevation tag and set the correct working directory
IF '%1'=='ELEV' ( shift /1 )
color 0A
SETLOCAL EnableExtensions
set EXE=BlackShellRunner.exe
FOR /F %%x IN ('tasklist /NH /FI "IMAGENAME eq %EXE%"') DO IF %%x == %EXE% goto FOUND
echo.
echo %EXE% not Running no need to kill process
echo.
goto FIN
:FOUND
taskkill /f /im BlackShellRunner.exe
echo.
echo %EXE% was running process killed
:FIN

echo.
rmdir %windir%\assembly\GAC_MSIL\LogicNP.ShComboBox /s /q
echo ShComboBox Removed...
echo.
rmdir %windir%\assembly\GAC_MSIL\LogicNP.FileView /s /q
echo FileView Removed...
echo.
rmdir %windir%\assembly\GAC_MSIL\LogicNP.FolderView /s /q
echo FolderView Removed...
echo.
rmdir %windir%\assembly\GAC_MSIL\LogicNP.ShellObjects /s /q
echo ShellObjects Removed...
echo.
pause