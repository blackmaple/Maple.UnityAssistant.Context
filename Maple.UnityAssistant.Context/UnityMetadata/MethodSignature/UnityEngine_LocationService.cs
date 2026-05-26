namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LocationService
{
    public const string MONO_GetLastHeadingInjected = "UnityEngine.LocationService::GetLastHeading_Injected";
    public const string MONO_GetLastLocationInjected = "UnityEngine.LocationService::GetLastLocation_Injected";
    public const string MONO_GetLocationStatus = "UnityEngine.LocationService::GetLocationStatus";
    public const string MONO_IsHeadingUpdatesEnabled = "UnityEngine.LocationService::IsHeadingUpdatesEnabled";
    public const string MONO_IsServiceEnabledByUser = "UnityEngine.LocationService::IsServiceEnabledByUser";
    public const string MONO_SetDesiredAccuracy = "UnityEngine.LocationService::SetDesiredAccuracy";
    public const string MONO_SetDistanceFilter = "UnityEngine.LocationService::SetDistanceFilter";
    public const string MONO_SetHeadingUpdatesEnabled = "UnityEngine.LocationService::SetHeadingUpdatesEnabled";
    public const string MONO_StartUpdatingLocation = "UnityEngine.LocationService::StartUpdatingLocation";
    public const string MONO_StopUpdatingLocation = "UnityEngine.LocationService::StopUpdatingLocation";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LocationService : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LocationService(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LocationService(nint ptr) => new Ptr_UnityEngine_LocationService(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LocationService ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LocationService ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
