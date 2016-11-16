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
SETLOCAL EnableExtensions
set EXE=BlackShellRunner.exe
echo.
FOR /F %%x IN ('tasklist /NH /FI "IMAGENAME eq %EXE%"') DO IF %%x == %EXE% goto FOUND
echo %EXE% not Running no need to kill process
echo.
goto FIN
:FOUND
taskkill /f /im BlackShellRunner.exe
echo %EXE% was running process killed
echo.
:FIN
color 0A
cd /d %~dp0\LogicNP
::32-bit
::set _programFiles=%ProgramFiles%
::64-bit
set _programFiles=%ProgramFiles(x86)%

set AppDir=%_programFiles%\LogicNP Software\Shell MegaPack.Net 2012

::set ShComboDir=%AppDir%\ShComboBox.Net Control 2012
::set ShFileViewDir=%AppDir%\FileView.Net Control 2012
::set ShFolderViewDir=%AppDir%\FolderView.Net Control 2012
::set ShObjectsDir=%AppDir%\ShellObjects.Net 2012

set ShComboGACDir=%windir%\assembly\GAC_MSIL\LogicNP.ShComboBox\13.0.0.0__ff6f27194af4af75
set ShFileViewGACDir=%windir%\assembly\GAC_MSIL\LogicNP.FileView\13.0.0.0__ff6f27194af4af75
set ShFolderViewGACDir=%windir%\assembly\GAC_MSIL\LogicNP.FolderView\13.0.0.0__ff6f27194af4af75
set ShObjectsGACDir=%windir%\assembly\GAC_MSIL\LogicNP.ShellObjects\13.0.0.0__ff6f27194af4af75

::del /Q "%ShComboDir%\Samples\*.dll"
::del /Q "%ShFileViewDir%\Samples\*.dll"
::del /Q "%ShFolderViewDir%\Samples\*.dll"
::del /Q "%ShObjectsDir%\Samples\*.dll"

if exist %ShComboGACDir% (
  del /Q %ShComboGACDir%\*.*
) else (
  mkdir %ShComboGACDir%
)
echo copying ShComboBox
copy LogicNP.ShComboBox.dll %ShComboGACDir%
::copy LogicNP.ShComboBox.dll "%ShComboDir%"
if exist %ShFileViewGACDir% (
  del /Q %ShFileViewGACDir%\*.*
) else (
  mkdir %ShFileViewGACDir%
)
echo.
echo copying Fileview
copy LogicNP.FileView.dll %ShFileViewGACDir%
::copy LogicNP.FileView.dll "%ShFileViewDir%"
if exist %ShFolderViewGACDir% (
  del /Q %ShFolderViewGACDir%\*.*
) else (
  mkdir %ShFolderViewGACDir%
)
echo.
echo copying FolderView
copy LogicNP.FolderView.dll %ShFolderViewGACDir%
::copy LogicNP.FolderView.dll "%ShFolderViewDir%"
if exist %ShObjectsGACDir% (
  del /Q %ShObjectsGACDir%\*.*
) else (
  mkdir %ShObjectsGACDir%
)
echo.
echo copying ShellObjects
copy LogicNP.ShellObjects.dll %ShObjectsGACDir%
::copy LogicNP.ShellObjects.dll "%ShObjectsDir%"
echo.
echo.
echo Press a key to run BlackShellRunner setup.exe
echo.
cd /d %~dp0
echo %~dp0setup.exe
echo.
setup.exe
pause