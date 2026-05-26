namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Analytics_Analytics
{
    public const string MONO_EnableCustomEventWithLimit = "UnityEngine.Analytics.Analytics::EnableCustomEventWithLimit";
    public const string MONO_EnableEventWithLimit = "UnityEngine.Analytics.Analytics::EnableEventWithLimit";
    public const string MONO_FlushArchivedEvents = "UnityEngine.Analytics.Analytics::FlushArchivedEvents";
    public const string MONO_GetConfigUrlInternal = "UnityEngine.Analytics.Analytics::get_configUrlInternal";
    public const string MONO_GetDashboardUrlInternal = "UnityEngine.Analytics.Analytics::get_dashboardUrlInternal";
    public const string MONO_GetDeviceStatsEnabledInternal = "UnityEngine.Analytics.Analytics::get_deviceStatsEnabledInternal";
    public const string MONO_GetEnabledInternal = "UnityEngine.Analytics.Analytics::get_enabledInternal";
    public const string MONO_GetEventUrlInternal = "UnityEngine.Analytics.Analytics::get_eventUrlInternal";
    public const string MONO_GetInitializeOnStartupInternal = "UnityEngine.Analytics.Analytics::get_initializeOnStartupInternal";
    public const string MONO_GetLimitUserTrackingInternal = "UnityEngine.Analytics.Analytics::get_limitUserTrackingInternal";
    public const string MONO_GetPlayerOptedOutInternal = "UnityEngine.Analytics.Analytics::get_playerOptedOutInternal";
    public const string MONO_IsCustomEventWithLimitEnabled = "UnityEngine.Analytics.Analytics::IsCustomEventWithLimitEnabled";
    public const string MONO_IsEventWithLimitEnabled = "UnityEngine.Analytics.Analytics::IsEventWithLimitEnabled";
    public const string MONO_IsInitialized = "UnityEngine.Analytics.Analytics::IsInitialized";
    public const string MONO_QueueEvent = "UnityEngine.Analytics.Analytics::QueueEvent";
    public const string MONO_RegisterEventsWithLimit = "UnityEngine.Analytics.Analytics::RegisterEventsWithLimit";
    public const string MONO_RegisterEventWithLimit = "UnityEngine.Analytics.Analytics::RegisterEventWithLimit";
    public const string MONO_ResumeInitializationInternal = "UnityEngine.Analytics.Analytics::ResumeInitializationInternal";
    public const string MONO_SendCustomEvent = "UnityEngine.Analytics.Analytics::SendCustomEvent";
    public const string MONO_SendCustomEventName = "UnityEngine.Analytics.Analytics::SendCustomEventName";
    public const string MONO_SendEventWithLimit = "UnityEngine.Analytics.Analytics::SendEventWithLimit";
    public const string MONO_SetDeviceStatsEnabledInternal = "UnityEngine.Analytics.Analytics::set_deviceStatsEnabledInternal";
    public const string MONO_SetEnabledInternal = "UnityEngine.Analytics.Analytics::set_enabledInternal";
    public const string MONO_SetInitializeOnStartupInternal = "UnityEngine.Analytics.Analytics::set_initializeOnStartupInternal";
    public const string MONO_SetLimitUserTrackingInternal = "UnityEngine.Analytics.Analytics::set_limitUserTrackingInternal";
    public const string MONO_SetEventWithLimitEndPoint = "UnityEngine.Analytics.Analytics::SetEventWithLimitEndPoint";
    public const string MONO_SetEventWithLimitPriority = "UnityEngine.Analytics.Analytics::SetEventWithLimitPriority";
    public const string MONO_Transaction = "UnityEngine.Analytics.Analytics::Transaction";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Analytics_Analytics : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Analytics_Analytics(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Analytics_Analytics(nint ptr) => new Ptr_UnityEngine_Analytics_Analytics(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Analytics_Analytics ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Analytics_Analytics ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_IsInitialized = "UnityEngine.Analytics.Analytics::IsInitialized()";
    public const string IL2CPP_RegisterEventWithLimit = "UnityEngine.Analytics.Analytics::RegisterEventWithLimit(System.String,System.Int32,System.Int32,System.String,System.Int32,System.String,System.String,System.Boolean)";
    public const string IL2CPP_SendEventWithLimit = "UnityEngine.Analytics.Analytics::SendEventWithLimit(System.String,System.Object,System.Int32,System.String)";
}

