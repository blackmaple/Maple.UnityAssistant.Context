namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SliderJoint2D
{
    public const string MONO_GetAngle = "UnityEngine.SliderJoint2D::get_angle";
    public const string MONO_GetAutoConfigureAngle = "UnityEngine.SliderJoint2D::get_autoConfigureAngle";
    public const string MONO_GetJointSpeed = "UnityEngine.SliderJoint2D::get_jointSpeed";
    public const string MONO_GetJointTranslation = "UnityEngine.SliderJoint2D::get_jointTranslation";
    public const string MONO_GetLimitsInjected = "UnityEngine.SliderJoint2D::get_limits_Injected";
    public const string MONO_GetLimitState = "UnityEngine.SliderJoint2D::get_limitState";
    public const string MONO_GetMotorInjected = "UnityEngine.SliderJoint2D::get_motor_Injected";
    public const string MONO_GetReferenceAngle = "UnityEngine.SliderJoint2D::get_referenceAngle";
    public const string MONO_GetUseLimits = "UnityEngine.SliderJoint2D::get_useLimits";
    public const string MONO_GetUseMotor = "UnityEngine.SliderJoint2D::get_useMotor";
    public const string MONO_GetMotorForce = "UnityEngine.SliderJoint2D::GetMotorForce";
    public const string MONO_SetAngle = "UnityEngine.SliderJoint2D::set_angle";
    public const string MONO_SetAutoConfigureAngle = "UnityEngine.SliderJoint2D::set_autoConfigureAngle";
    public const string MONO_SetLimitsInjected = "UnityEngine.SliderJoint2D::set_limits_Injected";
    public const string MONO_SetMotorInjected = "UnityEngine.SliderJoint2D::set_motor_Injected";
    public const string MONO_SetUseLimits = "UnityEngine.SliderJoint2D::set_useLimits";
    public const string MONO_SetUseMotor = "UnityEngine.SliderJoint2D::set_useMotor";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SliderJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SliderJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SliderJoint2D(nint ptr) => new Ptr_UnityEngine_SliderJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SliderJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SliderJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
