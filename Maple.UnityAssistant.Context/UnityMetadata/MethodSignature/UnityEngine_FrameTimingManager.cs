namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_FrameTimingManager
{
    public const string MONO_CaptureFrameTimings = "UnityEngine.FrameTimingManager::CaptureFrameTimings";
    public const string MONO_GetCpuTimerFrequency = "UnityEngine.FrameTimingManager::GetCpuTimerFrequency";
    public const string MONO_GetGpuTimerFrequency = "UnityEngine.FrameTimingManager::GetGpuTimerFrequency";
    public const string MONO_GetLatestTimings = "UnityEngine.FrameTimingManager::GetLatestTimings";
    public const string MONO_GetVsyncsPerSecond = "UnityEngine.FrameTimingManager::GetVSyncsPerSecond";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_FrameTimingManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_FrameTimingManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_FrameTimingManager(nint ptr) => new Ptr_UnityEngine_FrameTimingManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_FrameTimingManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_FrameTimingManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
