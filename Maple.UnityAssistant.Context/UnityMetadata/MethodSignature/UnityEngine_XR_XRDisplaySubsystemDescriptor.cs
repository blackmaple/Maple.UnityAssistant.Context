namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRDisplaySubsystemDescriptor
{
    public const string MONO_GetDisablesLegacyVr = "UnityEngine.XR.XRDisplaySubsystemDescriptor::get_disablesLegacyVr";
    public const string MONO_GetEnableBackBufferMsaa = "UnityEngine.XR.XRDisplaySubsystemDescriptor::get_enableBackBufferMSAA";
    public const string MONO_GetAvailableMirrorBlitModeCount = "UnityEngine.XR.XRDisplaySubsystemDescriptor::GetAvailableMirrorBlitModeCount";
    public const string MONO_GetMirrorBlitModeByIndex = "UnityEngine.XR.XRDisplaySubsystemDescriptor::GetMirrorBlitModeByIndex";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor(nint ptr) => new Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRDisplaySubsystemDescriptor ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
