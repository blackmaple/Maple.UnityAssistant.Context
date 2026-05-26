namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CharacterJoint
{
    public const string MONO_GetEnableProjection = "UnityEngine.CharacterJoint::get_enableProjection";
    public const string MONO_GetHighTwistLimitInjected = "UnityEngine.CharacterJoint::get_highTwistLimit_Injected";
    public const string MONO_GetLowTwistLimitInjected = "UnityEngine.CharacterJoint::get_lowTwistLimit_Injected";
    public const string MONO_GetProjectionAngle = "UnityEngine.CharacterJoint::get_projectionAngle";
    public const string MONO_GetProjectionDistance = "UnityEngine.CharacterJoint::get_projectionDistance";
    public const string MONO_GetSwing1LimitInjected = "UnityEngine.CharacterJoint::get_swing1Limit_Injected";
    public const string MONO_GetSwing2LimitInjected = "UnityEngine.CharacterJoint::get_swing2Limit_Injected";
    public const string MONO_GetSwingAxisInjected = "UnityEngine.CharacterJoint::get_swingAxis_Injected";
    public const string MONO_GetSwingLimitSpringInjected = "UnityEngine.CharacterJoint::get_swingLimitSpring_Injected";
    public const string MONO_GetTwistLimitSpringInjected = "UnityEngine.CharacterJoint::get_twistLimitSpring_Injected";
    public const string MONO_SetEnableProjection = "UnityEngine.CharacterJoint::set_enableProjection";
    public const string MONO_SetHighTwistLimitInjected = "UnityEngine.CharacterJoint::set_highTwistLimit_Injected";
    public const string MONO_SetLowTwistLimitInjected = "UnityEngine.CharacterJoint::set_lowTwistLimit_Injected";
    public const string MONO_SetProjectionAngle = "UnityEngine.CharacterJoint::set_projectionAngle";
    public const string MONO_SetProjectionDistance = "UnityEngine.CharacterJoint::set_projectionDistance";
    public const string MONO_SetSwing1LimitInjected = "UnityEngine.CharacterJoint::set_swing1Limit_Injected";
    public const string MONO_SetSwing2LimitInjected = "UnityEngine.CharacterJoint::set_swing2Limit_Injected";
    public const string MONO_SetSwingAxisInjected = "UnityEngine.CharacterJoint::set_swingAxis_Injected";
    public const string MONO_SetSwingLimitSpringInjected = "UnityEngine.CharacterJoint::set_swingLimitSpring_Injected";
    public const string MONO_SetTwistLimitSpringInjected = "UnityEngine.CharacterJoint::set_twistLimitSpring_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CharacterJoint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CharacterJoint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CharacterJoint(nint ptr) => new Ptr_UnityEngine_CharacterJoint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CharacterJoint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CharacterJoint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
