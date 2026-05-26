namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Rendering_ShaderWarmup
{
    public const string MONO_WarmupShaderInjected = "UnityEngine.Experimental.Rendering.ShaderWarmup::WarmupShader_Injected";
    public const string MONO_WarmupShaderFromCollectionInjected = "UnityEngine.Experimental.Rendering.ShaderWarmup::WarmupShaderFromCollection_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup(nint ptr) => new Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Rendering_ShaderWarmup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
