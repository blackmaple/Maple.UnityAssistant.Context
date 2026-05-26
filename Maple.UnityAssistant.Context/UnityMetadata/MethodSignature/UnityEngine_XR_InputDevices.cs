namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_InputDevices
{
    public const string MONO_GetDeviceCharacteristics = "UnityEngine.XR.InputDevices::GetDeviceCharacteristics";
    public const string MONO_GetDeviceManufacturer = "UnityEngine.XR.InputDevices::GetDeviceManufacturer";
    public const string MONO_GetDeviceName = "UnityEngine.XR.InputDevices::GetDeviceName";
    public const string MONO_GetDevicesInternal = "UnityEngine.XR.InputDevices::GetDevices_Internal";
    public const string MONO_GetDeviceSerialNumber = "UnityEngine.XR.InputDevices::GetDeviceSerialNumber";
    public const string MONO_IsDeviceValid = "UnityEngine.XR.InputDevices::IsDeviceValid";
    public const string MONO_SendHapticBuffer = "UnityEngine.XR.InputDevices::SendHapticBuffer";
    public const string MONO_SendHapticImpulse = "UnityEngine.XR.InputDevices::SendHapticImpulse";
    public const string MONO_StopHaptics = "UnityEngine.XR.InputDevices::StopHaptics";
    public const string MONO_TryGetFeatureUsages = "UnityEngine.XR.InputDevices::TryGetFeatureUsages";
    public const string MONO_TryGetFeatureValueBool = "UnityEngine.XR.InputDevices::TryGetFeatureValue_bool";
    public const string MONO_TryGetFeatureValueCustom = "UnityEngine.XR.InputDevices::TryGetFeatureValue_Custom";
    public const string MONO_TryGetFeatureValueFloat = "UnityEngine.XR.InputDevices::TryGetFeatureValue_float";
    public const string MONO_TryGetFeatureValueQuaternionf = "UnityEngine.XR.InputDevices::TryGetFeatureValue_Quaternionf";
    public const string MONO_TryGetFeatureValueUint32 = "UnityEngine.XR.InputDevices::TryGetFeatureValue_UInt32";
    public const string MONO_TryGetFeatureValueVector2f = "UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector2f";
    public const string MONO_TryGetFeatureValueVector3f = "UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector3f";
    public const string MONO_TryGetFeatureValueXrbone = "UnityEngine.XR.InputDevices::TryGetFeatureValue_XRBone";
    public const string MONO_TryGetFeatureValueXreyes = "UnityEngine.XR.InputDevices::TryGetFeatureValue_XREyes";
    public const string MONO_TryGetFeatureValueXrhand = "UnityEngine.XR.InputDevices::TryGetFeatureValue_XRHand";
    public const string MONO_TryGetFeatureValueAtTimeBool = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_bool";
    public const string MONO_TryGetFeatureValueAtTimeFloat = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_float";
    public const string MONO_TryGetFeatureValueAtTimeQuaternionf = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Quaternionf";
    public const string MONO_TryGetFeatureValueAtTimeUint32 = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_UInt32";
    public const string MONO_TryGetFeatureValueAtTimeVector2f = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector2f";
    public const string MONO_TryGetFeatureValueAtTimeVector3f = "UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector3f";
    public const string MONO_TryGetHapticCapabilities = "UnityEngine.XR.InputDevices::TryGetHapticCapabilities";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_InputDevices : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_InputDevices(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_InputDevices(nint ptr) => new Ptr_UnityEngine_XR_InputDevices(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_InputDevices ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_InputDevices ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
