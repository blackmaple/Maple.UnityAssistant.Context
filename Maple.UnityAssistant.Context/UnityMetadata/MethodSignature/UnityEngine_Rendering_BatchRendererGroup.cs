namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_BatchRendererGroup
{
    public const string MONO_AddBatchInjected = "UnityEngine.Rendering.BatchRendererGroup::AddBatch_Injected";
    public const string MONO_Create = "UnityEngine.Rendering.BatchRendererGroup::Create";
    public const string MONO_Destroy = "UnityEngine.Rendering.BatchRendererGroup::Destroy";
    public const string MONO_EnableVisibleIndicesYarray = "UnityEngine.Rendering.BatchRendererGroup::EnableVisibleIndicesYArray";
    public const string MONO_GetBatchMatrices = "UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrices";
    public const string MONO_GetBatchMatrixArray = "UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray";
    public const string MONO_GetBatchMatrixArrayInternal = "UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray_Internal";
    public const string MONO_GetBatchScalarArray = "UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray";
    public const string MONO_GetBatchScalarArrayInternal = "UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray_Internal";
    public const string MONO_GetBatchVectorArray = "UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray";
    public const string MONO_GetBatchVectorArrayInternal = "UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray_Internal";
    public const string MONO_GetNumBatches = "UnityEngine.Rendering.BatchRendererGroup::GetNumBatches";
    public const string MONO_InternalSetBatchPropertyMetadata = "UnityEngine.Rendering.BatchRendererGroup::InternalSetBatchPropertyMetadata";
    public const string MONO_RemoveBatch = "UnityEngine.Rendering.BatchRendererGroup::RemoveBatch";
    public const string MONO_SetBatchBoundsInjected = "UnityEngine.Rendering.BatchRendererGroup::SetBatchBounds_Injected";
    public const string MONO_SetBatchFlags = "UnityEngine.Rendering.BatchRendererGroup::SetBatchFlags";
    public const string MONO_SetInstancingData = "UnityEngine.Rendering.BatchRendererGroup::SetInstancingData";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_BatchRendererGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_BatchRendererGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_BatchRendererGroup(nint ptr) => new Ptr_UnityEngine_Rendering_BatchRendererGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_BatchRendererGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_BatchRendererGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
