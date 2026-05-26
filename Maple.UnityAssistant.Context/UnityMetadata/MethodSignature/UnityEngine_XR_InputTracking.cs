namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_InputTracking
{
    public const string MONO_GetDisablePositionalTracking = "UnityEngine.XR.InputTracking::get_disablePositionalTracking";
    public const string MONO_GetDeviceIdAtXrnode = "UnityEngine.XR.InputTracking::GetDeviceIdAtXRNode";
    public const string MONO_GetDeviceIdsAtXrnodeInternal = "UnityEngine.XR.InputTracking::GetDeviceIdsAtXRNode_Internal";
    public const string MONO_GetLocalPositionInjected = "UnityEngine.XR.InputTracking::GetLocalPosition_Injected";
    public const string MONO_GetLocalRotationInjected = "UnityEngine.XR.InputTracking::GetLocalRotation_Injected";
    public const string MONO_GetNodeName = "UnityEngine.XR.InputTracking::GetNodeName";
    public const string MONO_GetNodeStatesInternal = "UnityEngine.XR.InputTracking::GetNodeStates_Internal";
    public const string MONO_Recenter = "UnityEngine.XR.InputTracking::Recenter";
    public const string MONO_SetDisablePositionalTracking = "UnityEngine.XR.InputTracking::set_disablePositionalTracking";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_InputTracking : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_InputTracking(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_InputTracking(nint ptr) => new Ptr_UnityEngine_XR_InputTracking(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_InputTracking ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_InputTracking ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
