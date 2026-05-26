namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Audio_AudioClipPlayable
{
    public const string MONO_GetClipInternal = "UnityEngine.Audio.AudioClipPlayable::GetClipInternal";
    public const string MONO_GetIsChannelPlayingInternal = "UnityEngine.Audio.AudioClipPlayable::GetIsChannelPlayingInternal";
    public const string MONO_GetLoopedInternal = "UnityEngine.Audio.AudioClipPlayable::GetLoopedInternal";
    public const string MONO_GetPauseDelayInternal = "UnityEngine.Audio.AudioClipPlayable::GetPauseDelayInternal";
    public const string MONO_GetSpatialBlendInternal = "UnityEngine.Audio.AudioClipPlayable::GetSpatialBlendInternal";
    public const string MONO_GetStartDelayInternal = "UnityEngine.Audio.AudioClipPlayable::GetStartDelayInternal";
    public const string MONO_GetStereoPanInternal = "UnityEngine.Audio.AudioClipPlayable::GetStereoPanInternal";
    public const string MONO_GetVolumeInternal = "UnityEngine.Audio.AudioClipPlayable::GetVolumeInternal";
    public const string MONO_InternalCreateAudioClipPlayable = "UnityEngine.Audio.AudioClipPlayable::InternalCreateAudioClipPlayable";
    public const string MONO_SetClipInternal = "UnityEngine.Audio.AudioClipPlayable::SetClipInternal";
    public const string MONO_SetLoopedInternal = "UnityEngine.Audio.AudioClipPlayable::SetLoopedInternal";
    public const string MONO_SetPauseDelayInternal = "UnityEngine.Audio.AudioClipPlayable::SetPauseDelayInternal";
    public const string MONO_SetSpatialBlendInternal = "UnityEngine.Audio.AudioClipPlayable::SetSpatialBlendInternal";
    public const string MONO_SetStartDelayInternal = "UnityEngine.Audio.AudioClipPlayable::SetStartDelayInternal";
    public const string MONO_SetStereoPanInternal = "UnityEngine.Audio.AudioClipPlayable::SetStereoPanInternal";
    public const string MONO_SetVolumeInternal = "UnityEngine.Audio.AudioClipPlayable::SetVolumeInternal";
    public const string MONO_ValidateType = "UnityEngine.Audio.AudioClipPlayable::ValidateType";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Audio_AudioClipPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Audio_AudioClipPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Audio_AudioClipPlayable(nint ptr) => new Ptr_UnityEngine_Audio_AudioClipPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Audio_AudioClipPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Audio_AudioClipPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalCreateAudioClipPlayable = "UnityEngine.Audio.AudioClipPlayable::InternalCreateAudioClipPlayable(UnityEngine.Playables.PlayableGraph&,UnityEngine.AudioClip,System.Boolean,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_SetPauseDelayInternal = "UnityEngine.Audio.AudioClipPlayable::SetPauseDelayInternal(UnityEngine.Playables.PlayableHandle&,System.Double)";
    public const string IL2CPP_SetSpatialBlendInternal = "UnityEngine.Audio.AudioClipPlayable::SetSpatialBlendInternal(UnityEngine.Playables.PlayableHandle&,System.Single)";
    public const string IL2CPP_SetStartDelayInternal = "UnityEngine.Audio.AudioClipPlayable::SetStartDelayInternal(UnityEngine.Playables.PlayableHandle&,System.Double)";
    public const string IL2CPP_SetStereoPanInternal = "UnityEngine.Audio.AudioClipPlayable::SetStereoPanInternal(UnityEngine.Playables.PlayableHandle&,System.Single)";
    public const string IL2CPP_SetVolumeInternal = "UnityEngine.Audio.AudioClipPlayable::SetVolumeInternal(UnityEngine.Playables.PlayableHandle&,System.Single)";
}

