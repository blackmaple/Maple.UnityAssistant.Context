namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnimationState
{
    public const string MONO_AddMixingTransform = "UnityEngine.AnimationState::AddMixingTransform";
    public const string MONO_GetBlendMode = "UnityEngine.AnimationState::get_blendMode";
    public const string MONO_GetClip = "UnityEngine.AnimationState::get_clip";
    public const string MONO_GetEnabled = "UnityEngine.AnimationState::get_enabled";
    public const string MONO_GetLayer = "UnityEngine.AnimationState::get_layer";
    public const string MONO_GetLength = "UnityEngine.AnimationState::get_length";
    public const string MONO_GetName = "UnityEngine.AnimationState::get_name";
    public const string MONO_GetNormalizedSpeed = "UnityEngine.AnimationState::get_normalizedSpeed";
    public const string MONO_GetNormalizedTime = "UnityEngine.AnimationState::get_normalizedTime";
    public const string MONO_GetSpeed = "UnityEngine.AnimationState::get_speed";
    public const string MONO_GetTime = "UnityEngine.AnimationState::get_time";
    public const string MONO_GetWeight = "UnityEngine.AnimationState::get_weight";
    public const string MONO_GetWrapMode = "UnityEngine.AnimationState::get_wrapMode";
    public const string MONO_RemoveMixingTransform = "UnityEngine.AnimationState::RemoveMixingTransform";
    public const string MONO_SetBlendMode = "UnityEngine.AnimationState::set_blendMode";
    public const string MONO_SetEnabled = "UnityEngine.AnimationState::set_enabled";
    public const string MONO_SetLayer = "UnityEngine.AnimationState::set_layer";
    public const string MONO_SetName = "UnityEngine.AnimationState::set_name";
    public const string MONO_SetNormalizedSpeed = "UnityEngine.AnimationState::set_normalizedSpeed";
    public const string MONO_SetNormalizedTime = "UnityEngine.AnimationState::set_normalizedTime";
    public const string MONO_SetSpeed = "UnityEngine.AnimationState::set_speed";
    public const string MONO_SetTime = "UnityEngine.AnimationState::set_time";
    public const string MONO_SetWeight = "UnityEngine.AnimationState::set_weight";
    public const string MONO_SetWrapMode = "UnityEngine.AnimationState::set_wrapMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnimationState : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnimationState(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnimationState(nint ptr) => new Ptr_UnityEngine_AnimationState(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnimationState ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnimationState ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_clip = "UnityEngine.AnimationState::get_clip()";
    public const string IL2CPP_get_length = "UnityEngine.AnimationState::get_length()";
    public const string IL2CPP_get_name = "UnityEngine.AnimationState::get_name()";
}

