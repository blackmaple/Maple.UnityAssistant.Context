namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_WheelJoint2D
{
    public const string MONO_GetJointAngle = "UnityEngine.WheelJoint2D::get_jointAngle";
    public const string MONO_GetJointLinearSpeed = "UnityEngine.WheelJoint2D::get_jointLinearSpeed";
    public const string MONO_GetJointSpeed = "UnityEngine.WheelJoint2D::get_jointSpeed";
    public const string MONO_GetJointTranslation = "UnityEngine.WheelJoint2D::get_jointTranslation";
    public const string MONO_GetMotorInjected = "UnityEngine.WheelJoint2D::get_motor_Injected";
    public const string MONO_GetSuspensionInjected = "UnityEngine.WheelJoint2D::get_suspension_Injected";
    public const string MONO_GetUseMotor = "UnityEngine.WheelJoint2D::get_useMotor";
    public const string MONO_GetMotorTorque = "UnityEngine.WheelJoint2D::GetMotorTorque";
    public const string MONO_SetMotorInjected = "UnityEngine.WheelJoint2D::set_motor_Injected";
    public const string MONO_SetSuspensionInjected = "UnityEngine.WheelJoint2D::set_suspension_Injected";
    public const string MONO_SetUseMotor = "UnityEngine.WheelJoint2D::set_useMotor";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_WheelJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_WheelJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_WheelJoint2D(nint ptr) => new Ptr_UnityEngine_WheelJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_WheelJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_WheelJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
