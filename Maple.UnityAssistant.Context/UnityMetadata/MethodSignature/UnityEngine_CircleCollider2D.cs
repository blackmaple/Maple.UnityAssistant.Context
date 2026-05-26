namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CircleCollider2D
{
    public const string MONO_GetRadius = "UnityEngine.CircleCollider2D::get_radius";
    public const string MONO_SetRadius = "UnityEngine.CircleCollider2D::set_radius";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CircleCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CircleCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CircleCollider2D(nint ptr) => new Ptr_UnityEngine_CircleCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CircleCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CircleCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_radius = "UnityEngine.CircleCollider2D::get_radius()";
    public const string IL2CPP_set_radius = "UnityEngine.CircleCollider2D::set_radius(System.Single)";
}

