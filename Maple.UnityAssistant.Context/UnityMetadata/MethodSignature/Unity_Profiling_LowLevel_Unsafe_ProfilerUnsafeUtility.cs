namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility
{
    public const string MONO_BeginSample = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSample";
    public const string MONO_BeginSampleWithMetadata = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata";
    public const string MONO_CreateCategory = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory";
    public const string MONO_CreateCategoryUnmanaged = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory__Unmanaged";
    public const string MONO_CreateCategoryUnsafe = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Unsafe";
    public const string MONO_CreateCounterValue = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue";
    public const string MONO_CreateCounterValueUnmanaged = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue__Unmanaged";
    public const string MONO_CreateCounterValueUnsafe = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe";
    public const string MONO_CreateFlow = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow";
    public const string MONO_CreateMarker = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker";
    public const string MONO_CreateMarkerUnmanaged = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker__Unmanaged";
    public const string MONO_CreateMarkerUnsafe = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe";
    public const string MONO_EndSample = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::EndSample";
    public const string MONO_FlowEvent = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent";
    public const string MONO_FlushCounterValue = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue";
    public const string MONO_GetTimestamp = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp";
    public const string MONO_GetTimestampToNanosecondsConversionRatioInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_TimestampToNanosecondsConversionRatio_Injected";
    public const string MONO_GetCategoryByNameUnsafe = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe";
    public const string MONO_GetCategoryColorInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryColor_Injected";
    public const string MONO_GetCategoryDescriptionInjected = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryDescription_Injected";
    public const string MONO_GetMarker = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetMarker";
    public const string MONO_InternalBeginWithObject = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject";
    public const string MONO_InternalGetName = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName";
    public const string MONO_SetMarkerMetadata = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata";
    public const string MONO_SetMarkerMetadataUnmanaged = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata__Unmanaged";
    public const string MONO_SetMarkerMetadataUnsafe = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe";
    public const string MONO_SingleSampleWithMetadata = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility(nint ptr) => new Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility(ptr);
        public static implicit operator nint(Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Profiling_LowLevel_Unsafe_ProfilerUnsafeUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_BeginSample = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSample(System.IntPtr)";
    public const string IL2CPP_CreateMarker = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker(System.String,System.UInt16,Unity.Profiling.LowLevel.MarkerFlags,System.Int32)";
    public const string IL2CPP_EndSample = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::EndSample(System.IntPtr)";
    public const string IL2CPP_GetCategoryDescription_Injected = "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryDescription_Injected(System.UInt16,Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription&)";
}

