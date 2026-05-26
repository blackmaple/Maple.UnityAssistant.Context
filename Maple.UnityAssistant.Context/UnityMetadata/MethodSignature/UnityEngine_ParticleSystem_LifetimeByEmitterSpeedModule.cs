namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule
{
    public const string MONO_GetCurveInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::get_curve_Injected";
    public const string MONO_GetCurveMultiplierInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::get_curveMultiplier_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::get_enabled_Injected";
    public const string MONO_GetRangeInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::get_range_Injected";
    public const string MONO_SetCurveInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::set_curve_Injected";
    public const string MONO_SetCurveMultiplierInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::set_curveMultiplier_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::set_enabled_Injected";
    public const string MONO_SetRangeInjected = "UnityEngine.ParticleSystem/LifetimeByEmitterSpeedModule::set_range_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_LifetimeByEmitterSpeedModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
