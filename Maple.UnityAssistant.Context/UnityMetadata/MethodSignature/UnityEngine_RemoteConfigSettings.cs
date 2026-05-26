namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RemoteConfigSettings
{
    public const string MONO_AddSessionTag = "UnityEngine.RemoteConfigSettings::AddSessionTag";
    public const string MONO_ForceUpdate = "UnityEngine.RemoteConfigSettings::ForceUpdate";
    public const string MONO_GetAsScriptingObject = "UnityEngine.RemoteConfigSettings::GetAsScriptingObject";
    public const string MONO_GetBool = "UnityEngine.RemoteConfigSettings::GetBool";
    public const string MONO_GetCount = "UnityEngine.RemoteConfigSettings::GetCount";
    public const string MONO_GetFloat = "UnityEngine.RemoteConfigSettings::GetFloat";
    public const string MONO_GetInt = "UnityEngine.RemoteConfigSettings::GetInt";
    public const string MONO_GetKeys = "UnityEngine.RemoteConfigSettings::GetKeys";
    public const string MONO_GetLong = "UnityEngine.RemoteConfigSettings::GetLong";
    public const string MONO_GetSafeTopMap = "UnityEngine.RemoteConfigSettings::GetSafeTopMap";
    public const string MONO_GetString = "UnityEngine.RemoteConfigSettings::GetString";
    public const string MONO_HasKey = "UnityEngine.RemoteConfigSettings::HasKey";
    public const string MONO_InternalCreate = "UnityEngine.RemoteConfigSettings::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.RemoteConfigSettings::Internal_Destroy";
    public const string MONO_QueueConfig = "UnityEngine.RemoteConfigSettings::QueueConfig";
    public const string MONO_ReleaseSafeLock = "UnityEngine.RemoteConfigSettings::ReleaseSafeLock";
    public const string MONO_SendDeviceInfoInConfigRequest = "UnityEngine.RemoteConfigSettings::SendDeviceInfoInConfigRequest";
    public const string MONO_UseSafeLock = "UnityEngine.RemoteConfigSettings::UseSafeLock";
    public const string MONO_WasLastUpdatedFromServer = "UnityEngine.RemoteConfigSettings::WasLastUpdatedFromServer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RemoteConfigSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RemoteConfigSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RemoteConfigSettings(nint ptr) => new Ptr_UnityEngine_RemoteConfigSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RemoteConfigSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RemoteConfigSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
