namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundleRequest
{
    public const string MONO_GetAllAssets = "UnityEngine.AssetBundleRequest::get_allAssets";
    public const string MONO_GetResult = "UnityEngine.AssetBundleRequest::GetResult";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundleRequest : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundleRequest(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundleRequest(nint ptr) => new Ptr_UnityEngine_AssetBundleRequest(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundleRequest ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundleRequest ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetResult = "UnityEngine.AssetBundleRequest::GetResult()";
}

