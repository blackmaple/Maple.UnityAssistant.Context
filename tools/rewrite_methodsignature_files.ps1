Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Rewriting MethodSignature files under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

$nsPattern = 'namespace\s+[^{;\r\n]+'
$classPattern = 'public\s+static\s+class\s+([A-Za-z_]\w*)'
$constPattern = 'public\s+const\s+string\s+[A-Za-z_]\w*\s*=\s*"[^"]*"\s*;'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path

    $nsMatch = [regex]::Match($text, $nsPattern)
    $classMatch = [regex]::Match($text, $classPattern)
    if (-not $nsMatch.Success -or -not $classMatch.Success) {
        Write-Host "Skipping (no namespace/class): $path"
        continue
    }

    $namespaceLine = $nsMatch.Value.Trim()
    $className = $classMatch.Groups[1].Value

    $constMatches = [regex]::Matches($text, $constPattern)
    $constLines = @()
    foreach ($cm in $constMatches) { $constLines += $cm.Value.Trim() }
    $constLines = $constLines | Select-Object -Unique

    # Build new content
    $sb = New-Object System.Text.StringBuilder
    [void]$sb.AppendLine($namespaceLine)
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("public static class $className")
    [void]$sb.AppendLine('{')

    foreach ($cl in $constLines) {
        [void]$sb.AppendLine('    ' + $cl)
    }

    # Append Ptr struct
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]')
    [void]$sb.AppendLine("    public unsafe readonly partial struct Ptr_$className : IPtrMetadata")
    [void]$sb.AppendLine('    {')
    [void]$sb.AppendLine('        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]')
    [void]$sb.AppendLine('        private readonly nint m_Pointer;')
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("        public Ptr_$className(nint ptr) { m_Pointer = ptr; }")
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('        public nint Ptr => m_Pointer;')
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("        public static implicit operator Ptr_$className(nint ptr) => new Ptr_$className(ptr);")
    [void]$sb.AppendLine("        public static implicit operator nint(Ptr_$className ptr) => ptr.m_Pointer;")
    [void]$sb.AppendLine("        public static implicit operator bool(Ptr_$className ptr) => ptr.m_Pointer != nint.Zero;")
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('        public override string ToString() => m_Pointer.ToString("X8");')
    [void]$sb.AppendLine('    }')

    [void]$sb.AppendLine('}')

    $newText = $sb.ToString()
    Set-Content -Path $path -Value $newText -Encoding UTF8
    Write-Host "Rewritten: $path"
}

Write-Host "Done."
