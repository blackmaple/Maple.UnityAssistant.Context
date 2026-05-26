namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Cache
{
    public const string MONO_CacheClearCache = "UnityEngine.Cache::Cache_ClearCache";
    public const string MONO_CacheClearCacheExpiration = "UnityEngine.Cache::Cache_ClearCache_Expiration";
    public const string MONO_CacheGetCachingDiskSpaceUsed = "UnityEngine.Cache::Cache_GetCachingDiskSpaceUsed";
    public const string MONO_CacheGetExpirationDelay = "UnityEngine.Cache::Cache_GetExpirationDelay";
    public const string MONO_CacheGetIndex = "UnityEngine.Cache::Cache_GetIndex";
    public const string MONO_CacheGetMaximumDiskSpaceAvailable = "UnityEngine.Cache::Cache_GetMaximumDiskSpaceAvailable";
    public const string MONO_CacheGetPath = "UnityEngine.Cache::Cache_GetPath";
    public const string MONO_CacheGetSpaceFree = "UnityEngine.Cache::Cache_GetSpaceFree";
    public const string MONO_CacheIsReadonly = "UnityEngine.Cache::Cache_IsReadonly";
    public const string MONO_CacheIsReady = "UnityEngine.Cache::Cache_IsReady";
    public const string MONO_CacheIsValid = "UnityEngine.Cache::Cache_IsValid";
    public const string MONO_CacheSetExpirationDelay = "UnityEngine.Cache::Cache_SetExpirationDelay";
    public const string MONO_CacheSetMaximumDiskSpaceAvailable = "UnityEngine.Cache::Cache_SetMaximumDiskSpaceAvailable";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Cache : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Cache(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Cache(nint ptr) => new Ptr_UnityEngine_Cache(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Cache ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Cache ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
