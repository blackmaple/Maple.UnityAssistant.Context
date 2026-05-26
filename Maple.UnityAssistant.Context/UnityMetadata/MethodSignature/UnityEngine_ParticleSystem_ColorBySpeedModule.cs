namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_ColorBySpeedModule
{
    public const string MONO_GetColorInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_color_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_enabled_Injected";
    public const string MONO_GetRangeInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_range_Injected";
    public const string MONO_SetColorInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_color_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_enabled_Injected";
    public const string MONO_SetRangeInjected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_range_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_ColorBySpeedModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_color_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_color_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&,UnityEngine.ParticleSystem/MinMaxGradient&)";
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_enabled_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&)";
    public const string IL2CPP_get_range_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::get_range_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&,UnityEngine.Vector2&)";
    public const string IL2CPP_set_color_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_color_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&,UnityEngine.ParticleSystem/MinMaxGradient&)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_enabled_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&,System.Boolean)";
    public const string IL2CPP_set_range_Injected = "UnityEngine.ParticleSystem/ColorBySpeedModule::set_range_Injected(UnityEngine.ParticleSystem/ColorBySpeedModule&,UnityEngine.Vector2&)";
}

