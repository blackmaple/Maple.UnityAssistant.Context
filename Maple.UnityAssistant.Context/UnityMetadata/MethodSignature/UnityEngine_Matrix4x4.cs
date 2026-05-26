namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Matrix4x4
{
    public const string MONO_DecomposeProjectionInjected = "UnityEngine.Matrix4x4::DecomposeProjection_Injected";
    public const string MONO_FrustumInjected = "UnityEngine.Matrix4x4::Frustum_Injected";
    public const string MONO_GetDeterminantInjected = "UnityEngine.Matrix4x4::GetDeterminant_Injected";
    public const string MONO_GetLossyScaleInjected = "UnityEngine.Matrix4x4::GetLossyScale_Injected";
    public const string MONO_GetRotationInjected = "UnityEngine.Matrix4x4::GetRotation_Injected";
    public const string MONO_InverseInjected = "UnityEngine.Matrix4x4::Inverse_Injected";
    public const string MONO_Inverse3DaffineInjected = "UnityEngine.Matrix4x4::Inverse3DAffine_Injected";
    public const string MONO_IsIdentityInjected = "UnityEngine.Matrix4x4::IsIdentity_Injected";
    public const string MONO_LookAtInjected = "UnityEngine.Matrix4x4::LookAt_Injected";
    public const string MONO_OrthoInjected = "UnityEngine.Matrix4x4::Ortho_Injected";
    public const string MONO_PerspectiveInjected = "UnityEngine.Matrix4x4::Perspective_Injected";
    public const string MONO_TransposeInjected = "UnityEngine.Matrix4x4::Transpose_Injected";
    public const string MONO_TrsInjected = "UnityEngine.Matrix4x4::TRS_Injected";
    public const string MONO_ValidTrsInjected = "UnityEngine.Matrix4x4::ValidTRS_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Matrix4x4 : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Matrix4x4(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Matrix4x4(nint ptr) => new Ptr_UnityEngine_Matrix4x4(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Matrix4x4 ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Matrix4x4 ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DecomposeProjection_Injected = "UnityEngine.Matrix4x4::DecomposeProjection_Injected(UnityEngine.Matrix4x4&,UnityEngine.FrustumPlanes&)";
    public const string IL2CPP_Frustum_Injected = "UnityEngine.Matrix4x4::Frustum_Injected(System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GetDeterminant_Injected = "UnityEngine.Matrix4x4::GetDeterminant_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GetLossyScale_Injected = "UnityEngine.Matrix4x4::GetLossyScale_Injected(UnityEngine.Matrix4x4&,UnityEngine.Vector3&)";
    public const string IL2CPP_GetRotation_Injected = "UnityEngine.Matrix4x4::GetRotation_Injected(UnityEngine.Matrix4x4&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Inverse_Injected = "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_Inverse3DAffine_Injected = "UnityEngine.Matrix4x4::Inverse3DAffine_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_IsIdentity_Injected = "UnityEngine.Matrix4x4::IsIdentity_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_LookAt_Injected = "UnityEngine.Matrix4x4::LookAt_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_Ortho_Injected = "UnityEngine.Matrix4x4::Ortho_Injected(System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_Perspective_Injected = "UnityEngine.Matrix4x4::Perspective_Injected(System.Single,System.Single,System.Single,System.Single,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_Transpose_Injected = "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_TRS_Injected = "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_ValidTRS_Injected = "UnityEngine.Matrix4x4::ValidTRS_Injected(UnityEngine.Matrix4x4&)";
}

