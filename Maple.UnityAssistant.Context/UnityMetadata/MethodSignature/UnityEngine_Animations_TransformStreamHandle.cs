namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_TransformStreamHandle
{
    public const string MONO_GetGlobalTrinternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetGlobalTRInternal_Injected";
    public const string MONO_GetLocalPositionInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetLocalPositionInternal_Injected";
    public const string MONO_GetLocalRotationInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetLocalRotationInternal_Injected";
    public const string MONO_GetLocalScaleInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetLocalScaleInternal_Injected";
    public const string MONO_GetLocalTrsinternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetLocalTRSInternal_Injected";
    public const string MONO_GetPositionInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetPositionInternal_Injected";
    public const string MONO_GetPositionReadMaskInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetPositionReadMaskInternal_Injected";
    public const string MONO_GetRotationInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetRotationInternal_Injected";
    public const string MONO_GetRotationReadMaskInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetRotationReadMaskInternal_Injected";
    public const string MONO_GetScaleReadMaskInternalInjected = "UnityEngine.Animations.TransformStreamHandle::GetScaleReadMaskInternal_Injected";
    public const string MONO_ResolveInternalInjected = "UnityEngine.Animations.TransformStreamHandle::ResolveInternal_Injected";
    public const string MONO_SetGlobalTrinternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetGlobalTRInternal_Injected";
    public const string MONO_SetLocalPositionInternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetLocalPositionInternal_Injected";
    public const string MONO_SetLocalRotationInternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal_Injected";
    public const string MONO_SetLocalScaleInternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetLocalScaleInternal_Injected";
    public const string MONO_SetLocalTrsinternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetLocalTRSInternal_Injected";
    public const string MONO_SetPositionInternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetPositionInternal_Injected";
    public const string MONO_SetRotationInternalInjected = "UnityEngine.Animations.TransformStreamHandle::SetRotationInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_TransformStreamHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_TransformStreamHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_TransformStreamHandle(nint ptr) => new Ptr_UnityEngine_Animations_TransformStreamHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_TransformStreamHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_TransformStreamHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
