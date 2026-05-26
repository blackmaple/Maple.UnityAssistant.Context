namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_DSPCommandBlockInternal
{
    public const string MONO_InternalAddAttenuationKey = "Unity.Audio.DSPCommandBlockInternal::Internal_AddAttenuationKey";
    public const string MONO_InternalAddFloatKey = "Unity.Audio.DSPCommandBlockInternal::Internal_AddFloatKey";
    public const string MONO_InternalAddInletPort = "Unity.Audio.DSPCommandBlockInternal::Internal_AddInletPort";
    public const string MONO_InternalAddOutletPort = "Unity.Audio.DSPCommandBlockInternal::Internal_AddOutletPort";
    public const string MONO_InternalCancel = "Unity.Audio.DSPCommandBlockInternal::Internal_Cancel";
    public const string MONO_InternalComplete = "Unity.Audio.DSPCommandBlockInternal::Internal_Complete";
    public const string MONO_InternalConnect = "Unity.Audio.DSPCommandBlockInternal::Internal_Connect";
    public const string MONO_InternalCreateDspnode = "Unity.Audio.DSPCommandBlockInternal::Internal_CreateDSPNode";
    public const string MONO_InternalCreateUpdateRequest = "Unity.Audio.DSPCommandBlockInternal::Internal_CreateUpdateRequest";
    public const string MONO_InternalDisconnect = "Unity.Audio.DSPCommandBlockInternal::Internal_Disconnect";
    public const string MONO_InternalDisconnectByHandle = "Unity.Audio.DSPCommandBlockInternal::Internal_DisconnectByHandle";
    public const string MONO_InternalInsertSampleProvider = "Unity.Audio.DSPCommandBlockInternal::Internal_InsertSampleProvider";
    public const string MONO_InternalReleaseDspnode = "Unity.Audio.DSPCommandBlockInternal::Internal_ReleaseDSPNode";
    public const string MONO_InternalRemoveSampleProvider = "Unity.Audio.DSPCommandBlockInternal::Internal_RemoveSampleProvider";
    public const string MONO_InternalSetAttenuation = "Unity.Audio.DSPCommandBlockInternal::Internal_SetAttenuation";
    public const string MONO_InternalSetFloat = "Unity.Audio.DSPCommandBlockInternal::Internal_SetFloat";
    public const string MONO_InternalSetSampleProvider = "Unity.Audio.DSPCommandBlockInternal::Internal_SetSampleProvider";
    public const string MONO_InternalSustainAttenuation = "Unity.Audio.DSPCommandBlockInternal::Internal_SustainAttenuation";
    public const string MONO_InternalSustainFloat = "Unity.Audio.DSPCommandBlockInternal::Internal_SustainFloat";
    public const string MONO_InternalUpdateAudioJob = "Unity.Audio.DSPCommandBlockInternal::Internal_UpdateAudioJob";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_DSPCommandBlockInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_DSPCommandBlockInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_DSPCommandBlockInternal(nint ptr) => new Ptr_Unity_Audio_DSPCommandBlockInternal(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_DSPCommandBlockInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_DSPCommandBlockInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
