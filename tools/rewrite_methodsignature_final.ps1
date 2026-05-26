Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Rewriting MethodSignature files to final canonical form: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

$namespacePattern = '^\s*namespace\s+([^\r\n;{]+)\s*[;{]?\s*$'
$classPattern = '^\s*public\s+static\s+class\s+([A-Za-z_]\w*)\s*$'
$constPattern = '^\s*public\s+const\s+string\s+([A-Za-z_]\w*)\s*=\s*("(?:[^"\\]|\\.)*")\s*;\s*$'
$fqInterface = 'MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path
    $lines = $text -split "\r?\n"

    $namespace = $null
    $className = $null
    $constMap = [ordered]@{}

    foreach ($line in $lines) {
        if (-not $namespace) {
            $nm = [regex]::Match($line, $namespacePattern)
            if ($nm.Success) {
                $candidate = $nm.Groups[1].Value.Trim()
                if ($candidate -ne '' -and -not $candidate.Contains('public static class')) {
                    $namespace = $candidate
                }
            }
        }

        if (-not $className) {
            $cm = [regex]::Match($line, $classPattern)
            if ($cm.Success) { $className = $cm.Groups[1].Value.Trim() }
        }

        $constMatch = [regex]::Match($line, $constPattern)
        if ($constMatch.Success) {
            $constName = $constMatch.Groups[1].Value
            $constValue = $constMatch.Groups[2].Value
            if (-not $constMap.Contains($constName)) {
                $constMap[$constName] = $constValue
            }
        }
    }

    if (-not $namespace -or -not $className) {
        Write-Host "Skipping (missing namespace/class): $path"
        continue
    }

    $structName = "Ptr_$className"

    $out = New-Object System.Collections.Generic.List[string]
    $out.Add("namespace $namespace;")
    $out.Add('')
    $out.Add("public static class $className")
    $out.Add('{')

    foreach ($key in $constMap.Keys) {
        $out.Add("    public const string $key = $($constMap[$key]);")
    }

    $out.Add('')
    $out.Add('    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]')
    $out.Add("    public unsafe readonly partial struct $structName : $fqInterface")
    $out.Add('    {')
    $out.Add('        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]')
    $out.Add('        private readonly nint m_Pointer;')
    $out.Add('')
    $out.Add("        public $structName(nint ptr) { m_Pointer = ptr; }")
    $out.Add('')
    $out.Add('        public nint Ptr => m_Pointer;')
    $out.Add('')
    $out.Add("        public static implicit operator $structName(nint ptr) => new $structName(ptr);")
    $out.Add("        public static implicit operator nint($structName ptr) => ptr.m_Pointer;")
    $out.Add("        public static implicit operator bool($structName ptr) => ptr.m_Pointer != nint.Zero;")
    $out.Add('')
    $out.Add('        public override string ToString() => m_Pointer.ToString("X8");')
    $out.Add('    }')
    $out.Add('}')

    [System.IO.File]::WriteAllText($path, ($out -join [Environment]::NewLine) + [Environment]::NewLine, [System.Text.UTF8Encoding]::new($false))
    Write-Host "Rewritten: $path"
}

Write-Host "Done."