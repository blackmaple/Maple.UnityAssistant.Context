namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_UIElements_UIR_Utility
{
    public const string MONO_AllocateBuffer = "UnityEngine.UIElements.UIR.Utility::AllocateBuffer";
    public const string MONO_CpufencePassed = "UnityEngine.UIElements.UIR.Utility::CPUFencePassed";
    public const string MONO_CreateStencilStateInjected = "UnityEngine.UIElements.UIR.Utility::CreateStencilState_Injected";
    public const string MONO_DebugIsMainThread = "UnityEngine.UIElements.UIR.Utility::DebugIsMainThread";
    public const string MONO_DisableScissor = "UnityEngine.UIElements.UIR.Utility::DisableScissor";
    public const string MONO_DrawRanges = "UnityEngine.UIElements.UIR.Utility::DrawRanges";
    public const string MONO_FreeBuffer = "UnityEngine.UIElements.UIR.Utility::FreeBuffer";
    public const string MONO_GetActiveViewportInjected = "UnityEngine.UIElements.UIR.Utility::GetActiveViewport_Injected";
    public const string MONO_GetDeviceProjectionMatrixInjected = "UnityEngine.UIElements.UIR.Utility::GetDeviceProjectionMatrix_Injected";
    public const string MONO_GetUnityProjectionMatrixInjected = "UnityEngine.UIElements.UIR.Utility::GetUnityProjectionMatrix_Injected";
    public const string MONO_GetVertexDeclaration = "UnityEngine.UIElements.UIR.Utility::GetVertexDeclaration";
    public const string MONO_HasMappedBufferRange = "UnityEngine.UIElements.UIR.Utility::HasMappedBufferRange";
    public const string MONO_InsertCpufence = "UnityEngine.UIElements.UIR.Utility::InsertCPUFence";
    public const string MONO_IsScissorEnabled = "UnityEngine.UIElements.UIR.Utility::IsScissorEnabled";
    public const string MONO_NotifyOfUirevents = "UnityEngine.UIElements.UIR.Utility::NotifyOfUIREvents";
    public const string MONO_ProfileDrawChainBegin = "UnityEngine.UIElements.UIR.Utility::ProfileDrawChainBegin";
    public const string MONO_ProfileDrawChainEnd = "UnityEngine.UIElements.UIR.Utility::ProfileDrawChainEnd";
    public const string MONO_RegisterIntermediateRendererInjected = "UnityEngine.UIElements.UIR.Utility::RegisterIntermediateRenderer_Injected";
    public const string MONO_SetPropertyBlock = "UnityEngine.UIElements.UIR.Utility::SetPropertyBlock";
    public const string MONO_SetScissorRectInjected = "UnityEngine.UIElements.UIR.Utility::SetScissorRect_Injected";
    public const string MONO_SetStencilState = "UnityEngine.UIElements.UIR.Utility::SetStencilState";
    public const string MONO_SetVectorArray = "UnityEngine.UIElements.UIR.Utility::SetVectorArray";
    public const string MONO_SyncRenderThread = "UnityEngine.UIElements.UIR.Utility::SyncRenderThread";
    public const string MONO_UpdateBufferRanges = "UnityEngine.UIElements.UIR.Utility::UpdateBufferRanges";
    public const string MONO_WaitForCpufencePassed = "UnityEngine.UIElements.UIR.Utility::WaitForCPUFencePassed";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_UIElements_UIR_Utility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_UIElements_UIR_Utility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_UIElements_UIR_Utility(nint ptr) => new Ptr_UnityEngine_UIElements_UIR_Utility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_UIElements_UIR_Utility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_UIElements_UIR_Utility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AllocateBuffer = "UnityEngine.UIElements.UIR.Utility::AllocateBuffer(System.Int32,System.Int32,System.Boolean)";
    public const string IL2CPP_CPUFencePassed = "UnityEngine.UIElements.UIR.Utility::CPUFencePassed(System.UInt32)";
    public const string IL2CPP_CreateStencilState_Injected = "UnityEngine.UIElements.UIR.Utility::CreateStencilState_Injected(UnityEngine.Rendering.StencilState&)";
    public const string IL2CPP_DisableScissor = "UnityEngine.UIElements.UIR.Utility::DisableScissor()";
    public const string IL2CPP_DrawRanges = "UnityEngine.UIElements.UIR.Utility::DrawRanges(System.IntPtr,System.IntPtr*,System.Int32,System.IntPtr,System.Int32,System.IntPtr)";
    public const string IL2CPP_FreeBuffer = "UnityEngine.UIElements.UIR.Utility::FreeBuffer(System.IntPtr)";
    public const string IL2CPP_GetActiveViewport_Injected = "UnityEngine.UIElements.UIR.Utility::GetActiveViewport_Injected(UnityEngine.RectInt&)";
    public const string IL2CPP_GetUnityProjectionMatrix_Injected = "UnityEngine.UIElements.UIR.Utility::GetUnityProjectionMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GetVertexDeclaration = "UnityEngine.UIElements.UIR.Utility::GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[])";
    public const string IL2CPP_HasMappedBufferRange = "UnityEngine.UIElements.UIR.Utility::HasMappedBufferRange()";
    public const string IL2CPP_InsertCPUFence = "UnityEngine.UIElements.UIR.Utility::InsertCPUFence()";
    public const string IL2CPP_NotifyOfUIREvents = "UnityEngine.UIElements.UIR.Utility::NotifyOfUIREvents(System.Boolean)";
    public const string IL2CPP_ProfileDrawChainBegin = "UnityEngine.UIElements.UIR.Utility::ProfileDrawChainBegin()";
    public const string IL2CPP_ProfileDrawChainEnd = "UnityEngine.UIElements.UIR.Utility::ProfileDrawChainEnd()";
    public const string IL2CPP_RegisterIntermediateRenderer_Injected = "UnityEngine.UIElements.UIR.Utility::RegisterIntermediateRenderer_Injected(UnityEngine.Camera,UnityEngine.Material,UnityEngine.Matrix4x4&,UnityEngine.Bounds&,System.Int32,System.Int32,System.Boolean,System.Int32,System.UInt64,System.Int32,System.IntPtr,System.Int32)";
    public const string IL2CPP_SetPropertyBlock = "UnityEngine.UIElements.UIR.Utility::SetPropertyBlock(UnityEngine.MaterialPropertyBlock)";
    public const string IL2CPP_SetScissorRect_Injected = "UnityEngine.UIElements.UIR.Utility::SetScissorRect_Injected(UnityEngine.RectInt&)";
    public const string IL2CPP_SetStencilState = "UnityEngine.UIElements.UIR.Utility::SetStencilState(System.IntPtr,System.Int32)";
    public const string IL2CPP_SetVectorArray = "UnityEngine.UIElements.UIR.Utility::SetVectorArray(UnityEngine.MaterialPropertyBlock,System.Int32,System.IntPtr,System.Int32)";
    public const string IL2CPP_SyncRenderThread = "UnityEngine.UIElements.UIR.Utility::SyncRenderThread()";
    public const string IL2CPP_UpdateBufferRanges = "UnityEngine.UIElements.UIR.Utility::UpdateBufferRanges(System.IntPtr,System.IntPtr,System.Int32,System.Int32,System.Int32)";
    public const string IL2CPP_WaitForCPUFencePassed = "UnityEngine.UIElements.UIR.Utility::WaitForCPUFencePassed(System.UInt32)";
}

