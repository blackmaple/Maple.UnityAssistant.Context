namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LensFlare
{
    public const string MONO_GetBrightness = "UnityEngine.LensFlare::get_brightness";
    public const string MONO_GetColorInjected = "UnityEngine.LensFlare::get_color_Injected";
    public const string MONO_GetFadeSpeed = "UnityEngine.LensFlare::get_fadeSpeed";
    public const string MONO_GetFlare = "UnityEngine.LensFlare::get_flare";
    public const string MONO_SetBrightness = "UnityEngine.LensFlare::set_brightness";
    public const string MONO_SetColorInjected = "UnityEngine.LensFlare::set_color_Injected";
    public const string MONO_SetFadeSpeed = "UnityEngine.LensFlare::set_fadeSpeed";
    public const string MONO_SetFlare = "UnityEngine.LensFlare::set_flare";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LensFlare : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LensFlare(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LensFlare(nint ptr) => new Ptr_UnityEngine_LensFlare(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LensFlare ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LensFlare ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
