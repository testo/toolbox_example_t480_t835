pushd ..\easysoft3\Tools\MakeResources2
call CacheResxFiles.bat
popd
pushd Tools\MakeResources2
call CacheResxFiles.bat
popd
call CopyEasysoft3ComponentsToHere.bat

Tools\elevate\elevate -c call "Lib\Testo Shared\_Register_T480_runas_admin.bat"
Tools\elevate\elevate -c "USBDriver\T835_USBSer_Install\setup.exe"