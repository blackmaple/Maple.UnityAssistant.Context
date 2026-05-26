namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ClusterNetwork
{
    public const string MONO_GetIsDisconnected = "UnityEngine.ClusterNetwork::get_isDisconnected";
    public const string MONO_GetIsMasterOfCluster = "UnityEngine.ClusterNetwork::get_isMasterOfCluster";
    public const string MONO_GetNodeIndex = "UnityEngine.ClusterNetwork::get_nodeIndex";
    public const string MONO_SetNodeIndex = "UnityEngine.ClusterNetwork::set_nodeIndex";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ClusterNetwork : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ClusterNetwork(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ClusterNetwork(nint ptr) => new Ptr_UnityEngine_ClusterNetwork(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ClusterNetwork ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ClusterNetwork ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
