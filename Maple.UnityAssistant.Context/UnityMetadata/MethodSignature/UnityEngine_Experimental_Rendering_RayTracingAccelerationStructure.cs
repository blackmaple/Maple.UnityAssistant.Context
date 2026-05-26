namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure
{
    public const string MONO_AddInstance = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance";
    public const string MONO_AddInstanceProceduralInjected = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Injected";
    public const string MONO_AddInstanceSubMeshFlagsArray = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstanceSubMeshFlagsArray";
    public const string MONO_BuildInjected = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Build_Injected";
    public const string MONO_CreateInjected = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Create_Injected";
    public const string MONO_Destroy = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Destroy";
    public const string MONO_GetInstanceCount = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetInstanceCount";
    public const string MONO_GetSize = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetSize";
    public const string MONO_RemoveInstance = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance";
    public const string MONO_UpdateInjected = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Update_Injected";
    public const string MONO_UpdateInstanceId = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceID";
    public const string MONO_UpdateInstanceMask = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask";
    public const string MONO_UpdateInstanceTransform = "UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(nint ptr) => new Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
