namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PhysicsMaterial2D
{
    public const string MONO_CreateInternal = "UnityEngine.PhysicsMaterial2D::Create_Internal";
    public const string MONO_GetBounciness = "UnityEngine.PhysicsMaterial2D::get_bounciness";
    public const string MONO_GetFriction = "UnityEngine.PhysicsMaterial2D::get_friction";
    public const string MONO_SetBounciness = "UnityEngine.PhysicsMaterial2D::set_bounciness";
    public const string MONO_SetFriction = "UnityEngine.PhysicsMaterial2D::set_friction";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PhysicsMaterial2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PhysicsMaterial2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PhysicsMaterial2D(nint ptr) => new Ptr_UnityEngine_PhysicsMaterial2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PhysicsMaterial2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PhysicsMaterial2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Create_Internal = "UnityEngine.PhysicsMaterial2D::Create_Internal(UnityEngine.PhysicsMaterial2D,System.String)";
    public const string IL2CPP_get_bounciness = "UnityEngine.PhysicsMaterial2D::get_bounciness()";
    public const string IL2CPP_get_friction = "UnityEngine.PhysicsMaterial2D::get_friction()";
    public const string IL2CPP_set_bounciness = "UnityEngine.PhysicsMaterial2D::set_bounciness(System.Single)";
    public const string IL2CPP_set_friction = "UnityEngine.PhysicsMaterial2D::set_friction(System.Single)";
}

