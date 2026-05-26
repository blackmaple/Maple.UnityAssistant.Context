namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SubsystemManager
{
    public const string MONO_ReportSingleSubsystemAnalytics = "UnityEngine.SubsystemManager::ReportSingleSubsystemAnalytics";
    public const string MONO_StaticConstructScriptingClassMap = "UnityEngine.SubsystemManager::StaticConstructScriptingClassMap";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SubsystemManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SubsystemManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SubsystemManager(nint ptr) => new Ptr_UnityEngine_SubsystemManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SubsystemManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SubsystemManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_StaticConstructScriptingClassMap = "UnityEngine.SubsystemManager::StaticConstructScriptingClassMap()";
}

