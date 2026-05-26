namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Tilemaps_TilemapRenderer
{
    public const string MONO_GetChunkCullingBoundsInjected = "UnityEngine.Tilemaps.TilemapRenderer::get_chunkCullingBounds_Injected";
    public const string MONO_GetChunkSizeInjected = "UnityEngine.Tilemaps.TilemapRenderer::get_chunkSize_Injected";
    public const string MONO_GetDetectChunkCullingBounds = "UnityEngine.Tilemaps.TilemapRenderer::get_detectChunkCullingBounds";
    public const string MONO_GetMaskInteraction = "UnityEngine.Tilemaps.TilemapRenderer::get_maskInteraction";
    public const string MONO_GetMaxChunkCount = "UnityEngine.Tilemaps.TilemapRenderer::get_maxChunkCount";
    public const string MONO_GetMaxFrameAge = "UnityEngine.Tilemaps.TilemapRenderer::get_maxFrameAge";
    public const string MONO_GetMode = "UnityEngine.Tilemaps.TilemapRenderer::get_mode";
    public const string MONO_GetSortOrder = "UnityEngine.Tilemaps.TilemapRenderer::get_sortOrder";
    public const string MONO_OnSpriteAtlasRegistered = "UnityEngine.Tilemaps.TilemapRenderer::OnSpriteAtlasRegistered";
    public const string MONO_SetChunkCullingBoundsInjected = "UnityEngine.Tilemaps.TilemapRenderer::set_chunkCullingBounds_Injected";
    public const string MONO_SetChunkSizeInjected = "UnityEngine.Tilemaps.TilemapRenderer::set_chunkSize_Injected";
    public const string MONO_SetDetectChunkCullingBounds = "UnityEngine.Tilemaps.TilemapRenderer::set_detectChunkCullingBounds";
    public const string MONO_SetMaskInteraction = "UnityEngine.Tilemaps.TilemapRenderer::set_maskInteraction";
    public const string MONO_SetMaxChunkCount = "UnityEngine.Tilemaps.TilemapRenderer::set_maxChunkCount";
    public const string MONO_SetMaxFrameAge = "UnityEngine.Tilemaps.TilemapRenderer::set_maxFrameAge";
    public const string MONO_SetMode = "UnityEngine.Tilemaps.TilemapRenderer::set_mode";
    public const string MONO_SetSortOrder = "UnityEngine.Tilemaps.TilemapRenderer::set_sortOrder";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Tilemaps_TilemapRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Tilemaps_TilemapRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Tilemaps_TilemapRenderer(nint ptr) => new Ptr_UnityEngine_Tilemaps_TilemapRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Tilemaps_TilemapRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Tilemaps_TilemapRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_chunkCullingBounds_Injected = "UnityEngine.Tilemaps.TilemapRenderer::get_chunkCullingBounds_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_chunkSize_Injected = "UnityEngine.Tilemaps.TilemapRenderer::get_chunkSize_Injected(UnityEngine.Vector3Int&)";
    public const string IL2CPP_get_detectChunkCullingBounds = "UnityEngine.Tilemaps.TilemapRenderer::get_detectChunkCullingBounds()";
    public const string IL2CPP_get_maskInteraction = "UnityEngine.Tilemaps.TilemapRenderer::get_maskInteraction()";
    public const string IL2CPP_get_maxChunkCount = "UnityEngine.Tilemaps.TilemapRenderer::get_maxChunkCount()";
    public const string IL2CPP_get_maxFrameAge = "UnityEngine.Tilemaps.TilemapRenderer::get_maxFrameAge()";
    public const string IL2CPP_get_mode = "UnityEngine.Tilemaps.TilemapRenderer::get_mode()";
    public const string IL2CPP_get_sortOrder = "UnityEngine.Tilemaps.TilemapRenderer::get_sortOrder()";
    public const string IL2CPP_OnSpriteAtlasRegistered = "UnityEngine.Tilemaps.TilemapRenderer::OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas)";
    public const string IL2CPP_set_chunkCullingBounds_Injected = "UnityEngine.Tilemaps.TilemapRenderer::set_chunkCullingBounds_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_chunkSize_Injected = "UnityEngine.Tilemaps.TilemapRenderer::set_chunkSize_Injected(UnityEngine.Vector3Int&)";
    public const string IL2CPP_set_detectChunkCullingBounds = "UnityEngine.Tilemaps.TilemapRenderer::set_detectChunkCullingBounds(UnityEngine.Tilemaps.TilemapRenderer/DetectChunkCullingBounds)";
    public const string IL2CPP_set_maskInteraction = "UnityEngine.Tilemaps.TilemapRenderer::set_maskInteraction(UnityEngine.SpriteMaskInteraction)";
    public const string IL2CPP_set_maxChunkCount = "UnityEngine.Tilemaps.TilemapRenderer::set_maxChunkCount(System.Int32)";
    public const string IL2CPP_set_maxFrameAge = "UnityEngine.Tilemaps.TilemapRenderer::set_maxFrameAge(System.Int32)";
    public const string IL2CPP_set_mode = "UnityEngine.Tilemaps.TilemapRenderer::set_mode(UnityEngine.Tilemaps.TilemapRenderer/Mode)";
    public const string IL2CPP_set_sortOrder = "UnityEngine.Tilemaps.TilemapRenderer::set_sortOrder(UnityEngine.Tilemaps.TilemapRenderer/SortOrder)";
}

