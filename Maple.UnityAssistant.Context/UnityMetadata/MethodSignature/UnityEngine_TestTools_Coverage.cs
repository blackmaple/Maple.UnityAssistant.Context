namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TestTools_Coverage
{
    public const string MONO_GetEnabled = "UnityEngine.TestTools.Coverage::get_enabled";
    public const string MONO_GetSequencePointsForInternal = "UnityEngine.TestTools.Coverage::GetSequencePointsFor_Internal";
    public const string MONO_GetStatsForInternalInjected = "UnityEngine.TestTools.Coverage::GetStatsFor_Internal_Injected";
    public const string MONO_GetStatsForAllCoveredMethods = "UnityEngine.TestTools.Coverage::GetStatsForAllCoveredMethods";
    public const string MONO_ResetAll = "UnityEngine.TestTools.Coverage::ResetAll";
    public const string MONO_ResetForInternal = "UnityEngine.TestTools.Coverage::ResetFor_Internal";
    public const string MONO_SetEnabled = "UnityEngine.TestTools.Coverage::set_enabled";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TestTools_Coverage : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TestTools_Coverage(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TestTools_Coverage(nint ptr) => new Ptr_UnityEngine_TestTools_Coverage(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TestTools_Coverage ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TestTools_Coverage ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
