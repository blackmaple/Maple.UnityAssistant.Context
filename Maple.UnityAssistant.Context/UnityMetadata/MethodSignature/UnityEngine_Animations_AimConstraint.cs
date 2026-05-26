namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AimConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.AimConstraint::AddSource_Injected";
    public const string MONO_GetAimVectorInjected = "UnityEngine.Animations.AimConstraint::get_aimVector_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.AimConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.AimConstraint::get_locked";
    public const string MONO_GetRotationAtRestInjected = "UnityEngine.Animations.AimConstraint::get_rotationAtRest_Injected";
    public const string MONO_GetRotationAxis = "UnityEngine.Animations.AimConstraint::get_rotationAxis";
    public const string MONO_GetRotationOffsetInjected = "UnityEngine.Animations.AimConstraint::get_rotationOffset_Injected";
    public const string MONO_GetUpVectorInjected = "UnityEngine.Animations.AimConstraint::get_upVector_Injected";
    public const string MONO_GetWeight = "UnityEngine.Animations.AimConstraint::get_weight";
    public const string MONO_GetWorldUpObject = "UnityEngine.Animations.AimConstraint::get_worldUpObject";
    public const string MONO_GetWorldUpType = "UnityEngine.Animations.AimConstraint::get_worldUpType";
    public const string MONO_GetWorldUpVectorInjected = "UnityEngine.Animations.AimConstraint::get_worldUpVector_Injected";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.AimConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.AimConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.AimConstraint::GetSources";
    public const string MONO_InternalCreate = "UnityEngine.Animations.AimConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.AimConstraint::RemoveSourceInternal";
    public const string MONO_SetAimVectorInjected = "UnityEngine.Animations.AimConstraint::set_aimVector_Injected";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.AimConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.AimConstraint::set_locked";
    public const string MONO_SetRotationAtRestInjected = "UnityEngine.Animations.AimConstraint::set_rotationAtRest_Injected";
    public const string MONO_SetRotationAxis = "UnityEngine.Animations.AimConstraint::set_rotationAxis";
    public const string MONO_SetRotationOffsetInjected = "UnityEngine.Animations.AimConstraint::set_rotationOffset_Injected";
    public const string MONO_SetUpVectorInjected = "UnityEngine.Animations.AimConstraint::set_upVector_Injected";
    public const string MONO_SetWeight = "UnityEngine.Animations.AimConstraint::set_weight";
    public const string MONO_SetWorldUpObject = "UnityEngine.Animations.AimConstraint::set_worldUpObject";
    public const string MONO_SetWorldUpType = "UnityEngine.Animations.AimConstraint::set_worldUpType";
    public const string MONO_SetWorldUpVectorInjected = "UnityEngine.Animations.AimConstraint::set_worldUpVector_Injected";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.AimConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.AimConstraint::SetSourcesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AimConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AimConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AimConstraint(nint ptr) => new Ptr_UnityEngine_Animations_AimConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AimConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AimConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
