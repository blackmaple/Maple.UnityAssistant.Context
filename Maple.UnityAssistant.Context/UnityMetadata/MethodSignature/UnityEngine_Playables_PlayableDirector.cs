namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Playables_PlayableDirector
{
    public const string MONO_ClearGenericBinding = "UnityEngine.Playables.PlayableDirector::ClearGenericBinding";
    public const string MONO_ClearReferenceValueInjected = "UnityEngine.Playables.PlayableDirector::ClearReferenceValue_Injected";
    public const string MONO_Evaluate = "UnityEngine.Playables.PlayableDirector::Evaluate";
    public const string MONO_EvaluateNextFrame = "UnityEngine.Playables.PlayableDirector::EvaluateNextFrame";
    public const string MONO_GetDuration = "UnityEngine.Playables.PlayableDirector::get_duration";
    public const string MONO_GetInitialTime = "UnityEngine.Playables.PlayableDirector::get_initialTime";
    public const string MONO_GetTime = "UnityEngine.Playables.PlayableDirector::get_time";
    public const string MONO_GetTimeUpdateMode = "UnityEngine.Playables.PlayableDirector::get_timeUpdateMode";
    public const string MONO_GetGenericBinding = "UnityEngine.Playables.PlayableDirector::GetGenericBinding";
    public const string MONO_GetGraphHandleInjected = "UnityEngine.Playables.PlayableDirector::GetGraphHandle_Injected";
    public const string MONO_GetPlayOnAwake = "UnityEngine.Playables.PlayableDirector::GetPlayOnAwake";
    public const string MONO_GetPlayState = "UnityEngine.Playables.PlayableDirector::GetPlayState";
    public const string MONO_GetReferenceValueInjected = "UnityEngine.Playables.PlayableDirector::GetReferenceValue_Injected";
    public const string MONO_GetWrapMode = "UnityEngine.Playables.PlayableDirector::GetWrapMode";
    public const string MONO_HasGenericBinding = "UnityEngine.Playables.PlayableDirector::HasGenericBinding";
    public const string MONO_InternalGetPlayableAsset = "UnityEngine.Playables.PlayableDirector::Internal_GetPlayableAsset";
    public const string MONO_InternalSetGenericBinding = "UnityEngine.Playables.PlayableDirector::Internal_SetGenericBinding";
    public const string MONO_Pause = "UnityEngine.Playables.PlayableDirector::Pause";
    public const string MONO_Play = "UnityEngine.Playables.PlayableDirector::Play";
    public const string MONO_PlayOnFrameInjected = "UnityEngine.Playables.PlayableDirector::PlayOnFrame_Injected";
    public const string MONO_ProcessPendingGraphChanges = "UnityEngine.Playables.PlayableDirector::ProcessPendingGraphChanges";
    public const string MONO_RebindPlayableGraphOutputs = "UnityEngine.Playables.PlayableDirector::RebindPlayableGraphOutputs";
    public const string MONO_RebuildGraph = "UnityEngine.Playables.PlayableDirector::RebuildGraph";
    public const string MONO_ResetFrameTiming = "UnityEngine.Playables.PlayableDirector::ResetFrameTiming";
    public const string MONO_Resume = "UnityEngine.Playables.PlayableDirector::Resume";
    public const string MONO_SetInitialTime = "UnityEngine.Playables.PlayableDirector::set_initialTime";
    public const string MONO_SetTime = "UnityEngine.Playables.PlayableDirector::set_time";
    public const string MONO_SetTimeUpdateMode = "UnityEngine.Playables.PlayableDirector::set_timeUpdateMode";
    public const string MONO_SetPlayableAsset = "UnityEngine.Playables.PlayableDirector::SetPlayableAsset";
    public const string MONO_SetPlayOnAwake = "UnityEngine.Playables.PlayableDirector::SetPlayOnAwake";
    public const string MONO_SetReferenceValueInjected = "UnityEngine.Playables.PlayableDirector::SetReferenceValue_Injected";
    public const string MONO_SetWrapMode = "UnityEngine.Playables.PlayableDirector::SetWrapMode";
    public const string MONO_Stop = "UnityEngine.Playables.PlayableDirector::Stop";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Playables_PlayableDirector : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Playables_PlayableDirector(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Playables_PlayableDirector(nint ptr) => new Ptr_UnityEngine_Playables_PlayableDirector(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Playables_PlayableDirector ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Playables_PlayableDirector ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Evaluate = "UnityEngine.Playables.PlayableDirector::Evaluate()";
    public const string IL2CPP_get_duration = "UnityEngine.Playables.PlayableDirector::get_duration()";
    public const string IL2CPP_get_time = "UnityEngine.Playables.PlayableDirector::get_time()";
    public const string IL2CPP_GetGenericBinding = "UnityEngine.Playables.PlayableDirector::GetGenericBinding(UnityEngine.Object)";
    public const string IL2CPP_GetGraphHandle_Injected = "UnityEngine.Playables.PlayableDirector::GetGraphHandle_Injected(UnityEngine.Playables.PlayableGraph&)";
    public const string IL2CPP_GetPlayState = "UnityEngine.Playables.PlayableDirector::GetPlayState()";
    public const string IL2CPP_GetReferenceValue_Injected = "UnityEngine.Playables.PlayableDirector::GetReferenceValue_Injected(UnityEngine.PropertyName&,System.Boolean&)";
    public const string IL2CPP_GetWrapMode = "UnityEngine.Playables.PlayableDirector::GetWrapMode()";
    public const string IL2CPP_Internal_GetPlayableAsset = "UnityEngine.Playables.PlayableDirector::Internal_GetPlayableAsset()";
    public const string IL2CPP_Internal_SetGenericBinding = "UnityEngine.Playables.PlayableDirector::Internal_SetGenericBinding(UnityEngine.Object,UnityEngine.Object)";
    public const string IL2CPP_Pause = "UnityEngine.Playables.PlayableDirector::Pause()";
    public const string IL2CPP_Play = "UnityEngine.Playables.PlayableDirector::Play()";
    public const string IL2CPP_PlayOnFrame_Injected = "UnityEngine.Playables.PlayableDirector::PlayOnFrame_Injected(UnityEngine.Playables.FrameRate&)";
    public const string IL2CPP_Resume = "UnityEngine.Playables.PlayableDirector::Resume()";
    public const string IL2CPP_set_time = "UnityEngine.Playables.PlayableDirector::set_time(System.Double)";
    public const string IL2CPP_SetPlayableAsset = "UnityEngine.Playables.PlayableDirector::SetPlayableAsset(UnityEngine.ScriptableObject)";
    public const string IL2CPP_Stop = "UnityEngine.Playables.PlayableDirector::Stop()";
}

