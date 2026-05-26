namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Collections_LowLevel_Unsafe_UnsafeUtility
{
    public const string MONO_CheckForLeaks = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CheckForLeaks";
    public const string MONO_CopyObjectAddressToPtr = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr";
    public const string MONO_ForgiveLeaks = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ForgiveLeaks";
    public const string MONO_Free = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Free";
    public const string MONO_FreeTracked = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::FreeTracked";
    public const string MONO_GetFieldOffsetInClass = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass";
    public const string MONO_GetFieldOffsetInStruct = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct";
    public const string MONO_GetLeakDetectionMode = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetLeakDetectionMode";
    public const string MONO_IsBlittable = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsBlittable";
    public const string MONO_IsUnmanaged = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged";
    public const string MONO_IsValidNativeContainerElementType = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType";
    public const string MONO_LeakErase = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LeakErase";
    public const string MONO_LeakRecord = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LeakRecord";
    public const string MONO_LogError = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError";
    public const string MONO_Malloc = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Malloc";
    public const string MONO_MallocTracked = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MallocTracked";
    public const string MONO_MemCmp = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCmp";
    public const string MONO_MemCpy = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy";
    public const string MONO_MemCpyReplicate = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate";
    public const string MONO_MemCpyStride = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyStride";
    public const string MONO_MemMove = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemMove";
    public const string MONO_MemSet = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet";
    public const string MONO_PinSystemArrayAndGetAddress = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress";
    public const string MONO_PinSystemObjectAndGetAddress = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress";
    public const string MONO_ReleaseGcobject = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject";
    public const string MONO_SetLeakDetectionMode = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SetLeakDetectionMode";
    public const string MONO_SizeOf = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility(nint ptr) => new Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility(ptr);
        public static implicit operator nint(Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Collections_LowLevel_Unsafe_UnsafeUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Free = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Free(System.Void*,Unity.Collections.Allocator)";
    public const string IL2CPP_IsBlittable = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsBlittable(System.Type)";
    public const string IL2CPP_IsUnmanaged = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged(System.Type)";
    public const string IL2CPP_Malloc = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Malloc(System.Int64,System.Int32,Unity.Collections.Allocator)";
    public const string IL2CPP_MemCmp = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCmp(System.Void*,System.Void*,System.Int64)";
    public const string IL2CPP_MemCpy = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)";
    public const string IL2CPP_MemCpyStride = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyStride(System.Void*,System.Int32,System.Void*,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_MemMove = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemMove(System.Void*,System.Void*,System.Int64)";
    public const string IL2CPP_MemSet = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)";
    public const string IL2CPP_SizeOf = "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf(System.Type)";
}

