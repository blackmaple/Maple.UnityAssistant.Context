namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_HostTopologyInternal
{
    public const string MONO_AddSpecialConnectionConfig = "UnityEngine.Networking.HostTopologyInternal::AddSpecialConnectionConfig";
    public const string MONO_InternalCreate = "UnityEngine.Networking.HostTopologyInternal::InternalCreate";
    public const string MONO_InternalDestroy = "UnityEngine.Networking.HostTopologyInternal::InternalDestroy";
    public const string MONO_SetMessagePoolSizeGrowthFactor = "UnityEngine.Networking.HostTopologyInternal::set_MessagePoolSizeGrowthFactor";
    public const string MONO_SetReceivedMessagePoolSize = "UnityEngine.Networking.HostTopologyInternal::set_ReceivedMessagePoolSize";
    public const string MONO_SetSentMessagePoolSize = "UnityEngine.Networking.HostTopologyInternal::set_SentMessagePoolSize";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_HostTopologyInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_HostTopologyInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_HostTopologyInternal(nint ptr) => new Ptr_UnityEngine_Networking_HostTopologyInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_HostTopologyInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_HostTopologyInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
