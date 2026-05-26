namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PhysicsScene
{
    public const string MONO_InternalBoxCastNonAllocInjected = "UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected";
    public const string MONO_InternalCapsuleCastNonAllocInjected = "UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected";
    public const string MONO_InternalRaycastInjected = "UnityEngine.PhysicsScene::Internal_Raycast_Injected";
    public const string MONO_InternalRaycastNonAllocInjected = "UnityEngine.PhysicsScene::Internal_RaycastNonAlloc_Injected";
    public const string MONO_InternalRaycastTestInjected = "UnityEngine.PhysicsScene::Internal_RaycastTest_Injected";
    public const string MONO_InternalSphereCastNonAllocInjected = "UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected";
    public const string MONO_IsEmptyInternalInjected = "UnityEngine.PhysicsScene::IsEmpty_Internal_Injected";
    public const string MONO_IsValidInternalInjected = "UnityEngine.PhysicsScene::IsValid_Internal_Injected";
    public const string MONO_OverlapBoxNonAllocInternalInjected = "UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected";
    public const string MONO_OverlapCapsuleNonAllocInternalInjected = "UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected";
    public const string MONO_OverlapSphereNonAllocInternalInjected = "UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected";
    public const string MONO_QueryBoxCastInjected = "UnityEngine.PhysicsScene::Query_BoxCast_Injected";
    public const string MONO_QueryCapsuleCastInjected = "UnityEngine.PhysicsScene::Query_CapsuleCast_Injected";
    public const string MONO_QuerySphereCastInjected = "UnityEngine.PhysicsScene::Query_SphereCast_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PhysicsScene : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PhysicsScene(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PhysicsScene(nint ptr) => new Ptr_UnityEngine_PhysicsScene(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PhysicsScene ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PhysicsScene ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_BoxCastNonAlloc_Injected = "UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.RaycastHit[],UnityEngine.Quaternion&,System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Internal_CapsuleCastNonAlloc_Injected = "UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&,UnityEngine.RaycastHit[],System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Internal_Raycast_Injected = "UnityEngine.PhysicsScene::Internal_Raycast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Internal_RaycastNonAlloc_Injected = "UnityEngine.PhysicsScene::Internal_RaycastNonAlloc_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,UnityEngine.RaycastHit[],System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Internal_RaycastTest_Injected = "UnityEngine.PhysicsScene::Internal_RaycastTest_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Internal_SphereCastNonAlloc_Injected = "UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&,UnityEngine.RaycastHit[],System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_OverlapBoxNonAlloc_Internal_Injected = "UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Collider[],UnityEngine.Quaternion&,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_OverlapCapsuleNonAlloc_Internal_Injected = "UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,UnityEngine.Collider[],System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_OverlapSphereNonAlloc_Internal_Injected = "UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,System.Single,UnityEngine.Collider[],System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Query_BoxCast_Injected = "UnityEngine.PhysicsScene::Query_BoxCast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Quaternion&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Query_CapsuleCast_Injected = "UnityEngine.PhysicsScene::Query_CapsuleCast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)";
    public const string IL2CPP_Query_SphereCast_Injected = "UnityEngine.PhysicsScene::Query_SphereCast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Vector3&,System.Single,UnityEngine.Vector3&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)";
}

