namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Playables_TextureMixerPlayable
{
    public const string MONO_CreateTextureMixerPlayableInternal = "UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable(nint ptr) => new Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Playables_TextureMixerPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
