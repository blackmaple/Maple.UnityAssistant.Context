namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_MeshRenderer
{
    public const string MONO_GetAdditionalVertexStreams = "UnityEngine.MeshRenderer::get_additionalVertexStreams";
    public const string MONO_GetEnlightenVertexStream = "UnityEngine.MeshRenderer::get_enlightenVertexStream";
    public const string MONO_GetSubMeshStartIndex = "UnityEngine.MeshRenderer::get_subMeshStartIndex";
    public const string MONO_SetAdditionalVertexStreams = "UnityEngine.MeshRenderer::set_additionalVertexStreams";
    public const string MONO_SetEnlightenVertexStream = "UnityEngine.MeshRenderer::set_enlightenVertexStream";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_MeshRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_MeshRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_MeshRenderer(nint ptr) => new Ptr_UnityEngine_MeshRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_MeshRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_MeshRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_additionalVertexStreams = "UnityEngine.MeshRenderer::get_additionalVertexStreams()";
    public const string IL2CPP_get_enlightenVertexStream = "UnityEngine.MeshRenderer::get_enlightenVertexStream()";
    public const string IL2CPP_get_subMeshStartIndex = "UnityEngine.MeshRenderer::get_subMeshStartIndex()";
    public const string IL2CPP_set_additionalVertexStreams = "UnityEngine.MeshRenderer::set_additionalVertexStreams(UnityEngine.Mesh)";
    public const string IL2CPP_set_enlightenVertexStream = "UnityEngine.MeshRenderer::set_enlightenVertexStream(UnityEngine.Mesh)";
}

