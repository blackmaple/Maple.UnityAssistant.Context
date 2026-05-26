namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_U2D_SpriteRendererDataAccessExtensions
{
    public const string MONO_DeactivateDeformableBuffer = "UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer";
    public const string MONO_IsUsingDeformableBuffer = "UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsUsingDeformableBuffer";
    public const string MONO_SetBatchDeformableBufferAndLocalAabbarray = "UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray";
    public const string MONO_SetDeformableBuffer = "UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer";
    public const string MONO_SetLocalAabbInjected = "UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions(nint ptr) => new Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_U2D_SpriteRendererDataAccessExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
