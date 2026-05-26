namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_U2D_SpriteRendererGroup
{
    public const string MONO_AddRenderers = "UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers";
    public const string MONO_Clear = "UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup(nint ptr) => new Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_U2D_SpriteRendererGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
