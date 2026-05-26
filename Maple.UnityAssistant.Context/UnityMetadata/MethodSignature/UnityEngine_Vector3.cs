namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Vector3
{
    public const string MONO_OrthoNormalize2 = "UnityEngine.Vector3::OrthoNormalize2";
    public const string MONO_OrthoNormalize3 = "UnityEngine.Vector3::OrthoNormalize3";
    public const string MONO_RotateTowardsInjected = "UnityEngine.Vector3::RotateTowards_Injected";
    public const string MONO_SlerpInjected = "UnityEngine.Vector3::Slerp_Injected";
    public const string MONO_SlerpUnclampedInjected = "UnityEngine.Vector3::SlerpUnclamped_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Vector3 : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Vector3(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Vector3(nint ptr) => new Ptr_UnityEngine_Vector3(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Vector3 ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Vector3 ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_OrthoNormalize2 = "UnityEngine.Vector3::OrthoNormalize2(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_OrthoNormalize3 = "UnityEngine.Vector3::OrthoNormalize3(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_RotateTowards_Injected = "UnityEngine.Vector3::RotateTowards_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,System.Single,UnityEngine.Vector3&)";
    public const string IL2CPP_Slerp_Injected = "UnityEngine.Vector3::Slerp_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&)";
    public const string IL2CPP_SlerpUnclamped_Injected = "UnityEngine.Vector3::SlerpUnclamped_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&)";
}

