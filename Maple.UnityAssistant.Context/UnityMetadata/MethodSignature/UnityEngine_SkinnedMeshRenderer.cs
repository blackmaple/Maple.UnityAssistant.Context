namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SkinnedMeshRenderer
{
    public const string MONO_BakeMesh = "UnityEngine.SkinnedMeshRenderer::BakeMesh";
    public const string MONO_GetBones = "UnityEngine.SkinnedMeshRenderer::get_bones";
    public const string MONO_GetForceMatrixRecalculationPerRender = "UnityEngine.SkinnedMeshRenderer::get_forceMatrixRecalculationPerRender";
    public const string MONO_GetQuality = "UnityEngine.SkinnedMeshRenderer::get_quality";
    public const string MONO_GetRootBone = "UnityEngine.SkinnedMeshRenderer::get_rootBone";
    public const string MONO_GetSharedMesh = "UnityEngine.SkinnedMeshRenderer::get_sharedMesh";
    public const string MONO_GetSkinnedMotionVectors = "UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors";
    public const string MONO_GetUpdateWhenOffscreen = "UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen";
    public const string MONO_GetVertexBufferTarget = "UnityEngine.SkinnedMeshRenderer::get_vertexBufferTarget";
    public const string MONO_GetBlendShapeWeight = "UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight";
    public const string MONO_GetPreviousVertexBufferImpl = "UnityEngine.SkinnedMeshRenderer::GetPreviousVertexBufferImpl";
    public const string MONO_GetVertexBufferImpl = "UnityEngine.SkinnedMeshRenderer::GetVertexBufferImpl";
    public const string MONO_SetBones = "UnityEngine.SkinnedMeshRenderer::set_bones";
    public const string MONO_SetForceMatrixRecalculationPerRender = "UnityEngine.SkinnedMeshRenderer::set_forceMatrixRecalculationPerRender";
    public const string MONO_SetQuality = "UnityEngine.SkinnedMeshRenderer::set_quality";
    public const string MONO_SetRootBone = "UnityEngine.SkinnedMeshRenderer::set_rootBone";
    public const string MONO_SetSharedMesh = "UnityEngine.SkinnedMeshRenderer::set_sharedMesh";
    public const string MONO_SetSkinnedMotionVectors = "UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors";
    public const string MONO_SetUpdateWhenOffscreen = "UnityEngine.SkinnedMeshRenderer::set_updateWhenOffscreen";
    public const string MONO_SetVertexBufferTarget = "UnityEngine.SkinnedMeshRenderer::set_vertexBufferTarget";
    public const string MONO_SetBlendShapeWeight = "UnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SkinnedMeshRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SkinnedMeshRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SkinnedMeshRenderer(nint ptr) => new Ptr_UnityEngine_SkinnedMeshRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SkinnedMeshRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SkinnedMeshRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_bones = "UnityEngine.SkinnedMeshRenderer::get_bones()";
    public const string IL2CPP_get_quality = "UnityEngine.SkinnedMeshRenderer::get_quality()";
    public const string IL2CPP_get_rootBone = "UnityEngine.SkinnedMeshRenderer::get_rootBone()";
    public const string IL2CPP_get_sharedMesh = "UnityEngine.SkinnedMeshRenderer::get_sharedMesh()";
    public const string IL2CPP_get_skinnedMotionVectors = "UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors()";
    public const string IL2CPP_get_updateWhenOffscreen = "UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen()";
    public const string IL2CPP_GetBlendShapeWeight = "UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight(System.Int32)";
    public const string IL2CPP_set_bones = "UnityEngine.SkinnedMeshRenderer::set_bones(UnityEngine.Transform[])";
    public const string IL2CPP_set_quality = "UnityEngine.SkinnedMeshRenderer::set_quality(UnityEngine.SkinQuality)";
    public const string IL2CPP_set_rootBone = "UnityEngine.SkinnedMeshRenderer::set_rootBone(UnityEngine.Transform)";
    public const string IL2CPP_set_sharedMesh = "UnityEngine.SkinnedMeshRenderer::set_sharedMesh(UnityEngine.Mesh)";
    public const string IL2CPP_set_skinnedMotionVectors = "UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors(System.Boolean)";
    public const string IL2CPP_set_updateWhenOffscreen = "UnityEngine.SkinnedMeshRenderer::set_updateWhenOffscreen(System.Boolean)";
    public const string IL2CPP_SetBlendShapeWeight = "UnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight(System.Int32,System.Single)";
}

