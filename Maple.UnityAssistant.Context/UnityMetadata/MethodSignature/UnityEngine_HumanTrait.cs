namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HumanTrait
{
    public const string MONO_GetBoneCount = "UnityEngine.HumanTrait::get_BoneCount";
    public const string MONO_GetBoneName = "UnityEngine.HumanTrait::get_BoneName";
    public const string MONO_GetMuscleCount = "UnityEngine.HumanTrait::get_MuscleCount";
    public const string MONO_GetMuscleName = "UnityEngine.HumanTrait::get_MuscleName";
    public const string MONO_GetRequiredBoneCount = "UnityEngine.HumanTrait::get_RequiredBoneCount";
    public const string MONO_GetBoneIndexFromMono = "UnityEngine.HumanTrait::GetBoneIndexFromMono";
    public const string MONO_GetBoneIndexToMono = "UnityEngine.HumanTrait::GetBoneIndexToMono";
    public const string MONO_GetMuscleDefaultMax = "UnityEngine.HumanTrait::GetMuscleDefaultMax";
    public const string MONO_GetMuscleDefaultMin = "UnityEngine.HumanTrait::GetMuscleDefaultMin";
    public const string MONO_InternalBoneFromMuscle = "UnityEngine.HumanTrait::Internal_BoneFromMuscle";
    public const string MONO_InternalGetBoneHierarchyMass = "UnityEngine.HumanTrait::Internal_GetBoneHierarchyMass";
    public const string MONO_InternalGetParent = "UnityEngine.HumanTrait::Internal_GetParent";
    public const string MONO_InternalMuscleFromBone = "UnityEngine.HumanTrait::Internal_MuscleFromBone";
    public const string MONO_InternalRequiredBone = "UnityEngine.HumanTrait::Internal_RequiredBone";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HumanTrait : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HumanTrait(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HumanTrait(nint ptr) => new Ptr_UnityEngine_HumanTrait(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HumanTrait ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HumanTrait ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
