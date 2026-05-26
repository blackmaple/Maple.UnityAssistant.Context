namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HingeJoint
{
    public const string MONO_GetAngle = "UnityEngine.HingeJoint::get_angle";
    public const string MONO_GetLimitsInjected = "UnityEngine.HingeJoint::get_limits_Injected";
    public const string MONO_GetMotorInjected = "UnityEngine.HingeJoint::get_motor_Injected";
    public const string MONO_GetSpringInjected = "UnityEngine.HingeJoint::get_spring_Injected";
    public const string MONO_GetUseLimits = "UnityEngine.HingeJoint::get_useLimits";
    public const string MONO_GetUseMotor = "UnityEngine.HingeJoint::get_useMotor";
    public const string MONO_GetUseSpring = "UnityEngine.HingeJoint::get_useSpring";
    public const string MONO_GetVelocity = "UnityEngine.HingeJoint::get_velocity";
    public const string MONO_SetLimitsInjected = "UnityEngine.HingeJoint::set_limits_Injected";
    public const string MONO_SetMotorInjected = "UnityEngine.HingeJoint::set_motor_Injected";
    public const string MONO_SetSpringInjected = "UnityEngine.HingeJoint::set_spring_Injected";
    public const string MONO_SetUseLimits = "UnityEngine.HingeJoint::set_useLimits";
    public const string MONO_SetUseMotor = "UnityEngine.HingeJoint::set_useMotor";
    public const string MONO_SetUseSpring = "UnityEngine.HingeJoint::set_useSpring";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HingeJoint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HingeJoint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HingeJoint(nint ptr) => new Ptr_UnityEngine_HingeJoint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HingeJoint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HingeJoint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
