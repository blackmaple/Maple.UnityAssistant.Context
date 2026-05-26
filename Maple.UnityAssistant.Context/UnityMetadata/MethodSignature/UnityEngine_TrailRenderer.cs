namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TrailRenderer
{
    public const string MONO_AddPositionInjected = "UnityEngine.TrailRenderer::AddPosition_Injected";
    public const string MONO_AddPositions = "UnityEngine.TrailRenderer::AddPositions";
    public const string MONO_AddPositionsWithNativeContainer = "UnityEngine.TrailRenderer::AddPositionsWithNativeContainer";
    public const string MONO_BakeMesh = "UnityEngine.TrailRenderer::BakeMesh";
    public const string MONO_Clear = "UnityEngine.TrailRenderer::Clear";
    public const string MONO_GetAlignment = "UnityEngine.TrailRenderer::get_alignment";
    public const string MONO_GetAutodestruct = "UnityEngine.TrailRenderer::get_autodestruct";
    public const string MONO_GetEmitting = "UnityEngine.TrailRenderer::get_emitting";
    public const string MONO_GetEndColorInjected = "UnityEngine.TrailRenderer::get_endColor_Injected";
    public const string MONO_GetEndWidth = "UnityEngine.TrailRenderer::get_endWidth";
    public const string MONO_GetGenerateLightingData = "UnityEngine.TrailRenderer::get_generateLightingData";
    public const string MONO_GetMinVertexDistance = "UnityEngine.TrailRenderer::get_minVertexDistance";
    public const string MONO_GetNumCapVertices = "UnityEngine.TrailRenderer::get_numCapVertices";
    public const string MONO_GetNumCornerVertices = "UnityEngine.TrailRenderer::get_numCornerVertices";
    public const string MONO_GetPositionCount = "UnityEngine.TrailRenderer::get_positionCount";
    public const string MONO_GetShadowBias = "UnityEngine.TrailRenderer::get_shadowBias";
    public const string MONO_GetStartColorInjected = "UnityEngine.TrailRenderer::get_startColor_Injected";
    public const string MONO_GetStartWidth = "UnityEngine.TrailRenderer::get_startWidth";
    public const string MONO_GetTextureMode = "UnityEngine.TrailRenderer::get_textureMode";
    public const string MONO_GetTime = "UnityEngine.TrailRenderer::get_time";
    public const string MONO_GetWidthMultiplier = "UnityEngine.TrailRenderer::get_widthMultiplier";
    public const string MONO_GetColorGradientCopy = "UnityEngine.TrailRenderer::GetColorGradientCopy";
    public const string MONO_GetPositionInjected = "UnityEngine.TrailRenderer::GetPosition_Injected";
    public const string MONO_GetPositions = "UnityEngine.TrailRenderer::GetPositions";
    public const string MONO_GetPositionsWithNativeContainer = "UnityEngine.TrailRenderer::GetPositionsWithNativeContainer";
    public const string MONO_GetWidthCurveCopy = "UnityEngine.TrailRenderer::GetWidthCurveCopy";
    public const string MONO_SetAlignment = "UnityEngine.TrailRenderer::set_alignment";
    public const string MONO_SetAutodestruct = "UnityEngine.TrailRenderer::set_autodestruct";
    public const string MONO_SetEmitting = "UnityEngine.TrailRenderer::set_emitting";
    public const string MONO_SetEndColorInjected = "UnityEngine.TrailRenderer::set_endColor_Injected";
    public const string MONO_SetEndWidth = "UnityEngine.TrailRenderer::set_endWidth";
    public const string MONO_SetGenerateLightingData = "UnityEngine.TrailRenderer::set_generateLightingData";
    public const string MONO_SetMinVertexDistance = "UnityEngine.TrailRenderer::set_minVertexDistance";
    public const string MONO_SetNumCapVertices = "UnityEngine.TrailRenderer::set_numCapVertices";
    public const string MONO_SetNumCornerVertices = "UnityEngine.TrailRenderer::set_numCornerVertices";
    public const string MONO_SetShadowBias = "UnityEngine.TrailRenderer::set_shadowBias";
    public const string MONO_SetStartColorInjected = "UnityEngine.TrailRenderer::set_startColor_Injected";
    public const string MONO_SetStartWidth = "UnityEngine.TrailRenderer::set_startWidth";
    public const string MONO_SetTextureMode = "UnityEngine.TrailRenderer::set_textureMode";
    public const string MONO_SetTime = "UnityEngine.TrailRenderer::set_time";
    public const string MONO_SetWidthMultiplier = "UnityEngine.TrailRenderer::set_widthMultiplier";
    public const string MONO_SetColorGradient = "UnityEngine.TrailRenderer::SetColorGradient";
    public const string MONO_SetPositionInjected = "UnityEngine.TrailRenderer::SetPosition_Injected";
    public const string MONO_SetPositions = "UnityEngine.TrailRenderer::SetPositions";
    public const string MONO_SetPositionsWithNativeContainer = "UnityEngine.TrailRenderer::SetPositionsWithNativeContainer";
    public const string MONO_SetWidthCurve = "UnityEngine.TrailRenderer::SetWidthCurve";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TrailRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TrailRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TrailRenderer(nint ptr) => new Ptr_UnityEngine_TrailRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TrailRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TrailRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Clear = "UnityEngine.TrailRenderer::Clear()";
    public const string IL2CPP_get_endWidth = "UnityEngine.TrailRenderer::get_endWidth()";
    public const string IL2CPP_get_startWidth = "UnityEngine.TrailRenderer::get_startWidth()";
    public const string IL2CPP_get_time = "UnityEngine.TrailRenderer::get_time()";
    public const string IL2CPP_set_endWidth = "UnityEngine.TrailRenderer::set_endWidth(System.Single)";
    public const string IL2CPP_set_startWidth = "UnityEngine.TrailRenderer::set_startWidth(System.Single)";
    public const string IL2CPP_set_time = "UnityEngine.TrailRenderer::set_time(System.Single)";
}

