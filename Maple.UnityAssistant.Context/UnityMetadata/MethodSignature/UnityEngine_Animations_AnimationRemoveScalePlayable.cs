namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationRemoveScalePlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationRemoveScalePlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateHandleInternal_Injected = "UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)";
}

