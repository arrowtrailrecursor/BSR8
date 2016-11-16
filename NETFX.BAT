cd /d %~dp0
REG QUERY "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP" /s|FIND " Version"|FIND "4"||goto NETFX
goto DELFX
:NETFX
echo.
echo Installing Microsoft .Net Framework 4.0.
echo BlackShellRunner will start soon.
start /realtime /wait dotNetFx40_Full_x86_x64.exe /q /noreboot
goto STARTBSR
:DELFX
del /f dotNetFx40_Full_x86_x64.exe