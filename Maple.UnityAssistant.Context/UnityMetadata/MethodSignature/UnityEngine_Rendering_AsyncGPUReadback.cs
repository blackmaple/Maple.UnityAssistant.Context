namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_AsyncGPUReadback
{
    public const string MONO_RequestInternalComputeBuffer1Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_1_Injected";
    public const string MONO_RequestInternalComputeBuffer2Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_2_Injected";
    public const string MONO_RequestInternalGraphicsBuffer1Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_GraphicsBuffer_1_Injected";
    public const string MONO_RequestInternalGraphicsBuffer2Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_GraphicsBuffer_2_Injected";
    public const string MONO_RequestInternalTexture1Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_1_Injected";
    public const string MONO_RequestInternalTexture2Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_2_Injected";
    public const string MONO_RequestInternalTexture3Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_3_Injected";
    public const string MONO_RequestInternalTexture4Injected = "UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_4_Injected";
    public const string MONO_WaitAllRequests = "UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_AsyncGPUReadback : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_AsyncGPUReadback(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_AsyncGPUReadback(nint ptr) => new Ptr_UnityEngine_Rendering_AsyncGPUReadback(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_AsyncGPUReadback ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_AsyncGPUReadback ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
