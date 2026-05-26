Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Rewriting MethodSignature files to canonical form: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

$namespacePattern = '^\s*namespace\s+([^\r\n;]+)\s*;?\s*$'
$classPattern = '^\s*public\s+static\s+class\s+([A-Za-z_]\w*)\s*$'
$constPattern = '^\s*public\s+const\s+string\s+([A-Za-z_]\w*)\s*=\s*("(?:[^"\\]|\\.)*")\s*;\s*$'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path
    $lines = $text -split "\r?\n"

    $namespace = $null
    $className = $null
    $constLines = New-Object System.Collections.Generic.List[string]

    foreach ($line in $lines) {
        if (-not $namespace) {
            $nm = [regex]::Match($line, $namespacePattern)
            if ($nm.Success) { $namespace = $nm.Groups[1].Value.Trim() }
        }

        if (-not $className) {
            $cm = [regex]::Match($line, $classPattern)
            if ($cm.Success) { $className = $cm.Groups[1].Value.Trim() }
        }

        $constMatch = [regex]::Match($line, $constPattern)
        if ($constMatch.Success) {
            $constName = $constMatch.Groups[1].Value
            $constValue = $constMatch.Groups[2].Value
            $constLines.Add("    public const string $constName = $constValue;")
        }
    }

    if (-not $namespace -or -not $className) {
        Write-Host "Skipping (missing namespace/class): $path"
        continue
    }

    $structName = "Ptr_$className"

    $sb = New-Object System.Text.StringBuilder
    [void]$sb.AppendLine("namespace $namespace;")
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("public static class $className")
    [void]$sb.AppendLine('{')

    foreach ($constLine in $constLines) {
        [void]$sb.AppendLine($constLine)
    }

    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]')
    [void]$sb.AppendLine("    public unsafe readonly partial struct $structName : IPtrMetadata")
    [void]$sb.AppendLine('    {')
    [void]$sb.AppendLine('        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]')
    [void]$sb.AppendLine('        private readonly nint m_Pointer;')
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("        public $structName(nint ptr) { m_Pointer = ptr; }")
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('        public nint Ptr => m_Pointer;')
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine("        public static implicit operator $structName(nint ptr) => new $structName(ptr);")
    [void]$sb.AppendLine("        public static implicit operator nint($structName ptr) => ptr.m_Pointer;")
    [void]$sb.AppendLine("        public static implicit operator bool($structName ptr) => ptr.m_Pointer != nint.Zero;")
    [void]$sb.AppendLine('')
    [void]$sb.AppendLine('        public override string ToString() => m_Pointer.ToString("X8");')
    [void]$sb.AppendLine('    }')
    [void]$sb.AppendLine('}')

    $newText = $sb.ToString()
    Set-Content -Path $path -Value $newText -Encoding UTF8
    Write-Host "Rewritten: $path"
}

Write-Host "Done."
