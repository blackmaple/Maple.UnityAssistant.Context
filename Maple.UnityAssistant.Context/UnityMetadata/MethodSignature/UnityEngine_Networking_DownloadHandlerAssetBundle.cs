namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_DownloadHandlerAssetBundle
{
    public const string MONO_Create = "UnityEngine.Networking.DownloadHandlerAssetBundle::Create";
    public const string MONO_CreateCachedInjected = "UnityEngine.Networking.DownloadHandlerAssetBundle::CreateCached_Injected";
    public const string MONO_GetAssetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_assetBundle";
    public const string MONO_GetAutoLoadAssetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_autoLoadAssetBundle";
    public const string MONO_GetIsDownloadComplete = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_isDownloadComplete";
    public const string MONO_SetAutoLoadAssetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::set_autoLoadAssetBundle";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle(nint ptr) => new Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_DownloadHandlerAssetBundle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Create = "UnityEngine.Networking.DownloadHandlerAssetBundle::Create(UnityEngine.Networking.DownloadHandlerAssetBundle,System.String,System.UInt32)";
    public const string IL2CPP_CreateCached_Injected = "UnityEngine.Networking.DownloadHandlerAssetBundle::CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle,System.String,System.String,UnityEngine.Hash128&,System.UInt32)";
    public const string IL2CPP_get_assetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_assetBundle()";
    public const string IL2CPP_get_autoLoadAssetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_autoLoadAssetBundle()";
    public const string IL2CPP_get_isDownloadComplete = "UnityEngine.Networking.DownloadHandlerAssetBundle::get_isDownloadComplete()";
    public const string IL2CPP_set_autoLoadAssetBundle = "UnityEngine.Networking.DownloadHandlerAssetBundle::set_autoLoadAssetBundle(System.Boolean)";
}

