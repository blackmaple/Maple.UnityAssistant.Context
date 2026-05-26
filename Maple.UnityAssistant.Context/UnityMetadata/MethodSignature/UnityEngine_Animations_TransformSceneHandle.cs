namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_TransformSceneHandle
{
    public const string MONO_GetGlobalTrinternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetGlobalTRInternal_Injected";
    public const string MONO_GetLocalPositionInternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetLocalPositionInternal_Injected";
    public const string MONO_GetLocalRotationInternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetLocalRotationInternal_Injected";
    public const string MONO_GetLocalScaleInternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetLocalScaleInternal_Injected";
    public const string MONO_GetLocalTrsinternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetLocalTRSInternal_Injected";
    public const string MONO_GetPositionInternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetPositionInternal_Injected";
    public const string MONO_GetRotationInternalInjected = "UnityEngine.Animations.TransformSceneHandle::GetRotationInternal_Injected";
    public const string MONO_HasValidTransformInjected = "UnityEngine.Animations.TransformSceneHandle::HasValidTransform_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_TransformSceneHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_TransformSceneHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_TransformSceneHandle(nint ptr) => new Ptr_UnityEngine_Animations_TransformSceneHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_TransformSceneHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_TransformSceneHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
