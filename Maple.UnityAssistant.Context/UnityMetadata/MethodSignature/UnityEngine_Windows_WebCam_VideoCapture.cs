namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_WebCam_VideoCapture
{
    public const string MONO_DisposeInternal = "UnityEngine.Windows.WebCam.VideoCapture::Dispose_Internal";
    public const string MONO_DisposeThreadedInternal = "UnityEngine.Windows.WebCam.VideoCapture::DisposeThreaded_Internal";
    public const string MONO_GetIsRecording = "UnityEngine.Windows.WebCam.VideoCapture::get_IsRecording";
    public const string MONO_GetSupportedFrameRatesForResolutionInternal = "UnityEngine.Windows.WebCam.VideoCapture::GetSupportedFrameRatesForResolution_Internal";
    public const string MONO_GetSupportedResolutionsInternal = "UnityEngine.Windows.WebCam.VideoCapture::GetSupportedResolutions_Internal";
    public const string MONO_GetUnsafePointerToVideoDeviceController = "UnityEngine.Windows.WebCam.VideoCapture::GetUnsafePointerToVideoDeviceController";
    public const string MONO_InstantiateInternal = "UnityEngine.Windows.WebCam.VideoCapture::Instantiate_Internal";
    public const string MONO_StartRecordingVideoToDiskInternal = "UnityEngine.Windows.WebCam.VideoCapture::StartRecordingVideoToDisk_Internal";
    public const string MONO_StartVideoModeInternalInjected = "UnityEngine.Windows.WebCam.VideoCapture::StartVideoMode_Internal_Injected";
    public const string MONO_StopRecordingAsync = "UnityEngine.Windows.WebCam.VideoCapture::StopRecordingAsync";
    public const string MONO_StopVideoModeAsync = "UnityEngine.Windows.WebCam.VideoCapture::StopVideoModeAsync";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_WebCam_VideoCapture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_WebCam_VideoCapture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_WebCam_VideoCapture(nint ptr) => new Ptr_UnityEngine_Windows_WebCam_VideoCapture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_WebCam_VideoCapture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_WebCam_VideoCapture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Dispose_Internal = "UnityEngine.Windows.WebCam.VideoCapture::Dispose_Internal()";
    public const string IL2CPP_DisposeThreaded_Internal = "UnityEngine.Windows.WebCam.VideoCapture::DisposeThreaded_Internal()";
}

