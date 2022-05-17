taskkill /f /im easyclimate.exe
tasklist | FIND "EasyClimate.exe"
IF NOT %ERRORLEVEL% == 1 pause
rem copies easysoft framework from local neighborhood svn directory
call CopyEasysoft3ComponentsFrom ..\EasySoft3\bin
echo hallo > bin\MakeResources2CheckResourceDate.txt
rem call MakeEasyClimate.bat
start bin\EasyClimate.exe cleanup > %temp%\Flo.txt
