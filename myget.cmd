set dir=%~dp0
@set cfg=Debug

@echo -------------------------------------------------------------------
cd "%dir%"
type myget.cmd
@echo -------------------------------------------------------------------

@REM myget.org build server

@if "%MsBuildExe%"=="" (
@set MsBuildExe=%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe
)
@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe
@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe
@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe


@echo "%MsBuildExe%"

nuget.exe restore libcheck.sln

"%MsBuildExe%" /p:Configuration="%cfg%" /v:m /m  libcheck.sln