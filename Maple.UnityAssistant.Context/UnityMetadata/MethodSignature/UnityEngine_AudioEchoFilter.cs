namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioEchoFilter
{
    public const string MONO_GetDecayRatio = "UnityEngine.AudioEchoFilter::get_decayRatio";
    public const string MONO_GetDelay = "UnityEngine.AudioEchoFilter::get_delay";
    public const string MONO_GetDryMix = "UnityEngine.AudioEchoFilter::get_dryMix";
    public const string MONO_GetWetMix = "UnityEngine.AudioEchoFilter::get_wetMix";
    public const string MONO_SetDecayRatio = "UnityEngine.AudioEchoFilter::set_decayRatio";
    public const string MONO_SetDelay = "UnityEngine.AudioEchoFilter::set_delay";
    public const string MONO_SetDryMix = "UnityEngine.AudioEchoFilter::set_dryMix";
    public const string MONO_SetWetMix = "UnityEngine.AudioEchoFilter::set_wetMix";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioEchoFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioEchoFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioEchoFilter(nint ptr) => new Ptr_UnityEngine_AudioEchoFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioEchoFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioEchoFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
