namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Input
{
    public const string MONO_CheckDisabled = "UnityEngine.Input::CheckDisabled";
    public const string MONO_GetAccelerationInjected = "UnityEngine.Input::get_acceleration_Injected";
    public const string MONO_GetAccelerationEventCount = "UnityEngine.Input::get_accelerationEventCount";
    public const string MONO_GetAnyKey = "UnityEngine.Input::get_anyKey";
    public const string MONO_GetAnyKeyDown = "UnityEngine.Input::get_anyKeyDown";
    public const string MONO_GetBackButtonLeavesApp = "UnityEngine.Input::get_backButtonLeavesApp";
    public const string MONO_GetCompensateSensors = "UnityEngine.Input::get_compensateSensors";
    public const string MONO_GetCompositionCursorPosInjected = "UnityEngine.Input::get_compositionCursorPos_Injected";
    public const string MONO_GetCompositionString = "UnityEngine.Input::get_compositionString";
    public const string MONO_GetDeviceOrientation = "UnityEngine.Input::get_deviceOrientation";
    public const string MONO_GetEatKeyPressOnTextFieldFocus = "UnityEngine.Input::get_eatKeyPressOnTextFieldFocus";
    public const string MONO_GetImeCompositionMode = "UnityEngine.Input::get_imeCompositionMode";
    public const string MONO_GetImeIsSelected = "UnityEngine.Input::get_imeIsSelected";
    public const string MONO_GetInputString = "UnityEngine.Input::get_inputString";
    public const string MONO_GetIsGyroAvailable = "UnityEngine.Input::get_isGyroAvailable";
    public const string MONO_GetMousePositionInjected = "UnityEngine.Input::get_mousePosition_Injected";
    public const string MONO_GetMousePresent = "UnityEngine.Input::get_mousePresent";
    public const string MONO_GetMouseScrollDeltaInjected = "UnityEngine.Input::get_mouseScrollDelta_Injected";
    public const string MONO_GetMultiTouchEnabled = "UnityEngine.Input::get_multiTouchEnabled";
    public const string MONO_GetSimulateMouseWithTouches = "UnityEngine.Input::get_simulateMouseWithTouches";
    public const string MONO_GetStylusTouchSupported = "UnityEngine.Input::get_stylusTouchSupported";
    public const string MONO_GetTouchCount = "UnityEngine.Input::get_touchCount";
    public const string MONO_GetTouchPressureSupported = "UnityEngine.Input::get_touchPressureSupported";
    public const string MONO_GetTouchSupported = "UnityEngine.Input::get_touchSupported";
    public const string MONO_GetAccelerationEventInjected = "UnityEngine.Input::GetAccelerationEvent_Injected";
    public const string MONO_GetAxis = "UnityEngine.Input::GetAxis";
    public const string MONO_GetAxisRaw = "UnityEngine.Input::GetAxisRaw";
    public const string MONO_GetButton = "UnityEngine.Input::GetButton";
    public const string MONO_GetButtonDown = "UnityEngine.Input::GetButtonDown";
    public const string MONO_GetButtonUp = "UnityEngine.Input::GetButtonUp";
    public const string MONO_GetGyroInternal = "UnityEngine.Input::GetGyroInternal";
    public const string MONO_GetJoystickNames = "UnityEngine.Input::GetJoystickNames";
    public const string MONO_GetKeyDownInt = "UnityEngine.Input::GetKeyDownInt";
    public const string MONO_GetKeyDownString = "UnityEngine.Input::GetKeyDownString";
    public const string MONO_GetKeyInt = "UnityEngine.Input::GetKeyInt";
    public const string MONO_GetKeyString = "UnityEngine.Input::GetKeyString";
    public const string MONO_GetKeyUpInt = "UnityEngine.Input::GetKeyUpInt";
    public const string MONO_GetKeyUpString = "UnityEngine.Input::GetKeyUpString";
    public const string MONO_GetMouseButton = "UnityEngine.Input::GetMouseButton";
    public const string MONO_GetMouseButtonDown = "UnityEngine.Input::GetMouseButtonDown";
    public const string MONO_GetMouseButtonUp = "UnityEngine.Input::GetMouseButtonUp";
    public const string MONO_GetTouchInjected = "UnityEngine.Input::GetTouch_Injected";
    public const string MONO_ResetInputAxes = "UnityEngine.Input::ResetInputAxes";
    public const string MONO_SetBackButtonLeavesApp = "UnityEngine.Input::set_backButtonLeavesApp";
    public const string MONO_SetCompensateSensors = "UnityEngine.Input::set_compensateSensors";
    public const string MONO_SetCompositionCursorPosInjected = "UnityEngine.Input::set_compositionCursorPos_Injected";
    public const string MONO_SetEatKeyPressOnTextFieldFocus = "UnityEngine.Input::set_eatKeyPressOnTextFieldFocus";
    public const string MONO_SetImeCompositionMode = "UnityEngine.Input::set_imeCompositionMode";
    public const string MONO_SetMultiTouchEnabled = "UnityEngine.Input::set_multiTouchEnabled";
    public const string MONO_SetSimulateMouseWithTouches = "UnityEngine.Input::set_simulateMouseWithTouches";
    public const string MONO_SimulateTouchInternalInjected = "UnityEngine.Input::SimulateTouchInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Input : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Input(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Input(nint ptr) => new Ptr_UnityEngine_Input(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Input ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Input ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CheckDisabled = "UnityEngine.Input::CheckDisabled()";
    public const string IL2CPP_get_acceleration_Injected = "UnityEngine.Input::get_acceleration_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_accelerationEventCount = "UnityEngine.Input::get_accelerationEventCount()";
    public const string IL2CPP_get_anyKey = "UnityEngine.Input::get_anyKey()";
    public const string IL2CPP_get_anyKeyDown = "UnityEngine.Input::get_anyKeyDown()";
    public const string IL2CPP_get_backButtonLeavesApp = "UnityEngine.Input::get_backButtonLeavesApp()";
    public const string IL2CPP_get_compensateSensors = "UnityEngine.Input::get_compensateSensors()";
    public const string IL2CPP_get_compositionCursorPos_Injected = "UnityEngine.Input::get_compositionCursorPos_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_compositionString = "UnityEngine.Input::get_compositionString()";
    public const string IL2CPP_get_deviceOrientation = "UnityEngine.Input::get_deviceOrientation()";
    public const string IL2CPP_get_eatKeyPressOnTextFieldFocus = "UnityEngine.Input::get_eatKeyPressOnTextFieldFocus()";
    public const string IL2CPP_get_imeCompositionMode = "UnityEngine.Input::get_imeCompositionMode()";
    public const string IL2CPP_get_imeIsSelected = "UnityEngine.Input::get_imeIsSelected()";
    public const string IL2CPP_get_inputString = "UnityEngine.Input::get_inputString()";
    public const string IL2CPP_get_isGyroAvailable = "UnityEngine.Input::get_isGyroAvailable()";
    public const string IL2CPP_get_mousePosition_Injected = "UnityEngine.Input::get_mousePosition_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_mousePresent = "UnityEngine.Input::get_mousePresent()";
    public const string IL2CPP_get_mouseScrollDelta_Injected = "UnityEngine.Input::get_mouseScrollDelta_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_multiTouchEnabled = "UnityEngine.Input::get_multiTouchEnabled()";
    public const string IL2CPP_get_simulateMouseWithTouches = "UnityEngine.Input::get_simulateMouseWithTouches()";
    public const string IL2CPP_get_stylusTouchSupported = "UnityEngine.Input::get_stylusTouchSupported()";
    public const string IL2CPP_get_touchCount = "UnityEngine.Input::get_touchCount()";
    public const string IL2CPP_get_touchPressureSupported = "UnityEngine.Input::get_touchPressureSupported()";
    public const string IL2CPP_get_touchSupported = "UnityEngine.Input::get_touchSupported()";
    public const string IL2CPP_GetAccelerationEvent_Injected = "UnityEngine.Input::GetAccelerationEvent_Injected(System.Int32,UnityEngine.AccelerationEvent&)";
    public const string IL2CPP_GetAxis = "UnityEngine.Input::GetAxis(System.String)";
    public const string IL2CPP_GetAxisRaw = "UnityEngine.Input::GetAxisRaw(System.String)";
    public const string IL2CPP_GetButton = "UnityEngine.Input::GetButton(System.String)";
    public const string IL2CPP_GetButtonDown = "UnityEngine.Input::GetButtonDown(System.String)";
    public const string IL2CPP_GetButtonUp = "UnityEngine.Input::GetButtonUp(System.String)";
    public const string IL2CPP_GetGyroInternal = "UnityEngine.Input::GetGyroInternal()";
    public const string IL2CPP_GetJoystickNames = "UnityEngine.Input::GetJoystickNames()";
    public const string IL2CPP_GetKeyDownInt = "UnityEngine.Input::GetKeyDownInt(UnityEngine.KeyCode)";
    public const string IL2CPP_GetKeyDownString = "UnityEngine.Input::GetKeyDownString(System.String)";
    public const string IL2CPP_GetKeyInt = "UnityEngine.Input::GetKeyInt(UnityEngine.KeyCode)";
    public const string IL2CPP_GetKeyString = "UnityEngine.Input::GetKeyString(System.String)";
    public const string IL2CPP_GetKeyUpInt = "UnityEngine.Input::GetKeyUpInt(UnityEngine.KeyCode)";
    public const string IL2CPP_GetKeyUpString = "UnityEngine.Input::GetKeyUpString(System.String)";
    public const string IL2CPP_GetMouseButton = "UnityEngine.Input::GetMouseButton(System.Int32)";
    public const string IL2CPP_GetMouseButtonDown = "UnityEngine.Input::GetMouseButtonDown(System.Int32)";
    public const string IL2CPP_GetMouseButtonUp = "UnityEngine.Input::GetMouseButtonUp(System.Int32)";
    public const string IL2CPP_GetTouch_Injected = "UnityEngine.Input::GetTouch_Injected(System.Int32,UnityEngine.Touch&)";
    public const string IL2CPP_ResetInputAxes = "UnityEngine.Input::ResetInputAxes()";
    public const string IL2CPP_set_backButtonLeavesApp = "UnityEngine.Input::set_backButtonLeavesApp(System.Boolean)";
    public const string IL2CPP_set_compensateSensors = "UnityEngine.Input::set_compensateSensors(System.Boolean)";
    public const string IL2CPP_set_compositionCursorPos_Injected = "UnityEngine.Input::set_compositionCursorPos_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_set_eatKeyPressOnTextFieldFocus = "UnityEngine.Input::set_eatKeyPressOnTextFieldFocus(System.Boolean)";
    public const string IL2CPP_set_imeCompositionMode = "UnityEngine.Input::set_imeCompositionMode(UnityEngine.IMECompositionMode)";
    public const string IL2CPP_set_multiTouchEnabled = "UnityEngine.Input::set_multiTouchEnabled(System.Boolean)";
    public const string IL2CPP_set_simulateMouseWithTouches = "UnityEngine.Input::set_simulateMouseWithTouches(System.Boolean)";
    public const string IL2CPP_SimulateTouchInternal_Injected = "UnityEngine.Input::SimulateTouchInternal_Injected(UnityEngine.Touch&,System.Int64)";
}

