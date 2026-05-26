namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CanvasRenderer
{
    public const string MONO_Clear = "UnityEngine.CanvasRenderer::Clear";
    public const string MONO_CreateUivertexStreamInternal = "UnityEngine.CanvasRenderer::CreateUIVertexStreamInternal";
    public const string MONO_DisableRectClipping = "UnityEngine.CanvasRenderer::DisableRectClipping";
    public const string MONO_EnableRectClippingInjected = "UnityEngine.CanvasRenderer::EnableRectClipping_Injected";
    public const string MONO_GetAbsoluteDepth = "UnityEngine.CanvasRenderer::get_absoluteDepth";
    public const string MONO_GetClippingSoftnessInjected = "UnityEngine.CanvasRenderer::get_clippingSoftness_Injected";
    public const string MONO_GetCull = "UnityEngine.CanvasRenderer::get_cull";
    public const string MONO_GetCullTransparentMesh = "UnityEngine.CanvasRenderer::get_cullTransparentMesh";
    public const string MONO_GetHasMoved = "UnityEngine.CanvasRenderer::get_hasMoved";
    public const string MONO_GetHasPopInstruction = "UnityEngine.CanvasRenderer::get_hasPopInstruction";
    public const string MONO_GetHasRectClipping = "UnityEngine.CanvasRenderer::get_hasRectClipping";
    public const string MONO_GetMaterialCount = "UnityEngine.CanvasRenderer::get_materialCount";
    public const string MONO_GetPopMaterialCount = "UnityEngine.CanvasRenderer::get_popMaterialCount";
    public const string MONO_GetRelativeDepth = "UnityEngine.CanvasRenderer::get_relativeDepth";
    public const string MONO_GetColorInjected = "UnityEngine.CanvasRenderer::GetColor_Injected";
    public const string MONO_GetInheritedAlpha = "UnityEngine.CanvasRenderer::GetInheritedAlpha";
    public const string MONO_GetMaterial = "UnityEngine.CanvasRenderer::GetMaterial";
    public const string MONO_GetPopMaterial = "UnityEngine.CanvasRenderer::GetPopMaterial";
    public const string MONO_SetClippingSoftnessInjected = "UnityEngine.CanvasRenderer::set_clippingSoftness_Injected";
    public const string MONO_SetCull = "UnityEngine.CanvasRenderer::set_cull";
    public const string MONO_SetCullTransparentMesh = "UnityEngine.CanvasRenderer::set_cullTransparentMesh";
    public const string MONO_SetHasPopInstruction = "UnityEngine.CanvasRenderer::set_hasPopInstruction";
    public const string MONO_SetMaterialCount = "UnityEngine.CanvasRenderer::set_materialCount";
    public const string MONO_SetPopMaterialCount = "UnityEngine.CanvasRenderer::set_popMaterialCount";
    public const string MONO_SetAlphaTexture = "UnityEngine.CanvasRenderer::SetAlphaTexture";
    public const string MONO_SetColorInjected = "UnityEngine.CanvasRenderer::SetColor_Injected";
    public const string MONO_SetMaterial = "UnityEngine.CanvasRenderer::SetMaterial";
    public const string MONO_SetMesh = "UnityEngine.CanvasRenderer::SetMesh";
    public const string MONO_SetPopMaterial = "UnityEngine.CanvasRenderer::SetPopMaterial";
    public const string MONO_SetTexture = "UnityEngine.CanvasRenderer::SetTexture";
    public const string MONO_SplitIndicesStreamsInternal = "UnityEngine.CanvasRenderer::SplitIndicesStreamsInternal";
    public const string MONO_SplitUivertexStreamsInternal = "UnityEngine.CanvasRenderer::SplitUIVertexStreamsInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CanvasRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CanvasRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CanvasRenderer(nint ptr) => new Ptr_UnityEngine_CanvasRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CanvasRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CanvasRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Clear = "UnityEngine.CanvasRenderer::Clear()";
    public const string IL2CPP_CreateUIVertexStreamInternal = "UnityEngine.CanvasRenderer::CreateUIVertexStreamInternal(System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object)";
    public const string IL2CPP_DisableRectClipping = "UnityEngine.CanvasRenderer::DisableRectClipping()";
    public const string IL2CPP_EnableRectClipping_Injected = "UnityEngine.CanvasRenderer::EnableRectClipping_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_get_absoluteDepth = "UnityEngine.CanvasRenderer::get_absoluteDepth()";
    public const string IL2CPP_get_cull = "UnityEngine.CanvasRenderer::get_cull()";
    public const string IL2CPP_get_cullTransparentMesh = "UnityEngine.CanvasRenderer::get_cullTransparentMesh()";
    public const string IL2CPP_get_hasMoved = "UnityEngine.CanvasRenderer::get_hasMoved()";
    public const string IL2CPP_get_materialCount = "UnityEngine.CanvasRenderer::get_materialCount()";
    public const string IL2CPP_GetColor_Injected = "UnityEngine.CanvasRenderer::GetColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_GetMaterial = "UnityEngine.CanvasRenderer::GetMaterial(System.Int32)";
    public const string IL2CPP_set_clippingSoftness_Injected = "UnityEngine.CanvasRenderer::set_clippingSoftness_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_cull = "UnityEngine.CanvasRenderer::set_cull(System.Boolean)";
    public const string IL2CPP_set_cullTransparentMesh = "UnityEngine.CanvasRenderer::set_cullTransparentMesh(System.Boolean)";
    public const string IL2CPP_set_hasPopInstruction = "UnityEngine.CanvasRenderer::set_hasPopInstruction(System.Boolean)";
    public const string IL2CPP_set_materialCount = "UnityEngine.CanvasRenderer::set_materialCount(System.Int32)";
    public const string IL2CPP_set_popMaterialCount = "UnityEngine.CanvasRenderer::set_popMaterialCount(System.Int32)";
    public const string IL2CPP_SetAlphaTexture = "UnityEngine.CanvasRenderer::SetAlphaTexture(UnityEngine.Texture)";
    public const string IL2CPP_SetColor_Injected = "UnityEngine.CanvasRenderer::SetColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_SetMaterial = "UnityEngine.CanvasRenderer::SetMaterial(UnityEngine.Material,System.Int32)";
    public const string IL2CPP_SetMesh = "UnityEngine.CanvasRenderer::SetMesh(UnityEngine.Mesh)";
    public const string IL2CPP_SetPopMaterial = "UnityEngine.CanvasRenderer::SetPopMaterial(UnityEngine.Material,System.Int32)";
    public const string IL2CPP_SetTexture = "UnityEngine.CanvasRenderer::SetTexture(UnityEngine.Texture)";
    public const string IL2CPP_SplitIndicesStreamsInternal = "UnityEngine.CanvasRenderer::SplitIndicesStreamsInternal(System.Object,System.Object)";
    public const string IL2CPP_SplitUIVertexStreamsInternal = "UnityEngine.CanvasRenderer::SplitUIVertexStreamsInternal(System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object,System.Object)";
}

