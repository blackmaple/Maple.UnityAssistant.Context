namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_DownloadHandler
{
    public const string MONO_GetContentType = "UnityEngine.Networking.DownloadHandler::GetContentType";
    public const string MONO_GetErrorMsg = "UnityEngine.Networking.DownloadHandler::GetErrorMsg";
    public const string MONO_InternalGetByteArray = "UnityEngine.Networking.DownloadHandler::InternalGetByteArray";
    public const string MONO_IsDone = "UnityEngine.Networking.DownloadHandler::IsDone";
    public const string MONO_Release = "UnityEngine.Networking.DownloadHandler::Release";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_DownloadHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_DownloadHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_DownloadHandler(nint ptr) => new Ptr_UnityEngine_Networking_DownloadHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_DownloadHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_DownloadHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetContentType = "UnityEngine.Networking.DownloadHandler::GetContentType()";
    public const string IL2CPP_InternalGetByteArray = "UnityEngine.Networking.DownloadHandler::InternalGetByteArray(UnityEngine.Networking.DownloadHandler,System.Int32&)";
    public const string IL2CPP_Release = "UnityEngine.Networking.DownloadHandler::Release()";
}

