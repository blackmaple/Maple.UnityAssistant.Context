namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RaycastHit
{
    public const string MONO_CalculateRaycastTexCoordInjected = "UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RaycastHit : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RaycastHit(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RaycastHit(nint ptr) => new Ptr_UnityEngine_RaycastHit(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RaycastHit ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RaycastHit ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CalculateRaycastTexCoord_Injected = "UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected(UnityEngine.Collider,UnityEngine.Vector2&,UnityEngine.Vector3&,System.UInt32,System.Int32,UnityEngine.Vector2&)";
}

