using System.Runtime.CompilerServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Texture;

namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public partial class UnityEngine_Texture2D
{
    public const string MONO_ApplyImpl = "UnityEngine.Texture2D::ApplyImpl";
    public const string MONO_ClearMinimumMipmapLevel = "UnityEngine.Texture2D::ClearMinimumMipmapLevel";
    public const string MONO_ClearRequestedMipmapLevel = "UnityEngine.Texture2D::ClearRequestedMipmapLevel";
    public const string MONO_Compress = "UnityEngine.Texture2D::Compress";
    public const string MONO_GenerateAtlasImpl = "UnityEngine.Texture2D::GenerateAtlasImpl";
    public const string MONO_GetBlackTexture = "UnityEngine.Texture2D::get_blackTexture";
    public const string MONO_GetCalculatedMipmapLevel = "UnityEngine.Texture2D::get_calculatedMipmapLevel";
    public const string MONO_GetDesiredMipmapLevel = "UnityEngine.Texture2D::get_desiredMipmapLevel";
    public const string MONO_GetFormat = "UnityEngine.Texture2D::get_format";
    public const string MONO_GetGrayTexture = "UnityEngine.Texture2D::get_grayTexture";
    public const string MONO_GetIgnoreMipmapLimit = "UnityEngine.Texture2D::get_ignoreMipmapLimit";
    public const string MONO_GetIsPreProcessed = "UnityEngine.Texture2D::get_isPreProcessed";
    public const string MONO_GetIsReadable = "UnityEngine.Texture2D::get_isReadable";
    public const string MONO_GetLinearGrayTexture = "UnityEngine.Texture2D::get_linearGrayTexture";
    public const string MONO_GetLoadAllMips = "UnityEngine.Texture2D::get_loadAllMips";
    public const string MONO_GetLoadedMipmapLevel = "UnityEngine.Texture2D::get_loadedMipmapLevel";
    public const string MONO_GetLoadingMipmapLevel = "UnityEngine.Texture2D::get_loadingMipmapLevel";
    public const string MONO_GetMinimumMipmapLevel = "UnityEngine.Texture2D::get_minimumMipmapLevel";
    public const string MONO_GetNormalTexture = "UnityEngine.Texture2D::get_normalTexture";
    public const string MONO_GetRedTexture = "UnityEngine.Texture2D::get_redTexture";
    public const string MONO_GetRequestedMipmapLevel = "UnityEngine.Texture2D::get_requestedMipmapLevel";
    public const string MONO_GetStreamingMipmaps = "UnityEngine.Texture2D::get_streamingMipmaps";
    public const string MONO_GetStreamingMipmapsPriority = "UnityEngine.Texture2D::get_streamingMipmapsPriority";
    public const string MONO_GetVtOnly = "UnityEngine.Texture2D::get_vtOnly";
    public const string MONO_GetWhiteTexture = "UnityEngine.Texture2D::get_whiteTexture";
    public const string MONO_GetPixelBilinearImplInjected = "UnityEngine.Texture2D::GetPixelBilinearImpl_Injected";
    public const string MONO_GetPixelImplInjected = "UnityEngine.Texture2D::GetPixelImpl_Injected";
    public const string MONO_GetPixels = "UnityEngine.Texture2D::GetPixels";
    public const string MONO_GetPixels32 = "UnityEngine.Texture2D::GetPixels32";
    public const string MONO_GetRawImageDataSize = "UnityEngine.Texture2D::GetRawImageDataSize";
    public const string MONO_GetRawTextureData = "UnityEngine.Texture2D::GetRawTextureData";
    public const string MONO_GetWritableImageData = "UnityEngine.Texture2D::GetWritableImageData";
    public const string MONO_InternalCreateImpl = "UnityEngine.Texture2D::Internal_CreateImpl";
    public const string MONO_IsRequestedMipmapLevelLoaded = "UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded";
    public const string MONO_LoadRawTextureDataImpl = "UnityEngine.Texture2D::LoadRawTextureDataImpl";
    public const string MONO_LoadRawTextureDataImplArray = "UnityEngine.Texture2D::LoadRawTextureDataImplArray";
    public const string MONO_PackTextures = "UnityEngine.Texture2D::PackTextures";
    public const string MONO_ReadPixelsImplInjected = "UnityEngine.Texture2D::ReadPixelsImpl_Injected";
    public const string MONO_ReinitializeImpl = "UnityEngine.Texture2D::ReinitializeImpl";
    public const string MONO_ReinitializeWithFormatImpl = "UnityEngine.Texture2D::ReinitializeWithFormatImpl";
    public const string MONO_SetIgnoreMipmapLimit = "UnityEngine.Texture2D::set_ignoreMipmapLimit";
    public const string MONO_SetLoadAllMips = "UnityEngine.Texture2D::set_loadAllMips";
    public const string MONO_SetMinimumMipmapLevel = "UnityEngine.Texture2D::set_minimumMipmapLevel";
    public const string MONO_SetRequestedMipmapLevel = "UnityEngine.Texture2D::set_requestedMipmapLevel";
    public const string MONO_SetAllPixels32 = "UnityEngine.Texture2D::SetAllPixels32";
    public const string MONO_SetBlockOfPixels32 = "UnityEngine.Texture2D::SetBlockOfPixels32";
    public const string MONO_SetPixelDataImpl = "UnityEngine.Texture2D::SetPixelDataImpl";
    public const string MONO_SetPixelDataImplArray = "UnityEngine.Texture2D::SetPixelDataImplArray";
    public const string MONO_SetPixelImplInjected = "UnityEngine.Texture2D::SetPixelImpl_Injected";
    public const string MONO_SetPixelsImpl = "UnityEngine.Texture2D::SetPixelsImpl";
    public const string MONO_UpdateExternalTexture = "UnityEngine.Texture2D::UpdateExternalTexture";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Texture2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Texture2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Texture2D(nint ptr) => new Ptr_UnityEngine_Texture2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Texture2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Texture2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ApplyImpl = "UnityEngine.Texture2D::ApplyImpl(System.Boolean,System.Boolean)";
    public const string IL2CPP_ClearMinimumMipmapLevel = "UnityEngine.Texture2D::ClearMinimumMipmapLevel()";
    public const string IL2CPP_ClearRequestedMipmapLevel = "UnityEngine.Texture2D::ClearRequestedMipmapLevel()";
    public const string IL2CPP_Compress = "UnityEngine.Texture2D::Compress(System.Boolean)";
    public const string IL2CPP_GenerateAtlasImpl = "UnityEngine.Texture2D::GenerateAtlasImpl(UnityEngine.Vector2[],System.Int32,System.Int32,UnityEngine.Rect[])";
    public const string IL2CPP_get_blackTexture = "UnityEngine.Texture2D::get_blackTexture()";
    public const string IL2CPP_get_calculatedMipmapLevel = "UnityEngine.Texture2D::get_calculatedMipmapLevel()";
    public const string IL2CPP_get_desiredMipmapLevel = "UnityEngine.Texture2D::get_desiredMipmapLevel()";
    public const string IL2CPP_get_format = "UnityEngine.Texture2D::get_format()";
    public const string IL2CPP_get_grayTexture = "UnityEngine.Texture2D::get_grayTexture()";
    public const string IL2CPP_get_isPreProcessed = "UnityEngine.Texture2D::get_isPreProcessed()";
    public const string IL2CPP_get_isReadable = "UnityEngine.Texture2D::get_isReadable()";
    public const string IL2CPP_get_linearGrayTexture = "UnityEngine.Texture2D::get_linearGrayTexture()";
    public const string IL2CPP_get_loadAllMips = "UnityEngine.Texture2D::get_loadAllMips()";
    public const string IL2CPP_get_loadedMipmapLevel = "UnityEngine.Texture2D::get_loadedMipmapLevel()";
    public const string IL2CPP_get_loadingMipmapLevel = "UnityEngine.Texture2D::get_loadingMipmapLevel()";
    public const string IL2CPP_get_minimumMipmapLevel = "UnityEngine.Texture2D::get_minimumMipmapLevel()";
    public const string IL2CPP_get_normalTexture = "UnityEngine.Texture2D::get_normalTexture()";
    public const string IL2CPP_get_redTexture = "UnityEngine.Texture2D::get_redTexture()";
    public const string IL2CPP_get_requestedMipmapLevel = "UnityEngine.Texture2D::get_requestedMipmapLevel()";
    public const string IL2CPP_get_streamingMipmaps = "UnityEngine.Texture2D::get_streamingMipmaps()";
    public const string IL2CPP_get_streamingMipmapsPriority = "UnityEngine.Texture2D::get_streamingMipmapsPriority()";
    public const string IL2CPP_get_vtOnly = "UnityEngine.Texture2D::get_vtOnly()";
    public const string IL2CPP_get_whiteTexture = "UnityEngine.Texture2D::get_whiteTexture()";
    public const string IL2CPP_GetPixelBilinearImpl_Injected = "UnityEngine.Texture2D::GetPixelBilinearImpl_Injected(System.Int32,System.Int32,System.Single,System.Single,UnityEngine.Color&)";
    public const string IL2CPP_GetPixelImpl_Injected = "UnityEngine.Texture2D::GetPixelImpl_Injected(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color&)";
    public const string IL2CPP_GetPixels = "UnityEngine.Texture2D::GetPixels(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_GetPixels32 = "UnityEngine.Texture2D::GetPixels32(System.Int32)";
    public const string IL2CPP_GetRawImageDataSize = "UnityEngine.Texture2D::GetRawImageDataSize()";
    public const string IL2CPP_GetRawTextureData = "UnityEngine.Texture2D::GetRawTextureData()";
    public const string IL2CPP_GetWritableImageData = "UnityEngine.Texture2D::GetWritableImageData(System.Int32)";
    public const string IL2CPP_Internal_CreateImpl = "UnityEngine.Texture2D::Internal_CreateImpl(UnityEngine.Texture2D,System.Int32,System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngine.Experimental.Rendering.TextureCreationFlags,System.IntPtr)";
    public const string IL2CPP_IsRequestedMipmapLevelLoaded = "UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded()";
    public const string IL2CPP_LoadRawTextureDataImpl = "UnityEngine.Texture2D::LoadRawTextureDataImpl(System.IntPtr,System.Int32)";
    public const string IL2CPP_LoadRawTextureDataImplArray = "UnityEngine.Texture2D::LoadRawTextureDataImplArray(System.Byte[])";
    public const string IL2CPP_PackTextures = "UnityEngine.Texture2D::PackTextures(UnityEngine.Texture2D[],System.Int32,System.Int32,System.Boolean)";
    public const string IL2CPP_ReadPixelsImpl_Injected = "UnityEngine.Texture2D::ReadPixelsImpl_Injected(UnityEngine.Rect&,System.Int32,System.Int32,System.Boolean)";
    public const string IL2CPP_ReinitializeImpl = "UnityEngine.Texture2D::ReinitializeImpl(System.Int32,System.Int32)";
    public const string IL2CPP_ReinitializeWithFormatImpl = "UnityEngine.Texture2D::ReinitializeWithFormatImpl(System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,System.Boolean)";
    public const string IL2CPP_set_loadAllMips = "UnityEngine.Texture2D::set_loadAllMips(System.Boolean)";
    public const string IL2CPP_set_minimumMipmapLevel = "UnityEngine.Texture2D::set_minimumMipmapLevel(System.Int32)";
    public const string IL2CPP_set_requestedMipmapLevel = "UnityEngine.Texture2D::set_requestedMipmapLevel(System.Int32)";
    public const string IL2CPP_SetAllPixels32 = "UnityEngine.Texture2D::SetAllPixels32(UnityEngine.Color32[],System.Int32)";
    public const string IL2CPP_SetBlockOfPixels32 = "UnityEngine.Texture2D::SetBlockOfPixels32(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color32[],System.Int32)";
    public const string IL2CPP_SetPixelDataImpl = "UnityEngine.Texture2D::SetPixelDataImpl(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_SetPixelDataImplArray = "UnityEngine.Texture2D::SetPixelDataImplArray(System.Array,System.Int32,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_SetPixelImpl_Injected = "UnityEngine.Texture2D::SetPixelImpl_Injected(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color&)";
    public const string IL2CPP_SetPixelsImpl = "UnityEngine.Texture2D::SetPixelsImpl(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color[],System.Int32,System.Int32)";
    public const string IL2CPP_UpdateExternalTexture = "UnityEngine.Texture2D::UpdateExternalTexture(System.IntPtr)";
}

partial class UnityEngine_Texture2D
{
    partial struct Ptr_UnityEngine_Texture2D
    {
        public nint GetNativeTexturePtr() => BaseClass().GetNativeTexturePtr();
        public int Width => BaseClass().Width;
        public int Height => BaseClass().Height;

    }
    partial struct Ptr_UnityEngine_Texture2D
    {
        public UnityEngine_Texture.Ptr_UnityEngine_Texture BaseClass() => this;
        public static implicit operator UnityEngine_Texture.Ptr_UnityEngine_Texture(Ptr_UnityEngine_Texture2D ptr) => new(ptr.m_Pointer);
    }

}