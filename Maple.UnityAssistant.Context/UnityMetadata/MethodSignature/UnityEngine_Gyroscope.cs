namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Gyroscope
{
    public const string MONO_AttitudeInternalInjected = "UnityEngine.Gyroscope::attitude_Internal_Injected";
    public const string MONO_GetEnabledInternal = "UnityEngine.Gyroscope::getEnabled_Internal";
    public const string MONO_GetUpdateIntervalInternal = "UnityEngine.Gyroscope::getUpdateInterval_Internal";
    public const string MONO_GravityInternalInjected = "UnityEngine.Gyroscope::gravity_Internal_Injected";
    public const string MONO_RotationRateInternalInjected = "UnityEngine.Gyroscope::rotationRate_Internal_Injected";
    public const string MONO_RotationRateUnbiasedInternalInjected = "UnityEngine.Gyroscope::rotationRateUnbiased_Internal_Injected";
    public const string MONO_SetEnabledInternal = "UnityEngine.Gyroscope::setEnabled_Internal";
    public const string MONO_SetUpdateIntervalInternal = "UnityEngine.Gyroscope::setUpdateInterval_Internal";
    public const string MONO_UserAccelerationInternalInjected = "UnityEngine.Gyroscope::userAcceleration_Internal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Gyroscope : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Gyroscope(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Gyroscope(nint ptr) => new Ptr_UnityEngine_Gyroscope(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Gyroscope ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Gyroscope ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
