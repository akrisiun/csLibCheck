@REM dnx\*.dll
@REM -debug 

set dnx=%~dp0dnx

cd bin\
libcheck.exe -store full corefx-rc2 -full %dnx% -out ..\Sample\src\