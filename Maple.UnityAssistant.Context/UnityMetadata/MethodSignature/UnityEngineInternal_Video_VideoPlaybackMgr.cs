namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_Video_VideoPlaybackMgr
{
    public const string MONO_CreateVideoPlayback = "UnityEngineInternal.Video.VideoPlaybackMgr::CreateVideoPlayback";
    public const string MONO_GetVideoPlaybackCount = "UnityEngineInternal.Video.VideoPlaybackMgr::get_videoPlaybackCount";
    public const string MONO_InternalCreate = "UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Destroy";
    public const string MONO_ProcessOsmainLoopMessagesForTesting = "UnityEngineInternal.Video.VideoPlaybackMgr::ProcessOSMainLoopMessagesForTesting";
    public const string MONO_ReleaseVideoPlayback = "UnityEngineInternal.Video.VideoPlaybackMgr::ReleaseVideoPlayback";
    public const string MONO_Update = "UnityEngineInternal.Video.VideoPlaybackMgr::Update";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_Video_VideoPlaybackMgr : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_Video_VideoPlaybackMgr(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_Video_VideoPlaybackMgr(nint ptr) => new Ptr_UnityEngineInternal_Video_VideoPlaybackMgr(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_Video_VideoPlaybackMgr ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_Video_VideoPlaybackMgr ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
