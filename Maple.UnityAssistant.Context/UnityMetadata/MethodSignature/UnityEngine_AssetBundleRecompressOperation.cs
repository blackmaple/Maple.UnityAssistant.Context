namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AssetBundleRecompressOperation
{
    public const string MONO_GetHumanReadableResult = "UnityEngine.AssetBundleRecompressOperation::get_humanReadableResult";
    public const string MONO_GetInputPath = "UnityEngine.AssetBundleRecompressOperation::get_inputPath";
    public const string MONO_GetOutputPath = "UnityEngine.AssetBundleRecompressOperation::get_outputPath";
    public const string MONO_GetResult = "UnityEngine.AssetBundleRecompressOperation::get_result";
    public const string MONO_GetSuccess = "UnityEngine.AssetBundleRecompressOperation::get_success";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AssetBundleRecompressOperation : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AssetBundleRecompressOperation(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AssetBundleRecompressOperation(nint ptr) => new Ptr_UnityEngine_AssetBundleRecompressOperation(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AssetBundleRecompressOperation ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AssetBundleRecompressOperation ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
