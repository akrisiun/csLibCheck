@REM  c:\Program Files (x86)\dotnet\bin\System.IO.*
@REM -debug 

set dnx=c:\Program Files (x86)\dotnet\bin

cd bin\
libcheck.exe -nopause -file "%dnx%\System.IO.*.dll" -out ..\Sample\src\dotnet

libcheck.exe -nopause -file "%dnx%\System.Runtime.*.dll" -out ..\Sample\src\dotnet

libcheck.exe -nopause -file "%dnx%\System.Collections.*.dll" -out ..\Sample\src\dotnet

@PAUSE