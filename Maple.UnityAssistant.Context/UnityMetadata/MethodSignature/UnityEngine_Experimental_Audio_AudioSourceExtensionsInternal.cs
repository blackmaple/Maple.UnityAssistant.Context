namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal
{
    public const string MONO_InternalRegisterSampleProviderWithAudioSource = "UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_RegisterSampleProviderWithAudioSource";
    public const string MONO_InternalUnregisterSampleProviderFromAudioSource = "UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_UnregisterSampleProviderFromAudioSource";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal(nint ptr) => new Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Audio_AudioSourceExtensionsInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
