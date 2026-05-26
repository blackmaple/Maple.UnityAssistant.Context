namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioClip
{
    public const string MONO_ConstructInternal = "UnityEngine.AudioClip::Construct_Internal";
    public const string MONO_CreateUserSound = "UnityEngine.AudioClip::CreateUserSound";
    public const string MONO_GetAmbisonic = "UnityEngine.AudioClip::get_ambisonic";
    public const string MONO_GetChannels = "UnityEngine.AudioClip::get_channels";
    public const string MONO_GetFrequency = "UnityEngine.AudioClip::get_frequency";
    public const string MONO_GetIsReadyToPlay = "UnityEngine.AudioClip::get_isReadyToPlay";
    public const string MONO_GetLength = "UnityEngine.AudioClip::get_length";
    public const string MONO_GetLoadInBackground = "UnityEngine.AudioClip::get_loadInBackground";
    public const string MONO_GetLoadState = "UnityEngine.AudioClip::get_loadState";
    public const string MONO_GetLoadType = "UnityEngine.AudioClip::get_loadType";
    public const string MONO_GetPreloadAudioData = "UnityEngine.AudioClip::get_preloadAudioData";
    public const string MONO_GetSamples = "UnityEngine.AudioClip::get_samples";
    public const string MONO_GetData = "UnityEngine.AudioClip::GetData";
    public const string MONO_GetName = "UnityEngine.AudioClip::GetName";
    public const string MONO_LoadAudioData = "UnityEngine.AudioClip::LoadAudioData";
    public const string MONO_SetData = "UnityEngine.AudioClip::SetData";
    public const string MONO_UnloadAudioData = "UnityEngine.AudioClip::UnloadAudioData";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioClip : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioClip(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioClip(nint ptr) => new Ptr_UnityEngine_AudioClip(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioClip ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioClip ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Construct_Internal = "UnityEngine.AudioClip::Construct_Internal()";
    public const string IL2CPP_CreateUserSound = "UnityEngine.AudioClip::CreateUserSound(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)";
    public const string IL2CPP_get_ambisonic = "UnityEngine.AudioClip::get_ambisonic()";
    public const string IL2CPP_get_channels = "UnityEngine.AudioClip::get_channels()";
    public const string IL2CPP_get_frequency = "UnityEngine.AudioClip::get_frequency()";
    public const string IL2CPP_get_isReadyToPlay = "UnityEngine.AudioClip::get_isReadyToPlay()";
    public const string IL2CPP_get_length = "UnityEngine.AudioClip::get_length()";
    public const string IL2CPP_get_loadInBackground = "UnityEngine.AudioClip::get_loadInBackground()";
    public const string IL2CPP_get_loadState = "UnityEngine.AudioClip::get_loadState()";
    public const string IL2CPP_get_loadType = "UnityEngine.AudioClip::get_loadType()";
    public const string IL2CPP_get_preloadAudioData = "UnityEngine.AudioClip::get_preloadAudioData()";
    public const string IL2CPP_get_samples = "UnityEngine.AudioClip::get_samples()";
    public const string IL2CPP_GetData = "UnityEngine.AudioClip::GetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)";
    public const string IL2CPP_GetName = "UnityEngine.AudioClip::GetName()";
    public const string IL2CPP_LoadAudioData = "UnityEngine.AudioClip::LoadAudioData()";
    public const string IL2CPP_SetData = "UnityEngine.AudioClip::SetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)";
    public const string IL2CPP_UnloadAudioData = "UnityEngine.AudioClip::UnloadAudioData()";
}

