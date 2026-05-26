namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Cubemap
{
    public const string MONO_ApplyImpl = "UnityEngine.Cubemap::ApplyImpl";
    public const string MONO_ClearRequestedMipmapLevel = "UnityEngine.Cubemap::ClearRequestedMipmapLevel";
    public const string MONO_GetDesiredMipmapLevel = "UnityEngine.Cubemap::get_desiredMipmapLevel";
    public const string MONO_GetFormat = "UnityEngine.Cubemap::get_format";
    public const string MONO_GetIsPreProcessed = "UnityEngine.Cubemap::get_isPreProcessed";
    public const string MONO_GetIsReadable = "UnityEngine.Cubemap::get_isReadable";
    public const string MONO_GetLoadAllMips = "UnityEngine.Cubemap::get_loadAllMips";
    public const string MONO_GetLoadedMipmapLevel = "UnityEngine.Cubemap::get_loadedMipmapLevel";
    public const string MONO_GetLoadingMipmapLevel = "UnityEngine.Cubemap::get_loadingMipmapLevel";
    public const string MONO_GetRequestedMipmapLevel = "UnityEngine.Cubemap::get_requestedMipmapLevel";
    public const string MONO_GetStreamingMipmaps = "UnityEngine.Cubemap::get_streamingMipmaps";
    public const string MONO_GetStreamingMipmapsPriority = "UnityEngine.Cubemap::get_streamingMipmapsPriority";
    public const string MONO_GetPixelImplInjected = "UnityEngine.Cubemap::GetPixelImpl_Injected";
    public const string MONO_GetPixels = "UnityEngine.Cubemap::GetPixels";
    public const string MONO_GetWritableImageData = "UnityEngine.Cubemap::GetWritableImageData";
    public const string MONO_InternalCreateImpl = "UnityEngine.Cubemap::Internal_CreateImpl";
    public const string MONO_IsRequestedMipmapLevelLoaded = "UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded";
    public const string MONO_SetLoadAllMips = "UnityEngine.Cubemap::set_loadAllMips";
    public const string MONO_SetRequestedMipmapLevel = "UnityEngine.Cubemap::set_requestedMipmapLevel";
    public const string MONO_SetPixelDataImpl = "UnityEngine.Cubemap::SetPixelDataImpl";
    public const string MONO_SetPixelDataImplArray = "UnityEngine.Cubemap::SetPixelDataImplArray";
    public const string MONO_SetPixelImplInjected = "UnityEngine.Cubemap::SetPixelImpl_Injected";
    public const string MONO_SetPixels = "UnityEngine.Cubemap::SetPixels";
    public const string MONO_SmoothEdges = "UnityEngine.Cubemap::SmoothEdges";
    public const string MONO_UpdateExternalTexture = "UnityEngine.Cubemap::UpdateExternalTexture";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Cubemap : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Cubemap(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Cubemap(nint ptr) => new Ptr_UnityEngine_Cubemap(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Cubemap ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Cubemap ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ApplyImpl = "UnityEngine.Cubemap::ApplyImpl(System.Boolean,System.Boolean)";
    public const string IL2CPP_get_isReadable = "UnityEngine.Cubemap::get_isReadable()";
    public const string IL2CPP_Internal_CreateImpl = "UnityEngine.Cubemap::Internal_CreateImpl(UnityEngine.Cubemap,System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngine.Experimental.Rendering.TextureCreationFlags,System.IntPtr)";
    public const string IL2CPP_SetPixelImpl_Injected = "UnityEngine.Cubemap::SetPixelImpl_Injected(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color&)";
}

