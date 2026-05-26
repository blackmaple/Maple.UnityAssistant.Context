namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SparseTexture
{
    public const string MONO_GetIsCreated = "UnityEngine.SparseTexture::get_isCreated";
    public const string MONO_GetTileHeight = "UnityEngine.SparseTexture::get_tileHeight";
    public const string MONO_GetTileWidth = "UnityEngine.SparseTexture::get_tileWidth";
    public const string MONO_InternalCreate = "UnityEngine.SparseTexture::Internal_Create";
    public const string MONO_UpdateTile = "UnityEngine.SparseTexture::UpdateTile";
    public const string MONO_UpdateTileRaw = "UnityEngine.SparseTexture::UpdateTileRaw";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SparseTexture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SparseTexture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SparseTexture(nint ptr) => new Ptr_UnityEngine_SparseTexture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SparseTexture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SparseTexture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
