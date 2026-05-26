namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TextAsset
{
    public const string MONO_GetBytes = "UnityEngine.TextAsset::get_bytes";
    public const string MONO_GetDataPtr = "UnityEngine.TextAsset::GetDataPtr";
    public const string MONO_GetDataSize = "UnityEngine.TextAsset::GetDataSize";
    public const string MONO_GetPreviewBytes = "UnityEngine.TextAsset::GetPreviewBytes";
    public const string MONO_InternalCreateInstance = "UnityEngine.TextAsset::Internal_CreateInstance";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TextAsset : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TextAsset(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TextAsset(nint ptr) => new Ptr_UnityEngine_TextAsset(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TextAsset ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TextAsset ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_bytes = "UnityEngine.TextAsset::get_bytes()";
    public const string IL2CPP_GetDataPtr = "UnityEngine.TextAsset::GetDataPtr()";
    public const string IL2CPP_GetDataSize = "UnityEngine.TextAsset::GetDataSize()";
    public const string IL2CPP_GetPreviewBytes = "UnityEngine.TextAsset::GetPreviewBytes(System.Int32)";
    public const string IL2CPP_Internal_CreateInstance = "UnityEngine.TextAsset::Internal_CreateInstance(UnityEngine.TextAsset,System.String)";
}

