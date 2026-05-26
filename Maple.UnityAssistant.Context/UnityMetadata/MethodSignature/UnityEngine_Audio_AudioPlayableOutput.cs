namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Audio_AudioPlayableOutput
{
    public const string MONO_InternalGetEvaluateOnSeek = "UnityEngine.Audio.AudioPlayableOutput::InternalGetEvaluateOnSeek";
    public const string MONO_InternalGetTarget = "UnityEngine.Audio.AudioPlayableOutput::InternalGetTarget";
    public const string MONO_InternalSetEvaluateOnSeek = "UnityEngine.Audio.AudioPlayableOutput::InternalSetEvaluateOnSeek";
    public const string MONO_InternalSetTarget = "UnityEngine.Audio.AudioPlayableOutput::InternalSetTarget";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Audio_AudioPlayableOutput : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Audio_AudioPlayableOutput(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Audio_AudioPlayableOutput(nint ptr) => new Ptr_UnityEngine_Audio_AudioPlayableOutput(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Audio_AudioPlayableOutput ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Audio_AudioPlayableOutput ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalSetEvaluateOnSeek = "UnityEngine.Audio.AudioPlayableOutput::InternalSetEvaluateOnSeek(UnityEngine.Playables.PlayableOutputHandle&,System.Boolean)";
    public const string IL2CPP_InternalSetTarget = "UnityEngine.Audio.AudioPlayableOutput::InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.AudioSource)";
}

