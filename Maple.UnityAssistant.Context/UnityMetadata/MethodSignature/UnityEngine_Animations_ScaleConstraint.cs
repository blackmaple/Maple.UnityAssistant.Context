namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_ScaleConstraint
{
    public const string MONO_AddSourceInjected = "UnityEngine.Animations.ScaleConstraint::AddSource_Injected";
    public const string MONO_GetConstraintActive = "UnityEngine.Animations.ScaleConstraint::get_constraintActive";
    public const string MONO_GetLocked = "UnityEngine.Animations.ScaleConstraint::get_locked";
    public const string MONO_GetScaleAtRestInjected = "UnityEngine.Animations.ScaleConstraint::get_scaleAtRest_Injected";
    public const string MONO_GetScaleOffsetInjected = "UnityEngine.Animations.ScaleConstraint::get_scaleOffset_Injected";
    public const string MONO_GetScalingAxis = "UnityEngine.Animations.ScaleConstraint::get_scalingAxis";
    public const string MONO_GetWeight = "UnityEngine.Animations.ScaleConstraint::get_weight";
    public const string MONO_GetSourceCountInternal = "UnityEngine.Animations.ScaleConstraint::GetSourceCountInternal";
    public const string MONO_GetSourceInternalInjected = "UnityEngine.Animations.ScaleConstraint::GetSourceInternal_Injected";
    public const string MONO_GetSources = "UnityEngine.Animations.ScaleConstraint::GetSources";
    public const string MONO_InternalCreate = "UnityEngine.Animations.ScaleConstraint::Internal_Create";
    public const string MONO_RemoveSourceInternal = "UnityEngine.Animations.ScaleConstraint::RemoveSourceInternal";
    public const string MONO_SetConstraintActive = "UnityEngine.Animations.ScaleConstraint::set_constraintActive";
    public const string MONO_SetLocked = "UnityEngine.Animations.ScaleConstraint::set_locked";
    public const string MONO_SetScaleAtRestInjected = "UnityEngine.Animations.ScaleConstraint::set_scaleAtRest_Injected";
    public const string MONO_SetScaleOffsetInjected = "UnityEngine.Animations.ScaleConstraint::set_scaleOffset_Injected";
    public const string MONO_SetScalingAxis = "UnityEngine.Animations.ScaleConstraint::set_scalingAxis";
    public const string MONO_SetWeight = "UnityEngine.Animations.ScaleConstraint::set_weight";
    public const string MONO_SetSourceInternalInjected = "UnityEngine.Animations.ScaleConstraint::SetSourceInternal_Injected";
    public const string MONO_SetSourcesInternal = "UnityEngine.Animations.ScaleConstraint::SetSourcesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_ScaleConstraint : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_ScaleConstraint(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_ScaleConstraint(nint ptr) => new Ptr_UnityEngine_Animations_ScaleConstraint(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_ScaleConstraint ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_ScaleConstraint ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
