Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Fixing insertion of Ptr_ structs under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) { Write-Host "No files found."; exit 0 }

$classPattern = 'public\s+[^{]*class\s+([A-Za-z_]\w*)'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path

    $matches = [regex]::Matches($text, $classPattern)
    if ($matches.Count -eq 0) { continue }

    $modified = $false

    foreach ($m in $matches) {
        $className = $m.Groups[1].Value

        # Remove any previously inserted Ptr struct for this class
        $removePattern = "\[System\.Runtime\.InteropServices\.StructLayout\([\s\S]*?\)\]\s*public\s+unsafe[\s\S]*?struct\s+Ptr_$className[\s\S]*?\}\s*"
        if ([regex]::IsMatch($text, $removePattern, [System.Text.RegularExpressions.RegexOptions]::Singleline)) {
            $text = [regex]::Replace($text, $removePattern, '', [System.Text.RegularExpressions.RegexOptions]::Singleline)
            $modified = $true
        }

        # Now insert struct inside the class body
        # find index of this match in the text
        $startIndex = $m.Index
        # find index of first '{' after startIndex
        $openBraceIndex = $text.IndexOf('{', $startIndex)
        if ($openBraceIndex -lt 0) { continue }

        # scan to find matching closing brace
        $depth = 0
        $i = $openBraceIndex
        $len = $text.Length
        while ($i -lt $len) {
            $ch = $text[$i]
            if ($ch -eq '{') { $depth++ }
            elseif ($ch -eq '}') { $depth-- }
            $i++
            if ($depth -eq 0) { break }
        }
        if ($depth -ne 0) { continue }

        $classCloseIndex = $i - 1

        # Prepare struct text
        $structLines = @()
        $structLines += '        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]'
        $structLines += "        public unsafe readonly partial struct Ptr_$className : IPtrMetadata"
        $structLines += '        {'
        $structLines += '            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]'
        $structLines += '            private readonly nint m_Pointer;'
        $structLines += ''
        $structLines += "            public Ptr_$className(nint ptr) { m_Pointer = ptr; }"
        $structLines += ''
        $structLines += '            public nint Ptr => m_Pointer;'
        $structLines += ''
        $structLines += "            public static implicit operator Ptr_$className(nint ptr) => new Ptr_$className(ptr);"
        $structLines += "            public static implicit operator nint(Ptr_$className ptr) => ptr.m_Pointer;"
        $structLines += "            public static implicit operator bool(Ptr_$className ptr) => ptr.m_Pointer != nint.Zero;"
        $structLines += ''
        $structLines += '            public override string ToString() => m_Pointer.ToString("X8");'
        $structLines += '        }'

        $structText = [string]::Join([Environment]::NewLine, $structLines) + [Environment]::NewLine

        # Insert struct just before the class closing brace, with proper indentation
        $text = $text.Substring(0, $classCloseIndex) + $structText + $text.Substring($classCloseIndex)
        $modified = $true
    }

    if ($modified) {
        Set-Content -Path $path -Value $text -Encoding UTF8
        Write-Host "Updated: $path"
    }
}

Write-Host "Done."
