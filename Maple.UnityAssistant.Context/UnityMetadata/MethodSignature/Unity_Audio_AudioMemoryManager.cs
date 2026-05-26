namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_AudioMemoryManager
{
    public const string MONO_InternalAllocateAudioMemory = "Unity.Audio.AudioMemoryManager::Internal_AllocateAudioMemory";
    public const string MONO_InternalFreeAudioMemory = "Unity.Audio.AudioMemoryManager::Internal_FreeAudioMemory";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_AudioMemoryManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_AudioMemoryManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_AudioMemoryManager(nint ptr) => new Ptr_Unity_Audio_AudioMemoryManager(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_AudioMemoryManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_AudioMemoryManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }


}




