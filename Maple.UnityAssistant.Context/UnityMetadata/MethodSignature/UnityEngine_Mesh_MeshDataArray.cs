namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Mesh_MeshDataArray
{
    public const string MONO_AcquireReadOnlyMeshData = "UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshData";
    public const string MONO_AcquireReadOnlyMeshDatas = "UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshDatas";
    public const string MONO_ApplyToMeshesImpl = "UnityEngine.Mesh/MeshDataArray::ApplyToMeshesImpl";
    public const string MONO_ApplyToMeshImpl = "UnityEngine.Mesh/MeshDataArray::ApplyToMeshImpl";
    public const string MONO_CreateNewMeshDatas = "UnityEngine.Mesh/MeshDataArray::CreateNewMeshDatas";
    public const string MONO_ReleaseMeshDatas = "UnityEngine.Mesh/MeshDataArray::ReleaseMeshDatas";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Mesh_MeshDataArray : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Mesh_MeshDataArray(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Mesh_MeshDataArray(nint ptr) => new Ptr_UnityEngine_Mesh_MeshDataArray(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Mesh_MeshDataArray ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Mesh_MeshDataArray ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
