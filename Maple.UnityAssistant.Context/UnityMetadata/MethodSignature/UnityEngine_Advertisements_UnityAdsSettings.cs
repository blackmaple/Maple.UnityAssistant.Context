namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Advertisements_UnityAdsSettings
{
    public const string MONO_GetEnabled = "UnityEngine.Advertisements.UnityAdsSettings::get_enabled";
    public const string MONO_GetInitializeOnStartup = "UnityEngine.Advertisements.UnityAdsSettings::get_initializeOnStartup";
    public const string MONO_GetTestMode = "UnityEngine.Advertisements.UnityAdsSettings::get_testMode";
    public const string MONO_GetGameId = "UnityEngine.Advertisements.UnityAdsSettings::GetGameId";
    public const string MONO_SetEnabled = "UnityEngine.Advertisements.UnityAdsSettings::set_enabled";
    public const string MONO_SetInitializeOnStartup = "UnityEngine.Advertisements.UnityAdsSettings::set_initializeOnStartup";
    public const string MONO_SetTestMode = "UnityEngine.Advertisements.UnityAdsSettings::set_testMode";
    public const string MONO_SetGameId = "UnityEngine.Advertisements.UnityAdsSettings::SetGameId";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Advertisements_UnityAdsSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Advertisements_UnityAdsSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Advertisements_UnityAdsSettings(nint ptr) => new Ptr_UnityEngine_Advertisements_UnityAdsSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Advertisements_UnityAdsSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Advertisements_UnityAdsSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
