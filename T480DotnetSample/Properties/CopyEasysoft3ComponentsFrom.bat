rem copies testo framework from given parameter %1 
@echo off
if "%1"=="" (echo Missing parameter basedir
pause
exit 1)
@echo on
mkdir bin
mkdir bin\modules
set BASEDIR=%1
set DESTDIR=.\Lib\TestoEasysoft
mkdir .\Lib
mkdir %DESTDIR%
mkdir %DESTDIR%\modules
copy /D /Y %BASEDIR%\Testo.*.dll %DESTDIR%\
copy /D /y ..\EasySoft3\bin\Testo.*.pdb %DESTDIR%\
copy /D /Y ..\EasySoft3\bin\mmgrw32.dll %DESTDIR%\
copy /D /y ..\EasySoft3\bin\mmgrw32.pdb %DESTDIR%\
copy /D /Y %BASEDIR%\TestoControlLibrary.dll %DESTDIR%\
copy /D /y %BASEDIR%\TestoControlLibrary.pdb %DESTDIR%\
copy /D /Y %BASEDIR%\TestoControlLibrary.dll .\bin\
copy /D /y %BASEDIR%\TestoControlLibrary.pdb .\bin\
copy /D /Y %DESTDIR%\Testo.*.dll .\bin\
copy /D /y %DESTDIR%\Testo.*.pdb .\bin\
del /S /F %DESTDIR%\*.UnitTest.dll
del /S /F .\bin\*.UnitTest.dll
del /S /F %DESTDIR%\*.UnitTests.dll
del /S /F .\bin\*.UnitTests.dll
del /S /F %DESTDIR%\*.UnitTest.pdb
del /S /F .\bin\*.UnitTest.pdb
del /S /F %DESTDIR%\*.UnitTests.pdb
del /S /F .\bin\*.UnitTests.pdb
copy /D /Y %BASEDIR%\Modules\*.dll %DESTDIR%\Modules\
copy /D /y %BASEDIR%\Modules\*.pdb %DESTDIR%\Modules\
copy /D /Y .\lib\TestoEasySoft\Modules\Testo.*.dll .\bin\Modules\
copy /D /y .\lib\TestoEasySoft\Modules\Testo.*.pdb .\bin\Modules\
copy /D /Y %BASEDIR%\EasyClimate.exe .\bin\
copy /D /Y %BASEDIR%\EasyClimate.exe %DESTDIR%\
copy /D /Y %BASEDIR%\EasyClimate.exe.config %DESTDIR%\
copy /D /Y %BASEDIR%\EasySoft3.pdb %DESTDIR%\EasyClimate.pdb
copy /D /Y %BASEDIR%\EasyClimate.pdb .\bin\
copy /D /Y %BASEDIR%\EasyClimate.exe.config .\bin\
rem copy /D /Y %BASEDIR%\EasyClimate.exe.config %DESTDIR%

