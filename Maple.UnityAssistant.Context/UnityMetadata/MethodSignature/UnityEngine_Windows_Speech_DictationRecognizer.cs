namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_Speech_DictationRecognizer
{
    public const string MONO_Create = "UnityEngine.Windows.Speech.DictationRecognizer::Create";
    public const string MONO_Destroy = "UnityEngine.Windows.Speech.DictationRecognizer::Destroy";
    public const string MONO_DestroyThreaded = "UnityEngine.Windows.Speech.DictationRecognizer::DestroyThreaded";
    public const string MONO_GetAutoSilenceTimeoutSeconds = "UnityEngine.Windows.Speech.DictationRecognizer::GetAutoSilenceTimeoutSeconds";
    public const string MONO_GetInitialSilenceTimeoutSeconds = "UnityEngine.Windows.Speech.DictationRecognizer::GetInitialSilenceTimeoutSeconds";
    public const string MONO_GetStatus = "UnityEngine.Windows.Speech.DictationRecognizer::GetStatus";
    public const string MONO_SetAutoSilenceTimeoutSeconds = "UnityEngine.Windows.Speech.DictationRecognizer::SetAutoSilenceTimeoutSeconds";
    public const string MONO_SetInitialSilenceTimeoutSeconds = "UnityEngine.Windows.Speech.DictationRecognizer::SetInitialSilenceTimeoutSeconds";
    public const string MONO_Start = "UnityEngine.Windows.Speech.DictationRecognizer::Start";
    public const string MONO_Stop = "UnityEngine.Windows.Speech.DictationRecognizer::Stop";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_Speech_DictationRecognizer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_Speech_DictationRecognizer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_Speech_DictationRecognizer(nint ptr) => new Ptr_UnityEngine_Windows_Speech_DictationRecognizer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_Speech_DictationRecognizer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_Speech_DictationRecognizer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
