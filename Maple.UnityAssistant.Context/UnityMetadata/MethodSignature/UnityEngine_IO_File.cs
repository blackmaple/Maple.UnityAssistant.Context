namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_IO_File
{
    public const string MONO_GetMainThreadFileIorestriction = "UnityEngine.IO.File::GetMainThreadFileIORestriction";
    public const string MONO_GetRecordZeroSeeks = "UnityEngine.IO.File::GetRecordZeroSeeks";
    public const string MONO_GetTotalBytesRead = "UnityEngine.IO.File::GetTotalBytesRead";
    public const string MONO_GetTotalBytesWritten = "UnityEngine.IO.File::GetTotalBytesWritten";
    public const string MONO_GetTotalCloseCalls = "UnityEngine.IO.File::GetTotalCloseCalls";
    public const string MONO_GetTotalFilesClosed = "UnityEngine.IO.File::GetTotalFilesClosed";
    public const string MONO_GetTotalFilesOpened = "UnityEngine.IO.File::GetTotalFilesOpened";
    public const string MONO_GetTotalOpenCalls = "UnityEngine.IO.File::GetTotalOpenCalls";
    public const string MONO_GetTotalReadCalls = "UnityEngine.IO.File::GetTotalReadCalls";
    public const string MONO_GetTotalSeekCalls = "UnityEngine.IO.File::GetTotalSeekCalls";
    public const string MONO_GetTotalWriteCalls = "UnityEngine.IO.File::GetTotalWriteCalls";
    public const string MONO_GetTotalZeroSeekCalls = "UnityEngine.IO.File::GetTotalZeroSeekCalls";
    public const string MONO_SetMainThreadFileIorestriction = "UnityEngine.IO.File::SetMainThreadFileIORestriction";
    public const string MONO_SetRecordZeroSeeks = "UnityEngine.IO.File::SetRecordZeroSeeks";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_IO_File : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_IO_File(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_IO_File(nint ptr) => new Ptr_UnityEngine_IO_File(ptr);
        public static implicit operator nint(Ptr_UnityEngine_IO_File ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_IO_File ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
