namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationPlayableExtensions
{
    public const string MONO_SetAnimatedPropertiesInternal = "UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationPlayableExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationPlayableExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationPlayableExtensions(nint ptr) => new Ptr_UnityEngine_Animations_AnimationPlayableExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationPlayableExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationPlayableExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_SetAnimatedPropertiesInternal = "UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle&,UnityEngine.AnimationClip)";
}

