namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Mesh_MeshData
{
    public const string MONO_CopyAttributeIntoPtr = "UnityEngine.Mesh/MeshData::CopyAttributeIntoPtr";
    public const string MONO_CopyIndicesIntoPtr = "UnityEngine.Mesh/MeshData::CopyIndicesIntoPtr";
    public const string MONO_GetIndexCount = "UnityEngine.Mesh/MeshData::GetIndexCount";
    public const string MONO_GetIndexDataPtr = "UnityEngine.Mesh/MeshData::GetIndexDataPtr";
    public const string MONO_GetIndexDataSize = "UnityEngine.Mesh/MeshData::GetIndexDataSize";
    public const string MONO_GetIndexFormat = "UnityEngine.Mesh/MeshData::GetIndexFormat";
    public const string MONO_GetSubMeshInjected = "UnityEngine.Mesh/MeshData::GetSubMesh_Injected";
    public const string MONO_GetSubMeshCount = "UnityEngine.Mesh/MeshData::GetSubMeshCount";
    public const string MONO_GetVertexAttributeDimension = "UnityEngine.Mesh/MeshData::GetVertexAttributeDimension";
    public const string MONO_GetVertexAttributeFormat = "UnityEngine.Mesh/MeshData::GetVertexAttributeFormat";
    public const string MONO_GetVertexAttributeOffset = "UnityEngine.Mesh/MeshData::GetVertexAttributeOffset";
    public const string MONO_GetVertexAttributeStream = "UnityEngine.Mesh/MeshData::GetVertexAttributeStream";
    public const string MONO_GetVertexBufferCount = "UnityEngine.Mesh/MeshData::GetVertexBufferCount";
    public const string MONO_GetVertexBufferStride = "UnityEngine.Mesh/MeshData::GetVertexBufferStride";
    public const string MONO_GetVertexCount = "UnityEngine.Mesh/MeshData::GetVertexCount";
    public const string MONO_GetVertexDataPtr = "UnityEngine.Mesh/MeshData::GetVertexDataPtr";
    public const string MONO_GetVertexDataSize = "UnityEngine.Mesh/MeshData::GetVertexDataSize";
    public const string MONO_HasVertexAttribute = "UnityEngine.Mesh/MeshData::HasVertexAttribute";
    public const string MONO_SetIndexBufferParamsImpl = "UnityEngine.Mesh/MeshData::SetIndexBufferParamsImpl";
    public const string MONO_SetSubMeshCount = "UnityEngine.Mesh/MeshData::SetSubMeshCount";
    public const string MONO_SetSubMeshImplInjected = "UnityEngine.Mesh/MeshData::SetSubMeshImpl_Injected";
    public const string MONO_SetVertexBufferParamsFromArray = "UnityEngine.Mesh/MeshData::SetVertexBufferParamsFromArray";
    public const string MONO_SetVertexBufferParamsFromPtr = "UnityEngine.Mesh/MeshData::SetVertexBufferParamsFromPtr";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Mesh_MeshData : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Mesh_MeshData(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Mesh_MeshData(nint ptr) => new Ptr_UnityEngine_Mesh_MeshData(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Mesh_MeshData ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Mesh_MeshData ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
