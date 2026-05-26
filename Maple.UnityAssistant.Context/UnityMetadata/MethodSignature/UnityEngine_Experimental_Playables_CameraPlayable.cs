namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Playables_CameraPlayable
{
    public const string MONO_GetCameraInternal = "UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal";
    public const string MONO_InternalCreateCameraPlayable = "UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable";
    public const string MONO_SetCameraInternal = "UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal";
    public const string MONO_ValidateType = "UnityEngine.Experimental.Playables.CameraPlayable::ValidateType";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Playables_CameraPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Playables_CameraPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Playables_CameraPlayable(nint ptr) => new Ptr_UnityEngine_Experimental_Playables_CameraPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Playables_CameraPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Playables_CameraPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
