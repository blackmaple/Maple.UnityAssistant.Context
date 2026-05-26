namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_GIDebugVisualisation
{
    public const string MONO_CycleSkipInstances = "UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances";
    public const string MONO_CycleSkipSystems = "UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems";
    public const string MONO_GetCycleMode = "UnityEngineInternal.GIDebugVisualisation::get_cycleMode";
    public const string MONO_GetPauseCycleMode = "UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode";
    public const string MONO_GetTexType = "UnityEngineInternal.GIDebugVisualisation::get_texType";
    public const string MONO_PauseCycleMode = "UnityEngineInternal.GIDebugVisualisation::PauseCycleMode";
    public const string MONO_PlayCycleMode = "UnityEngineInternal.GIDebugVisualisation::PlayCycleMode";
    public const string MONO_ResetRuntimeInputTextures = "UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures";
    public const string MONO_SetTexType = "UnityEngineInternal.GIDebugVisualisation::set_texType";
    public const string MONO_StopCycleMode = "UnityEngineInternal.GIDebugVisualisation::StopCycleMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_GIDebugVisualisation : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_GIDebugVisualisation(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_GIDebugVisualisation(nint ptr) => new Ptr_UnityEngineInternal_GIDebugVisualisation(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_GIDebugVisualisation ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_GIDebugVisualisation ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
