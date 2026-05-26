namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AvatarBuilder
{
    public const string MONO_BuildGenericAvatar = "UnityEngine.AvatarBuilder::BuildGenericAvatar";
    public const string MONO_BuildHumanAvatarInternalInjected = "UnityEngine.AvatarBuilder::BuildHumanAvatarInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AvatarBuilder : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AvatarBuilder(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AvatarBuilder(nint ptr) => new Ptr_UnityEngine_AvatarBuilder(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AvatarBuilder ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AvatarBuilder ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
