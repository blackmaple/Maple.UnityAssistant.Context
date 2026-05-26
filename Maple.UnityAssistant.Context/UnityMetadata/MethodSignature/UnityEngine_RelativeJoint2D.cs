namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RelativeJoint2D
{
    public const string MONO_GetAngularOffset = "UnityEngine.RelativeJoint2D::get_angularOffset";
    public const string MONO_GetAutoConfigureOffset = "UnityEngine.RelativeJoint2D::get_autoConfigureOffset";
    public const string MONO_GetCorrectionScale = "UnityEngine.RelativeJoint2D::get_correctionScale";
    public const string MONO_GetLinearOffsetInjected = "UnityEngine.RelativeJoint2D::get_linearOffset_Injected";
    public const string MONO_GetMaxForce = "UnityEngine.RelativeJoint2D::get_maxForce";
    public const string MONO_GetMaxTorque = "UnityEngine.RelativeJoint2D::get_maxTorque";
    public const string MONO_GetTargetInjected = "UnityEngine.RelativeJoint2D::get_target_Injected";
    public const string MONO_SetAngularOffset = "UnityEngine.RelativeJoint2D::set_angularOffset";
    public const string MONO_SetAutoConfigureOffset = "UnityEngine.RelativeJoint2D::set_autoConfigureOffset";
    public const string MONO_SetCorrectionScale = "UnityEngine.RelativeJoint2D::set_correctionScale";
    public const string MONO_SetLinearOffsetInjected = "UnityEngine.RelativeJoint2D::set_linearOffset_Injected";
    public const string MONO_SetMaxForce = "UnityEngine.RelativeJoint2D::set_maxForce";
    public const string MONO_SetMaxTorque = "UnityEngine.RelativeJoint2D::set_maxTorque";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RelativeJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RelativeJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RelativeJoint2D(nint ptr) => new Ptr_UnityEngine_RelativeJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RelativeJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RelativeJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
