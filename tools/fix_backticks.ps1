Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Fixing literal backtick sequences under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path
    if ($text -like '*`n*') {
        $new = $text.Replace('`n', [Environment]::NewLine)
        # also remove any stray carriage-return backtick combos
        $new = $new.Replace('`r', '')
        if ($new -ne $text) {
            Set-Content -Path $path -Value $new -Encoding UTF8
            Write-Host "Fixed: $path"
        }
    }
}

Write-Host "Done."
