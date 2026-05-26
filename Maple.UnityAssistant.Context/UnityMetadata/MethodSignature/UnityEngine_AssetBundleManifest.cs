namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundleManifest
{
    public const string MONO_GetAllAssetBundles = "UnityEngine.AssetBundleManifest::GetAllAssetBundles";
    public const string MONO_GetAllAssetBundlesWithVariant = "UnityEngine.AssetBundleManifest::GetAllAssetBundlesWithVariant";
    public const string MONO_GetAllDependencies = "UnityEngine.AssetBundleManifest::GetAllDependencies";
    public const string MONO_GetAssetBundleHashInjected = "UnityEngine.AssetBundleManifest::GetAssetBundleHash_Injected";
    public const string MONO_GetDirectDependencies = "UnityEngine.AssetBundleManifest::GetDirectDependencies";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundleManifest : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundleManifest(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundleManifest(nint ptr) => new Ptr_UnityEngine_AssetBundleManifest(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundleManifest ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundleManifest ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetAllDependencies = "UnityEngine.AssetBundleManifest::GetAllDependencies(System.String)";
    public const string IL2CPP_GetAssetBundleHash_Injected = "UnityEngine.AssetBundleManifest::GetAssetBundleHash_Injected(System.String,UnityEngine.Hash128&)";
}

