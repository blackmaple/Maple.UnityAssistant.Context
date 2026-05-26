namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_EditorHelpers
{
    public const string MONO_GetTileSize = "UnityEngine.Rendering.VirtualTexturing.EditorHelpers::get_tileSize";
    public const string MONO_QuerySupportedFormats = "UnityEngine.Rendering.VirtualTexturing.EditorHelpers::QuerySupportedFormats";
    public const string MONO_ValidateMaterialTextureStacks = "UnityEngine.Rendering.VirtualTexturing.EditorHelpers::ValidateMaterialTextureStacks";
    public const string MONO_ValidateTextureStack = "UnityEngine.Rendering.VirtualTexturing.EditorHelpers::ValidateTextureStack";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_EditorHelpers ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
