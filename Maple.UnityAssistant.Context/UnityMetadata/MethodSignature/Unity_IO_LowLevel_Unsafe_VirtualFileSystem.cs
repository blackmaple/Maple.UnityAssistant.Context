namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_IO_LowLevel_Unsafe_VirtualFileSystem
{
    public const string MONO_GetLocalFileSystemName = "Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem(nint ptr) => new Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem(ptr);
        public static implicit operator nint(Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_IO_LowLevel_Unsafe_VirtualFileSystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
