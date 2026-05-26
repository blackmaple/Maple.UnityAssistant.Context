namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Event
{
    public const string MONO_CopyFromPtr = "UnityEngine.Event::CopyFromPtr";
    public const string MONO_GetButton = "UnityEngine.Event::get_button";
    public const string MONO_GetCharacter = "UnityEngine.Event::get_character";
    public const string MONO_GetClickCount = "UnityEngine.Event::get_clickCount";
    public const string MONO_GetCommandName = "UnityEngine.Event::get_commandName";
    public const string MONO_GetDeltaInjected = "UnityEngine.Event::get_delta_Injected";
    public const string MONO_GetDisplayIndex = "UnityEngine.Event::get_displayIndex";
    public const string MONO_GetKeyCode = "UnityEngine.Event::get_keyCode";
    public const string MONO_GetModifiers = "UnityEngine.Event::get_modifiers";
    public const string MONO_GetMousePositionInjected = "UnityEngine.Event::get_mousePosition_Injected";
    public const string MONO_GetPointerType = "UnityEngine.Event::get_pointerType";
    public const string MONO_GetPressure = "UnityEngine.Event::get_pressure";
    public const string MONO_GetRawType = "UnityEngine.Event::get_rawType";
    public const string MONO_GetType = "UnityEngine.Event::get_type";
    public const string MONO_GetDoubleClickTime = "UnityEngine.Event::GetDoubleClickTime";
    public const string MONO_GetEventCount = "UnityEngine.Event::GetEventCount";
    public const string MONO_GetTypeForControl = "UnityEngine.Event::GetTypeForControl";
    public const string MONO_InternalCopy = "UnityEngine.Event::Internal_Copy";
    public const string MONO_InternalCreate = "UnityEngine.Event::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.Event::Internal_Destroy";
    public const string MONO_InternalSetNativeEvent = "UnityEngine.Event::Internal_SetNativeEvent";
    public const string MONO_InternalUse = "UnityEngine.Event::Internal_Use";
    public const string MONO_PopEvent = "UnityEngine.Event::PopEvent";
    public const string MONO_SetButton = "UnityEngine.Event::set_button";
    public const string MONO_SetCharacter = "UnityEngine.Event::set_character";
    public const string MONO_SetClickCount = "UnityEngine.Event::set_clickCount";
    public const string MONO_SetCommandName = "UnityEngine.Event::set_commandName";
    public const string MONO_SetDeltaInjected = "UnityEngine.Event::set_delta_Injected";
    public const string MONO_SetDisplayIndex = "UnityEngine.Event::set_displayIndex";
    public const string MONO_SetKeyCode = "UnityEngine.Event::set_keyCode";
    public const string MONO_SetModifiers = "UnityEngine.Event::set_modifiers";
    public const string MONO_SetMousePositionInjected = "UnityEngine.Event::set_mousePosition_Injected";
    public const string MONO_SetPointerType = "UnityEngine.Event::set_pointerType";
    public const string MONO_SetPressure = "UnityEngine.Event::set_pressure";
    public const string MONO_SetType = "UnityEngine.Event::set_type";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Event : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Event(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Event(nint ptr) => new Ptr_UnityEngine_Event(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Event ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Event ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CopyFromPtr = "UnityEngine.Event::CopyFromPtr(System.IntPtr)";
    public const string IL2CPP_get_button = "UnityEngine.Event::get_button()";
    public const string IL2CPP_get_character = "UnityEngine.Event::get_character()";
    public const string IL2CPP_get_clickCount = "UnityEngine.Event::get_clickCount()";
    public const string IL2CPP_get_commandName = "UnityEngine.Event::get_commandName()";
    public const string IL2CPP_get_delta_Injected = "UnityEngine.Event::get_delta_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_displayIndex = "UnityEngine.Event::get_displayIndex()";
    public const string IL2CPP_get_keyCode = "UnityEngine.Event::get_keyCode()";
    public const string IL2CPP_get_modifiers = "UnityEngine.Event::get_modifiers()";
    public const string IL2CPP_get_mousePosition_Injected = "UnityEngine.Event::get_mousePosition_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_pointerType = "UnityEngine.Event::get_pointerType()";
    public const string IL2CPP_get_pressure = "UnityEngine.Event::get_pressure()";
    public const string IL2CPP_get_rawType = "UnityEngine.Event::get_rawType()";
    public const string IL2CPP_get_type = "UnityEngine.Event::get_type()";
    public const string IL2CPP_GetDoubleClickTime = "UnityEngine.Event::GetDoubleClickTime()";
    public const string IL2CPP_GetTypeForControl = "UnityEngine.Event::GetTypeForControl(System.Int32)";
    public const string IL2CPP_Internal_Create = "UnityEngine.Event::Internal_Create(System.Int32)";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.Event::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_Internal_SetNativeEvent = "UnityEngine.Event::Internal_SetNativeEvent(System.IntPtr)";
    public const string IL2CPP_Internal_Use = "UnityEngine.Event::Internal_Use()";
    public const string IL2CPP_PopEvent = "UnityEngine.Event::PopEvent(UnityEngine.Event)";
    public const string IL2CPP_set_character = "UnityEngine.Event::set_character(System.Char)";
    public const string IL2CPP_set_commandName = "UnityEngine.Event::set_commandName(System.String)";
    public const string IL2CPP_set_delta_Injected = "UnityEngine.Event::set_delta_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_displayIndex = "UnityEngine.Event::set_displayIndex(System.Int32)";
    public const string IL2CPP_set_keyCode = "UnityEngine.Event::set_keyCode(UnityEngine.KeyCode)";
    public const string IL2CPP_set_modifiers = "UnityEngine.Event::set_modifiers(UnityEngine.EventModifiers)";
    public const string IL2CPP_set_mousePosition_Injected = "UnityEngine.Event::set_mousePosition_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_type = "UnityEngine.Event::set_type(UnityEngine.EventType)";
}

