namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Microphone
{
    public const string MONO_EndRecord = "UnityEngine.Microphone::EndRecord";
    public const string MONO_GetDevices = "UnityEngine.Microphone::get_devices";
    public const string MONO_GetIsAnyDeviceRecording = "UnityEngine.Microphone::get_isAnyDeviceRecording";
    public const string MONO_GetDeviceCaps = "UnityEngine.Microphone::GetDeviceCaps";
    public const string MONO_GetMicrophoneDeviceIdfromName = "UnityEngine.Microphone::GetMicrophoneDeviceIDFromName";
    public const string MONO_GetRecordPosition = "UnityEngine.Microphone::GetRecordPosition";
    public const string MONO_IsRecording = "UnityEngine.Microphone::IsRecording";
    public const string MONO_StartRecord = "UnityEngine.Microphone::StartRecord";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Microphone : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Microphone(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Microphone(nint ptr) => new Ptr_UnityEngine_Microphone(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Microphone ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Microphone ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
