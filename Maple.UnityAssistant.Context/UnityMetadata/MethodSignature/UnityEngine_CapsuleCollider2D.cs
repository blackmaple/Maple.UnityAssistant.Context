namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CapsuleCollider2D
{
    public const string MONO_GetDirection = "UnityEngine.CapsuleCollider2D::get_direction";
    public const string MONO_GetSizeInjected = "UnityEngine.CapsuleCollider2D::get_size_Injected";
    public const string MONO_SetDirection = "UnityEngine.CapsuleCollider2D::set_direction";
    public const string MONO_SetSizeInjected = "UnityEngine.CapsuleCollider2D::set_size_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CapsuleCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CapsuleCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CapsuleCollider2D(nint ptr) => new Ptr_UnityEngine_CapsuleCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CapsuleCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CapsuleCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_size_Injected = "UnityEngine.CapsuleCollider2D::get_size_Injected(UnityEngine.Vector2&)";
}

