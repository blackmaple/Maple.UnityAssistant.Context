namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GeometryUtility
{
    public const string MONO_InternalCalculateBoundsInjected = "UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected";
    public const string MONO_InternalExtractPlanesInjected = "UnityEngine.GeometryUtility::Internal_ExtractPlanes_Injected";
    public const string MONO_TestPlanesAabbInjected = "UnityEngine.GeometryUtility::TestPlanesAABB_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GeometryUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GeometryUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GeometryUtility(nint ptr) => new Ptr_UnityEngine_GeometryUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GeometryUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GeometryUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_ExtractPlanes_Injected = "UnityEngine.GeometryUtility::Internal_ExtractPlanes_Injected(UnityEngine.Plane[],UnityEngine.Matrix4x4&)";
    public const string IL2CPP_TestPlanesAABB_Injected = "UnityEngine.GeometryUtility::TestPlanesAABB_Injected(UnityEngine.Plane[],UnityEngine.Bounds&)";
}

