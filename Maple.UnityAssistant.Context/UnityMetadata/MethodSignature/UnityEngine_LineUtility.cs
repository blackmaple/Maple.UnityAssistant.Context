namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LineUtility
{
    public const string MONO_GeneratePointsToKeep2D = "UnityEngine.LineUtility::GeneratePointsToKeep2D";
    public const string MONO_GeneratePointsToKeep3D = "UnityEngine.LineUtility::GeneratePointsToKeep3D";
    public const string MONO_GenerateSimplifiedPoints2D = "UnityEngine.LineUtility::GenerateSimplifiedPoints2D";
    public const string MONO_GenerateSimplifiedPoints3D = "UnityEngine.LineUtility::GenerateSimplifiedPoints3D";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LineUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LineUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LineUtility(nint ptr) => new Ptr_UnityEngine_LineUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LineUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LineUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
