namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_ScriptableRenderContext
{
    public const string MONO_BeginRenderPassInternal = "UnityEngine.Rendering.ScriptableRenderContext::BeginRenderPass_Internal";
    public const string MONO_BeginSubPassInternal = "UnityEngine.Rendering.ScriptableRenderContext::BeginSubPass_Internal";
    public const string MONO_CreateRendererListInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::CreateRendererList_Internal_Injected";
    public const string MONO_DrawGizmosInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected";
    public const string MONO_DrawRenderersInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawRenderers_Internal_Injected";
    public const string MONO_DrawShadowsInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal_Injected";
    public const string MONO_DrawSkyboxInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected";
    public const string MONO_DrawUioverlayInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawUIOverlay_Internal_Injected";
    public const string MONO_DrawWireOverlayImplInjected = "UnityEngine.Rendering.ScriptableRenderContext::DrawWireOverlay_Impl_Injected";
    public const string MONO_EmitGeometryForCamera = "UnityEngine.Rendering.ScriptableRenderContext::EmitGeometryForCamera";
    public const string MONO_EndRenderPassInternal = "UnityEngine.Rendering.ScriptableRenderContext::EndRenderPass_Internal";
    public const string MONO_EndSubPassInternal = "UnityEngine.Rendering.ScriptableRenderContext::EndSubPass_Internal";
    public const string MONO_ExecuteCommandBufferInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBuffer_Internal_Injected";
    public const string MONO_ExecuteCommandBufferAsyncInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBufferAsync_Internal_Injected";
    public const string MONO_GetCamerasInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::GetCameras_Internal_Injected";
    public const string MONO_InitializeSortSettings = "UnityEngine.Rendering.ScriptableRenderContext::InitializeSortSettings";
    public const string MONO_InternalCullInjected = "UnityEngine.Rendering.ScriptableRenderContext::Internal_Cull_Injected";
    public const string MONO_InvokeOnRenderObjectCallbackInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal_Injected";
    public const string MONO_PrepareRendererListsAsyncInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::PrepareRendererListsAsync_Internal_Injected";
    public const string MONO_QueryRendererListStatusInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::QueryRendererListStatus_Internal_Injected";
    public const string MONO_SetupCameraPropertiesInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::SetupCameraProperties_Internal_Injected";
    public const string MONO_StartMultiEyeInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected";
    public const string MONO_StereoEndRenderInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected";
    public const string MONO_StopMultiEyeInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected";
    public const string MONO_SubmitInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::Submit_Internal_Injected";
    public const string MONO_SubmitForRenderPassValidationInternalInjected = "UnityEngine.Rendering.ScriptableRenderContext::SubmitForRenderPassValidation_Internal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_ScriptableRenderContext : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_ScriptableRenderContext(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_ScriptableRenderContext(nint ptr) => new Ptr_UnityEngine_Rendering_ScriptableRenderContext(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_ScriptableRenderContext ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_ScriptableRenderContext ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_BeginRenderPass_Internal = "UnityEngine.Rendering.ScriptableRenderContext::BeginRenderPass_Internal(System.IntPtr,System.Int32,System.Int32,System.Int32,System.IntPtr,System.Int32,System.Int32)";
    public const string IL2CPP_BeginSubPass_Internal = "UnityEngine.Rendering.ScriptableRenderContext::BeginSubPass_Internal(System.IntPtr,System.IntPtr,System.Int32,System.IntPtr,System.Int32,System.Boolean,System.Boolean)";
    public const string IL2CPP_CreateRendererList_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::CreateRendererList_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,System.IntPtr,UnityEngine.Rendering.DrawingSettings&,UnityEngine.Rendering.FilteringSettings&,UnityEngine.Rendering.ShaderTagId&,System.Boolean,System.IntPtr,System.IntPtr,System.Int32,UnityEngine.Rendering.RendererUtils.RendererList&)";
    public const string IL2CPP_DrawRenderers_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::DrawRenderers_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,System.IntPtr,UnityEngine.Rendering.DrawingSettings&,UnityEngine.Rendering.FilteringSettings&,UnityEngine.Rendering.ShaderTagId&,System.Boolean,System.IntPtr,System.IntPtr,System.Int32)";
    public const string IL2CPP_DrawShadows_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,System.IntPtr)";
    public const string IL2CPP_DrawSkybox_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Camera)";
    public const string IL2CPP_DrawWireOverlay_Impl_Injected = "UnityEngine.Rendering.ScriptableRenderContext::DrawWireOverlay_Impl_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Camera)";
    public const string IL2CPP_EndRenderPass_Internal = "UnityEngine.Rendering.ScriptableRenderContext::EndRenderPass_Internal(System.IntPtr)";
    public const string IL2CPP_EndSubPass_Internal = "UnityEngine.Rendering.ScriptableRenderContext::EndSubPass_Internal(System.IntPtr)";
    public const string IL2CPP_ExecuteCommandBuffer_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBuffer_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Rendering.CommandBuffer)";
    public const string IL2CPP_ExecuteCommandBufferAsync_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBufferAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Rendering.CommandBuffer,UnityEngine.Rendering.ComputeQueueType)";
    public const string IL2CPP_GetCameras_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::GetCameras_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,System.Type,System.Object)";
    public const string IL2CPP_InitializeSortSettings = "UnityEngine.Rendering.ScriptableRenderContext::InitializeSortSettings(UnityEngine.Camera,UnityEngine.Rendering.SortingSettings&)";
    public const string IL2CPP_Internal_Cull_Injected = "UnityEngine.Rendering.ScriptableRenderContext::Internal_Cull_Injected(UnityEngine.Rendering.ScriptableCullingParameters&,UnityEngine.Rendering.ScriptableRenderContext&,System.IntPtr)";
    public const string IL2CPP_InvokeOnRenderObjectCallback_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&)";
    public const string IL2CPP_PrepareRendererListsAsync_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::PrepareRendererListsAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,System.Object)";
    public const string IL2CPP_QueryRendererListStatus_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::QueryRendererListStatus_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Rendering.RendererUtils.RendererList&)";
    public const string IL2CPP_SetupCameraProperties_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::SetupCameraProperties_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&,UnityEngine.Camera,System.Boolean,System.Int32)";
    public const string IL2CPP_Submit_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::Submit_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&)";
    public const string IL2CPP_SubmitForRenderPassValidation_Internal_Injected = "UnityEngine.Rendering.ScriptableRenderContext::SubmitForRenderPassValidation_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext&)";
}

