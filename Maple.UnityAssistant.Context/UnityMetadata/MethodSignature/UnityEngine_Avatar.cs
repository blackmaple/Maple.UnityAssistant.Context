namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Avatar
{
    public const string MONO_GetHumanDescriptionInjected = "UnityEngine.Avatar::get_humanDescription_Injected";
    public const string MONO_GetIsHuman = "UnityEngine.Avatar::get_isHuman";
    public const string MONO_GetIsValid = "UnityEngine.Avatar::get_isValid";
    public const string MONO_InternalGetAxisLength = "UnityEngine.Avatar::Internal_GetAxisLength";
    public const string MONO_InternalGetLimitSignInjected = "UnityEngine.Avatar::Internal_GetLimitSign_Injected";
    public const string MONO_InternalGetPostRotationInjected = "UnityEngine.Avatar::Internal_GetPostRotation_Injected";
    public const string MONO_InternalGetPreRotationInjected = "UnityEngine.Avatar::Internal_GetPreRotation_Injected";
    public const string MONO_InternalGetZypostQInjected = "UnityEngine.Avatar::Internal_GetZYPostQ_Injected";
    public const string MONO_InternalGetZyrollInjected = "UnityEngine.Avatar::Internal_GetZYRoll_Injected";
    public const string MONO_SetMuscleMinMax = "UnityEngine.Avatar::SetMuscleMinMax";
    public const string MONO_SetParameter = "UnityEngine.Avatar::SetParameter";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Avatar : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Avatar(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Avatar(nint ptr) => new Ptr_UnityEngine_Avatar(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Avatar ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Avatar ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_humanDescription_Injected = "UnityEngine.Avatar::get_humanDescription_Injected(UnityEngine.HumanDescription&)";
}

