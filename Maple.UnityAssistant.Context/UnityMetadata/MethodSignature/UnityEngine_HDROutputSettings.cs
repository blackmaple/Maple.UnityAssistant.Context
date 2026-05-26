namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HDROutputSettings
{
    public const string MONO_GetActive = "UnityEngine.HDROutputSettings::GetActive";
    public const string MONO_GetAutomaticHdrtonemapping = "UnityEngine.HDROutputSettings::GetAutomaticHDRTonemapping";
    public const string MONO_GetAvailable = "UnityEngine.HDROutputSettings::GetAvailable";
    public const string MONO_GetDisplayColorGamut = "UnityEngine.HDROutputSettings::GetDisplayColorGamut";
    public const string MONO_GetGraphicsFormat = "UnityEngine.HDROutputSettings::GetGraphicsFormat";
    public const string MONO_GetHdrmodeChangeRequested = "UnityEngine.HDROutputSettings::GetHDRModeChangeRequested";
    public const string MONO_GetMaxFullFrameToneMapLuminance = "UnityEngine.HDROutputSettings::GetMaxFullFrameToneMapLuminance";
    public const string MONO_GetMaxToneMapLuminance = "UnityEngine.HDROutputSettings::GetMaxToneMapLuminance";
    public const string MONO_GetMinToneMapLuminance = "UnityEngine.HDROutputSettings::GetMinToneMapLuminance";
    public const string MONO_GetPaperWhiteNits = "UnityEngine.HDROutputSettings::GetPaperWhiteNits";
    public const string MONO_RequestHdrmodeChangeInternal = "UnityEngine.HDROutputSettings::RequestHDRModeChangeInternal";
    public const string MONO_SetAutomaticHdrtonemapping = "UnityEngine.HDROutputSettings::SetAutomaticHDRTonemapping";
    public const string MONO_SetPaperWhiteNits = "UnityEngine.HDROutputSettings::SetPaperWhiteNits";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HDROutputSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HDROutputSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HDROutputSettings(nint ptr) => new Ptr_UnityEngine_HDROutputSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HDROutputSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HDROutputSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
