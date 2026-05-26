Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Cleaning and inserting Ptr_ structs under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

$classPattern = 'public\s+[^{]*class\s+([A-Za-z_]\w*)'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path

    $m = [regex]::Match($text, $classPattern)
    if (-not $m.Success) { continue }
    $className = $m.Groups[1].Value

    # find class block
    $startIndex = $m.Index
    $openBraceIndex = $text.IndexOf('{', $startIndex)
    if ($openBraceIndex -lt 0) { continue }
    $depth = 0; $i = $openBraceIndex; $len = $text.Length
    while ($i -lt $len) {
        $ch = $text[$i]
        if ($ch -eq '{') { $depth++ }
        elseif ($ch -eq '}') { $depth-- }
        $i++
        if ($depth -eq 0) { break }
    }
    if ($depth -ne 0) { continue }
    $classCloseIndex = $i - 1

    $classBody = $text.Substring($openBraceIndex + 1, $classCloseIndex - $openBraceIndex - 1)

    # Remove any existing Ptr struct blocks
    $structRemovePattern = "\[System\\.Runtime\\.InteropServices\\.StructLayout[\s\S]*?struct\\s+Ptr_$className[\s\S]*?\}\s*"
    $classBody = [regex]::Replace($classBody, $structRemovePattern, '', [System.Text.RegularExpressions.RegexOptions]::Singleline)

    # Remove stray Ptr-related member lines that may exist outside struct
    $lines = $classBody -split "\r?\n"
    $cleanLines = @()
    foreach ($line in $lines) {
        if ($line -match "\b(m_Pointer|Ptr\s*=>|implicit operator Ptr_$className|implicit operator nint\(|implicit operator bool\(|ToString\(|MarshalAs\(|StructLayout)" ) {
            # skip these lines
            continue
        }
        $cleanLines += $line
    }

    $cleanBody = [string]::Join([Environment]::NewLine, $cleanLines).TrimEnd()

    # Build correct struct block with 4-space indentation
    $structLines = @()
    $structLines += ''
    $structLines += '    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]'
    $structLines += "    public unsafe readonly partial struct Ptr_$className : IPtrMetadata"
    $structLines += '    {'
    $structLines += '        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]'
    $structLines += '        private readonly nint m_Pointer;'
    $structLines += ''
    $structLines += "        public Ptr_$className(nint ptr) { m_Pointer = ptr; }"
    $structLines += ''
    $structLines += '        public nint Ptr => m_Pointer;'
    $structLines += ''
    $structLines += "        public static implicit operator Ptr_$className(nint ptr) => new Ptr_$className(ptr);"
    $structLines += "        public static implicit operator nint(Ptr_$className ptr) => ptr.m_Pointer;"
    $structLines += "        public static implicit operator bool(Ptr_$className ptr) => ptr.m_Pointer != nint.Zero;"
    $structLines += ''
    $structLines += '        public override string ToString() => m_Pointer.ToString("X8");'
    $structLines += '    }'

    $structText = [string]::Join([Environment]::NewLine, $structLines)

    # Compose new class body
    if ($cleanBody -ne '') { $newClassBody = $cleanBody + [Environment]::NewLine + $structText + [Environment]::NewLine }
    else { $newClassBody = $structText + [Environment]::NewLine }

    # Replace in original text
    $newText = $text.Substring(0, $openBraceIndex + 1) + [Environment]::NewLine + $newClassBody + $text.Substring($classCloseIndex)

    if ($newText -ne $text) {
        Set-Content -Path $path -Value $newText -Encoding UTF8
        Write-Host "Patched: $path"
    }
}

Write-Host "Done."
