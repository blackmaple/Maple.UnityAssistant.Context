namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Profiling_Memory_Experimental_MemoryProfiler
{
    public const string MONO_StartOperation = "UnityEngine.Profiling.Memory.Experimental.MemoryProfiler::StartOperation";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler(nint ptr) => new Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
