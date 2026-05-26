namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_PropertySceneHandle
{
    public const string MONO_GetBoolInternalInjected = "UnityEngine.Animations.PropertySceneHandle::GetBoolInternal_Injected";
    public const string MONO_GetFloatInternalInjected = "UnityEngine.Animations.PropertySceneHandle::GetFloatInternal_Injected";
    public const string MONO_GetIntInternalInjected = "UnityEngine.Animations.PropertySceneHandle::GetIntInternal_Injected";
    public const string MONO_HasValidTransformInjected = "UnityEngine.Animations.PropertySceneHandle::HasValidTransform_Injected";
    public const string MONO_IsBoundInjected = "UnityEngine.Animations.PropertySceneHandle::IsBound_Injected";
    public const string MONO_ResolveInternalInjected = "UnityEngine.Animations.PropertySceneHandle::ResolveInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_PropertySceneHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_PropertySceneHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_PropertySceneHandle(nint ptr) => new Ptr_UnityEngine_Animations_PropertySceneHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_PropertySceneHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_PropertySceneHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
