#!/bin/bash
set -eu -o pipefail

dotnet restore /app/LongestRunningSubsequence.Tests/LongestRunningSubsequence.Tests.csproj
dotnet test /app/LongestRunningSubsequence.Tests/LongestRunningSubsequence.Tests.csproj