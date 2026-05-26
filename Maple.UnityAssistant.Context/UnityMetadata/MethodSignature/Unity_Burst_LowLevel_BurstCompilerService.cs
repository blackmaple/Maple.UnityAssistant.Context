namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Burst_LowLevel_BurstCompilerService
{
    public const string MONO_CompileAsyncDelegateMethod = "Unity.Burst.LowLevel.BurstCompilerService::CompileAsyncDelegateMethod";
    public const string MONO_GetIsInitialized = "Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized";
    public const string MONO_GetAsyncCompiledAsyncDelegateMethod = "Unity.Burst.LowLevel.BurstCompilerService::GetAsyncCompiledAsyncDelegateMethod";
    public const string MONO_GetCurrentExecutionMode = "Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode";
    public const string MONO_GetDisassembly = "Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly";
    public const string MONO_GetMethodSignature = "Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature";
    public const string MONO_GetOrCreateSharedMemory = "Unity.Burst.LowLevel.BurstCompilerService::GetOrCreateSharedMemory";
    public const string MONO_InitializeInternal = "Unity.Burst.LowLevel.BurstCompilerService::InitializeInternal";
    public const string MONO_LoadBurstLibrary = "Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary";
    public const string MONO_Log = "Unity.Burst.LowLevel.BurstCompilerService::Log";
    public const string MONO_SetCurrentExecutionMode = "Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Burst_LowLevel_BurstCompilerService : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Burst_LowLevel_BurstCompilerService(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Burst_LowLevel_BurstCompilerService(nint ptr) => new Ptr_Unity_Burst_LowLevel_BurstCompilerService(ptr);
        public static implicit operator nint(Ptr_Unity_Burst_LowLevel_BurstCompilerService ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Burst_LowLevel_BurstCompilerService ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CompileAsyncDelegateMethod = "Unity.Burst.LowLevel.BurstCompilerService::CompileAsyncDelegateMethod(System.Object,System.String)";
    public const string IL2CPP_GetAsyncCompiledAsyncDelegateMethod = "Unity.Burst.LowLevel.BurstCompilerService::GetAsyncCompiledAsyncDelegateMethod(System.Int32)";
    public const string IL2CPP_GetCurrentExecutionMode = "Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode()";
    public const string IL2CPP_GetDisassembly = "Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly(System.Reflection.MethodInfo,System.String)";
    public const string IL2CPP_GetOrCreateSharedMemory = "Unity.Burst.LowLevel.BurstCompilerService::GetOrCreateSharedMemory(UnityEngine.Hash128&,System.UInt32,System.UInt32)";
    public const string IL2CPP_LoadBurstLibrary = "Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary(System.String)";
    public const string IL2CPP_Log = "Unity.Burst.LowLevel.BurstCompilerService::Log(System.Void*,Unity.Burst.LowLevel.BurstCompilerService/BurstLogType,System.Byte*,System.Byte*,System.Int32)";
    public const string IL2CPP_SetCurrentExecutionMode = "Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode(System.UInt32)";
}

