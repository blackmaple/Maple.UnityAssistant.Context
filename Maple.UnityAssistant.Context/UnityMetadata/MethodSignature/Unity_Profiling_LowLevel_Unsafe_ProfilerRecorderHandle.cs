namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle
{
    public const string MONO_GetAvailable = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetAvailable";
    public const string MONO_GetByNameUnmanagedInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName__Unmanaged_Injected";
    public const string MONO_GetByNameInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Injected";
    public const string MONO_GetByNameUnsafeInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Unsafe_Injected";
    public const string MONO_GetDescriptionInternalInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetDescriptionInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle(nint ptr) => new Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle(ptr);
        public static implicit operator nint(Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerRecorderHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetDescriptionInternal_Injected = "Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetDescriptionInternal_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle&,Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription&)";
}

