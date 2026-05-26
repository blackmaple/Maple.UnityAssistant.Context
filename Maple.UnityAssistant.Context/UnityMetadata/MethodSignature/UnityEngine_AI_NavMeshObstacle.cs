namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMeshObstacle
{
    public const string MONO_FitExtents = "UnityEngine.AI.NavMeshObstacle::FitExtents";
    public const string MONO_GetCarveOnlyStationary = "UnityEngine.AI.NavMeshObstacle::get_carveOnlyStationary";
    public const string MONO_GetCarving = "UnityEngine.AI.NavMeshObstacle::get_carving";
    public const string MONO_GetCarvingMoveThreshold = "UnityEngine.AI.NavMeshObstacle::get_carvingMoveThreshold";
    public const string MONO_GetCarvingTimeToStationary = "UnityEngine.AI.NavMeshObstacle::get_carvingTimeToStationary";
    public const string MONO_GetCenterInjected = "UnityEngine.AI.NavMeshObstacle::get_center_Injected";
    public const string MONO_GetHeight = "UnityEngine.AI.NavMeshObstacle::get_height";
    public const string MONO_GetRadius = "UnityEngine.AI.NavMeshObstacle::get_radius";
    public const string MONO_GetShape = "UnityEngine.AI.NavMeshObstacle::get_shape";
    public const string MONO_GetSizeInjected = "UnityEngine.AI.NavMeshObstacle::get_size_Injected";
    public const string MONO_GetVelocityInjected = "UnityEngine.AI.NavMeshObstacle::get_velocity_Injected";
    public const string MONO_SetCarveOnlyStationary = "UnityEngine.AI.NavMeshObstacle::set_carveOnlyStationary";
    public const string MONO_SetCarving = "UnityEngine.AI.NavMeshObstacle::set_carving";
    public const string MONO_SetCarvingMoveThreshold = "UnityEngine.AI.NavMeshObstacle::set_carvingMoveThreshold";
    public const string MONO_SetCarvingTimeToStationary = "UnityEngine.AI.NavMeshObstacle::set_carvingTimeToStationary";
    public const string MONO_SetCenterInjected = "UnityEngine.AI.NavMeshObstacle::set_center_Injected";
    public const string MONO_SetHeight = "UnityEngine.AI.NavMeshObstacle::set_height";
    public const string MONO_SetRadius = "UnityEngine.AI.NavMeshObstacle::set_radius";
    public const string MONO_SetShape = "UnityEngine.AI.NavMeshObstacle::set_shape";
    public const string MONO_SetSizeInjected = "UnityEngine.AI.NavMeshObstacle::set_size_Injected";
    public const string MONO_SetVelocityInjected = "UnityEngine.AI.NavMeshObstacle::set_velocity_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMeshObstacle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMeshObstacle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMeshObstacle(nint ptr) => new Ptr_UnityEngine_AI_NavMeshObstacle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMeshObstacle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMeshObstacle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_FitExtents = "UnityEngine.AI.NavMeshObstacle::FitExtents()";
    public const string IL2CPP_get_carveOnlyStationary = "UnityEngine.AI.NavMeshObstacle::get_carveOnlyStationary()";
    public const string IL2CPP_get_carving = "UnityEngine.AI.NavMeshObstacle::get_carving()";
    public const string IL2CPP_get_carvingMoveThreshold = "UnityEngine.AI.NavMeshObstacle::get_carvingMoveThreshold()";
    public const string IL2CPP_get_carvingTimeToStationary = "UnityEngine.AI.NavMeshObstacle::get_carvingTimeToStationary()";
    public const string IL2CPP_get_center_Injected = "UnityEngine.AI.NavMeshObstacle::get_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_height = "UnityEngine.AI.NavMeshObstacle::get_height()";
    public const string IL2CPP_get_radius = "UnityEngine.AI.NavMeshObstacle::get_radius()";
    public const string IL2CPP_get_shape = "UnityEngine.AI.NavMeshObstacle::get_shape()";
    public const string IL2CPP_get_size_Injected = "UnityEngine.AI.NavMeshObstacle::get_size_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_velocity_Injected = "UnityEngine.AI.NavMeshObstacle::get_velocity_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_carveOnlyStationary = "UnityEngine.AI.NavMeshObstacle::set_carveOnlyStationary(System.Boolean)";
    public const string IL2CPP_set_carving = "UnityEngine.AI.NavMeshObstacle::set_carving(System.Boolean)";
    public const string IL2CPP_set_carvingMoveThreshold = "UnityEngine.AI.NavMeshObstacle::set_carvingMoveThreshold(System.Single)";
    public const string IL2CPP_set_carvingTimeToStationary = "UnityEngine.AI.NavMeshObstacle::set_carvingTimeToStationary(System.Single)";
    public const string IL2CPP_set_center_Injected = "UnityEngine.AI.NavMeshObstacle::set_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_height = "UnityEngine.AI.NavMeshObstacle::set_height(System.Single)";
    public const string IL2CPP_set_radius = "UnityEngine.AI.NavMeshObstacle::set_radius(System.Single)";
    public const string IL2CPP_set_shape = "UnityEngine.AI.NavMeshObstacle::set_shape(UnityEngine.AI.NavMeshObstacleShape)";
    public const string IL2CPP_set_size_Injected = "UnityEngine.AI.NavMeshObstacle::set_size_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_velocity_Injected = "UnityEngine.AI.NavMeshObstacle::set_velocity_Injected(UnityEngine.Vector3&)";
}

