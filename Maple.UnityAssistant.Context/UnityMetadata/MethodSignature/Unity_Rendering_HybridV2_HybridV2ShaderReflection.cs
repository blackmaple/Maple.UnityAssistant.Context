namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Rendering_HybridV2_HybridV2ShaderReflection
{
    public const string MONO_GetDotsinstancingCbuffersPointer = "Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingCbuffersPointer";
    public const string MONO_GetDotsinstancingPropertiesPointer = "Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingPropertiesPointer";
    public const string MONO_GetDotsreflectionVersionNumber = "Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSReflectionVersionNumber";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection(nint ptr) => new Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection(ptr);
        public static implicit operator nint(Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Rendering_HybridV2_HybridV2ShaderReflection ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
