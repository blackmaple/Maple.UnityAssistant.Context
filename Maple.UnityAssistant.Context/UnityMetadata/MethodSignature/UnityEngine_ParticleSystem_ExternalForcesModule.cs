namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_ExternalForcesModule
{
    public const string MONO_AddInfluenceInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::AddInfluence_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_enabled_Injected";
    public const string MONO_GetInfluenceCountInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_influenceCount_Injected";
    public const string MONO_GetInfluenceFilterInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_influenceFilter_Injected";
    public const string MONO_GetInfluenceMaskInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_influenceMask_Injected";
    public const string MONO_GetMultiplierInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_multiplier_Injected";
    public const string MONO_GetMultiplierCurveInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_multiplierCurve_Injected";
    public const string MONO_GetInfluenceInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::GetInfluence_Injected";
    public const string MONO_IsAffectedByInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::IsAffectedBy_Injected";
    public const string MONO_RemoveAllInfluencesInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::RemoveAllInfluences_Injected";
    public const string MONO_RemoveInfluenceInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::RemoveInfluence_Injected";
    public const string MONO_RemoveInfluenceAtIndexInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::RemoveInfluenceAtIndex_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_enabled_Injected";
    public const string MONO_SetInfluenceFilterInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_influenceFilter_Injected";
    public const string MONO_SetInfluenceMaskInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_influenceMask_Injected";
    public const string MONO_SetMultiplierInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_multiplier_Injected";
    public const string MONO_SetMultiplierCurveInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_multiplierCurve_Injected";
    public const string MONO_SetInfluenceInjected = "UnityEngine.ParticleSystem/ExternalForcesModule::SetInfluence_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_ExternalForcesModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_ExternalForcesModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_ExternalForcesModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_ExternalForcesModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_ExternalForcesModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_ExternalForcesModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_enabled_Injected(UnityEngine.ParticleSystem/ExternalForcesModule&)";
    public const string IL2CPP_get_multiplier_Injected = "UnityEngine.ParticleSystem/ExternalForcesModule::get_multiplier_Injected(UnityEngine.ParticleSystem/ExternalForcesModule&)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_enabled_Injected(UnityEngine.ParticleSystem/ExternalForcesModule&,System.Boolean)";
    public const string IL2CPP_set_multiplier_Injected = "UnityEngine.ParticleSystem/ExternalForcesModule::set_multiplier_Injected(UnityEngine.ParticleSystem/ExternalForcesModule&,System.Single)";
}

