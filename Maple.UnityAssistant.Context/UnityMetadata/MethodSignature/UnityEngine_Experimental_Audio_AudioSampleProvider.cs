namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Audio_AudioSampleProvider
{
    public const string MONO_InternalClearSampleFramesAvailableNativeHandler = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesAvailableNativeHandler";
    public const string MONO_InternalClearSampleFramesOverflowNativeHandler = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesOverflowNativeHandler";
    public const string MONO_InternalCreateSampleProvider = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalCreateSampleProvider";
    public const string MONO_InternalGetAvailableSampleFrameCount = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetAvailableSampleFrameCount";
    public const string MONO_InternalGetConsumeSampleFramesNativeFunctionPtr = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetConsumeSampleFramesNativeFunctionPtr";
    public const string MONO_InternalGetEnableSampleFramesAvailableEvents = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSampleFramesAvailableEvents";
    public const string MONO_InternalGetEnableSilencePadding = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSilencePadding";
    public const string MONO_InternalGetFormatInfo = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFormatInfo";
    public const string MONO_InternalGetFreeSampleFrameCount = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCount";
    public const string MONO_InternalGetFreeSampleFrameCountLowThreshold = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCountLowThreshold";
    public const string MONO_InternalGetMaxSampleFrameCount = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetMaxSampleFrameCount";
    public const string MONO_InternalGetScriptingPtr = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetScriptingPtr";
    public const string MONO_InternalIsValid = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalIsValid";
    public const string MONO_InternalQueueSampleFrames = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalQueueSampleFrames";
    public const string MONO_InternalRemove = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalRemove";
    public const string MONO_InternalSetEnableSampleFramesAvailableEvents = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSampleFramesAvailableEvents";
    public const string MONO_InternalSetEnableSilencePadding = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSilencePadding";
    public const string MONO_InternalSetFreeSampleFrameCountLowThreshold = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetFreeSampleFrameCountLowThreshold";
    public const string MONO_InternalSetSampleFramesAvailableNativeHandler = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesAvailableNativeHandler";
    public const string MONO_InternalSetSampleFramesOverflowNativeHandler = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesOverflowNativeHandler";
    public const string MONO_InternalSetScriptingPtr = "UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetScriptingPtr";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider(nint ptr) => new Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Audio_AudioSampleProvider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
