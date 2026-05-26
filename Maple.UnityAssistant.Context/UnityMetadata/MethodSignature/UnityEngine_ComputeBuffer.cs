namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ComputeBuffer
{
    public const string MONO_BeginBufferWrite = "UnityEngine.ComputeBuffer::BeginBufferWrite";
    public const string MONO_CopyCount = "UnityEngine.ComputeBuffer::CopyCount";
    public const string MONO_DestroyBuffer = "UnityEngine.ComputeBuffer::DestroyBuffer";
    public const string MONO_EndBufferWrite = "UnityEngine.ComputeBuffer::EndBufferWrite";
    public const string MONO_GetCount = "UnityEngine.ComputeBuffer::get_count";
    public const string MONO_GetStride = "UnityEngine.ComputeBuffer::get_stride";
    public const string MONO_GetUsage = "UnityEngine.ComputeBuffer::get_usage";
    public const string MONO_GetNativeBufferPtr = "UnityEngine.ComputeBuffer::GetNativeBufferPtr";
    public const string MONO_InitBuffer = "UnityEngine.ComputeBuffer::InitBuffer";
    public const string MONO_InternalGetData = "UnityEngine.ComputeBuffer::InternalGetData";
    public const string MONO_InternalSetData = "UnityEngine.ComputeBuffer::InternalSetData";
    public const string MONO_InternalSetNativeData = "UnityEngine.ComputeBuffer::InternalSetNativeData";
    public const string MONO_IsValidBuffer = "UnityEngine.ComputeBuffer::IsValidBuffer";
    public const string MONO_SetCounterValue = "UnityEngine.ComputeBuffer::SetCounterValue";
    public const string MONO_SetName = "UnityEngine.ComputeBuffer::SetName";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ComputeBuffer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ComputeBuffer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ComputeBuffer(nint ptr) => new Ptr_UnityEngine_ComputeBuffer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ComputeBuffer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ComputeBuffer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DestroyBuffer = "UnityEngine.ComputeBuffer::DestroyBuffer(UnityEngine.ComputeBuffer)";
    public const string IL2CPP_get_count = "UnityEngine.ComputeBuffer::get_count()";
    public const string IL2CPP_get_stride = "UnityEngine.ComputeBuffer::get_stride()";
    public const string IL2CPP_InitBuffer = "UnityEngine.ComputeBuffer::InitBuffer(System.Int32,System.Int32,UnityEngine.ComputeBufferType,UnityEngine.ComputeBufferMode)";
    public const string IL2CPP_InternalSetData = "UnityEngine.ComputeBuffer::InternalSetData(System.Array,System.Int32,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_InternalSetNativeData = "UnityEngine.ComputeBuffer::InternalSetNativeData(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_SetName = "UnityEngine.ComputeBuffer::SetName(System.String)";
}

