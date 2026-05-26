namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Analytics_AnalyticsSessionInfo
{
    public const string MONO_GetCustomDeviceIdInternal = "UnityEngine.Analytics.AnalyticsSessionInfo::get_customDeviceIdInternal";
    public const string MONO_GetCustomUserIdInternal = "UnityEngine.Analytics.AnalyticsSessionInfo::get_customUserIdInternal";
    public const string MONO_GetIdentityTokenInternal = "UnityEngine.Analytics.AnalyticsSessionInfo::get_identityTokenInternal";
    public const string MONO_GetSessionCount = "UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionCount";
    public const string MONO_GetSessionElapsedTime = "UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionElapsedTime";
    public const string MONO_GetSessionFirstRun = "UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionFirstRun";
    public const string MONO_GetSessionId = "UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionId";
    public const string MONO_GetSessionState = "UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionState";
    public const string MONO_GetUserId = "UnityEngine.Analytics.AnalyticsSessionInfo::get_userId";
    public const string MONO_SetCustomDeviceIdInternal = "UnityEngine.Analytics.AnalyticsSessionInfo::set_customDeviceIdInternal";
    public const string MONO_SetCustomUserIdInternal = "UnityEngine.Analytics.AnalyticsSessionInfo::set_customUserIdInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Analytics_AnalyticsSessionInfo : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Analytics_AnalyticsSessionInfo(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Analytics_AnalyticsSessionInfo(nint ptr) => new Ptr_UnityEngine_Analytics_AnalyticsSessionInfo(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Analytics_AnalyticsSessionInfo ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Analytics_AnalyticsSessionInfo ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
