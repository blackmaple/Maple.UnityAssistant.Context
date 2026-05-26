namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_SortingGroup
{
    public const string MONO_GetIndex = "UnityEngine.Rendering.SortingGroup::get_index";
    public const string MONO_GetInvalidSortingGroupId = "UnityEngine.Rendering.SortingGroup::get_invalidSortingGroupID";
    public const string MONO_GetSortingGroupId = "UnityEngine.Rendering.SortingGroup::get_sortingGroupID";
    public const string MONO_GetSortingGroupOrder = "UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder";
    public const string MONO_GetSortingLayerId = "UnityEngine.Rendering.SortingGroup::get_sortingLayerID";
    public const string MONO_GetSortingLayerName = "UnityEngine.Rendering.SortingGroup::get_sortingLayerName";
    public const string MONO_GetSortingOrder = "UnityEngine.Rendering.SortingGroup::get_sortingOrder";
    public const string MONO_SetSortingLayerId = "UnityEngine.Rendering.SortingGroup::set_sortingLayerID";
    public const string MONO_SetSortingLayerName = "UnityEngine.Rendering.SortingGroup::set_sortingLayerName";
    public const string MONO_SetSortingOrder = "UnityEngine.Rendering.SortingGroup::set_sortingOrder";
    public const string MONO_UpdateAllSortingGroups = "UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_SortingGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_SortingGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_SortingGroup(nint ptr) => new Ptr_UnityEngine_Rendering_SortingGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_SortingGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_SortingGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_sortingLayerID = "UnityEngine.Rendering.SortingGroup::get_sortingLayerID()";
    public const string IL2CPP_set_sortingLayerName = "UnityEngine.Rendering.SortingGroup::set_sortingLayerName(System.String)";
}

