namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_StreamingController
{
    public const string MONO_CancelPreloading = "UnityEngine.StreamingController::CancelPreloading";
    public const string MONO_GetStreamingMipmapBias = "UnityEngine.StreamingController::get_streamingMipmapBias";
    public const string MONO_IsPreloading = "UnityEngine.StreamingController::IsPreloading";
    public const string MONO_SetStreamingMipmapBias = "UnityEngine.StreamingController::set_streamingMipmapBias";
    public const string MONO_SetPreloading = "UnityEngine.StreamingController::SetPreloading";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_StreamingController : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_StreamingController(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_StreamingController(nint ptr) => new Ptr_UnityEngine_StreamingController(ptr);
        public static implicit operator nint(Ptr_UnityEngine_StreamingController ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_StreamingController ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
