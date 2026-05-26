namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Caching
{
    public const string MONO_AddCacheInjected = "UnityEngine.Caching::AddCache_Injected";
    public const string MONO_ClearCache = "UnityEngine.Caching::ClearCache";
    public const string MONO_ClearCacheInt = "UnityEngine.Caching::ClearCache_Int";
    public const string MONO_ClearCachedVersionInternalInjected = "UnityEngine.Caching::ClearCachedVersionInternal_Injected";
    public const string MONO_ClearCachedVersionsInjected = "UnityEngine.Caching::ClearCachedVersions_Injected";
    public const string MONO_GetCacheCount = "UnityEngine.Caching::get_cacheCount";
    public const string MONO_GetCompressionEnabled = "UnityEngine.Caching::get_compressionEnabled";
    public const string MONO_GetCurrentCacheForWritingInjected = "UnityEngine.Caching::get_currentCacheForWriting_Injected";
    public const string MONO_GetDefaultCacheInjected = "UnityEngine.Caching::get_defaultCache_Injected";
    public const string MONO_GetExpirationDelay = "UnityEngine.Caching::get_expirationDelay";
    public const string MONO_GetMaximumAvailableDiskSpace = "UnityEngine.Caching::get_maximumAvailableDiskSpace";
    public const string MONO_GetReady = "UnityEngine.Caching::get_ready";
    public const string MONO_GetSpaceFree = "UnityEngine.Caching::get_spaceFree";
    public const string MONO_GetSpaceOccupied = "UnityEngine.Caching::get_spaceOccupied";
    public const string MONO_GetCacheAtInjected = "UnityEngine.Caching::GetCacheAt_Injected";
    public const string MONO_GetCacheByPathInjected = "UnityEngine.Caching::GetCacheByPath_Injected";
    public const string MONO_GetCachedVersions = "UnityEngine.Caching::GetCachedVersions";
    public const string MONO_IsVersionCachedInjected = "UnityEngine.Caching::IsVersionCached_Injected";
    public const string MONO_MarkAsUsedInjected = "UnityEngine.Caching::MarkAsUsed_Injected";
    public const string MONO_MoveCacheAfterInjected = "UnityEngine.Caching::MoveCacheAfter_Injected";
    public const string MONO_MoveCacheBeforeInjected = "UnityEngine.Caching::MoveCacheBefore_Injected";
    public const string MONO_RemoveCacheInjected = "UnityEngine.Caching::RemoveCache_Injected";
    public const string MONO_SetCompressionEnabled = "UnityEngine.Caching::set_compressionEnabled";
    public const string MONO_SetCurrentCacheForWritingInjected = "UnityEngine.Caching::set_currentCacheForWriting_Injected";
    public const string MONO_SetExpirationDelay = "UnityEngine.Caching::set_expirationDelay";
    public const string MONO_SetMaximumAvailableDiskSpace = "UnityEngine.Caching::set_maximumAvailableDiskSpace";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Caching : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Caching(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Caching(nint ptr) => new Ptr_UnityEngine_Caching(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Caching ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Caching ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
