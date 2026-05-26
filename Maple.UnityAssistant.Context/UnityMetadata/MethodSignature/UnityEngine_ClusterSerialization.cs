namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ClusterSerialization
{
    public const string MONO_RestoreClusterInputStateInternal = "UnityEngine.ClusterSerialization::RestoreClusterInputStateInternal";
    public const string MONO_RestoreInputManagerStateInternal = "UnityEngine.ClusterSerialization::RestoreInputManagerStateInternal";
    public const string MONO_RestoreTimeManagerStateInternal = "UnityEngine.ClusterSerialization::RestoreTimeManagerStateInternal";
    public const string MONO_SaveClusterInputStateInternal = "UnityEngine.ClusterSerialization::SaveClusterInputStateInternal";
    public const string MONO_SaveInputManagerStateInternal = "UnityEngine.ClusterSerialization::SaveInputManagerStateInternal";
    public const string MONO_SaveTimeManagerStateInternal = "UnityEngine.ClusterSerialization::SaveTimeManagerStateInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ClusterSerialization : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ClusterSerialization(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ClusterSerialization(nint ptr) => new Ptr_UnityEngine_ClusterSerialization(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ClusterSerialization ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ClusterSerialization ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
