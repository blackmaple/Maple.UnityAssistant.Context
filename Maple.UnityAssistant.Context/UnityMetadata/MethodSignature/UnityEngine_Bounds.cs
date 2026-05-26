namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Bounds
{
    public const string MONO_ClosestPointInjected = "UnityEngine.Bounds::ClosestPoint_Injected";
    public const string MONO_ContainsInjected = "UnityEngine.Bounds::Contains_Injected";
    public const string MONO_IntersectRayAabbInjected = "UnityEngine.Bounds::IntersectRayAABB_Injected";
    public const string MONO_SqrDistanceInjected = "UnityEngine.Bounds::SqrDistance_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Bounds : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Bounds(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Bounds(nint ptr) => new Ptr_UnityEngine_Bounds(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Bounds ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Bounds ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ClosestPoint_Injected = "UnityEngine.Bounds::ClosestPoint_Injected(UnityEngine.Bounds&,UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_Contains_Injected = "UnityEngine.Bounds::Contains_Injected(UnityEngine.Bounds&,UnityEngine.Vector3&)";
    public const string IL2CPP_IntersectRayAABB_Injected = "UnityEngine.Bounds::IntersectRayAABB_Injected(UnityEngine.Ray&,UnityEngine.Bounds&,System.Single&)";
    public const string IL2CPP_SqrDistance_Injected = "UnityEngine.Bounds::SqrDistance_Injected(UnityEngine.Bounds&,UnityEngine.Vector3&)";
}

