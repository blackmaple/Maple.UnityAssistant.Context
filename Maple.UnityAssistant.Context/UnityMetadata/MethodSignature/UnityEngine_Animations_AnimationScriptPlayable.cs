namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationScriptPlayable
{
    public const string MONO_CreateHandleInternalInjected = "UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected";
    public const string MONO_GetProcessInputsInternalInjected = "UnityEngine.Animations.AnimationScriptPlayable::GetProcessInputsInternal_Injected";
    public const string MONO_SetProcessInputsInternalInjected = "UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationScriptPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationScriptPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationScriptPlayable(nint ptr) => new Ptr_UnityEngine_Animations_AnimationScriptPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationScriptPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationScriptPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
