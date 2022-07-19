Param(
  [string]$newProjectName = "DotnetTemplate"
)

$oldName = "DotnetTemplate"

Get-ChildItem -Filter "*$oldName*" -Recurse | Rename-Item -NewName {$_.name -replace "$oldName", "$newProjectName" }

get-childitem -Recurse | Where-Object { ! $_.PSIsContainer -and $_.Name -ne 'RenameToNewProject.ps1' } | Select-Object -ExpandProperty fullname |
ForEach-Object {
          (Get-Content $_) -replace $oldName,$newProjectName |
            Set-Content $_
          }
