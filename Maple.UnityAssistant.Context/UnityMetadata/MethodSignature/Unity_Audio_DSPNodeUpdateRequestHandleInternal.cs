namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Audio_DSPNodeUpdateRequestHandleInternal
{
    public const string MONO_InternalDispose = "Unity.Audio.DSPNodeUpdateRequestHandleInternal::Internal_Dispose";
    public const string MONO_InternalGetDspnode = "Unity.Audio.DSPNodeUpdateRequestHandleInternal::Internal_GetDSPNode";
    public const string MONO_InternalGetFence = "Unity.Audio.DSPNodeUpdateRequestHandleInternal::Internal_GetFence";
    public const string MONO_InternalGetUpdateJobData = "Unity.Audio.DSPNodeUpdateRequestHandleInternal::Internal_GetUpdateJobData";
    public const string MONO_InternalHasError = "Unity.Audio.DSPNodeUpdateRequestHandleInternal::Internal_HasError";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal(nint ptr) => new Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal(ptr);
        public static implicit operator nint(Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Audio_DSPNodeUpdateRequestHandleInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
