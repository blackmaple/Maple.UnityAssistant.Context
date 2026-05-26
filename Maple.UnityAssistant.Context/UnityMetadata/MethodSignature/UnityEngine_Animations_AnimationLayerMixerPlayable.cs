namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationLayerMixerPlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected";
    public const string MONO_IsLayerAdditiveInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal";
    public const string MONO_SetLayerAdditiveInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal";
    public const string MONO_SetLayerMaskFromAvatarMaskInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal";
    public const string MONO_SetSingleLayerOptimizationInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::SetSingleLayerOptimizationInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationLayerMixerPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateHandleInternal_Injected = "UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_SetLayerMaskFromAvatarMaskInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,UnityEngine.AvatarMask)";
    public const string IL2CPP_SetSingleLayerOptimizationInternal = "UnityEngine.Animations.AnimationLayerMixerPlayable::SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)";
}

