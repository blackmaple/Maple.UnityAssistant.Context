namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_Speech_PhraseRecognizer
{
    public const string MONO_CreateFromGrammarFile = "UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromGrammarFile";
    public const string MONO_CreateFromKeywords = "UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromKeywords";
    public const string MONO_Destroy = "UnityEngine.Windows.Speech.PhraseRecognizer::Destroy";
    public const string MONO_DestroyThreaded = "UnityEngine.Windows.Speech.PhraseRecognizer::DestroyThreaded";
    public const string MONO_IsRunningInternal = "UnityEngine.Windows.Speech.PhraseRecognizer::IsRunning_Internal";
    public const string MONO_StartInternal = "UnityEngine.Windows.Speech.PhraseRecognizer::Start_Internal";
    public const string MONO_StopInternal = "UnityEngine.Windows.Speech.PhraseRecognizer::Stop_Internal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_Speech_PhraseRecognizer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_Speech_PhraseRecognizer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_Speech_PhraseRecognizer(nint ptr) => new Ptr_UnityEngine_Windows_Speech_PhraseRecognizer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_Speech_PhraseRecognizer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_Speech_PhraseRecognizer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
