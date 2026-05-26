namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TerrainLayer
{
    public const string MONO_GetDiffuseRemapMaxInjected = "UnityEngine.TerrainLayer::get_diffuseRemapMax_Injected";
    public const string MONO_GetDiffuseRemapMinInjected = "UnityEngine.TerrainLayer::get_diffuseRemapMin_Injected";
    public const string MONO_GetDiffuseTexture = "UnityEngine.TerrainLayer::get_diffuseTexture";
    public const string MONO_GetMaskMapRemapMaxInjected = "UnityEngine.TerrainLayer::get_maskMapRemapMax_Injected";
    public const string MONO_GetMaskMapRemapMinInjected = "UnityEngine.TerrainLayer::get_maskMapRemapMin_Injected";
    public const string MONO_GetMaskMapTexture = "UnityEngine.TerrainLayer::get_maskMapTexture";
    public const string MONO_GetMetallic = "UnityEngine.TerrainLayer::get_metallic";
    public const string MONO_GetNormalMapTexture = "UnityEngine.TerrainLayer::get_normalMapTexture";
    public const string MONO_GetNormalScale = "UnityEngine.TerrainLayer::get_normalScale";
    public const string MONO_GetSmoothness = "UnityEngine.TerrainLayer::get_smoothness";
    public const string MONO_GetSpecularInjected = "UnityEngine.TerrainLayer::get_specular_Injected";
    public const string MONO_GetTileOffsetInjected = "UnityEngine.TerrainLayer::get_tileOffset_Injected";
    public const string MONO_GetTileSizeInjected = "UnityEngine.TerrainLayer::get_tileSize_Injected";
    public const string MONO_InternalCreate = "UnityEngine.TerrainLayer::Internal_Create";
    public const string MONO_SetDiffuseRemapMaxInjected = "UnityEngine.TerrainLayer::set_diffuseRemapMax_Injected";
    public const string MONO_SetDiffuseRemapMinInjected = "UnityEngine.TerrainLayer::set_diffuseRemapMin_Injected";
    public const string MONO_SetDiffuseTexture = "UnityEngine.TerrainLayer::set_diffuseTexture";
    public const string MONO_SetMaskMapRemapMaxInjected = "UnityEngine.TerrainLayer::set_maskMapRemapMax_Injected";
    public const string MONO_SetMaskMapRemapMinInjected = "UnityEngine.TerrainLayer::set_maskMapRemapMin_Injected";
    public const string MONO_SetMaskMapTexture = "UnityEngine.TerrainLayer::set_maskMapTexture";
    public const string MONO_SetMetallic = "UnityEngine.TerrainLayer::set_metallic";
    public const string MONO_SetNormalMapTexture = "UnityEngine.TerrainLayer::set_normalMapTexture";
    public const string MONO_SetNormalScale = "UnityEngine.TerrainLayer::set_normalScale";
    public const string MONO_SetSmoothness = "UnityEngine.TerrainLayer::set_smoothness";
    public const string MONO_SetSpecularInjected = "UnityEngine.TerrainLayer::set_specular_Injected";
    public const string MONO_SetTileOffsetInjected = "UnityEngine.TerrainLayer::set_tileOffset_Injected";
    public const string MONO_SetTileSizeInjected = "UnityEngine.TerrainLayer::set_tileSize_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TerrainLayer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TerrainLayer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TerrainLayer(nint ptr) => new Ptr_UnityEngine_TerrainLayer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TerrainLayer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TerrainLayer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
