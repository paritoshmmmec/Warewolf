﻿#Requires -RunAsAdministrator

taskkill /im "Warewolf Studio.exe" /fi "STATUS eq RUNNING" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}
taskkill /im "Warewolf Studio.exe" /fi "STATUS eq UNKNOWN" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}
taskkill /im "Warewolf Studio.exe" /fi "STATUS eq NOT RESPONDING" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}

sc.exe stop "Warewolf Server"

taskkill /im "Warewolf Server.exe" /fi "STATUS eq RUNNING" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}
taskkill /im "Warewolf Server.exe" /fi "STATUS eq UNKNOWN" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}
taskkill /im "Warewolf Server.exe" /fi "STATUS eq NOT RESPONDING" | %{$Output = $_}
if ($Output.StartsWith("SUCCESS: ")) {
    sleep 5
}

$ToClean = `
"$env:LOCALAPPDATA\Warewolf\DebugData\PersistSettings.dat",
"$env:LOCALAPPDATA\Warewolf\UserInterfaceLayouts\WorkspaceLayout.xml",
"$env:PROGRAMDATA\Warewolf\Resources",
"$env:PROGRAMDATA\Warewolf\Tests",
"$env:PROGRAMDATA\Warewolf\Workspaces",
"$env:PROGRAMDATA\Warewolf\Server Settings"

[int]$ExitCode = 0
foreach ($FileOrFolder in $ToClean) {
	Remove-Item $FileOrFolder -Recurse -ErrorAction SilentlyContinue
	if (Test-Path $FileOrFolder) {
		Write-Host Cannot delete $FileOrFolder
		$ExitCode = 1
	}	
}
if ($ExitCode -eq 1) {
    exit 1
}