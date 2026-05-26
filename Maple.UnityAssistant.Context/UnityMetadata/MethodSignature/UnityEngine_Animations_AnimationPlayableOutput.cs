namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationPlayableOutput
{
    public const string MONO_InternalGetTarget = "UnityEngine.Animations.AnimationPlayableOutput::InternalGetTarget";
    public const string MONO_InternalSetTarget = "UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationPlayableOutput : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationPlayableOutput(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationPlayableOutput(nint ptr) => new Ptr_UnityEngine_Animations_AnimationPlayableOutput(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationPlayableOutput ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationPlayableOutput ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalGetTarget = "UnityEngine.Animations.AnimationPlayableOutput::InternalGetTarget(UnityEngine.Playables.PlayableOutputHandle&)";
    public const string IL2CPP_InternalSetTarget = "UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Animator)";
}

