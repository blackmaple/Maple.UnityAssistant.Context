namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_ParentConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.ParentConstraint::AddSource_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.ParentConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.ParentConstraint::get_locked";
    public const string MONO_GetRotationAtRestInjected = "UnityEngine.Animations.ParentConstraint::get_rotationAtRest_Injected";
    public const string MONO_GetRotationAxis = "UnityEngine.Animations.ParentConstraint::get_rotationAxis";
    public const string MONO_GetRotationOffsets = "UnityEngine.Animations.ParentConstraint::get_rotationOffsets";
    public const string MONO_GetTranslationAtRestInjected = "UnityEngine.Animations.ParentConstraint::get_translationAtRest_Injected";
    public const string MONO_GetTranslationAxis = "UnityEngine.Animations.ParentConstraint::get_translationAxis";
    public const string MONO_GetTranslationOffsets = "UnityEngine.Animations.ParentConstraint::get_translationOffsets";
    public const string MONO_GetWeight = "UnityEngine.Animations.ParentConstraint::get_weight";
    public const string MONO_GetRotationOffsetInternalInjected = "UnityEngine.Animations.ParentConstraint::GetRotationOffsetInternal_Injected";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.ParentConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.ParentConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.ParentConstraint::GetSources";
    public const string MONO_GetTranslationOffsetInternalInjected = "UnityEngine.Animations.ParentConstraint::GetTranslationOffsetInternal_Injected";
    public const string MONO_InternalCreate = "UnityEngine.Animations.ParentConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.ParentConstraint::RemoveSourceInternal";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.ParentConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.ParentConstraint::set_locked";
    public const string MONO_SetRotationAtRestInjected = "UnityEngine.Animations.ParentConstraint::set_rotationAtRest_Injected";
    public const string MONO_SetRotationAxis = "UnityEngine.Animations.ParentConstraint::set_rotationAxis";
    public const string MONO_SetRotationOffsets = "UnityEngine.Animations.ParentConstraint::set_rotationOffsets";
    public const string MONO_SetTranslationAtRestInjected = "UnityEngine.Animations.ParentConstraint::set_translationAtRest_Injected";
    public const string MONO_SetTranslationAxis = "UnityEngine.Animations.ParentConstraint::set_translationAxis";
    public const string MONO_SetTranslationOffsets = "UnityEngine.Animations.ParentConstraint::set_translationOffsets";
    public const string MONO_SetWeight = "UnityEngine.Animations.ParentConstraint::set_weight";
    public const string MONO_SetRotationOffsetInternalInjected = "UnityEngine.Animations.ParentConstraint::SetRotationOffsetInternal_Injected";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.ParentConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.ParentConstraint::SetSourcesInternal";
    public const string MONO_SetTranslationOffsetInternalInjected = "UnityEngine.Animations.ParentConstraint::SetTranslationOffsetInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_ParentConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_ParentConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_ParentConstraint(nint ptr) => new Ptr_UnityEngine_Animations_ParentConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_ParentConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_ParentConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
