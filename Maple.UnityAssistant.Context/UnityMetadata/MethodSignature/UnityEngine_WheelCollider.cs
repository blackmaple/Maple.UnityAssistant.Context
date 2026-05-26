namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_WheelCollider
{
    public const string MONO_ConfigureVehicleSubsteps = "UnityEngine.WheelCollider::ConfigureVehicleSubsteps";
    public const string MONO_GetBrakeTorque = "UnityEngine.WheelCollider::get_brakeTorque";
    public const string MONO_GetCenterInjected = "UnityEngine.WheelCollider::get_center_Injected";
    public const string MONO_GetForceAppPointDistance = "UnityEngine.WheelCollider::get_forceAppPointDistance";
    public const string MONO_GetForwardFrictionInjected = "UnityEngine.WheelCollider::get_forwardFriction_Injected";
    public const string MONO_GetIsGrounded = "UnityEngine.WheelCollider::get_isGrounded";
    public const string MONO_GetMass = "UnityEngine.WheelCollider::get_mass";
    public const string MONO_GetMotorTorque = "UnityEngine.WheelCollider::get_motorTorque";
    public const string MONO_GetRadius = "UnityEngine.WheelCollider::get_radius";
    public const string MONO_GetRpm = "UnityEngine.WheelCollider::get_rpm";
    public const string MONO_GetSidewaysFrictionInjected = "UnityEngine.WheelCollider::get_sidewaysFriction_Injected";
    public const string MONO_GetSprungMass = "UnityEngine.WheelCollider::get_sprungMass";
    public const string MONO_GetSteerAngle = "UnityEngine.WheelCollider::get_steerAngle";
    public const string MONO_GetSuspensionDistance = "UnityEngine.WheelCollider::get_suspensionDistance";
    public const string MONO_GetSuspensionExpansionLimited = "UnityEngine.WheelCollider::get_suspensionExpansionLimited";
    public const string MONO_GetSuspensionSpringInjected = "UnityEngine.WheelCollider::get_suspensionSpring_Injected";
    public const string MONO_GetWheelDampingRate = "UnityEngine.WheelCollider::get_wheelDampingRate";
    public const string MONO_GetGroundHit = "UnityEngine.WheelCollider::GetGroundHit";
    public const string MONO_GetWorldPose = "UnityEngine.WheelCollider::GetWorldPose";
    public const string MONO_ResetSprungMasses = "UnityEngine.WheelCollider::ResetSprungMasses";
    public const string MONO_SetBrakeTorque = "UnityEngine.WheelCollider::set_brakeTorque";
    public const string MONO_SetCenterInjected = "UnityEngine.WheelCollider::set_center_Injected";
    public const string MONO_SetForceAppPointDistance = "UnityEngine.WheelCollider::set_forceAppPointDistance";
    public const string MONO_SetForwardFrictionInjected = "UnityEngine.WheelCollider::set_forwardFriction_Injected";
    public const string MONO_SetMass = "UnityEngine.WheelCollider::set_mass";
    public const string MONO_SetMotorTorque = "UnityEngine.WheelCollider::set_motorTorque";
    public const string MONO_SetRadius = "UnityEngine.WheelCollider::set_radius";
    public const string MONO_SetSidewaysFrictionInjected = "UnityEngine.WheelCollider::set_sidewaysFriction_Injected";
    public const string MONO_SetSprungMass = "UnityEngine.WheelCollider::set_sprungMass";
    public const string MONO_SetSteerAngle = "UnityEngine.WheelCollider::set_steerAngle";
    public const string MONO_SetSuspensionDistance = "UnityEngine.WheelCollider::set_suspensionDistance";
    public const string MONO_SetSuspensionExpansionLimited = "UnityEngine.WheelCollider::set_suspensionExpansionLimited";
    public const string MONO_SetSuspensionSpringInjected = "UnityEngine.WheelCollider::set_suspensionSpring_Injected";
    public const string MONO_SetWheelDampingRate = "UnityEngine.WheelCollider::set_wheelDampingRate";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_WheelCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_WheelCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_WheelCollider(nint ptr) => new Ptr_UnityEngine_WheelCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_WheelCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_WheelCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
