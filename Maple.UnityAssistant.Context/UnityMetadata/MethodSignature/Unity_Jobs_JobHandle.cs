namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Jobs_JobHandle
{
    public const string MONO_CheckFenceIsDependencyOrDidSyncFenceInjected = "Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected";
    public const string MONO_CombineDependenciesInternal2Injected = "Unity.Jobs.JobHandle::CombineDependenciesInternal2_Injected";
    public const string MONO_CombineDependenciesInternal3Injected = "Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected";
    public const string MONO_CombineDependenciesInternalPtrInjected = "Unity.Jobs.JobHandle::CombineDependenciesInternalPtr_Injected";
    public const string MONO_ScheduleBatchedJobs = "Unity.Jobs.JobHandle::ScheduleBatchedJobs";
    public const string MONO_ScheduleBatchedJobsAndComplete = "Unity.Jobs.JobHandle::ScheduleBatchedJobsAndComplete";
    public const string MONO_ScheduleBatchedJobsAndCompleteAll = "Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll";
    public const string MONO_ScheduleBatchedJobsAndIsCompleted = "Unity.Jobs.JobHandle::ScheduleBatchedJobsAndIsCompleted";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Jobs_JobHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Jobs_JobHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Jobs_JobHandle(nint ptr) => new Ptr_Unity_Jobs_JobHandle(ptr);
        public static implicit operator nint(Ptr_Unity_Jobs_JobHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Jobs_JobHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CombineDependenciesInternal2_Injected = "Unity.Jobs.JobHandle::CombineDependenciesInternal2_Injected(Unity.Jobs.JobHandle&,Unity.Jobs.JobHandle&,Unity.Jobs.JobHandle&)";
    public const string IL2CPP_ScheduleBatchedJobs = "Unity.Jobs.JobHandle::ScheduleBatchedJobs()";
    public const string IL2CPP_ScheduleBatchedJobsAndComplete = "Unity.Jobs.JobHandle::ScheduleBatchedJobsAndComplete(Unity.Jobs.JobHandle&)";
    public const string IL2CPP_ScheduleBatchedJobsAndCompleteAll = "Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll(System.Void*,System.Int32)";
}

