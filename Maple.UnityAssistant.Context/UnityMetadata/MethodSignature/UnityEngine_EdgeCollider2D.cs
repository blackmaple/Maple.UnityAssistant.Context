namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_EdgeCollider2D
{
    public const string MONO_GetAdjacentEndPointInjected = "UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected";
    public const string MONO_GetAdjacentStartPointInjected = "UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected";
    public const string MONO_GetEdgeCount = "UnityEngine.EdgeCollider2D::get_edgeCount";
    public const string MONO_GetEdgeRadius = "UnityEngine.EdgeCollider2D::get_edgeRadius";
    public const string MONO_GetPointCount = "UnityEngine.EdgeCollider2D::get_pointCount";
    public const string MONO_GetPoints = "UnityEngine.EdgeCollider2D::get_points";
    public const string MONO_GetUseAdjacentEndPoint = "UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint";
    public const string MONO_GetUseAdjacentStartPoint = "UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint";
    public const string MONO_GetPoints_2 = "UnityEngine.EdgeCollider2D::GetPoints";
    public const string MONO_Reset = "UnityEngine.EdgeCollider2D::Reset";
    public const string MONO_SetAdjacentEndPointInjected = "UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected";
    public const string MONO_SetAdjacentStartPointInjected = "UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected";
    public const string MONO_SetEdgeRadius = "UnityEngine.EdgeCollider2D::set_edgeRadius";
    public const string MONO_SetPoints = "UnityEngine.EdgeCollider2D::set_points";
    public const string MONO_SetUseAdjacentEndPoint = "UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint";
    public const string MONO_SetUseAdjacentStartPoint = "UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint";
    public const string MONO_SetPoints_2 = "UnityEngine.EdgeCollider2D::SetPoints";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_EdgeCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_EdgeCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_EdgeCollider2D(nint ptr) => new Ptr_UnityEngine_EdgeCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_EdgeCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_EdgeCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_adjacentEndPoint_Injected = "UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_adjacentStartPoint_Injected = "UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_edgeCount = "UnityEngine.EdgeCollider2D::get_edgeCount()";
    public const string IL2CPP_get_edgeRadius = "UnityEngine.EdgeCollider2D::get_edgeRadius()";
    public const string IL2CPP_get_pointCount = "UnityEngine.EdgeCollider2D::get_pointCount()";
    public const string IL2CPP_get_points = "UnityEngine.EdgeCollider2D::get_points()";
    public const string IL2CPP_get_useAdjacentEndPoint = "UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint()";
    public const string IL2CPP_get_useAdjacentStartPoint = "UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint()";
    public const string IL2CPP_GetPoints = "UnityEngine.EdgeCollider2D::GetPoints(System.Collections.Generic.List`1<UnityEngine.Vector2>)";
    public const string IL2CPP_Reset = "UnityEngine.EdgeCollider2D::Reset()";
    public const string IL2CPP_set_adjacentEndPoint_Injected = "UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_adjacentStartPoint_Injected = "UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_edgeRadius = "UnityEngine.EdgeCollider2D::set_edgeRadius(System.Single)";
    public const string IL2CPP_set_points = "UnityEngine.EdgeCollider2D::set_points(UnityEngine.Vector2[])";
    public const string IL2CPP_set_useAdjacentEndPoint = "UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint(System.Boolean)";
    public const string IL2CPP_set_useAdjacentStartPoint = "UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint(System.Boolean)";
    public const string IL2CPP_SetPoints = "UnityEngine.EdgeCollider2D::SetPoints(System.Collections.Generic.List`1<UnityEngine.Vector2>)";
}

