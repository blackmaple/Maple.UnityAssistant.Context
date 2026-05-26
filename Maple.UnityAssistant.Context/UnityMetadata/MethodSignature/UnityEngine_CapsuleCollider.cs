namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CapsuleCollider
{
    public const string MONO_CalculateTransformInjected = "UnityEngine.CapsuleCollider::CalculateTransform_Injected";
    public const string MONO_GetCenterInjected = "UnityEngine.CapsuleCollider::get_center_Injected";
    public const string MONO_GetDirection = "UnityEngine.CapsuleCollider::get_direction";
    public const string MONO_GetHeight = "UnityEngine.CapsuleCollider::get_height";
    public const string MONO_GetRadius = "UnityEngine.CapsuleCollider::get_radius";
    public const string MONO_GetGlobalExtentsInjected = "UnityEngine.CapsuleCollider::GetGlobalExtents_Injected";
    public const string MONO_SetCenterInjected = "UnityEngine.CapsuleCollider::set_center_Injected";
    public const string MONO_SetDirection = "UnityEngine.CapsuleCollider::set_direction";
    public const string MONO_SetHeight = "UnityEngine.CapsuleCollider::set_height";
    public const string MONO_SetRadius = "UnityEngine.CapsuleCollider::set_radius";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CapsuleCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CapsuleCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CapsuleCollider(nint ptr) => new Ptr_UnityEngine_CapsuleCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CapsuleCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CapsuleCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_center_Injected = "UnityEngine.CapsuleCollider::get_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_direction = "UnityEngine.CapsuleCollider::get_direction()";
    public const string IL2CPP_get_height = "UnityEngine.CapsuleCollider::get_height()";
    public const string IL2CPP_get_radius = "UnityEngine.CapsuleCollider::get_radius()";
    public const string IL2CPP_set_center_Injected = "UnityEngine.CapsuleCollider::set_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_direction = "UnityEngine.CapsuleCollider::set_direction(System.Int32)";
    public const string IL2CPP_set_height = "UnityEngine.CapsuleCollider::set_height(System.Single)";
    public const string IL2CPP_set_radius = "UnityEngine.CapsuleCollider::set_radius(System.Single)";
}

