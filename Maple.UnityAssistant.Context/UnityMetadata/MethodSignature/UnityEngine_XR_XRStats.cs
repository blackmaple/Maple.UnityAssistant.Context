namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRStats
{
    public const string MONO_TryGetDroppedFrameCount = "UnityEngine.XR.XRStats::TryGetDroppedFrameCount";
    public const string MONO_TryGetFramePresentCount = "UnityEngine.XR.XRStats::TryGetFramePresentCount";
    public const string MONO_TryGetGputimeLastFrame = "UnityEngine.XR.XRStats::TryGetGPUTimeLastFrame";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRStats : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRStats(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRStats(nint ptr) => new Ptr_UnityEngine_XR_XRStats(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRStats ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRStats ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
