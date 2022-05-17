md %easysoftdir%\bin
md %easysoftdir%\bin\runtime
md %easysoftdir%\bin\runtime\Systecs.Common.Application
md %easysoftdir%\bin\runtime\Systecs.Common.Application.Docking
md %easysoftdir%\bin\runtime\Systecs.Common.Application.Ribbon
md %easysoftdir%\bin\runtime\Systecs.Common.Database
md %easysoftdir%\bin\runtime\Systecs.Framework
md %easysoftdir%\bin\runtime\WPfSupport
md %easysoftdir%\bin\runtime\Infragistics

copy %easysoftdir%\lib\Systecs\systecs.Common\Systecs.Common.Application\systecs.Common.Application.* %easysoftdir%\bin\runtime\Systecs.Common.Application
copy %easysoftdir%\lib\Systecs\systecs.Common\Systecs.Common.Application.Docking\systecs.Common.Application.Docking.* %easysoftdir%\bin\runtime\Systecs.Common.Application.Docking
copy %easysoftdir%\lib\Systecs\systecs.Common\Systecs.Common.Application.Ribbon\systecs.Common.Application.Ribbon.* %easysoftdir%\bin\runtime\Systecs.Common.Application.Ribbon
copy %easysoftdir%\lib\Systecs\systecs.Common\Systecs.Common.Database\Systecs.Common.Database.* %easysoftdir%\bin\runtime\Systecs.Common.Database
copy %easysoftdir%\lib\Systecs\systecs.Framework\Systecs.Framework.* %easysoftdir%\bin\runtime\Systecs.Framework
copy %easysoftdir%\lib\Systecs\HelperFiles\*.* %easysoftdir%\bin\runtime
copy %easysoftdir%\lib\CompositeWPF\*.dll %easysoftdir%\bin\runtime\WPFSupport
copy "%easysoftdir%\lib\Support files for Expression Blend\*.dll" %easysoftdir%\bin\runtime\WPFSupport
copy %easysoftdir%\lib\Infragistics.2011.2\*.* %easysoftdir%\bin\runtime\Infragistics
copy %easysoftdir%\lib\Infragistics.Wpf.2011.2\*.* %easysoftdir%\bin\runtime\Infragistics

copy %easysoftdir%\lib\ClosedXml\*.* %easysoftdir%\bin\runtime

copy %easysoftdir%\lib\TestoFramework\*.dll %easysoftdir%\bin\
copy %easysoftdir%\lib\TestoFramework\*.pdb %easysoftdir%\bin

copy %easysoftdir%\lib\ICSharpCode.SharpZipLib.dll %easysoftdir%\bin

copy %easysoftdir%\lib\C1Chart\*.dll %easysoftdir%\bin\
copy %easysoftdir%\lib\mmgrw32.dll %easysoftdir%\bin\
copy %easysoftdir%\lib\mmgrw32.pdb %easysoftdir%\bin\
copy %easysoftdir%\lib\nvalidate.dll %easysoftdir%\bin\


