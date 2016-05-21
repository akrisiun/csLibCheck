@REM c:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.dll
@REM -debug 

set dnx=%~dp0dnx

bin\libcheck.exe -store full corefx-rc2 -full %dnx% -out Sample\src\