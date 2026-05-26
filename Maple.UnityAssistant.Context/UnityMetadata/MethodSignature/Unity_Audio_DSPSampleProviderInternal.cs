namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_DSPSampleProviderInternal
{
    public const string MONO_InternalGetChannelCount = "Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCount";
    public const string MONO_InternalGetChannelCountById = "Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCountById";
    public const string MONO_InternalGetSampleRate = "Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRate";
    public const string MONO_InternalGetSampleRateById = "Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRateById";
    public const string MONO_InternalReadFloatFromSampleProvider = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProvider";
    public const string MONO_InternalReadFloatFromSampleProviderById = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProviderById";
    public const string MONO_InternalReadSint16FromSampleProvider = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProvider";
    public const string MONO_InternalReadSint16FromSampleProviderById = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProviderById";
    public const string MONO_InternalReadUint8FromSampleProvider = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProvider";
    public const string MONO_InternalReadUint8FromSampleProviderById = "Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProviderById";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_DSPSampleProviderInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_DSPSampleProviderInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_DSPSampleProviderInternal(nint ptr) => new Ptr_Unity_Audio_DSPSampleProviderInternal(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_DSPSampleProviderInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_DSPSampleProviderInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
