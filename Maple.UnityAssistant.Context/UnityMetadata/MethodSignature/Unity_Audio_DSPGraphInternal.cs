namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_DSPGraphInternal
{
    public const string MONO_InternalAddNodeEventHandler = "Unity.Audio.DSPGraphInternal::Internal_AddNodeEventHandler";
    public const string MONO_InternalAllocateHandleInjected = "Unity.Audio.DSPGraphInternal::Internal_AllocateHandle_Injected";
    public const string MONO_InternalAssertMainThread = "Unity.Audio.DSPGraphInternal::Internal_AssertMainThread";
    public const string MONO_InternalAssertMixerThread = "Unity.Audio.DSPGraphInternal::Internal_AssertMixerThread";
    public const string MONO_InternalBeginMix = "Unity.Audio.DSPGraphInternal::Internal_BeginMix";
    public const string MONO_InternalCreateDspcommandBlock = "Unity.Audio.DSPGraphInternal::Internal_CreateDSPCommandBlock";
    public const string MONO_InternalCreateDspgraph = "Unity.Audio.DSPGraphInternal::Internal_CreateDSPGraph";
    public const string MONO_InternalDisposeDspgraph = "Unity.Audio.DSPGraphInternal::Internal_DisposeDSPGraph";
    public const string MONO_InternalDisposeJob = "Unity.Audio.DSPGraphInternal::Internal_DisposeJob";
    public const string MONO_InternalExecuteJob = "Unity.Audio.DSPGraphInternal::Internal_ExecuteJob";
    public const string MONO_InternalExecuteUpdateJob = "Unity.Audio.DSPGraphInternal::Internal_ExecuteUpdateJob";
    public const string MONO_InternalGetDspclock = "Unity.Audio.DSPGraphInternal::Internal_GetDSPClock";
    public const string MONO_InternalGetRootDsp = "Unity.Audio.DSPGraphInternal::Internal_GetRootDSP";
    public const string MONO_InternalInitializeJob = "Unity.Audio.DSPGraphInternal::Internal_InitializeJob";
    public const string MONO_InternalReadMix = "Unity.Audio.DSPGraphInternal::Internal_ReadMix";
    public const string MONO_InternalRemoveNodeEventHandler = "Unity.Audio.DSPGraphInternal::Internal_RemoveNodeEventHandler";
    public const string MONO_InternalScheduleGraphInjected = "Unity.Audio.DSPGraphInternal::Internal_ScheduleGraph_Injected";
    public const string MONO_InternalSyncFenceNoWorkStealInjected = "Unity.Audio.DSPGraphInternal::Internal_SyncFenceNoWorkSteal_Injected";
    public const string MONO_InternalUpdate = "Unity.Audio.DSPGraphInternal::Internal_Update";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_DSPGraphInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_DSPGraphInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_DSPGraphInternal(nint ptr) => new Ptr_Unity_Audio_DSPGraphInternal(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_DSPGraphInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_DSPGraphInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
