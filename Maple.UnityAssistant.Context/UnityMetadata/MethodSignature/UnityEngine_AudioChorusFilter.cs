namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioChorusFilter
{
    public const string MONO_GetDelay = "UnityEngine.AudioChorusFilter::get_delay";
    public const string MONO_GetDepth = "UnityEngine.AudioChorusFilter::get_depth";
    public const string MONO_GetDryMix = "UnityEngine.AudioChorusFilter::get_dryMix";
    public const string MONO_GetRate = "UnityEngine.AudioChorusFilter::get_rate";
    public const string MONO_GetWetMix1 = "UnityEngine.AudioChorusFilter::get_wetMix1";
    public const string MONO_GetWetMix2 = "UnityEngine.AudioChorusFilter::get_wetMix2";
    public const string MONO_GetWetMix3 = "UnityEngine.AudioChorusFilter::get_wetMix3";
    public const string MONO_SetDelay = "UnityEngine.AudioChorusFilter::set_delay";
    public const string MONO_SetDepth = "UnityEngine.AudioChorusFilter::set_depth";
    public const string MONO_SetDryMix = "UnityEngine.AudioChorusFilter::set_dryMix";
    public const string MONO_SetRate = "UnityEngine.AudioChorusFilter::set_rate";
    public const string MONO_SetWetMix1 = "UnityEngine.AudioChorusFilter::set_wetMix1";
    public const string MONO_SetWetMix2 = "UnityEngine.AudioChorusFilter::set_wetMix2";
    public const string MONO_SetWetMix3 = "UnityEngine.AudioChorusFilter::set_wetMix3";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioChorusFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioChorusFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioChorusFilter(nint ptr) => new Ptr_UnityEngine_AudioChorusFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioChorusFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioChorusFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
