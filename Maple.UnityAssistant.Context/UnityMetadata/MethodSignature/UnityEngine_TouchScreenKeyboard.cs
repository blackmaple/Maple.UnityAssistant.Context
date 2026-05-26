namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TouchScreenKeyboard
{
    public const string MONO_GetActive = "UnityEngine.TouchScreenKeyboard::get_active";
    public const string MONO_GetAreaInjected = "UnityEngine.TouchScreenKeyboard::get_area_Injected";
    public const string MONO_GetCanGetSelection = "UnityEngine.TouchScreenKeyboard::get_canGetSelection";
    public const string MONO_GetCanSetSelection = "UnityEngine.TouchScreenKeyboard::get_canSetSelection";
    public const string MONO_GetCharacterLimit = "UnityEngine.TouchScreenKeyboard::get_characterLimit";
    public const string MONO_GetHideInput = "UnityEngine.TouchScreenKeyboard::get_hideInput";
    public const string MONO_GetStatus = "UnityEngine.TouchScreenKeyboard::get_status";
    public const string MONO_GetText = "UnityEngine.TouchScreenKeyboard::get_text";
    public const string MONO_GetType = "UnityEngine.TouchScreenKeyboard::get_type";
    public const string MONO_GetVisible = "UnityEngine.TouchScreenKeyboard::get_visible";
    public const string MONO_GetDone = "UnityEngine.TouchScreenKeyboard::GetDone";
    public const string MONO_GetSelection = "UnityEngine.TouchScreenKeyboard::GetSelection";
    public const string MONO_GetWasCanceled = "UnityEngine.TouchScreenKeyboard::GetWasCanceled";
    public const string MONO_InternalDestroy = "UnityEngine.TouchScreenKeyboard::Internal_Destroy";
    public const string MONO_IsRequiredToForceOpen = "UnityEngine.TouchScreenKeyboard::IsRequiredToForceOpen";
    public const string MONO_SetActive = "UnityEngine.TouchScreenKeyboard::set_active";
    public const string MONO_SetCharacterLimit = "UnityEngine.TouchScreenKeyboard::set_characterLimit";
    public const string MONO_SetHideInput = "UnityEngine.TouchScreenKeyboard::set_hideInput";
    public const string MONO_SetText = "UnityEngine.TouchScreenKeyboard::set_text";
    public const string MONO_SetSelection = "UnityEngine.TouchScreenKeyboard::SetSelection";
    public const string MONO_TouchScreenKeyboardInternalConstructorHelper = "UnityEngine.TouchScreenKeyboard::TouchScreenKeyboard_InternalConstructorHelper";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TouchScreenKeyboard : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TouchScreenKeyboard(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TouchScreenKeyboard(nint ptr) => new Ptr_UnityEngine_TouchScreenKeyboard(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TouchScreenKeyboard ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TouchScreenKeyboard ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_active = "UnityEngine.TouchScreenKeyboard::get_active()";
    public const string IL2CPP_get_canGetSelection = "UnityEngine.TouchScreenKeyboard::get_canGetSelection()";
    public const string IL2CPP_get_canSetSelection = "UnityEngine.TouchScreenKeyboard::get_canSetSelection()";
    public const string IL2CPP_get_status = "UnityEngine.TouchScreenKeyboard::get_status()";
    public const string IL2CPP_get_text = "UnityEngine.TouchScreenKeyboard::get_text()";
    public const string IL2CPP_GetSelection = "UnityEngine.TouchScreenKeyboard::GetSelection(System.Int32&,System.Int32&)";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.TouchScreenKeyboard::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_IsRequiredToForceOpen = "UnityEngine.TouchScreenKeyboard::IsRequiredToForceOpen()";
    public const string IL2CPP_set_active = "UnityEngine.TouchScreenKeyboard::set_active(System.Boolean)";
    public const string IL2CPP_set_characterLimit = "UnityEngine.TouchScreenKeyboard::set_characterLimit(System.Int32)";
    public const string IL2CPP_set_hideInput = "UnityEngine.TouchScreenKeyboard::set_hideInput(System.Boolean)";
    public const string IL2CPP_set_text = "UnityEngine.TouchScreenKeyboard::set_text(System.String)";
    public const string IL2CPP_SetSelection = "UnityEngine.TouchScreenKeyboard::SetSelection(System.Int32,System.Int32)";
    public const string IL2CPP_TouchScreenKeyboard_InternalConstructorHelper = "UnityEngine.TouchScreenKeyboard::TouchScreenKeyboard_InternalConstructorHelper(UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments&,System.String,System.String)";
}

