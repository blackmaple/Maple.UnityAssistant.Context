namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioSettings
{
    public const string MONO_GetDriverCapabilities = "UnityEngine.AudioSettings::get_driverCapabilities";
    public const string MONO_GetDspTime = "UnityEngine.AudioSettings::get_dspTime";
    public const string MONO_GetProfilerCaptureFlags = "UnityEngine.AudioSettings::get_profilerCaptureFlags";
    public const string MONO_GetUnityAudioDisabled = "UnityEngine.AudioSettings::get_unityAudioDisabled";
    public const string MONO_GetAmbisonicDecoderPluginName = "UnityEngine.AudioSettings::GetAmbisonicDecoderPluginName";
    public const string MONO_GetConfigurationInjected = "UnityEngine.AudioSettings::GetConfiguration_Injected";
    public const string MONO_GetDspbufferSize = "UnityEngine.AudioSettings::GetDSPBufferSize";
    public const string MONO_GetSampleRate = "UnityEngine.AudioSettings::GetSampleRate";
    public const string MONO_GetSpatializerPluginName = "UnityEngine.AudioSettings::GetSpatializerPluginName";
    public const string MONO_GetSpeakerMode = "UnityEngine.AudioSettings::GetSpeakerMode";
    public const string MONO_SetConfigurationInjected = "UnityEngine.AudioSettings::SetConfiguration_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioSettings(nint ptr) => new Ptr_UnityEngine_AudioSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
