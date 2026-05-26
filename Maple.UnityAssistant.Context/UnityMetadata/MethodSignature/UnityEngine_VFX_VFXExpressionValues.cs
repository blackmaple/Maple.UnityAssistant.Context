namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_VFX_VFXExpressionValues
{
    public const string MONO_GetBool = "UnityEngine.VFX.VFXExpressionValues::GetBool";
    public const string MONO_GetFloat = "UnityEngine.VFX.VFXExpressionValues::GetFloat";
    public const string MONO_GetInt = "UnityEngine.VFX.VFXExpressionValues::GetInt";
    public const string MONO_GetMatrix4x4Injected = "UnityEngine.VFX.VFXExpressionValues::GetMatrix4x4_Injected";
    public const string MONO_GetMesh = "UnityEngine.VFX.VFXExpressionValues::GetMesh";
    public const string MONO_GetTexture = "UnityEngine.VFX.VFXExpressionValues::GetTexture";
    public const string MONO_GetUint = "UnityEngine.VFX.VFXExpressionValues::GetUInt";
    public const string MONO_GetVector2Injected = "UnityEngine.VFX.VFXExpressionValues::GetVector2_Injected";
    public const string MONO_GetVector3Injected = "UnityEngine.VFX.VFXExpressionValues::GetVector3_Injected";
    public const string MONO_GetVector4Injected = "UnityEngine.VFX.VFXExpressionValues::GetVector4_Injected";
    public const string MONO_InternalGetAnimationCurveFromScript = "UnityEngine.VFX.VFXExpressionValues::Internal_GetAnimationCurveFromScript";
    public const string MONO_InternalGetGradientFromScript = "UnityEngine.VFX.VFXExpressionValues::Internal_GetGradientFromScript";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_VFX_VFXExpressionValues : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_VFX_VFXExpressionValues(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_VFX_VFXExpressionValues(nint ptr) => new Ptr_UnityEngine_VFX_VFXExpressionValues(ptr);
        public static implicit operator nint(Ptr_UnityEngine_VFX_VFXExpressionValues ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_VFX_VFXExpressionValues ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
