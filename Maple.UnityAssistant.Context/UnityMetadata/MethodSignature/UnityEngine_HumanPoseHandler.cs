namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HumanPoseHandler
{
    public const string MONO_GetHumanPose = "UnityEngine.HumanPoseHandler::GetHumanPose";
    public const string MONO_GetInternalAvatarPose = "UnityEngine.HumanPoseHandler::GetInternalAvatarPose";
    public const string MONO_GetInternalHumanPose = "UnityEngine.HumanPoseHandler::GetInternalHumanPose";
    public const string MONO_InternalCreateFromJointPaths = "UnityEngine.HumanPoseHandler::Internal_CreateFromJointPaths";
    public const string MONO_InternalCreateFromRoot = "UnityEngine.HumanPoseHandler::Internal_CreateFromRoot";
    public const string MONO_InternalDestroy = "UnityEngine.HumanPoseHandler::Internal_Destroy";
    public const string MONO_SetHumanPose = "UnityEngine.HumanPoseHandler::SetHumanPose";
    public const string MONO_SetInternalAvatarPose = "UnityEngine.HumanPoseHandler::SetInternalAvatarPose";
    public const string MONO_SetInternalHumanPose = "UnityEngine.HumanPoseHandler::SetInternalHumanPose";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HumanPoseHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HumanPoseHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HumanPoseHandler(nint ptr) => new Ptr_UnityEngine_HumanPoseHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HumanPoseHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HumanPoseHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
