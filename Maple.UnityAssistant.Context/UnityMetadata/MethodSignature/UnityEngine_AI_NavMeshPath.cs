namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMeshPath
{
    public const string MONO_CalculateCornersInternal = "UnityEngine.AI.NavMeshPath::CalculateCornersInternal";
    public const string MONO_ClearCornersInternal = "UnityEngine.AI.NavMeshPath::ClearCornersInternal";
    public const string MONO_DestroyNavMeshPath = "UnityEngine.AI.NavMeshPath::DestroyNavMeshPath";
    public const string MONO_GetStatus = "UnityEngine.AI.NavMeshPath::get_status";
    public const string MONO_GetCornersNonAlloc = "UnityEngine.AI.NavMeshPath::GetCornersNonAlloc";
    public const string MONO_InitializeNavMeshPath = "UnityEngine.AI.NavMeshPath::InitializeNavMeshPath";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMeshPath : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMeshPath(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMeshPath(nint ptr) => new Ptr_UnityEngine_AI_NavMeshPath(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMeshPath ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMeshPath ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CalculateCornersInternal = "UnityEngine.AI.NavMeshPath::CalculateCornersInternal()";
    public const string IL2CPP_ClearCornersInternal = "UnityEngine.AI.NavMeshPath::ClearCornersInternal()";
    public const string IL2CPP_DestroyNavMeshPath = "UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr)";
    public const string IL2CPP_get_status = "UnityEngine.AI.NavMeshPath::get_status()";
    public const string IL2CPP_GetCornersNonAlloc = "UnityEngine.AI.NavMeshPath::GetCornersNonAlloc(UnityEngine.Vector3[])";
    public const string IL2CPP_InitializeNavMeshPath = "UnityEngine.AI.NavMeshPath::InitializeNavMeshPath()";
}

