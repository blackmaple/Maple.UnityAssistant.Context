namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_AsyncGPUReadbackRequest
{
    public const string MONO_GetDataRawInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDataRaw_Injected";
    public const string MONO_GetDepthInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDepth_Injected";
    public const string MONO_GetHeightInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetHeight_Injected";
    public const string MONO_GetLayerCountInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetLayerCount_Injected";
    public const string MONO_GetLayerDataSizeInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetLayerDataSize_Injected";
    public const string MONO_GetWidthInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::GetWidth_Injected";
    public const string MONO_HasErrorInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::HasError_Injected";
    public const string MONO_IsDoneInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::IsDone_Injected";
    public const string MONO_SetScriptingCallbackInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::SetScriptingCallback_Injected";
    public const string MONO_UpdateInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::Update_Injected";
    public const string MONO_WaitForCompletionInjected = "UnityEngine.Rendering.AsyncGPUReadbackRequest::WaitForCompletion_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest(nint ptr) => new Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_AsyncGPUReadbackRequest ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
