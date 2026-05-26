namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationStream
{
    public const string MONO_CopyAnimationStreamMotionInternalInjected = "UnityEngine.Animations.AnimationStream::CopyAnimationStreamMotionInternal_Injected";
    public const string MONO_GetAngularVelocityInjected = "UnityEngine.Animations.AnimationStream::GetAngularVelocity_Injected";
    public const string MONO_GetDeltaTimeInjected = "UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected";
    public const string MONO_GetHumanStreamInjected = "UnityEngine.Animations.AnimationStream::GetHumanStream_Injected";
    public const string MONO_GetInputStreamCountInjected = "UnityEngine.Animations.AnimationStream::GetInputStreamCount_Injected";
    public const string MONO_GetIsHumanStreamInjected = "UnityEngine.Animations.AnimationStream::GetIsHumanStream_Injected";
    public const string MONO_GetRootMotionPositionInjected = "UnityEngine.Animations.AnimationStream::GetRootMotionPosition_Injected";
    public const string MONO_GetRootMotionRotationInjected = "UnityEngine.Animations.AnimationStream::GetRootMotionRotation_Injected";
    public const string MONO_GetVelocityInjected = "UnityEngine.Animations.AnimationStream::GetVelocity_Injected";
    public const string MONO_InternalGetInputStreamInjected = "UnityEngine.Animations.AnimationStream::InternalGetInputStream_Injected";
    public const string MONO_InternalGetInputWeightInjected = "UnityEngine.Animations.AnimationStream::InternalGetInputWeight_Injected";
    public const string MONO_InternalReadSceneTransformsInjected = "UnityEngine.Animations.AnimationStream::InternalReadSceneTransforms_Injected";
    public const string MONO_InternalWriteSceneTransformsInjected = "UnityEngine.Animations.AnimationStream::InternalWriteSceneTransforms_Injected";
    public const string MONO_SetAngularVelocityInjected = "UnityEngine.Animations.AnimationStream::SetAngularVelocity_Injected";
    public const string MONO_SetVelocityInjected = "UnityEngine.Animations.AnimationStream::SetVelocity_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationStream : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationStream(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationStream(nint ptr) => new Ptr_UnityEngine_Animations_AnimationStream(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationStream ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationStream ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
