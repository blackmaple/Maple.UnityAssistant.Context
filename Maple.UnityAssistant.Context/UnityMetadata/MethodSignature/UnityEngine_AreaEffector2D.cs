namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AreaEffector2D
{
    public const string MONO_GetAngularDrag = "UnityEngine.AreaEffector2D::get_angularDrag";
    public const string MONO_GetDrag = "UnityEngine.AreaEffector2D::get_drag";
    public const string MONO_GetForceAngle = "UnityEngine.AreaEffector2D::get_forceAngle";
    public const string MONO_GetForceMagnitude = "UnityEngine.AreaEffector2D::get_forceMagnitude";
    public const string MONO_GetForceTarget = "UnityEngine.AreaEffector2D::get_forceTarget";
    public const string MONO_GetForceVariation = "UnityEngine.AreaEffector2D::get_forceVariation";
    public const string MONO_GetUseGlobalAngle = "UnityEngine.AreaEffector2D::get_useGlobalAngle";
    public const string MONO_SetAngularDrag = "UnityEngine.AreaEffector2D::set_angularDrag";
    public const string MONO_SetDrag = "UnityEngine.AreaEffector2D::set_drag";
    public const string MONO_SetForceAngle = "UnityEngine.AreaEffector2D::set_forceAngle";
    public const string MONO_SetForceMagnitude = "UnityEngine.AreaEffector2D::set_forceMagnitude";
    public const string MONO_SetForceTarget = "UnityEngine.AreaEffector2D::set_forceTarget";
    public const string MONO_SetForceVariation = "UnityEngine.AreaEffector2D::set_forceVariation";
    public const string MONO_SetUseGlobalAngle = "UnityEngine.AreaEffector2D::set_useGlobalAngle";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AreaEffector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AreaEffector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AreaEffector2D(nint ptr) => new Ptr_UnityEngine_AreaEffector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AreaEffector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AreaEffector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
