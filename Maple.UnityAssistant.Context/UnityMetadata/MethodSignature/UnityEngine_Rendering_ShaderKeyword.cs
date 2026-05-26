namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_ShaderKeyword
{
    public const string MONO_CreateGlobalKeyword = "UnityEngine.Rendering.ShaderKeyword::CreateGlobalKeyword";
    public const string MONO_GetComputeShaderKeywordCount = "UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordCount";
    public const string MONO_GetComputeShaderKeywordIndex = "UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordIndex";
    public const string MONO_GetGlobalKeywordCount = "UnityEngine.Rendering.ShaderKeyword::GetGlobalKeywordCount";
    public const string MONO_GetGlobalKeywordIndex = "UnityEngine.Rendering.ShaderKeyword::GetGlobalKeywordIndex";
    public const string MONO_GetGlobalShaderKeywordType = "UnityEngine.Rendering.ShaderKeyword::GetGlobalShaderKeywordType";
    public const string MONO_GetKeywordCount = "UnityEngine.Rendering.ShaderKeyword::GetKeywordCount";
    public const string MONO_GetKeywordIndex = "UnityEngine.Rendering.ShaderKeyword::GetKeywordIndex";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_ShaderKeyword : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_ShaderKeyword(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_ShaderKeyword(nint ptr) => new Ptr_UnityEngine_Rendering_ShaderKeyword(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_ShaderKeyword ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_ShaderKeyword ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateGlobalKeyword = "UnityEngine.Rendering.ShaderKeyword::CreateGlobalKeyword(System.String)";
    public const string IL2CPP_GetGlobalKeywordCount = "UnityEngine.Rendering.ShaderKeyword::GetGlobalKeywordCount()";
    public const string IL2CPP_GetGlobalKeywordIndex = "UnityEngine.Rendering.ShaderKeyword::GetGlobalKeywordIndex(System.String)";
}

