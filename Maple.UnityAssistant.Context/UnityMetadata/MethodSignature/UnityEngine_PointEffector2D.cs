namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PointEffector2D
{
    public const string MONO_GetAngularDrag = "UnityEngine.PointEffector2D::get_angularDrag";
    public const string MONO_GetDistanceScale = "UnityEngine.PointEffector2D::get_distanceScale";
    public const string MONO_GetDrag = "UnityEngine.PointEffector2D::get_drag";
    public const string MONO_GetForceMagnitude = "UnityEngine.PointEffector2D::get_forceMagnitude";
    public const string MONO_GetForceMode = "UnityEngine.PointEffector2D::get_forceMode";
    public const string MONO_GetForceSource = "UnityEngine.PointEffector2D::get_forceSource";
    public const string MONO_GetForceTarget = "UnityEngine.PointEffector2D::get_forceTarget";
    public const string MONO_GetForceVariation = "UnityEngine.PointEffector2D::get_forceVariation";
    public const string MONO_SetAngularDrag = "UnityEngine.PointEffector2D::set_angularDrag";
    public const string MONO_SetDistanceScale = "UnityEngine.PointEffector2D::set_distanceScale";
    public const string MONO_SetDrag = "UnityEngine.PointEffector2D::set_drag";
    public const string MONO_SetForceMagnitude = "UnityEngine.PointEffector2D::set_forceMagnitude";
    public const string MONO_SetForceMode = "UnityEngine.PointEffector2D::set_forceMode";
    public const string MONO_SetForceSource = "UnityEngine.PointEffector2D::set_forceSource";
    public const string MONO_SetForceTarget = "UnityEngine.PointEffector2D::set_forceTarget";
    public const string MONO_SetForceVariation = "UnityEngine.PointEffector2D::set_forceVariation";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PointEffector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PointEffector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PointEffector2D(nint ptr) => new Ptr_UnityEngine_PointEffector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PointEffector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PointEffector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
