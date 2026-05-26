namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CharacterController
{
    public const string MONO_GetCenterInjected = "UnityEngine.CharacterController::get_center_Injected";
    public const string MONO_GetCollisionFlags = "UnityEngine.CharacterController::get_collisionFlags";
    public const string MONO_GetDetectCollisions = "UnityEngine.CharacterController::get_detectCollisions";
    public const string MONO_GetEnableOverlapRecovery = "UnityEngine.CharacterController::get_enableOverlapRecovery";
    public const string MONO_GetHeight = "UnityEngine.CharacterController::get_height";
    public const string MONO_GetIsGrounded = "UnityEngine.CharacterController::get_isGrounded";
    public const string MONO_GetMinMoveDistance = "UnityEngine.CharacterController::get_minMoveDistance";
    public const string MONO_GetRadius = "UnityEngine.CharacterController::get_radius";
    public const string MONO_GetSkinWidth = "UnityEngine.CharacterController::get_skinWidth";
    public const string MONO_GetSlopeLimit = "UnityEngine.CharacterController::get_slopeLimit";
    public const string MONO_GetStepOffset = "UnityEngine.CharacterController::get_stepOffset";
    public const string MONO_GetVelocityInjected = "UnityEngine.CharacterController::get_velocity_Injected";
    public const string MONO_MoveInjected = "UnityEngine.CharacterController::Move_Injected";
    public const string MONO_SetCenterInjected = "UnityEngine.CharacterController::set_center_Injected";
    public const string MONO_SetDetectCollisions = "UnityEngine.CharacterController::set_detectCollisions";
    public const string MONO_SetEnableOverlapRecovery = "UnityEngine.CharacterController::set_enableOverlapRecovery";
    public const string MONO_SetHeight = "UnityEngine.CharacterController::set_height";
    public const string MONO_SetMinMoveDistance = "UnityEngine.CharacterController::set_minMoveDistance";
    public const string MONO_SetRadius = "UnityEngine.CharacterController::set_radius";
    public const string MONO_SetSkinWidth = "UnityEngine.CharacterController::set_skinWidth";
    public const string MONO_SetSlopeLimit = "UnityEngine.CharacterController::set_slopeLimit";
    public const string MONO_SetStepOffset = "UnityEngine.CharacterController::set_stepOffset";
    public const string MONO_SimpleMoveInjected = "UnityEngine.CharacterController::SimpleMove_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CharacterController : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CharacterController(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CharacterController(nint ptr) => new Ptr_UnityEngine_CharacterController(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CharacterController ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CharacterController ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_center_Injected = "UnityEngine.CharacterController::get_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_height = "UnityEngine.CharacterController::get_height()";
    public const string IL2CPP_get_isGrounded = "UnityEngine.CharacterController::get_isGrounded()";
    public const string IL2CPP_get_radius = "UnityEngine.CharacterController::get_radius()";
    public const string IL2CPP_get_velocity_Injected = "UnityEngine.CharacterController::get_velocity_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_Move_Injected = "UnityEngine.CharacterController::Move_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_center_Injected = "UnityEngine.CharacterController::set_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_height = "UnityEngine.CharacterController::set_height(System.Single)";
    public const string IL2CPP_set_radius = "UnityEngine.CharacterController::set_radius(System.Single)";
}

