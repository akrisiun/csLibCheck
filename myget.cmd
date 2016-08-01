set dir=%~dp0
@set cfg=Debug

@echo -------------------------------------------------------------------
cd "%dir%"
type myget.cmd
@echo -------------------------------------------------------------------

@REM myget.org build server

@set msbuild="%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

nuget restore libcheck.sln

%msbuild% /p:Configuration="%cfg%" /v:m /m  libcheck.sln