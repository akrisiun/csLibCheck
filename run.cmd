@REM             -store full debug -split 4  -full c:\bin -out net47
@REM bin\libcheck.exe -store full net46 -split 4  -full d:\Beta\dotnet

@REM bin\libcheck.exe -store full corefx -split 4  -full "c:\Program Files\dotnet\bin" -out corefx
bin\libcheck.exe -split 4 -file "c:\Program Files\dotnet\bin\dotnet*" -out corefx

@PAUSE

