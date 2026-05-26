namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRDisplaySubsystem
{
    public const string MONO_AddGraphicsThreadMirrorViewBlit = "UnityEngine.XR.XRDisplaySubsystem::AddGraphicsThreadMirrorViewBlit";
    public const string MONO_GetContentProtectionEnabled = "UnityEngine.XR.XRDisplaySubsystem::get_contentProtectionEnabled";
    public const string MONO_GetDisableLegacyRenderer = "UnityEngine.XR.XRDisplaySubsystem::get_disableLegacyRenderer";
    public const string MONO_GetDisplayOpaque = "UnityEngine.XR.XRDisplaySubsystem::get_displayOpaque";
    public const string MONO_GetOcclusionMaskScale = "UnityEngine.XR.XRDisplaySubsystem::get_occlusionMaskScale";
    public const string MONO_GetReprojectionMode = "UnityEngine.XR.XRDisplaySubsystem::get_reprojectionMode";
    public const string MONO_GetScaleOfAllRenderTargets = "UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllRenderTargets";
    public const string MONO_GetScaleOfAllViewports = "UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllViewports";
    public const string MONO_GetSRgb = "UnityEngine.XR.XRDisplaySubsystem::get_sRGB";
    public const string MONO_GetSupportedTextureLayouts = "UnityEngine.XR.XRDisplaySubsystem::get_supportedTextureLayouts";
    public const string MONO_GetTextureLayout = "UnityEngine.XR.XRDisplaySubsystem::get_textureLayout";
    public const string MONO_GetZFar = "UnityEngine.XR.XRDisplaySubsystem::get_zFar";
    public const string MONO_GetZNear = "UnityEngine.XR.XRDisplaySubsystem::get_zNear";
    public const string MONO_GetMirrorViewBlitDesc = "UnityEngine.XR.XRDisplaySubsystem::GetMirrorViewBlitDesc";
    public const string MONO_GetPreferredMirrorBlitMode = "UnityEngine.XR.XRDisplaySubsystem::GetPreferredMirrorBlitMode";
    public const string MONO_GetRenderPassCount = "UnityEngine.XR.XRDisplaySubsystem::GetRenderPassCount";
    public const string MONO_GetRenderTextureForRenderPass = "UnityEngine.XR.XRDisplaySubsystem::GetRenderTextureForRenderPass";
    public const string MONO_GetSharedDepthTextureForRenderPass = "UnityEngine.XR.XRDisplaySubsystem::GetSharedDepthTextureForRenderPass";
    public const string MONO_InternalTryBeginRecordingIfLateLatched = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryBeginRecordingIfLateLatched";
    public const string MONO_InternalTryEndRecordingIfLateLatched = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryEndRecordingIfLateLatched";
    public const string MONO_InternalTryGetCullingParams = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryGetCullingParams";
    public const string MONO_InternalTryGetRenderPass = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryGetRenderPass";
    public const string MONO_MarkTransformLateLatched = "UnityEngine.XR.XRDisplaySubsystem::MarkTransformLateLatched";
    public const string MONO_SetContentProtectionEnabled = "UnityEngine.XR.XRDisplaySubsystem::set_contentProtectionEnabled";
    public const string MONO_SetDisableLegacyRenderer = "UnityEngine.XR.XRDisplaySubsystem::set_disableLegacyRenderer";
    public const string MONO_SetOcclusionMaskScale = "UnityEngine.XR.XRDisplaySubsystem::set_occlusionMaskScale";
    public const string MONO_SetReprojectionMode = "UnityEngine.XR.XRDisplaySubsystem::set_reprojectionMode";
    public const string MONO_SetScaleOfAllRenderTargets = "UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllRenderTargets";
    public const string MONO_SetScaleOfAllViewports = "UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllViewports";
    public const string MONO_SetSRgb = "UnityEngine.XR.XRDisplaySubsystem::set_sRGB";
    public const string MONO_SetTextureLayout = "UnityEngine.XR.XRDisplaySubsystem::set_textureLayout";
    public const string MONO_SetZFar = "UnityEngine.XR.XRDisplaySubsystem::set_zFar";
    public const string MONO_SetZNear = "UnityEngine.XR.XRDisplaySubsystem::set_zNear";
    public const string MONO_SetFocusPlaneInjected = "UnityEngine.XR.XRDisplaySubsystem::SetFocusPlane_Injected";
    public const string MONO_SetMsaalevel = "UnityEngine.XR.XRDisplaySubsystem::SetMSAALevel";
    public const string MONO_SetPreferredMirrorBlitMode = "UnityEngine.XR.XRDisplaySubsystem::SetPreferredMirrorBlitMode";
    public const string MONO_TryGetAppGputimeLastFrame = "UnityEngine.XR.XRDisplaySubsystem::TryGetAppGPUTimeLastFrame";
    public const string MONO_TryGetCompositorGputimeLastFrame = "UnityEngine.XR.XRDisplaySubsystem::TryGetCompositorGPUTimeLastFrame";
    public const string MONO_TryGetDisplayRefreshRate = "UnityEngine.XR.XRDisplaySubsystem::TryGetDisplayRefreshRate";
    public const string MONO_TryGetDroppedFrameCount = "UnityEngine.XR.XRDisplaySubsystem::TryGetDroppedFrameCount";
    public const string MONO_TryGetFramePresentCount = "UnityEngine.XR.XRDisplaySubsystem::TryGetFramePresentCount";
    public const string MONO_TryGetMotionToPhoton = "UnityEngine.XR.XRDisplaySubsystem::TryGetMotionToPhoton";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRDisplaySubsystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRDisplaySubsystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRDisplaySubsystem(nint ptr) => new Ptr_UnityEngine_XR_XRDisplaySubsystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRDisplaySubsystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRDisplaySubsystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddGraphicsThreadMirrorViewBlit = "UnityEngine.XR.XRDisplaySubsystem::AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer,System.Boolean,System.Int32)";
    public const string IL2CPP_GetMirrorViewBlitDesc = "UnityEngine.XR.XRDisplaySubsystem::GetMirrorViewBlitDesc(UnityEngine.RenderTexture,UnityEngine.XR.XRDisplaySubsystem/XRMirrorViewBlitDesc&,System.Int32)";
    public const string IL2CPP_GetPreferredMirrorBlitMode = "UnityEngine.XR.XRDisplaySubsystem::GetPreferredMirrorBlitMode()";
    public const string IL2CPP_GetRenderPassCount = "UnityEngine.XR.XRDisplaySubsystem::GetRenderPassCount()";
    public const string IL2CPP_Internal_TryBeginRecordingIfLateLatched = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera)";
    public const string IL2CPP_Internal_TryEndRecordingIfLateLatched = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera)";
    public const string IL2CPP_Internal_TryGetCullingParams = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryGetCullingParams(UnityEngine.Camera,System.Int32,UnityEngine.Rendering.ScriptableCullingParameters&)";
    public const string IL2CPP_Internal_TryGetRenderPass = "UnityEngine.XR.XRDisplaySubsystem::Internal_TryGetRenderPass(System.Int32,UnityEngine.XR.XRDisplaySubsystem/XRRenderPass&)";
    public const string IL2CPP_set_disableLegacyRenderer = "UnityEngine.XR.XRDisplaySubsystem::set_disableLegacyRenderer(System.Boolean)";
    public const string IL2CPP_set_scaleOfAllRenderTargets = "UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllRenderTargets(System.Single)";
    public const string IL2CPP_set_sRGB = "UnityEngine.XR.XRDisplaySubsystem::set_sRGB(System.Boolean)";
    public const string IL2CPP_set_textureLayout = "UnityEngine.XR.XRDisplaySubsystem::set_textureLayout(UnityEngine.XR.XRDisplaySubsystem/TextureLayout)";
    public const string IL2CPP_set_zFar = "UnityEngine.XR.XRDisplaySubsystem::set_zFar(System.Single)";
    public const string IL2CPP_set_zNear = "UnityEngine.XR.XRDisplaySubsystem::set_zNear(System.Single)";
    public const string IL2CPP_SetMSAALevel = "UnityEngine.XR.XRDisplaySubsystem::SetMSAALevel(System.Int32)";
}

