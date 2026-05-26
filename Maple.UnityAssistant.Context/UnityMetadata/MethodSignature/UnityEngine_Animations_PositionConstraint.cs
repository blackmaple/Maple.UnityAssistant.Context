namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_PositionConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.PositionConstraint::AddSource_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.PositionConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.PositionConstraint::get_locked";
    public const string MONO_GetTranslationAtRestInjected = "UnityEngine.Animations.PositionConstraint::get_translationAtRest_Injected";
    public const string MONO_GetTranslationAxis = "UnityEngine.Animations.PositionConstraint::get_translationAxis";
    public const string MONO_GetTranslationOffsetInjected = "UnityEngine.Animations.PositionConstraint::get_translationOffset_Injected";
    public const string MONO_GetWeight = "UnityEngine.Animations.PositionConstraint::get_weight";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.PositionConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.PositionConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.PositionConstraint::GetSources";
    public const string MONO_InternalCreate = "UnityEngine.Animations.PositionConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.PositionConstraint::RemoveSourceInternal";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.PositionConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.PositionConstraint::set_locked";
    public const string MONO_SetTranslationAtRestInjected = "UnityEngine.Animations.PositionConstraint::set_translationAtRest_Injected";
    public const string MONO_SetTranslationAxis = "UnityEngine.Animations.PositionConstraint::set_translationAxis";
    public const string MONO_SetTranslationOffsetInjected = "UnityEngine.Animations.PositionConstraint::set_translationOffset_Injected";
    public const string MONO_SetWeight = "UnityEngine.Animations.PositionConstraint::set_weight";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.PositionConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.PositionConstraint::SetSourcesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_PositionConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_PositionConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_PositionConstraint(nint ptr) => new Ptr_UnityEngine_Animations_PositionConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_PositionConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_PositionConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
