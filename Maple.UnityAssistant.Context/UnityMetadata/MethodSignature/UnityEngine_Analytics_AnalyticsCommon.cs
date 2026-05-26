namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Analytics_AnalyticsCommon
{
    public const string MONO_GetUgsAnalyticsEnabledInternal = "UnityEngine.Analytics.AnalyticsCommon::get_ugsAnalyticsEnabledInternal";
    public const string MONO_SetUgsAnalyticsEnabledInternal = "UnityEngine.Analytics.AnalyticsCommon::set_ugsAnalyticsEnabledInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Analytics_AnalyticsCommon : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Analytics_AnalyticsCommon(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Analytics_AnalyticsCommon(nint ptr) => new Ptr_UnityEngine_Analytics_AnalyticsCommon(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Analytics_AnalyticsCommon ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Analytics_AnalyticsCommon ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
