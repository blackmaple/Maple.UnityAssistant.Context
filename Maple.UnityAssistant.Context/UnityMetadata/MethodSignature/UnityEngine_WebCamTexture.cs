namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_WebCamTexture
{
    public const string MONO_GetDeviceName = "UnityEngine.WebCamTexture::get_deviceName";
    public const string MONO_GetDevices = "UnityEngine.WebCamTexture::get_devices";
    public const string MONO_GetDidUpdateThisFrame = "UnityEngine.WebCamTexture::get_didUpdateThisFrame";
    public const string MONO_GetInternalAutoFocusPointInjected = "UnityEngine.WebCamTexture::get_internalAutoFocusPoint_Injected";
    public const string MONO_GetIsDepth = "UnityEngine.WebCamTexture::get_isDepth";
    public const string MONO_GetIsPlaying = "UnityEngine.WebCamTexture::get_isPlaying";
    public const string MONO_GetRequestedFps = "UnityEngine.WebCamTexture::get_requestedFPS";
    public const string MONO_GetRequestedHeight = "UnityEngine.WebCamTexture::get_requestedHeight";
    public const string MONO_GetRequestedWidth = "UnityEngine.WebCamTexture::get_requestedWidth";
    public const string MONO_GetVideoRotationAngle = "UnityEngine.WebCamTexture::get_videoRotationAngle";
    public const string MONO_GetVideoVerticallyMirrored = "UnityEngine.WebCamTexture::get_videoVerticallyMirrored";
    public const string MONO_GetPixelInjected = "UnityEngine.WebCamTexture::GetPixel_Injected";
    public const string MONO_GetPixels = "UnityEngine.WebCamTexture::GetPixels";
    public const string MONO_GetPixels32 = "UnityEngine.WebCamTexture::GetPixels32";
    public const string MONO_InternalCreateWebCamTexture = "UnityEngine.WebCamTexture::Internal_CreateWebCamTexture";
    public const string MONO_Pause = "UnityEngine.WebCamTexture::Pause";
    public const string MONO_Play = "UnityEngine.WebCamTexture::Play";
    public const string MONO_SetDeviceName = "UnityEngine.WebCamTexture::set_deviceName";
    public const string MONO_SetInternalAutoFocusPointInjected = "UnityEngine.WebCamTexture::set_internalAutoFocusPoint_Injected";
    public const string MONO_SetRequestedFps = "UnityEngine.WebCamTexture::set_requestedFPS";
    public const string MONO_SetRequestedHeight = "UnityEngine.WebCamTexture::set_requestedHeight";
    public const string MONO_SetRequestedWidth = "UnityEngine.WebCamTexture::set_requestedWidth";
    public const string MONO_Stop = "UnityEngine.WebCamTexture::Stop";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_WebCamTexture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_WebCamTexture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_WebCamTexture(nint ptr) => new Ptr_UnityEngine_WebCamTexture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_WebCamTexture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_WebCamTexture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
