namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CompositeCollider2D
{
    public const string MONO_GenerateGeometry = "UnityEngine.CompositeCollider2D::GenerateGeometry";
    public const string MONO_GetEdgeRadius = "UnityEngine.CompositeCollider2D::get_edgeRadius";
    public const string MONO_GetGenerationType = "UnityEngine.CompositeCollider2D::get_generationType";
    public const string MONO_GetGeometryType = "UnityEngine.CompositeCollider2D::get_geometryType";
    public const string MONO_GetOffsetDistance = "UnityEngine.CompositeCollider2D::get_offsetDistance";
    public const string MONO_GetPathCount = "UnityEngine.CompositeCollider2D::get_pathCount";
    public const string MONO_GetPointCount = "UnityEngine.CompositeCollider2D::get_pointCount";
    public const string MONO_GetVertexDistance = "UnityEngine.CompositeCollider2D::get_vertexDistance";
    public const string MONO_GetPathArrayInternal = "UnityEngine.CompositeCollider2D::GetPathArray_Internal";
    public const string MONO_GetPathListInternal = "UnityEngine.CompositeCollider2D::GetPathList_Internal";
    public const string MONO_GetPathPointCountInternal = "UnityEngine.CompositeCollider2D::GetPathPointCount_Internal";
    public const string MONO_SetEdgeRadius = "UnityEngine.CompositeCollider2D::set_edgeRadius";
    public const string MONO_SetGenerationType = "UnityEngine.CompositeCollider2D::set_generationType";
    public const string MONO_SetGeometryType = "UnityEngine.CompositeCollider2D::set_geometryType";
    public const string MONO_SetOffsetDistance = "UnityEngine.CompositeCollider2D::set_offsetDistance";
    public const string MONO_SetVertexDistance = "UnityEngine.CompositeCollider2D::set_vertexDistance";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CompositeCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CompositeCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CompositeCollider2D(nint ptr) => new Ptr_UnityEngine_CompositeCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CompositeCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CompositeCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_pathCount = "UnityEngine.CompositeCollider2D::get_pathCount()";
    public const string IL2CPP_get_pointCount = "UnityEngine.CompositeCollider2D::get_pointCount()";
    public const string IL2CPP_GetPathArray_Internal = "UnityEngine.CompositeCollider2D::GetPathArray_Internal(System.Int32,UnityEngine.Vector2[])";
}

