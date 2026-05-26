namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RemoteConfigSettingsHelper
{
    public const string MONO_GetSafeArray = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArray";
    public const string MONO_GetSafeArrayArray = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayArray";
    public const string MONO_GetSafeArrayBool = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayBool";
    public const string MONO_GetSafeArrayFloat = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayFloat";
    public const string MONO_GetSafeArrayMap = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayMap";
    public const string MONO_GetSafeArraySize = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArraySize";
    public const string MONO_GetSafeArrayStringValue = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayStringValue";
    public const string MONO_GetSafeArrayType = "UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayType";
    public const string MONO_GetSafeBool = "UnityEngine.RemoteConfigSettingsHelper::GetSafeBool";
    public const string MONO_GetSafeFloat = "UnityEngine.RemoteConfigSettingsHelper::GetSafeFloat";
    public const string MONO_GetSafeMap = "UnityEngine.RemoteConfigSettingsHelper::GetSafeMap";
    public const string MONO_GetSafeMapKeys = "UnityEngine.RemoteConfigSettingsHelper::GetSafeMapKeys";
    public const string MONO_GetSafeMapTypes = "UnityEngine.RemoteConfigSettingsHelper::GetSafeMapTypes";
    public const string MONO_GetSafeNumber = "UnityEngine.RemoteConfigSettingsHelper::GetSafeNumber";
    public const string MONO_GetSafeNumberArray = "UnityEngine.RemoteConfigSettingsHelper::GetSafeNumberArray";
    public const string MONO_GetSafeStringValue = "UnityEngine.RemoteConfigSettingsHelper::GetSafeStringValue";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RemoteConfigSettingsHelper : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RemoteConfigSettingsHelper(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RemoteConfigSettingsHelper(nint ptr) => new Ptr_UnityEngine_RemoteConfigSettingsHelper(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RemoteConfigSettingsHelper ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RemoteConfigSettingsHelper ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
