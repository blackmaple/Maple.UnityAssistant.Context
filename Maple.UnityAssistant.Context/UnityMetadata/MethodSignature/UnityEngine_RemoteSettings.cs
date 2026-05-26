namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RemoteSettings
{
    public const string MONO_ForceUpdate = "UnityEngine.RemoteSettings::ForceUpdate";
    public const string MONO_GetAsScriptingObject = "UnityEngine.RemoteSettings::GetAsScriptingObject";
    public const string MONO_GetBool = "UnityEngine.RemoteSettings::GetBool";
    public const string MONO_GetCount = "UnityEngine.RemoteSettings::GetCount";
    public const string MONO_GetFloat = "UnityEngine.RemoteSettings::GetFloat";
    public const string MONO_GetInt = "UnityEngine.RemoteSettings::GetInt";
    public const string MONO_GetKeys = "UnityEngine.RemoteSettings::GetKeys";
    public const string MONO_GetLong = "UnityEngine.RemoteSettings::GetLong";
    public const string MONO_GetSafeTopMap = "UnityEngine.RemoteSettings::GetSafeTopMap";
    public const string MONO_GetString = "UnityEngine.RemoteSettings::GetString";
    public const string MONO_HasKey = "UnityEngine.RemoteSettings::HasKey";
    public const string MONO_ReleaseSafeLock = "UnityEngine.RemoteSettings::ReleaseSafeLock";
    public const string MONO_UseSafeLock = "UnityEngine.RemoteSettings::UseSafeLock";
    public const string MONO_WasLastUpdatedFromServer = "UnityEngine.RemoteSettings::WasLastUpdatedFromServer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RemoteSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RemoteSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RemoteSettings(nint ptr) => new Ptr_UnityEngine_RemoteSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RemoteSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RemoteSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
