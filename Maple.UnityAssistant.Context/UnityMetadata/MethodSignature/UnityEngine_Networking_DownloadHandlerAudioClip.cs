namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_DownloadHandlerAudioClip
{
    public const string MONO_Create = "UnityEngine.Networking.DownloadHandlerAudioClip::Create";
    public const string MONO_GetAudioClip = "UnityEngine.Networking.DownloadHandlerAudioClip::get_audioClip";
    public const string MONO_GetCompressed = "UnityEngine.Networking.DownloadHandlerAudioClip::get_compressed";
    public const string MONO_GetStreamAudio = "UnityEngine.Networking.DownloadHandlerAudioClip::get_streamAudio";
    public const string MONO_SetCompressed = "UnityEngine.Networking.DownloadHandlerAudioClip::set_compressed";
    public const string MONO_SetStreamAudio = "UnityEngine.Networking.DownloadHandlerAudioClip::set_streamAudio";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_DownloadHandlerAudioClip : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_DownloadHandlerAudioClip(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_DownloadHandlerAudioClip(nint ptr) => new Ptr_UnityEngine_Networking_DownloadHandlerAudioClip(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_DownloadHandlerAudioClip ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_DownloadHandlerAudioClip ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Create = "UnityEngine.Networking.DownloadHandlerAudioClip::Create(UnityEngine.Networking.DownloadHandlerAudioClip,System.String,UnityEngine.AudioType)";
    public const string IL2CPP_get_audioClip = "UnityEngine.Networking.DownloadHandlerAudioClip::get_audioClip()";
}

