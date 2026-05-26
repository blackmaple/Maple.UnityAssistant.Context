namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_BillboardRenderer
{
    public const string MONO_GetBillboard = "UnityEngine.BillboardRenderer::get_billboard";
    public const string MONO_SetBillboard = "UnityEngine.BillboardRenderer::set_billboard";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_BillboardRenderer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_BillboardRenderer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_BillboardRenderer(nint ptr) => new Ptr_UnityEngine_BillboardRenderer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_BillboardRenderer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_BillboardRenderer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
