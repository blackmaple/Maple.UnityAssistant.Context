namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_MemorylessManager
{
    public const string MONO_GetFramebufferDepthMemorylessMode = "UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode";
    public const string MONO_SetFramebufferDepthMemorylessMode = "UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_MemorylessManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_MemorylessManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_MemorylessManager(nint ptr) => new Ptr_UnityEngineInternal_MemorylessManager(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_MemorylessManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_MemorylessManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
