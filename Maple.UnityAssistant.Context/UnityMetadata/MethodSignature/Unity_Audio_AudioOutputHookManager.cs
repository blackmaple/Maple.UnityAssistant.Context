namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_AudioOutputHookManager
{
    public const string MONO_InternalCreateAudioOutputHook = "Unity.Audio.AudioOutputHookManager::Internal_CreateAudioOutputHook";
    public const string MONO_InternalDisposeAudioOutputHook = "Unity.Audio.AudioOutputHookManager::Internal_DisposeAudioOutputHook";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_AudioOutputHookManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_AudioOutputHookManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_AudioOutputHookManager(nint ptr) => new Ptr_Unity_Audio_AudioOutputHookManager(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_AudioOutputHookManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_AudioOutputHookManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
