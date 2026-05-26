namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SpriteRenderer
{
    public const string MONO_GetAdaptiveModeThreshold = "UnityEngine.SpriteRenderer::get_adaptiveModeThreshold";
    public const string MONO_GetColorInjected = "UnityEngine.SpriteRenderer::get_color_Injected";
    public const string MONO_GetDrawMode = "UnityEngine.SpriteRenderer::get_drawMode";
    public const string MONO_GetFlipX = "UnityEngine.SpriteRenderer::get_flipX";
    public const string MONO_GetFlipY = "UnityEngine.SpriteRenderer::get_flipY";
    public const string MONO_GetMaskInteraction = "UnityEngine.SpriteRenderer::get_maskInteraction";
    public const string MONO_GetShouldSupportTiling = "UnityEngine.SpriteRenderer::get_shouldSupportTiling";
    public const string MONO_GetSizeInjected = "UnityEngine.SpriteRenderer::get_size_Injected";
    public const string MONO_GetSprite = "UnityEngine.SpriteRenderer::get_sprite";
    public const string MONO_GetSpriteSortPoint = "UnityEngine.SpriteRenderer::get_spriteSortPoint";
    public const string MONO_GetTileMode = "UnityEngine.SpriteRenderer::get_tileMode";
    public const string MONO_InternalGetSpriteBoundsInjected = "UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected";
    public const string MONO_SetAdaptiveModeThreshold = "UnityEngine.SpriteRenderer::set_adaptiveModeThreshold";
    public const string MONO_SetColorInjected = "UnityEngine.SpriteRenderer::set_color_Injected";
    public const string MONO_SetDrawMode = "UnityEngine.SpriteRenderer::set_drawMode";
    public const string MONO_SetFlipX = "UnityEngine.SpriteRenderer::set_flipX";
    public const string MONO_SetFlipY = "UnityEngine.SpriteRenderer::set_flipY";
    public const string MONO_SetMaskInteraction = "UnityEngine.SpriteRenderer::set_maskInteraction";
    public const string MONO_SetSizeInjected = "UnityEngine.SpriteRenderer::set_size_Injected";
    public const string MONO_SetSprite = "UnityEngine.SpriteRenderer::set_sprite";
    public const string MONO_SetSpriteSortPoint = "UnityEngine.SpriteRenderer::set_spriteSortPoint";
    public const string MONO_SetTileMode = "UnityEngine.SpriteRenderer::set_tileMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SpriteRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SpriteRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SpriteRenderer(nint ptr) => new Ptr_UnityEngine_SpriteRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SpriteRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SpriteRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_adaptiveModeThreshold = "UnityEngine.SpriteRenderer::get_adaptiveModeThreshold()";
    public const string IL2CPP_get_color_Injected = "UnityEngine.SpriteRenderer::get_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_drawMode = "UnityEngine.SpriteRenderer::get_drawMode()";
    public const string IL2CPP_get_flipX = "UnityEngine.SpriteRenderer::get_flipX()";
    public const string IL2CPP_get_flipY = "UnityEngine.SpriteRenderer::get_flipY()";
    public const string IL2CPP_get_maskInteraction = "UnityEngine.SpriteRenderer::get_maskInteraction()";
    public const string IL2CPP_get_shouldSupportTiling = "UnityEngine.SpriteRenderer::get_shouldSupportTiling()";
    public const string IL2CPP_get_size_Injected = "UnityEngine.SpriteRenderer::get_size_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_sprite = "UnityEngine.SpriteRenderer::get_sprite()";
    public const string IL2CPP_get_spriteSortPoint = "UnityEngine.SpriteRenderer::get_spriteSortPoint()";
    public const string IL2CPP_get_tileMode = "UnityEngine.SpriteRenderer::get_tileMode()";
    public const string IL2CPP_Internal_GetSpriteBounds_Injected = "UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected(UnityEngine.SpriteDrawMode,UnityEngine.Bounds&)";
    public const string IL2CPP_set_adaptiveModeThreshold = "UnityEngine.SpriteRenderer::set_adaptiveModeThreshold(System.Single)";
    public const string IL2CPP_set_color_Injected = "UnityEngine.SpriteRenderer::set_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_drawMode = "UnityEngine.SpriteRenderer::set_drawMode(UnityEngine.SpriteDrawMode)";
    public const string IL2CPP_set_flipX = "UnityEngine.SpriteRenderer::set_flipX(System.Boolean)";
    public const string IL2CPP_set_flipY = "UnityEngine.SpriteRenderer::set_flipY(System.Boolean)";
    public const string IL2CPP_set_maskInteraction = "UnityEngine.SpriteRenderer::set_maskInteraction(UnityEngine.SpriteMaskInteraction)";
    public const string IL2CPP_set_size_Injected = "UnityEngine.SpriteRenderer::set_size_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_sprite = "UnityEngine.SpriteRenderer::set_sprite(UnityEngine.Sprite)";
    public const string IL2CPP_set_spriteSortPoint = "UnityEngine.SpriteRenderer::set_spriteSortPoint(UnityEngine.SpriteSortPoint)";
    public const string IL2CPP_set_tileMode = "UnityEngine.SpriteRenderer::set_tileMode(UnityEngine.SpriteTileMode)";
}

