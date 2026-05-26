namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SphereCollider
{
    public const string MONO_GetCenterInjected = "UnityEngine.SphereCollider::get_center_Injected";
    public const string MONO_GetRadius = "UnityEngine.SphereCollider::get_radius";
    public const string MONO_SetCenterInjected = "UnityEngine.SphereCollider::set_center_Injected";
    public const string MONO_SetRadius = "UnityEngine.SphereCollider::set_radius";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SphereCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SphereCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SphereCollider(nint ptr) => new Ptr_UnityEngine_SphereCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SphereCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SphereCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_center_Injected = "UnityEngine.SphereCollider::get_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_radius = "UnityEngine.SphereCollider::get_radius()";
    public const string IL2CPP_set_center_Injected = "UnityEngine.SphereCollider::set_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_radius = "UnityEngine.SphereCollider::set_radius(System.Single)";
}

