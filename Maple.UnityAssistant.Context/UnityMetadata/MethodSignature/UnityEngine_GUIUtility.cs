namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUIUtility
{
    public const string MONO_AlignRectToDeviceInjected = "UnityEngine.GUIUtility::AlignRectToDevice_Injected";
    public const string MONO_BeginContainer = "UnityEngine.GUIUtility::BeginContainer";
    public const string MONO_BeginContainerFromOwner = "UnityEngine.GUIUtility::BeginContainerFromOwner";
    public const string MONO_CheckForTabEvent = "UnityEngine.GUIUtility::CheckForTabEvent";
    public const string MONO_GetCompositionCursorPosInjected = "UnityEngine.GUIUtility::get_compositionCursorPos_Injected";
    public const string MONO_GetCompositionString = "UnityEngine.GUIUtility::get_compositionString";
    public const string MONO_GetGuiDepth = "UnityEngine.GUIUtility::get_guiDepth";
    public const string MONO_GetHasModalWindow = "UnityEngine.GUIUtility::get_hasModalWindow";
    public const string MONO_GetImeCompositionMode = "UnityEngine.GUIUtility::get_imeCompositionMode";
    public const string MONO_GetManualTex2Srgbenabled = "UnityEngine.GUIUtility::get_manualTex2SRGBEnabled";
    public const string MONO_GetMouseUsed = "UnityEngine.GUIUtility::get_mouseUsed";
    public const string MONO_GetPixelsPerPoint = "UnityEngine.GUIUtility::get_pixelsPerPoint";
    public const string MONO_GetSEditorScreenPointOffsetInjected = "UnityEngine.GUIUtility::get_s_EditorScreenPointOffset_Injected";
    public const string MONO_GetSystemCopyBuffer = "UnityEngine.GUIUtility::get_systemCopyBuffer";
    public const string MONO_GetTextFieldInput = "UnityEngine.GUIUtility::get_textFieldInput";
    public const string MONO_GetChanged = "UnityEngine.GUIUtility::GetChanged";
    public const string MONO_GetPermanentControlId = "UnityEngine.GUIUtility::GetPermanentControlID";
    public const string MONO_HasFocusableControls = "UnityEngine.GUIUtility::HasFocusableControls";
    public const string MONO_InternalEndContainer = "UnityEngine.GUIUtility::Internal_EndContainer";
    public const string MONO_InternalExitGui = "UnityEngine.GUIUtility::Internal_ExitGUI";
    public const string MONO_InternalGetBuiltinSkin = "UnityEngine.GUIUtility::Internal_GetBuiltinSkin";
    public const string MONO_InternalGetControlIdInjected = "UnityEngine.GUIUtility::Internal_GetControlID_Injected";
    public const string MONO_InternalGetDefaultSkin = "UnityEngine.GUIUtility::Internal_GetDefaultSkin";
    public const string MONO_InternalGetHotControl = "UnityEngine.GUIUtility::Internal_GetHotControl";
    public const string MONO_InternalGetKeyboardControl = "UnityEngine.GUIUtility::Internal_GetKeyboardControl";
    public const string MONO_InternalMultiplyPointInjected = "UnityEngine.GUIUtility::Internal_MultiplyPoint_Injected";
    public const string MONO_InternalSetHotControl = "UnityEngine.GUIUtility::Internal_SetHotControl";
    public const string MONO_InternalSetKeyboardControl = "UnityEngine.GUIUtility::Internal_SetKeyboardControl";
    public const string MONO_InternalScreenToWindowPointInjected = "UnityEngine.GUIUtility::InternalScreenToWindowPoint_Injected";
    public const string MONO_InternalWindowToScreenPointInjected = "UnityEngine.GUIUtility::InternalWindowToScreenPoint_Injected";
    public const string MONO_OwnsId = "UnityEngine.GUIUtility::OwnsId";
    public const string MONO_SetCompositionCursorPosInjected = "UnityEngine.GUIUtility::set_compositionCursorPos_Injected";
    public const string MONO_SetImeCompositionMode = "UnityEngine.GUIUtility::set_imeCompositionMode";
    public const string MONO_SetManualTex2Srgbenabled = "UnityEngine.GUIUtility::set_manualTex2SRGBEnabled";
    public const string MONO_SetMouseUsed = "UnityEngine.GUIUtility::set_mouseUsed";
    public const string MONO_SetSEditorScreenPointOffsetInjected = "UnityEngine.GUIUtility::set_s_EditorScreenPointOffset_Injected";
    public const string MONO_SetSystemCopyBuffer = "UnityEngine.GUIUtility::set_systemCopyBuffer";
    public const string MONO_SetTextFieldInput = "UnityEngine.GUIUtility::set_textFieldInput";
    public const string MONO_SetChanged = "UnityEngine.GUIUtility::SetChanged";
    public const string MONO_SetDidGuiwindowsEatLastEvent = "UnityEngine.GUIUtility::SetDidGUIWindowsEatLastEvent";
    public const string MONO_SetKeyboardControlToFirstControlId = "UnityEngine.GUIUtility::SetKeyboardControlToFirstControlId";
    public const string MONO_SetKeyboardControlToLastControlId = "UnityEngine.GUIUtility::SetKeyboardControlToLastControlId";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUIUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUIUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUIUtility(nint ptr) => new Ptr_UnityEngine_GUIUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUIUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUIUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AlignRectToDevice_Injected = "UnityEngine.GUIUtility::AlignRectToDevice_Injected(UnityEngine.Rect&,System.Int32&,System.Int32&,UnityEngine.Rect&)";
    public const string IL2CPP_BeginContainer = "UnityEngine.GUIUtility::BeginContainer(UnityEngine.ObjectGUIState)";
    public const string IL2CPP_BeginContainerFromOwner = "UnityEngine.GUIUtility::BeginContainerFromOwner(UnityEngine.ScriptableObject)";
    public const string IL2CPP_CheckForTabEvent = "UnityEngine.GUIUtility::CheckForTabEvent(UnityEngine.Event)";
    public const string IL2CPP_get_compositionString = "UnityEngine.GUIUtility::get_compositionString()";
    public const string IL2CPP_get_guiDepth = "UnityEngine.GUIUtility::get_guiDepth()";
    public const string IL2CPP_get_pixelsPerPoint = "UnityEngine.GUIUtility::get_pixelsPerPoint()";
    public const string IL2CPP_get_systemCopyBuffer = "UnityEngine.GUIUtility::get_systemCopyBuffer()";
    public const string IL2CPP_get_textFieldInput = "UnityEngine.GUIUtility::get_textFieldInput()";
    public const string IL2CPP_HasFocusableControls = "UnityEngine.GUIUtility::HasFocusableControls()";
    public const string IL2CPP_Internal_EndContainer = "UnityEngine.GUIUtility::Internal_EndContainer()";
    public const string IL2CPP_Internal_ExitGUI = "UnityEngine.GUIUtility::Internal_ExitGUI()";
    public const string IL2CPP_Internal_GetControlID_Injected = "UnityEngine.GUIUtility::Internal_GetControlID_Injected(System.Int32,UnityEngine.FocusType,UnityEngine.Rect&)";
    public const string IL2CPP_Internal_GetDefaultSkin = "UnityEngine.GUIUtility::Internal_GetDefaultSkin(System.Int32)";
    public const string IL2CPP_Internal_GetHotControl = "UnityEngine.GUIUtility::Internal_GetHotControl()";
    public const string IL2CPP_Internal_GetKeyboardControl = "UnityEngine.GUIUtility::Internal_GetKeyboardControl()";
    public const string IL2CPP_Internal_SetHotControl = "UnityEngine.GUIUtility::Internal_SetHotControl(System.Int32)";
    public const string IL2CPP_Internal_SetKeyboardControl = "UnityEngine.GUIUtility::Internal_SetKeyboardControl(System.Int32)";
    public const string IL2CPP_OwnsId = "UnityEngine.GUIUtility::OwnsId(System.Int32)";
    public const string IL2CPP_set_compositionCursorPos_Injected = "UnityEngine.GUIUtility::set_compositionCursorPos_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_imeCompositionMode = "UnityEngine.GUIUtility::set_imeCompositionMode(UnityEngine.IMECompositionMode)";
    public const string IL2CPP_set_mouseUsed = "UnityEngine.GUIUtility::set_mouseUsed(System.Boolean)";
    public const string IL2CPP_set_systemCopyBuffer = "UnityEngine.GUIUtility::set_systemCopyBuffer(System.String)";
    public const string IL2CPP_set_textFieldInput = "UnityEngine.GUIUtility::set_textFieldInput(System.Boolean)";
    public const string IL2CPP_SetKeyboardControlToFirstControlId = "UnityEngine.GUIUtility::SetKeyboardControlToFirstControlId()";
    public const string IL2CPP_SetKeyboardControlToLastControlId = "UnityEngine.GUIUtility::SetKeyboardControlToLastControlId()";
}

