namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Rendering_ExternalGPUProfiler
{
    public const string MONO_BeginGpucapture = "UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture";
    public const string MONO_EndGpucapture = "UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture";
    public const string MONO_IsAttached = "UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler(nint ptr) => new Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Rendering_ExternalGPUProfiler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
