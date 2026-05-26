namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_PIX
{
    public const string MONO_BeginGpucapture = "UnityEngine.Rendering.PIX::BeginGPUCapture";
    public const string MONO_EndGpucapture = "UnityEngine.Rendering.PIX::EndGPUCapture";
    public const string MONO_IsAttached = "UnityEngine.Rendering.PIX::IsAttached";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_PIX : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_PIX(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_PIX(nint ptr) => new Ptr_UnityEngine_Rendering_PIX(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_PIX ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_PIX ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
