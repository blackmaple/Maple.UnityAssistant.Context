namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SpringJoint
{
    public const string MONO_GetDamper = "UnityEngine.SpringJoint::get_damper";
    public const string MONO_GetMaxDistance = "UnityEngine.SpringJoint::get_maxDistance";
    public const string MONO_GetMinDistance = "UnityEngine.SpringJoint::get_minDistance";
    public const string MONO_GetSpring = "UnityEngine.SpringJoint::get_spring";
    public const string MONO_GetTolerance = "UnityEngine.SpringJoint::get_tolerance";
    public const string MONO_SetDamper = "UnityEngine.SpringJoint::set_damper";
    public const string MONO_SetMaxDistance = "UnityEngine.SpringJoint::set_maxDistance";
    public const string MONO_SetMinDistance = "UnityEngine.SpringJoint::set_minDistance";
    public const string MONO_SetSpring = "UnityEngine.SpringJoint::set_spring";
    public const string MONO_SetTolerance = "UnityEngine.SpringJoint::set_tolerance";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SpringJoint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SpringJoint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SpringJoint(nint ptr) => new Ptr_UnityEngine_SpringJoint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SpringJoint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SpringJoint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
