namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ModifiableContactPair
{
    public const string MONO_ResolveBodyInstanceId = "UnityEngine.ModifiableContactPair::ResolveBodyInstanceID";
    public const string MONO_ResolveColliderInstanceId = "UnityEngine.ModifiableContactPair::ResolveColliderInstanceID";
    public const string MONO_TranslateTriangleIndex = "UnityEngine.ModifiableContactPair::TranslateTriangleIndex";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ModifiableContactPair : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ModifiableContactPair(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ModifiableContactPair(nint ptr) => new Ptr_UnityEngine_ModifiableContactPair(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ModifiableContactPair ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ModifiableContactPair ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
