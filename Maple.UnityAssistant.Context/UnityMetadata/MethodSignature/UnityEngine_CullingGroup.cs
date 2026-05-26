namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CullingGroup
{
    public const string MONO_DisposeInternal = "UnityEngine.CullingGroup::DisposeInternal";
    public const string MONO_EraseSwapBack = "UnityEngine.CullingGroup::EraseSwapBack";
    public const string MONO_FinalizerFailure = "UnityEngine.CullingGroup::FinalizerFailure";
    public const string MONO_GetEnabled = "UnityEngine.CullingGroup::get_enabled";
    public const string MONO_GetTargetCamera = "UnityEngine.CullingGroup::get_targetCamera";
    public const string MONO_GetDistance = "UnityEngine.CullingGroup::GetDistance";
    public const string MONO_Init = "UnityEngine.CullingGroup::Init";
    public const string MONO_IsVisible = "UnityEngine.CullingGroup::IsVisible";
    public const string MONO_QueryIndices = "UnityEngine.CullingGroup::QueryIndices";
    public const string MONO_SetEnabled = "UnityEngine.CullingGroup::set_enabled";
    public const string MONO_SetTargetCamera = "UnityEngine.CullingGroup::set_targetCamera";
    public const string MONO_SetBoundingDistances = "UnityEngine.CullingGroup::SetBoundingDistances";
    public const string MONO_SetBoundingSphereCount = "UnityEngine.CullingGroup::SetBoundingSphereCount";
    public const string MONO_SetBoundingSpheres = "UnityEngine.CullingGroup::SetBoundingSpheres";
    public const string MONO_SetDistanceReferencePointInternalTransform = "UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform";
    public const string MONO_SetDistanceReferencePointInternalVector3Injected = "UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalVector3_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CullingGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CullingGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CullingGroup(nint ptr) => new Ptr_UnityEngine_CullingGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CullingGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CullingGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DisposeInternal = "UnityEngine.CullingGroup::DisposeInternal()";
    public const string IL2CPP_FinalizerFailure = "UnityEngine.CullingGroup::FinalizerFailure()";
    public const string IL2CPP_Init = "UnityEngine.CullingGroup::Init(System.Object)";
    public const string IL2CPP_QueryIndices = "UnityEngine.CullingGroup::QueryIndices(System.Boolean,System.Int32,UnityEngine.CullingQueryOptions,System.Int32[],System.Int32)";
    public const string IL2CPP_set_targetCamera = "UnityEngine.CullingGroup::set_targetCamera(UnityEngine.Camera)";
    public const string IL2CPP_SetBoundingDistances = "UnityEngine.CullingGroup::SetBoundingDistances(System.Single[])";
    public const string IL2CPP_SetBoundingSphereCount = "UnityEngine.CullingGroup::SetBoundingSphereCount(System.Int32)";
    public const string IL2CPP_SetBoundingSpheres = "UnityEngine.CullingGroup::SetBoundingSpheres(UnityEngine.BoundingSphere[])";
    public const string IL2CPP_SetDistanceReferencePoint_InternalVector3_Injected = "UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalVector3_Injected(UnityEngine.Vector3&)";
}

