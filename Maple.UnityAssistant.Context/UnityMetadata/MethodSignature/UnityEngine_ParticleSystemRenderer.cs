namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystemRenderer
{
    public const string MONO_BakeMesh = "UnityEngine.ParticleSystemRenderer::BakeMesh";
    public const string MONO_BakeTrailsMesh = "UnityEngine.ParticleSystemRenderer::BakeTrailsMesh";
    public const string MONO_GetActiveVertexStreamsCount = "UnityEngine.ParticleSystemRenderer::get_activeVertexStreamsCount";
    public const string MONO_GetAlignment = "UnityEngine.ParticleSystemRenderer::get_alignment";
    public const string MONO_GetAllowRoll = "UnityEngine.ParticleSystemRenderer::get_allowRoll";
    public const string MONO_GetCameraVelocityScale = "UnityEngine.ParticleSystemRenderer::get_cameraVelocityScale";
    public const string MONO_GetEnableGpuinstancing = "UnityEngine.ParticleSystemRenderer::get_enableGPUInstancing";
    public const string MONO_GetFlipInjected = "UnityEngine.ParticleSystemRenderer::get_flip_Injected";
    public const string MONO_GetFreeformStretching = "UnityEngine.ParticleSystemRenderer::get_freeformStretching";
    public const string MONO_GetLengthScale = "UnityEngine.ParticleSystemRenderer::get_lengthScale";
    public const string MONO_GetMaskInteraction = "UnityEngine.ParticleSystemRenderer::get_maskInteraction";
    public const string MONO_GetMaxParticleSize = "UnityEngine.ParticleSystemRenderer::get_maxParticleSize";
    public const string MONO_GetMesh = "UnityEngine.ParticleSystemRenderer::get_mesh";
    public const string MONO_GetMeshCount = "UnityEngine.ParticleSystemRenderer::get_meshCount";
    public const string MONO_GetMeshDistribution = "UnityEngine.ParticleSystemRenderer::get_meshDistribution";
    public const string MONO_GetMinParticleSize = "UnityEngine.ParticleSystemRenderer::get_minParticleSize";
    public const string MONO_GetNormalDirection = "UnityEngine.ParticleSystemRenderer::get_normalDirection";
    public const string MONO_GetPivotInjected = "UnityEngine.ParticleSystemRenderer::get_pivot_Injected";
    public const string MONO_GetRenderMode = "UnityEngine.ParticleSystemRenderer::get_renderMode";
    public const string MONO_GetRotateWithStretchDirection = "UnityEngine.ParticleSystemRenderer::get_rotateWithStretchDirection";
    public const string MONO_GetShadowBias = "UnityEngine.ParticleSystemRenderer::get_shadowBias";
    public const string MONO_GetSortingFudge = "UnityEngine.ParticleSystemRenderer::get_sortingFudge";
    public const string MONO_GetSortMode = "UnityEngine.ParticleSystemRenderer::get_sortMode";
    public const string MONO_GetTrailMaterial = "UnityEngine.ParticleSystemRenderer::get_trailMaterial";
    public const string MONO_GetVelocityScale = "UnityEngine.ParticleSystemRenderer::get_velocityScale";
    public const string MONO_GetActiveVertexStreams = "UnityEngine.ParticleSystemRenderer::GetActiveVertexStreams";
    public const string MONO_GetMeshes = "UnityEngine.ParticleSystemRenderer::GetMeshes";
    public const string MONO_GetMeshWeightings = "UnityEngine.ParticleSystemRenderer::GetMeshWeightings";
    public const string MONO_SetAlignment = "UnityEngine.ParticleSystemRenderer::set_alignment";
    public const string MONO_SetAllowRoll = "UnityEngine.ParticleSystemRenderer::set_allowRoll";
    public const string MONO_SetCameraVelocityScale = "UnityEngine.ParticleSystemRenderer::set_cameraVelocityScale";
    public const string MONO_SetEnableGpuinstancing = "UnityEngine.ParticleSystemRenderer::set_enableGPUInstancing";
    public const string MONO_SetFlipInjected = "UnityEngine.ParticleSystemRenderer::set_flip_Injected";
    public const string MONO_SetFreeformStretching = "UnityEngine.ParticleSystemRenderer::set_freeformStretching";
    public const string MONO_SetLengthScale = "UnityEngine.ParticleSystemRenderer::set_lengthScale";
    public const string MONO_SetMaskInteraction = "UnityEngine.ParticleSystemRenderer::set_maskInteraction";
    public const string MONO_SetMaxParticleSize = "UnityEngine.ParticleSystemRenderer::set_maxParticleSize";
    public const string MONO_SetMesh = "UnityEngine.ParticleSystemRenderer::set_mesh";
    public const string MONO_SetMeshDistribution = "UnityEngine.ParticleSystemRenderer::set_meshDistribution";
    public const string MONO_SetMinParticleSize = "UnityEngine.ParticleSystemRenderer::set_minParticleSize";
    public const string MONO_SetNormalDirection = "UnityEngine.ParticleSystemRenderer::set_normalDirection";
    public const string MONO_SetOldTrailMaterial = "UnityEngine.ParticleSystemRenderer::set_oldTrailMaterial";
    public const string MONO_SetPivotInjected = "UnityEngine.ParticleSystemRenderer::set_pivot_Injected";
    public const string MONO_SetRenderMode = "UnityEngine.ParticleSystemRenderer::set_renderMode";
    public const string MONO_SetRotateWithStretchDirection = "UnityEngine.ParticleSystemRenderer::set_rotateWithStretchDirection";
    public const string MONO_SetShadowBias = "UnityEngine.ParticleSystemRenderer::set_shadowBias";
    public const string MONO_SetSortingFudge = "UnityEngine.ParticleSystemRenderer::set_sortingFudge";
    public const string MONO_SetSortMode = "UnityEngine.ParticleSystemRenderer::set_sortMode";
    public const string MONO_SetTrailMaterial = "UnityEngine.ParticleSystemRenderer::set_trailMaterial";
    public const string MONO_SetVelocityScale = "UnityEngine.ParticleSystemRenderer::set_velocityScale";
    public const string MONO_SetActiveVertexStreams = "UnityEngine.ParticleSystemRenderer::SetActiveVertexStreams";
    public const string MONO_SetMeshes = "UnityEngine.ParticleSystemRenderer::SetMeshes";
    public const string MONO_SetMeshWeightings = "UnityEngine.ParticleSystemRenderer::SetMeshWeightings";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystemRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystemRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystemRenderer(nint ptr) => new Ptr_UnityEngine_ParticleSystemRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystemRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystemRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetMeshes = "UnityEngine.ParticleSystemRenderer::GetMeshes(UnityEngine.Mesh[])";
}

