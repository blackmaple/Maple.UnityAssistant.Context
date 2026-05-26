namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ComputeShader
{
    public const string MONO_DisableKeyword = "UnityEngine.ComputeShader::DisableKeyword";
    public const string MONO_DisableLocalKeywordInjected = "UnityEngine.ComputeShader::DisableLocalKeyword_Injected";
    public const string MONO_Dispatch = "UnityEngine.ComputeShader::Dispatch";
    public const string MONO_EnableKeyword = "UnityEngine.ComputeShader::EnableKeyword";
    public const string MONO_EnableLocalKeywordInjected = "UnityEngine.ComputeShader::EnableLocalKeyword_Injected";
    public const string MONO_FindKernel = "UnityEngine.ComputeShader::FindKernel";
    public const string MONO_GetKeywordSpaceInjected = "UnityEngine.ComputeShader::get_keywordSpace_Injected";
    public const string MONO_GetEnabledKeywords = "UnityEngine.ComputeShader::GetEnabledKeywords";
    public const string MONO_GetKernelThreadGroupSizes = "UnityEngine.ComputeShader::GetKernelThreadGroupSizes";
    public const string MONO_GetShaderKeywords = "UnityEngine.ComputeShader::GetShaderKeywords";
    public const string MONO_HasKernel = "UnityEngine.ComputeShader::HasKernel";
    public const string MONO_InternalDispatchIndirect = "UnityEngine.ComputeShader::Internal_DispatchIndirect";
    public const string MONO_InternalDispatchIndirectGraphicsBuffer = "UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer";
    public const string MONO_InternalSetBuffer = "UnityEngine.ComputeShader::Internal_SetBuffer";
    public const string MONO_InternalSetGraphicsBuffer = "UnityEngine.ComputeShader::Internal_SetGraphicsBuffer";
    public const string MONO_IsKeywordEnabled = "UnityEngine.ComputeShader::IsKeywordEnabled";
    public const string MONO_IsLocalKeywordEnabledInjected = "UnityEngine.ComputeShader::IsLocalKeywordEnabled_Injected";
    public const string MONO_IsSupported = "UnityEngine.ComputeShader::IsSupported";
    public const string MONO_SetConstantComputeBuffer = "UnityEngine.ComputeShader::SetConstantComputeBuffer";
    public const string MONO_SetConstantGraphicsBuffer = "UnityEngine.ComputeShader::SetConstantGraphicsBuffer";
    public const string MONO_SetEnabledKeywords = "UnityEngine.ComputeShader::SetEnabledKeywords";
    public const string MONO_SetFloat = "UnityEngine.ComputeShader::SetFloat";
    public const string MONO_SetFloatArray = "UnityEngine.ComputeShader::SetFloatArray";
    public const string MONO_SetInt = "UnityEngine.ComputeShader::SetInt";
    public const string MONO_SetIntArray = "UnityEngine.ComputeShader::SetIntArray";
    public const string MONO_SetLocalKeywordInjected = "UnityEngine.ComputeShader::SetLocalKeyword_Injected";
    public const string MONO_SetMatrixInjected = "UnityEngine.ComputeShader::SetMatrix_Injected";
    public const string MONO_SetMatrixArray = "UnityEngine.ComputeShader::SetMatrixArray";
    public const string MONO_SetRenderTexture = "UnityEngine.ComputeShader::SetRenderTexture";
    public const string MONO_SetShaderKeywords = "UnityEngine.ComputeShader::SetShaderKeywords";
    public const string MONO_SetTexture = "UnityEngine.ComputeShader::SetTexture";
    public const string MONO_SetTextureFromGlobal = "UnityEngine.ComputeShader::SetTextureFromGlobal";
    public const string MONO_SetVectorInjected = "UnityEngine.ComputeShader::SetVector_Injected";
    public const string MONO_SetVectorArray = "UnityEngine.ComputeShader::SetVectorArray";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ComputeShader : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ComputeShader(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ComputeShader(nint ptr) => new Ptr_UnityEngine_ComputeShader(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ComputeShader ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ComputeShader ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DisableKeyword = "UnityEngine.ComputeShader::DisableKeyword(System.String)";
    public const string IL2CPP_EnableKeyword = "UnityEngine.ComputeShader::EnableKeyword(System.String)";
    public const string IL2CPP_FindKernel = "UnityEngine.ComputeShader::FindKernel(System.String)";
    public const string IL2CPP_SetConstantComputeBuffer = "UnityEngine.ComputeShader::SetConstantComputeBuffer(System.Int32,UnityEngine.ComputeBuffer,System.Int32,System.Int32)";
}

