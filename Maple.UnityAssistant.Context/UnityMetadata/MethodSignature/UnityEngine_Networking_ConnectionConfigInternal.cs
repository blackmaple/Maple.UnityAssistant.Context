namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_ConnectionConfigInternal
{
    public const string MONO_AddChannel = "UnityEngine.Networking.ConnectionConfigInternal::AddChannel";
    public const string MONO_InternalCreate = "UnityEngine.Networking.ConnectionConfigInternal::InternalCreate";
    public const string MONO_InternalDestroy = "UnityEngine.Networking.ConnectionConfigInternal::InternalDestroy";
    public const string MONO_MakeChannelsSharedOrder = "UnityEngine.Networking.ConnectionConfigInternal::MakeChannelsSharedOrder";
    public const string MONO_SetAckDelay = "UnityEngine.Networking.ConnectionConfigInternal::set_AckDelay";
    public const string MONO_SetAcksType = "UnityEngine.Networking.ConnectionConfigInternal::set_AcksType";
    public const string MONO_SetAllCostTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_AllCostTimeout";
    public const string MONO_SetBandwidthPeakFactor = "UnityEngine.Networking.ConnectionConfigInternal::set_BandwidthPeakFactor";
    public const string MONO_SetConnectTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_ConnectTimeout";
    public const string MONO_SetDisconnectTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_DisconnectTimeout";
    public const string MONO_SetFragmentSize = "UnityEngine.Networking.ConnectionConfigInternal::set_FragmentSize";
    public const string MONO_SetInitialBandwidth = "UnityEngine.Networking.ConnectionConfigInternal::set_InitialBandwidth";
    public const string MONO_SetMaxCombinedReliableMessageCount = "UnityEngine.Networking.ConnectionConfigInternal::set_MaxCombinedReliableMessageCount";
    public const string MONO_SetMaxCombinedReliableMessageSize = "UnityEngine.Networking.ConnectionConfigInternal::set_MaxCombinedReliableMessageSize";
    public const string MONO_SetMaxConnectionAttempt = "UnityEngine.Networking.ConnectionConfigInternal::set_MaxConnectionAttempt";
    public const string MONO_SetMaxSentMessageQueueSize = "UnityEngine.Networking.ConnectionConfigInternal::set_MaxSentMessageQueueSize";
    public const string MONO_SetMinUpdateTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_MinUpdateTimeout";
    public const string MONO_SetNetworkDropThreshold = "UnityEngine.Networking.ConnectionConfigInternal::set_NetworkDropThreshold";
    public const string MONO_SetOverflowDropThreshold = "UnityEngine.Networking.ConnectionConfigInternal::set_OverflowDropThreshold";
    public const string MONO_SetPingTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_PingTimeout";
    public const string MONO_SetReducedPingTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_ReducedPingTimeout";
    public const string MONO_SetResendTimeout = "UnityEngine.Networking.ConnectionConfigInternal::set_ResendTimeout";
    public const string MONO_SetSendDelay = "UnityEngine.Networking.ConnectionConfigInternal::set_SendDelay";
    public const string MONO_SetUdpSocketReceiveBufferMaxSize = "UnityEngine.Networking.ConnectionConfigInternal::set_UdpSocketReceiveBufferMaxSize";
    public const string MONO_SetUsePlatformSpecificProtocols = "UnityEngine.Networking.ConnectionConfigInternal::set_UsePlatformSpecificProtocols";
    public const string MONO_SetWebSocketReceiveBufferMaxSize = "UnityEngine.Networking.ConnectionConfigInternal::set_WebSocketReceiveBufferMaxSize";
    public const string MONO_SetPacketSize = "UnityEngine.Networking.ConnectionConfigInternal::SetPacketSize";
    public const string MONO_SetSslcafilePath = "UnityEngine.Networking.ConnectionConfigInternal::SetSSLCAFilePath";
    public const string MONO_SetSslcertFilePath = "UnityEngine.Networking.ConnectionConfigInternal::SetSSLCertFilePath";
    public const string MONO_SetSslprivateKeyFilePath = "UnityEngine.Networking.ConnectionConfigInternal::SetSSLPrivateKeyFilePath";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_ConnectionConfigInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_ConnectionConfigInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_ConnectionConfigInternal(nint ptr) => new Ptr_UnityEngine_Networking_ConnectionConfigInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_ConnectionConfigInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_ConnectionConfigInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
