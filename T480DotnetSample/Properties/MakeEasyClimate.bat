cd > %temp%\currentdir.txt
set /p easysoftdir= < %temp%\currentdir.txt

cd %easysoftdir%\Tools\CollabNetSVN
call %easysoftdir%\Tools\CollabNetSVN\setsvnrevision.bat %easysoftdir%
cd %easysoftdir%

rem needed by NextBuild, but better created her than checked in
md CDRelease\easyEmission
md CDRelease\easyheat
md CDRelease\EasyKool
md CDRelease\EMon



 

rem hack introduced by using product.xml as external (imho worth it)
rem those files are not used, but currently required by nextbuild.exe
copy %easysoftdir%\wix\installeasysoft\easyclimate_org.wxi %easysoftdir%\wix\installeasysoft\easyemission_org.wxi
copy %easysoftdir%\wix\installeasysoft\easyclimate_org.wxi %easysoftdir%\wix\installeasysoft\easyheat_org.wxi
copy %easysoftdir%\wix\installeasysoft\easyclimate_org.wxi %easysoftdir%\wix\installeasysoft\easykool_org.wxi
copy %easysoftdir%\wix\installeasysoft\easyclimate_org.wxi %easysoftdir%\wix\installeasysoft\emon_org.wxi

del %easysoftdir%\bin\*.exe
del %easysoftdir%\bin\*.pdb
del %easysoftdir%\bin\*.dll
del %easysoftdir%\bin\de\*.dll
del %easysoftdir%\bin\*.xml

echo deleting all dll files in all obj folders (usually /Debug/obj and /Release/obj)
FOR /F "delims=# " %%o in ('dir obj /ad /s /b') do (del %%o\*.dll /s )

echo deleting all versions AssemblyVersion.cs in case someone added a copy instead a link
del /s AssemblyVersion.cs
NextBuild
IF NOT exist .\AssemblyVersion.cs (pause
EXIT %errorlevel%)

attrib -R %easysoftdir%\Daten\*.* /s

call %easysoftdir%\CopyEasysoft
call %easysoftdir%\CopyRuntime

cd %easysoftdir%
md CDRelease
md EasyClimate
NextBuild
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild EasyClimate.sln /p:Configuration=Release /p:TrackFileAccess=false /verbosity:minimal

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild t835dev.UnitTest\T835.UnitTest.sln /p:Configuration=Release /p:TrackFileAccess=false 
@echo off
IF NOT %errorlevel% == 0 (echo.
echo error occured, please check log messages above
pause
EXIT /b %errorlevel%)