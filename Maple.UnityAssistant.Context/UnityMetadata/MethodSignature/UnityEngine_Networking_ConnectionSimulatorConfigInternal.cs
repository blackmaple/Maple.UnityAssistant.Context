namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_ConnectionSimulatorConfigInternal
{
    public const string MONO_InternalCreate = "UnityEngine.Networking.ConnectionSimulatorConfigInternal::InternalCreate";
    public const string MONO_InternalDestroy = "UnityEngine.Networking.ConnectionSimulatorConfigInternal::InternalDestroy";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal(nint ptr) => new Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_ConnectionSimulatorConfigInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
