namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_WebCam_PhotoCaptureFrame
{
    public const string MONO_CopyRawImageDataIntoBufferInternal = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::CopyRawImageDataIntoBuffer_Internal";
    public const string MONO_DisposeInternal = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::Dispose_Internal";
    public const string MONO_GetCameraToWorldMatrixInjected = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCameraToWorldMatrix_Injected";
    public const string MONO_GetCapturePixelFormat = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCapturePixelFormat";
    public const string MONO_GetDataLength = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetDataLength";
    public const string MONO_GetHasLocationData = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetHasLocationData";
    public const string MONO_GetProjectionInjected = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetProjection_Injected";
    public const string MONO_GetUnsafePointerToBuffer = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetUnsafePointerToBuffer";
    public const string MONO_UploadImageDataToTextureInternal = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::UploadImageDataToTexture_Internal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame(nint ptr) => new Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_WebCam_PhotoCaptureFrame ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Dispose_Internal = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::Dispose_Internal()";
    public const string IL2CPP_GetCapturePixelFormat = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCapturePixelFormat()";
    public const string IL2CPP_GetDataLength = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetDataLength()";
    public const string IL2CPP_GetHasLocationData = "UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetHasLocationData()";
}

