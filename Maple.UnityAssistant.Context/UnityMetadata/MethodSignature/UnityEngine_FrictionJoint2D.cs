namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_FrictionJoint2D
{
    public const string MONO_GetMaxForce = "UnityEngine.FrictionJoint2D::get_maxForce";
    public const string MONO_GetMaxTorque = "UnityEngine.FrictionJoint2D::get_maxTorque";
    public const string MONO_SetMaxForce = "UnityEngine.FrictionJoint2D::set_maxForce";
    public const string MONO_SetMaxTorque = "UnityEngine.FrictionJoint2D::set_maxTorque";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_FrictionJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_FrictionJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_FrictionJoint2D(nint ptr) => new Ptr_UnityEngine_FrictionJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_FrictionJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_FrictionJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
