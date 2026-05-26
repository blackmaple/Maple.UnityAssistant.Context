namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GridLayout
{
    public const string MONO_CellToLocalInjected = "UnityEngine.GridLayout::CellToLocal_Injected";
    public const string MONO_CellToLocalInterpolatedInjected = "UnityEngine.GridLayout::CellToLocalInterpolated_Injected";
    public const string MONO_CellToWorldInjected = "UnityEngine.GridLayout::CellToWorld_Injected";
    public const string MONO_GetCellGapInjected = "UnityEngine.GridLayout::get_cellGap_Injected";
    public const string MONO_GetCellLayout = "UnityEngine.GridLayout::get_cellLayout";
    public const string MONO_GetCellSizeInjected = "UnityEngine.GridLayout::get_cellSize_Injected";
    public const string MONO_GetCellSwizzle = "UnityEngine.GridLayout::get_cellSwizzle";
    public const string MONO_GetBoundsLocalInjected = "UnityEngine.GridLayout::GetBoundsLocal_Injected";
    public const string MONO_GetBoundsLocalOriginSizeInjected = "UnityEngine.GridLayout::GetBoundsLocalOriginSize_Injected";
    public const string MONO_GetLayoutCellCenterInjected = "UnityEngine.GridLayout::GetLayoutCellCenter_Injected";
    public const string MONO_LocalToCellInjected = "UnityEngine.GridLayout::LocalToCell_Injected";
    public const string MONO_LocalToCellInterpolatedInjected = "UnityEngine.GridLayout::LocalToCellInterpolated_Injected";
    public const string MONO_LocalToWorldInjected = "UnityEngine.GridLayout::LocalToWorld_Injected";
    public const string MONO_WorldToCellInjected = "UnityEngine.GridLayout::WorldToCell_Injected";
    public const string MONO_WorldToLocalInjected = "UnityEngine.GridLayout::WorldToLocal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GridLayout : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GridLayout(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GridLayout(nint ptr) => new Ptr_UnityEngine_GridLayout(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GridLayout ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GridLayout ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CellToLocal_Injected = "UnityEngine.GridLayout::CellToLocal_Injected(UnityEngine.Vector3Int&,UnityEngine.Vector3&)";
    public const string IL2CPP_CellToLocalInterpolated_Injected = "UnityEngine.GridLayout::CellToLocalInterpolated_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_CellToWorld_Injected = "UnityEngine.GridLayout::CellToWorld_Injected(UnityEngine.Vector3Int&,UnityEngine.Vector3&)";
    public const string IL2CPP_get_cellGap_Injected = "UnityEngine.GridLayout::get_cellGap_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_cellLayout = "UnityEngine.GridLayout::get_cellLayout()";
    public const string IL2CPP_get_cellSize_Injected = "UnityEngine.GridLayout::get_cellSize_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_cellSwizzle = "UnityEngine.GridLayout::get_cellSwizzle()";
    public const string IL2CPP_GetBoundsLocal_Injected = "UnityEngine.GridLayout::GetBoundsLocal_Injected(UnityEngine.Vector3Int&,UnityEngine.Bounds&)";
    public const string IL2CPP_GetBoundsLocalOriginSize_Injected = "UnityEngine.GridLayout::GetBoundsLocalOriginSize_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Bounds&)";
    public const string IL2CPP_GetLayoutCellCenter_Injected = "UnityEngine.GridLayout::GetLayoutCellCenter_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_LocalToCell_Injected = "UnityEngine.GridLayout::LocalToCell_Injected(UnityEngine.Vector3&,UnityEngine.Vector3Int&)";
    public const string IL2CPP_LocalToCellInterpolated_Injected = "UnityEngine.GridLayout::LocalToCellInterpolated_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_LocalToWorld_Injected = "UnityEngine.GridLayout::LocalToWorld_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_WorldToCell_Injected = "UnityEngine.GridLayout::WorldToCell_Injected(UnityEngine.Vector3&,UnityEngine.Vector3Int&)";
    public const string IL2CPP_WorldToLocal_Injected = "UnityEngine.GridLayout::WorldToLocal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
}

