namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_UploadHandler
{
    public const string MONO_InternalGetContentType = "UnityEngine.Networking.UploadHandler::InternalGetContentType";
    public const string MONO_InternalGetProgress = "UnityEngine.Networking.UploadHandler::InternalGetProgress";
    public const string MONO_InternalSetContentType = "UnityEngine.Networking.UploadHandler::InternalSetContentType";
    public const string MONO_Release = "UnityEngine.Networking.UploadHandler::Release";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_UploadHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_UploadHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_UploadHandler(nint ptr) => new Ptr_UnityEngine_Networking_UploadHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_UploadHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_UploadHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalSetContentType = "UnityEngine.Networking.UploadHandler::InternalSetContentType(System.String)";
    public const string IL2CPP_Release = "UnityEngine.Networking.UploadHandler::Release()";
}

