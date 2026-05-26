namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnimationClip
{
    public const string MONO_AddEventInternal = "UnityEngine.AnimationClip::AddEventInternal";
    public const string MONO_ClearCurves = "UnityEngine.AnimationClip::ClearCurves";
    public const string MONO_EnsureQuaternionContinuity = "UnityEngine.AnimationClip::EnsureQuaternionContinuity";
    public const string MONO_GetEmpty = "UnityEngine.AnimationClip::get_empty";
    public const string MONO_GetFrameRate = "UnityEngine.AnimationClip::get_frameRate";
    public const string MONO_GetHasGenericRootTransform = "UnityEngine.AnimationClip::get_hasGenericRootTransform";
    public const string MONO_GetHasMotionCurves = "UnityEngine.AnimationClip::get_hasMotionCurves";
    public const string MONO_GetHasMotionFloatCurves = "UnityEngine.AnimationClip::get_hasMotionFloatCurves";
    public const string MONO_GetHasRootCurves = "UnityEngine.AnimationClip::get_hasRootCurves";
    public const string MONO_GetHasRootMotion = "UnityEngine.AnimationClip::get_hasRootMotion";
    public const string MONO_GetHumanMotion = "UnityEngine.AnimationClip::get_humanMotion";
    public const string MONO_GetLegacy = "UnityEngine.AnimationClip::get_legacy";
    public const string MONO_GetLength = "UnityEngine.AnimationClip::get_length";
    public const string MONO_GetLocalBoundsInjected = "UnityEngine.AnimationClip::get_localBounds_Injected";
    public const string MONO_GetStartTime = "UnityEngine.AnimationClip::get_startTime";
    public const string MONO_GetStopTime = "UnityEngine.AnimationClip::get_stopTime";
    public const string MONO_GetWrapMode = "UnityEngine.AnimationClip::get_wrapMode";
    public const string MONO_GetEventsInternal = "UnityEngine.AnimationClip::GetEventsInternal";
    public const string MONO_InternalCreateAnimationClip = "UnityEngine.AnimationClip::Internal_CreateAnimationClip";
    public const string MONO_SampleAnimation = "UnityEngine.AnimationClip::SampleAnimation";
    public const string MONO_SetFrameRate = "UnityEngine.AnimationClip::set_frameRate";
    public const string MONO_SetLegacy = "UnityEngine.AnimationClip::set_legacy";
    public const string MONO_SetLocalBoundsInjected = "UnityEngine.AnimationClip::set_localBounds_Injected";
    public const string MONO_SetWrapMode = "UnityEngine.AnimationClip::set_wrapMode";
    public const string MONO_SetCurve = "UnityEngine.AnimationClip::SetCurve";
    public const string MONO_SetEventsInternal = "UnityEngine.AnimationClip::SetEventsInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnimationClip : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnimationClip(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnimationClip(nint ptr) => new Ptr_UnityEngine_AnimationClip(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnimationClip ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnimationClip ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_empty = "UnityEngine.AnimationClip::get_empty()";
    public const string IL2CPP_get_frameRate = "UnityEngine.AnimationClip::get_frameRate()";
    public const string IL2CPP_get_hasGenericRootTransform = "UnityEngine.AnimationClip::get_hasGenericRootTransform()";
    public const string IL2CPP_get_hasMotionCurves = "UnityEngine.AnimationClip::get_hasMotionCurves()";
    public const string IL2CPP_get_hasRootCurves = "UnityEngine.AnimationClip::get_hasRootCurves()";
    public const string IL2CPP_get_hasRootMotion = "UnityEngine.AnimationClip::get_hasRootMotion()";
    public const string IL2CPP_get_legacy = "UnityEngine.AnimationClip::get_legacy()";
    public const string IL2CPP_get_length = "UnityEngine.AnimationClip::get_length()";
    public const string IL2CPP_Internal_CreateAnimationClip = "UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)";
    public const string IL2CPP_set_frameRate = "UnityEngine.AnimationClip::set_frameRate(System.Single)";
    public const string IL2CPP_set_legacy = "UnityEngine.AnimationClip::set_legacy(System.Boolean)";
}

