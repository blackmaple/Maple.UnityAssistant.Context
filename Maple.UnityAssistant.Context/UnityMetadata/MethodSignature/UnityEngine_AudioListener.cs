namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AudioListener
{
    public const string MONO_GetPause = "UnityEngine.AudioListener::get_pause";
    public const string MONO_GetVelocityUpdateMode = "UnityEngine.AudioListener::get_velocityUpdateMode";
    public const string MONO_GetVolume = "UnityEngine.AudioListener::get_volume";
    public const string MONO_GetOutputDataHelper = "UnityEngine.AudioListener::GetOutputDataHelper";
    public const string MONO_GetSpectrumDataHelper = "UnityEngine.AudioListener::GetSpectrumDataHelper";
    public const string MONO_SetPause = "UnityEngine.AudioListener::set_pause";
    public const string MONO_SetVelocityUpdateMode = "UnityEngine.AudioListener::set_velocityUpdateMode";
    public const string MONO_SetVolume = "UnityEngine.AudioListener::set_volume";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AudioListener : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AudioListener(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AudioListener(nint ptr) => new Ptr_UnityEngine_AudioListener(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AudioListener ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AudioListener ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
