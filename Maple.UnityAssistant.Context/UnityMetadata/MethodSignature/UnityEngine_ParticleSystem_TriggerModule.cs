namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem_TriggerModule
{
    public const string MONO_AddColliderInjected = "UnityEngine.ParticleSystem/TriggerModule::AddCollider_Injected";
    public const string MONO_GetColliderCountInjected = "UnityEngine.ParticleSystem/TriggerModule::get_colliderCount_Injected";
    public const string MONO_GetColliderQueryModeInjected = "UnityEngine.ParticleSystem/TriggerModule::get_colliderQueryMode_Injected";
    public const string MONO_GetEnabledInjected = "UnityEngine.ParticleSystem/TriggerModule::get_enabled_Injected";
    public const string MONO_GetEnterInjected = "UnityEngine.ParticleSystem/TriggerModule::get_enter_Injected";
    public const string MONO_GetExitInjected = "UnityEngine.ParticleSystem/TriggerModule::get_exit_Injected";
    public const string MONO_GetInsideInjected = "UnityEngine.ParticleSystem/TriggerModule::get_inside_Injected";
    public const string MONO_GetOutsideInjected = "UnityEngine.ParticleSystem/TriggerModule::get_outside_Injected";
    public const string MONO_GetRadiusScaleInjected = "UnityEngine.ParticleSystem/TriggerModule::get_radiusScale_Injected";
    public const string MONO_GetColliderInjected = "UnityEngine.ParticleSystem/TriggerModule::GetCollider_Injected";
    public const string MONO_RemoveColliderInjected = "UnityEngine.ParticleSystem/TriggerModule::RemoveCollider_Injected";
    public const string MONO_RemoveColliderObjectInjected = "UnityEngine.ParticleSystem/TriggerModule::RemoveColliderObject_Injected";
    public const string MONO_SetColliderQueryModeInjected = "UnityEngine.ParticleSystem/TriggerModule::set_colliderQueryMode_Injected";
    public const string MONO_SetEnabledInjected = "UnityEngine.ParticleSystem/TriggerModule::set_enabled_Injected";
    public const string MONO_SetEnterInjected = "UnityEngine.ParticleSystem/TriggerModule::set_enter_Injected";
    public const string MONO_SetExitInjected = "UnityEngine.ParticleSystem/TriggerModule::set_exit_Injected";
    public const string MONO_SetInsideInjected = "UnityEngine.ParticleSystem/TriggerModule::set_inside_Injected";
    public const string MONO_SetOutsideInjected = "UnityEngine.ParticleSystem/TriggerModule::set_outside_Injected";
    public const string MONO_SetRadiusScaleInjected = "UnityEngine.ParticleSystem/TriggerModule::set_radiusScale_Injected";
    public const string MONO_SetColliderInjected = "UnityEngine.ParticleSystem/TriggerModule::SetCollider_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem_TriggerModule : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem_TriggerModule(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem_TriggerModule(nint ptr) => new Ptr_UnityEngine_ParticleSystem_TriggerModule(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem_TriggerModule ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem_TriggerModule ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_enabled_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_enabled_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_get_enter_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_enter_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_get_exit_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_exit_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_get_inside_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_inside_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_get_outside_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_outside_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_get_radiusScale_Injected = "UnityEngine.ParticleSystem/TriggerModule::get_radiusScale_Injected(UnityEngine.ParticleSystem/TriggerModule&)";
    public const string IL2CPP_set_enabled_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_enabled_Injected(UnityEngine.ParticleSystem/TriggerModule&,System.Boolean)";
    public const string IL2CPP_set_enter_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_enter_Injected(UnityEngine.ParticleSystem/TriggerModule&,UnityEngine.ParticleSystemOverlapAction)";
    public const string IL2CPP_set_exit_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_exit_Injected(UnityEngine.ParticleSystem/TriggerModule&,UnityEngine.ParticleSystemOverlapAction)";
    public const string IL2CPP_set_inside_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_inside_Injected(UnityEngine.ParticleSystem/TriggerModule&,UnityEngine.ParticleSystemOverlapAction)";
    public const string IL2CPP_set_outside_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_outside_Injected(UnityEngine.ParticleSystem/TriggerModule&,UnityEngine.ParticleSystemOverlapAction)";
    public const string IL2CPP_set_radiusScale_Injected = "UnityEngine.ParticleSystem/TriggerModule::set_radiusScale_Injected(UnityEngine.ParticleSystem/TriggerModule&,System.Single)";
}

