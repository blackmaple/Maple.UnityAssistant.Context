namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_MeshFilter
{
    public const string MONO_GetMesh = "UnityEngine.MeshFilter::get_mesh";
    public const string MONO_GetSharedMesh = "UnityEngine.MeshFilter::get_sharedMesh";
    public const string MONO_SetMesh = "UnityEngine.MeshFilter::set_mesh";
    public const string MONO_SetSharedMesh = "UnityEngine.MeshFilter::set_sharedMesh";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_MeshFilter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_MeshFilter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_MeshFilter(nint ptr) => new Ptr_UnityEngine_MeshFilter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_MeshFilter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_MeshFilter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_sharedMesh = "UnityEngine.MeshFilter::get_sharedMesh()";
    public const string IL2CPP_set_mesh = "UnityEngine.MeshFilter::set_mesh(UnityEngine.Mesh)";
    public const string IL2CPP_set_sharedMesh = "UnityEngine.MeshFilter::set_sharedMesh(UnityEngine.Mesh)";
}

