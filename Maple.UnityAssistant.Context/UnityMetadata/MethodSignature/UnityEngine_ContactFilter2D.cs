namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ContactFilter2D
{
    public const string MONO_CheckConsistencyInjected = "UnityEngine.ContactFilter2D::CheckConsistency_Injected";
    public const string MONO_IsFilteringNormalAngleInjected = "UnityEngine.ContactFilter2D::IsFilteringNormalAngle_Injected";
    public const string MONO_IsFilteringNormalAngleUsingAngleInjected = "UnityEngine.ContactFilter2D::IsFilteringNormalAngleUsingAngle_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ContactFilter2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ContactFilter2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ContactFilter2D(nint ptr) => new Ptr_UnityEngine_ContactFilter2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ContactFilter2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ContactFilter2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CheckConsistency_Injected = "UnityEngine.ContactFilter2D::CheckConsistency_Injected(UnityEngine.ContactFilter2D&)";
}

