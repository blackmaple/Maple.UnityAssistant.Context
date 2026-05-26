namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationSceneHandleUtility
{
    public const string MONO_ReadSceneFloatsInternal = "UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneFloatsInternal";
    public const string MONO_ReadSceneIntsInternal = "UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneIntsInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationSceneHandleUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationSceneHandleUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationSceneHandleUtility(nint ptr) => new Ptr_UnityEngine_Animations_AnimationSceneHandleUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationSceneHandleUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationSceneHandleUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
