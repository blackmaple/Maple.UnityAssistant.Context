namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUIStyle
{
    public const string MONO_AssignRectOffset = "UnityEngine.GUIStyle::AssignRectOffset";
    public const string MONO_AssignStyleState = "UnityEngine.GUIStyle::AssignStyleState";
    public const string MONO_GetAlignment = "UnityEngine.GUIStyle::get_alignment";
    public const string MONO_GetClipOffsetInjected = "UnityEngine.GUIStyle::get_clipOffset_Injected";
    public const string MONO_GetClipping = "UnityEngine.GUIStyle::get_clipping";
    public const string MONO_GetContentOffsetInjected = "UnityEngine.GUIStyle::get_contentOffset_Injected";
    public const string MONO_GetFixedHeight = "UnityEngine.GUIStyle::get_fixedHeight";
    public const string MONO_GetFixedWidth = "UnityEngine.GUIStyle::get_fixedWidth";
    public const string MONO_GetFont = "UnityEngine.GUIStyle::get_font";
    public const string MONO_GetFontSize = "UnityEngine.GUIStyle::get_fontSize";
    public const string MONO_GetFontStyle = "UnityEngine.GUIStyle::get_fontStyle";
    public const string MONO_GetImagePosition = "UnityEngine.GUIStyle::get_imagePosition";
    public const string MONO_GetInternalClipOffsetInjected = "UnityEngine.GUIStyle::get_Internal_clipOffset_Injected";
    public const string MONO_GetRawName = "UnityEngine.GUIStyle::get_rawName";
    public const string MONO_GetRichText = "UnityEngine.GUIStyle::get_richText";
    public const string MONO_GetStretchHeight = "UnityEngine.GUIStyle::get_stretchHeight";
    public const string MONO_GetStretchWidth = "UnityEngine.GUIStyle::get_stretchWidth";
    public const string MONO_GetWordWrap = "UnityEngine.GUIStyle::get_wordWrap";
    public const string MONO_GetRectOffsetPtr = "UnityEngine.GUIStyle::GetRectOffsetPtr";
    public const string MONO_GetStyleStatePtr = "UnityEngine.GUIStyle::GetStyleStatePtr";
    public const string MONO_InternalCalcHeight = "UnityEngine.GUIStyle::Internal_CalcHeight";
    public const string MONO_InternalCalcMinMaxWidthInjected = "UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected";
    public const string MONO_InternalCalcSizeInjected = "UnityEngine.GUIStyle::Internal_CalcSize_Injected";
    public const string MONO_InternalCalcSizeWithConstraintsInjected = "UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected";
    public const string MONO_InternalCopy = "UnityEngine.GUIStyle::Internal_Copy";
    public const string MONO_InternalCreate = "UnityEngine.GUIStyle::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.GUIStyle::Internal_Destroy";
    public const string MONO_InternalDrawInjected = "UnityEngine.GUIStyle::Internal_Draw_Injected";
    public const string MONO_InternalDraw2Injected = "UnityEngine.GUIStyle::Internal_Draw2_Injected";
    public const string MONO_InternalDrawCursorInjected = "UnityEngine.GUIStyle::Internal_DrawCursor_Injected";
    public const string MONO_InternalDrawWithTextSelectionInjected = "UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected";
    public const string MONO_InternalGetCursorFlashOffset = "UnityEngine.GUIStyle::Internal_GetCursorFlashOffset";
    public const string MONO_InternalGetCursorPixelPositionInjected = "UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected";
    public const string MONO_InternalGetCursorStringIndexInjected = "UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected";
    public const string MONO_InternalGetHyperlinksRectInjected = "UnityEngine.GUIStyle::Internal_GetHyperlinksRect_Injected";
    public const string MONO_InternalGetLineHeight = "UnityEngine.GUIStyle::Internal_GetLineHeight";
    public const string MONO_InternalGetNumCharactersThatFitWithinWidth = "UnityEngine.GUIStyle::Internal_GetNumCharactersThatFitWithinWidth";
    public const string MONO_InternalGetSelectedRenderedTextInjected = "UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected";
    public const string MONO_IsTooltipActive = "UnityEngine.GUIStyle::IsTooltipActive";
    public const string MONO_SetAlignment = "UnityEngine.GUIStyle::set_alignment";
    public const string MONO_SetClipOffsetInjected = "UnityEngine.GUIStyle::set_clipOffset_Injected";
    public const string MONO_SetClipping = "UnityEngine.GUIStyle::set_clipping";
    public const string MONO_SetContentOffsetInjected = "UnityEngine.GUIStyle::set_contentOffset_Injected";
    public const string MONO_SetFixedHeight = "UnityEngine.GUIStyle::set_fixedHeight";
    public const string MONO_SetFixedWidth = "UnityEngine.GUIStyle::set_fixedWidth";
    public const string MONO_SetFont = "UnityEngine.GUIStyle::set_font";
    public const string MONO_SetFontSize = "UnityEngine.GUIStyle::set_fontSize";
    public const string MONO_SetFontStyle = "UnityEngine.GUIStyle::set_fontStyle";
    public const string MONO_SetImagePosition = "UnityEngine.GUIStyle::set_imagePosition";
    public const string MONO_SetInternalClipOffsetInjected = "UnityEngine.GUIStyle::set_Internal_clipOffset_Injected";
    public const string MONO_SetRawName = "UnityEngine.GUIStyle::set_rawName";
    public const string MONO_SetRichText = "UnityEngine.GUIStyle::set_richText";
    public const string MONO_SetStretchHeight = "UnityEngine.GUIStyle::set_stretchHeight";
    public const string MONO_SetStretchWidth = "UnityEngine.GUIStyle::set_stretchWidth";
    public const string MONO_SetWordWrap = "UnityEngine.GUIStyle::set_wordWrap";
    public const string MONO_SetDefaultFont = "UnityEngine.GUIStyle::SetDefaultFont";
    public const string MONO_SetMouseTooltipInjected = "UnityEngine.GUIStyle::SetMouseTooltip_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUIStyle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUIStyle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUIStyle(nint ptr) => new Ptr_UnityEngine_GUIStyle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUIStyle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUIStyle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AssignRectOffset = "UnityEngine.GUIStyle::AssignRectOffset(System.Int32,System.IntPtr)";
    public const string IL2CPP_get_alignment = "UnityEngine.GUIStyle::get_alignment()";
    public const string IL2CPP_get_contentOffset_Injected = "UnityEngine.GUIStyle::get_contentOffset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_fixedHeight = "UnityEngine.GUIStyle::get_fixedHeight()";
    public const string IL2CPP_get_fixedWidth = "UnityEngine.GUIStyle::get_fixedWidth()";
    public const string IL2CPP_get_font = "UnityEngine.GUIStyle::get_font()";
    public const string IL2CPP_get_fontStyle = "UnityEngine.GUIStyle::get_fontStyle()";
    public const string IL2CPP_get_imagePosition = "UnityEngine.GUIStyle::get_imagePosition()";
    public const string IL2CPP_get_rawName = "UnityEngine.GUIStyle::get_rawName()";
    public const string IL2CPP_get_stretchHeight = "UnityEngine.GUIStyle::get_stretchHeight()";
    public const string IL2CPP_get_stretchWidth = "UnityEngine.GUIStyle::get_stretchWidth()";
    public const string IL2CPP_get_wordWrap = "UnityEngine.GUIStyle::get_wordWrap()";
    public const string IL2CPP_GetRectOffsetPtr = "UnityEngine.GUIStyle::GetRectOffsetPtr(System.Int32)";
    public const string IL2CPP_GetStyleStatePtr = "UnityEngine.GUIStyle::GetStyleStatePtr(System.Int32)";
    public const string IL2CPP_Internal_CalcHeight = "UnityEngine.GUIStyle::Internal_CalcHeight(UnityEngine.GUIContent,System.Single)";
    public const string IL2CPP_Internal_CalcMinMaxWidth_Injected = "UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_CalcSize_Injected = "UnityEngine.GUIStyle::Internal_CalcSize_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_CalcSizeWithConstraints_Injected = "UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&,UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_Copy = "UnityEngine.GUIStyle::Internal_Copy(UnityEngine.GUIStyle,UnityEngine.GUIStyle)";
    public const string IL2CPP_Internal_Create = "UnityEngine.GUIStyle::Internal_Create(UnityEngine.GUIStyle)";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.GUIStyle::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_Internal_Draw_Injected = "UnityEngine.GUIStyle::Internal_Draw_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)";
    public const string IL2CPP_Internal_Draw2_Injected = "UnityEngine.GUIStyle::Internal_Draw2_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Boolean)";
    public const string IL2CPP_Internal_DrawCursor_Injected = "UnityEngine.GUIStyle::Internal_DrawCursor_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Color&)";
    public const string IL2CPP_Internal_DrawWithTextSelection_Injected = "UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color&,UnityEngine.Color&)";
    public const string IL2CPP_Internal_GetCursorFlashOffset = "UnityEngine.GUIStyle::Internal_GetCursorFlashOffset()";
    public const string IL2CPP_Internal_GetCursorPixelPosition_Injected = "UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_GetCursorStringIndex_Injected = "UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_GetLineHeight = "UnityEngine.GUIStyle::Internal_GetLineHeight(System.IntPtr)";
    public const string IL2CPP_Internal_GetSelectedRenderedText_Injected = "UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Int32)";
    public const string IL2CPP_IsTooltipActive = "UnityEngine.GUIStyle::IsTooltipActive(System.String)";
    public const string IL2CPP_set_alignment = "UnityEngine.GUIStyle::set_alignment(UnityEngine.TextAnchor)";
    public const string IL2CPP_set_clipping = "UnityEngine.GUIStyle::set_clipping(UnityEngine.TextClipping)";
    public const string IL2CPP_set_contentOffset_Injected = "UnityEngine.GUIStyle::set_contentOffset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_font = "UnityEngine.GUIStyle::set_font(UnityEngine.Font)";
    public const string IL2CPP_set_fontSize = "UnityEngine.GUIStyle::set_fontSize(System.Int32)";
    public const string IL2CPP_set_fontStyle = "UnityEngine.GUIStyle::set_fontStyle(UnityEngine.FontStyle)";
    public const string IL2CPP_set_Internal_clipOffset_Injected = "UnityEngine.GUIStyle::set_Internal_clipOffset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_rawName = "UnityEngine.GUIStyle::set_rawName(System.String)";
    public const string IL2CPP_set_richText = "UnityEngine.GUIStyle::set_richText(System.Boolean)";
    public const string IL2CPP_set_stretchHeight = "UnityEngine.GUIStyle::set_stretchHeight(System.Boolean)";
    public const string IL2CPP_set_stretchWidth = "UnityEngine.GUIStyle::set_stretchWidth(System.Boolean)";
    public const string IL2CPP_set_wordWrap = "UnityEngine.GUIStyle::set_wordWrap(System.Boolean)";
    public const string IL2CPP_SetDefaultFont = "UnityEngine.GUIStyle::SetDefaultFont(UnityEngine.Font)";
    public const string IL2CPP_SetMouseTooltip_Injected = "UnityEngine.GUIStyle::SetMouseTooltip_Injected(System.String,UnityEngine.Rect&)";
}

