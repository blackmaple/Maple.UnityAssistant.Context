namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_JsonUtility
{
    public const string MONO_FromJsonInternal = "UnityEngine.JsonUtility::FromJsonInternal";
    public const string MONO_ToJsonInternal = "UnityEngine.JsonUtility::ToJsonInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_JsonUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_JsonUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_JsonUtility(nint ptr) => new Ptr_UnityEngine_JsonUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_JsonUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_JsonUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_FromJsonInternal = "UnityEngine.JsonUtility::FromJsonInternal(System.String,System.Object,System.Type)";
    public const string IL2CPP_ToJsonInternal = "UnityEngine.JsonUtility::ToJsonInternal(System.Object,System.Boolean)";
}

