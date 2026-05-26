namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Jobs_TransformAccess
{
    public const string MONO_GetLocalPosition = "UnityEngine.Jobs.TransformAccess::GetLocalPosition";
    public const string MONO_GetLocalRotation = "UnityEngine.Jobs.TransformAccess::GetLocalRotation";
    public const string MONO_GetLocalScale = "UnityEngine.Jobs.TransformAccess::GetLocalScale";
    public const string MONO_GetLocalToWorldMatrix = "UnityEngine.Jobs.TransformAccess::GetLocalToWorldMatrix";
    public const string MONO_GetPosition = "UnityEngine.Jobs.TransformAccess::GetPosition";
    public const string MONO_GetRotation = "UnityEngine.Jobs.TransformAccess::GetRotation";
    public const string MONO_GetWorldToLocalMatrix = "UnityEngine.Jobs.TransformAccess::GetWorldToLocalMatrix";
    public const string MONO_SetLocalPosition = "UnityEngine.Jobs.TransformAccess::SetLocalPosition";
    public const string MONO_SetLocalRotation = "UnityEngine.Jobs.TransformAccess::SetLocalRotation";
    public const string MONO_SetLocalScale = "UnityEngine.Jobs.TransformAccess::SetLocalScale";
    public const string MONO_SetPosition = "UnityEngine.Jobs.TransformAccess::SetPosition";
    public const string MONO_SetRotation = "UnityEngine.Jobs.TransformAccess::SetRotation";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Jobs_TransformAccess : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Jobs_TransformAccess(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Jobs_TransformAccess(nint ptr) => new Ptr_UnityEngine_Jobs_TransformAccess(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Jobs_TransformAccess ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Jobs_TransformAccess ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetLocalScale = "UnityEngine.Jobs.TransformAccess::GetLocalScale(UnityEngine.Jobs.TransformAccess&,UnityEngine.Vector3&)";
    public const string IL2CPP_GetLocalToWorldMatrix = "UnityEngine.Jobs.TransformAccess::GetLocalToWorldMatrix(UnityEngine.Jobs.TransformAccess&,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GetPosition = "UnityEngine.Jobs.TransformAccess::GetPosition(UnityEngine.Jobs.TransformAccess&,UnityEngine.Vector3&)";
    public const string IL2CPP_GetRotation = "UnityEngine.Jobs.TransformAccess::GetRotation(UnityEngine.Jobs.TransformAccess&,UnityEngine.Quaternion&)";
}

