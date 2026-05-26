namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Projector
{
    public const string MONO_GetAspectRatio = "UnityEngine.Projector::get_aspectRatio";
    public const string MONO_GetFarClipPlane = "UnityEngine.Projector::get_farClipPlane";
    public const string MONO_GetFieldOfView = "UnityEngine.Projector::get_fieldOfView";
    public const string MONO_GetIgnoreLayers = "UnityEngine.Projector::get_ignoreLayers";
    public const string MONO_GetMaterial = "UnityEngine.Projector::get_material";
    public const string MONO_GetNearClipPlane = "UnityEngine.Projector::get_nearClipPlane";
    public const string MONO_GetOrthographic = "UnityEngine.Projector::get_orthographic";
    public const string MONO_GetOrthographicSize = "UnityEngine.Projector::get_orthographicSize";
    public const string MONO_SetAspectRatio = "UnityEngine.Projector::set_aspectRatio";
    public const string MONO_SetFarClipPlane = "UnityEngine.Projector::set_farClipPlane";
    public const string MONO_SetFieldOfView = "UnityEngine.Projector::set_fieldOfView";
    public const string MONO_SetIgnoreLayers = "UnityEngine.Projector::set_ignoreLayers";
    public const string MONO_SetMaterial = "UnityEngine.Projector::set_material";
    public const string MONO_SetNearClipPlane = "UnityEngine.Projector::set_nearClipPlane";
    public const string MONO_SetOrthographic = "UnityEngine.Projector::set_orthographic";
    public const string MONO_SetOrthographicSize = "UnityEngine.Projector::set_orthographicSize";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Projector : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Projector(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Projector(nint ptr) => new Ptr_UnityEngine_Projector(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Projector ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Projector ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
