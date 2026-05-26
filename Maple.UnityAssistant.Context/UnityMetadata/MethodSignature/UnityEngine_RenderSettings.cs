namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RenderSettings
{
    public const string MONO_GetAmbientEquatorColorInjected = "UnityEngine.RenderSettings::get_ambientEquatorColor_Injected";
    public const string MONO_GetAmbientGroundColorInjected = "UnityEngine.RenderSettings::get_ambientGroundColor_Injected";
    public const string MONO_GetAmbientIntensity = "UnityEngine.RenderSettings::get_ambientIntensity";
    public const string MONO_GetAmbientLightInjected = "UnityEngine.RenderSettings::get_ambientLight_Injected";
    public const string MONO_GetAmbientMode = "UnityEngine.RenderSettings::get_ambientMode";
    public const string MONO_GetAmbientProbeInjected = "UnityEngine.RenderSettings::get_ambientProbe_Injected";
    public const string MONO_GetAmbientSkyColorInjected = "UnityEngine.RenderSettings::get_ambientSkyColor_Injected";
    public const string MONO_GetCustomReflection = "UnityEngine.RenderSettings::get_customReflection";
    public const string MONO_GetDefaultReflection = "UnityEngine.RenderSettings::get_defaultReflection";
    public const string MONO_GetDefaultReflectionMode = "UnityEngine.RenderSettings::get_defaultReflectionMode";
    public const string MONO_GetDefaultReflectionResolution = "UnityEngine.RenderSettings::get_defaultReflectionResolution";
    public const string MONO_GetFlareFadeSpeed = "UnityEngine.RenderSettings::get_flareFadeSpeed";
    public const string MONO_GetFlareStrength = "UnityEngine.RenderSettings::get_flareStrength";
    public const string MONO_GetFog = "UnityEngine.RenderSettings::get_fog";
    public const string MONO_GetFogColorInjected = "UnityEngine.RenderSettings::get_fogColor_Injected";
    public const string MONO_GetFogDensity = "UnityEngine.RenderSettings::get_fogDensity";
    public const string MONO_GetFogEndDistance = "UnityEngine.RenderSettings::get_fogEndDistance";
    public const string MONO_GetFogMode = "UnityEngine.RenderSettings::get_fogMode";
    public const string MONO_GetFogStartDistance = "UnityEngine.RenderSettings::get_fogStartDistance";
    public const string MONO_GetHaloStrength = "UnityEngine.RenderSettings::get_haloStrength";
    public const string MONO_GetReflectionBounces = "UnityEngine.RenderSettings::get_reflectionBounces";
    public const string MONO_GetReflectionIntensity = "UnityEngine.RenderSettings::get_reflectionIntensity";
    public const string MONO_GetSkybox = "UnityEngine.RenderSettings::get_skybox";
    public const string MONO_GetSubtractiveShadowColorInjected = "UnityEngine.RenderSettings::get_subtractiveShadowColor_Injected";
    public const string MONO_GetSun = "UnityEngine.RenderSettings::get_sun";
    public const string MONO_GetRenderSettings = "UnityEngine.RenderSettings::GetRenderSettings";
    public const string MONO_Reset = "UnityEngine.RenderSettings::Reset";
    public const string MONO_SetAmbientEquatorColorInjected = "UnityEngine.RenderSettings::set_ambientEquatorColor_Injected";
    public const string MONO_SetAmbientGroundColorInjected = "UnityEngine.RenderSettings::set_ambientGroundColor_Injected";
    public const string MONO_SetAmbientIntensity = "UnityEngine.RenderSettings::set_ambientIntensity";
    public const string MONO_SetAmbientLightInjected = "UnityEngine.RenderSettings::set_ambientLight_Injected";
    public const string MONO_SetAmbientMode = "UnityEngine.RenderSettings::set_ambientMode";
    public const string MONO_SetAmbientProbeInjected = "UnityEngine.RenderSettings::set_ambientProbe_Injected";
    public const string MONO_SetAmbientSkyColorInjected = "UnityEngine.RenderSettings::set_ambientSkyColor_Injected";
    public const string MONO_SetCustomReflection = "UnityEngine.RenderSettings::set_customReflection";
    public const string MONO_SetDefaultReflectionMode = "UnityEngine.RenderSettings::set_defaultReflectionMode";
    public const string MONO_SetDefaultReflectionResolution = "UnityEngine.RenderSettings::set_defaultReflectionResolution";
    public const string MONO_SetFlareFadeSpeed = "UnityEngine.RenderSettings::set_flareFadeSpeed";
    public const string MONO_SetFlareStrength = "UnityEngine.RenderSettings::set_flareStrength";
    public const string MONO_SetFog = "UnityEngine.RenderSettings::set_fog";
    public const string MONO_SetFogColorInjected = "UnityEngine.RenderSettings::set_fogColor_Injected";
    public const string MONO_SetFogDensity = "UnityEngine.RenderSettings::set_fogDensity";
    public const string MONO_SetFogEndDistance = "UnityEngine.RenderSettings::set_fogEndDistance";
    public const string MONO_SetFogMode = "UnityEngine.RenderSettings::set_fogMode";
    public const string MONO_SetFogStartDistance = "UnityEngine.RenderSettings::set_fogStartDistance";
    public const string MONO_SetHaloStrength = "UnityEngine.RenderSettings::set_haloStrength";
    public const string MONO_SetReflectionBounces = "UnityEngine.RenderSettings::set_reflectionBounces";
    public const string MONO_SetReflectionIntensity = "UnityEngine.RenderSettings::set_reflectionIntensity";
    public const string MONO_SetSkybox = "UnityEngine.RenderSettings::set_skybox";
    public const string MONO_SetSubtractiveShadowColorInjected = "UnityEngine.RenderSettings::set_subtractiveShadowColor_Injected";
    public const string MONO_SetSun = "UnityEngine.RenderSettings::set_sun";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RenderSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RenderSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RenderSettings(nint ptr) => new Ptr_UnityEngine_RenderSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RenderSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RenderSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_ambientEquatorColor_Injected = "UnityEngine.RenderSettings::get_ambientEquatorColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_ambientGroundColor_Injected = "UnityEngine.RenderSettings::get_ambientGroundColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_ambientProbe_Injected = "UnityEngine.RenderSettings::get_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2&)";
    public const string IL2CPP_get_ambientSkyColor_Injected = "UnityEngine.RenderSettings::get_ambientSkyColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_fog = "UnityEngine.RenderSettings::get_fog()";
    public const string IL2CPP_get_reflectionIntensity = "UnityEngine.RenderSettings::get_reflectionIntensity()";
    public const string IL2CPP_get_skybox = "UnityEngine.RenderSettings::get_skybox()";
    public const string IL2CPP_get_subtractiveShadowColor_Injected = "UnityEngine.RenderSettings::get_subtractiveShadowColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_sun = "UnityEngine.RenderSettings::get_sun()";
}

