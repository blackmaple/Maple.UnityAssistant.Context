namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Rendering_RayTracingShader
{
    public const string MONO_Dispatch = "UnityEngine.Experimental.Rendering.RayTracingShader::Dispatch";
    public const string MONO_GetMaxRecursionDepth = "UnityEngine.Experimental.Rendering.RayTracingShader::get_maxRecursionDepth";
    public const string MONO_SetAccelerationStructure = "UnityEngine.Experimental.Rendering.RayTracingShader::SetAccelerationStructure";
    public const string MONO_SetBuffer = "UnityEngine.Experimental.Rendering.RayTracingShader::SetBuffer";
    public const string MONO_SetConstantComputeBuffer = "UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantComputeBuffer";
    public const string MONO_SetConstantGraphicsBuffer = "UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantGraphicsBuffer";
    public const string MONO_SetFloat = "UnityEngine.Experimental.Rendering.RayTracingShader::SetFloat";
    public const string MONO_SetFloatArray = "UnityEngine.Experimental.Rendering.RayTracingShader::SetFloatArray";
    public const string MONO_SetGraphicsBuffer = "UnityEngine.Experimental.Rendering.RayTracingShader::SetGraphicsBuffer";
    public const string MONO_SetInt = "UnityEngine.Experimental.Rendering.RayTracingShader::SetInt";
    public const string MONO_SetIntArray = "UnityEngine.Experimental.Rendering.RayTracingShader::SetIntArray";
    public const string MONO_SetMatrixInjected = "UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrix_Injected";
    public const string MONO_SetMatrixArray = "UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrixArray";
    public const string MONO_SetShaderPass = "UnityEngine.Experimental.Rendering.RayTracingShader::SetShaderPass";
    public const string MONO_SetTexture = "UnityEngine.Experimental.Rendering.RayTracingShader::SetTexture";
    public const string MONO_SetTextureFromGlobal = "UnityEngine.Experimental.Rendering.RayTracingShader::SetTextureFromGlobal";
    public const string MONO_SetVectorInjected = "UnityEngine.Experimental.Rendering.RayTracingShader::SetVector_Injected";
    public const string MONO_SetVectorArray = "UnityEngine.Experimental.Rendering.RayTracingShader::SetVectorArray";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Rendering_RayTracingShader : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Rendering_RayTracingShader(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Rendering_RayTracingShader(nint ptr) => new Ptr_UnityEngine_Experimental_Rendering_RayTracingShader(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Rendering_RayTracingShader ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Rendering_RayTracingShader ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
