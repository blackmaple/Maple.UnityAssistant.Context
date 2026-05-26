namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnimatorUtility
{
    public const string MONO_DeoptimizeTransformHierarchy = "UnityEngine.AnimatorUtility::DeoptimizeTransformHierarchy";
    public const string MONO_OptimizeTransformHierarchy = "UnityEngine.AnimatorUtility::OptimizeTransformHierarchy";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnimatorUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnimatorUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnimatorUtility(nint ptr) => new Ptr_UnityEngine_AnimatorUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnimatorUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnimatorUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
