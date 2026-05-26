namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundle
{
    public const string MONO_Contains = "UnityEngine.AssetBundle::Contains";
    public const string MONO_GetIsStreamedSceneAssetBundle = "UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle";
    public const string MONO_GetAllAssetNames = "UnityEngine.AssetBundle::GetAllAssetNames";
    public const string MONO_GetAllLoadedAssetBundlesNative = "UnityEngine.AssetBundle::GetAllLoadedAssetBundles_Native";
    public const string MONO_GetAllScenePaths = "UnityEngine.AssetBundle::GetAllScenePaths";
    public const string MONO_LoadAssetInternal = "UnityEngine.AssetBundle::LoadAsset_Internal";
    public const string MONO_LoadAssetAsyncInternal = "UnityEngine.AssetBundle::LoadAssetAsync_Internal";
    public const string MONO_LoadAssetWithSubAssetsInternal = "UnityEngine.AssetBundle::LoadAssetWithSubAssets_Internal";
    public const string MONO_LoadAssetWithSubAssetsAsyncInternal = "UnityEngine.AssetBundle::LoadAssetWithSubAssetsAsync_Internal";
    public const string MONO_LoadFromFileInternal = "UnityEngine.AssetBundle::LoadFromFile_Internal";
    public const string MONO_LoadFromFileAsyncInternal = "UnityEngine.AssetBundle::LoadFromFileAsync_Internal";
    public const string MONO_LoadFromMemoryInternal = "UnityEngine.AssetBundle::LoadFromMemory_Internal";
    public const string MONO_LoadFromMemoryAsyncInternal = "UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal";
    public const string MONO_LoadFromStreamAsyncInternal = "UnityEngine.AssetBundle::LoadFromStreamAsyncInternal";
    public const string MONO_LoadFromStreamInternal = "UnityEngine.AssetBundle::LoadFromStreamInternal";
    public const string MONO_RecompressAssetBundleAsyncInternalInjected = "UnityEngine.AssetBundle::RecompressAssetBundleAsync_Internal_Injected";
    public const string MONO_ReturnMainAsset = "UnityEngine.AssetBundle::returnMainAsset";
    public const string MONO_SetAssetBundleDecryptKey = "UnityEngine.AssetBundle::SetAssetBundleDecryptKey";
    public const string MONO_Unload = "UnityEngine.AssetBundle::Unload";
    public const string MONO_UnloadAllAssetBundles = "UnityEngine.AssetBundle::UnloadAllAssetBundles";
    public const string MONO_UnloadAsync = "UnityEngine.AssetBundle::UnloadAsync";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundle(nint ptr) => new Ptr_UnityEngine_AssetBundle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Contains = "UnityEngine.AssetBundle::Contains(System.String)";
    public const string IL2CPP_get_isStreamedSceneAssetBundle = "UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle()";
    public const string IL2CPP_GetAllAssetNames = "UnityEngine.AssetBundle::GetAllAssetNames()";
    public const string IL2CPP_GetAllLoadedAssetBundles_Native = "UnityEngine.AssetBundle::GetAllLoadedAssetBundles_Native()";
    public const string IL2CPP_GetAllScenePaths = "UnityEngine.AssetBundle::GetAllScenePaths()";
    public const string IL2CPP_LoadAsset_Internal = "UnityEngine.AssetBundle::LoadAsset_Internal(System.String,System.Type)";
    public const string IL2CPP_LoadAssetAsync_Internal = "UnityEngine.AssetBundle::LoadAssetAsync_Internal(System.String,System.Type)";
    public const string IL2CPP_LoadAssetWithSubAssets_Internal = "UnityEngine.AssetBundle::LoadAssetWithSubAssets_Internal(System.String,System.Type)";
    public const string IL2CPP_LoadAssetWithSubAssetsAsync_Internal = "UnityEngine.AssetBundle::LoadAssetWithSubAssetsAsync_Internal(System.String,System.Type)";
    public const string IL2CPP_LoadFromFile_Internal = "UnityEngine.AssetBundle::LoadFromFile_Internal(System.String,System.UInt32,System.UInt64)";
    public const string IL2CPP_LoadFromFileAsync_Internal = "UnityEngine.AssetBundle::LoadFromFileAsync_Internal(System.String,System.UInt32,System.UInt64)";
    public const string IL2CPP_LoadFromMemory_Internal = "UnityEngine.AssetBundle::LoadFromMemory_Internal(System.Byte[],System.UInt32)";
    public const string IL2CPP_LoadFromMemoryAsync_Internal = "UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal(System.Byte[],System.UInt32)";
    public const string IL2CPP_LoadFromStreamAsyncInternal = "UnityEngine.AssetBundle::LoadFromStreamAsyncInternal(System.IO.Stream,System.UInt32,System.UInt32)";
    public const string IL2CPP_LoadFromStreamInternal = "UnityEngine.AssetBundle::LoadFromStreamInternal(System.IO.Stream,System.UInt32,System.UInt32)";
    public const string IL2CPP_RecompressAssetBundleAsync_Internal_Injected = "UnityEngine.AssetBundle::RecompressAssetBundleAsync_Internal_Injected(System.String,System.String,UnityEngine.BuildCompression&,System.UInt32,UnityEngine.ThreadPriority)";
    public const string IL2CPP_returnMainAsset = "UnityEngine.AssetBundle::returnMainAsset(UnityEngine.AssetBundle)";
    public const string IL2CPP_Unload = "UnityEngine.AssetBundle::Unload(System.Boolean)";
    public const string IL2CPP_UnloadAllAssetBundles = "UnityEngine.AssetBundle::UnloadAllAssetBundles(System.Boolean)";
    public const string IL2CPP_UnloadAsync = "UnityEngine.AssetBundle::UnloadAsync(System.Boolean)";
}

