namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ConstantForce
{
    public const string MONO_GetForceInjected = "UnityEngine.ConstantForce::get_force_Injected";
    public const string MONO_GetRelativeForceInjected = "UnityEngine.ConstantForce::get_relativeForce_Injected";
    public const string MONO_GetRelativeTorqueInjected = "UnityEngine.ConstantForce::get_relativeTorque_Injected";
    public const string MONO_GetTorqueInjected = "UnityEngine.ConstantForce::get_torque_Injected";
    public const string MONO_SetForceInjected = "UnityEngine.ConstantForce::set_force_Injected";
    public const string MONO_SetRelativeForceInjected = "UnityEngine.ConstantForce::set_relativeForce_Injected";
    public const string MONO_SetRelativeTorqueInjected = "UnityEngine.ConstantForce::set_relativeTorque_Injected";
    public const string MONO_SetTorqueInjected = "UnityEngine.ConstantForce::set_torque_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ConstantForce : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ConstantForce(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ConstantForce(nint ptr) => new Ptr_UnityEngine_ConstantForce(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ConstantForce ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ConstantForce ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
