namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_GraphicsSettings
{
    public const string MONO_GetDefaultRenderingLayerMask = "UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask";
    public const string MONO_GetDisableBuiltinCustomRenderTextureUpdate = "UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate";
    public const string MONO_GetInternalCurrentRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipeline";
    public const string MONO_GetInternalDefaultRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_defaultRenderPipeline";
    public const string MONO_GetLightsUseColorTemperature = "UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature";
    public const string MONO_GetLightsUseLinearIntensity = "UnityEngine.Rendering.GraphicsSettings::get_lightsUseLinearIntensity";
    public const string MONO_GetLogWhenShaderIsCompiled = "UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled";
    public const string MONO_GetRealtimeDirectRectangularAreaLights = "UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights";
    public const string MONO_GetTransparencySortAxisInjected = "UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected";
    public const string MONO_GetTransparencySortMode = "UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode";
    public const string MONO_GetUseScriptableRenderPipelineBatching = "UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching";
    public const string MONO_GetVideoShadersIncludeMode = "UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode";
    public const string MONO_GetAllConfiguredRenderPipelines = "UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines";
    public const string MONO_GetCustomShader = "UnityEngine.Rendering.GraphicsSettings::GetCustomShader";
    public const string MONO_GetGraphicsSettings = "UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings";
    public const string MONO_GetSettingsForRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::GetSettingsForRenderPipeline";
    public const string MONO_GetShaderMode = "UnityEngine.Rendering.GraphicsSettings::GetShaderMode";
    public const string MONO_HasShaderDefine = "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine";
    public const string MONO_RegisterRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::RegisterRenderPipeline";
    public const string MONO_SetDefaultRenderingLayerMask = "UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask";
    public const string MONO_SetDisableBuiltinCustomRenderTextureUpdate = "UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate";
    public const string MONO_SetInternalDefaultRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline";
    public const string MONO_SetLightsUseColorTemperature = "UnityEngine.Rendering.GraphicsSettings::set_lightsUseColorTemperature";
    public const string MONO_SetLightsUseLinearIntensity = "UnityEngine.Rendering.GraphicsSettings::set_lightsUseLinearIntensity";
    public const string MONO_SetLogWhenShaderIsCompiled = "UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled";
    public const string MONO_SetRealtimeDirectRectangularAreaLights = "UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights";
    public const string MONO_SetTransparencySortAxisInjected = "UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected";
    public const string MONO_SetTransparencySortMode = "UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode";
    public const string MONO_SetUseScriptableRenderPipelineBatching = "UnityEngine.Rendering.GraphicsSettings::set_useScriptableRenderPipelineBatching";
    public const string MONO_SetCustomShader = "UnityEngine.Rendering.GraphicsSettings::SetCustomShader";
    public const string MONO_SetShaderMode = "UnityEngine.Rendering.GraphicsSettings::SetShaderMode";
    public const string MONO_UnregisterRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::UnregisterRenderPipeline";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_GraphicsSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_GraphicsSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_GraphicsSettings(nint ptr) => new Ptr_UnityEngine_Rendering_GraphicsSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_GraphicsSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_GraphicsSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_INTERNAL_currentRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipeline()";
    public const string IL2CPP_get_lightsUseLinearIntensity = "UnityEngine.Rendering.GraphicsSettings::get_lightsUseLinearIntensity()";
    public const string IL2CPP_GetSettingsForRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::GetSettingsForRenderPipeline(System.String)";
    public const string IL2CPP_HasShaderDefine = "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)";
    public const string IL2CPP_RegisterRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::RegisterRenderPipeline(System.String,UnityEngine.Object)";
    public const string IL2CPP_set_defaultRenderingLayerMask = "UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask(System.UInt32)";
    public const string IL2CPP_set_INTERNAL_defaultRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline(UnityEngine.ScriptableObject)";
    public const string IL2CPP_set_lightsUseColorTemperature = "UnityEngine.Rendering.GraphicsSettings::set_lightsUseColorTemperature(System.Boolean)";
    public const string IL2CPP_set_lightsUseLinearIntensity = "UnityEngine.Rendering.GraphicsSettings::set_lightsUseLinearIntensity(System.Boolean)";
    public const string IL2CPP_set_useScriptableRenderPipelineBatching = "UnityEngine.Rendering.GraphicsSettings::set_useScriptableRenderPipelineBatching(System.Boolean)";
    public const string IL2CPP_UnregisterRenderPipeline = "UnityEngine.Rendering.GraphicsSettings::UnregisterRenderPipeline(System.String)";
}

