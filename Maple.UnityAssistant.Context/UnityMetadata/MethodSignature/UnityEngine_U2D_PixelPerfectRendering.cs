namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_U2D_PixelPerfectRendering
{
    public const string MONO_GetPixelSnapSpacing = "UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing";
    public const string MONO_SetPixelSnapSpacing = "UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_U2D_PixelPerfectRendering : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_U2D_PixelPerfectRendering(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_U2D_PixelPerfectRendering(nint ptr) => new Ptr_UnityEngine_U2D_PixelPerfectRendering(ptr);
        public static implicit operator nint(Ptr_UnityEngine_U2D_PixelPerfectRendering ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_U2D_PixelPerfectRendering ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_set_pixelSnapSpacing = "UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing(System.Single)";
}

