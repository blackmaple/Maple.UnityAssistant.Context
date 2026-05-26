namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LightProbeProxyVolume
{
    public const string MONO_GetBoundingBoxMode = "UnityEngine.LightProbeProxyVolume::get_boundingBoxMode";
    public const string MONO_GetBoundsGlobalInjected = "UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected";
    public const string MONO_GetDataFormat = "UnityEngine.LightProbeProxyVolume::get_dataFormat";
    public const string MONO_GetGridResolutionX = "UnityEngine.LightProbeProxyVolume::get_gridResolutionX";
    public const string MONO_GetGridResolutionY = "UnityEngine.LightProbeProxyVolume::get_gridResolutionY";
    public const string MONO_GetGridResolutionZ = "UnityEngine.LightProbeProxyVolume::get_gridResolutionZ";
    public const string MONO_GetIsFeatureSupported = "UnityEngine.LightProbeProxyVolume::get_isFeatureSupported";
    public const string MONO_GetOriginCustomInjected = "UnityEngine.LightProbeProxyVolume::get_originCustom_Injected";
    public const string MONO_GetProbeDensity = "UnityEngine.LightProbeProxyVolume::get_probeDensity";
    public const string MONO_GetProbePositionMode = "UnityEngine.LightProbeProxyVolume::get_probePositionMode";
    public const string MONO_GetQualityMode = "UnityEngine.LightProbeProxyVolume::get_qualityMode";
    public const string MONO_GetRefreshMode = "UnityEngine.LightProbeProxyVolume::get_refreshMode";
    public const string MONO_GetResolutionMode = "UnityEngine.LightProbeProxyVolume::get_resolutionMode";
    public const string MONO_GetSizeCustomInjected = "UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected";
    public const string MONO_SetBoundingBoxMode = "UnityEngine.LightProbeProxyVolume::set_boundingBoxMode";
    public const string MONO_SetDataFormat = "UnityEngine.LightProbeProxyVolume::set_dataFormat";
    public const string MONO_SetGridResolutionX = "UnityEngine.LightProbeProxyVolume::set_gridResolutionX";
    public const string MONO_SetGridResolutionY = "UnityEngine.LightProbeProxyVolume::set_gridResolutionY";
    public const string MONO_SetGridResolutionZ = "UnityEngine.LightProbeProxyVolume::set_gridResolutionZ";
    public const string MONO_SetOriginCustomInjected = "UnityEngine.LightProbeProxyVolume::set_originCustom_Injected";
    public const string MONO_SetProbeDensity = "UnityEngine.LightProbeProxyVolume::set_probeDensity";
    public const string MONO_SetProbePositionMode = "UnityEngine.LightProbeProxyVolume::set_probePositionMode";
    public const string MONO_SetQualityMode = "UnityEngine.LightProbeProxyVolume::set_qualityMode";
    public const string MONO_SetRefreshMode = "UnityEngine.LightProbeProxyVolume::set_refreshMode";
    public const string MONO_SetResolutionMode = "UnityEngine.LightProbeProxyVolume::set_resolutionMode";
    public const string MONO_SetSizeCustomInjected = "UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected";
    public const string MONO_SetDirtyFlag = "UnityEngine.LightProbeProxyVolume::SetDirtyFlag";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LightProbeProxyVolume : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LightProbeProxyVolume(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LightProbeProxyVolume(nint ptr) => new Ptr_UnityEngine_LightProbeProxyVolume(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LightProbeProxyVolume ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LightProbeProxyVolume ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
