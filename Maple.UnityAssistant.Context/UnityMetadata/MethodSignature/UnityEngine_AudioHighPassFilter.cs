namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioHighPassFilter
{
    public const string MONO_GetCutoffFrequency = "UnityEngine.AudioHighPassFilter::get_cutoffFrequency";
    public const string MONO_GetHighpassResonanceQ = "UnityEngine.AudioHighPassFilter::get_highpassResonanceQ";
    public const string MONO_SetCutoffFrequency = "UnityEngine.AudioHighPassFilter::set_cutoffFrequency";
    public const string MONO_SetHighpassResonanceQ = "UnityEngine.AudioHighPassFilter::set_highpassResonanceQ";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioHighPassFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioHighPassFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioHighPassFilter(nint ptr) => new Ptr_UnityEngine_AudioHighPassFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioHighPassFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioHighPassFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
