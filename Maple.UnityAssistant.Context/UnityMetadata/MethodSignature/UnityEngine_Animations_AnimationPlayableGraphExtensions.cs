namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationPlayableGraphExtensions
{
    public const string MONO_InternalAnimationOutputCount = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalAnimationOutputCount";
    public const string MONO_InternalCreateAnimationOutput = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput";
    public const string MONO_InternalDestroyOutput = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalDestroyOutput";
    public const string MONO_InternalGetAnimationOutput = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalGetAnimationOutput";
    public const string MONO_InternalSyncUpdateAndTimeMode = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions(nint ptr) => new Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationPlayableGraphExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalCreateAnimationOutput = "UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph&,System.String,UnityEngine.Playables.PlayableOutputHandle&)";
}

