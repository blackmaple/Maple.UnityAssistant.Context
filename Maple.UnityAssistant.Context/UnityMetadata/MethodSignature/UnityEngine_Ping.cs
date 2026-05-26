namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Ping
{
    public const string MONO_GetIp = "UnityEngine.Ping::get_ip";
    public const string MONO_GetTime = "UnityEngine.Ping::get_time";
    public const string MONO_InternalCreate = "UnityEngine.Ping::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.Ping::Internal_Destroy";
    public const string MONO_InternalIsDone = "UnityEngine.Ping::Internal_IsDone";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Ping : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Ping(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Ping(nint ptr) => new Ptr_UnityEngine_Ping(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Ping ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Ping ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
