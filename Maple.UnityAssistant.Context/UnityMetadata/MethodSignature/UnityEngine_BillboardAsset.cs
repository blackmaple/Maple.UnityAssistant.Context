namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_BillboardAsset
{
    public const string MONO_GetBottom = "UnityEngine.BillboardAsset::get_bottom";
    public const string MONO_GetHeight = "UnityEngine.BillboardAsset::get_height";
    public const string MONO_GetImageCount = "UnityEngine.BillboardAsset::get_imageCount";
    public const string MONO_GetIndexCount = "UnityEngine.BillboardAsset::get_indexCount";
    public const string MONO_GetMaterial = "UnityEngine.BillboardAsset::get_material";
    public const string MONO_GetVertexCount = "UnityEngine.BillboardAsset::get_vertexCount";
    public const string MONO_GetWidth = "UnityEngine.BillboardAsset::get_width";
    public const string MONO_GetImageTexCoords = "UnityEngine.BillboardAsset::GetImageTexCoords";
    public const string MONO_GetImageTexCoordsInternal = "UnityEngine.BillboardAsset::GetImageTexCoordsInternal";
    public const string MONO_GetIndices = "UnityEngine.BillboardAsset::GetIndices";
    public const string MONO_GetIndicesInternal = "UnityEngine.BillboardAsset::GetIndicesInternal";
    public const string MONO_GetVertices = "UnityEngine.BillboardAsset::GetVertices";
    public const string MONO_GetVerticesInternal = "UnityEngine.BillboardAsset::GetVerticesInternal";
    public const string MONO_InternalCreate = "UnityEngine.BillboardAsset::Internal_Create";
    public const string MONO_MakeMaterialProperties = "UnityEngine.BillboardAsset::MakeMaterialProperties";
    public const string MONO_SetBottom = "UnityEngine.BillboardAsset::set_bottom";
    public const string MONO_SetHeight = "UnityEngine.BillboardAsset::set_height";
    public const string MONO_SetMaterial = "UnityEngine.BillboardAsset::set_material";
    public const string MONO_SetWidth = "UnityEngine.BillboardAsset::set_width";
    public const string MONO_SetImageTexCoords = "UnityEngine.BillboardAsset::SetImageTexCoords";
    public const string MONO_SetImageTexCoordsInternalList = "UnityEngine.BillboardAsset::SetImageTexCoordsInternalList";
    public const string MONO_SetIndices = "UnityEngine.BillboardAsset::SetIndices";
    public const string MONO_SetIndicesInternalList = "UnityEngine.BillboardAsset::SetIndicesInternalList";
    public const string MONO_SetVertices = "UnityEngine.BillboardAsset::SetVertices";
    public const string MONO_SetVerticesInternalList = "UnityEngine.BillboardAsset::SetVerticesInternalList";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_BillboardAsset : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_BillboardAsset(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_BillboardAsset(nint ptr) => new Ptr_UnityEngine_BillboardAsset(ptr);
        public static implicit operator nint(Ptr_UnityEngine_BillboardAsset ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_BillboardAsset ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
