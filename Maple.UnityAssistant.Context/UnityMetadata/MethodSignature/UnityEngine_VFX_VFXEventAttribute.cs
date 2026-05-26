namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_VFX_VFXEventAttribute
{
    public const string MONO_CopyValuesFrom = "UnityEngine.VFX.VFXEventAttribute::CopyValuesFrom";
    public const string MONO_GetBool = "UnityEngine.VFX.VFXEventAttribute::GetBool";
    public const string MONO_GetFloat = "UnityEngine.VFX.VFXEventAttribute::GetFloat";
    public const string MONO_GetInt = "UnityEngine.VFX.VFXEventAttribute::GetInt";
    public const string MONO_GetMatrix4x4Injected = "UnityEngine.VFX.VFXEventAttribute::GetMatrix4x4_Injected";
    public const string MONO_GetUint = "UnityEngine.VFX.VFXEventAttribute::GetUint";
    public const string MONO_GetVector2Injected = "UnityEngine.VFX.VFXEventAttribute::GetVector2_Injected";
    public const string MONO_GetVector3Injected = "UnityEngine.VFX.VFXEventAttribute::GetVector3_Injected";
    public const string MONO_GetVector4Injected = "UnityEngine.VFX.VFXEventAttribute::GetVector4_Injected";
    public const string MONO_HasBool = "UnityEngine.VFX.VFXEventAttribute::HasBool";
    public const string MONO_HasFloat = "UnityEngine.VFX.VFXEventAttribute::HasFloat";
    public const string MONO_HasInt = "UnityEngine.VFX.VFXEventAttribute::HasInt";
    public const string MONO_HasMatrix4x4 = "UnityEngine.VFX.VFXEventAttribute::HasMatrix4x4";
    public const string MONO_HasUint = "UnityEngine.VFX.VFXEventAttribute::HasUint";
    public const string MONO_HasVector2 = "UnityEngine.VFX.VFXEventAttribute::HasVector2";
    public const string MONO_HasVector3 = "UnityEngine.VFX.VFXEventAttribute::HasVector3";
    public const string MONO_HasVector4 = "UnityEngine.VFX.VFXEventAttribute::HasVector4";
    public const string MONO_InternalCreate = "UnityEngine.VFX.VFXEventAttribute::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.VFX.VFXEventAttribute::Internal_Destroy";
    public const string MONO_InternalInitFromAsset = "UnityEngine.VFX.VFXEventAttribute::Internal_InitFromAsset";
    public const string MONO_InternalInitFromEventAttribute = "UnityEngine.VFX.VFXEventAttribute::Internal_InitFromEventAttribute";
    public const string MONO_SetBool = "UnityEngine.VFX.VFXEventAttribute::SetBool";
    public const string MONO_SetFloat = "UnityEngine.VFX.VFXEventAttribute::SetFloat";
    public const string MONO_SetInt = "UnityEngine.VFX.VFXEventAttribute::SetInt";
    public const string MONO_SetMatrix4x4Injected = "UnityEngine.VFX.VFXEventAttribute::SetMatrix4x4_Injected";
    public const string MONO_SetUint = "UnityEngine.VFX.VFXEventAttribute::SetUint";
    public const string MONO_SetVector2Injected = "UnityEngine.VFX.VFXEventAttribute::SetVector2_Injected";
    public const string MONO_SetVector3Injected = "UnityEngine.VFX.VFXEventAttribute::SetVector3_Injected";
    public const string MONO_SetVector4Injected = "UnityEngine.VFX.VFXEventAttribute::SetVector4_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_VFX_VFXEventAttribute : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_VFX_VFXEventAttribute(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_VFX_VFXEventAttribute(nint ptr) => new Ptr_UnityEngine_VFX_VFXEventAttribute(ptr);
        public static implicit operator nint(Ptr_UnityEngine_VFX_VFXEventAttribute ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_VFX_VFXEventAttribute ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_Create = "UnityEngine.VFX.VFXEventAttribute::Internal_Create()";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.VFX.VFXEventAttribute::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_Internal_InitFromAsset = "UnityEngine.VFX.VFXEventAttribute::Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset)";
}

