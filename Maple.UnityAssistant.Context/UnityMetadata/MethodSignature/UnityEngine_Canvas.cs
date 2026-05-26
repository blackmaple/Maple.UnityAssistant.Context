namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Canvas
{
    public const string MONO_GetAdditionalShaderChannels = "UnityEngine.Canvas::get_additionalShaderChannels";
    public const string MONO_GetCachedSortingLayerValue = "UnityEngine.Canvas::get_cachedSortingLayerValue";
    public const string MONO_GetIsRootCanvas = "UnityEngine.Canvas::get_isRootCanvas";
    public const string MONO_GetNormalizedSortingGridSize = "UnityEngine.Canvas::get_normalizedSortingGridSize";
    public const string MONO_GetOverridePixelPerfect = "UnityEngine.Canvas::get_overridePixelPerfect";
    public const string MONO_GetOverrideSorting = "UnityEngine.Canvas::get_overrideSorting";
    public const string MONO_GetPixelPerfect = "UnityEngine.Canvas::get_pixelPerfect";
    public const string MONO_GetPixelRectInjected = "UnityEngine.Canvas::get_pixelRect_Injected";
    public const string MONO_GetPlaneDistance = "UnityEngine.Canvas::get_planeDistance";
    public const string MONO_GetReferencePixelsPerUnit = "UnityEngine.Canvas::get_referencePixelsPerUnit";
    public const string MONO_GetRenderingDisplaySizeInjected = "UnityEngine.Canvas::get_renderingDisplaySize_Injected";
    public const string MONO_GetRenderMode = "UnityEngine.Canvas::get_renderMode";
    public const string MONO_GetRenderOrder = "UnityEngine.Canvas::get_renderOrder";
    public const string MONO_GetRootCanvas = "UnityEngine.Canvas::get_rootCanvas";
    public const string MONO_GetScaleFactor = "UnityEngine.Canvas::get_scaleFactor";
    public const string MONO_GetSortingGridNormalizedSize = "UnityEngine.Canvas::get_sortingGridNormalizedSize";
    public const string MONO_GetSortingLayerId = "UnityEngine.Canvas::get_sortingLayerID";
    public const string MONO_GetSortingLayerName = "UnityEngine.Canvas::get_sortingLayerName";
    public const string MONO_GetSortingOrder = "UnityEngine.Canvas::get_sortingOrder";
    public const string MONO_GetTargetDisplay = "UnityEngine.Canvas::get_targetDisplay";
    public const string MONO_GetWorldCamera = "UnityEngine.Canvas::get_worldCamera";
    public const string MONO_GetDefaultCanvasMaterial = "UnityEngine.Canvas::GetDefaultCanvasMaterial";
    public const string MONO_GetDefaultCanvasTextMaterial = "UnityEngine.Canvas::GetDefaultCanvasTextMaterial";
    public const string MONO_GetEtc1SupportedCanvasMaterial = "UnityEngine.Canvas::GetETC1SupportedCanvasMaterial";
    public const string MONO_SetAdditionalShaderChannels = "UnityEngine.Canvas::set_additionalShaderChannels";
    public const string MONO_SetNormalizedSortingGridSize = "UnityEngine.Canvas::set_normalizedSortingGridSize";
    public const string MONO_SetOverridePixelPerfect = "UnityEngine.Canvas::set_overridePixelPerfect";
    public const string MONO_SetOverrideSorting = "UnityEngine.Canvas::set_overrideSorting";
    public const string MONO_SetPixelPerfect = "UnityEngine.Canvas::set_pixelPerfect";
    public const string MONO_SetPlaneDistance = "UnityEngine.Canvas::set_planeDistance";
    public const string MONO_SetReferencePixelsPerUnit = "UnityEngine.Canvas::set_referencePixelsPerUnit";
    public const string MONO_SetRenderMode = "UnityEngine.Canvas::set_renderMode";
    public const string MONO_SetScaleFactor = "UnityEngine.Canvas::set_scaleFactor";
    public const string MONO_SetSortingGridNormalizedSize = "UnityEngine.Canvas::set_sortingGridNormalizedSize";
    public const string MONO_SetSortingLayerId = "UnityEngine.Canvas::set_sortingLayerID";
    public const string MONO_SetSortingLayerName = "UnityEngine.Canvas::set_sortingLayerName";
    public const string MONO_SetSortingOrder = "UnityEngine.Canvas::set_sortingOrder";
    public const string MONO_SetTargetDisplay = "UnityEngine.Canvas::set_targetDisplay";
    public const string MONO_SetWorldCamera = "UnityEngine.Canvas::set_worldCamera";
    public const string MONO_SetExternalCanvasEnabled = "UnityEngine.Canvas::SetExternalCanvasEnabled";
    public const string MONO_UpdateCanvasRectTransform = "UnityEngine.Canvas::UpdateCanvasRectTransform";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Canvas : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Canvas(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Canvas(nint ptr) => new Ptr_UnityEngine_Canvas(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Canvas ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Canvas ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_additionalShaderChannels = "UnityEngine.Canvas::get_additionalShaderChannels()";
    public const string IL2CPP_get_cachedSortingLayerValue = "UnityEngine.Canvas::get_cachedSortingLayerValue()";
    public const string IL2CPP_get_isRootCanvas = "UnityEngine.Canvas::get_isRootCanvas()";
    public const string IL2CPP_get_normalizedSortingGridSize = "UnityEngine.Canvas::get_normalizedSortingGridSize()";
    public const string IL2CPP_get_overridePixelPerfect = "UnityEngine.Canvas::get_overridePixelPerfect()";
    public const string IL2CPP_get_overrideSorting = "UnityEngine.Canvas::get_overrideSorting()";
    public const string IL2CPP_get_pixelPerfect = "UnityEngine.Canvas::get_pixelPerfect()";
    public const string IL2CPP_get_pixelRect_Injected = "UnityEngine.Canvas::get_pixelRect_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_get_planeDistance = "UnityEngine.Canvas::get_planeDistance()";
    public const string IL2CPP_get_referencePixelsPerUnit = "UnityEngine.Canvas::get_referencePixelsPerUnit()";
    public const string IL2CPP_get_renderingDisplaySize_Injected = "UnityEngine.Canvas::get_renderingDisplaySize_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_renderMode = "UnityEngine.Canvas::get_renderMode()";
    public const string IL2CPP_get_renderOrder = "UnityEngine.Canvas::get_renderOrder()";
    public const string IL2CPP_get_rootCanvas = "UnityEngine.Canvas::get_rootCanvas()";
    public const string IL2CPP_get_scaleFactor = "UnityEngine.Canvas::get_scaleFactor()";
    public const string IL2CPP_get_sortingGridNormalizedSize = "UnityEngine.Canvas::get_sortingGridNormalizedSize()";
    public const string IL2CPP_get_sortingLayerID = "UnityEngine.Canvas::get_sortingLayerID()";
    public const string IL2CPP_get_sortingLayerName = "UnityEngine.Canvas::get_sortingLayerName()";
    public const string IL2CPP_get_sortingOrder = "UnityEngine.Canvas::get_sortingOrder()";
    public const string IL2CPP_get_targetDisplay = "UnityEngine.Canvas::get_targetDisplay()";
    public const string IL2CPP_get_worldCamera = "UnityEngine.Canvas::get_worldCamera()";
    public const string IL2CPP_GetDefaultCanvasMaterial = "UnityEngine.Canvas::GetDefaultCanvasMaterial()";
    public const string IL2CPP_GetDefaultCanvasTextMaterial = "UnityEngine.Canvas::GetDefaultCanvasTextMaterial()";
    public const string IL2CPP_GetETC1SupportedCanvasMaterial = "UnityEngine.Canvas::GetETC1SupportedCanvasMaterial()";
    public const string IL2CPP_set_additionalShaderChannels = "UnityEngine.Canvas::set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels)";
    public const string IL2CPP_set_normalizedSortingGridSize = "UnityEngine.Canvas::set_normalizedSortingGridSize(System.Single)";
    public const string IL2CPP_set_overridePixelPerfect = "UnityEngine.Canvas::set_overridePixelPerfect(System.Boolean)";
    public const string IL2CPP_set_overrideSorting = "UnityEngine.Canvas::set_overrideSorting(System.Boolean)";
    public const string IL2CPP_set_pixelPerfect = "UnityEngine.Canvas::set_pixelPerfect(System.Boolean)";
    public const string IL2CPP_set_planeDistance = "UnityEngine.Canvas::set_planeDistance(System.Single)";
    public const string IL2CPP_set_referencePixelsPerUnit = "UnityEngine.Canvas::set_referencePixelsPerUnit(System.Single)";
    public const string IL2CPP_set_renderMode = "UnityEngine.Canvas::set_renderMode(UnityEngine.RenderMode)";
    public const string IL2CPP_set_scaleFactor = "UnityEngine.Canvas::set_scaleFactor(System.Single)";
    public const string IL2CPP_set_sortingGridNormalizedSize = "UnityEngine.Canvas::set_sortingGridNormalizedSize(System.Int32)";
    public const string IL2CPP_set_sortingLayerID = "UnityEngine.Canvas::set_sortingLayerID(System.Int32)";
    public const string IL2CPP_set_sortingLayerName = "UnityEngine.Canvas::set_sortingLayerName(System.String)";
    public const string IL2CPP_set_sortingOrder = "UnityEngine.Canvas::set_sortingOrder(System.Int32)";
    public const string IL2CPP_set_targetDisplay = "UnityEngine.Canvas::set_targetDisplay(System.Int32)";
    public const string IL2CPP_set_worldCamera = "UnityEngine.Canvas::set_worldCamera(UnityEngine.Camera)";
    public const string IL2CPP_SetExternalCanvasEnabled = "UnityEngine.Canvas::SetExternalCanvasEnabled(System.Boolean)";
    public const string IL2CPP_UpdateCanvasRectTransform = "UnityEngine.Canvas::UpdateCanvasRectTransform(System.Boolean)";
}

