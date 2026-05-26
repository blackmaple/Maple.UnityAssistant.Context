namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_ColorOverLifetimeModule
{
    public const string MONO_GetColorInjected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::get_color_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::get_enabled_Injected";
    public const string MONO_SetColorInjected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::set_color_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::set_enabled_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_ColorOverLifetimeModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_color_Injected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::get_color_Injected(UnityEngine.ParticleSystem/ColorOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxGradient&)";
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::get_enabled_Injected(UnityEngine.ParticleSystem/ColorOverLifetimeModule&)";
    public const string IL2CPP_set_color_Injected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::set_color_Injected(UnityEngine.ParticleSystem/ColorOverLifetimeModule&,UnityEngine.ParticleSystem/MinMaxGradient&)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/ColorOverLifetimeModule::set_enabled_Injected(UnityEngine.ParticleSystem/ColorOverLifetimeModule&,System.Boolean)";
}

