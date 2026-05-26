namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimatorJobExtensions
{
    public const string MONO_InternalAddJobDependencyInjected = "UnityEngine.Animations.AnimatorJobExtensions::InternalAddJobDependency_Injected";
    public const string MONO_InternalBindCustomStreamProperty = "UnityEngine.Animations.AnimatorJobExtensions::InternalBindCustomStreamProperty";
    public const string MONO_InternalBindSceneProperty = "UnityEngine.Animations.AnimatorJobExtensions::InternalBindSceneProperty";
    public const string MONO_InternalBindSceneTransform = "UnityEngine.Animations.AnimatorJobExtensions::InternalBindSceneTransform";
    public const string MONO_InternalBindStreamProperty = "UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamProperty";
    public const string MONO_InternalBindStreamTransform = "UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamTransform";
    public const string MONO_InternalCloseAnimationStream = "UnityEngine.Animations.AnimatorJobExtensions::InternalCloseAnimationStream";
    public const string MONO_InternalOpenAnimationStream = "UnityEngine.Animations.AnimatorJobExtensions::InternalOpenAnimationStream";
    public const string MONO_InternalResolveAllSceneHandles = "UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllSceneHandles";
    public const string MONO_InternalResolveAllStreamHandles = "UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllStreamHandles";
    public const string MONO_InternalUnbindAllSceneHandles = "UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllSceneHandles";
    public const string MONO_InternalUnbindAllStreamHandles = "UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllStreamHandles";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimatorJobExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimatorJobExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimatorJobExtensions(nint ptr) => new Ptr_UnityEngine_Animations_AnimatorJobExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimatorJobExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimatorJobExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
