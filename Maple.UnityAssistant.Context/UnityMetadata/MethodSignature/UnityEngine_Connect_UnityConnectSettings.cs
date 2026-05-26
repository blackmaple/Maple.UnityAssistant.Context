namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Connect_UnityConnectSettings
{
    public const string MONO_GetConfigUrl = "UnityEngine.Connect.UnityConnectSettings::get_configUrl";
    public const string MONO_GetEnabled = "UnityEngine.Connect.UnityConnectSettings::get_enabled";
    public const string MONO_GetEventOldUrl = "UnityEngine.Connect.UnityConnectSettings::get_eventOldUrl";
    public const string MONO_GetEventUrl = "UnityEngine.Connect.UnityConnectSettings::get_eventUrl";
    public const string MONO_GetTestInitMode = "UnityEngine.Connect.UnityConnectSettings::get_testInitMode";
    public const string MONO_GetTestMode = "UnityEngine.Connect.UnityConnectSettings::get_testMode";
    public const string MONO_SetConfigUrl = "UnityEngine.Connect.UnityConnectSettings::set_configUrl";
    public const string MONO_SetEnabled = "UnityEngine.Connect.UnityConnectSettings::set_enabled";
    public const string MONO_SetEventOldUrl = "UnityEngine.Connect.UnityConnectSettings::set_eventOldUrl";
    public const string MONO_SetEventUrl = "UnityEngine.Connect.UnityConnectSettings::set_eventUrl";
    public const string MONO_SetTestInitMode = "UnityEngine.Connect.UnityConnectSettings::set_testInitMode";
    public const string MONO_SetTestMode = "UnityEngine.Connect.UnityConnectSettings::set_testMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Connect_UnityConnectSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Connect_UnityConnectSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Connect_UnityConnectSettings(nint ptr) => new Ptr_UnityEngine_Connect_UnityConnectSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Connect_UnityConnectSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Connect_UnityConnectSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
