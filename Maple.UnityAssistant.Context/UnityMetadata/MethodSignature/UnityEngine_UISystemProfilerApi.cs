namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_UISystemProfilerApi
{
    public const string MONO_AddMarker = "UnityEngine.UISystemProfilerApi::AddMarker";
    public const string MONO_BeginSample = "UnityEngine.UISystemProfilerApi::BeginSample";
    public const string MONO_EndSample = "UnityEngine.UISystemProfilerApi::EndSample";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_UISystemProfilerApi : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_UISystemProfilerApi(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_UISystemProfilerApi(nint ptr) => new Ptr_UnityEngine_UISystemProfilerApi(ptr);
        public static implicit operator nint(Ptr_UnityEngine_UISystemProfilerApi ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_UISystemProfilerApi ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddMarker = "UnityEngine.UISystemProfilerApi::AddMarker(System.String,UnityEngine.Object)";
    public const string IL2CPP_BeginSample = "UnityEngine.UISystemProfilerApi::BeginSample(UnityEngine.UISystemProfilerApi/SampleType)";
    public const string IL2CPP_EndSample = "UnityEngine.UISystemProfilerApi::EndSample(UnityEngine.UISystemProfilerApi/SampleType)";
}

