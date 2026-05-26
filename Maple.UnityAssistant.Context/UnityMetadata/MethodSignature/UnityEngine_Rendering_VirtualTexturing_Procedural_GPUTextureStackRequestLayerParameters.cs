namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters
{
    public const string MONO_GetHeightInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/GPUTextureStackRequestLayerParameters::GetHeight_Injected";
    public const string MONO_GetWidthInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/GPUTextureStackRequestLayerParameters::GetWidth_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_GPUTextureStackRequestLayerParameters ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
