namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMeshBuildSource
{
    public const string MONO_InternalGetComponent = "UnityEngine.AI.NavMeshBuildSource::InternalGetComponent";
    public const string MONO_InternalGetObject = "UnityEngine.AI.NavMeshBuildSource::InternalGetObject";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMeshBuildSource : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMeshBuildSource(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMeshBuildSource(nint ptr) => new Ptr_UnityEngine_AI_NavMeshBuildSource(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMeshBuildSource ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMeshBuildSource ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_InternalGetComponent = "UnityEngine.AI.NavMeshBuildSource::InternalGetComponent(System.Int32)";
    public const string IL2CPP_InternalGetObject = "UnityEngine.AI.NavMeshBuildSource::InternalGetObject(System.Int32)";
}

