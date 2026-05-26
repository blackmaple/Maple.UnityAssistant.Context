namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GraphicsBuffer
{
    public const string MONO_CopyCountCc = "UnityEngine.GraphicsBuffer::CopyCountCC";
    public const string MONO_CopyCountCg = "UnityEngine.GraphicsBuffer::CopyCountCG";
    public const string MONO_CopyCountGc = "UnityEngine.GraphicsBuffer::CopyCountGC";
    public const string MONO_CopyCountGg = "UnityEngine.GraphicsBuffer::CopyCountGG";
    public const string MONO_DestroyBuffer = "UnityEngine.GraphicsBuffer::DestroyBuffer";
    public const string MONO_GetCount = "UnityEngine.GraphicsBuffer::get_count";
    public const string MONO_GetStride = "UnityEngine.GraphicsBuffer::get_stride";
    public const string MONO_GetTarget = "UnityEngine.GraphicsBuffer::get_target";
    public const string MONO_GetNativeBufferPtr = "UnityEngine.GraphicsBuffer::GetNativeBufferPtr";
    public const string MONO_InitBuffer = "UnityEngine.GraphicsBuffer::InitBuffer";
    public const string MONO_InternalGetData = "UnityEngine.GraphicsBuffer::InternalGetData";
    public const string MONO_InternalSetData = "UnityEngine.GraphicsBuffer::InternalSetData";
    public const string MONO_InternalSetNativeData = "UnityEngine.GraphicsBuffer::InternalSetNativeData";
    public const string MONO_IsValidBuffer = "UnityEngine.GraphicsBuffer::IsValidBuffer";
    public const string MONO_SetCounterValue = "UnityEngine.GraphicsBuffer::SetCounterValue";
    public const string MONO_SetName = "UnityEngine.GraphicsBuffer::SetName";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GraphicsBuffer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GraphicsBuffer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GraphicsBuffer(nint ptr) => new Ptr_UnityEngine_GraphicsBuffer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GraphicsBuffer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GraphicsBuffer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
