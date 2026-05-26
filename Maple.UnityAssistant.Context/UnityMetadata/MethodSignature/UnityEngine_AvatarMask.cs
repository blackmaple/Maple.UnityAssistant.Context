namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AvatarMask
{
    public const string MONO_AddTransformPath = "UnityEngine.AvatarMask::AddTransformPath";
    public const string MONO_GetHasFeetIk = "UnityEngine.AvatarMask::get_hasFeetIK";
    public const string MONO_GetTransformCount = "UnityEngine.AvatarMask::get_transformCount";
    public const string MONO_GetHumanoidBodyPartActive = "UnityEngine.AvatarMask::GetHumanoidBodyPartActive";
    public const string MONO_GetTransformPath = "UnityEngine.AvatarMask::GetTransformPath";
    public const string MONO_GetTransformWeight = "UnityEngine.AvatarMask::GetTransformWeight";
    public const string MONO_InternalCreate = "UnityEngine.AvatarMask::Internal_Create";
    public const string MONO_RemoveTransformPath = "UnityEngine.AvatarMask::RemoveTransformPath";
    public const string MONO_SetTransformCount = "UnityEngine.AvatarMask::set_transformCount";
    public const string MONO_SetHumanoidBodyPartActive = "UnityEngine.AvatarMask::SetHumanoidBodyPartActive";
    public const string MONO_SetTransformPath = "UnityEngine.AvatarMask::SetTransformPath";
    public const string MONO_SetTransformWeight = "UnityEngine.AvatarMask::SetTransformWeight";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AvatarMask : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AvatarMask(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AvatarMask(nint ptr) => new Ptr_UnityEngine_AvatarMask(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AvatarMask ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AvatarMask ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_transformCount = "UnityEngine.AvatarMask::get_transformCount()";
    public const string IL2CPP_GetHumanoidBodyPartActive = "UnityEngine.AvatarMask::GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart)";
    public const string IL2CPP_GetTransformPath = "UnityEngine.AvatarMask::GetTransformPath(System.Int32)";
    public const string IL2CPP_GetTransformWeight = "UnityEngine.AvatarMask::GetTransformWeight(System.Int32)";
}

