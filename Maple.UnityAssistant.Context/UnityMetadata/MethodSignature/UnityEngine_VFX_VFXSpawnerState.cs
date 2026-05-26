namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_VFX_VFXSpawnerState
{
    public const string MONO_GetDelayAfterLoop = "UnityEngine.VFX.VFXSpawnerState::get_delayAfterLoop";
    public const string MONO_GetDelayBeforeLoop = "UnityEngine.VFX.VFXSpawnerState::get_delayBeforeLoop";
    public const string MONO_GetDeltaTime = "UnityEngine.VFX.VFXSpawnerState::get_deltaTime";
    public const string MONO_GetLoopCount = "UnityEngine.VFX.VFXSpawnerState::get_loopCount";
    public const string MONO_GetLoopDuration = "UnityEngine.VFX.VFXSpawnerState::get_loopDuration";
    public const string MONO_GetLoopIndex = "UnityEngine.VFX.VFXSpawnerState::get_loopIndex";
    public const string MONO_GetLoopState = "UnityEngine.VFX.VFXSpawnerState::get_loopState";
    public const string MONO_GetNewLoop = "UnityEngine.VFX.VFXSpawnerState::get_newLoop";
    public const string MONO_GetSpawnCount = "UnityEngine.VFX.VFXSpawnerState::get_spawnCount";
    public const string MONO_GetTotalTime = "UnityEngine.VFX.VFXSpawnerState::get_totalTime";
    public const string MONO_GetVfxEventAttribute = "UnityEngine.VFX.VFXSpawnerState::get_vfxEventAttribute";
    public const string MONO_InternalCreate = "UnityEngine.VFX.VFXSpawnerState::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.VFX.VFXSpawnerState::Internal_Destroy";
    public const string MONO_SetDelayAfterLoop = "UnityEngine.VFX.VFXSpawnerState::set_delayAfterLoop";
    public const string MONO_SetDelayBeforeLoop = "UnityEngine.VFX.VFXSpawnerState::set_delayBeforeLoop";
    public const string MONO_SetDeltaTime = "UnityEngine.VFX.VFXSpawnerState::set_deltaTime";
    public const string MONO_SetLoopCount = "UnityEngine.VFX.VFXSpawnerState::set_loopCount";
    public const string MONO_SetLoopDuration = "UnityEngine.VFX.VFXSpawnerState::set_loopDuration";
    public const string MONO_SetLoopIndex = "UnityEngine.VFX.VFXSpawnerState::set_loopIndex";
    public const string MONO_SetLoopState = "UnityEngine.VFX.VFXSpawnerState::set_loopState";
    public const string MONO_SetSpawnCount = "UnityEngine.VFX.VFXSpawnerState::set_spawnCount";
    public const string MONO_SetTotalTime = "UnityEngine.VFX.VFXSpawnerState::set_totalTime";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_VFX_VFXSpawnerState : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_VFX_VFXSpawnerState(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_VFX_VFXSpawnerState(nint ptr) => new Ptr_UnityEngine_VFX_VFXSpawnerState(ptr);
        public static implicit operator nint(Ptr_UnityEngine_VFX_VFXSpawnerState ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_VFX_VFXSpawnerState ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_Destroy = "UnityEngine.VFX.VFXSpawnerState::Internal_Destroy(System.IntPtr)";
}

