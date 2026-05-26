namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Time
{
    public const string MONO_GetCaptureDeltaTime = "UnityEngine.Time::get_captureDeltaTime";
    public const string MONO_GetDeltaTime = "UnityEngine.Time::get_deltaTime";
    public const string MONO_GetFixedDeltaTime = "UnityEngine.Time::get_fixedDeltaTime";
    public const string MONO_GetFixedTime = "UnityEngine.Time::get_fixedTime";
    public const string MONO_GetFixedTimeAsDouble = "UnityEngine.Time::get_fixedTimeAsDouble";
    public const string MONO_GetFixedUnscaledDeltaTime = "UnityEngine.Time::get_fixedUnscaledDeltaTime";
    public const string MONO_GetFixedUnscaledTime = "UnityEngine.Time::get_fixedUnscaledTime";
    public const string MONO_GetFixedUnscaledTimeAsDouble = "UnityEngine.Time::get_fixedUnscaledTimeAsDouble";
    public const string MONO_GetFrameCount = "UnityEngine.Time::get_frameCount";
    public const string MONO_GetInFixedTimeStep = "UnityEngine.Time::get_inFixedTimeStep";
    public const string MONO_GetMaximumDeltaTime = "UnityEngine.Time::get_maximumDeltaTime";
    public const string MONO_GetMaximumParticleDeltaTime = "UnityEngine.Time::get_maximumParticleDeltaTime";
    public const string MONO_GetRealtimeSinceStartup = "UnityEngine.Time::get_realtimeSinceStartup";
    public const string MONO_GetRealtimeSinceStartupAsDouble = "UnityEngine.Time::get_realtimeSinceStartupAsDouble";
    public const string MONO_GetRenderedFrameCount = "UnityEngine.Time::get_renderedFrameCount";
    public const string MONO_GetSmoothDeltaTime = "UnityEngine.Time::get_smoothDeltaTime";
    public const string MONO_GetTime = "UnityEngine.Time::get_time";
    public const string MONO_GetTimeAsDouble = "UnityEngine.Time::get_timeAsDouble";
    public const string MONO_GetTimeScale = "UnityEngine.Time::get_timeScale";
    public const string MONO_GetTimeSinceLevelLoad = "UnityEngine.Time::get_timeSinceLevelLoad";
    public const string MONO_GetTimeSinceLevelLoadAsDouble = "UnityEngine.Time::get_timeSinceLevelLoadAsDouble";
    public const string MONO_GetUnscaledDeltaTime = "UnityEngine.Time::get_unscaledDeltaTime";
    public const string MONO_GetUnscaledTime = "UnityEngine.Time::get_unscaledTime";
    public const string MONO_GetUnscaledTimeAsDouble = "UnityEngine.Time::get_unscaledTimeAsDouble";
    public const string MONO_SetCaptureDeltaTime = "UnityEngine.Time::set_captureDeltaTime";
    public const string MONO_SetFixedDeltaTime = "UnityEngine.Time::set_fixedDeltaTime";
    public const string MONO_SetMaximumDeltaTime = "UnityEngine.Time::set_maximumDeltaTime";
    public const string MONO_SetMaximumParticleDeltaTime = "UnityEngine.Time::set_maximumParticleDeltaTime";
    public const string MONO_SetTimeScale = "UnityEngine.Time::set_timeScale";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Time : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Time(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Time(nint ptr) => new Ptr_UnityEngine_Time(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Time ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Time ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_captureDeltaTime = "UnityEngine.Time::get_captureDeltaTime()";
    public const string IL2CPP_get_deltaTime = "UnityEngine.Time::get_deltaTime()";
    public const string IL2CPP_get_fixedDeltaTime = "UnityEngine.Time::get_fixedDeltaTime()";
    public const string IL2CPP_get_fixedTime = "UnityEngine.Time::get_fixedTime()";
    public const string IL2CPP_get_fixedTimeAsDouble = "UnityEngine.Time::get_fixedTimeAsDouble()";
    public const string IL2CPP_get_fixedUnscaledDeltaTime = "UnityEngine.Time::get_fixedUnscaledDeltaTime()";
    public const string IL2CPP_get_fixedUnscaledTime = "UnityEngine.Time::get_fixedUnscaledTime()";
    public const string IL2CPP_get_fixedUnscaledTimeAsDouble = "UnityEngine.Time::get_fixedUnscaledTimeAsDouble()";
    public const string IL2CPP_get_frameCount = "UnityEngine.Time::get_frameCount()";
    public const string IL2CPP_get_inFixedTimeStep = "UnityEngine.Time::get_inFixedTimeStep()";
    public const string IL2CPP_get_maximumDeltaTime = "UnityEngine.Time::get_maximumDeltaTime()";
    public const string IL2CPP_get_maximumParticleDeltaTime = "UnityEngine.Time::get_maximumParticleDeltaTime()";
    public const string IL2CPP_get_realtimeSinceStartup = "UnityEngine.Time::get_realtimeSinceStartup()";
    public const string IL2CPP_get_realtimeSinceStartupAsDouble = "UnityEngine.Time::get_realtimeSinceStartupAsDouble()";
    public const string IL2CPP_get_renderedFrameCount = "UnityEngine.Time::get_renderedFrameCount()";
    public const string IL2CPP_get_smoothDeltaTime = "UnityEngine.Time::get_smoothDeltaTime()";
    public const string IL2CPP_get_time = "UnityEngine.Time::get_time()";
    public const string IL2CPP_get_timeAsDouble = "UnityEngine.Time::get_timeAsDouble()";
    public const string IL2CPP_get_timeScale = "UnityEngine.Time::get_timeScale()";
    public const string IL2CPP_get_timeSinceLevelLoad = "UnityEngine.Time::get_timeSinceLevelLoad()";
    public const string IL2CPP_get_timeSinceLevelLoadAsDouble = "UnityEngine.Time::get_timeSinceLevelLoadAsDouble()";
    public const string IL2CPP_get_unscaledDeltaTime = "UnityEngine.Time::get_unscaledDeltaTime()";
    public const string IL2CPP_get_unscaledTime = "UnityEngine.Time::get_unscaledTime()";
    public const string IL2CPP_get_unscaledTimeAsDouble = "UnityEngine.Time::get_unscaledTimeAsDouble()";
    public const string IL2CPP_set_captureDeltaTime = "UnityEngine.Time::set_captureDeltaTime(System.Single)";
    public const string IL2CPP_set_fixedDeltaTime = "UnityEngine.Time::set_fixedDeltaTime(System.Single)";
    public const string IL2CPP_set_maximumDeltaTime = "UnityEngine.Time::set_maximumDeltaTime(System.Single)";
    public const string IL2CPP_set_maximumParticleDeltaTime = "UnityEngine.Time::set_maximumParticleDeltaTime(System.Single)";
    public const string IL2CPP_set_timeScale = "UnityEngine.Time::set_timeScale(System.Single)";
}

