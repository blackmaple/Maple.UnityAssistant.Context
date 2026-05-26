namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_WindZone
{
    public const string MONO_GetMode = "UnityEngine.WindZone::get_mode";
    public const string MONO_GetRadius = "UnityEngine.WindZone::get_radius";
    public const string MONO_GetWindMain = "UnityEngine.WindZone::get_windMain";
    public const string MONO_GetWindPulseFrequency = "UnityEngine.WindZone::get_windPulseFrequency";
    public const string MONO_GetWindPulseMagnitude = "UnityEngine.WindZone::get_windPulseMagnitude";
    public const string MONO_GetWindTurbulence = "UnityEngine.WindZone::get_windTurbulence";
    public const string MONO_SetMode = "UnityEngine.WindZone::set_mode";
    public const string MONO_SetRadius = "UnityEngine.WindZone::set_radius";
    public const string MONO_SetWindMain = "UnityEngine.WindZone::set_windMain";
    public const string MONO_SetWindPulseFrequency = "UnityEngine.WindZone::set_windPulseFrequency";
    public const string MONO_SetWindPulseMagnitude = "UnityEngine.WindZone::set_windPulseMagnitude";
    public const string MONO_SetWindTurbulence = "UnityEngine.WindZone::set_windTurbulence";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_WindZone : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_WindZone(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_WindZone(nint ptr) => new Ptr_UnityEngine_WindZone(ptr);
        public static implicit operator nint(Ptr_UnityEngine_WindZone ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_WindZone ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
