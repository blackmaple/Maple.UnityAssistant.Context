namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Profiling_ProfilerRecorder
{
    public const string MONO_ControlInjected = "Unity.Profiling.ProfilerRecorder::Control_Injected";
    public const string MONO_CopyToListInjected = "Unity.Profiling.ProfilerRecorder::CopyTo_List_Injected";
    public const string MONO_CopyToPointerInjected = "Unity.Profiling.ProfilerRecorder::CopyTo_Pointer_Injected";
    public const string MONO_CreateInjected = "Unity.Profiling.ProfilerRecorder::Create_Injected";
    public const string MONO_GetCountInjected = "Unity.Profiling.ProfilerRecorder::GetCount_Injected";
    public const string MONO_GetCurrentValueInjected = "Unity.Profiling.ProfilerRecorder::GetCurrentValue_Injected";
    public const string MONO_GetCurrentValueAsDoubleInjected = "Unity.Profiling.ProfilerRecorder::GetCurrentValueAsDouble_Injected";
    public const string MONO_GetLastValueInjected = "Unity.Profiling.ProfilerRecorder::GetLastValue_Injected";
    public const string MONO_GetLastValueAsDoubleInjected = "Unity.Profiling.ProfilerRecorder::GetLastValueAsDouble_Injected";
    public const string MONO_GetRunningInjected = "Unity.Profiling.ProfilerRecorder::GetRunning_Injected";
    public const string MONO_GetSampleInternalInjected = "Unity.Profiling.ProfilerRecorder::GetSampleInternal_Injected";
    public const string MONO_GetValidInjected = "Unity.Profiling.ProfilerRecorder::GetValid_Injected";
    public const string MONO_GetValueDataTypeInjected = "Unity.Profiling.ProfilerRecorder::GetValueDataType_Injected";
    public const string MONO_GetValueUnitTypeInjected = "Unity.Profiling.ProfilerRecorder::GetValueUnitType_Injected";
    public const string MONO_GetWrappedInjected = "Unity.Profiling.ProfilerRecorder::GetWrapped_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Profiling_ProfilerRecorder : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Profiling_ProfilerRecorder(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Profiling_ProfilerRecorder(nint ptr) => new Ptr_Unity_Profiling_ProfilerRecorder(ptr);
        public static implicit operator nint(Ptr_Unity_Profiling_ProfilerRecorder ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Profiling_ProfilerRecorder ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Control_Injected = "Unity.Profiling.ProfilerRecorder::Control_Injected(Unity.Profiling.ProfilerRecorder&,Unity.Profiling.ProfilerRecorder/ControlOptions)";
    public const string IL2CPP_Create_Injected = "Unity.Profiling.ProfilerRecorder::Create_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle&,System.Int32,Unity.Profiling.ProfilerRecorderOptions,Unity.Profiling.ProfilerRecorder&)";
    public const string IL2CPP_GetCount_Injected = "Unity.Profiling.ProfilerRecorder::GetCount_Injected(Unity.Profiling.ProfilerRecorder&,Unity.Profiling.ProfilerRecorder/CountOptions)";
    public const string IL2CPP_GetLastValue_Injected = "Unity.Profiling.ProfilerRecorder::GetLastValue_Injected(Unity.Profiling.ProfilerRecorder&)";
    public const string IL2CPP_GetRunning_Injected = "Unity.Profiling.ProfilerRecorder::GetRunning_Injected(Unity.Profiling.ProfilerRecorder&)";
    public const string IL2CPP_GetSampleInternal_Injected = "Unity.Profiling.ProfilerRecorder::GetSampleInternal_Injected(Unity.Profiling.ProfilerRecorder&,System.Int32,Unity.Profiling.ProfilerRecorderSample&)";
    public const string IL2CPP_GetValid_Injected = "Unity.Profiling.ProfilerRecorder::GetValid_Injected(Unity.Profiling.ProfilerRecorder&)";
}

