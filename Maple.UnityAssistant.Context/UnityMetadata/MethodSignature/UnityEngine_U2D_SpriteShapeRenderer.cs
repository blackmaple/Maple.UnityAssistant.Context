namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_U2D_SpriteShapeRenderer
{
    public const string MONO_GetColorInjected = "UnityEngine.U2D.SpriteShapeRenderer::get_color_Injected";
    public const string MONO_GetMaskInteraction = "UnityEngine.U2D.SpriteShapeRenderer::get_maskInteraction";
    public const string MONO_GetChannelInfoInjected = "UnityEngine.U2D.SpriteShapeRenderer::GetChannelInfo_Injected";
    public const string MONO_GetDataInfoInjected = "UnityEngine.U2D.SpriteShapeRenderer::GetDataInfo_Injected";
    public const string MONO_PrepareInjected = "UnityEngine.U2D.SpriteShapeRenderer::Prepare_Injected";
    public const string MONO_SetColorInjected = "UnityEngine.U2D.SpriteShapeRenderer::set_color_Injected";
    public const string MONO_SetMaskInteraction = "UnityEngine.U2D.SpriteShapeRenderer::set_maskInteraction";
    public const string MONO_SetLocalAabbInjected = "UnityEngine.U2D.SpriteShapeRenderer::SetLocalAABB_Injected";
    public const string MONO_SetMeshChannelInfo = "UnityEngine.U2D.SpriteShapeRenderer::SetMeshChannelInfo";
    public const string MONO_SetMeshDataCount = "UnityEngine.U2D.SpriteShapeRenderer::SetMeshDataCount";
    public const string MONO_SetSegmentCount = "UnityEngine.U2D.SpriteShapeRenderer::SetSegmentCount";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_U2D_SpriteShapeRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_U2D_SpriteShapeRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_U2D_SpriteShapeRenderer(nint ptr) => new Ptr_UnityEngine_U2D_SpriteShapeRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_U2D_SpriteShapeRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_U2D_SpriteShapeRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
