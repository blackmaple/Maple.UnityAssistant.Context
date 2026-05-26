namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_OcclusionArea
{
    public const string MONO_GetCenterInjected = "UnityEngine.OcclusionArea::get_center_Injected";
    public const string MONO_GetSizeInjected = "UnityEngine.OcclusionArea::get_size_Injected";
    public const string MONO_SetCenterInjected = "UnityEngine.OcclusionArea::set_center_Injected";
    public const string MONO_SetSizeInjected = "UnityEngine.OcclusionArea::set_size_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_OcclusionArea : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_OcclusionArea(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_OcclusionArea(nint ptr) => new Ptr_UnityEngine_OcclusionArea(ptr);
        public static implicit operator nint(Ptr_UnityEngine_OcclusionArea ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_OcclusionArea ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
