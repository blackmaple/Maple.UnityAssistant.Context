namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_TLS_LowLevel_Binding
{
    public const string MONO_UnitytlsClientAddCiphersuite = "Unity.TLS.LowLevel.Binding::unitytls_client_add_ciphersuite";
    public const string MONO_UnitytlsClientCreate = "Unity.TLS.LowLevel.Binding::unitytls_client_create";
    public const string MONO_UnitytlsClientDestroy = "Unity.TLS.LowLevel.Binding::unitytls_client_destroy";
    public const string MONO_UnitytlsClientGetCiphersuite = "Unity.TLS.LowLevel.Binding::unitytls_client_get_ciphersuite";
    public const string MONO_UnitytlsClientGetCiphersuiteCnt = "Unity.TLS.LowLevel.Binding::unitytls_client_get_ciphersuite_cnt";
    public const string MONO_UnitytlsClientGetErrorsState = "Unity.TLS.LowLevel.Binding::unitytls_client_get_errorsState";
    public const string MONO_UnitytlsClientGetHandshakeState = "Unity.TLS.LowLevel.Binding::unitytls_client_get_handshake_state";
    public const string MONO_UnitytlsClientGetRole = "Unity.TLS.LowLevel.Binding::unitytls_client_get_role";
    public const string MONO_UnitytlsClientGetState = "Unity.TLS.LowLevel.Binding::unitytls_client_get_state";
    public const string MONO_UnitytlsClientHandshake = "Unity.TLS.LowLevel.Binding::unitytls_client_handshake";
    public const string MONO_UnitytlsClientInit = "Unity.TLS.LowLevel.Binding::unitytls_client_init";
    public const string MONO_UnitytlsClientInitConfig = "Unity.TLS.LowLevel.Binding::unitytls_client_init_config";
    public const string MONO_UnitytlsClientReadData = "Unity.TLS.LowLevel.Binding::unitytls_client_read_data";
    public const string MONO_UnitytlsClientSendData = "Unity.TLS.LowLevel.Binding::unitytls_client_send_data";
    public const string MONO_UnitytlsClientSetCookieInfo = "Unity.TLS.LowLevel.Binding::unitytls_client_set_cookie_info";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_TLS_LowLevel_Binding : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_TLS_LowLevel_Binding(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_TLS_LowLevel_Binding(nint ptr) => new Ptr_Unity_TLS_LowLevel_Binding(ptr);
        public static implicit operator nint(Ptr_Unity_TLS_LowLevel_Binding ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_TLS_LowLevel_Binding ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
