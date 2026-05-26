namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LightmapSettings
{
    public const string MONO_GetLightmaps = "UnityEngine.LightmapSettings::get_lightmaps";
    public const string MONO_GetLightmapsMode = "UnityEngine.LightmapSettings::get_lightmapsMode";
    public const string MONO_GetLightProbes = "UnityEngine.LightmapSettings::get_lightProbes";
    public const string MONO_Reset = "UnityEngine.LightmapSettings::Reset";
    public const string MONO_SetLightmaps = "UnityEngine.LightmapSettings::set_lightmaps";
    public const string MONO_SetLightmapsMode = "UnityEngine.LightmapSettings::set_lightmapsMode";
    public const string MONO_SetLightProbes = "UnityEngine.LightmapSettings::set_lightProbes";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LightmapSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LightmapSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LightmapSettings(nint ptr) => new Ptr_UnityEngine_LightmapSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LightmapSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LightmapSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
