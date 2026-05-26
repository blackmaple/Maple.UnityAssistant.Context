namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_NavMeshData
{
    public const string MONO_GetPositionInjected = "UnityEngine.AI.NavMeshData::get_position_Injected";
    public const string MONO_GetRotationInjected = "UnityEngine.AI.NavMeshData::get_rotation_Injected";
    public const string MONO_GetSourceBoundsInjected = "UnityEngine.AI.NavMeshData::get_sourceBounds_Injected";
    public const string MONO_InternalCreate = "UnityEngine.AI.NavMeshData::Internal_Create";
    public const string MONO_SetPositionInjected = "UnityEngine.AI.NavMeshData::set_position_Injected";
    public const string MONO_SetRotationInjected = "UnityEngine.AI.NavMeshData::set_rotation_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_NavMeshData : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_NavMeshData(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_NavMeshData(nint ptr) => new Ptr_UnityEngine_AI_NavMeshData(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_NavMeshData ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_NavMeshData ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_Create = "UnityEngine.AI.NavMeshData::Internal_Create(UnityEngine.AI.NavMeshData,System.Int32)";
    public const string IL2CPP_set_position_Injected = "UnityEngine.AI.NavMeshData::set_position_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_rotation_Injected = "UnityEngine.AI.NavMeshData::set_rotation_Injected(UnityEngine.Quaternion&)";
}

