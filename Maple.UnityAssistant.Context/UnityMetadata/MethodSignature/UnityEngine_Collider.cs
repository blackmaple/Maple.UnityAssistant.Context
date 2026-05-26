namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Collider
{
    public const string MONO_ClosestPointInjected = "UnityEngine.Collider::ClosestPoint_Injected";
    public const string MONO_GetAttachedArticulationBody = "UnityEngine.Collider::get_attachedArticulationBody";
    public const string MONO_GetAttachedRigidbody = "UnityEngine.Collider::get_attachedRigidbody";
    public const string MONO_GetBoundsInjected = "UnityEngine.Collider::get_bounds_Injected";
    public const string MONO_GetContactOffset = "UnityEngine.Collider::get_contactOffset";
    public const string MONO_GetEnabled = "UnityEngine.Collider::get_enabled";
    public const string MONO_GetHasModifiableContacts = "UnityEngine.Collider::get_hasModifiableContacts";
    public const string MONO_GetIsTrigger = "UnityEngine.Collider::get_isTrigger";
    public const string MONO_GetMaterial = "UnityEngine.Collider::get_material";
    public const string MONO_GetSharedMaterial = "UnityEngine.Collider::get_sharedMaterial";
    public const string MONO_InternalClosestPointOnBoundsInjected = "UnityEngine.Collider::Internal_ClosestPointOnBounds_Injected";
    public const string MONO_RaycastInjected = "UnityEngine.Collider::Raycast_Injected";
    public const string MONO_SetContactOffset = "UnityEngine.Collider::set_contactOffset";
    public const string MONO_SetEnabled = "UnityEngine.Collider::set_enabled";
    public const string MONO_SetHasModifiableContacts = "UnityEngine.Collider::set_hasModifiableContacts";
    public const string MONO_SetIsTrigger = "UnityEngine.Collider::set_isTrigger";
    public const string MONO_SetMaterial = "UnityEngine.Collider::set_material";
    public const string MONO_SetSharedMaterial = "UnityEngine.Collider::set_sharedMaterial";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Collider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Collider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Collider(nint ptr) => new Ptr_UnityEngine_Collider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Collider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Collider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ClosestPoint_Injected = "UnityEngine.Collider::ClosestPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_get_attachedArticulationBody = "UnityEngine.Collider::get_attachedArticulationBody()";
    public const string IL2CPP_get_attachedRigidbody = "UnityEngine.Collider::get_attachedRigidbody()";
    public const string IL2CPP_get_bounds_Injected = "UnityEngine.Collider::get_bounds_Injected(UnityEngine.Bounds&)";
    public const string IL2CPP_get_contactOffset = "UnityEngine.Collider::get_contactOffset()";
    public const string IL2CPP_get_enabled = "UnityEngine.Collider::get_enabled()";
    public const string IL2CPP_get_isTrigger = "UnityEngine.Collider::get_isTrigger()";
    public const string IL2CPP_get_sharedMaterial = "UnityEngine.Collider::get_sharedMaterial()";
    public const string IL2CPP_Raycast_Injected = "UnityEngine.Collider::Raycast_Injected(UnityEngine.Ray&,System.Single,System.Boolean&,UnityEngine.RaycastHit&)";
    public const string IL2CPP_set_contactOffset = "UnityEngine.Collider::set_contactOffset(System.Single)";
    public const string IL2CPP_set_enabled = "UnityEngine.Collider::set_enabled(System.Boolean)";
    public const string IL2CPP_set_isTrigger = "UnityEngine.Collider::set_isTrigger(System.Boolean)";
    public const string IL2CPP_set_sharedMaterial = "UnityEngine.Collider::set_sharedMaterial(UnityEngine.PhysicMaterial)";
}

