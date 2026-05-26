namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimatorControllerPlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected";
    public const string MONO_CrossFadeInFixedTimeInternal = "UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal";
    public const string MONO_CrossFadeInternal = "UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal";
    public const string MONO_GetAnimatorClipInfoCountInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal";
    public const string MONO_GetAnimatorClipInfoInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal";
    public const string MONO_GetAnimatorControllerInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorControllerInternal";
    public const string MONO_GetAnimatorTransitionInfoInternalInjected = "UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected";
    public const string MONO_GetBoolId = "UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID";
    public const string MONO_GetBoolString = "UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString";
    public const string MONO_GetCurrentAnimatorClipInfoInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal";
    public const string MONO_GetCurrentAnimatorStateInfoInternalInjected = "UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected";
    public const string MONO_GetFloatId = "UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID";
    public const string MONO_GetFloatString = "UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString";
    public const string MONO_GetIntegerId = "UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID";
    public const string MONO_GetIntegerString = "UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString";
    public const string MONO_GetLayerCountInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal";
    public const string MONO_GetLayerIndexInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal";
    public const string MONO_GetLayerNameInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal";
    public const string MONO_GetLayerWeightInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal";
    public const string MONO_GetNextAnimatorClipInfoInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal";
    public const string MONO_GetNextAnimatorStateInfoInternalInjected = "UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected";
    public const string MONO_GetParameterCountInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal";
    public const string MONO_GetParametersArrayInternal = "UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal";
    public const string MONO_HasStateInternal = "UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal";
    public const string MONO_IsInTransitionInternal = "UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal";
    public const string MONO_IsParameterControlledByCurveId = "UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID";
    public const string MONO_IsParameterControlledByCurveString = "UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString";
    public const string MONO_PlayInFixedTimeInternal = "UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal";
    public const string MONO_PlayInternal = "UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal";
    public const string MONO_ResetTriggerId = "UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID";
    public const string MONO_ResetTriggerString = "UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString";
    public const string MONO_ResolveHashInternal = "UnityEngine.Animations.AnimatorControllerPlayable::ResolveHashInternal";
    public const string MONO_SetBoolId = "UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID";
    public const string MONO_SetBoolString = "UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString";
    public const string MONO_SetFloatId = "UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID";
    public const string MONO_SetFloatString = "UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString";
    public const string MONO_SetIntegerId = "UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID";
    public const string MONO_SetIntegerString = "UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString";
    public const string MONO_SetLayerWeightInternal = "UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal";
    public const string MONO_SetTriggerId = "UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID";
    public const string MONO_SetTriggerString = "UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString";
    public const string MONO_StringToHash = "UnityEngine.Animations.AnimatorControllerPlayable::StringToHash";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimatorControllerPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimatorControllerPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimatorControllerPlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimatorControllerPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimatorControllerPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimatorControllerPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
