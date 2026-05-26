namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_IO_LowLevel_Unsafe_ReadHandle
{
    public const string MONO_CancelInternalInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::CancelInternal_Injected";
    public const string MONO_GetBytesReadInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesRead_Injected";
    public const string MONO_GetBytesReadArrayInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadArray_Injected";
    public const string MONO_GetBytesReadForCommandInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadForCommand_Injected";
    public const string MONO_GetJobHandleInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetJobHandle_Injected";
    public const string MONO_GetReadCountInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetReadCount_Injected";
    public const string MONO_GetReadStatusInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::GetReadStatus_Injected";
    public const string MONO_IsReadHandleValidInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::IsReadHandleValid_Injected";
    public const string MONO_ReleaseReadHandleInjected = "Unity.IO.LowLevel.Unsafe.ReadHandle::ReleaseReadHandle_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle(nint ptr) => new Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle(ptr);
        public static implicit operator nint(Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_IO_LowLevel_Unsafe_ReadHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
