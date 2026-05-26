namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_WebCam_PhotoCapture
{
    public const string MONO_CapturePhotoToDiskInternal = "UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToDisk_Internal";
    public const string MONO_CapturePhotoToMemoryInternal = "UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToMemory_Internal";
    public const string MONO_DisposeInternal = "UnityEngine.Windows.WebCam.PhotoCapture::Dispose_Internal";
    public const string MONO_DisposeThreadedInternal = "UnityEngine.Windows.WebCam.PhotoCapture::DisposeThreaded_Internal";
    public const string MONO_GetSupportedResolutionsInternal = "UnityEngine.Windows.WebCam.PhotoCapture::GetSupportedResolutions_Internal";
    public const string MONO_GetUnsafePointerToVideoDeviceController = "UnityEngine.Windows.WebCam.PhotoCapture::GetUnsafePointerToVideoDeviceController";
    public const string MONO_InstantiateInternal = "UnityEngine.Windows.WebCam.PhotoCapture::Instantiate_Internal";
    public const string MONO_StartPhotoModeInternalInjected = "UnityEngine.Windows.WebCam.PhotoCapture::StartPhotoMode_Internal_Injected";
    public const string MONO_StopPhotoModeAsync = "UnityEngine.Windows.WebCam.PhotoCapture::StopPhotoModeAsync";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_WebCam_PhotoCapture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_WebCam_PhotoCapture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_WebCam_PhotoCapture(nint ptr) => new Ptr_UnityEngine_Windows_WebCam_PhotoCapture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_WebCam_PhotoCapture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_WebCam_PhotoCapture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Dispose_Internal = "UnityEngine.Windows.WebCam.PhotoCapture::Dispose_Internal()";
    public const string IL2CPP_DisposeThreaded_Internal = "UnityEngine.Windows.WebCam.PhotoCapture::DisposeThreaded_Internal()";
}

