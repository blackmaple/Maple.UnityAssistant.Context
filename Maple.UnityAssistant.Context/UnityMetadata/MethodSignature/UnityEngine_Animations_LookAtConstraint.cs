namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_LookAtConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.LookAtConstraint::AddSource_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.LookAtConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.LookAtConstraint::get_locked";
    public const string MONO_GetRoll = "UnityEngine.Animations.LookAtConstraint::get_roll";
    public const string MONO_GetRotationAtRestInjected = "UnityEngine.Animations.LookAtConstraint::get_rotationAtRest_Injected";
    public const string MONO_GetRotationOffsetInjected = "UnityEngine.Animations.LookAtConstraint::get_rotationOffset_Injected";
    public const string MONO_GetUseUpObject = "UnityEngine.Animations.LookAtConstraint::get_useUpObject";
    public const string MONO_GetWeight = "UnityEngine.Animations.LookAtConstraint::get_weight";
    public const string MONO_GetWorldUpObject = "UnityEngine.Animations.LookAtConstraint::get_worldUpObject";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.LookAtConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.LookAtConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.LookAtConstraint::GetSources";
    public const string MONO_InternalCreate = "UnityEngine.Animations.LookAtConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.LookAtConstraint::RemoveSourceInternal";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.LookAtConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.LookAtConstraint::set_locked";
    public const string MONO_SetRoll = "UnityEngine.Animations.LookAtConstraint::set_roll";
    public const string MONO_SetRotationAtRestInjected = "UnityEngine.Animations.LookAtConstraint::set_rotationAtRest_Injected";
    public const string MONO_SetRotationOffsetInjected = "UnityEngine.Animations.LookAtConstraint::set_rotationOffset_Injected";
    public const string MONO_SetUseUpObject = "UnityEngine.Animations.LookAtConstraint::set_useUpObject";
    public const string MONO_SetWeight = "UnityEngine.Animations.LookAtConstraint::set_weight";
    public const string MONO_SetWorldUpObject = "UnityEngine.Animations.LookAtConstraint::set_worldUpObject";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.LookAtConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.LookAtConstraint::SetSourcesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_LookAtConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_LookAtConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_LookAtConstraint(nint ptr) => new Ptr_UnityEngine_Animations_LookAtConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_LookAtConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_LookAtConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
