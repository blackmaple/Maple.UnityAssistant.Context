namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SortingLayer
{
    public const string MONO_GetLayerValueFromId = "UnityEngine.SortingLayer::GetLayerValueFromID";
    public const string MONO_GetLayerValueFromName = "UnityEngine.SortingLayer::GetLayerValueFromName";
    public const string MONO_GetSortingLayerIdsInternal = "UnityEngine.SortingLayer::GetSortingLayerIDsInternal";
    public const string MONO_IdtoName = "UnityEngine.SortingLayer::IDToName";
    public const string MONO_IsValid = "UnityEngine.SortingLayer::IsValid";
    public const string MONO_NameToId = "UnityEngine.SortingLayer::NameToID";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SortingLayer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SortingLayer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SortingLayer(nint ptr) => new Ptr_UnityEngine_SortingLayer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SortingLayer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SortingLayer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetLayerValueFromID = "UnityEngine.SortingLayer::GetLayerValueFromID(System.Int32)";
    public const string IL2CPP_GetSortingLayerIDsInternal = "UnityEngine.SortingLayer::GetSortingLayerIDsInternal()";
    public const string IL2CPP_IDToName = "UnityEngine.SortingLayer::IDToName(System.Int32)";
    public const string IL2CPP_NameToID = "UnityEngine.SortingLayer::NameToID(System.String)";
}

