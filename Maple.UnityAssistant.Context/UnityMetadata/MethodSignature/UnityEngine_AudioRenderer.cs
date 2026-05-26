namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioRenderer
{
    public const string MONO_InternalAudioRendererAddMixerGroupSink = "UnityEngine.AudioRenderer::Internal_AudioRenderer_AddMixerGroupSink";
    public const string MONO_InternalAudioRendererGetSampleCountForCaptureFrame = "UnityEngine.AudioRenderer::Internal_AudioRenderer_GetSampleCountForCaptureFrame";
    public const string MONO_InternalAudioRendererRender = "UnityEngine.AudioRenderer::Internal_AudioRenderer_Render";
    public const string MONO_InternalAudioRendererStart = "UnityEngine.AudioRenderer::Internal_AudioRenderer_Start";
    public const string MONO_InternalAudioRendererStop = "UnityEngine.AudioRenderer::Internal_AudioRenderer_Stop";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioRenderer(nint ptr) => new Ptr_UnityEngine_AudioRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
