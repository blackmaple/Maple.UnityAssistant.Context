namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LineRenderer
{
    public const string MONO_BakeMesh = "UnityEngine.LineRenderer::BakeMesh";
    public const string MONO_GetAlignment = "UnityEngine.LineRenderer::get_alignment";
    public const string MONO_GetEndColorInjected = "UnityEngine.LineRenderer::get_endColor_Injected";
    public const string MONO_GetEndWidth = "UnityEngine.LineRenderer::get_endWidth";
    public const string MONO_GetGenerateLightingData = "UnityEngine.LineRenderer::get_generateLightingData";
    public const string MONO_GetLoop = "UnityEngine.LineRenderer::get_loop";
    public const string MONO_GetNumCapVertices = "UnityEngine.LineRenderer::get_numCapVertices";
    public const string MONO_GetNumCornerVertices = "UnityEngine.LineRenderer::get_numCornerVertices";
    public const string MONO_GetPositionCount = "UnityEngine.LineRenderer::get_positionCount";
    public const string MONO_GetShadowBias = "UnityEngine.LineRenderer::get_shadowBias";
    public const string MONO_GetStartColorInjected = "UnityEngine.LineRenderer::get_startColor_Injected";
    public const string MONO_GetStartWidth = "UnityEngine.LineRenderer::get_startWidth";
    public const string MONO_GetTextureMode = "UnityEngine.LineRenderer::get_textureMode";
    public const string MONO_GetUseWorldSpace = "UnityEngine.LineRenderer::get_useWorldSpace";
    public const string MONO_GetWidthMultiplier = "UnityEngine.LineRenderer::get_widthMultiplier";
    public const string MONO_GetColorGradientCopy = "UnityEngine.LineRenderer::GetColorGradientCopy";
    public const string MONO_GetPositionInjected = "UnityEngine.LineRenderer::GetPosition_Injected";
    public const string MONO_GetPositions = "UnityEngine.LineRenderer::GetPositions";
    public const string MONO_GetPositionsWithNativeContainer = "UnityEngine.LineRenderer::GetPositionsWithNativeContainer";
    public const string MONO_GetWidthCurveCopy = "UnityEngine.LineRenderer::GetWidthCurveCopy";
    public const string MONO_SetAlignment = "UnityEngine.LineRenderer::set_alignment";
    public const string MONO_SetEndColorInjected = "UnityEngine.LineRenderer::set_endColor_Injected";
    public const string MONO_SetEndWidth = "UnityEngine.LineRenderer::set_endWidth";
    public const string MONO_SetGenerateLightingData = "UnityEngine.LineRenderer::set_generateLightingData";
    public const string MONO_SetLoop = "UnityEngine.LineRenderer::set_loop";
    public const string MONO_SetNumCapVertices = "UnityEngine.LineRenderer::set_numCapVertices";
    public const string MONO_SetNumCornerVertices = "UnityEngine.LineRenderer::set_numCornerVertices";
    public const string MONO_SetPositionCount = "UnityEngine.LineRenderer::set_positionCount";
    public const string MONO_SetShadowBias = "UnityEngine.LineRenderer::set_shadowBias";
    public const string MONO_SetStartColorInjected = "UnityEngine.LineRenderer::set_startColor_Injected";
    public const string MONO_SetStartWidth = "UnityEngine.LineRenderer::set_startWidth";
    public const string MONO_SetTextureMode = "UnityEngine.LineRenderer::set_textureMode";
    public const string MONO_SetUseWorldSpace = "UnityEngine.LineRenderer::set_useWorldSpace";
    public const string MONO_SetWidthMultiplier = "UnityEngine.LineRenderer::set_widthMultiplier";
    public const string MONO_SetColorGradient = "UnityEngine.LineRenderer::SetColorGradient";
    public const string MONO_SetPositionInjected = "UnityEngine.LineRenderer::SetPosition_Injected";
    public const string MONO_SetPositions = "UnityEngine.LineRenderer::SetPositions";
    public const string MONO_SetPositionsWithNativeContainer = "UnityEngine.LineRenderer::SetPositionsWithNativeContainer";
    public const string MONO_SetWidthCurve = "UnityEngine.LineRenderer::SetWidthCurve";
    public const string MONO_Simplify = "UnityEngine.LineRenderer::Simplify";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LineRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LineRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LineRenderer(nint ptr) => new Ptr_UnityEngine_LineRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LineRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LineRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_set_endColor_Injected = "UnityEngine.LineRenderer::set_endColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_startColor_Injected = "UnityEngine.LineRenderer::set_startColor_Injected(UnityEngine.Color&)";
}

