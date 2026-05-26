namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_XRMeshSubsystem
{
    public const string MONO_GenerateMeshAsyncInjected = "UnityEngine.XR.XRMeshSubsystem::GenerateMeshAsync_Injected";
    public const string MONO_GetMeshDensity = "UnityEngine.XR.XRMeshSubsystem::get_meshDensity";
    public const string MONO_GetMeshInfosAsFixedArray = "UnityEngine.XR.XRMeshSubsystem::GetMeshInfosAsFixedArray";
    public const string MONO_GetMeshInfosAsList = "UnityEngine.XR.XRMeshSubsystem::GetMeshInfosAsList";
    public const string MONO_GetUpdatedMeshTransforms = "UnityEngine.XR.XRMeshSubsystem::GetUpdatedMeshTransforms";
    public const string MONO_SetMeshDensity = "UnityEngine.XR.XRMeshSubsystem::set_meshDensity";
    public const string MONO_SetBoundingVolumeInjected = "UnityEngine.XR.XRMeshSubsystem::SetBoundingVolume_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_XRMeshSubsystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_XRMeshSubsystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_XRMeshSubsystem(nint ptr) => new Ptr_UnityEngine_XR_XRMeshSubsystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_XRMeshSubsystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_XRMeshSubsystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
