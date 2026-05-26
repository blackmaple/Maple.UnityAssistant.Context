namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationClipPlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected";
    public const string MONO_GetAnimationClipInternal = "UnityEngine.Animations.AnimationClipPlayable::GetAnimationClipInternal";
    public const string MONO_GetApplyFootIkinternal = "UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal";
    public const string MONO_GetApplyPlayableIkinternal = "UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal";
    public const string MONO_GetLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::GetLoopTimeInternal";
    public const string MONO_GetOverrideLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::GetOverrideLoopTimeInternal";
    public const string MONO_GetRemoveStartOffsetInternal = "UnityEngine.Animations.AnimationClipPlayable::GetRemoveStartOffsetInternal";
    public const string MONO_GetSampleRateInternal = "UnityEngine.Animations.AnimationClipPlayable::GetSampleRateInternal";
    public const string MONO_SetApplyFootIkinternal = "UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal";
    public const string MONO_SetApplyPlayableIkinternal = "UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal";
    public const string MONO_SetLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal";
    public const string MONO_SetOverrideLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal";
    public const string MONO_SetRemoveStartOffsetInternal = "UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal";
    public const string MONO_SetSampleRateInternal = "UnityEngine.Animations.AnimationClipPlayable::SetSampleRateInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationClipPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationClipPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationClipPlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationClipPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationClipPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationClipPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateHandleInternal_Injected = "UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_SetApplyFootIKInternal = "UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
    public const string IL2CPP_SetLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
    public const string IL2CPP_SetOverrideLoopTimeInternal = "UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
    public const string IL2CPP_SetRemoveStartOffsetInternal = "UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
}

