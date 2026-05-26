namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Apple_FrameCapture
{
    public const string MONO_BeginCaptureImpl = "UnityEngine.Apple.FrameCapture::BeginCaptureImpl";
    public const string MONO_CaptureNextFrameImpl = "UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl";
    public const string MONO_EndCaptureImpl = "UnityEngine.Apple.FrameCapture::EndCaptureImpl";
    public const string MONO_IsDestinationSupportedImpl = "UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Apple_FrameCapture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Apple_FrameCapture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Apple_FrameCapture(nint ptr) => new Ptr_UnityEngine_Apple_FrameCapture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Apple_FrameCapture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Apple_FrameCapture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
