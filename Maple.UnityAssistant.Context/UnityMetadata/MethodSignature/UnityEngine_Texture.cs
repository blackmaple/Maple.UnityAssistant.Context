namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Texture
{
    public const string MONO_GetAllowThreadedTextureCreation = "UnityEngine.Texture::get_allowThreadedTextureCreation";
    public const string MONO_GetAnisoLevel = "UnityEngine.Texture::get_anisoLevel";
    public const string MONO_GetAnisotropicFiltering = "UnityEngine.Texture::get_anisotropicFiltering";
    public const string MONO_GetCurrentTextureMemory = "UnityEngine.Texture::get_currentTextureMemory";
    public const string MONO_GetDesiredTextureMemory = "UnityEngine.Texture::get_desiredTextureMemory";
    public const string MONO_GetFilterMode = "UnityEngine.Texture::get_filterMode";
    public const string MONO_GetIsReadable = "UnityEngine.Texture::get_isReadable";
    public const string MONO_GetMasterTextureLimit = "UnityEngine.Texture::get_masterTextureLimit";
    public const string MONO_GetMipMapBias = "UnityEngine.Texture::get_mipMapBias";
    public const string MONO_GetMipmapCount = "UnityEngine.Texture::get_mipmapCount";
    public const string MONO_GetNonStreamingTextureCount = "UnityEngine.Texture::get_nonStreamingTextureCount";
    public const string MONO_GetNonStreamingTextureMemory = "UnityEngine.Texture::get_nonStreamingTextureMemory";
    public const string MONO_GetStreamingMipmapUploadCount = "UnityEngine.Texture::get_streamingMipmapUploadCount";
    public const string MONO_GetStreamingRendererCount = "UnityEngine.Texture::get_streamingRendererCount";
    public const string MONO_GetStreamingTextureCount = "UnityEngine.Texture::get_streamingTextureCount";
    public const string MONO_GetStreamingTextureDiscardUnusedMips = "UnityEngine.Texture::get_streamingTextureDiscardUnusedMips";
    public const string MONO_GetStreamingTextureForceLoadAll = "UnityEngine.Texture::get_streamingTextureForceLoadAll";
    public const string MONO_GetStreamingTextureLoadingCount = "UnityEngine.Texture::get_streamingTextureLoadingCount";
    public const string MONO_GetStreamingTexturePendingLoadCount = "UnityEngine.Texture::get_streamingTexturePendingLoadCount";
    public const string MONO_GetTargetTextureMemory = "UnityEngine.Texture::get_targetTextureMemory";
    public const string MONO_GetTexelSizeInjected = "UnityEngine.Texture::get_texelSize_Injected";
    public const string MONO_GetTotalTextureMemory = "UnityEngine.Texture::get_totalTextureMemory";
    public const string MONO_GetUpdateCount = "UnityEngine.Texture::get_updateCount";
    public const string MONO_GetWrapMode = "UnityEngine.Texture::get_wrapMode";
    public const string MONO_GetWrapModeU = "UnityEngine.Texture::get_wrapModeU";
    public const string MONO_GetWrapModeV = "UnityEngine.Texture::get_wrapModeV";
    public const string MONO_GetWrapModeW = "UnityEngine.Texture::get_wrapModeW";
    public const string MONO_GetDimension = "UnityEngine.Texture::GetDimension";
    public const string MONO_GetNativeTexturePtr = "UnityEngine.Texture::GetNativeTexturePtr";
    public const string MONO_GetPixelDataOffset = "UnityEngine.Texture::GetPixelDataOffset";
    public const string MONO_GetPixelDataSize = "UnityEngine.Texture::GetPixelDataSize";
    public const string MONO_GetScriptHeight = "UnityEngine.Texture::GetScriptHeight";
    public const string MONO_GetScriptWidth = "UnityEngine.Texture::GetScriptWidth";
    public const string MONO_IncrementUpdateCount = "UnityEngine.Texture::IncrementUpdateCount";
    public const string MONO_InternalGetActiveTextureColorSpace = "UnityEngine.Texture::Internal_GetActiveTextureColorSpace";
    public const string MONO_SetAllowThreadedTextureCreation = "UnityEngine.Texture::set_allowThreadedTextureCreation";
    public const string MONO_SetAnisoLevel = "UnityEngine.Texture::set_anisoLevel";
    public const string MONO_SetAnisotropicFiltering = "UnityEngine.Texture::set_anisotropicFiltering";
    public const string MONO_SetFilterMode = "UnityEngine.Texture::set_filterMode";
    public const string MONO_SetMasterTextureLimit = "UnityEngine.Texture::set_masterTextureLimit";
    public const string MONO_SetMipMapBias = "UnityEngine.Texture::set_mipMapBias";
    public const string MONO_SetStreamingTextureDiscardUnusedMips = "UnityEngine.Texture::set_streamingTextureDiscardUnusedMips";
    public const string MONO_SetStreamingTextureForceLoadAll = "UnityEngine.Texture::set_streamingTextureForceLoadAll";
    public const string MONO_SetWrapMode = "UnityEngine.Texture::set_wrapMode";
    public const string MONO_SetWrapModeU = "UnityEngine.Texture::set_wrapModeU";
    public const string MONO_SetWrapModeV = "UnityEngine.Texture::set_wrapModeV";
    public const string MONO_SetWrapModeW = "UnityEngine.Texture::set_wrapModeW";
    public const string MONO_SetGlobalAnisotropicFilteringLimits = "UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits";
    public const string MONO_SetStreamingTextureMaterialDebugProperties = "UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Texture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Texture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Texture(nint ptr) => new Ptr_UnityEngine_Texture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Texture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Texture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_allowThreadedTextureCreation = "UnityEngine.Texture::get_allowThreadedTextureCreation()";
    public const string IL2CPP_get_anisoLevel = "UnityEngine.Texture::get_anisoLevel()";
    public const string IL2CPP_get_anisotropicFiltering = "UnityEngine.Texture::get_anisotropicFiltering()";
    public const string IL2CPP_get_currentTextureMemory = "UnityEngine.Texture::get_currentTextureMemory()";
    public const string IL2CPP_get_desiredTextureMemory = "UnityEngine.Texture::get_desiredTextureMemory()";
    public const string IL2CPP_get_filterMode = "UnityEngine.Texture::get_filterMode()";
    public const string IL2CPP_get_isReadable = "UnityEngine.Texture::get_isReadable()";
    public const string IL2CPP_get_masterTextureLimit = "UnityEngine.Texture::get_masterTextureLimit()";
    public const string IL2CPP_get_mipMapBias = "UnityEngine.Texture::get_mipMapBias()";
    public const string IL2CPP_get_mipmapCount = "UnityEngine.Texture::get_mipmapCount()";
    public const string IL2CPP_get_nonStreamingTextureCount = "UnityEngine.Texture::get_nonStreamingTextureCount()";
    public const string IL2CPP_get_nonStreamingTextureMemory = "UnityEngine.Texture::get_nonStreamingTextureMemory()";
    public const string IL2CPP_get_streamingMipmapUploadCount = "UnityEngine.Texture::get_streamingMipmapUploadCount()";
    public const string IL2CPP_get_streamingRendererCount = "UnityEngine.Texture::get_streamingRendererCount()";
    public const string IL2CPP_get_streamingTextureCount = "UnityEngine.Texture::get_streamingTextureCount()";
    public const string IL2CPP_get_streamingTextureDiscardUnusedMips = "UnityEngine.Texture::get_streamingTextureDiscardUnusedMips()";
    public const string IL2CPP_get_streamingTextureForceLoadAll = "UnityEngine.Texture::get_streamingTextureForceLoadAll()";
    public const string IL2CPP_get_streamingTextureLoadingCount = "UnityEngine.Texture::get_streamingTextureLoadingCount()";
    public const string IL2CPP_get_streamingTexturePendingLoadCount = "UnityEngine.Texture::get_streamingTexturePendingLoadCount()";
    public const string IL2CPP_get_targetTextureMemory = "UnityEngine.Texture::get_targetTextureMemory()";
    public const string IL2CPP_get_texelSize_Injected = "UnityEngine.Texture::get_texelSize_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_totalTextureMemory = "UnityEngine.Texture::get_totalTextureMemory()";
    public const string IL2CPP_get_updateCount = "UnityEngine.Texture::get_updateCount()";
    public const string IL2CPP_get_wrapMode = "UnityEngine.Texture::get_wrapMode()";
    public const string IL2CPP_get_wrapModeU = "UnityEngine.Texture::get_wrapModeU()";
    public const string IL2CPP_get_wrapModeV = "UnityEngine.Texture::get_wrapModeV()";
    public const string IL2CPP_get_wrapModeW = "UnityEngine.Texture::get_wrapModeW()";
    public const string IL2CPP_GetDataHeight = "UnityEngine.Texture::GetDataHeight()";
    public const string IL2CPP_GetDataWidth = "UnityEngine.Texture::GetDataWidth()";
    public const string IL2CPP_GetDimension = "UnityEngine.Texture::GetDimension()";
    public const string IL2CPP_GetNativeTexturePtr = "UnityEngine.Texture::GetNativeTexturePtr()";
    public const string IL2CPP_GetPixelDataOffset = "UnityEngine.Texture::GetPixelDataOffset(System.Int32,System.Int32)";
    public const string IL2CPP_GetPixelDataSize = "UnityEngine.Texture::GetPixelDataSize(System.Int32,System.Int32)";
    public const string IL2CPP_IncrementUpdateCount = "UnityEngine.Texture::IncrementUpdateCount()";
    public const string IL2CPP_Internal_GetActiveTextureColorSpace = "UnityEngine.Texture::Internal_GetActiveTextureColorSpace()";
    public const string IL2CPP_set_allowThreadedTextureCreation = "UnityEngine.Texture::set_allowThreadedTextureCreation(System.Boolean)";
    public const string IL2CPP_set_anisoLevel = "UnityEngine.Texture::set_anisoLevel(System.Int32)";
    public const string IL2CPP_set_anisotropicFiltering = "UnityEngine.Texture::set_anisotropicFiltering(UnityEngine.AnisotropicFiltering)";
    public const string IL2CPP_set_filterMode = "UnityEngine.Texture::set_filterMode(UnityEngine.FilterMode)";
    public const string IL2CPP_set_masterTextureLimit = "UnityEngine.Texture::set_masterTextureLimit(System.Int32)";
    public const string IL2CPP_set_mipMapBias = "UnityEngine.Texture::set_mipMapBias(System.Single)";
    public const string IL2CPP_set_streamingTextureDiscardUnusedMips = "UnityEngine.Texture::set_streamingTextureDiscardUnusedMips(System.Boolean)";
    public const string IL2CPP_set_streamingTextureForceLoadAll = "UnityEngine.Texture::set_streamingTextureForceLoadAll(System.Boolean)";
    public const string IL2CPP_set_wrapMode = "UnityEngine.Texture::set_wrapMode(UnityEngine.TextureWrapMode)";
    public const string IL2CPP_set_wrapModeU = "UnityEngine.Texture::set_wrapModeU(UnityEngine.TextureWrapMode)";
    public const string IL2CPP_set_wrapModeV = "UnityEngine.Texture::set_wrapModeV(UnityEngine.TextureWrapMode)";
    public const string IL2CPP_set_wrapModeW = "UnityEngine.Texture::set_wrapModeW(UnityEngine.TextureWrapMode)";
    public const string IL2CPP_SetGlobalAnisotropicFilteringLimits = "UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits(System.Int32,System.Int32)";
    public const string IL2CPP_SetStreamingTextureMaterialDebugProperties = "UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties()";
}

