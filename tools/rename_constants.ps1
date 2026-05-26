Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Renaming const string identifiers under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) {
    Write-Host "No files found under $Root"; exit 0
}

$pattern = 'public\s+const\s+string\s+(?!MONO_)([A-Za-z_]\w*)\s*=\s*'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path
    $new = [regex]::Replace($text, $pattern, 'public const string MONO_$1 = ')
    if ($new -ne $text) {
        Set-Content -Path $path -Value $new -Encoding UTF8
        Write-Host "Modified: $path"
    }
}

Write-Host "Done."
