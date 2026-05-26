namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LightingSettings
{
    public const string MONO_GetBakedGi = "UnityEngine.LightingSettings::get_bakedGI";
    public const string MONO_GetRealtimeEnvironmentLighting = "UnityEngine.LightingSettings::get_realtimeEnvironmentLighting";
    public const string MONO_GetRealtimeGi = "UnityEngine.LightingSettings::get_realtimeGI";
    public const string MONO_InternalCreate = "UnityEngine.LightingSettings::Internal_Create";
    public const string MONO_SetBakedGi = "UnityEngine.LightingSettings::set_bakedGI";
    public const string MONO_SetRealtimeEnvironmentLighting = "UnityEngine.LightingSettings::set_realtimeEnvironmentLighting";
    public const string MONO_SetRealtimeGi = "UnityEngine.LightingSettings::set_realtimeGI";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LightingSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LightingSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LightingSettings(nint ptr) => new Ptr_UnityEngine_LightingSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LightingSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LightingSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
