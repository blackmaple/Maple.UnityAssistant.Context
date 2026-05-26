namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ConstantForce2D
{
    public const string MONO_GetForceInjected = "UnityEngine.ConstantForce2D::get_force_Injected";
    public const string MONO_GetRelativeForceInjected = "UnityEngine.ConstantForce2D::get_relativeForce_Injected";
    public const string MONO_GetTorque = "UnityEngine.ConstantForce2D::get_torque";
    public const string MONO_SetForceInjected = "UnityEngine.ConstantForce2D::set_force_Injected";
    public const string MONO_SetRelativeForceInjected = "UnityEngine.ConstantForce2D::set_relativeForce_Injected";
    public const string MONO_SetTorque = "UnityEngine.ConstantForce2D::set_torque";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ConstantForce2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ConstantForce2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ConstantForce2D(nint ptr) => new Ptr_UnityEngine_ConstantForce2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ConstantForce2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ConstantForce2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
