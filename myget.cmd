set dir=%~dp0
@set cfg=Debug

@echo -------------------------------------------------------------------
type myget.cmd
@echo -------------------------------------------------------------------

@REM myget.org build server
@if "%MsBuildExe%"=="" (
  @set MsBuildExe=%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe
)

"%MsBuildExe%" /p:Configuration="%cfg%" /v:m /m src\libcheck.csproj
