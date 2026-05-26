namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ClusterInput
{
    public const string MONO_AddInput = "UnityEngine.ClusterInput::AddInput";
    public const string MONO_CheckConnectionToServer = "UnityEngine.ClusterInput::CheckConnectionToServer";
    public const string MONO_EditInput = "UnityEngine.ClusterInput::EditInput";
    public const string MONO_GetAxis = "UnityEngine.ClusterInput::GetAxis";
    public const string MONO_GetButton = "UnityEngine.ClusterInput::GetButton";
    public const string MONO_GetTrackerPositionInjected = "UnityEngine.ClusterInput::GetTrackerPosition_Injected";
    public const string MONO_GetTrackerRotationInjected = "UnityEngine.ClusterInput::GetTrackerRotation_Injected";
    public const string MONO_SetAxis = "UnityEngine.ClusterInput::SetAxis";
    public const string MONO_SetButton = "UnityEngine.ClusterInput::SetButton";
    public const string MONO_SetTrackerPositionInjected = "UnityEngine.ClusterInput::SetTrackerPosition_Injected";
    public const string MONO_SetTrackerRotationInjected = "UnityEngine.ClusterInput::SetTrackerRotation_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ClusterInput : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ClusterInput(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ClusterInput(nint ptr) => new Ptr_UnityEngine_ClusterInput(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ClusterInput ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ClusterInput ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
