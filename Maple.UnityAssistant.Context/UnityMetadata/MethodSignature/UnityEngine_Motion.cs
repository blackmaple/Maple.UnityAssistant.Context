namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Motion
{
    public const string MONO_GetApparentSpeed = "UnityEngine.Motion::get_apparentSpeed";
    public const string MONO_GetAverageAngularSpeed = "UnityEngine.Motion::get_averageAngularSpeed";
    public const string MONO_GetAverageDuration = "UnityEngine.Motion::get_averageDuration";
    public const string MONO_GetAverageSpeedInjected = "UnityEngine.Motion::get_averageSpeed_Injected";
    public const string MONO_GetIsHumanMotion = "UnityEngine.Motion::get_isHumanMotion";
    public const string MONO_GetIsLooping = "UnityEngine.Motion::get_isLooping";
    public const string MONO_GetLegacy = "UnityEngine.Motion::get_legacy";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Motion : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Motion(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Motion(nint ptr) => new Ptr_UnityEngine_Motion(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Motion ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Motion ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_isLooping = "UnityEngine.Motion::get_isLooping()";
}

