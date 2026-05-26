namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRDevice
{
    public const string MONO_DisableAutoXrcameraTracking = "UnityEngine.XR.XRDevice::DisableAutoXRCameraTracking";
    public const string MONO_GetFovZoomFactor = "UnityEngine.XR.XRDevice::get_fovZoomFactor";
    public const string MONO_GetRefreshRate = "UnityEngine.XR.XRDevice::get_refreshRate";
    public const string MONO_GetNativePtr = "UnityEngine.XR.XRDevice::GetNativePtr";
    public const string MONO_GetTrackingSpaceType = "UnityEngine.XR.XRDevice::GetTrackingSpaceType";
    public const string MONO_SetFovZoomFactor = "UnityEngine.XR.XRDevice::set_fovZoomFactor";
    public const string MONO_SetTrackingSpaceType = "UnityEngine.XR.XRDevice::SetTrackingSpaceType";
    public const string MONO_UpdateEyeTextureMsaasetting = "UnityEngine.XR.XRDevice::UpdateEyeTextureMSAASetting";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRDevice : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRDevice(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRDevice(nint ptr) => new Ptr_UnityEngine_XR_XRDevice(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRDevice ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRDevice ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DisableAutoXRCameraTracking = "UnityEngine.XR.XRDevice::DisableAutoXRCameraTracking(UnityEngine.Camera,System.Boolean)";
}

