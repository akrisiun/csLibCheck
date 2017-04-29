dotnet restore
cd src
dotnet build

nuget pack libcheck.csproj -o ..\

cd ..
