namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMeshBuilder
{
    public const string MONO_Cancel = "UnityEngine.AI.NavMeshBuilder::Cancel";
    public const string MONO_CollectSourcesInternalInjected = "UnityEngine.AI.NavMeshBuilder::CollectSourcesInternal_Injected";
    public const string MONO_UpdateNavMeshDataAsyncListInternalInjected = "UnityEngine.AI.NavMeshBuilder::UpdateNavMeshDataAsyncListInternal_Injected";
    public const string MONO_UpdateNavMeshDataListInternalInjected = "UnityEngine.AI.NavMeshBuilder::UpdateNavMeshDataListInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMeshBuilder : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMeshBuilder(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMeshBuilder(nint ptr) => new Ptr_UnityEngine_AI_NavMeshBuilder(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMeshBuilder ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMeshBuilder ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CollectSourcesInternal_Injected = "UnityEngine.AI.NavMeshBuilder::CollectSourcesInternal_Injected(System.Int32,UnityEngine.Bounds&,UnityEngine.Transform,System.Boolean,UnityEngine.AI.NavMeshCollectGeometry,System.Int32,UnityEngine.AI.NavMeshBuildMarkup[])";
    public const string IL2CPP_UpdateNavMeshDataAsyncListInternal_Injected = "UnityEngine.AI.NavMeshBuilder::UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData,UnityEngine.AI.NavMeshBuildSettings&,System.Object,UnityEngine.Bounds&)";
    public const string IL2CPP_UpdateNavMeshDataListInternal_Injected = "UnityEngine.AI.NavMeshBuilder::UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData,UnityEngine.AI.NavMeshBuildSettings&,System.Object,UnityEngine.Bounds&)";
}

