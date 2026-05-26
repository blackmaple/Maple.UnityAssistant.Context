namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Quaternion
{
    public const string MONO_AngleAxisInjected = "UnityEngine.Quaternion::AngleAxis_Injected";
    public const string MONO_FromToRotationInjected = "UnityEngine.Quaternion::FromToRotation_Injected";
    public const string MONO_InternalFromEulerRadInjected = "UnityEngine.Quaternion::Internal_FromEulerRad_Injected";
    public const string MONO_InternalToAxisAngleRadInjected = "UnityEngine.Quaternion::Internal_ToAxisAngleRad_Injected";
    public const string MONO_InternalToEulerRadInjected = "UnityEngine.Quaternion::Internal_ToEulerRad_Injected";
    public const string MONO_InverseInjected = "UnityEngine.Quaternion::Inverse_Injected";
    public const string MONO_LerpInjected = "UnityEngine.Quaternion::Lerp_Injected";
    public const string MONO_LerpUnclampedInjected = "UnityEngine.Quaternion::LerpUnclamped_Injected";
    public const string MONO_LookRotationInjected = "UnityEngine.Quaternion::LookRotation_Injected";
    public const string MONO_SlerpInjected = "UnityEngine.Quaternion::Slerp_Injected";
    public const string MONO_SlerpUnclampedInjected = "UnityEngine.Quaternion::SlerpUnclamped_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Quaternion : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Quaternion(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Quaternion(nint ptr) => new Ptr_UnityEngine_Quaternion(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Quaternion ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Quaternion ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AngleAxis_Injected = "UnityEngine.Quaternion::AngleAxis_Injected(System.Single,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Internal_FromEulerRad_Injected = "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Internal_ToAxisAngleRad_Injected = "UnityEngine.Quaternion::Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion&,UnityEngine.Vector3&,System.Single&)";
    public const string IL2CPP_Internal_ToEulerRad_Injected = "UnityEngine.Quaternion::Internal_ToEulerRad_Injected(UnityEngine.Quaternion&,UnityEngine.Vector3&)";
    public const string IL2CPP_Inverse_Injected = "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Lerp_Injected = "UnityEngine.Quaternion::Lerp_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)";
    public const string IL2CPP_LerpUnclamped_Injected = "UnityEngine.Quaternion::LerpUnclamped_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)";
    public const string IL2CPP_LookRotation_Injected = "UnityEngine.Quaternion::LookRotation_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Slerp_Injected = "UnityEngine.Quaternion::Slerp_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)";
    public const string IL2CPP_SlerpUnclamped_Injected = "UnityEngine.Quaternion::SlerpUnclamped_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)";
}

