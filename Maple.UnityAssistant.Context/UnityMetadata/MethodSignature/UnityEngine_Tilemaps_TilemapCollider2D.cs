namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Tilemaps_TilemapCollider2D
{
    public const string MONO_GetExtrusionFactor = "UnityEngine.Tilemaps.TilemapCollider2D::get_extrusionFactor";
    public const string MONO_GetHasTilemapChanges = "UnityEngine.Tilemaps.TilemapCollider2D::get_hasTilemapChanges";
    public const string MONO_GetMaximumTileChangeCount = "UnityEngine.Tilemaps.TilemapCollider2D::get_maximumTileChangeCount";
    public const string MONO_ProcessTilemapChanges = "UnityEngine.Tilemaps.TilemapCollider2D::ProcessTilemapChanges";
    public const string MONO_SetExtrusionFactor = "UnityEngine.Tilemaps.TilemapCollider2D::set_extrusionFactor";
    public const string MONO_SetMaximumTileChangeCount = "UnityEngine.Tilemaps.TilemapCollider2D::set_maximumTileChangeCount";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Tilemaps_TilemapCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Tilemaps_TilemapCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Tilemaps_TilemapCollider2D(nint ptr) => new Ptr_UnityEngine_Tilemaps_TilemapCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Tilemaps_TilemapCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Tilemaps_TilemapCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
