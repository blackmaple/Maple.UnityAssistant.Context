namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule
{
    public const string MONO_GetDampenInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_dampen_Injected";
    public const string MONO_GetDragInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_drag_Injected";
    public const string MONO_GetDragMultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_dragMultiplier_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_enabled_Injected";
    public const string MONO_GetLimitInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limit_Injected";
    public const string MONO_GetLimitMultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitMultiplier_Injected";
    public const string MONO_GetLimitXInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitX_Injected";
    public const string MONO_GetLimitXmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitXMultiplier_Injected";
    public const string MONO_GetLimitYInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitY_Injected";
    public const string MONO_GetLimitYmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitYMultiplier_Injected";
    public const string MONO_GetLimitZInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitZ_Injected";
    public const string MONO_GetLimitZmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitZMultiplier_Injected";
    public const string MONO_GetMultiplyDragByParticleSizeInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_multiplyDragByParticleSize_Injected";
    public const string MONO_GetMultiplyDragByParticleVelocityInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_multiplyDragByParticleVelocity_Injected";
    public const string MONO_GetSeparateAxesInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_separateAxes_Injected";
    public const string MONO_GetSpaceInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_space_Injected";
    public const string MONO_SetDampenInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_dampen_Injected";
    public const string MONO_SetDragInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_drag_Injected";
    public const string MONO_SetDragMultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_dragMultiplier_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_enabled_Injected";
    public const string MONO_SetLimitInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limit_Injected";
    public const string MONO_SetLimitMultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitMultiplier_Injected";
    public const string MONO_SetLimitXInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitX_Injected";
    public const string MONO_SetLimitXmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitXMultiplier_Injected";
    public const string MONO_SetLimitYInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitY_Injected";
    public const string MONO_SetLimitYmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitYMultiplier_Injected";
    public const string MONO_SetLimitZInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitZ_Injected";
    public const string MONO_SetLimitZmultiplierInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitZMultiplier_Injected";
    public const string MONO_SetMultiplyDragByParticleSizeInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_multiplyDragByParticleSize_Injected";
    public const string MONO_SetMultiplyDragByParticleVelocityInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_multiplyDragByParticleVelocity_Injected";
    public const string MONO_SetSeparateAxesInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_separateAxes_Injected";
    public const string MONO_SetSpaceInjected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_space_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_dampen_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_dampen_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_enabled_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_limit_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limit_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_limitMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_limitX_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitX_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_limitXMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitXMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_limitY_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitY_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_limitYMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitYMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_limitZ_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitZ_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_limitZMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_limitZMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_separateAxes_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_separateAxes_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_get_space_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::get_space_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&)";
    public const string IL2CPP_set_dampen_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_dampen_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Single)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_enabled_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Boolean)";
    public const string IL2CPP_set_limit_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limit_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_limitMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Single)";
    public const string IL2CPP_set_limitX_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitX_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_limitXMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitXMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Single)";
    public const string IL2CPP_set_limitY_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitY_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_limitYMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitYMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Single)";
    public const string IL2CPP_set_limitZ_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitZ_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_limitZMultiplier_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_limitZMultiplier_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Single)";
    public const string IL2CPP_set_separateAxes_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_separateAxes_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,System.Boolean)";
    public const string IL2CPP_set_space_Injected = "UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule::set_space_Injected(UnityEngine.ParticleSystem/LimitVelocityOverLifetimeModule&,UnityEngine.ParticleSystemSimulationSpace)";
}

