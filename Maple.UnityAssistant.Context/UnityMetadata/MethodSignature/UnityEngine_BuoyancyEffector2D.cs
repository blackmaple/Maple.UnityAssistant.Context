namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_BuoyancyEffector2D
{
    public const string MONO_GetAngularDrag = "UnityEngine.BuoyancyEffector2D::get_angularDrag";
    public const string MONO_GetDensity = "UnityEngine.BuoyancyEffector2D::get_density";
    public const string MONO_GetFlowAngle = "UnityEngine.BuoyancyEffector2D::get_flowAngle";
    public const string MONO_GetFlowMagnitude = "UnityEngine.BuoyancyEffector2D::get_flowMagnitude";
    public const string MONO_GetFlowVariation = "UnityEngine.BuoyancyEffector2D::get_flowVariation";
    public const string MONO_GetLinearDrag = "UnityEngine.BuoyancyEffector2D::get_linearDrag";
    public const string MONO_GetSurfaceLevel = "UnityEngine.BuoyancyEffector2D::get_surfaceLevel";
    public const string MONO_SetAngularDrag = "UnityEngine.BuoyancyEffector2D::set_angularDrag";
    public const string MONO_SetDensity = "UnityEngine.BuoyancyEffector2D::set_density";
    public const string MONO_SetFlowAngle = "UnityEngine.BuoyancyEffector2D::set_flowAngle";
    public const string MONO_SetFlowMagnitude = "UnityEngine.BuoyancyEffector2D::set_flowMagnitude";
    public const string MONO_SetFlowVariation = "UnityEngine.BuoyancyEffector2D::set_flowVariation";
    public const string MONO_SetLinearDrag = "UnityEngine.BuoyancyEffector2D::set_linearDrag";
    public const string MONO_SetSurfaceLevel = "UnityEngine.BuoyancyEffector2D::set_surfaceLevel";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_BuoyancyEffector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_BuoyancyEffector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_BuoyancyEffector2D(nint ptr) => new Ptr_UnityEngine_BuoyancyEffector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_BuoyancyEffector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_BuoyancyEffector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
