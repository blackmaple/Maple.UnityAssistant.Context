namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RenderBuffer
{
    public const string MONO_GetLoadActionInjected = "UnityEngine.RenderBuffer::GetLoadAction_Injected";
    public const string MONO_GetNativeRenderBufferPtrInjected = "UnityEngine.RenderBuffer::GetNativeRenderBufferPtr_Injected";
    public const string MONO_GetStoreActionInjected = "UnityEngine.RenderBuffer::GetStoreAction_Injected";
    public const string MONO_SetLoadActionInjected = "UnityEngine.RenderBuffer::SetLoadAction_Injected";
    public const string MONO_SetStoreActionInjected = "UnityEngine.RenderBuffer::SetStoreAction_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RenderBuffer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RenderBuffer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RenderBuffer(nint ptr) => new Ptr_UnityEngine_RenderBuffer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RenderBuffer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RenderBuffer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
