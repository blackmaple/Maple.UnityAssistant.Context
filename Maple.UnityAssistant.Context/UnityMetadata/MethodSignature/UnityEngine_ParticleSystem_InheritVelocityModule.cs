namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_InheritVelocityModule
{
    public const string MONO_GetCurveInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_curve_Injected";
    public const string MONO_GetCurveMultiplierInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_curveMultiplier_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_enabled_Injected";
    public const string MONO_GetModeInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_mode_Injected";
    public const string MONO_SetCurveInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_curve_Injected";
    public const string MONO_SetCurveMultiplierInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_curveMultiplier_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_enabled_Injected";
    public const string MONO_SetModeInjected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_mode_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_InheritVelocityModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_InheritVelocityModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_InheritVelocityModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_InheritVelocityModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_InheritVelocityModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_InheritVelocityModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_curve_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_curve_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_get_curveMultiplier_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_curveMultiplier_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&)";
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_enabled_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&)";
    public const string IL2CPP_get_mode_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::get_mode_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&)";
    public const string IL2CPP_set_curve_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_curve_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&,UnityEngine.ParticleSystem/MinMaxCurve&)";
    public const string IL2CPP_set_curveMultiplier_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_curveMultiplier_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&,System.Single)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_enabled_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&,System.Boolean)";
    public const string IL2CPP_set_mode_Injected = "UnityEngine.ParticleSystem/InheritVelocityModule::set_mode_Injected(UnityEngine.ParticleSystem/InheritVelocityModule&,UnityEngine.ParticleSystemInheritVelocityMode)";
}

