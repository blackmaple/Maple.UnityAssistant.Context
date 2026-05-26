namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_CertificateHandler
{
    public const string MONO_Create = "UnityEngine.Networking.CertificateHandler::Create";
    public const string MONO_Release = "UnityEngine.Networking.CertificateHandler::Release";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_CertificateHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_CertificateHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_CertificateHandler(nint ptr) => new Ptr_UnityEngine_Networking_CertificateHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_CertificateHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_CertificateHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Release = "UnityEngine.Networking.CertificateHandler::Release()";
}

