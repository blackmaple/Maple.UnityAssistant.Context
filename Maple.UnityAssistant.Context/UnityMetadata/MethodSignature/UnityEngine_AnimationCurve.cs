namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnimationCurve
{
    public const string MONO_AddKey = "UnityEngine.AnimationCurve::AddKey";
    public const string MONO_AddKeyInternalInjected = "UnityEngine.AnimationCurve::AddKey_Internal_Injected";
    public const string MONO_Evaluate = "UnityEngine.AnimationCurve::Evaluate";
    public const string MONO_GetLength = "UnityEngine.AnimationCurve::get_length";
    public const string MONO_GetPostWrapMode = "UnityEngine.AnimationCurve::get_postWrapMode";
    public const string MONO_GetPreWrapMode = "UnityEngine.AnimationCurve::get_preWrapMode";
    public const string MONO_GetKeyInjected = "UnityEngine.AnimationCurve::GetKey_Injected";
    public const string MONO_GetKeys = "UnityEngine.AnimationCurve::GetKeys";
    public const string MONO_InternalCreate = "UnityEngine.AnimationCurve::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.AnimationCurve::Internal_Destroy";
    public const string MONO_InternalEquals = "UnityEngine.AnimationCurve::Internal_Equals";
    public const string MONO_MoveKeyInjected = "UnityEngine.AnimationCurve::MoveKey_Injected";
    public const string MONO_RemoveKey = "UnityEngine.AnimationCurve::RemoveKey";
    public const string MONO_SetPostWrapMode = "UnityEngine.AnimationCurve::set_postWrapMode";
    public const string MONO_SetPreWrapMode = "UnityEngine.AnimationCurve::set_preWrapMode";
    public const string MONO_SetKeys = "UnityEngine.AnimationCurve::SetKeys";
    public const string MONO_SmoothTangents = "UnityEngine.AnimationCurve::SmoothTangents";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnimationCurve : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnimationCurve(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnimationCurve(nint ptr) => new Ptr_UnityEngine_AnimationCurve(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnimationCurve ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnimationCurve ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddKey = "UnityEngine.AnimationCurve::AddKey(System.Single,System.Single)";
    public const string IL2CPP_AddKey_Internal_Injected = "UnityEngine.AnimationCurve::AddKey_Internal_Injected(UnityEngine.Keyframe&)";
    public const string IL2CPP_Evaluate = "UnityEngine.AnimationCurve::Evaluate(System.Single)";
    public const string IL2CPP_get_length = "UnityEngine.AnimationCurve::get_length()";
    public const string IL2CPP_get_postWrapMode = "UnityEngine.AnimationCurve::get_postWrapMode()";
    public const string IL2CPP_get_preWrapMode = "UnityEngine.AnimationCurve::get_preWrapMode()";
    public const string IL2CPP_GetKey_Injected = "UnityEngine.AnimationCurve::GetKey_Injected(System.Int32,UnityEngine.Keyframe&)";
    public const string IL2CPP_GetKeys = "UnityEngine.AnimationCurve::GetKeys()";
    public const string IL2CPP_Internal_Create = "UnityEngine.AnimationCurve::Internal_Create(UnityEngine.Keyframe[])";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.AnimationCurve::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_Internal_Equals = "UnityEngine.AnimationCurve::Internal_Equals(System.IntPtr)";
    public const string IL2CPP_MoveKey_Injected = "UnityEngine.AnimationCurve::MoveKey_Injected(System.Int32,UnityEngine.Keyframe&)";
    public const string IL2CPP_RemoveKey = "UnityEngine.AnimationCurve::RemoveKey(System.Int32)";
    public const string IL2CPP_set_postWrapMode = "UnityEngine.AnimationCurve::set_postWrapMode(UnityEngine.WrapMode)";
    public const string IL2CPP_set_preWrapMode = "UnityEngine.AnimationCurve::set_preWrapMode(UnityEngine.WrapMode)";
    public const string IL2CPP_SetKeys = "UnityEngine.AnimationCurve::SetKeys(UnityEngine.Keyframe[])";
    public const string IL2CPP_SmoothTangents = "UnityEngine.AnimationCurve::SmoothTangents(System.Int32,System.Single)";
}

