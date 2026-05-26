namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Grid
{
    public const string MONO_GetCellGapInjected = "UnityEngine.Grid::get_cellGap_Injected";
    public const string MONO_GetCellLayout = "UnityEngine.Grid::get_cellLayout";
    public const string MONO_GetCellSizeInjected = "UnityEngine.Grid::get_cellSize_Injected";
    public const string MONO_GetCellSwizzle = "UnityEngine.Grid::get_cellSwizzle";
    public const string MONO_InverseSwizzleInjected = "UnityEngine.Grid::InverseSwizzle_Injected";
    public const string MONO_SetCellGapInjected = "UnityEngine.Grid::set_cellGap_Injected";
    public const string MONO_SetCellLayout = "UnityEngine.Grid::set_cellLayout";
    public const string MONO_SetCellSizeInjected = "UnityEngine.Grid::set_cellSize_Injected";
    public const string MONO_SetCellSwizzle = "UnityEngine.Grid::set_cellSwizzle";
    public const string MONO_SwizzleInjected = "UnityEngine.Grid::Swizzle_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Grid : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Grid(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Grid(nint ptr) => new Ptr_UnityEngine_Grid(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Grid ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Grid ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_cellGap_Injected = "UnityEngine.Grid::get_cellGap_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_cellLayout = "UnityEngine.Grid::get_cellLayout()";
    public const string IL2CPP_get_cellSize_Injected = "UnityEngine.Grid::get_cellSize_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_cellSwizzle = "UnityEngine.Grid::get_cellSwizzle()";
    public const string IL2CPP_InverseSwizzle_Injected = "UnityEngine.Grid::InverseSwizzle_Injected(UnityEngine.GridLayout/CellSwizzle,UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_set_cellGap_Injected = "UnityEngine.Grid::set_cellGap_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_cellLayout = "UnityEngine.Grid::set_cellLayout(UnityEngine.GridLayout/CellLayout)";
    public const string IL2CPP_set_cellSize_Injected = "UnityEngine.Grid::set_cellSize_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_cellSwizzle = "UnityEngine.Grid::set_cellSwizzle(UnityEngine.GridLayout/CellSwizzle)";
    public const string IL2CPP_Swizzle_Injected = "UnityEngine.Grid::Swizzle_Injected(UnityEngine.GridLayout/CellSwizzle,UnityEngine.Vector3&,UnityEngine.Vector3&)";
}

