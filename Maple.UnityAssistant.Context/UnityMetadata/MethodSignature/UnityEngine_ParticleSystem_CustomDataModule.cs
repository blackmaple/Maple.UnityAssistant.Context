namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_CustomDataModule
{
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/CustomDataModule::get_enabled_Injected";
    public const string MONO_GetColorInjected = "UnityEngine.ParticleSystem/CustomDataModule::GetColor_Injected";
    public const string MONO_GetModeInjected = "UnityEngine.ParticleSystem/CustomDataModule::GetMode_Injected";
    public const string MONO_GetVectorInjected = "UnityEngine.ParticleSystem/CustomDataModule::GetVector_Injected";
    public const string MONO_GetVectorComponentCountInjected = "UnityEngine.ParticleSystem/CustomDataModule::GetVectorComponentCount_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/CustomDataModule::set_enabled_Injected";
    public const string MONO_SetColorInjected = "UnityEngine.ParticleSystem/CustomDataModule::SetColor_Injected";
    public const string MONO_SetModeInjected = "UnityEngine.ParticleSystem/CustomDataModule::SetMode_Injected";
    public const string MONO_SetVectorInjected = "UnityEngine.ParticleSystem/CustomDataModule::SetVector_Injected";
    public const string MONO_SetVectorComponentCountInjected = "UnityEngine.ParticleSystem/CustomDataModule::SetVectorComponentCount_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_CustomDataModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_CustomDataModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_CustomDataModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_CustomDataModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_CustomDataModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_CustomDataModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
