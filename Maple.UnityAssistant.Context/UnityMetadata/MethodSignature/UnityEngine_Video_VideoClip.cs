namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Video_VideoClip
{
    public const string MONO_GetAudioTrackCount = "UnityEngine.Video.VideoClip::get_audioTrackCount";
    public const string MONO_GetFrameCount = "UnityEngine.Video.VideoClip::get_frameCount";
    public const string MONO_GetFrameRate = "UnityEngine.Video.VideoClip::get_frameRate";
    public const string MONO_GetHeight = "UnityEngine.Video.VideoClip::get_height";
    public const string MONO_GetLength = "UnityEngine.Video.VideoClip::get_length";
    public const string MONO_GetOriginalPath = "UnityEngine.Video.VideoClip::get_originalPath";
    public const string MONO_GetPixelAspectRatioDenominator = "UnityEngine.Video.VideoClip::get_pixelAspectRatioDenominator";
    public const string MONO_GetPixelAspectRatioNumerator = "UnityEngine.Video.VideoClip::get_pixelAspectRatioNumerator";
    public const string MONO_GetSRgb = "UnityEngine.Video.VideoClip::get_sRGB";
    public const string MONO_GetWidth = "UnityEngine.Video.VideoClip::get_width";
    public const string MONO_GetAudioChannelCount = "UnityEngine.Video.VideoClip::GetAudioChannelCount";
    public const string MONO_GetAudioLanguage = "UnityEngine.Video.VideoClip::GetAudioLanguage";
    public const string MONO_GetAudioSampleRate = "UnityEngine.Video.VideoClip::GetAudioSampleRate";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Video_VideoClip : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Video_VideoClip(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Video_VideoClip(nint ptr) => new Ptr_UnityEngine_Video_VideoClip(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Video_VideoClip ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Video_VideoClip ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
