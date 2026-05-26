namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_DistanceJoint2D
{
    public const string MONO_GetAutoConfigureDistance = "UnityEngine.DistanceJoint2D::get_autoConfigureDistance";
    public const string MONO_GetDistance = "UnityEngine.DistanceJoint2D::get_distance";
    public const string MONO_GetMaxDistanceOnly = "UnityEngine.DistanceJoint2D::get_maxDistanceOnly";
    public const string MONO_SetAutoConfigureDistance = "UnityEngine.DistanceJoint2D::set_autoConfigureDistance";
    public const string MONO_SetDistance = "UnityEngine.DistanceJoint2D::set_distance";
    public const string MONO_SetMaxDistanceOnly = "UnityEngine.DistanceJoint2D::set_maxDistanceOnly";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_DistanceJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_DistanceJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_DistanceJoint2D(nint ptr) => new Ptr_UnityEngine_DistanceJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_DistanceJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_DistanceJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
