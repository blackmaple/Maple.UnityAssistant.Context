namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystem
{
    public const string MONO_AllocateAxisOfRotationAttribute = "UnityEngine.ParticleSystem::AllocateAxisOfRotationAttribute";
    public const string MONO_AllocateCustomDataAttribute = "UnityEngine.ParticleSystem::AllocateCustomDataAttribute";
    public const string MONO_AllocateMeshIndexAttribute = "UnityEngine.ParticleSystem::AllocateMeshIndexAttribute";
    public const string MONO_Clear = "UnityEngine.ParticleSystem::Clear";
    public const string MONO_CopyManagedJobData = "UnityEngine.ParticleSystem::CopyManagedJobData";
    public const string MONO_EmitInjected = "UnityEngine.ParticleSystem::Emit_Injected";
    public const string MONO_EmitInternal = "UnityEngine.ParticleSystem::Emit_Internal";
    public const string MONO_EmitOldInternal = "UnityEngine.ParticleSystem::EmitOld_Internal";
    public const string MONO_GetIsEmitting = "UnityEngine.ParticleSystem::get_isEmitting";
    public const string MONO_GetIsPaused = "UnityEngine.ParticleSystem::get_isPaused";
    public const string MONO_GetIsPlaying = "UnityEngine.ParticleSystem::get_isPlaying";
    public const string MONO_GetIsStopped = "UnityEngine.ParticleSystem::get_isStopped";
    public const string MONO_GetParticleCount = "UnityEngine.ParticleSystem::get_particleCount";
    public const string MONO_GetProceduralSimulationSupported = "UnityEngine.ParticleSystem::get_proceduralSimulationSupported";
    public const string MONO_GetRandomSeed = "UnityEngine.ParticleSystem::get_randomSeed";
    public const string MONO_GetTime = "UnityEngine.ParticleSystem::get_time";
    public const string MONO_GetUseAutoRandomSeed = "UnityEngine.ParticleSystem::get_useAutoRandomSeed";
    public const string MONO_GetCustomParticleData = "UnityEngine.ParticleSystem::GetCustomParticleData";
    public const string MONO_GetManagedJobData = "UnityEngine.ParticleSystem::GetManagedJobData";
    public const string MONO_GetManagedJobHandleInjected = "UnityEngine.ParticleSystem::GetManagedJobHandle_Injected";
    public const string MONO_GetParticleCurrentColorInjected = "UnityEngine.ParticleSystem::GetParticleCurrentColor_Injected";
    public const string MONO_GetParticleCurrentSize = "UnityEngine.ParticleSystem::GetParticleCurrentSize";
    public const string MONO_GetParticleCurrentSize3DInjected = "UnityEngine.ParticleSystem::GetParticleCurrentSize3D_Injected";
    public const string MONO_GetParticleMeshIndex = "UnityEngine.ParticleSystem::GetParticleMeshIndex";
    public const string MONO_GetParticles = "UnityEngine.ParticleSystem::GetParticles";
    public const string MONO_GetParticlesWithNativeArray = "UnityEngine.ParticleSystem::GetParticlesWithNativeArray";
    public const string MONO_GetPlaybackStateInjected = "UnityEngine.ParticleSystem::GetPlaybackState_Injected";
    public const string MONO_GetTrailDataInternal = "UnityEngine.ParticleSystem::GetTrailDataInternal";
    public const string MONO_IsAlive = "UnityEngine.ParticleSystem::IsAlive";
    public const string MONO_Pause = "UnityEngine.ParticleSystem::Pause";
    public const string MONO_Play = "UnityEngine.ParticleSystem::Play";
    public const string MONO_ResetPreMappedBufferMemory = "UnityEngine.ParticleSystem::ResetPreMappedBufferMemory";
    public const string MONO_ScheduleManagedJobInjected = "UnityEngine.ParticleSystem::ScheduleManagedJob_Injected";
    public const string MONO_SetRandomSeed = "UnityEngine.ParticleSystem::set_randomSeed";
    public const string MONO_SetTime = "UnityEngine.ParticleSystem::set_time";
    public const string MONO_SetUseAutoRandomSeed = "UnityEngine.ParticleSystem::set_useAutoRandomSeed";
    public const string MONO_SetCustomParticleData = "UnityEngine.ParticleSystem::SetCustomParticleData";
    public const string MONO_SetManagedJobHandleInjected = "UnityEngine.ParticleSystem::SetManagedJobHandle_Injected";
    public const string MONO_SetMaximumPreMappedBufferCounts = "UnityEngine.ParticleSystem::SetMaximumPreMappedBufferCounts";
    public const string MONO_SetParticles = "UnityEngine.ParticleSystem::SetParticles";
    public const string MONO_SetParticlesWithNativeArray = "UnityEngine.ParticleSystem::SetParticlesWithNativeArray";
    public const string MONO_SetPlaybackStateInjected = "UnityEngine.ParticleSystem::SetPlaybackState_Injected";
    public const string MONO_SetTrailsInjected = "UnityEngine.ParticleSystem::SetTrails_Injected";
    public const string MONO_Simulate = "UnityEngine.ParticleSystem::Simulate";
    public const string MONO_Stop = "UnityEngine.ParticleSystem::Stop";
    public const string MONO_TriggerSubEmitter = "UnityEngine.ParticleSystem::TriggerSubEmitter";
    public const string MONO_TriggerSubEmitterForParticleInjected = "UnityEngine.ParticleSystem::TriggerSubEmitterForParticle_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystem(nint ptr) => new Ptr_UnityEngine_ParticleSystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AllocateAxisOfRotationAttribute = "UnityEngine.ParticleSystem::AllocateAxisOfRotationAttribute()";
    public const string IL2CPP_AllocateCustomDataAttribute = "UnityEngine.ParticleSystem::AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData)";
    public const string IL2CPP_AllocateMeshIndexAttribute = "UnityEngine.ParticleSystem::AllocateMeshIndexAttribute()";
    public const string IL2CPP_Clear = "UnityEngine.ParticleSystem::Clear(System.Boolean)";
    public const string IL2CPP_CopyManagedJobData = "UnityEngine.ParticleSystem::CopyManagedJobData(System.Void*,UnityEngine.ParticleSystemJobs.NativeParticleData&)";
    public const string IL2CPP_Emit_Injected = "UnityEngine.ParticleSystem::Emit_Injected(UnityEngine.ParticleSystem/EmitParams&,System.Int32)";
    public const string IL2CPP_Emit_Internal = "UnityEngine.ParticleSystem::Emit_Internal(System.Int32)";
    public const string IL2CPP_EmitOld_Internal = "UnityEngine.ParticleSystem::EmitOld_Internal(UnityEngine.ParticleSystem/Particle&)";
    public const string IL2CPP_get_isEmitting = "UnityEngine.ParticleSystem::get_isEmitting()";
    public const string IL2CPP_get_isPaused = "UnityEngine.ParticleSystem::get_isPaused()";
    public const string IL2CPP_get_isStopped = "UnityEngine.ParticleSystem::get_isStopped()";
    public const string IL2CPP_get_particleCount = "UnityEngine.ParticleSystem::get_particleCount()";
    public const string IL2CPP_get_proceduralSimulationSupported = "UnityEngine.ParticleSystem::get_proceduralSimulationSupported()";
    public const string IL2CPP_get_randomSeed = "UnityEngine.ParticleSystem::get_randomSeed()";
    public const string IL2CPP_get_time = "UnityEngine.ParticleSystem::get_time()";
    public const string IL2CPP_get_useAutoRandomSeed = "UnityEngine.ParticleSystem::get_useAutoRandomSeed()";
    public const string IL2CPP_GetCustomParticleData = "UnityEngine.ParticleSystem::GetCustomParticleData(System.Collections.Generic.List`1<UnityEngine.Vector4>,UnityEngine.ParticleSystemCustomData)";
    public const string IL2CPP_GetManagedJobData = "UnityEngine.ParticleSystem::GetManagedJobData()";
    public const string IL2CPP_GetManagedJobHandle_Injected = "UnityEngine.ParticleSystem::GetManagedJobHandle_Injected(Unity.Jobs.JobHandle&)";
    public const string IL2CPP_GetParticleCurrentColor_Injected = "UnityEngine.ParticleSystem::GetParticleCurrentColor_Injected(UnityEngine.ParticleSystem/Particle&,UnityEngine.Color32&)";
    public const string IL2CPP_GetParticleCurrentSize = "UnityEngine.ParticleSystem::GetParticleCurrentSize(UnityEngine.ParticleSystem/Particle&)";
    public const string IL2CPP_GetParticleCurrentSize3D_Injected = "UnityEngine.ParticleSystem::GetParticleCurrentSize3D_Injected(UnityEngine.ParticleSystem/Particle&,UnityEngine.Vector3&)";
    public const string IL2CPP_GetParticleMeshIndex = "UnityEngine.ParticleSystem::GetParticleMeshIndex(UnityEngine.ParticleSystem/Particle&)";
    public const string IL2CPP_GetParticles = "UnityEngine.ParticleSystem::GetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32,System.Int32)";
    public const string IL2CPP_GetParticlesWithNativeArray = "UnityEngine.ParticleSystem::GetParticlesWithNativeArray(System.IntPtr,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_GetPlaybackState_Injected = "UnityEngine.ParticleSystem::GetPlaybackState_Injected(UnityEngine.ParticleSystem/PlaybackState&)";
    public const string IL2CPP_GetTrailDataInternal = "UnityEngine.ParticleSystem::GetTrailDataInternal(UnityEngine.ParticleSystem/Trails&)";
    public const string IL2CPP_IsAlive = "UnityEngine.ParticleSystem::IsAlive(System.Boolean)";
    public const string IL2CPP_Pause = "UnityEngine.ParticleSystem::Pause(System.Boolean)";
    public const string IL2CPP_Play = "UnityEngine.ParticleSystem::Play(System.Boolean)";
    public const string IL2CPP_ResetPreMappedBufferMemory = "UnityEngine.ParticleSystem::ResetPreMappedBufferMemory()";
    public const string IL2CPP_ScheduleManagedJob_Injected = "UnityEngine.ParticleSystem::ScheduleManagedJob_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters&,System.Void*,Unity.Jobs.JobHandle&)";
    public const string IL2CPP_set_randomSeed = "UnityEngine.ParticleSystem::set_randomSeed(System.UInt32)";
    public const string IL2CPP_set_time = "UnityEngine.ParticleSystem::set_time(System.Single)";
    public const string IL2CPP_set_useAutoRandomSeed = "UnityEngine.ParticleSystem::set_useAutoRandomSeed(System.Boolean)";
    public const string IL2CPP_SetCustomParticleData = "UnityEngine.ParticleSystem::SetCustomParticleData(System.Collections.Generic.List`1<UnityEngine.Vector4>,UnityEngine.ParticleSystemCustomData)";
    public const string IL2CPP_SetManagedJobHandle_Injected = "UnityEngine.ParticleSystem::SetManagedJobHandle_Injected(Unity.Jobs.JobHandle&)";
    public const string IL2CPP_SetMaximumPreMappedBufferCounts = "UnityEngine.ParticleSystem::SetMaximumPreMappedBufferCounts(System.Int32,System.Int32)";
    public const string IL2CPP_SetParticles = "UnityEngine.ParticleSystem::SetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32,System.Int32)";
    public const string IL2CPP_SetParticlesWithNativeArray = "UnityEngine.ParticleSystem::SetParticlesWithNativeArray(System.IntPtr,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_SetPlaybackState_Injected = "UnityEngine.ParticleSystem::SetPlaybackState_Injected(UnityEngine.ParticleSystem/PlaybackState&)";
    public const string IL2CPP_SetTrails_Injected = "UnityEngine.ParticleSystem::SetTrails_Injected(UnityEngine.ParticleSystem/Trails&)";
    public const string IL2CPP_Simulate = "UnityEngine.ParticleSystem::Simulate(System.Single,System.Boolean,System.Boolean,System.Boolean)";
    public const string IL2CPP_Stop = "UnityEngine.ParticleSystem::Stop(System.Boolean,UnityEngine.ParticleSystemStopBehavior)";
    public const string IL2CPP_TriggerSubEmitter = "UnityEngine.ParticleSystem::TriggerSubEmitter(System.Int32,System.Collections.Generic.List`1<UnityEngine.ParticleSystem/Particle>)";
    public const string IL2CPP_TriggerSubEmitterForParticle_Injected = "UnityEngine.ParticleSystem::TriggerSubEmitterForParticle_Injected(System.Int32,UnityEngine.ParticleSystem/Particle&)";
}

