namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_XR_Bone
{
    public const string MONO_BoneTryGetChildBonesInjected = "UnityEngine.XR.Bone::Bone_TryGetChildBones_Injected";
    public const string MONO_BoneTryGetParentBoneInjected = "UnityEngine.XR.Bone::Bone_TryGetParentBone_Injected";
    public const string MONO_BoneTryGetPositionInjected = "UnityEngine.XR.Bone::Bone_TryGetPosition_Injected";
    public const string MONO_BoneTryGetRotationInjected = "UnityEngine.XR.Bone::Bone_TryGetRotation_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_XR_Bone : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_XR_Bone(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_XR_Bone(nint ptr) => new Ptr_UnityEngine_XR_Bone(ptr);
        public static implicit operator nint(Ptr_UnityEngine_XR_Bone ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_XR_Bone ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
