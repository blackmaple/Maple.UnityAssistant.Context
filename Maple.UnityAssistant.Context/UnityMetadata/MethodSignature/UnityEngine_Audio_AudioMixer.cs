namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Audio_AudioMixer
{
    public const string MONO_ClearFloat = "UnityEngine.Audio.AudioMixer::ClearFloat";
    public const string MONO_FindMatchingGroups = "UnityEngine.Audio.AudioMixer::FindMatchingGroups";
    public const string MONO_FindSnapshot = "UnityEngine.Audio.AudioMixer::FindSnapshot";
    public const string MONO_GetOutputAudioMixerGroup = "UnityEngine.Audio.AudioMixer::get_outputAudioMixerGroup";
    public const string MONO_GetUpdateMode = "UnityEngine.Audio.AudioMixer::get_updateMode";
    public const string MONO_GetFloat = "UnityEngine.Audio.AudioMixer::GetFloat";
    public const string MONO_SetOutputAudioMixerGroup = "UnityEngine.Audio.AudioMixer::set_outputAudioMixerGroup";
    public const string MONO_SetUpdateMode = "UnityEngine.Audio.AudioMixer::set_updateMode";
    public const string MONO_SetFloat = "UnityEngine.Audio.AudioMixer::SetFloat";
    public const string MONO_TransitionToSnapshotInternal = "UnityEngine.Audio.AudioMixer::TransitionToSnapshotInternal";
    public const string MONO_TransitionToSnapshots = "UnityEngine.Audio.AudioMixer::TransitionToSnapshots";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Audio_AudioMixer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Audio_AudioMixer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Audio_AudioMixer(nint ptr) => new Ptr_UnityEngine_Audio_AudioMixer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Audio_AudioMixer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Audio_AudioMixer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetFloat = "UnityEngine.Audio.AudioMixer::GetFloat(System.String,System.Single&)";
    public const string IL2CPP_SetFloat = "UnityEngine.Audio.AudioMixer::SetFloat(System.String,System.Single)";
}

