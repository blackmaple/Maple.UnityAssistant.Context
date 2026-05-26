namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_RotationConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.RotationConstraint::AddSource_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.RotationConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.RotationConstraint::get_locked";
    public const string MONO_GetRotationAtRestInjected = "UnityEngine.Animations.RotationConstraint::get_rotationAtRest_Injected";
    public const string MONO_GetRotationAxis = "UnityEngine.Animations.RotationConstraint::get_rotationAxis";
    public const string MONO_GetRotationOffsetInjected = "UnityEngine.Animations.RotationConstraint::get_rotationOffset_Injected";
    public const string MONO_GetWeight = "UnityEngine.Animations.RotationConstraint::get_weight";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.RotationConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.RotationConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.RotationConstraint::GetSources";
    public const string MONO_InternalCreate = "UnityEngine.Animations.RotationConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.RotationConstraint::RemoveSourceInternal";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.RotationConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.RotationConstraint::set_locked";
    public const string MONO_SetRotationAtRestInjected = "UnityEngine.Animations.RotationConstraint::set_rotationAtRest_Injected";
    public const string MONO_SetRotationAxis = "UnityEngine.Animations.RotationConstraint::set_rotationAxis";
    public const string MONO_SetRotationOffsetInjected = "UnityEngine.Animations.RotationConstraint::set_rotationOffset_Injected";
    public const string MONO_SetWeight = "UnityEngine.Animations.RotationConstraint::set_weight";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.RotationConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.RotationConstraint::SetSourcesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_RotationConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_RotationConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_RotationConstraint(nint ptr) => new Ptr_UnityEngine_Animations_RotationConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_RotationConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_RotationConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
