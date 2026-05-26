namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioLowPassFilter
{
    public const string MONO_GetCutoffFrequency = "UnityEngine.AudioLowPassFilter::get_cutoffFrequency";
    public const string MONO_GetLowpassResonanceQ = "UnityEngine.AudioLowPassFilter::get_lowpassResonanceQ";
    public const string MONO_GetCustomLowpassLevelCurveCopy = "UnityEngine.AudioLowPassFilter::GetCustomLowpassLevelCurveCopy";
    public const string MONO_SetCutoffFrequency = "UnityEngine.AudioLowPassFilter::set_cutoffFrequency";
    public const string MONO_SetLowpassResonanceQ = "UnityEngine.AudioLowPassFilter::set_lowpassResonanceQ";
    public const string MONO_SetCustomLowpassLevelCurveHelper = "UnityEngine.AudioLowPassFilter::SetCustomLowpassLevelCurveHelper";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioLowPassFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioLowPassFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioLowPassFilter(nint ptr) => new Ptr_UnityEngine_AudioLowPassFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioLowPassFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioLowPassFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
