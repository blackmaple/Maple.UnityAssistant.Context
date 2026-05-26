namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Streaming
{
    public const string MONO_GetCpucacheSize = "UnityEngine.Rendering.VirtualTexturing.Streaming::GetCPUCacheSize";
    public const string MONO_GetGpucacheSettings = "UnityEngine.Rendering.VirtualTexturing.Streaming::GetGPUCacheSettings";
    public const string MONO_GetTextureStackSize = "UnityEngine.Rendering.VirtualTexturing.Streaming::GetTextureStackSize";
    public const string MONO_RequestRegionInjected = "UnityEngine.Rendering.VirtualTexturing.Streaming::RequestRegion_Injected";
    public const string MONO_SetCpucacheSize = "UnityEngine.Rendering.VirtualTexturing.Streaming::SetCPUCacheSize";
    public const string MONO_SetGpucacheSettings = "UnityEngine.Rendering.VirtualTexturing.Streaming::SetGPUCacheSettings";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Streaming ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
