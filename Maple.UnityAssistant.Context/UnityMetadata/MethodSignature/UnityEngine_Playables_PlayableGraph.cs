namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Playables_PlayableGraph
{
    public const string MONO_ConnectInternalInjected = "UnityEngine.Playables.PlayableGraph::ConnectInternal_Injected";
    public const string MONO_CreateInjected = "UnityEngine.Playables.PlayableGraph::Create_Injected";
    public const string MONO_CreatePlayableHandleInjected = "UnityEngine.Playables.PlayableGraph::CreatePlayableHandle_Injected";
    public const string MONO_CreateScriptOutputInternalInjected = "UnityEngine.Playables.PlayableGraph::CreateScriptOutputInternal_Injected";
    public const string MONO_DestroyInjected = "UnityEngine.Playables.PlayableGraph::Destroy_Injected";
    public const string MONO_DestroyOutputInternalInjected = "UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected";
    public const string MONO_DestroyPlayableInternalInjected = "UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected";
    public const string MONO_DestroySubgraphInternalInjected = "UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected";
    public const string MONO_DisableMatchFrameRateInjected = "UnityEngine.Playables.PlayableGraph::DisableMatchFrameRate_Injected";
    public const string MONO_DisconnectInternalInjected = "UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected";
    public const string MONO_EnableMatchFrameRateInjected = "UnityEngine.Playables.PlayableGraph::EnableMatchFrameRate_Injected";
    public const string MONO_EvaluateInjected = "UnityEngine.Playables.PlayableGraph::Evaluate_Injected";
    public const string MONO_GetFrameRateInjected = "UnityEngine.Playables.PlayableGraph::GetFrameRate_Injected";
    public const string MONO_GetOutputByTypeInternalInjected = "UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal_Injected";
    public const string MONO_GetOutputCountInjected = "UnityEngine.Playables.PlayableGraph::GetOutputCount_Injected";
    public const string MONO_GetOutputCountByTypeInternalInjected = "UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal_Injected";
    public const string MONO_GetOutputInternalInjected = "UnityEngine.Playables.PlayableGraph::GetOutputInternal_Injected";
    public const string MONO_GetPlayableCountInjected = "UnityEngine.Playables.PlayableGraph::GetPlayableCount_Injected";
    public const string MONO_GetResolverInjected = "UnityEngine.Playables.PlayableGraph::GetResolver_Injected";
    public const string MONO_GetRootPlayableCountInjected = "UnityEngine.Playables.PlayableGraph::GetRootPlayableCount_Injected";
    public const string MONO_GetRootPlayableInternalInjected = "UnityEngine.Playables.PlayableGraph::GetRootPlayableInternal_Injected";
    public const string MONO_GetTimeUpdateModeInjected = "UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode_Injected";
    public const string MONO_IsDoneInjected = "UnityEngine.Playables.PlayableGraph::IsDone_Injected";
    public const string MONO_IsMatchFrameRateEnabledInjected = "UnityEngine.Playables.PlayableGraph::IsMatchFrameRateEnabled_Injected";
    public const string MONO_IsPlayingInjected = "UnityEngine.Playables.PlayableGraph::IsPlaying_Injected";
    public const string MONO_IsValidInjected = "UnityEngine.Playables.PlayableGraph::IsValid_Injected";
    public const string MONO_PlayInjected = "UnityEngine.Playables.PlayableGraph::Play_Injected";
    public const string MONO_SetResolverInjected = "UnityEngine.Playables.PlayableGraph::SetResolver_Injected";
    public const string MONO_SetTimeUpdateModeInjected = "UnityEngine.Playables.PlayableGraph::SetTimeUpdateMode_Injected";
    public const string MONO_StopInjected = "UnityEngine.Playables.PlayableGraph::Stop_Injected";
    public const string MONO_SynchronizeEvaluationInjected = "UnityEngine.Playables.PlayableGraph::SynchronizeEvaluation_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Playables_PlayableGraph : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Playables_PlayableGraph(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Playables_PlayableGraph(nint ptr) => new Ptr_UnityEngine_Playables_PlayableGraph(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Playables_PlayableGraph ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Playables_PlayableGraph ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ConnectInternal_Injected = "UnityEngine.Playables.PlayableGraph::ConnectInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.Playables.PlayableHandle&,System.Int32)";
    public const string IL2CPP_CreatePlayableHandle_Injected = "UnityEngine.Playables.PlayableGraph::CreatePlayableHandle_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_CreateScriptOutputInternal_Injected = "UnityEngine.Playables.PlayableGraph::CreateScriptOutputInternal_Injected(UnityEngine.Playables.PlayableGraph&,System.String,UnityEngine.Playables.PlayableOutputHandle&)";
    public const string IL2CPP_Evaluate_Injected = "UnityEngine.Playables.PlayableGraph::Evaluate_Injected(UnityEngine.Playables.PlayableGraph&,System.Single)";
    public const string IL2CPP_GetFrameRate_Injected = "UnityEngine.Playables.PlayableGraph::GetFrameRate_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.FrameRate&)";
    public const string IL2CPP_GetPlayableCount_Injected = "UnityEngine.Playables.PlayableGraph::GetPlayableCount_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_GetResolver_Injected = "UnityEngine.Playables.PlayableGraph::GetResolver_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_GetRootPlayableCount_Injected = "UnityEngine.Playables.PlayableGraph::GetRootPlayableCount_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_GetRootPlayableInternal_Injected = "UnityEngine.Playables.PlayableGraph::GetRootPlayableInternal_Injected(UnityEngine.Playables.PlayableGraph&,System.Int32,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_IsMatchFrameRateEnabled_Injected = "UnityEngine.Playables.PlayableGraph::IsMatchFrameRateEnabled_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_IsPlaying_Injected = "UnityEngine.Playables.PlayableGraph::IsPlaying_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_IsValid_Injected = "UnityEngine.Playables.PlayableGraph::IsValid_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_SynchronizeEvaluation_Injected = "UnityEngine.Playables.PlayableGraph::SynchronizeEvaluation_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableGraph&)";
}

