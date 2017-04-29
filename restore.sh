#!/bin/bash

NUGET=.nuget/nuget.exe

mkdir .nuget

if [[ ! -e ${NUGET} ]]; then
    curl https://api.nuget.org/downloads/nuget.exe > ${NUGET}
fi

mono ${NUGET} restore libcheck.sln

# @REM "$@"
