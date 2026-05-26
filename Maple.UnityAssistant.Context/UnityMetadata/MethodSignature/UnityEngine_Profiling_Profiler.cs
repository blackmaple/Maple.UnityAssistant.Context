namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Profiling_Profiler
{
    public const string MONO_AddFramesFromFileInternal = "UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal";
    public const string MONO_BeginSampleImpl = "UnityEngine.Profiling.Profiler::BeginSampleImpl";
    public const string MONO_BeginThreadProfilingInternal = "UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal";
    public const string MONO_EndSample = "UnityEngine.Profiling.Profiler::EndSample";
    public const string MONO_GetEnableAllocationCallstacks = "UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks";
    public const string MONO_GetEnableBinaryLog = "UnityEngine.Profiling.Profiler::get_enableBinaryLog";
    public const string MONO_GetEnabled = "UnityEngine.Profiling.Profiler::get_enabled";
    public const string MONO_GetLogFile = "UnityEngine.Profiling.Profiler::get_logFile";
    public const string MONO_GetMaxUsedMemory = "UnityEngine.Profiling.Profiler::get_maxUsedMemory";
    public const string MONO_GetSupported = "UnityEngine.Profiling.Profiler::get_supported";
    public const string MONO_GetUsedHeapSizeLong = "UnityEngine.Profiling.Profiler::get_usedHeapSizeLong";
    public const string MONO_GetAllocatedMemoryForGraphicsDriver = "UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver";
    public const string MONO_GetAreaEnabled = "UnityEngine.Profiling.Profiler::GetAreaEnabled";
    public const string MONO_GetCategoriesCount = "UnityEngine.Profiling.Profiler::GetCategoriesCount";
    public const string MONO_GetMonoHeapSizeLong = "UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong";
    public const string MONO_GetMonoUsedSizeLong = "UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong";
    public const string MONO_GetRuntimeMemorySizeLong = "UnityEngine.Profiling.Profiler::GetRuntimeMemorySizeLong";
    public const string MONO_GetTempAllocatorSize = "UnityEngine.Profiling.Profiler::GetTempAllocatorSize";
    public const string MONO_GetTotalAllocatedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong";
    public const string MONO_GetTotalReservedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong";
    public const string MONO_GetTotalUnusedReservedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong";
    public const string MONO_InternalEmitGlobalMetaDataArray = "UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array";
    public const string MONO_InternalEmitGlobalMetaDataNative = "UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native";
    public const string MONO_InternalIsCategoryEnabled = "UnityEngine.Profiling.Profiler::Internal_IsCategoryEnabled";
    public const string MONO_InternalSetCategoryEnabled = "UnityEngine.Profiling.Profiler::Internal_SetCategoryEnabled";
    public const string MONO_InternalGetTotalFragmentationInfo = "UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo";
    public const string MONO_SetEnableAllocationCallstacks = "UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks";
    public const string MONO_SetEnableBinaryLog = "UnityEngine.Profiling.Profiler::set_enableBinaryLog";
    public const string MONO_SetEnabled = "UnityEngine.Profiling.Profiler::set_enabled";
    public const string MONO_SetLogFile = "UnityEngine.Profiling.Profiler::set_logFile";
    public const string MONO_SetMaxUsedMemory = "UnityEngine.Profiling.Profiler::set_maxUsedMemory";
    public const string MONO_SetAreaEnabled = "UnityEngine.Profiling.Profiler::SetAreaEnabled";
    public const string MONO_SetTempAllocatorRequestedSize = "UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Profiling_Profiler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Profiling_Profiler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Profiling_Profiler(nint ptr) => new Ptr_UnityEngine_Profiling_Profiler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Profiling_Profiler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Profiling_Profiler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetMonoHeapSizeLong = "UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong()";
    public const string IL2CPP_GetMonoUsedSizeLong = "UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong()";
    public const string IL2CPP_GetRuntimeMemorySizeLong = "UnityEngine.Profiling.Profiler::GetRuntimeMemorySizeLong(UnityEngine.Object)";
    public const string IL2CPP_GetTotalAllocatedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong()";
    public const string IL2CPP_GetTotalReservedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong()";
    public const string IL2CPP_GetTotalUnusedReservedMemoryLong = "UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong()";
}

