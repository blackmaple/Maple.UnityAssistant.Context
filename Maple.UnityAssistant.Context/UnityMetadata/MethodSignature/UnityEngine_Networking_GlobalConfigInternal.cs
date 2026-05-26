namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_GlobalConfigInternal
{
    public const string MONO_InternalCreate = "UnityEngine.Networking.GlobalConfigInternal::InternalCreate";
    public const string MONO_InternalDestroy = "UnityEngine.Networking.GlobalConfigInternal::InternalDestroy";
    public const string MONO_SetMaxHosts = "UnityEngine.Networking.GlobalConfigInternal::set_MaxHosts";
    public const string MONO_SetMaxNetSimulatorTimeout = "UnityEngine.Networking.GlobalConfigInternal::set_MaxNetSimulatorTimeout";
    public const string MONO_SetMaxPacketSize = "UnityEngine.Networking.GlobalConfigInternal::set_MaxPacketSize";
    public const string MONO_SetMaxTimerTimeout = "UnityEngine.Networking.GlobalConfigInternal::set_MaxTimerTimeout";
    public const string MONO_SetMinNetSimulatorTimeout = "UnityEngine.Networking.GlobalConfigInternal::set_MinNetSimulatorTimeout";
    public const string MONO_SetMinTimerTimeout = "UnityEngine.Networking.GlobalConfigInternal::set_MinTimerTimeout";
    public const string MONO_SetReactorMaximumReceivedMessages = "UnityEngine.Networking.GlobalConfigInternal::set_ReactorMaximumReceivedMessages";
    public const string MONO_SetReactorMaximumSentMessages = "UnityEngine.Networking.GlobalConfigInternal::set_ReactorMaximumSentMessages";
    public const string MONO_SetReactorModel = "UnityEngine.Networking.GlobalConfigInternal::set_ReactorModel";
    public const string MONO_SetThreadAwakeTimeout = "UnityEngine.Networking.GlobalConfigInternal::set_ThreadAwakeTimeout";
    public const string MONO_SetThreadPoolSize = "UnityEngine.Networking.GlobalConfigInternal::set_ThreadPoolSize";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_GlobalConfigInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_GlobalConfigInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_GlobalConfigInternal(nint ptr) => new Ptr_UnityEngine_Networking_GlobalConfigInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_GlobalConfigInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_GlobalConfigInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
