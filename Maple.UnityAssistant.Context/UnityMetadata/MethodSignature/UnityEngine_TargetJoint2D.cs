namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TargetJoint2D
{
    public const string MONO_GetAnchorInjected = "UnityEngine.TargetJoint2D::get_anchor_Injected";
    public const string MONO_GetAutoConfigureTarget = "UnityEngine.TargetJoint2D::get_autoConfigureTarget";
    public const string MONO_GetDampingRatio = "UnityEngine.TargetJoint2D::get_dampingRatio";
    public const string MONO_GetFrequency = "UnityEngine.TargetJoint2D::get_frequency";
    public const string MONO_GetMaxForce = "UnityEngine.TargetJoint2D::get_maxForce";
    public const string MONO_GetTargetInjected = "UnityEngine.TargetJoint2D::get_target_Injected";
    public const string MONO_SetAnchorInjected = "UnityEngine.TargetJoint2D::set_anchor_Injected";
    public const string MONO_SetAutoConfigureTarget = "UnityEngine.TargetJoint2D::set_autoConfigureTarget";
    public const string MONO_SetDampingRatio = "UnityEngine.TargetJoint2D::set_dampingRatio";
    public const string MONO_SetFrequency = "UnityEngine.TargetJoint2D::set_frequency";
    public const string MONO_SetMaxForce = "UnityEngine.TargetJoint2D::set_maxForce";
    public const string MONO_SetTargetInjected = "UnityEngine.TargetJoint2D::set_target_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TargetJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TargetJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TargetJoint2D(nint ptr) => new Ptr_UnityEngine_TargetJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TargetJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TargetJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
