namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRDisplaySubsystem_XRRenderPass
{
    public const string MONO_GetRenderParameterInjected = "UnityEngine.XR.XRDisplaySubsystem/XRRenderPass::GetRenderParameter_Injected";
    public const string MONO_GetRenderParameterCountInjected = "UnityEngine.XR.XRDisplaySubsystem/XRRenderPass::GetRenderParameterCount_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass(nint ptr) => new Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRDisplaySubsystem_XRRenderPass ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetRenderParameter_Injected = "UnityEngine.XR.XRDisplaySubsystem/XRRenderPass::GetRenderParameter_Injected(UnityEngine.XR.XRDisplaySubsystem/XRRenderPass&,UnityEngine.Camera,System.Int32,UnityEngine.XR.XRDisplaySubsystem/XRRenderParameter&)";
    public const string IL2CPP_GetRenderParameterCount_Injected = "UnityEngine.XR.XRDisplaySubsystem/XRRenderPass::GetRenderParameterCount_Injected(UnityEngine.XR.XRDisplaySubsystem/XRRenderPass&)";
}

