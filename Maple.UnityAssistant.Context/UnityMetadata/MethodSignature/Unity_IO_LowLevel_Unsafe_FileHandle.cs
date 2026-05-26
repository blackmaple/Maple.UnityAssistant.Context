namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_IO_LowLevel_Unsafe_FileHandle
{
    public const string MONO_GetFileStatusInternal = "Unity.IO.LowLevel.Unsafe.FileHandle::GetFileStatus_Internal";
    public const string MONO_GetJobHandleInternalInjected = "Unity.IO.LowLevel.Unsafe.FileHandle::GetJobHandle_Internal_Injected";
    public const string MONO_IsFileHandleValid = "Unity.IO.LowLevel.Unsafe.FileHandle::IsFileHandleValid";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_IO_LowLevel_Unsafe_FileHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_IO_LowLevel_Unsafe_FileHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_IO_LowLevel_Unsafe_FileHandle(nint ptr) => new Ptr_Unity_IO_LowLevel_Unsafe_FileHandle(ptr);
        public static implicit operator nint(Ptr_Unity_IO_LowLevel_Unsafe_FileHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_IO_LowLevel_Unsafe_FileHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
