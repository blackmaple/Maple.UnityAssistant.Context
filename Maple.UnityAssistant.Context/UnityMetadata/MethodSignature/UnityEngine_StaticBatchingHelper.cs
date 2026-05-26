namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_StaticBatchingHelper
{
    public const string MONO_InternalCombineIndices = "UnityEngine.StaticBatchingHelper::InternalCombineIndices";
    public const string MONO_InternalCombineVertices = "UnityEngine.StaticBatchingHelper::InternalCombineVertices";
    public const string MONO_IsMeshBatchable = "UnityEngine.StaticBatchingHelper::IsMeshBatchable";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_StaticBatchingHelper : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_StaticBatchingHelper(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_StaticBatchingHelper(nint ptr) => new Ptr_UnityEngine_StaticBatchingHelper(ptr);
        public static implicit operator nint(Ptr_UnityEngine_StaticBatchingHelper ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_StaticBatchingHelper ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
