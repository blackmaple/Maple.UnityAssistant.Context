namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_MeshCollider
{
    public const string MONO_GetConvex = "UnityEngine.MeshCollider::get_convex";
    public const string MONO_GetCookingOptions = "UnityEngine.MeshCollider::get_cookingOptions";
    public const string MONO_GetSharedMesh = "UnityEngine.MeshCollider::get_sharedMesh";
    public const string MONO_SetConvex = "UnityEngine.MeshCollider::set_convex";
    public const string MONO_SetCookingOptions = "UnityEngine.MeshCollider::set_cookingOptions";
    public const string MONO_SetSharedMesh = "UnityEngine.MeshCollider::set_sharedMesh";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_MeshCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_MeshCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_MeshCollider(nint ptr) => new Ptr_UnityEngine_MeshCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_MeshCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_MeshCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_convex = "UnityEngine.MeshCollider::get_convex()";
    public const string IL2CPP_get_sharedMesh = "UnityEngine.MeshCollider::get_sharedMesh()";
    public const string IL2CPP_set_convex = "UnityEngine.MeshCollider::set_convex(System.Boolean)";
    public const string IL2CPP_set_sharedMesh = "UnityEngine.MeshCollider::set_sharedMesh(UnityEngine.Mesh)";
}

