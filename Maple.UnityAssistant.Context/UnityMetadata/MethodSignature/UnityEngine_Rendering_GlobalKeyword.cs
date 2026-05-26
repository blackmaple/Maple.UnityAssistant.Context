namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_GlobalKeyword
{
    public const string MONO_CreateGlobalKeyword = "UnityEngine.Rendering.GlobalKeyword::CreateGlobalKeyword";
    public const string MONO_GetGlobalKeywordCount = "UnityEngine.Rendering.GlobalKeyword::GetGlobalKeywordCount";
    public const string MONO_GetGlobalKeywordIndex = "UnityEngine.Rendering.GlobalKeyword::GetGlobalKeywordIndex";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_GlobalKeyword : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_GlobalKeyword(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_GlobalKeyword(nint ptr) => new Ptr_UnityEngine_Rendering_GlobalKeyword(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_GlobalKeyword ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_GlobalKeyword ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
