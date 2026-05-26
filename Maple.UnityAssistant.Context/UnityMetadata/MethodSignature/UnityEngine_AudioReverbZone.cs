namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioReverbZone
{
    public const string MONO_GetDecayHfratio = "UnityEngine.AudioReverbZone::get_decayHFRatio";
    public const string MONO_GetDecayTime = "UnityEngine.AudioReverbZone::get_decayTime";
    public const string MONO_GetDensity = "UnityEngine.AudioReverbZone::get_density";
    public const string MONO_GetDiffusion = "UnityEngine.AudioReverbZone::get_diffusion";
    public const string MONO_GetHfreference = "UnityEngine.AudioReverbZone::get_HFReference";
    public const string MONO_GetLfreference = "UnityEngine.AudioReverbZone::get_LFReference";
    public const string MONO_GetMaxDistance = "UnityEngine.AudioReverbZone::get_maxDistance";
    public const string MONO_GetMinDistance = "UnityEngine.AudioReverbZone::get_minDistance";
    public const string MONO_GetReflections = "UnityEngine.AudioReverbZone::get_reflections";
    public const string MONO_GetReflectionsDelay = "UnityEngine.AudioReverbZone::get_reflectionsDelay";
    public const string MONO_GetReverb = "UnityEngine.AudioReverbZone::get_reverb";
    public const string MONO_GetReverbDelay = "UnityEngine.AudioReverbZone::get_reverbDelay";
    public const string MONO_GetReverbPreset = "UnityEngine.AudioReverbZone::get_reverbPreset";
    public const string MONO_GetRoom = "UnityEngine.AudioReverbZone::get_room";
    public const string MONO_GetRoomHf = "UnityEngine.AudioReverbZone::get_roomHF";
    public const string MONO_GetRoomLf = "UnityEngine.AudioReverbZone::get_roomLF";
    public const string MONO_SetDecayHfratio = "UnityEngine.AudioReverbZone::set_decayHFRatio";
    public const string MONO_SetDecayTime = "UnityEngine.AudioReverbZone::set_decayTime";
    public const string MONO_SetDensity = "UnityEngine.AudioReverbZone::set_density";
    public const string MONO_SetDiffusion = "UnityEngine.AudioReverbZone::set_diffusion";
    public const string MONO_SetHfreference = "UnityEngine.AudioReverbZone::set_HFReference";
    public const string MONO_SetLfreference = "UnityEngine.AudioReverbZone::set_LFReference";
    public const string MONO_SetMaxDistance = "UnityEngine.AudioReverbZone::set_maxDistance";
    public const string MONO_SetMinDistance = "UnityEngine.AudioReverbZone::set_minDistance";
    public const string MONO_SetReflections = "UnityEngine.AudioReverbZone::set_reflections";
    public const string MONO_SetReflectionsDelay = "UnityEngine.AudioReverbZone::set_reflectionsDelay";
    public const string MONO_SetReverb = "UnityEngine.AudioReverbZone::set_reverb";
    public const string MONO_SetReverbDelay = "UnityEngine.AudioReverbZone::set_reverbDelay";
    public const string MONO_SetReverbPreset = "UnityEngine.AudioReverbZone::set_reverbPreset";
    public const string MONO_SetRoom = "UnityEngine.AudioReverbZone::set_room";
    public const string MONO_SetRoomHf = "UnityEngine.AudioReverbZone::set_roomHF";
    public const string MONO_SetRoomLf = "UnityEngine.AudioReverbZone::set_roomLF";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioReverbZone : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioReverbZone(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioReverbZone(nint ptr) => new Ptr_UnityEngine_AudioReverbZone(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioReverbZone ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioReverbZone ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
