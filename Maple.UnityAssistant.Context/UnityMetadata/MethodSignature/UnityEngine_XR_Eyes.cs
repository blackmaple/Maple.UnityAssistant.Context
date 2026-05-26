namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_Eyes
{
    public const string MONO_EyesTryGetEyeOpenAmountInjected = "UnityEngine.XR.Eyes::Eyes_TryGetEyeOpenAmount_Injected";
    public const string MONO_EyesTryGetEyePositionInjected = "UnityEngine.XR.Eyes::Eyes_TryGetEyePosition_Injected";
    public const string MONO_EyesTryGetEyeRotationInjected = "UnityEngine.XR.Eyes::Eyes_TryGetEyeRotation_Injected";
    public const string MONO_EyesTryGetFixationPointInjected = "UnityEngine.XR.Eyes::Eyes_TryGetFixationPoint_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_Eyes : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_Eyes(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_Eyes(nint ptr) => new Ptr_UnityEngine_XR_Eyes(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_Eyes ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_Eyes ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
