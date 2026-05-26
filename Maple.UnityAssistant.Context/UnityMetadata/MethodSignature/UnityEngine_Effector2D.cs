namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Effector2D
{
    public const string MONO_GetColliderMask = "UnityEngine.Effector2D::get_colliderMask";
    public const string MONO_GetDesignedForNonTrigger = "UnityEngine.Effector2D::get_designedForNonTrigger";
    public const string MONO_GetDesignedForTrigger = "UnityEngine.Effector2D::get_designedForTrigger";
    public const string MONO_GetRequiresCollider = "UnityEngine.Effector2D::get_requiresCollider";
    public const string MONO_GetUseColliderMask = "UnityEngine.Effector2D::get_useColliderMask";
    public const string MONO_SetColliderMask = "UnityEngine.Effector2D::set_colliderMask";
    public const string MONO_SetUseColliderMask = "UnityEngine.Effector2D::set_useColliderMask";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Effector2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Effector2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Effector2D(nint ptr) => new Ptr_UnityEngine_Effector2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Effector2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Effector2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
