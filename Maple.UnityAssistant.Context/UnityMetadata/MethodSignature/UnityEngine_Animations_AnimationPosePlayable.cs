namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationPosePlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationPosePlayable::CreateHandleInternal_Injected";
    public const string MONO_GetApplyFootIkinternal = "UnityEngine.Animations.AnimationPosePlayable::GetApplyFootIKInternal";
    public const string MONO_GetMustReadPreviousPoseInternal = "UnityEngine.Animations.AnimationPosePlayable::GetMustReadPreviousPoseInternal";
    public const string MONO_GetReadDefaultPoseInternal = "UnityEngine.Animations.AnimationPosePlayable::GetReadDefaultPoseInternal";
    public const string MONO_SetApplyFootIkinternal = "UnityEngine.Animations.AnimationPosePlayable::SetApplyFootIKInternal";
    public const string MONO_SetMustReadPreviousPoseInternal = "UnityEngine.Animations.AnimationPosePlayable::SetMustReadPreviousPoseInternal";
    public const string MONO_SetReadDefaultPoseInternal = "UnityEngine.Animations.AnimationPosePlayable::SetReadDefaultPoseInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationPosePlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationPosePlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationPosePlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationPosePlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationPosePlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationPosePlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
