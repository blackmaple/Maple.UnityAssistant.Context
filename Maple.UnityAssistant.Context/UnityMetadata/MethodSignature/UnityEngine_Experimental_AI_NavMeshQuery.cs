namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_AI_NavMeshQuery
{
    public const string MONO_BeginFindPathInjected = "UnityEngine.Experimental.AI.NavMeshQuery::BeginFindPath_Injected";
    public const string MONO_CreateInjected = "UnityEngine.Experimental.AI.NavMeshQuery::Create_Injected";
    public const string MONO_Destroy = "UnityEngine.Experimental.AI.NavMeshQuery::Destroy";
    public const string MONO_EndFindPath = "UnityEngine.Experimental.AI.NavMeshQuery::EndFindPath";
    public const string MONO_GetAgentTypeIdForPolygonInjected = "UnityEngine.Experimental.AI.NavMeshQuery::GetAgentTypeIdForPolygon_Injected";
    public const string MONO_GetClosestPointOnPolyInjected = "UnityEngine.Experimental.AI.NavMeshQuery::GetClosestPointOnPoly_Injected";
    public const string MONO_GetEdgesAndNeighborsInjected = "UnityEngine.Experimental.AI.NavMeshQuery::GetEdgesAndNeighbors_Injected";
    public const string MONO_GetPathResult = "UnityEngine.Experimental.AI.NavMeshQuery::GetPathResult";
    public const string MONO_GetPolygonTypeInjected = "UnityEngine.Experimental.AI.NavMeshQuery::GetPolygonType_Injected";
    public const string MONO_GetPortalPointsInjected = "UnityEngine.Experimental.AI.NavMeshQuery::GetPortalPoints_Injected";
    public const string MONO_IsPositionInPolygonInjected = "UnityEngine.Experimental.AI.NavMeshQuery::IsPositionInPolygon_Injected";
    public const string MONO_IsValidPolygonInjected = "UnityEngine.Experimental.AI.NavMeshQuery::IsValidPolygon_Injected";
    public const string MONO_MapLocationInjected = "UnityEngine.Experimental.AI.NavMeshQuery::MapLocation_Injected";
    public const string MONO_MoveLocationInjected = "UnityEngine.Experimental.AI.NavMeshQuery::MoveLocation_Injected";
    public const string MONO_MoveLocations = "UnityEngine.Experimental.AI.NavMeshQuery::MoveLocations";
    public const string MONO_MoveLocationsInSameAreas = "UnityEngine.Experimental.AI.NavMeshQuery::MoveLocationsInSameAreas";
    public const string MONO_PolygonLocalToWorldMatrixInjected = "UnityEngine.Experimental.AI.NavMeshQuery::PolygonLocalToWorldMatrix_Injected";
    public const string MONO_PolygonWorldToLocalMatrixInjected = "UnityEngine.Experimental.AI.NavMeshQuery::PolygonWorldToLocalMatrix_Injected";
    public const string MONO_RaycastInjected = "UnityEngine.Experimental.AI.NavMeshQuery::Raycast_Injected";
    public const string MONO_UpdateFindPath = "UnityEngine.Experimental.AI.NavMeshQuery::UpdateFindPath";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_AI_NavMeshQuery : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_AI_NavMeshQuery(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_AI_NavMeshQuery(nint ptr) => new Ptr_UnityEngine_Experimental_AI_NavMeshQuery(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_AI_NavMeshQuery ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_AI_NavMeshQuery ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
