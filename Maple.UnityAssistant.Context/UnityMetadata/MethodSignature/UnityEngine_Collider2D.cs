namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Collider2D
{
    public const string MONO_CastArrayInternalInjected = "UnityEngine.Collider2D::CastArray_Internal_Injected";
    public const string MONO_CastListInternalInjected = "UnityEngine.Collider2D::CastList_Internal_Injected";
    public const string MONO_CreateMesh = "UnityEngine.Collider2D::CreateMesh";
    public const string MONO_GetAttachedRigidbody = "UnityEngine.Collider2D::get_attachedRigidbody";
    public const string MONO_GetBounciness = "UnityEngine.Collider2D::get_bounciness";
    public const string MONO_GetBoundsInjected = "UnityEngine.Collider2D::get_bounds_Injected";
    public const string MONO_GetComposite = "UnityEngine.Collider2D::get_composite";
    public const string MONO_GetCompositeCapable = "UnityEngine.Collider2D::get_compositeCapable";
    public const string MONO_GetDensity = "UnityEngine.Collider2D::get_density";
    public const string MONO_GetErrorState = "UnityEngine.Collider2D::get_errorState";
    public const string MONO_GetFriction = "UnityEngine.Collider2D::get_friction";
    public const string MONO_GetIsTrigger = "UnityEngine.Collider2D::get_isTrigger";
    public const string MONO_GetOffsetInjected = "UnityEngine.Collider2D::get_offset_Injected";
    public const string MONO_GetShapeCount = "UnityEngine.Collider2D::get_shapeCount";
    public const string MONO_GetSharedMaterial = "UnityEngine.Collider2D::get_sharedMaterial";
    public const string MONO_GetUsedByComposite = "UnityEngine.Collider2D::get_usedByComposite";
    public const string MONO_GetUsedByEffector = "UnityEngine.Collider2D::get_usedByEffector";
    public const string MONO_GetShapeHash = "UnityEngine.Collider2D::GetShapeHash";
    public const string MONO_GetShapesInternal = "UnityEngine.Collider2D::GetShapes_Internal";
    public const string MONO_IsTouching = "UnityEngine.Collider2D::IsTouching";
    public const string MONO_IsTouchingAnyColliderWithFilterInjected = "UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected";
    public const string MONO_IsTouchingOtherColliderWithFilterInjected = "UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected";
    public const string MONO_IsTouchingLayers = "UnityEngine.Collider2D::IsTouchingLayers";
    public const string MONO_OverlapPointInjected = "UnityEngine.Collider2D::OverlapPoint_Injected";
    public const string MONO_RaycastArrayInternalInjected = "UnityEngine.Collider2D::RaycastArray_Internal_Injected";
    public const string MONO_RaycastListInternalInjected = "UnityEngine.Collider2D::RaycastList_Internal_Injected";
    public const string MONO_SetDensity = "UnityEngine.Collider2D::set_density";
    public const string MONO_SetIsTrigger = "UnityEngine.Collider2D::set_isTrigger";
    public const string MONO_SetOffsetInjected = "UnityEngine.Collider2D::set_offset_Injected";
    public const string MONO_SetSharedMaterial = "UnityEngine.Collider2D::set_sharedMaterial";
    public const string MONO_SetUsedByComposite = "UnityEngine.Collider2D::set_usedByComposite";
    public const string MONO_SetUsedByEffector = "UnityEngine.Collider2D::set_usedByEffector";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Collider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Collider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Collider2D(nint ptr) => new Ptr_UnityEngine_Collider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Collider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Collider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CastArray_Internal_Injected = "UnityEngine.Collider2D::CastArray_Internal_Injected(UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Boolean,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_CastList_Internal_Injected = "UnityEngine.Collider2D::CastList_Internal_Injected(UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Boolean,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_CreateMesh = "UnityEngine.Collider2D::CreateMesh(System.Boolean,System.Boolean)";
    public const string IL2CPP_get_attachedRigidbody = "UnityEngine.Collider2D::get_attachedRigidbody()";
    public const string IL2CPP_get_bounciness = "UnityEngine.Collider2D::get_bounciness()";
    public const string IL2CPP_get_bounds_Injected = "UnityEngine.Collider2D::get_bounds_Injected(UnityEngine.Bounds&)";
    public const string IL2CPP_get_composite = "UnityEngine.Collider2D::get_composite()";
    public const string IL2CPP_get_compositeCapable = "UnityEngine.Collider2D::get_compositeCapable()";
    public const string IL2CPP_get_density = "UnityEngine.Collider2D::get_density()";
    public const string IL2CPP_get_errorState = "UnityEngine.Collider2D::get_errorState()";
    public const string IL2CPP_get_friction = "UnityEngine.Collider2D::get_friction()";
    public const string IL2CPP_get_isTrigger = "UnityEngine.Collider2D::get_isTrigger()";
    public const string IL2CPP_get_offset_Injected = "UnityEngine.Collider2D::get_offset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_shapeCount = "UnityEngine.Collider2D::get_shapeCount()";
    public const string IL2CPP_get_sharedMaterial = "UnityEngine.Collider2D::get_sharedMaterial()";
    public const string IL2CPP_get_usedByComposite = "UnityEngine.Collider2D::get_usedByComposite()";
    public const string IL2CPP_get_usedByEffector = "UnityEngine.Collider2D::get_usedByEffector()";
    public const string IL2CPP_GetShapeHash = "UnityEngine.Collider2D::GetShapeHash()";
    public const string IL2CPP_GetShapes_Internal = "UnityEngine.Collider2D::GetShapes_Internal(UnityEngine.PhysicsShapeGroup2D/GroupState&,System.Int32,System.Int32)";
    public const string IL2CPP_IsTouching = "UnityEngine.Collider2D::IsTouching(UnityEngine.Collider2D)";
    public const string IL2CPP_IsTouching_AnyColliderWithFilter_Injected = "UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected(UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_IsTouching_OtherColliderWithFilter_Injected = "UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected(UnityEngine.Collider2D,UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_IsTouchingLayers = "UnityEngine.Collider2D::IsTouchingLayers(System.Int32)";
    public const string IL2CPP_OverlapPoint_Injected = "UnityEngine.Collider2D::OverlapPoint_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_RaycastArray_Internal_Injected = "UnityEngine.Collider2D::RaycastArray_Internal_Injected(UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_RaycastList_Internal_Injected = "UnityEngine.Collider2D::RaycastList_Internal_Injected(UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_set_density = "UnityEngine.Collider2D::set_density(System.Single)";
    public const string IL2CPP_set_isTrigger = "UnityEngine.Collider2D::set_isTrigger(System.Boolean)";
    public const string IL2CPP_set_offset_Injected = "UnityEngine.Collider2D::set_offset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_sharedMaterial = "UnityEngine.Collider2D::set_sharedMaterial(UnityEngine.PhysicsMaterial2D)";
    public const string IL2CPP_set_usedByComposite = "UnityEngine.Collider2D::set_usedByComposite(System.Boolean)";
    public const string IL2CPP_set_usedByEffector = "UnityEngine.Collider2D::set_usedByEffector(System.Boolean)";
}

