namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc
{
    public const string MONO_GetBlitParameterInjected = "UnityEngine.XR.XRDisplaySubsystem/XRMirrorViewBlitDesc::GetBlitParameter_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc(nint ptr) => new Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRDisplaySubsystem_XRMirrorViewBlitDesc ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetBlitParameter_Injected = "UnityEngine.XR.XRDisplaySubsystem/XRMirrorViewBlitDesc::GetBlitParameter_Injected(UnityEngine.XR.XRDisplaySubsystem/XRMirrorViewBlitDesc&,System.Int32,UnityEngine.XR.XRDisplaySubsystem/XRBlitParams&)";
}

