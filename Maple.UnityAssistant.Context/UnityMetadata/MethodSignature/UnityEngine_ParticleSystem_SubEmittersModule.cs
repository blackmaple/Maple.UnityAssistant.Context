namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_SubEmittersModule
{
    public const string MONO_AddSubEmitterInjected = "UnityEngine.ParticleSystem/SubEmittersModule::AddSubEmitter_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/SubEmittersModule::get_enabled_Injected";
    public const string MONO_GetSubEmittersCountInjected = "UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount_Injected";
    public const string MONO_GetSubEmitterEmitProbabilityInjected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterEmitProbability_Injected";
    public const string MONO_GetSubEmitterPropertiesInjected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterProperties_Injected";
    public const string MONO_GetSubEmitterSystemInjected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem_Injected";
    public const string MONO_GetSubEmitterTypeInjected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterType_Injected";
    public const string MONO_RemoveSubEmitterInjected = "UnityEngine.ParticleSystem/SubEmittersModule::RemoveSubEmitter_Injected";
    public const string MONO_RemoveSubEmitterObjectInjected = "UnityEngine.ParticleSystem/SubEmittersModule::RemoveSubEmitterObject_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/SubEmittersModule::set_enabled_Injected";
    public const string MONO_SetSubEmitterEmitProbabilityInjected = "UnityEngine.ParticleSystem/SubEmittersModule::SetSubEmitterEmitProbability_Injected";
    public const string MONO_SetSubEmitterPropertiesInjected = "UnityEngine.ParticleSystem/SubEmittersModule::SetSubEmitterProperties_Injected";
    public const string MONO_SetSubEmitterSystemInjected = "UnityEngine.ParticleSystem/SubEmittersModule::SetSubEmitterSystem_Injected";
    public const string MONO_SetSubEmitterTypeInjected = "UnityEngine.ParticleSystem/SubEmittersModule::SetSubEmitterType_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_SubEmittersModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_SubEmittersModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_SubEmittersModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_SubEmittersModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_SubEmittersModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_SubEmittersModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddSubEmitter_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::AddSubEmitter_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,UnityEngine.ParticleSystem,UnityEngine.ParticleSystemSubEmitterType,UnityEngine.ParticleSystemSubEmitterProperties,System.Single)";
    public const string IL2CPP_get_subEmittersCount_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount_Injected(UnityEngine.ParticleSystem/SubEmittersModule&)";
    public const string IL2CPP_GetSubEmitterProperties_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterProperties_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32)";
    public const string IL2CPP_GetSubEmitterSystem_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32)";
    public const string IL2CPP_GetSubEmitterType_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterType_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32)";
    public const string IL2CPP_RemoveSubEmitter_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::RemoveSubEmitter_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/SubEmittersModule::set_enabled_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Boolean)";
}

