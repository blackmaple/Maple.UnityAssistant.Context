namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_LocalKeyword
{
    public const string MONO_GetComputeShaderKeywordCount = "UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordCount";
    public const string MONO_GetComputeShaderKeywordIndex = "UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordIndex";
    public const string MONO_GetKeywordTypeInjected = "UnityEngine.Rendering.LocalKeyword::GetKeywordType_Injected";
    public const string MONO_GetShaderKeywordCount = "UnityEngine.Rendering.LocalKeyword::GetShaderKeywordCount";
    public const string MONO_GetShaderKeywordIndex = "UnityEngine.Rendering.LocalKeyword::GetShaderKeywordIndex";
    public const string MONO_IsOverridableInjected = "UnityEngine.Rendering.LocalKeyword::IsOverridable_Injected";
    public const string MONO_IsValidInjected = "UnityEngine.Rendering.LocalKeyword::IsValid_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_LocalKeyword : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_LocalKeyword(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_LocalKeyword(nint ptr) => new Ptr_UnityEngine_Rendering_LocalKeyword(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_LocalKeyword ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_LocalKeyword ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
