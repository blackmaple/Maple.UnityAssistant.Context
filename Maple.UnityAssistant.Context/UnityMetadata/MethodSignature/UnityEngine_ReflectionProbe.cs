namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ReflectionProbe
{
    public const string MONO_BlendCubemap = "UnityEngine.ReflectionProbe::BlendCubemap";
    public const string MONO_GetBackgroundColorInjected = "UnityEngine.ReflectionProbe::get_backgroundColor_Injected";
    public const string MONO_GetBakedTexture = "UnityEngine.ReflectionProbe::get_bakedTexture";
    public const string MONO_GetBlendDistance = "UnityEngine.ReflectionProbe::get_blendDistance";
    public const string MONO_GetBoundsInjected = "UnityEngine.ReflectionProbe::get_bounds_Injected";
    public const string MONO_GetBoxProjection = "UnityEngine.ReflectionProbe::get_boxProjection";
    public const string MONO_GetCenterInjected = "UnityEngine.ReflectionProbe::get_center_Injected";
    public const string MONO_GetClearFlags = "UnityEngine.ReflectionProbe::get_clearFlags";
    public const string MONO_GetCullingMask = "UnityEngine.ReflectionProbe::get_cullingMask";
    public const string MONO_GetCustomBakedTexture = "UnityEngine.ReflectionProbe::get_customBakedTexture";
    public const string MONO_GetDefaultTexture = "UnityEngine.ReflectionProbe::get_defaultTexture";
    public const string MONO_GetDefaultTextureHdrdecodeValuesInjected = "UnityEngine.ReflectionProbe::get_defaultTextureHDRDecodeValues_Injected";
    public const string MONO_GetFarClipPlane = "UnityEngine.ReflectionProbe::get_farClipPlane";
    public const string MONO_GetHdr = "UnityEngine.ReflectionProbe::get_hdr";
    public const string MONO_GetImportance = "UnityEngine.ReflectionProbe::get_importance";
    public const string MONO_GetIntensity = "UnityEngine.ReflectionProbe::get_intensity";
    public const string MONO_GetMaxBakedCubemapResolution = "UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution";
    public const string MONO_GetMinBakedCubemapResolution = "UnityEngine.ReflectionProbe::get_minBakedCubemapResolution";
    public const string MONO_GetMode = "UnityEngine.ReflectionProbe::get_mode";
    public const string MONO_GetNearClipPlane = "UnityEngine.ReflectionProbe::get_nearClipPlane";
    public const string MONO_GetRealtimeTexture = "UnityEngine.ReflectionProbe::get_realtimeTexture";
    public const string MONO_GetRefreshMode = "UnityEngine.ReflectionProbe::get_refreshMode";
    public const string MONO_GetRenderDynamicObjects = "UnityEngine.ReflectionProbe::get_renderDynamicObjects";
    public const string MONO_GetResolution = "UnityEngine.ReflectionProbe::get_resolution";
    public const string MONO_GetShadowDistance = "UnityEngine.ReflectionProbe::get_shadowDistance";
    public const string MONO_GetSizeInjected = "UnityEngine.ReflectionProbe::get_size_Injected";
    public const string MONO_GetTexture = "UnityEngine.ReflectionProbe::get_texture";
    public const string MONO_GetTextureHdrdecodeValuesInjected = "UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected";
    public const string MONO_GetTimeSlicingMode = "UnityEngine.ReflectionProbe::get_timeSlicingMode";
    public const string MONO_GetType = "UnityEngine.ReflectionProbe::get_type";
    public const string MONO_IsFinishedRendering = "UnityEngine.ReflectionProbe::IsFinishedRendering";
    public const string MONO_Reset = "UnityEngine.ReflectionProbe::Reset";
    public const string MONO_ScheduleRender = "UnityEngine.ReflectionProbe::ScheduleRender";
    public const string MONO_SetBackgroundColorInjected = "UnityEngine.ReflectionProbe::set_backgroundColor_Injected";
    public const string MONO_SetBakedTexture = "UnityEngine.ReflectionProbe::set_bakedTexture";
    public const string MONO_SetBlendDistance = "UnityEngine.ReflectionProbe::set_blendDistance";
    public const string MONO_SetBoxProjection = "UnityEngine.ReflectionProbe::set_boxProjection";
    public const string MONO_SetCenterInjected = "UnityEngine.ReflectionProbe::set_center_Injected";
    public const string MONO_SetClearFlags = "UnityEngine.ReflectionProbe::set_clearFlags";
    public const string MONO_SetCullingMask = "UnityEngine.ReflectionProbe::set_cullingMask";
    public const string MONO_SetCustomBakedTexture = "UnityEngine.ReflectionProbe::set_customBakedTexture";
    public const string MONO_SetFarClipPlane = "UnityEngine.ReflectionProbe::set_farClipPlane";
    public const string MONO_SetHdr = "UnityEngine.ReflectionProbe::set_hdr";
    public const string MONO_SetImportance = "UnityEngine.ReflectionProbe::set_importance";
    public const string MONO_SetIntensity = "UnityEngine.ReflectionProbe::set_intensity";
    public const string MONO_SetMode = "UnityEngine.ReflectionProbe::set_mode";
    public const string MONO_SetNearClipPlane = "UnityEngine.ReflectionProbe::set_nearClipPlane";
    public const string MONO_SetRealtimeTexture = "UnityEngine.ReflectionProbe::set_realtimeTexture";
    public const string MONO_SetRefreshMode = "UnityEngine.ReflectionProbe::set_refreshMode";
    public const string MONO_SetRenderDynamicObjects = "UnityEngine.ReflectionProbe::set_renderDynamicObjects";
    public const string MONO_SetResolution = "UnityEngine.ReflectionProbe::set_resolution";
    public const string MONO_SetShadowDistance = "UnityEngine.ReflectionProbe::set_shadowDistance";
    public const string MONO_SetSizeInjected = "UnityEngine.ReflectionProbe::set_size_Injected";
    public const string MONO_SetTimeSlicingMode = "UnityEngine.ReflectionProbe::set_timeSlicingMode";
    public const string MONO_SetType = "UnityEngine.ReflectionProbe::set_type";
    public const string MONO_UpdateCachedState = "UnityEngine.ReflectionProbe::UpdateCachedState";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ReflectionProbe : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ReflectionProbe(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ReflectionProbe(nint ptr) => new Ptr_UnityEngine_ReflectionProbe(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ReflectionProbe ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ReflectionProbe ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_defaultTexture = "UnityEngine.ReflectionProbe::get_defaultTexture()";
    public const string IL2CPP_get_defaultTextureHDRDecodeValues_Injected = "UnityEngine.ReflectionProbe::get_defaultTextureHDRDecodeValues_Injected(UnityEngine.Vector4&)";
}

