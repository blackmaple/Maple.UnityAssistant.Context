namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Joint
{
    public const string MONO_GetAnchorInjected = "UnityEngine.Joint::get_anchor_Injected";
    public const string MONO_GetAutoConfigureConnectedAnchor = "UnityEngine.Joint::get_autoConfigureConnectedAnchor";
    public const string MONO_GetAxisInjected = "UnityEngine.Joint::get_axis_Injected";
    public const string MONO_GetBreakForce = "UnityEngine.Joint::get_breakForce";
    public const string MONO_GetBreakTorque = "UnityEngine.Joint::get_breakTorque";
    public const string MONO_GetConnectedAnchorInjected = "UnityEngine.Joint::get_connectedAnchor_Injected";
    public const string MONO_GetConnectedArticulationBody = "UnityEngine.Joint::get_connectedArticulationBody";
    public const string MONO_GetConnectedBody = "UnityEngine.Joint::get_connectedBody";
    public const string MONO_GetConnectedMassScale = "UnityEngine.Joint::get_connectedMassScale";
    public const string MONO_GetEnableCollision = "UnityEngine.Joint::get_enableCollision";
    public const string MONO_GetEnablePreprocessing = "UnityEngine.Joint::get_enablePreprocessing";
    public const string MONO_GetMassScale = "UnityEngine.Joint::get_massScale";
    public const string MONO_GetCurrentForces = "UnityEngine.Joint::GetCurrentForces";
    public const string MONO_SetAnchorInjected = "UnityEngine.Joint::set_anchor_Injected";
    public const string MONO_SetAutoConfigureConnectedAnchor = "UnityEngine.Joint::set_autoConfigureConnectedAnchor";
    public const string MONO_SetAxisInjected = "UnityEngine.Joint::set_axis_Injected";
    public const string MONO_SetBreakForce = "UnityEngine.Joint::set_breakForce";
    public const string MONO_SetBreakTorque = "UnityEngine.Joint::set_breakTorque";
    public const string MONO_SetConnectedAnchorInjected = "UnityEngine.Joint::set_connectedAnchor_Injected";
    public const string MONO_SetConnectedArticulationBody = "UnityEngine.Joint::set_connectedArticulationBody";
    public const string MONO_SetConnectedBody = "UnityEngine.Joint::set_connectedBody";
    public const string MONO_SetConnectedMassScale = "UnityEngine.Joint::set_connectedMassScale";
    public const string MONO_SetEnableCollision = "UnityEngine.Joint::set_enableCollision";
    public const string MONO_SetEnablePreprocessing = "UnityEngine.Joint::set_enablePreprocessing";
    public const string MONO_SetMassScale = "UnityEngine.Joint::set_massScale";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Joint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Joint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Joint(nint ptr) => new Ptr_UnityEngine_Joint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Joint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Joint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
