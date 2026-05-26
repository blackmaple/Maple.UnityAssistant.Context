namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRInputSubsystem
{
    public const string MONO_GetIndex = "UnityEngine.XR.XRInputSubsystem::GetIndex";
    public const string MONO_GetSupportedTrackingOriginModes = "UnityEngine.XR.XRInputSubsystem::GetSupportedTrackingOriginModes";
    public const string MONO_GetTrackingOriginMode = "UnityEngine.XR.XRInputSubsystem::GetTrackingOriginMode";
    public const string MONO_TryGetBoundaryPointsAsList = "UnityEngine.XR.XRInputSubsystem::TryGetBoundaryPoints_AsList";
    public const string MONO_TryGetDeviceIdsAsList = "UnityEngine.XR.XRInputSubsystem::TryGetDeviceIds_AsList";
    public const string MONO_TryRecenter = "UnityEngine.XR.XRInputSubsystem::TryRecenter";
    public const string MONO_TrySetTrackingOriginMode = "UnityEngine.XR.XRInputSubsystem::TrySetTrackingOriginMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRInputSubsystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRInputSubsystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRInputSubsystem(nint ptr) => new Ptr_UnityEngine_XR_XRInputSubsystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRInputSubsystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRInputSubsystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
