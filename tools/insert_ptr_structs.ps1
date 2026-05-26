Param(
    [string]$Root = "Maple.UnityAssistant.Context/UnityMetadata/MethodSignature"
)

Write-Host "Inserting Ptr_XXX structs under: $Root"

$files = Get-ChildItem -Path $Root -Filter *.cs -Recurse -ErrorAction SilentlyContinue
if (-not $files) {
    Write-Host "No files found under $Root"; exit 0
}

$classPattern = 'public\s+[^{]*class\s+([A-Za-z_]\w*)'

foreach ($file in $files) {
    $path = $file.FullName
    $text = Get-Content -Raw -Encoding UTF8 $path

    $m = [regex]::Match($text, $classPattern)
    if (-not $m.Success) {
        Write-Host "Skipping (no public class found): $path"
        continue
    }
    $className = $m.Groups[1].Value

    if ($text -like "*Ptr_$className*") {
        Write-Host "Skipping (Ptr exists): $path"
        continue
    }

    $struct = "    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]`n"
    $struct += "    public unsafe readonly partial struct Ptr_$className(nint ptr) : IPtrMetadata`n"
    $struct += "    {`n"
    $struct += "        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]`n"
    $struct += "        private readonly nint m_Pointer = ptr;`n`n"
    $struct += "        public nint Ptr => m_Pointer;`n`n"
    $struct += "        public static implicit operator Ptr_$className(nint ptr) => new(ptr);`n"
    $struct += "        public static implicit operator nint(Ptr_$className ptr) => ptr.m_Pointer;`n"
    $struct += "        public static implicit operator bool(Ptr_$className ptr) => ptr.m_Pointer != nint.Zero;`n"
    $struct += "        public override string ToString()" + "`n"
    $struct += "        {`n"
    $struct += '            return m_Pointer.ToString("X8");`n'
    $struct += "        }`n`n"
    $struct += "    }`n"

    # Insert struct before the last closing brace in the file
    $new = [regex]::Replace($text, "}\s*\z", "$struct}`n", [System.Text.RegularExpressions.RegexOptions]::Singleline)

    if ($new -ne $text) {
        Set-Content -Path $path -Value $new -Encoding UTF8
        Write-Host "Modified: $path (added Ptr_$className)"
    }
}

Write-Host "Done."
