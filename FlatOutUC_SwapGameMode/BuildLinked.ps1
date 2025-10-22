# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/FlatOutUC_SwapGameMode/*" -Force -Recurse
dotnet publish "./FlatOutUC_SwapGameMode.csproj" -c Release -o "$env:RELOADEDIIMODS/FlatOutUC_SwapGameMode" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location