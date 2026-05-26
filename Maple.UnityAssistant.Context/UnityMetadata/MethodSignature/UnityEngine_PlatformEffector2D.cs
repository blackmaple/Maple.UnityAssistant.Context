namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PlatformEffector2D
{
    public const string MONO_GetRotationalOffset = "UnityEngine.PlatformEffector2D::get_rotationalOffset";
    public const string MONO_GetSideArc = "UnityEngine.PlatformEffector2D::get_sideArc";
    public const string MONO_GetSurfaceArc = "UnityEngine.PlatformEffector2D::get_surfaceArc";
    public const string MONO_GetUseOneWay = "UnityEngine.PlatformEffector2D::get_useOneWay";
    public const string MONO_GetUseOneWayGrouping = "UnityEngine.PlatformEffector2D::get_useOneWayGrouping";
    public const string MONO_GetUseSideBounce = "UnityEngine.PlatformEffector2D::get_useSideBounce";
    public const string MONO_GetUseSideFriction = "UnityEngine.PlatformEffector2D::get_useSideFriction";
    public const string MONO_SetRotationalOffset = "UnityEngine.PlatformEffector2D::set_rotationalOffset";
    public const string MONO_SetSideArc = "UnityEngine.PlatformEffector2D::set_sideArc";
    public const string MONO_SetSurfaceArc = "UnityEngine.PlatformEffector2D::set_surfaceArc";
    public const string MONO_SetUseOneWay = "UnityEngine.PlatformEffector2D::set_useOneWay";
    public const string MONO_SetUseOneWayGrouping = "UnityEngine.PlatformEffector2D::set_useOneWayGrouping";
    public const string MONO_SetUseSideBounce = "UnityEngine.PlatformEffector2D::set_useSideBounce";
    public const string MONO_SetUseSideFriction = "UnityEngine.PlatformEffector2D::set_useSideFriction";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PlatformEffector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PlatformEffector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PlatformEffector2D(nint ptr) => new Ptr_UnityEngine_PlatformEffector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PlatformEffector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PlatformEffector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
