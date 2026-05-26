namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SpringJoint2D
{
    public const string MONO_GetAutoConfigureDistance = "UnityEngine.SpringJoint2D::get_autoConfigureDistance";
    public const string MONO_GetDampingRatio = "UnityEngine.SpringJoint2D::get_dampingRatio";
    public const string MONO_GetDistance = "UnityEngine.SpringJoint2D::get_distance";
    public const string MONO_GetFrequency = "UnityEngine.SpringJoint2D::get_frequency";
    public const string MONO_SetAutoConfigureDistance = "UnityEngine.SpringJoint2D::set_autoConfigureDistance";
    public const string MONO_SetDampingRatio = "UnityEngine.SpringJoint2D::set_dampingRatio";
    public const string MONO_SetDistance = "UnityEngine.SpringJoint2D::set_distance";
    public const string MONO_SetFrequency = "UnityEngine.SpringJoint2D::set_frequency";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SpringJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SpringJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SpringJoint2D(nint ptr) => new Ptr_UnityEngine_SpringJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SpringJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SpringJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
