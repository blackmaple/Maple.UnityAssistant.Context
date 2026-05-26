namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PolygonCollider2D
{
    public const string MONO_CreatePrimitiveInternalInjected = "UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected";
    public const string MONO_GetAutoTiling = "UnityEngine.PolygonCollider2D::get_autoTiling";
    public const string MONO_GetPathCount = "UnityEngine.PolygonCollider2D::get_pathCount";
    public const string MONO_GetPoints = "UnityEngine.PolygonCollider2D::get_points";
    public const string MONO_GetPathInternal = "UnityEngine.PolygonCollider2D::GetPath_Internal";
    public const string MONO_GetPathListInternal = "UnityEngine.PolygonCollider2D::GetPathList_Internal";
    public const string MONO_GetTotalPointCount = "UnityEngine.PolygonCollider2D::GetTotalPointCount";
    public const string MONO_SetAutoTiling = "UnityEngine.PolygonCollider2D::set_autoTiling";
    public const string MONO_SetPathCount = "UnityEngine.PolygonCollider2D::set_pathCount";
    public const string MONO_SetPoints = "UnityEngine.PolygonCollider2D::set_points";
    public const string MONO_SetPathInternal = "UnityEngine.PolygonCollider2D::SetPath_Internal";
    public const string MONO_SetPathListInternal = "UnityEngine.PolygonCollider2D::SetPathList_Internal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PolygonCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PolygonCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PolygonCollider2D(nint ptr) => new Ptr_UnityEngine_PolygonCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PolygonCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PolygonCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreatePrimitive_Internal_Injected = "UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected(System.Int32,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Boolean)";
    public const string IL2CPP_get_autoTiling = "UnityEngine.PolygonCollider2D::get_autoTiling()";
    public const string IL2CPP_get_pathCount = "UnityEngine.PolygonCollider2D::get_pathCount()";
    public const string IL2CPP_get_points = "UnityEngine.PolygonCollider2D::get_points()";
    public const string IL2CPP_GetPath_Internal = "UnityEngine.PolygonCollider2D::GetPath_Internal(System.Int32)";
    public const string IL2CPP_GetPathList_Internal = "UnityEngine.PolygonCollider2D::GetPathList_Internal(System.Int32,System.Collections.Generic.List`1<UnityEngine.Vector2>)";
    public const string IL2CPP_GetTotalPointCount = "UnityEngine.PolygonCollider2D::GetTotalPointCount()";
    public const string IL2CPP_set_autoTiling = "UnityEngine.PolygonCollider2D::set_autoTiling(System.Boolean)";
    public const string IL2CPP_set_pathCount = "UnityEngine.PolygonCollider2D::set_pathCount(System.Int32)";
    public const string IL2CPP_set_points = "UnityEngine.PolygonCollider2D::set_points(UnityEngine.Vector2[])";
    public const string IL2CPP_SetPath_Internal = "UnityEngine.PolygonCollider2D::SetPath_Internal(System.Int32,UnityEngine.Vector2[])";
    public const string IL2CPP_SetPathList_Internal = "UnityEngine.PolygonCollider2D::SetPathList_Internal(System.Int32,System.Collections.Generic.List`1<UnityEngine.Vector2>)";
}

