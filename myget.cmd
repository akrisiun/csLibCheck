set dir=%~dp0
@set cfg=Debug
set build=1.0.4

@echo -------------------------------------------------------------------
cd "%dir%"
@REM type myget.cmd
@echo -------------------------------------------------------------------

@REM myget.org build server
@set MsBuildExe=%ProgramFiles(x86)%\MSBuild\15.0\Bin\MSBuild.exe

@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe
@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles(x86)%\MSBuild\15.0\Bin\MSBuild.exe
@if not exist "%MsBuildExe%" @set MsBuildExe=%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe

@echo "%MsBuildExe%"

mkdir Packages

set NURL=https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
set NUGET=Packages\nuget.exe
if not exist %~dp0%NUGET% @powershell Invoke-WebRequest %NURL% -OutFile %NUGET%

%NUGET% restore libcheck.sln

@REM "%MsBuildExe%" /p:Configuration="%cfg%" /v:m /m  libcheck.sln

%NUGET% pack src\LibCheck.csproj -Version %build% -Symbols -Build
@REM CsLibCheck.nuspec --no-build --include-symbols

