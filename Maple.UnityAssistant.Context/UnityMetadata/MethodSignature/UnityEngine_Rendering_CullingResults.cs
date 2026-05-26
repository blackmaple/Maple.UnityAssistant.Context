namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_CullingResults
{
    public const string MONO_ComputeDirectionalShadowMatricesAndCullingPrimitivesInjected = "UnityEngine.Rendering.CullingResults::ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected";
    public const string MONO_ComputePointShadowMatricesAndCullingPrimitives = "UnityEngine.Rendering.CullingResults::ComputePointShadowMatricesAndCullingPrimitives";
    public const string MONO_ComputeSpotShadowMatricesAndCullingPrimitives = "UnityEngine.Rendering.CullingResults::ComputeSpotShadowMatricesAndCullingPrimitives";
    public const string MONO_FillLightAndReflectionProbeIndices = "UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndices";
    public const string MONO_FillLightAndReflectionProbeIndicesGraphicsBuffer = "UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndicesGraphicsBuffer";
    public const string MONO_FillLightIndexMap = "UnityEngine.Rendering.CullingResults::FillLightIndexMap";
    public const string MONO_FillReflectionProbeIndexMap = "UnityEngine.Rendering.CullingResults::FillReflectionProbeIndexMap";
    public const string MONO_GetLightIndexCount = "UnityEngine.Rendering.CullingResults::GetLightIndexCount";
    public const string MONO_GetLightIndexMapSize = "UnityEngine.Rendering.CullingResults::GetLightIndexMapSize";
    public const string MONO_GetReflectionProbeIndexCount = "UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexCount";
    public const string MONO_GetReflectionProbeIndexMapSize = "UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexMapSize";
    public const string MONO_GetShadowCasterBounds = "UnityEngine.Rendering.CullingResults::GetShadowCasterBounds";
    public const string MONO_SetLightIndexMap = "UnityEngine.Rendering.CullingResults::SetLightIndexMap";
    public const string MONO_SetReflectionProbeIndexMap = "UnityEngine.Rendering.CullingResults::SetReflectionProbeIndexMap";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_CullingResults : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_CullingResults(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_CullingResults(nint ptr) => new Ptr_UnityEngine_Rendering_CullingResults(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_CullingResults ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_CullingResults ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected = "UnityEngine.Rendering.CullingResults::ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(System.IntPtr,System.Int32,System.Int32,System.Int32,UnityEngine.Vector3&,System.Int32,System.Single,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Rendering.ShadowSplitData&)";
    public const string IL2CPP_ComputePointShadowMatricesAndCullingPrimitives = "UnityEngine.Rendering.CullingResults::ComputePointShadowMatricesAndCullingPrimitives(System.IntPtr,System.Int32,UnityEngine.CubemapFace,System.Single,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Rendering.ShadowSplitData&)";
    public const string IL2CPP_ComputeSpotShadowMatricesAndCullingPrimitives = "UnityEngine.Rendering.CullingResults::ComputeSpotShadowMatricesAndCullingPrimitives(System.IntPtr,System.Int32,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Rendering.ShadowSplitData&)";
    public const string IL2CPP_FillLightAndReflectionProbeIndices = "UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndices(System.IntPtr,UnityEngine.ComputeBuffer)";
    public const string IL2CPP_FillLightIndexMap = "UnityEngine.Rendering.CullingResults::FillLightIndexMap(System.IntPtr,System.IntPtr,System.Int32)";
    public const string IL2CPP_GetLightIndexCount = "UnityEngine.Rendering.CullingResults::GetLightIndexCount(System.IntPtr)";
    public const string IL2CPP_GetLightIndexMapSize = "UnityEngine.Rendering.CullingResults::GetLightIndexMapSize(System.IntPtr)";
    public const string IL2CPP_GetReflectionProbeIndexCount = "UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexCount(System.IntPtr)";
    public const string IL2CPP_GetShadowCasterBounds = "UnityEngine.Rendering.CullingResults::GetShadowCasterBounds(System.IntPtr,System.Int32,UnityEngine.Bounds&)";
    public const string IL2CPP_SetLightIndexMap = "UnityEngine.Rendering.CullingResults::SetLightIndexMap(System.IntPtr,System.IntPtr,System.Int32)";
}

