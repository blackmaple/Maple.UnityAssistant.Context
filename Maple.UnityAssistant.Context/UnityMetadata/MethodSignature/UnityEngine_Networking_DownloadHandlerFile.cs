namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_DownloadHandlerFile
{
    public const string MONO_Create = "UnityEngine.Networking.DownloadHandlerFile::Create";
    public const string MONO_GetRemoveFileOnAbort = "UnityEngine.Networking.DownloadHandlerFile::get_removeFileOnAbort";
    public const string MONO_SetRemoveFileOnAbort = "UnityEngine.Networking.DownloadHandlerFile::set_removeFileOnAbort";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_DownloadHandlerFile : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_DownloadHandlerFile(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_DownloadHandlerFile(nint ptr) => new Ptr_UnityEngine_Networking_DownloadHandlerFile(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_DownloadHandlerFile ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_DownloadHandlerFile ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Create = "UnityEngine.Networking.DownloadHandlerFile::Create(UnityEngine.Networking.DownloadHandlerFile,System.String,System.Boolean)";
}

