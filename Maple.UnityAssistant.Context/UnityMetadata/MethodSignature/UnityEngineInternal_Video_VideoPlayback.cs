namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_Video_VideoPlayback
{
    public const string MONO_CanNotSkipOnDrop = "UnityEngineInternal.Video.VideoPlayback::CanNotSkipOnDrop";
    public const string MONO_CanStep = "UnityEngineInternal.Video.VideoPlayback::CanStep";
    public const string MONO_GetAudioChannelCount = "UnityEngineInternal.Video.VideoPlayback::GetAudioChannelCount";
    public const string MONO_GetAudioSampleProviderId = "UnityEngineInternal.Video.VideoPlayback::GetAudioSampleProviderId";
    public const string MONO_GetAudioSampleRate = "UnityEngineInternal.Video.VideoPlayback::GetAudioSampleRate";
    public const string MONO_GetAudioTrackCount = "UnityEngineInternal.Video.VideoPlayback::GetAudioTrackCount";
    public const string MONO_GetDuration = "UnityEngineInternal.Video.VideoPlayback::GetDuration";
    public const string MONO_GetFrameCount = "UnityEngineInternal.Video.VideoPlayback::GetFrameCount";
    public const string MONO_GetFrameRate = "UnityEngineInternal.Video.VideoPlayback::GetFrameRate";
    public const string MONO_GetHeight = "UnityEngineInternal.Video.VideoPlayback::GetHeight";
    public const string MONO_GetLoop = "UnityEngineInternal.Video.VideoPlayback::GetLoop";
    public const string MONO_GetPixelAspectRatioDenominator = "UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioDenominator";
    public const string MONO_GetPixelAspectRatioNumerator = "UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioNumerator";
    public const string MONO_GetPixelFormat = "UnityEngineInternal.Video.VideoPlayback::GetPixelFormat";
    public const string MONO_GetPlaybackSpeed = "UnityEngineInternal.Video.VideoPlayback::GetPlaybackSpeed";
    public const string MONO_GetStatus = "UnityEngineInternal.Video.VideoPlayback::GetStatus";
    public const string MONO_GetTexture = "UnityEngineInternal.Video.VideoPlayback::GetTexture";
    public const string MONO_GetWidth = "UnityEngineInternal.Video.VideoPlayback::GetWidth";
    public const string MONO_IsPlaying = "UnityEngineInternal.Video.VideoPlayback::IsPlaying";
    public const string MONO_IsReady = "UnityEngineInternal.Video.VideoPlayback::IsReady";
    public const string MONO_PausePlayback = "UnityEngineInternal.Video.VideoPlayback::PausePlayback";
    public const string MONO_PlatformSupportsH265 = "UnityEngineInternal.Video.VideoPlayback::PlatformSupportsH265";
    public const string MONO_SeekToFrame = "UnityEngineInternal.Video.VideoPlayback::SeekToFrame";
    public const string MONO_SeekToTime = "UnityEngineInternal.Video.VideoPlayback::SeekToTime";
    public const string MONO_SetAdjustToLinearSpace = "UnityEngineInternal.Video.VideoPlayback::SetAdjustToLinearSpace";
    public const string MONO_SetAudioTarget = "UnityEngineInternal.Video.VideoPlayback::SetAudioTarget";
    public const string MONO_SetLoop = "UnityEngineInternal.Video.VideoPlayback::SetLoop";
    public const string MONO_SetPlaybackSpeed = "UnityEngineInternal.Video.VideoPlayback::SetPlaybackSpeed";
    public const string MONO_SetSkipOnDrop = "UnityEngineInternal.Video.VideoPlayback::SetSkipOnDrop";
    public const string MONO_StartPlayback = "UnityEngineInternal.Video.VideoPlayback::StartPlayback";
    public const string MONO_Step = "UnityEngineInternal.Video.VideoPlayback::Step";
    public const string MONO_StopPlayback = "UnityEngineInternal.Video.VideoPlayback::StopPlayback";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_Video_VideoPlayback : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_Video_VideoPlayback(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_Video_VideoPlayback(nint ptr) => new Ptr_UnityEngineInternal_Video_VideoPlayback(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_Video_VideoPlayback ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_Video_VideoPlayback ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
