namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Diagnostics_Utils
{
    public const string MONO_ForceCrash = "UnityEngine.Diagnostics.Utils::ForceCrash";
    public const string MONO_NativeAssert = "UnityEngine.Diagnostics.Utils::NativeAssert";
    public const string MONO_NativeError = "UnityEngine.Diagnostics.Utils::NativeError";
    public const string MONO_NativeWarning = "UnityEngine.Diagnostics.Utils::NativeWarning";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Diagnostics_Utils : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Diagnostics_Utils(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Diagnostics_Utils(nint ptr) => new Ptr_UnityEngine_Diagnostics_Utils(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Diagnostics_Utils ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Diagnostics_Utils ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ForceCrash = "UnityEngine.Diagnostics.Utils::ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory)";
}

