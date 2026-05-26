namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_LocalKeywordSpace
{
    public const string MONO_GetKeywordInjected = "UnityEngine.Rendering.LocalKeywordSpace::GetKeyword_Injected";
    public const string MONO_GetKeywordCountInjected = "UnityEngine.Rendering.LocalKeywordSpace::GetKeywordCount_Injected";
    public const string MONO_GetKeywordNamesInjected = "UnityEngine.Rendering.LocalKeywordSpace::GetKeywordNames_Injected";
    public const string MONO_GetKeywordsInjected = "UnityEngine.Rendering.LocalKeywordSpace::GetKeywords_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_LocalKeywordSpace : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_LocalKeywordSpace(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_LocalKeywordSpace(nint ptr) => new Ptr_UnityEngine_Rendering_LocalKeywordSpace(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_LocalKeywordSpace ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_LocalKeywordSpace ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
