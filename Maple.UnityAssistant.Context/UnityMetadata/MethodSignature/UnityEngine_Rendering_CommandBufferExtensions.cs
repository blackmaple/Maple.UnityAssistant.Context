namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_CommandBufferExtensions
{
    public const string MONO_InternalSwitchIntoFastMemory = "UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchIntoFastMemory";
    public const string MONO_InternalSwitchOutOfFastMemory = "UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchOutOfFastMemory";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_CommandBufferExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_CommandBufferExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_CommandBufferExtensions(nint ptr) => new Ptr_UnityEngine_Rendering_CommandBufferExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_CommandBufferExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_CommandBufferExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_SwitchIntoFastMemory = "UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer,UnityEngine.Rendering.RenderTargetIdentifier&,UnityEngine.Rendering.FastMemoryFlags,System.Single,System.Boolean)";
    public const string IL2CPP_Internal_SwitchOutOfFastMemory = "UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer,UnityEngine.Rendering.RenderTargetIdentifier&,System.Boolean)";
}

