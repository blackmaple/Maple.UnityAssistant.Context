namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SurfaceEffector2D
{
    public const string MONO_GetForceScale = "UnityEngine.SurfaceEffector2D::get_forceScale";
    public const string MONO_GetSpeed = "UnityEngine.SurfaceEffector2D::get_speed";
    public const string MONO_GetSpeedVariation = "UnityEngine.SurfaceEffector2D::get_speedVariation";
    public const string MONO_GetUseBounce = "UnityEngine.SurfaceEffector2D::get_useBounce";
    public const string MONO_GetUseContactForce = "UnityEngine.SurfaceEffector2D::get_useContactForce";
    public const string MONO_GetUseFriction = "UnityEngine.SurfaceEffector2D::get_useFriction";
    public const string MONO_SetForceScale = "UnityEngine.SurfaceEffector2D::set_forceScale";
    public const string MONO_SetSpeed = "UnityEngine.SurfaceEffector2D::set_speed";
    public const string MONO_SetSpeedVariation = "UnityEngine.SurfaceEffector2D::set_speedVariation";
    public const string MONO_SetUseBounce = "UnityEngine.SurfaceEffector2D::set_useBounce";
    public const string MONO_SetUseContactForce = "UnityEngine.SurfaceEffector2D::set_useContactForce";
    public const string MONO_SetUseFriction = "UnityEngine.SurfaceEffector2D::set_useFriction";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SurfaceEffector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SurfaceEffector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SurfaceEffector2D(nint ptr) => new Ptr_UnityEngine_SurfaceEffector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SurfaceEffector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SurfaceEffector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
