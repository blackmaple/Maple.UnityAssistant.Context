namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CloudStreaming
{
    public const string MONO_DisableMicRecording = "UnityEngine.CloudStreaming::DisableMicRecording";
    public const string MONO_EnableMicRecording = "UnityEngine.CloudStreaming::EnableMicRecording";
    public const string MONO_PeekMessage = "UnityEngine.CloudStreaming::PeekMessage";
    public const string MONO_PeekRemoteAudioCapture = "UnityEngine.CloudStreaming::PeekRemoteAudioCapture";
    public const string MONO_PostMessage = "UnityEngine.CloudStreaming::PostMessage";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CloudStreaming : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CloudStreaming(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CloudStreaming(nint ptr) => new Ptr_UnityEngine_CloudStreaming(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CloudStreaming ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CloudStreaming ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
