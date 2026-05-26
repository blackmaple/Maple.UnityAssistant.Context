namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore
{
    public const string MONO_ReportSingleSubsystemAnalytics = "UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore::ReportSingleSubsystemAnalytics";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore(nint ptr) => new Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ReportSingleSubsystemAnalytics = "UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore::ReportSingleSubsystemAnalytics(System.String)";
}

