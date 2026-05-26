namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_WebCam_WebCam
{
    public const string MONO_GetMode = "UnityEngine.Windows.WebCam.WebCam::get_Mode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_WebCam_WebCam : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_WebCam_WebCam(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_WebCam_WebCam(nint ptr) => new Ptr_UnityEngine_Windows_WebCam_WebCam(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_WebCam_WebCam ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_WebCam_WebCam ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
