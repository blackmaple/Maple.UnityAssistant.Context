namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HingeJoint2D
{
    public const string MONO_GetJointAngle = "UnityEngine.HingeJoint2D::get_jointAngle";
    public const string MONO_GetJointSpeed = "UnityEngine.HingeJoint2D::get_jointSpeed";
    public const string MONO_GetLimitsInjected = "UnityEngine.HingeJoint2D::get_limits_Injected";
    public const string MONO_GetLimitState = "UnityEngine.HingeJoint2D::get_limitState";
    public const string MONO_GetMotorInjected = "UnityEngine.HingeJoint2D::get_motor_Injected";
    public const string MONO_GetReferenceAngle = "UnityEngine.HingeJoint2D::get_referenceAngle";
    public const string MONO_GetUseLimits = "UnityEngine.HingeJoint2D::get_useLimits";
    public const string MONO_GetUseMotor = "UnityEngine.HingeJoint2D::get_useMotor";
    public const string MONO_GetMotorTorque = "UnityEngine.HingeJoint2D::GetMotorTorque";
    public const string MONO_SetLimitsInjected = "UnityEngine.HingeJoint2D::set_limits_Injected";
    public const string MONO_SetMotorInjected = "UnityEngine.HingeJoint2D::set_motor_Injected";
    public const string MONO_SetUseLimits = "UnityEngine.HingeJoint2D::set_useLimits";
    public const string MONO_SetUseMotor = "UnityEngine.HingeJoint2D::set_useMotor";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HingeJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HingeJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HingeJoint2D(nint ptr) => new Ptr_UnityEngine_HingeJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HingeJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HingeJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
