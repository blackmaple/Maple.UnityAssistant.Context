namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RenderTexture
{
    public const string MONO_ConvertToEquirect = "UnityEngine.RenderTexture::ConvertToEquirect";
    public const string MONO_Create = "UnityEngine.RenderTexture::Create";
    public const string MONO_DiscardContents = "UnityEngine.RenderTexture::DiscardContents";
    public const string MONO_GenerateMips = "UnityEngine.RenderTexture::GenerateMips";
    public const string MONO_GetAntiAliasing = "UnityEngine.RenderTexture::get_antiAliasing";
    public const string MONO_GetAutoGenerateMips = "UnityEngine.RenderTexture::get_autoGenerateMips";
    public const string MONO_GetBindTextureMs = "UnityEngine.RenderTexture::get_bindTextureMS";
    public const string MONO_GetDepth = "UnityEngine.RenderTexture::get_depth";
    public const string MONO_GetDepthStencilFormat = "UnityEngine.RenderTexture::get_depthStencilFormat";
    public const string MONO_GetDimension = "UnityEngine.RenderTexture::get_dimension";
    public const string MONO_GetEnableRandomWrite = "UnityEngine.RenderTexture::get_enableRandomWrite";
    public const string MONO_GetGraphicsFormat = "UnityEngine.RenderTexture::get_graphicsFormat";
    public const string MONO_GetHeight = "UnityEngine.RenderTexture::get_height";
    public const string MONO_GetMemorylessMode = "UnityEngine.RenderTexture::get_memorylessMode";
    public const string MONO_GetSRgb = "UnityEngine.RenderTexture::get_sRGB";
    public const string MONO_GetStencilFormat = "UnityEngine.RenderTexture::get_stencilFormat";
    public const string MONO_GetUseDynamicScale = "UnityEngine.RenderTexture::get_useDynamicScale";
    public const string MONO_GetUseMipMap = "UnityEngine.RenderTexture::get_useMipMap";
    public const string MONO_GetVolumeDepth = "UnityEngine.RenderTexture::get_volumeDepth";
    public const string MONO_GetVrUsage = "UnityEngine.RenderTexture::get_vrUsage";
    public const string MONO_GetWidth = "UnityEngine.RenderTexture::get_width";
    public const string MONO_GetActive = "UnityEngine.RenderTexture::GetActive";
    public const string MONO_GetColorBufferInjected = "UnityEngine.RenderTexture::GetColorBuffer_Injected";
    public const string MONO_GetDepthBufferInjected = "UnityEngine.RenderTexture::GetDepthBuffer_Injected";
    public const string MONO_GetDescriptorInjected = "UnityEngine.RenderTexture::GetDescriptor_Injected";
    public const string MONO_GetIsPowerOfTwo = "UnityEngine.RenderTexture::GetIsPowerOfTwo";
    public const string MONO_GetNativeDepthBufferPtr = "UnityEngine.RenderTexture::GetNativeDepthBufferPtr";
    public const string MONO_GetTemporaryInternalInjected = "UnityEngine.RenderTexture::GetTemporary_Internal_Injected";
    public const string MONO_InternalCreate = "UnityEngine.RenderTexture::Internal_Create";
    public const string MONO_IsCreated = "UnityEngine.RenderTexture::IsCreated";
    public const string MONO_MarkRestoreExpected = "UnityEngine.RenderTexture::MarkRestoreExpected";
    public const string MONO_Release = "UnityEngine.RenderTexture::Release";
    public const string MONO_ReleaseTemporary = "UnityEngine.RenderTexture::ReleaseTemporary";
    public const string MONO_ResolveAa = "UnityEngine.RenderTexture::ResolveAA";
    public const string MONO_ResolveAato = "UnityEngine.RenderTexture::ResolveAATo";
    public const string MONO_SetAntiAliasing = "UnityEngine.RenderTexture::set_antiAliasing";
    public const string MONO_SetAutoGenerateMips = "UnityEngine.RenderTexture::set_autoGenerateMips";
    public const string MONO_SetBindTextureMs = "UnityEngine.RenderTexture::set_bindTextureMS";
    public const string MONO_SetDepth = "UnityEngine.RenderTexture::set_depth";
    public const string MONO_SetDepthStencilFormat = "UnityEngine.RenderTexture::set_depthStencilFormat";
    public const string MONO_SetDimension = "UnityEngine.RenderTexture::set_dimension";
    public const string MONO_SetEnableRandomWrite = "UnityEngine.RenderTexture::set_enableRandomWrite";
    public const string MONO_SetGraphicsFormat = "UnityEngine.RenderTexture::set_graphicsFormat";
    public const string MONO_SetHeight = "UnityEngine.RenderTexture::set_height";
    public const string MONO_SetMemorylessMode = "UnityEngine.RenderTexture::set_memorylessMode";
    public const string MONO_SetStencilFormat = "UnityEngine.RenderTexture::set_stencilFormat";
    public const string MONO_SetUseDynamicScale = "UnityEngine.RenderTexture::set_useDynamicScale";
    public const string MONO_SetUseMipMap = "UnityEngine.RenderTexture::set_useMipMap";
    public const string MONO_SetVolumeDepth = "UnityEngine.RenderTexture::set_volumeDepth";
    public const string MONO_SetVrUsage = "UnityEngine.RenderTexture::set_vrUsage";
    public const string MONO_SetWidth = "UnityEngine.RenderTexture::set_width";
    public const string MONO_SetActive = "UnityEngine.RenderTexture::SetActive";
    public const string MONO_SetGlobalShaderProperty = "UnityEngine.RenderTexture::SetGlobalShaderProperty";
    public const string MONO_SetMipMapCount = "UnityEngine.RenderTexture::SetMipMapCount";
    public const string MONO_SetRenderTextureDescriptorInjected = "UnityEngine.RenderTexture::SetRenderTextureDescriptor_Injected";
    public const string MONO_SetShadowSamplingMode = "UnityEngine.RenderTexture::SetShadowSamplingMode";
    public const string MONO_SetSrgbreadWrite = "UnityEngine.RenderTexture::SetSRGBReadWrite";
    public const string MONO_SupportsStencil = "UnityEngine.RenderTexture::SupportsStencil";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RenderTexture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RenderTexture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RenderTexture(nint ptr) => new Ptr_UnityEngine_RenderTexture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RenderTexture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RenderTexture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ConvertToEquirect = "UnityEngine.RenderTexture::ConvertToEquirect(UnityEngine.RenderTexture,UnityEngine.Camera/MonoOrStereoscopicEye)";
    public const string IL2CPP_Create = "UnityEngine.RenderTexture::Create()";
    public const string IL2CPP_DiscardContents = "UnityEngine.RenderTexture::DiscardContents(System.Boolean,System.Boolean)";
    public const string IL2CPP_GenerateMips = "UnityEngine.RenderTexture::GenerateMips()";
    public const string IL2CPP_get_antiAliasing = "UnityEngine.RenderTexture::get_antiAliasing()";
    public const string IL2CPP_get_autoGenerateMips = "UnityEngine.RenderTexture::get_autoGenerateMips()";
    public const string IL2CPP_get_bindTextureMS = "UnityEngine.RenderTexture::get_bindTextureMS()";
    public const string IL2CPP_get_depth = "UnityEngine.RenderTexture::get_depth()";
    public const string IL2CPP_get_depthStencilFormat = "UnityEngine.RenderTexture::get_depthStencilFormat()";
    public const string IL2CPP_get_dimension = "UnityEngine.RenderTexture::get_dimension()";
    public const string IL2CPP_get_enableRandomWrite = "UnityEngine.RenderTexture::get_enableRandomWrite()";
    public const string IL2CPP_get_graphicsFormat = "UnityEngine.RenderTexture::get_graphicsFormat()";
    public const string IL2CPP_get_height = "UnityEngine.RenderTexture::get_height()";
    public const string IL2CPP_get_memorylessMode = "UnityEngine.RenderTexture::get_memorylessMode()";
    public const string IL2CPP_get_sRGB = "UnityEngine.RenderTexture::get_sRGB()";
    public const string IL2CPP_get_stencilFormat = "UnityEngine.RenderTexture::get_stencilFormat()";
    public const string IL2CPP_get_useDynamicScale = "UnityEngine.RenderTexture::get_useDynamicScale()";
    public const string IL2CPP_get_useMipMap = "UnityEngine.RenderTexture::get_useMipMap()";
    public const string IL2CPP_get_volumeDepth = "UnityEngine.RenderTexture::get_volumeDepth()";
    public const string IL2CPP_get_vrUsage = "UnityEngine.RenderTexture::get_vrUsage()";
    public const string IL2CPP_get_width = "UnityEngine.RenderTexture::get_width()";
    public const string IL2CPP_GetActive = "UnityEngine.RenderTexture::GetActive()";
    public const string IL2CPP_GetColorBuffer_Injected = "UnityEngine.RenderTexture::GetColorBuffer_Injected(UnityEngine.RenderBuffer&)";
    public const string IL2CPP_GetDepthBuffer_Injected = "UnityEngine.RenderTexture::GetDepthBuffer_Injected(UnityEngine.RenderBuffer&)";
    public const string IL2CPP_GetDescriptor_Injected = "UnityEngine.RenderTexture::GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor&)";
    public const string IL2CPP_GetIsPowerOfTwo = "UnityEngine.RenderTexture::GetIsPowerOfTwo()";
    public const string IL2CPP_GetNativeDepthBufferPtr = "UnityEngine.RenderTexture::GetNativeDepthBufferPtr()";
    public const string IL2CPP_GetTemporary_Internal_Injected = "UnityEngine.RenderTexture::GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor&)";
    public const string IL2CPP_Internal_Create = "UnityEngine.RenderTexture::Internal_Create(UnityEngine.RenderTexture)";
    public const string IL2CPP_IsCreated = "UnityEngine.RenderTexture::IsCreated()";
    public const string IL2CPP_MarkRestoreExpected = "UnityEngine.RenderTexture::MarkRestoreExpected()";
    public const string IL2CPP_Release = "UnityEngine.RenderTexture::Release()";
    public const string IL2CPP_ReleaseTemporary = "UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)";
    public const string IL2CPP_ResolveAA = "UnityEngine.RenderTexture::ResolveAA()";
    public const string IL2CPP_ResolveAATo = "UnityEngine.RenderTexture::ResolveAATo(UnityEngine.RenderTexture)";
    public const string IL2CPP_set_antiAliasing = "UnityEngine.RenderTexture::set_antiAliasing(System.Int32)";
    public const string IL2CPP_set_autoGenerateMips = "UnityEngine.RenderTexture::set_autoGenerateMips(System.Boolean)";
    public const string IL2CPP_set_bindTextureMS = "UnityEngine.RenderTexture::set_bindTextureMS(System.Boolean)";
    public const string IL2CPP_set_depth = "UnityEngine.RenderTexture::set_depth(System.Int32)";
    public const string IL2CPP_set_depthStencilFormat = "UnityEngine.RenderTexture::set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat)";
    public const string IL2CPP_set_dimension = "UnityEngine.RenderTexture::set_dimension(UnityEngine.Rendering.TextureDimension)";
    public const string IL2CPP_set_enableRandomWrite = "UnityEngine.RenderTexture::set_enableRandomWrite(System.Boolean)";
    public const string IL2CPP_set_graphicsFormat = "UnityEngine.RenderTexture::set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat)";
    public const string IL2CPP_set_height = "UnityEngine.RenderTexture::set_height(System.Int32)";
    public const string IL2CPP_set_memorylessMode = "UnityEngine.RenderTexture::set_memorylessMode(UnityEngine.RenderTextureMemoryless)";
    public const string IL2CPP_set_stencilFormat = "UnityEngine.RenderTexture::set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat)";
    public const string IL2CPP_set_useDynamicScale = "UnityEngine.RenderTexture::set_useDynamicScale(System.Boolean)";
    public const string IL2CPP_set_useMipMap = "UnityEngine.RenderTexture::set_useMipMap(System.Boolean)";
    public const string IL2CPP_set_volumeDepth = "UnityEngine.RenderTexture::set_volumeDepth(System.Int32)";
    public const string IL2CPP_set_vrUsage = "UnityEngine.RenderTexture::set_vrUsage(UnityEngine.VRTextureUsage)";
    public const string IL2CPP_set_width = "UnityEngine.RenderTexture::set_width(System.Int32)";
    public const string IL2CPP_SetActive = "UnityEngine.RenderTexture::SetActive(UnityEngine.RenderTexture)";
    public const string IL2CPP_SetGlobalShaderProperty = "UnityEngine.RenderTexture::SetGlobalShaderProperty(System.String)";
    public const string IL2CPP_SetMipMapCount = "UnityEngine.RenderTexture::SetMipMapCount(System.Int32)";
    public const string IL2CPP_SetRenderTextureDescriptor_Injected = "UnityEngine.RenderTexture::SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor&)";
    public const string IL2CPP_SetShadowSamplingMode = "UnityEngine.RenderTexture::SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode)";
    public const string IL2CPP_SetSRGBReadWrite = "UnityEngine.RenderTexture::SetSRGBReadWrite(System.Boolean)";
    public const string IL2CPP_SupportsStencil = "UnityEngine.RenderTexture::SupportsStencil(UnityEngine.RenderTexture)";
}

