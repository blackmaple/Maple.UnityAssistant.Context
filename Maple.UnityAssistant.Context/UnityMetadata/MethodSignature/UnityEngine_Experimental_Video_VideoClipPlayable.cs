namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Video_VideoClipPlayable
{
    public const string MONO_GetClipInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::GetClipInternal";
    public const string MONO_GetIsPlayingInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::GetIsPlayingInternal";
    public const string MONO_GetLoopedInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::GetLoopedInternal";
    public const string MONO_GetPauseDelayInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::GetPauseDelayInternal";
    public const string MONO_GetStartDelayInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::GetStartDelayInternal";
    public const string MONO_InternalCreateVideoClipPlayable = "UnityEngine.Experimental.Video.VideoClipPlayable::InternalCreateVideoClipPlayable";
    public const string MONO_SetClipInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::SetClipInternal";
    public const string MONO_SetLoopedInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::SetLoopedInternal";
    public const string MONO_SetPauseDelayInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::SetPauseDelayInternal";
    public const string MONO_SetStartDelayInternal = "UnityEngine.Experimental.Video.VideoClipPlayable::SetStartDelayInternal";
    public const string MONO_ValidateType = "UnityEngine.Experimental.Video.VideoClipPlayable::ValidateType";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Video_VideoClipPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Video_VideoClipPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Video_VideoClipPlayable(nint ptr) => new Ptr_UnityEngine_Experimental_Video_VideoClipPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Video_VideoClipPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Video_VideoClipPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
