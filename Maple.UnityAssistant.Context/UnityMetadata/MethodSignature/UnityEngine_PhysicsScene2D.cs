namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PhysicsScene2D
{
    public const string MONO_BoxCastInternalInjected = "UnityEngine.PhysicsScene2D::BoxCast_Internal_Injected";
    public const string MONO_BoxCastArrayInternalInjected = "UnityEngine.PhysicsScene2D::BoxCastArray_Internal_Injected";
    public const string MONO_BoxCastListInternalInjected = "UnityEngine.PhysicsScene2D::BoxCastList_Internal_Injected";
    public const string MONO_CapsuleCastInternalInjected = "UnityEngine.PhysicsScene2D::CapsuleCast_Internal_Injected";
    public const string MONO_CapsuleCastArrayInternalInjected = "UnityEngine.PhysicsScene2D::CapsuleCastArray_Internal_Injected";
    public const string MONO_CapsuleCastListInternalInjected = "UnityEngine.PhysicsScene2D::CapsuleCastList_Internal_Injected";
    public const string MONO_CircleCastInternalInjected = "UnityEngine.PhysicsScene2D::CircleCast_Internal_Injected";
    public const string MONO_CircleCastArrayInternalInjected = "UnityEngine.PhysicsScene2D::CircleCastArray_Internal_Injected";
    public const string MONO_CircleCastListInternalInjected = "UnityEngine.PhysicsScene2D::CircleCastList_Internal_Injected";
    public const string MONO_GetRayIntersectionInternalInjected = "UnityEngine.PhysicsScene2D::GetRayIntersection_Internal_Injected";
    public const string MONO_GetRayIntersectionArrayInternalInjected = "UnityEngine.PhysicsScene2D::GetRayIntersectionArray_Internal_Injected";
    public const string MONO_GetRayIntersectionListInternalInjected = "UnityEngine.PhysicsScene2D::GetRayIntersectionList_Internal_Injected";
    public const string MONO_IsEmptyInternalInjected = "UnityEngine.PhysicsScene2D::IsEmpty_Internal_Injected";
    public const string MONO_IsValidInternalInjected = "UnityEngine.PhysicsScene2D::IsValid_Internal_Injected";
    public const string MONO_LinecastInternalInjected = "UnityEngine.PhysicsScene2D::Linecast_Internal_Injected";
    public const string MONO_LinecastArrayInternalInjected = "UnityEngine.PhysicsScene2D::LinecastArray_Internal_Injected";
    public const string MONO_LinecastNonAllocListInternalInjected = "UnityEngine.PhysicsScene2D::LinecastNonAllocList_Internal_Injected";
    public const string MONO_OverlapBoxInternalInjected = "UnityEngine.PhysicsScene2D::OverlapBox_Internal_Injected";
    public const string MONO_OverlapBoxArrayInternalInjected = "UnityEngine.PhysicsScene2D::OverlapBoxArray_Internal_Injected";
    public const string MONO_OverlapBoxListInternalInjected = "UnityEngine.PhysicsScene2D::OverlapBoxList_Internal_Injected";
    public const string MONO_OverlapCapsuleInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCapsule_Internal_Injected";
    public const string MONO_OverlapCapsuleArrayInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCapsuleArray_Internal_Injected";
    public const string MONO_OverlapCapsuleListInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCapsuleList_Internal_Injected";
    public const string MONO_OverlapCircleInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCircle_Internal_Injected";
    public const string MONO_OverlapCircleArrayInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCircleArray_Internal_Injected";
    public const string MONO_OverlapCircleListInternalInjected = "UnityEngine.PhysicsScene2D::OverlapCircleList_Internal_Injected";
    public const string MONO_OverlapColliderArrayInternalInjected = "UnityEngine.PhysicsScene2D::OverlapColliderArray_Internal_Injected";
    public const string MONO_OverlapColliderListInternalInjected = "UnityEngine.PhysicsScene2D::OverlapColliderList_Internal_Injected";
    public const string MONO_OverlapPointInternalInjected = "UnityEngine.PhysicsScene2D::OverlapPoint_Internal_Injected";
    public const string MONO_OverlapPointArrayInternalInjected = "UnityEngine.PhysicsScene2D::OverlapPointArray_Internal_Injected";
    public const string MONO_OverlapPointListInternalInjected = "UnityEngine.PhysicsScene2D::OverlapPointList_Internal_Injected";
    public const string MONO_RaycastInternalInjected = "UnityEngine.PhysicsScene2D::Raycast_Internal_Injected";
    public const string MONO_RaycastArrayInternalInjected = "UnityEngine.PhysicsScene2D::RaycastArray_Internal_Injected";
    public const string MONO_RaycastListInternalInjected = "UnityEngine.PhysicsScene2D::RaycastList_Internal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PhysicsScene2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PhysicsScene2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PhysicsScene2D(nint ptr) => new Ptr_UnityEngine_PhysicsScene2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PhysicsScene2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PhysicsScene2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_BoxCast_Internal_Injected = "UnityEngine.PhysicsScene2D::BoxCast_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_BoxCastArray_Internal_Injected = "UnityEngine.PhysicsScene2D::BoxCastArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_BoxCastList_Internal_Injected = "UnityEngine.PhysicsScene2D::BoxCastList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_CapsuleCast_Internal_Injected = "UnityEngine.PhysicsScene2D::CapsuleCast_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_CapsuleCastArray_Internal_Injected = "UnityEngine.PhysicsScene2D::CapsuleCastArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_CapsuleCastList_Internal_Injected = "UnityEngine.PhysicsScene2D::CapsuleCastList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_CircleCast_Internal_Injected = "UnityEngine.PhysicsScene2D::CircleCast_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_CircleCastArray_Internal_Injected = "UnityEngine.PhysicsScene2D::CircleCastArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_CircleCastList_Internal_Injected = "UnityEngine.PhysicsScene2D::CircleCastList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_GetRayIntersection_Internal_Injected = "UnityEngine.PhysicsScene2D::GetRayIntersection_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,System.Int32,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_GetRayIntersectionArray_Internal_Injected = "UnityEngine.PhysicsScene2D::GetRayIntersectionArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,System.Int32,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_Linecast_Internal_Injected = "UnityEngine.PhysicsScene2D::Linecast_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_LinecastArray_Internal_Injected = "UnityEngine.PhysicsScene2D::LinecastArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_LinecastNonAllocList_Internal_Injected = "UnityEngine.PhysicsScene2D::LinecastNonAllocList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
    public const string IL2CPP_OverlapBox_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapBox_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_OverlapBoxArray_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapBoxArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.Collider2D[])";
    public const string IL2CPP_OverlapBoxList_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapBoxList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.Collider2D>)";
    public const string IL2CPP_OverlapCapsule_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCapsule_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_OverlapCapsuleArray_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCapsuleArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.Collider2D[])";
    public const string IL2CPP_OverlapCapsuleList_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCapsuleList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,UnityEngine.CapsuleDirection2D,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.Collider2D>)";
    public const string IL2CPP_OverlapCircle_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCircle_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_OverlapCircleArray_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCircleArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.Collider2D[])";
    public const string IL2CPP_OverlapCircleList_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapCircleList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.Collider2D>)";
    public const string IL2CPP_OverlapColliderArray_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapColliderArray_Internal_Injected(UnityEngine.Collider2D,UnityEngine.ContactFilter2D&,UnityEngine.Collider2D[])";
    public const string IL2CPP_OverlapColliderList_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapColliderList_Internal_Injected(UnityEngine.Collider2D,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.Collider2D>)";
    public const string IL2CPP_OverlapPoint_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapPoint_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&)";
    public const string IL2CPP_OverlapPointArray_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapPointArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&,UnityEngine.Collider2D[])";
    public const string IL2CPP_OverlapPointList_Internal_Injected = "UnityEngine.PhysicsScene2D::OverlapPointList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.Collider2D>)";
    public const string IL2CPP_Raycast_Internal_Injected = "UnityEngine.PhysicsScene2D::Raycast_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D&)";
    public const string IL2CPP_RaycastArray_Internal_Injected = "UnityEngine.PhysicsScene2D::RaycastArray_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,UnityEngine.RaycastHit2D[])";
    public const string IL2CPP_RaycastList_Internal_Injected = "UnityEngine.PhysicsScene2D::RaycastList_Internal_Injected(UnityEngine.PhysicsScene2D&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,UnityEngine.ContactFilter2D&,System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)";
}

