namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_IO_LowLevel_Unsafe_AsyncReadManager
{
    public const string MONO_CloseCachedFileAsyncInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseCachedFileAsync_Injected";
    public const string MONO_CloseFileAsyncInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseFileAsync_Injected";
    public const string MONO_GetFileInfoInternalInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::GetFileInfoInternal_Injected";
    public const string MONO_OpenFileAsyncInternalInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::OpenFileAsync_Internal_Injected";
    public const string MONO_ReadInternalInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadInternal_Injected";
    public const string MONO_ReadWithHandlesInternalNativeCopyInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadWithHandlesInternal_NativeCopy_Injected";
    public const string MONO_ReadWithHandlesInternalNativePtrInjected = "Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadWithHandlesInternal_NativePtr_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager(nint ptr) => new Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager(ptr);
        public static implicit operator nint(Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_IO_LowLevel_Unsafe_AsyncReadManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
