namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Cloth
{
    public const string MONO_ClearTransformMotion = "UnityEngine.Cloth::ClearTransformMotion";
    public const string MONO_GetBendingStiffness = "UnityEngine.Cloth::get_bendingStiffness";
    public const string MONO_GetCapsuleColliders = "UnityEngine.Cloth::get_capsuleColliders";
    public const string MONO_GetClothSolverFrequency = "UnityEngine.Cloth::get_clothSolverFrequency";
    public const string MONO_GetCoefficients = "UnityEngine.Cloth::get_coefficients";
    public const string MONO_GetCollisionMassScale = "UnityEngine.Cloth::get_collisionMassScale";
    public const string MONO_GetDamping = "UnityEngine.Cloth::get_damping";
    public const string MONO_GetEnableContinuousCollision = "UnityEngine.Cloth::get_enableContinuousCollision";
    public const string MONO_GetEnabled = "UnityEngine.Cloth::get_enabled";
    public const string MONO_GetExternalAccelerationInjected = "UnityEngine.Cloth::get_externalAcceleration_Injected";
    public const string MONO_GetFriction = "UnityEngine.Cloth::get_friction";
    public const string MONO_GetNormals = "UnityEngine.Cloth::get_normals";
    public const string MONO_GetRandomAccelerationInjected = "UnityEngine.Cloth::get_randomAcceleration_Injected";
    public const string MONO_GetSelfCollisionDistance = "UnityEngine.Cloth::get_selfCollisionDistance";
    public const string MONO_GetSelfCollisionStiffness = "UnityEngine.Cloth::get_selfCollisionStiffness";
    public const string MONO_GetSleepThreshold = "UnityEngine.Cloth::get_sleepThreshold";
    public const string MONO_GetSphereColliders = "UnityEngine.Cloth::get_sphereColliders";
    public const string MONO_GetStiffnessFrequency = "UnityEngine.Cloth::get_stiffnessFrequency";
    public const string MONO_GetStretchingStiffness = "UnityEngine.Cloth::get_stretchingStiffness";
    public const string MONO_GetUseGravity = "UnityEngine.Cloth::get_useGravity";
    public const string MONO_GetUseTethers = "UnityEngine.Cloth::get_useTethers";
    public const string MONO_GetUseVirtualParticles = "UnityEngine.Cloth::get_useVirtualParticles";
    public const string MONO_GetVertices = "UnityEngine.Cloth::get_vertices";
    public const string MONO_GetWorldAccelerationScale = "UnityEngine.Cloth::get_worldAccelerationScale";
    public const string MONO_GetWorldVelocityScale = "UnityEngine.Cloth::get_worldVelocityScale";
    public const string MONO_GetSelfAndInterCollisionIndices = "UnityEngine.Cloth::GetSelfAndInterCollisionIndices";
    public const string MONO_GetVirtualParticleIndices = "UnityEngine.Cloth::GetVirtualParticleIndices";
    public const string MONO_GetVirtualParticleWeights = "UnityEngine.Cloth::GetVirtualParticleWeights";
    public const string MONO_RaycastInjected = "UnityEngine.Cloth::Raycast_Injected";
    public const string MONO_SetBendingStiffness = "UnityEngine.Cloth::set_bendingStiffness";
    public const string MONO_SetCapsuleColliders = "UnityEngine.Cloth::set_capsuleColliders";
    public const string MONO_SetClothSolverFrequency = "UnityEngine.Cloth::set_clothSolverFrequency";
    public const string MONO_SetCoefficients = "UnityEngine.Cloth::set_coefficients";
    public const string MONO_SetCollisionMassScale = "UnityEngine.Cloth::set_collisionMassScale";
    public const string MONO_SetDamping = "UnityEngine.Cloth::set_damping";
    public const string MONO_SetEnableContinuousCollision = "UnityEngine.Cloth::set_enableContinuousCollision";
    public const string MONO_SetEnabled = "UnityEngine.Cloth::set_enabled";
    public const string MONO_SetExternalAccelerationInjected = "UnityEngine.Cloth::set_externalAcceleration_Injected";
    public const string MONO_SetFriction = "UnityEngine.Cloth::set_friction";
    public const string MONO_SetRandomAccelerationInjected = "UnityEngine.Cloth::set_randomAcceleration_Injected";
    public const string MONO_SetSelfCollisionDistance = "UnityEngine.Cloth::set_selfCollisionDistance";
    public const string MONO_SetSelfCollisionStiffness = "UnityEngine.Cloth::set_selfCollisionStiffness";
    public const string MONO_SetSleepThreshold = "UnityEngine.Cloth::set_sleepThreshold";
    public const string MONO_SetSphereColliders = "UnityEngine.Cloth::set_sphereColliders";
    public const string MONO_SetStiffnessFrequency = "UnityEngine.Cloth::set_stiffnessFrequency";
    public const string MONO_SetStretchingStiffness = "UnityEngine.Cloth::set_stretchingStiffness";
    public const string MONO_SetUseGravity = "UnityEngine.Cloth::set_useGravity";
    public const string MONO_SetUseTethers = "UnityEngine.Cloth::set_useTethers";
    public const string MONO_SetUseVirtualParticles = "UnityEngine.Cloth::set_useVirtualParticles";
    public const string MONO_SetWorldAccelerationScale = "UnityEngine.Cloth::set_worldAccelerationScale";
    public const string MONO_SetWorldVelocityScale = "UnityEngine.Cloth::set_worldVelocityScale";
    public const string MONO_SetEnabledFading = "UnityEngine.Cloth::SetEnabledFading";
    public const string MONO_SetSelfAndInterCollisionIndices = "UnityEngine.Cloth::SetSelfAndInterCollisionIndices";
    public const string MONO_SetVirtualParticleIndices = "UnityEngine.Cloth::SetVirtualParticleIndices";
    public const string MONO_SetVirtualParticleWeights = "UnityEngine.Cloth::SetVirtualParticleWeights";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Cloth : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Cloth(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Cloth(nint ptr) => new Ptr_UnityEngine_Cloth(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Cloth ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Cloth ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
