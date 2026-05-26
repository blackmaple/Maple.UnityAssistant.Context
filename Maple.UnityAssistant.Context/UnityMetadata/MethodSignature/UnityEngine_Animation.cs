namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animation
{
    public const string MONO_AddClip = "UnityEngine.Animation::AddClip";
    public const string MONO_Blend = "UnityEngine.Animation::Blend";
    public const string MONO_CrossFade = "UnityEngine.Animation::CrossFade";
    public const string MONO_CrossFadeQueued = "UnityEngine.Animation::CrossFadeQueued";
    public const string MONO_GetAnimateOnlyIfVisible = "UnityEngine.Animation::get_animateOnlyIfVisible";
    public const string MONO_GetAnimatePhysics = "UnityEngine.Animation::get_animatePhysics";
    public const string MONO_GetClip = "UnityEngine.Animation::get_clip";
    public const string MONO_GetCullingType = "UnityEngine.Animation::get_cullingType";
    public const string MONO_GetIsPlaying = "UnityEngine.Animation::get_isPlaying";
    public const string MONO_GetLocalBoundsInjected = "UnityEngine.Animation::get_localBounds_Injected";
    public const string MONO_GetPlayAutomatically = "UnityEngine.Animation::get_playAutomatically";
    public const string MONO_GetWrapMode = "UnityEngine.Animation::get_wrapMode";
    public const string MONO_GetClipCount = "UnityEngine.Animation::GetClipCount";
    public const string MONO_GetState = "UnityEngine.Animation::GetState";
    public const string MONO_GetStateAtIndex = "UnityEngine.Animation::GetStateAtIndex";
    public const string MONO_GetStateCount = "UnityEngine.Animation::GetStateCount";
    public const string MONO_IsPlaying = "UnityEngine.Animation::IsPlaying";
    public const string MONO_Play = "UnityEngine.Animation::Play";
    public const string MONO_PlayDefaultAnimation = "UnityEngine.Animation::PlayDefaultAnimation";
    public const string MONO_PlayQueued = "UnityEngine.Animation::PlayQueued";
    public const string MONO_RemoveClip = "UnityEngine.Animation::RemoveClip";
    public const string MONO_RemoveClipNamed = "UnityEngine.Animation::RemoveClipNamed";
    public const string MONO_Rewind = "UnityEngine.Animation::Rewind";
    public const string MONO_RewindNamed = "UnityEngine.Animation::RewindNamed";
    public const string MONO_Sample = "UnityEngine.Animation::Sample";
    public const string MONO_SetAnimateOnlyIfVisible = "UnityEngine.Animation::set_animateOnlyIfVisible";
    public const string MONO_SetAnimatePhysics = "UnityEngine.Animation::set_animatePhysics";
    public const string MONO_SetClip = "UnityEngine.Animation::set_clip";
    public const string MONO_SetCullingType = "UnityEngine.Animation::set_cullingType";
    public const string MONO_SetLocalBoundsInjected = "UnityEngine.Animation::set_localBounds_Injected";
    public const string MONO_SetPlayAutomatically = "UnityEngine.Animation::set_playAutomatically";
    public const string MONO_SetWrapMode = "UnityEngine.Animation::set_wrapMode";
    public const string MONO_Stop = "UnityEngine.Animation::Stop";
    public const string MONO_StopNamed = "UnityEngine.Animation::StopNamed";
    public const string MONO_SyncLayer = "UnityEngine.Animation::SyncLayer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animation : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animation(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animation(nint ptr) => new Ptr_UnityEngine_Animation(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animation ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animation ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CrossFade = "UnityEngine.Animation::CrossFade(System.String,System.Single,UnityEngine.PlayMode)";
    public const string IL2CPP_get_clip = "UnityEngine.Animation::get_clip()";
    public const string IL2CPP_GetState = "UnityEngine.Animation::GetState(System.String)";
    public const string IL2CPP_GetStateAtIndex = "UnityEngine.Animation::GetStateAtIndex(System.Int32)";
    public const string IL2CPP_GetStateCount = "UnityEngine.Animation::GetStateCount()";
    public const string IL2CPP_Play = "UnityEngine.Animation::Play(System.String,UnityEngine.PlayMode)";
    public const string IL2CPP_PlayDefaultAnimation = "UnityEngine.Animation::PlayDefaultAnimation(UnityEngine.PlayMode)";
    public const string IL2CPP_Stop = "UnityEngine.Animation::Stop()";
}

