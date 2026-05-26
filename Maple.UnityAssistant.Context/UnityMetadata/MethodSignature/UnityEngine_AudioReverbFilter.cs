namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioReverbFilter
{
    public const string MONO_GetDecayHfratio = "UnityEngine.AudioReverbFilter::get_decayHFRatio";
    public const string MONO_GetDecayTime = "UnityEngine.AudioReverbFilter::get_decayTime";
    public const string MONO_GetDensity = "UnityEngine.AudioReverbFilter::get_density";
    public const string MONO_GetDiffusion = "UnityEngine.AudioReverbFilter::get_diffusion";
    public const string MONO_GetDryLevel = "UnityEngine.AudioReverbFilter::get_dryLevel";
    public const string MONO_GetHfReference = "UnityEngine.AudioReverbFilter::get_hfReference";
    public const string MONO_GetLfReference = "UnityEngine.AudioReverbFilter::get_lfReference";
    public const string MONO_GetReflectionsDelay = "UnityEngine.AudioReverbFilter::get_reflectionsDelay";
    public const string MONO_GetReflectionsLevel = "UnityEngine.AudioReverbFilter::get_reflectionsLevel";
    public const string MONO_GetReverbDelay = "UnityEngine.AudioReverbFilter::get_reverbDelay";
    public const string MONO_GetReverbLevel = "UnityEngine.AudioReverbFilter::get_reverbLevel";
    public const string MONO_GetReverbPreset = "UnityEngine.AudioReverbFilter::get_reverbPreset";
    public const string MONO_GetRoom = "UnityEngine.AudioReverbFilter::get_room";
    public const string MONO_GetRoomHf = "UnityEngine.AudioReverbFilter::get_roomHF";
    public const string MONO_GetRoomLf = "UnityEngine.AudioReverbFilter::get_roomLF";
    public const string MONO_SetDecayHfratio = "UnityEngine.AudioReverbFilter::set_decayHFRatio";
    public const string MONO_SetDecayTime = "UnityEngine.AudioReverbFilter::set_decayTime";
    public const string MONO_SetDensity = "UnityEngine.AudioReverbFilter::set_density";
    public const string MONO_SetDiffusion = "UnityEngine.AudioReverbFilter::set_diffusion";
    public const string MONO_SetDryLevel = "UnityEngine.AudioReverbFilter::set_dryLevel";
    public const string MONO_SetHfReference = "UnityEngine.AudioReverbFilter::set_hfReference";
    public const string MONO_SetLfReference = "UnityEngine.AudioReverbFilter::set_lfReference";
    public const string MONO_SetReflectionsDelay = "UnityEngine.AudioReverbFilter::set_reflectionsDelay";
    public const string MONO_SetReflectionsLevel = "UnityEngine.AudioReverbFilter::set_reflectionsLevel";
    public const string MONO_SetReverbDelay = "UnityEngine.AudioReverbFilter::set_reverbDelay";
    public const string MONO_SetReverbLevel = "UnityEngine.AudioReverbFilter::set_reverbLevel";
    public const string MONO_SetReverbPreset = "UnityEngine.AudioReverbFilter::set_reverbPreset";
    public const string MONO_SetRoom = "UnityEngine.AudioReverbFilter::set_room";
    public const string MONO_SetRoomHf = "UnityEngine.AudioReverbFilter::set_roomHF";
    public const string MONO_SetRoomLf = "UnityEngine.AudioReverbFilter::set_roomLF";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioReverbFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioReverbFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioReverbFilter(nint ptr) => new Ptr_UnityEngine_AudioReverbFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioReverbFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioReverbFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
