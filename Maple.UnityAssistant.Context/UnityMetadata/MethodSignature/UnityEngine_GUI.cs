namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUI
{
    public const string MONO_BringWindowToBack = "UnityEngine.GUI::BringWindowToBack";
    public const string MONO_BringWindowToFront = "UnityEngine.GUI::BringWindowToFront";
    public const string MONO_DragWindowInjected = "UnityEngine.GUI::DragWindow_Injected";
    public const string MONO_FocusControl = "UnityEngine.GUI::FocusControl";
    public const string MONO_FocusWindow = "UnityEngine.GUI::FocusWindow";
    public const string MONO_GetBackgroundColorInjected = "UnityEngine.GUI::get_backgroundColor_Injected";
    public const string MONO_GetBlendMaterial = "UnityEngine.GUI::get_blendMaterial";
    public const string MONO_GetBlitMaterial = "UnityEngine.GUI::get_blitMaterial";
    public const string MONO_GetChanged = "UnityEngine.GUI::get_changed";
    public const string MONO_GetColorInjected = "UnityEngine.GUI::get_color_Injected";
    public const string MONO_GetContentColorInjected = "UnityEngine.GUI::get_contentColor_Injected";
    public const string MONO_GetDepth = "UnityEngine.GUI::get_depth";
    public const string MONO_GetEnabled = "UnityEngine.GUI::get_enabled";
    public const string MONO_GetIsInsideList = "UnityEngine.GUI::get_isInsideList";
    public const string MONO_GetRoundedRectMaterial = "UnityEngine.GUI::get_roundedRectMaterial";
    public const string MONO_GetRoundedRectWithColorPerBorderMaterial = "UnityEngine.GUI::get_roundedRectWithColorPerBorderMaterial";
    public const string MONO_GetUsePageScrollbars = "UnityEngine.GUI::get_usePageScrollbars";
    public const string MONO_GetNameOfFocusedControl = "UnityEngine.GUI::GetNameOfFocusedControl";
    public const string MONO_GrabMouseControl = "UnityEngine.GUI::GrabMouseControl";
    public const string MONO_HasMouseControl = "UnityEngine.GUI::HasMouseControl";
    public const string MONO_InternalBeginWindows = "UnityEngine.GUI::Internal_BeginWindows";
    public const string MONO_InternalConcatenate = "UnityEngine.GUI::Internal_Concatenate";
    public const string MONO_InternalDoModalWindowInjected = "UnityEngine.GUI::Internal_DoModalWindow_Injected";
    public const string MONO_InternalDoWindowInjected = "UnityEngine.GUI::Internal_DoWindow_Injected";
    public const string MONO_InternalEndWindows = "UnityEngine.GUI::Internal_EndWindows";
    public const string MONO_InternalGetMouseTooltip = "UnityEngine.GUI::Internal_GetMouseTooltip";
    public const string MONO_InternalGetTooltip = "UnityEngine.GUI::Internal_GetTooltip";
    public const string MONO_InternalSetTooltip = "UnityEngine.GUI::Internal_SetTooltip";
    public const string MONO_InternalRepaintEditorWindow = "UnityEngine.GUI::InternalRepaintEditorWindow";
    public const string MONO_ReleaseMouseControl = "UnityEngine.GUI::ReleaseMouseControl";
    public const string MONO_SetBackgroundColorInjected = "UnityEngine.GUI::set_backgroundColor_Injected";
    public const string MONO_SetChanged = "UnityEngine.GUI::set_changed";
    public const string MONO_SetColorInjected = "UnityEngine.GUI::set_color_Injected";
    public const string MONO_SetContentColorInjected = "UnityEngine.GUI::set_contentColor_Injected";
    public const string MONO_SetDepth = "UnityEngine.GUI::set_depth";
    public const string MONO_SetEnabled = "UnityEngine.GUI::set_enabled";
    public const string MONO_SetIsInsideList = "UnityEngine.GUI::set_isInsideList";
    public const string MONO_SetNextControlName = "UnityEngine.GUI::SetNextControlName";
    public const string MONO_UnfocusWindow = "UnityEngine.GUI::UnfocusWindow";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUI : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUI(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUI(nint ptr) => new Ptr_UnityEngine_GUI(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUI ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUI ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DragWindow_Injected = "UnityEngine.GUI::DragWindow_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_FocusControl = "UnityEngine.GUI::FocusControl(System.String)";
    public const string IL2CPP_get_backgroundColor_Injected = "UnityEngine.GUI::get_backgroundColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_blendMaterial = "UnityEngine.GUI::get_blendMaterial()";
    public const string IL2CPP_get_blitMaterial = "UnityEngine.GUI::get_blitMaterial()";
    public const string IL2CPP_get_changed = "UnityEngine.GUI::get_changed()";
    public const string IL2CPP_get_color_Injected = "UnityEngine.GUI::get_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_contentColor_Injected = "UnityEngine.GUI::get_contentColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_enabled = "UnityEngine.GUI::get_enabled()";
    public const string IL2CPP_get_roundedRectMaterial = "UnityEngine.GUI::get_roundedRectMaterial()";
    public const string IL2CPP_get_roundedRectWithColorPerBorderMaterial = "UnityEngine.GUI::get_roundedRectWithColorPerBorderMaterial()";
    public const string IL2CPP_get_usePageScrollbars = "UnityEngine.GUI::get_usePageScrollbars()";
    public const string IL2CPP_GetNameOfFocusedControl = "UnityEngine.GUI::GetNameOfFocusedControl()";
    public const string IL2CPP_GrabMouseControl = "UnityEngine.GUI::GrabMouseControl(System.Int32)";
    public const string IL2CPP_HasMouseControl = "UnityEngine.GUI::HasMouseControl(System.Int32)";
    public const string IL2CPP_Internal_DoWindow_Injected = "UnityEngine.GUI::Internal_DoWindow_Injected(System.Int32,System.Int32,UnityEngine.Rect&,UnityEngine.GUI/WindowFunction,UnityEngine.GUIContent,UnityEngine.GUIStyle,System.Object,System.Boolean,UnityEngine.Rect&)";
    public const string IL2CPP_InternalRepaintEditorWindow = "UnityEngine.GUI::InternalRepaintEditorWindow()";
    public const string IL2CPP_ReleaseMouseControl = "UnityEngine.GUI::ReleaseMouseControl()";
    public const string IL2CPP_set_backgroundColor_Injected = "UnityEngine.GUI::set_backgroundColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_changed = "UnityEngine.GUI::set_changed(System.Boolean)";
    public const string IL2CPP_set_color_Injected = "UnityEngine.GUI::set_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_contentColor_Injected = "UnityEngine.GUI::set_contentColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_enabled = "UnityEngine.GUI::set_enabled(System.Boolean)";
    public const string IL2CPP_SetNextControlName = "UnityEngine.GUI::SetNextControlName(System.String)";
}

