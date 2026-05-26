namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RectTransform
{
    public const string MONO_ForceUpdateRectTransforms = "UnityEngine.RectTransform::ForceUpdateRectTransforms";
    public const string MONO_GetAnchoredPositionInjected = "UnityEngine.RectTransform::get_anchoredPosition_Injected";
    public const string MONO_GetAnchorMaxInjected = "UnityEngine.RectTransform::get_anchorMax_Injected";
    public const string MONO_GetAnchorMinInjected = "UnityEngine.RectTransform::get_anchorMin_Injected";
    public const string MONO_GetDrivenByObject = "UnityEngine.RectTransform::get_drivenByObject";
    public const string MONO_GetDrivenProperties = "UnityEngine.RectTransform::get_drivenProperties";
    public const string MONO_GetPivotInjected = "UnityEngine.RectTransform::get_pivot_Injected";
    public const string MONO_GetRectInjected = "UnityEngine.RectTransform::get_rect_Injected";
    public const string MONO_GetSizeDeltaInjected = "UnityEngine.RectTransform::get_sizeDelta_Injected";
    public const string MONO_SetAnchoredPositionInjected = "UnityEngine.RectTransform::set_anchoredPosition_Injected";
    public const string MONO_SetAnchorMaxInjected = "UnityEngine.RectTransform::set_anchorMax_Injected";
    public const string MONO_SetAnchorMinInjected = "UnityEngine.RectTransform::set_anchorMin_Injected";
    public const string MONO_SetDrivenByObject = "UnityEngine.RectTransform::set_drivenByObject";
    public const string MONO_SetDrivenProperties = "UnityEngine.RectTransform::set_drivenProperties";
    public const string MONO_SetPivotInjected = "UnityEngine.RectTransform::set_pivot_Injected";
    public const string MONO_SetSizeDeltaInjected = "UnityEngine.RectTransform::set_sizeDelta_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RectTransform : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RectTransform(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RectTransform(nint ptr) => new Ptr_UnityEngine_RectTransform(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RectTransform ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RectTransform ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ForceUpdateRectTransforms = "UnityEngine.RectTransform::ForceUpdateRectTransforms()";
    public const string IL2CPP_get_anchoredPosition_Injected = "UnityEngine.RectTransform::get_anchoredPosition_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_anchorMax_Injected = "UnityEngine.RectTransform::get_anchorMax_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_anchorMin_Injected = "UnityEngine.RectTransform::get_anchorMin_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_pivot_Injected = "UnityEngine.RectTransform::get_pivot_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_rect_Injected = "UnityEngine.RectTransform::get_rect_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_get_sizeDelta_Injected = "UnityEngine.RectTransform::get_sizeDelta_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_anchoredPosition_Injected = "UnityEngine.RectTransform::set_anchoredPosition_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_anchorMax_Injected = "UnityEngine.RectTransform::set_anchorMax_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_anchorMin_Injected = "UnityEngine.RectTransform::set_anchorMin_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_pivot_Injected = "UnityEngine.RectTransform::set_pivot_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_sizeDelta_Injected = "UnityEngine.RectTransform::set_sizeDelta_Injected(UnityEngine.Vector2&)";
}

