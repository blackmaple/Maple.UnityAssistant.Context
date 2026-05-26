namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRSettings
{
    public const string MONO_GetDeviceEyeTextureDimension = "UnityEngine.XR.XRSettings::get_deviceEyeTextureDimension";
    public const string MONO_GetEnabled = "UnityEngine.XR.XRSettings::get_enabled";
    public const string MONO_GetEyeTextureDescInjected = "UnityEngine.XR.XRSettings::get_eyeTextureDesc_Injected";
    public const string MONO_GetEyeTextureHeight = "UnityEngine.XR.XRSettings::get_eyeTextureHeight";
    public const string MONO_GetEyeTextureResolutionScale = "UnityEngine.XR.XRSettings::get_eyeTextureResolutionScale";
    public const string MONO_GetEyeTextureWidth = "UnityEngine.XR.XRSettings::get_eyeTextureWidth";
    public const string MONO_GetGameViewRenderMode = "UnityEngine.XR.XRSettings::get_gameViewRenderMode";
    public const string MONO_GetIsDeviceActive = "UnityEngine.XR.XRSettings::get_isDeviceActive";
    public const string MONO_GetLoadedDeviceName = "UnityEngine.XR.XRSettings::get_loadedDeviceName";
    public const string MONO_GetOcclusionMaskScale = "UnityEngine.XR.XRSettings::get_occlusionMaskScale";
    public const string MONO_GetRenderViewportScaleInternal = "UnityEngine.XR.XRSettings::get_renderViewportScaleInternal";
    public const string MONO_GetShowDeviceView = "UnityEngine.XR.XRSettings::get_showDeviceView";
    public const string MONO_GetStereoRenderingMode = "UnityEngine.XR.XRSettings::get_stereoRenderingMode";
    public const string MONO_GetSupportedDevices = "UnityEngine.XR.XRSettings::get_supportedDevices";
    public const string MONO_GetUseOcclusionMesh = "UnityEngine.XR.XRSettings::get_useOcclusionMesh";
    public const string MONO_LoadDeviceByName = "UnityEngine.XR.XRSettings::LoadDeviceByName";
    public const string MONO_SetEnabled = "UnityEngine.XR.XRSettings::set_enabled";
    public const string MONO_SetEyeTextureResolutionScale = "UnityEngine.XR.XRSettings::set_eyeTextureResolutionScale";
    public const string MONO_SetGameViewRenderMode = "UnityEngine.XR.XRSettings::set_gameViewRenderMode";
    public const string MONO_SetOcclusionMaskScale = "UnityEngine.XR.XRSettings::set_occlusionMaskScale";
    public const string MONO_SetRenderViewportScaleInternal = "UnityEngine.XR.XRSettings::set_renderViewportScaleInternal";
    public const string MONO_SetShowDeviceView = "UnityEngine.XR.XRSettings::set_showDeviceView";
    public const string MONO_SetUseOcclusionMesh = "UnityEngine.XR.XRSettings::set_useOcclusionMesh";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRSettings(nint ptr) => new Ptr_UnityEngine_XR_XRSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_enabled = "UnityEngine.XR.XRSettings::get_enabled()";
    public const string IL2CPP_get_eyeTextureDesc_Injected = "UnityEngine.XR.XRSettings::get_eyeTextureDesc_Injected(UnityEngine.RenderTextureDescriptor&)";
    public const string IL2CPP_get_eyeTextureHeight = "UnityEngine.XR.XRSettings::get_eyeTextureHeight()";
    public const string IL2CPP_get_eyeTextureResolutionScale = "UnityEngine.XR.XRSettings::get_eyeTextureResolutionScale()";
    public const string IL2CPP_get_eyeTextureWidth = "UnityEngine.XR.XRSettings::get_eyeTextureWidth()";
    public const string IL2CPP_get_isDeviceActive = "UnityEngine.XR.XRSettings::get_isDeviceActive()";
    public const string IL2CPP_get_loadedDeviceName = "UnityEngine.XR.XRSettings::get_loadedDeviceName()";
    public const string IL2CPP_get_renderViewportScaleInternal = "UnityEngine.XR.XRSettings::get_renderViewportScaleInternal()";
    public const string IL2CPP_get_stereoRenderingMode = "UnityEngine.XR.XRSettings::get_stereoRenderingMode()";
    public const string IL2CPP_get_supportedDevices = "UnityEngine.XR.XRSettings::get_supportedDevices()";
    public const string IL2CPP_set_eyeTextureResolutionScale = "UnityEngine.XR.XRSettings::set_eyeTextureResolutionScale(System.Single)";
}

