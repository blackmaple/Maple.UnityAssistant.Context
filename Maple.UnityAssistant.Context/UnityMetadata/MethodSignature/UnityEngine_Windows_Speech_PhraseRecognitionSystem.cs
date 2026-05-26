namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Windows_Speech_PhraseRecognitionSystem
{
    public const string MONO_GetIsSupported = "UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_isSupported";
    public const string MONO_GetStatus = "UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_Status";
    public const string MONO_Restart = "UnityEngine.Windows.Speech.PhraseRecognitionSystem::Restart";
    public const string MONO_Shutdown = "UnityEngine.Windows.Speech.PhraseRecognitionSystem::Shutdown";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem(nint ptr) => new Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Windows_Speech_PhraseRecognitionSystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
