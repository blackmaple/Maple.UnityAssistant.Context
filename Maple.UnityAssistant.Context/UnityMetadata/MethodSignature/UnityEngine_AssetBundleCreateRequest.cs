namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundleCreateRequest
{
    public const string MONO_GetAssetBundle = "UnityEngine.AssetBundleCreateRequest::get_assetBundle";
    public const string MONO_SetEnableCompatibilityChecks = "UnityEngine.AssetBundleCreateRequest::SetEnableCompatibilityChecks";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundleCreateRequest : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundleCreateRequest(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundleCreateRequest(nint ptr) => new Ptr_UnityEngine_AssetBundleCreateRequest(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundleCreateRequest ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundleCreateRequest ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_assetBundle = "UnityEngine.AssetBundleCreateRequest::get_assetBundle()";
}

