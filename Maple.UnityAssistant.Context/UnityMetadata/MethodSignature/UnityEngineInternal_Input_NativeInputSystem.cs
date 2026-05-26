namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_Input_NativeInputSystem
{
    public const string MONO_AllocateDeviceId = "UnityEngineInternal.Input.NativeInputSystem::AllocateDeviceId";
    public const string MONO_GetCurrentTime = "UnityEngineInternal.Input.NativeInputSystem::get_currentTime";
    public const string MONO_GetCurrentTimeOffsetToRealtimeSinceStartup = "UnityEngineInternal.Input.NativeInputSystem::get_currentTimeOffsetToRealtimeSinceStartup";
    public const string MONO_Ioctl = "UnityEngineInternal.Input.NativeInputSystem::IOCTL";
    public const string MONO_QueueInputEvent = "UnityEngineInternal.Input.NativeInputSystem::QueueInputEvent";
    public const string MONO_SetHasDeviceDiscoveredCallback = "UnityEngineInternal.Input.NativeInputSystem::set_hasDeviceDiscoveredCallback";
    public const string MONO_SetPollingFrequency = "UnityEngineInternal.Input.NativeInputSystem::SetPollingFrequency";
    public const string MONO_Update = "UnityEngineInternal.Input.NativeInputSystem::Update";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_Input_NativeInputSystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_Input_NativeInputSystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_Input_NativeInputSystem(nint ptr) => new Ptr_UnityEngineInternal_Input_NativeInputSystem(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_Input_NativeInputSystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_Input_NativeInputSystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AllocateDeviceId = "UnityEngineInternal.Input.NativeInputSystem::AllocateDeviceId()";
    public const string IL2CPP_get_currentTime = "UnityEngineInternal.Input.NativeInputSystem::get_currentTime()";
    public const string IL2CPP_get_currentTimeOffsetToRealtimeSinceStartup = "UnityEngineInternal.Input.NativeInputSystem::get_currentTimeOffsetToRealtimeSinceStartup()";
    public const string IL2CPP_IOCTL = "UnityEngineInternal.Input.NativeInputSystem::IOCTL(System.Int32,System.Int32,System.IntPtr,System.Int32)";
    public const string IL2CPP_QueueInputEvent = "UnityEngineInternal.Input.NativeInputSystem::QueueInputEvent(System.IntPtr)";
    public const string IL2CPP_set_hasDeviceDiscoveredCallback = "UnityEngineInternal.Input.NativeInputSystem::set_hasDeviceDiscoveredCallback(System.Boolean)";
    public const string IL2CPP_SetPollingFrequency = "UnityEngineInternal.Input.NativeInputSystem::SetPollingFrequency(System.Single)";
    public const string IL2CPP_Update = "UnityEngineInternal.Input.NativeInputSystem::Update(UnityEngineInternal.Input.NativeInputUpdateType)";
}

