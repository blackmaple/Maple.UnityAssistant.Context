namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Jobs_LowLevel_Unsafe_JobsUtility
{
    public const string MONO_ClearSystemIds = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds";
    public const string MONO_CreateJobReflectionData = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::CreateJobReflectionData";
    public const string MONO_GetIsExecutingJob = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_IsExecutingJob";
    public const string MONO_GetJobCompilerEnabled = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled";
    public const string MONO_GetJobDebuggerEnabled = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled";
    public const string MONO_GetJobWorkerMaximumCount = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount";
    public const string MONO_GetJobQueueWorkerThreadCount = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount";
    public const string MONO_GetSystemIdCellPtr = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr";
    public const string MONO_GetSystemIdMappings = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings";
    public const string MONO_GetWorkStealingRange = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetWorkStealingRange";
    public const string MONO_PatchBufferMinMaxRanges = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges";
    public const string MONO_ResetJobWorkerCount = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount";
    public const string MONO_ScheduleInjected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::Schedule_Injected";
    public const string MONO_ScheduleParallelForInjected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelFor_Injected";
    public const string MONO_ScheduleParallelForDeferArraySizeInjected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForDeferArraySize_Injected";
    public const string MONO_ScheduleParallelForTransformInjected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransform_Injected";
    public const string MONO_ScheduleParallelForTransformReadOnlyInjected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected";
    public const string MONO_SetJobCompilerEnabled = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobCompilerEnabled";
    public const string MONO_SetJobDebuggerEnabled = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled";
    public const string MONO_SetJobQueueMaximumActiveThreadCount = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility(nint ptr) => new Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility(ptr);
        public static implicit operator nint(Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Jobs_LowLevel_Unsafe_JobsUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateJobReflectionData = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::CreateJobReflectionData(System.Type,System.Type,System.Object,System.Object,System.Object)";
    public const string IL2CPP_GetWorkStealingRange = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetWorkStealingRange(Unity.Jobs.LowLevel.Unsafe.JobRanges&,System.Int32,System.Int32&,System.Int32&)";
    public const string IL2CPP_Schedule_Injected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::Schedule_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters&,Unity.Jobs.JobHandle&)";
    public const string IL2CPP_ScheduleParallelFor_Injected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelFor_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters&,System.Int32,System.Int32,Unity.Jobs.JobHandle&)";
    public const string IL2CPP_ScheduleParallelForTransform_Injected = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransform_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters&,System.IntPtr,Unity.Jobs.JobHandle&)";
    public const string IL2CPP_set_JobCompilerEnabled = "Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobCompilerEnabled(System.Boolean)";
}

