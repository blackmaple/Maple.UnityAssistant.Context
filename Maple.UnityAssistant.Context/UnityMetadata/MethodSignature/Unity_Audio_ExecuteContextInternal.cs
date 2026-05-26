namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_ExecuteContextInternal
{
    public const string MONO_InternalPostEvent = "Unity.Audio.ExecuteContextInternal::Internal_PostEvent";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_ExecuteContextInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_ExecuteContextInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_ExecuteContextInternal(nint ptr) => new Ptr_Unity_Audio_ExecuteContextInternal(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_ExecuteContextInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_ExecuteContextInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
