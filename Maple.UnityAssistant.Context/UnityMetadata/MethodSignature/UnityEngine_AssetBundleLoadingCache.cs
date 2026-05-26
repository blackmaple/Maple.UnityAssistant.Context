namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundleLoadingCache
{
    public const string MONO_GetBlockCount = "UnityEngine.AssetBundleLoadingCache::get_blockCount";
    public const string MONO_GetBlockSize = "UnityEngine.AssetBundleLoadingCache::get_blockSize";
    public const string MONO_GetMaxBlocksPerFile = "UnityEngine.AssetBundleLoadingCache::get_maxBlocksPerFile";
    public const string MONO_SetBlockCount = "UnityEngine.AssetBundleLoadingCache::set_blockCount";
    public const string MONO_SetMaxBlocksPerFile = "UnityEngine.AssetBundleLoadingCache::set_maxBlocksPerFile";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundleLoadingCache : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundleLoadingCache(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundleLoadingCache(nint ptr) => new Ptr_UnityEngine_AssetBundleLoadingCache(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundleLoadingCache ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundleLoadingCache ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_blockCount = "UnityEngine.AssetBundleLoadingCache::get_blockCount()";
    public const string IL2CPP_get_blockSize = "UnityEngine.AssetBundleLoadingCache::get_blockSize()";
    public const string IL2CPP_get_maxBlocksPerFile = "UnityEngine.AssetBundleLoadingCache::get_maxBlocksPerFile()";
    public const string IL2CPP_set_blockCount = "UnityEngine.AssetBundleLoadingCache::set_blockCount(System.UInt32)";
    public const string IL2CPP_set_maxBlocksPerFile = "UnityEngine.AssetBundleLoadingCache::set_maxBlocksPerFile(System.UInt32)";
}

