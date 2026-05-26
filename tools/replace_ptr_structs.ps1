Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Replacing Ptr_ structs under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) {
    Write-Host "No files found under $Root"; exit 0
}

$classPattern = 'public\s+[^{]*class\s+([A-Za-z_]\w*)'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path

    $m = [regex]::Match($text, $classPattern)
    if (-not $m.Success) { continue }
    $className = $m.Groups[1].Value

    if (-not ($text -match "Ptr_$className")) { continue }

    $pattern = "\[System\.Runtime\.InteropServices\.StructLayout\([\s\S]*?public\s+unsafe\s+readonly\s+partial\s+struct\s+Ptr_$className[\s\S]*?\}\s*\n"

    $replacement = '    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]`n'
    $replacement += "    public unsafe readonly partial struct Ptr_$className : IPtrMetadata`n"
    $replacement += '    {`n'
    $replacement += '        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]`n'
    $replacement += '        private readonly nint m_Pointer;`n`n'
    $replacement += "        public Ptr_$className(nint ptr) { m_Pointer = ptr; }`n`n"
    $replacement += '        public nint Ptr => m_Pointer;`n`n'
    $replacement += "        public static implicit operator Ptr_$className(nint ptr) => new Ptr_$className(ptr);`n"
    $replacement += "        public static implicit operator nint(Ptr_$className ptr) => ptr.m_Pointer;`n"
    $replacement += "        public static implicit operator bool(Ptr_$className ptr) => ptr.m_Pointer != nint.Zero;`n"
    $replacement += '        public override string ToString() => m_Pointer.ToString("X8");`n'
    $replacement += '    }`n'

    $new = [regex]::Replace($text, $pattern, $replacement, [System.Text.RegularExpressions.RegexOptions]::Singleline)
    if ($new -ne $text) {
        Set-Content -Path $path -Value $new -Encoding UTF8
        Write-Host "Fixed Ptr_$className in: $path"
    }
}

Write-Host "Done."
