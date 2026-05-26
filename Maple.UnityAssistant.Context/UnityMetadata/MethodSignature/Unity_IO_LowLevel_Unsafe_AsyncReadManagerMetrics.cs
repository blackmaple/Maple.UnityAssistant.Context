namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics
{
    public const string MONO_ClearMetricsInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal";
    public const string MONO_GetMetricsFilteredInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal";
    public const string MONO_GetMetricsInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal";
    public const string MONO_GetMetricsNoAllocFilteredInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal";
    public const string MONO_GetMetricsNoAllocInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal";
    public const string MONO_GetSummaryMetricsInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal";
    public const string MONO_GetSummaryMetricsWithFiltersInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal";
    public const string MONO_GetSummaryOfMetricsFromContainerInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal";
    public const string MONO_GetSummaryOfMetricsInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal";
    public const string MONO_GetSummaryOfMetricsWithFiltersFromContainerInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal";
    public const string MONO_GetSummaryOfMetricsWithFiltersInternal = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal";
    public const string MONO_GetTotalSizeOfNonAsrmreadsBytes = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes";
    public const string MONO_IsEnabled = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled";
    public const string MONO_StartCollectingMetrics = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics";
    public const string MONO_StopCollectingMetrics = "Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics(nint ptr) => new Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics(ptr);
        public static implicit operator nint(Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManagerMetrics ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
