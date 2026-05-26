namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationOffsetPlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected";
    public const string MONO_GetPositionInternalInjected = "UnityEngine.Animations.AnimationOffsetPlayable::GetPositionInternal_Injected";
    public const string MONO_GetRotationInternalInjected = "UnityEngine.Animations.AnimationOffsetPlayable::GetRotationInternal_Injected";
    public const string MONO_SetPositionInternalInjected = "UnityEngine.Animations.AnimationOffsetPlayable::SetPositionInternal_Injected";
    public const string MONO_SetRotationInternalInjected = "UnityEngine.Animations.AnimationOffsetPlayable::SetRotationInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationOffsetPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationOffsetPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationOffsetPlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationOffsetPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationOffsetPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationOffsetPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateHandleInternal_Injected = "UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Playables.PlayableHandle&)";
}

