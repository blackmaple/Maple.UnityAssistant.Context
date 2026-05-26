namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMesh
{
    public const string MONO_AddLinkInternalInjected = "UnityEngine.AI.NavMesh::AddLinkInternal_Injected";
    public const string MONO_AddNavMeshDataInternal = "UnityEngine.AI.NavMesh::AddNavMeshDataInternal";
    public const string MONO_AddNavMeshDataTransformedInternalInjected = "UnityEngine.AI.NavMesh::AddNavMeshDataTransformedInternal_Injected";
    public const string MONO_CalculatePathFilterInternalInjected = "UnityEngine.AI.NavMesh::CalculatePathFilterInternal_Injected";
    public const string MONO_CalculatePathInternalInjected = "UnityEngine.AI.NavMesh::CalculatePathInternal_Injected";
    public const string MONO_CalculateTriangulationInjected = "UnityEngine.AI.NavMesh::CalculateTriangulation_Injected";
    public const string MONO_CreateSettingsInjected = "UnityEngine.AI.NavMesh::CreateSettings_Injected";
    public const string MONO_FindClosestEdgeInjected = "UnityEngine.AI.NavMesh::FindClosestEdge_Injected";
    public const string MONO_FindClosestEdgeFilterInjected = "UnityEngine.AI.NavMesh::FindClosestEdgeFilter_Injected";
    public const string MONO_GetAvoidancePredictionTime = "UnityEngine.AI.NavMesh::get_avoidancePredictionTime";
    public const string MONO_GetPathfindingIterationsPerFrame = "UnityEngine.AI.NavMesh::get_pathfindingIterationsPerFrame";
    public const string MONO_GetAreaCost = "UnityEngine.AI.NavMesh::GetAreaCost";
    public const string MONO_GetAreaFromName = "UnityEngine.AI.NavMesh::GetAreaFromName";
    public const string MONO_GetLayerCost = "UnityEngine.AI.NavMesh::GetLayerCost";
    public const string MONO_GetNavMeshLayerFromName = "UnityEngine.AI.NavMesh::GetNavMeshLayerFromName";
    public const string MONO_GetSettingsByIdInjected = "UnityEngine.AI.NavMesh::GetSettingsByID_Injected";
    public const string MONO_GetSettingsByIndexInjected = "UnityEngine.AI.NavMesh::GetSettingsByIndex_Injected";
    public const string MONO_GetSettingsCount = "UnityEngine.AI.NavMesh::GetSettingsCount";
    public const string MONO_GetSettingsNameFromId = "UnityEngine.AI.NavMesh::GetSettingsNameFromID";
    public const string MONO_InternalGetLinkOwner = "UnityEngine.AI.NavMesh::InternalGetLinkOwner";
    public const string MONO_InternalGetOwner = "UnityEngine.AI.NavMesh::InternalGetOwner";
    public const string MONO_InternalSetLinkOwner = "UnityEngine.AI.NavMesh::InternalSetLinkOwner";
    public const string MONO_InternalSetOwner = "UnityEngine.AI.NavMesh::InternalSetOwner";
    public const string MONO_IsValidLinkHandle = "UnityEngine.AI.NavMesh::IsValidLinkHandle";
    public const string MONO_IsValidNavMeshDataHandle = "UnityEngine.AI.NavMesh::IsValidNavMeshDataHandle";
    public const string MONO_RaycastInjected = "UnityEngine.AI.NavMesh::Raycast_Injected";
    public const string MONO_RaycastFilterInjected = "UnityEngine.AI.NavMesh::RaycastFilter_Injected";
    public const string MONO_RemoveAllNavMeshData = "UnityEngine.AI.NavMesh::RemoveAllNavMeshData";
    public const string MONO_RemoveLinkInternal = "UnityEngine.AI.NavMesh::RemoveLinkInternal";
    public const string MONO_RemoveNavMeshDataInternal = "UnityEngine.AI.NavMesh::RemoveNavMeshDataInternal";
    public const string MONO_RemoveSettings = "UnityEngine.AI.NavMesh::RemoveSettings";
    public const string MONO_SamplePositionInjected = "UnityEngine.AI.NavMesh::SamplePosition_Injected";
    public const string MONO_SamplePositionFilterInjected = "UnityEngine.AI.NavMesh::SamplePositionFilter_Injected";
    public const string MONO_SetAvoidancePredictionTime = "UnityEngine.AI.NavMesh::set_avoidancePredictionTime";
    public const string MONO_SetPathfindingIterationsPerFrame = "UnityEngine.AI.NavMesh::set_pathfindingIterationsPerFrame";
    public const string MONO_SetAreaCost = "UnityEngine.AI.NavMesh::SetAreaCost";
    public const string MONO_SetLayerCost = "UnityEngine.AI.NavMesh::SetLayerCost";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMesh : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMesh(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMesh(nint ptr) => new Ptr_UnityEngine_AI_NavMesh(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMesh ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMesh ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddLinkInternal_Injected = "UnityEngine.AI.NavMesh::AddLinkInternal_Injected(UnityEngine.AI.NavMeshLinkData&,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_AddNavMeshDataInternal = "UnityEngine.AI.NavMesh::AddNavMeshDataInternal(UnityEngine.AI.NavMeshData)";
    public const string IL2CPP_AddNavMeshDataTransformedInternal_Injected = "UnityEngine.AI.NavMesh::AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_CalculatePathFilterInternal_Injected = "UnityEngine.AI.NavMesh::CalculatePathFilterInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshPath,System.Int32,System.Int32,System.Single[])";
    public const string IL2CPP_CalculatePathInternal_Injected = "UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath)";
    public const string IL2CPP_CalculateTriangulation_Injected = "UnityEngine.AI.NavMesh::CalculateTriangulation_Injected(UnityEngine.AI.NavMeshTriangulation&)";
    public const string IL2CPP_CreateSettings_Injected = "UnityEngine.AI.NavMesh::CreateSettings_Injected(UnityEngine.AI.NavMeshBuildSettings&)";
    public const string IL2CPP_FindClosestEdge_Injected = "UnityEngine.AI.NavMesh::FindClosestEdge_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32)";
    public const string IL2CPP_FindClosestEdgeFilter_Injected = "UnityEngine.AI.NavMesh::FindClosestEdgeFilter_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32,System.Int32)";
    public const string IL2CPP_get_avoidancePredictionTime = "UnityEngine.AI.NavMesh::get_avoidancePredictionTime()";
    public const string IL2CPP_get_pathfindingIterationsPerFrame = "UnityEngine.AI.NavMesh::get_pathfindingIterationsPerFrame()";
    public const string IL2CPP_GetAreaCost = "UnityEngine.AI.NavMesh::GetAreaCost(System.Int32)";
    public const string IL2CPP_GetAreaFromName = "UnityEngine.AI.NavMesh::GetAreaFromName(System.String)";
    public const string IL2CPP_GetLayerCost = "UnityEngine.AI.NavMesh::GetLayerCost(System.Int32)";
    public const string IL2CPP_GetNavMeshLayerFromName = "UnityEngine.AI.NavMesh::GetNavMeshLayerFromName(System.String)";
    public const string IL2CPP_GetSettingsByID_Injected = "UnityEngine.AI.NavMesh::GetSettingsByID_Injected(System.Int32,UnityEngine.AI.NavMeshBuildSettings&)";
    public const string IL2CPP_GetSettingsByIndex_Injected = "UnityEngine.AI.NavMesh::GetSettingsByIndex_Injected(System.Int32,UnityEngine.AI.NavMeshBuildSettings&)";
    public const string IL2CPP_GetSettingsCount = "UnityEngine.AI.NavMesh::GetSettingsCount()";
    public const string IL2CPP_GetSettingsNameFromID = "UnityEngine.AI.NavMesh::GetSettingsNameFromID(System.Int32)";
    public const string IL2CPP_InternalGetLinkOwner = "UnityEngine.AI.NavMesh::InternalGetLinkOwner(System.Int32)";
    public const string IL2CPP_InternalGetOwner = "UnityEngine.AI.NavMesh::InternalGetOwner(System.Int32)";
    public const string IL2CPP_InternalSetLinkOwner = "UnityEngine.AI.NavMesh::InternalSetLinkOwner(System.Int32,System.Int32)";
    public const string IL2CPP_InternalSetOwner = "UnityEngine.AI.NavMesh::InternalSetOwner(System.Int32,System.Int32)";
    public const string IL2CPP_IsValidLinkHandle = "UnityEngine.AI.NavMesh::IsValidLinkHandle(System.Int32)";
    public const string IL2CPP_IsValidNavMeshDataHandle = "UnityEngine.AI.NavMesh::IsValidNavMeshDataHandle(System.Int32)";
    public const string IL2CPP_Raycast_Injected = "UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32)";
    public const string IL2CPP_RaycastFilter_Injected = "UnityEngine.AI.NavMesh::RaycastFilter_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32,System.Int32)";
    public const string IL2CPP_RemoveAllNavMeshData = "UnityEngine.AI.NavMesh::RemoveAllNavMeshData()";
    public const string IL2CPP_RemoveLinkInternal = "UnityEngine.AI.NavMesh::RemoveLinkInternal(System.Int32)";
    public const string IL2CPP_RemoveNavMeshDataInternal = "UnityEngine.AI.NavMesh::RemoveNavMeshDataInternal(System.Int32)";
    public const string IL2CPP_RemoveSettings = "UnityEngine.AI.NavMesh::RemoveSettings(System.Int32)";
    public const string IL2CPP_SamplePosition_Injected = "UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32)";
    public const string IL2CPP_SamplePositionFilter_Injected = "UnityEngine.AI.NavMesh::SamplePositionFilter_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32,System.Int32)";
    public const string IL2CPP_set_avoidancePredictionTime = "UnityEngine.AI.NavMesh::set_avoidancePredictionTime(System.Single)";
    public const string IL2CPP_set_pathfindingIterationsPerFrame = "UnityEngine.AI.NavMesh::set_pathfindingIterationsPerFrame(System.Int32)";
    public const string IL2CPP_SetAreaCost = "UnityEngine.AI.NavMesh::SetAreaCost(System.Int32,System.Single)";
    public const string IL2CPP_SetLayerCost = "UnityEngine.AI.NavMesh::SetLayerCost(System.Int32,System.Single)";
}

