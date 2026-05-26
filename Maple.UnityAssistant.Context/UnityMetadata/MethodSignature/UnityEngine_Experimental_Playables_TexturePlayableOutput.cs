namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Playables_TexturePlayableOutput
{
    public const string MONO_InternalGetTarget = "UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget";
    public const string MONO_InternalSetTarget = "UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput(nint ptr) => new Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Playables_TexturePlayableOutput ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
