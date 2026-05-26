namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_BoxCollider2D
{
    public const string MONO_GetAutoTiling = "UnityEngine.BoxCollider2D::get_autoTiling";
    public const string MONO_GetEdgeRadius = "UnityEngine.BoxCollider2D::get_edgeRadius";
    public const string MONO_GetSizeInjected = "UnityEngine.BoxCollider2D::get_size_Injected";
    public const string MONO_SetAutoTiling = "UnityEngine.BoxCollider2D::set_autoTiling";
    public const string MONO_SetEdgeRadius = "UnityEngine.BoxCollider2D::set_edgeRadius";
    public const string MONO_SetSizeInjected = "UnityEngine.BoxCollider2D::set_size_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_BoxCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_BoxCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_BoxCollider2D(nint ptr) => new Ptr_UnityEngine_BoxCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_BoxCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_BoxCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_autoTiling = "UnityEngine.BoxCollider2D::get_autoTiling()";
    public const string IL2CPP_get_edgeRadius = "UnityEngine.BoxCollider2D::get_edgeRadius()";
    public const string IL2CPP_get_size_Injected = "UnityEngine.BoxCollider2D::get_size_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_autoTiling = "UnityEngine.BoxCollider2D::set_autoTiling(System.Boolean)";
    public const string IL2CPP_set_edgeRadius = "UnityEngine.BoxCollider2D::set_edgeRadius(System.Single)";
    public const string IL2CPP_set_size_Injected = "UnityEngine.BoxCollider2D::set_size_Injected(UnityEngine.Vector2&)";
}

