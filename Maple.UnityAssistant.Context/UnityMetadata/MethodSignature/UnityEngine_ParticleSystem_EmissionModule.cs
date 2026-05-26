namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_EmissionModule
{
    public const string MONO_GetBurstCountInjected = "UnityEngine.ParticleSystem/EmissionModule::get_burstCount_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/EmissionModule::get_enabled_Injected";
    public const string MONO_GetRateOverDistanceInjected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverDistance_Injected";
    public const string MONO_GetRateOverDistanceMultiplierInjected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverDistanceMultiplier_Injected";
    public const string MONO_GetRateOverTimeInjected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Injected";
    public const string MONO_GetRateOverTimeMultiplierInjected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTimeMultiplier_Injected";
    public const string MONO_GetBurstInjected = "UnityEngine.ParticleSystem/EmissionModule::GetBurst_Injected";
    public const string MONO_SetBurstCountInjected = "UnityEngine.ParticleSystem/EmissionModule::set_burstCount_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/EmissionModule::set_enabled_Injected";
    public const string MONO_SetRateOverDistanceInjected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverDistance_Injected";
    public const string MONO_SetRateOverDistanceMultiplierInjected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverDistanceMultiplier_Injected";
    public const string MONO_SetRateOverTimeInjected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Injected";
    public const string MONO_SetRateOverTimeMultiplierInjected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTimeMultiplier_Injected";
    public const string MONO_SetBurstInjected = "UnityEngine.ParticleSystem/EmissionModule::SetBurst_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_EmissionModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_EmissionModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_EmissionModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_EmissionModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_EmissionModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_EmissionModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_burstCount_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_burstCount_Injected(UnityEngine.ParticleSystem/EmissionModule&)";
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_enabled_Injected(UnityEngine.ParticleSystem/EmissionModule&)";
    public const string IL2CPP_get_rateOverDistance_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverDistance_Injected(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_rateOverDistanceMultiplier_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverDistanceMultiplier_Injected(UnityEngine.ParticleSystem/EmissionModule&)";
    public const string IL2CPP_get_rateOverTime_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_rateOverTimeMultiplier_Injected = "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTimeMultiplier_Injected(UnityEngine.ParticleSystem/EmissionModule&)";
    public const string IL2CPP_GetBurst_Injected = "UnityEngine.ParticleSystem/EmissionModule::GetBurst_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Int32,UnityEngine.ParticleSystem/Burst&)";
    public const string IL2CPP_set_burstCount_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_burstCount_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Int32)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_enabled_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Boolean)";
    public const string IL2CPP_set_rateOverDistance_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverDistance_Injected(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_rateOverDistanceMultiplier_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverDistanceMultiplier_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Single)";
    public const string IL2CPP_set_rateOverTime_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_rateOverTimeMultiplier_Injected = "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTimeMultiplier_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Single)";
    public const string IL2CPP_SetBurst_Injected = "UnityEngine.ParticleSystem/EmissionModule::SetBurst_Injected(UnityEngine.ParticleSystem/EmissionModule&,System.Int32,UnityEngine.ParticleSystem/Burst&)";
}

