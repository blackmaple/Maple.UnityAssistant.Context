namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Playables_PlayableHandle
{
    public const string MONO_CanChangeInputsInjected = "UnityEngine.Playables.PlayableHandle::CanChangeInputs_Injected";
    public const string MONO_CanDestroyInjected = "UnityEngine.Playables.PlayableHandle::CanDestroy_Injected";
    public const string MONO_CanSetWeightsInjected = "UnityEngine.Playables.PlayableHandle::CanSetWeights_Injected";
    public const string MONO_GetDelayInjected = "UnityEngine.Playables.PlayableHandle::GetDelay_Injected";
    public const string MONO_GetDurationInjected = "UnityEngine.Playables.PlayableHandle::GetDuration_Injected";
    public const string MONO_GetGraphInjected = "UnityEngine.Playables.PlayableHandle::GetGraph_Injected";
    public const string MONO_GetInputCountInjected = "UnityEngine.Playables.PlayableHandle::GetInputCount_Injected";
    public const string MONO_GetInputHandleInjected = "UnityEngine.Playables.PlayableHandle::GetInputHandle_Injected";
    public const string MONO_GetInputWeightFromIndexInjected = "UnityEngine.Playables.PlayableHandle::GetInputWeightFromIndex_Injected";
    public const string MONO_GetJobDataInjected = "UnityEngine.Playables.PlayableHandle::GetJobData_Injected";
    public const string MONO_GetJobTypeInjected = "UnityEngine.Playables.PlayableHandle::GetJobType_Injected";
    public const string MONO_GetLeadTimeInjected = "UnityEngine.Playables.PlayableHandle::GetLeadTime_Injected";
    public const string MONO_GetOutputCountInjected = "UnityEngine.Playables.PlayableHandle::GetOutputCount_Injected";
    public const string MONO_GetOutputHandleInjected = "UnityEngine.Playables.PlayableHandle::GetOutputHandle_Injected";
    public const string MONO_GetPlayableTypeInjected = "UnityEngine.Playables.PlayableHandle::GetPlayableType_Injected";
    public const string MONO_GetPlayStateInjected = "UnityEngine.Playables.PlayableHandle::GetPlayState_Injected";
    public const string MONO_GetPreviousTimeInjected = "UnityEngine.Playables.PlayableHandle::GetPreviousTime_Injected";
    public const string MONO_GetPropagateSetTimeInjected = "UnityEngine.Playables.PlayableHandle::GetPropagateSetTime_Injected";
    public const string MONO_GetScriptInstanceInjected = "UnityEngine.Playables.PlayableHandle::GetScriptInstance_Injected";
    public const string MONO_GetSpeedInjected = "UnityEngine.Playables.PlayableHandle::GetSpeed_Injected";
    public const string MONO_GetTimeInjected = "UnityEngine.Playables.PlayableHandle::GetTime_Injected";
    public const string MONO_GetTimeWrapModeInjected = "UnityEngine.Playables.PlayableHandle::GetTimeWrapMode_Injected";
    public const string MONO_GetTraversalModeInjected = "UnityEngine.Playables.PlayableHandle::GetTraversalMode_Injected";
    public const string MONO_IsDelayedInjected = "UnityEngine.Playables.PlayableHandle::IsDelayed_Injected";
    public const string MONO_IsDoneInjected = "UnityEngine.Playables.PlayableHandle::IsDone_Injected";
    public const string MONO_IsNullInjected = "UnityEngine.Playables.PlayableHandle::IsNull_Injected";
    public const string MONO_IsValidInjected = "UnityEngine.Playables.PlayableHandle::IsValid_Injected";
    public const string MONO_PauseInjected = "UnityEngine.Playables.PlayableHandle::Pause_Injected";
    public const string MONO_PlayInjected = "UnityEngine.Playables.PlayableHandle::Play_Injected";
    public const string MONO_SetDelayInjected = "UnityEngine.Playables.PlayableHandle::SetDelay_Injected";
    public const string MONO_SetDoneInjected = "UnityEngine.Playables.PlayableHandle::SetDone_Injected";
    public const string MONO_SetDurationInjected = "UnityEngine.Playables.PlayableHandle::SetDuration_Injected";
    public const string MONO_SetInputCountInjected = "UnityEngine.Playables.PlayableHandle::SetInputCount_Injected";
    public const string MONO_SetInputWeightInjected = "UnityEngine.Playables.PlayableHandle::SetInputWeight_Injected";
    public const string MONO_SetInputWeightFromIndexInjected = "UnityEngine.Playables.PlayableHandle::SetInputWeightFromIndex_Injected";
    public const string MONO_SetLeadTimeInjected = "UnityEngine.Playables.PlayableHandle::SetLeadTime_Injected";
    public const string MONO_SetOutputCountInjected = "UnityEngine.Playables.PlayableHandle::SetOutputCount_Injected";
    public const string MONO_SetPropagateSetTimeInjected = "UnityEngine.Playables.PlayableHandle::SetPropagateSetTime_Injected";
    public const string MONO_SetScriptInstanceInjected = "UnityEngine.Playables.PlayableHandle::SetScriptInstance_Injected";
    public const string MONO_SetSpeedInjected = "UnityEngine.Playables.PlayableHandle::SetSpeed_Injected";
    public const string MONO_SetTimeInjected = "UnityEngine.Playables.PlayableHandle::SetTime_Injected";
    public const string MONO_SetTimeWrapModeInjected = "UnityEngine.Playables.PlayableHandle::SetTimeWrapMode_Injected";
    public const string MONO_SetTraversalModeInjected = "UnityEngine.Playables.PlayableHandle::SetTraversalMode_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Playables_PlayableHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Playables_PlayableHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Playables_PlayableHandle(nint ptr) => new Ptr_UnityEngine_Playables_PlayableHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Playables_PlayableHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Playables_PlayableHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetDuration_Injected = "UnityEngine.Playables.PlayableHandle::GetDuration_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetGraph_Injected = "UnityEngine.Playables.PlayableHandle::GetGraph_Injected(UnityEngine.Playables.PlayableHandle&,UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_GetInputCount_Injected = "UnityEngine.Playables.PlayableHandle::GetInputCount_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetInputHandle_Injected = "UnityEngine.Playables.PlayableHandle::GetInputHandle_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetInputWeightFromIndex_Injected = "UnityEngine.Playables.PlayableHandle::GetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32)";
    public const string IL2CPP_GetPlayableType_Injected = "UnityEngine.Playables.PlayableHandle::GetPlayableType_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetPlayState_Injected = "UnityEngine.Playables.PlayableHandle::GetPlayState_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetPreviousTime_Injected = "UnityEngine.Playables.PlayableHandle::GetPreviousTime_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetScriptInstance_Injected = "UnityEngine.Playables.PlayableHandle::GetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetTime_Injected = "UnityEngine.Playables.PlayableHandle::GetTime_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_GetTimeWrapMode_Injected = "UnityEngine.Playables.PlayableHandle::GetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_IsDone_Injected = "UnityEngine.Playables.PlayableHandle::IsDone_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_IsValid_Injected = "UnityEngine.Playables.PlayableHandle::IsValid_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_Pause_Injected = "UnityEngine.Playables.PlayableHandle::Pause_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_Play_Injected = "UnityEngine.Playables.PlayableHandle::Play_Injected(UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_SetDuration_Injected = "UnityEngine.Playables.PlayableHandle::SetDuration_Injected(UnityEngine.Playables.PlayableHandle&,System.Double)";
    public const string IL2CPP_SetInputCount_Injected = "UnityEngine.Playables.PlayableHandle::SetInputCount_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32)";
    public const string IL2CPP_SetInputWeight_Injected = "UnityEngine.Playables.PlayableHandle::SetInputWeight_Injected(UnityEngine.Playables.PlayableHandle&,UnityEngine.Playables.PlayableHandle&,System.Single)";
    public const string IL2CPP_SetInputWeightFromIndex_Injected = "UnityEngine.Playables.PlayableHandle::SetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)";
    public const string IL2CPP_SetPropagateSetTime_Injected = "UnityEngine.Playables.PlayableHandle::SetPropagateSetTime_Injected(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
    public const string IL2CPP_SetScriptInstance_Injected = "UnityEngine.Playables.PlayableHandle::SetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle&,System.Object)";
    public const string IL2CPP_SetSpeed_Injected = "UnityEngine.Playables.PlayableHandle::SetSpeed_Injected(UnityEngine.Playables.PlayableHandle&,System.Double)";
    public const string IL2CPP_SetTime_Injected = "UnityEngine.Playables.PlayableHandle::SetTime_Injected(UnityEngine.Playables.PlayableHandle&,System.Double)";
    public const string IL2CPP_SetTimeWrapMode_Injected = "UnityEngine.Playables.PlayableHandle::SetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle&,UnityEngine.Playables.DirectorWrapMode)";
    public const string IL2CPP_SetTraversalMode_Injected = "UnityEngine.Playables.PlayableHandle::SetTraversalMode_Injected(UnityEngine.Playables.PlayableHandle&,UnityEngine.Playables.PlayableTraversalMode)";
}

