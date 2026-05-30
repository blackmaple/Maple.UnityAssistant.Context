using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.UnmanagedExtensions;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static partial class UnityEngine_Input
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

partial class UnityEngine_Input
{


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_AXIS(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.Core.PMonoString, float> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.Core.PMonoString, float>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public float Delegate(Maple.MonoGameAssistant.Core.PMonoString axisName) => this.m_Pointer(axisName);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_AXIS func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_AXIS(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_AXIS func) => func.Ptr;
        public override string ToString()
        {
            return Ptr.ToString("X8");
        }

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_AXIS_RAW(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, float> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, float>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public float Delegate(PMonoString axisName) => this.m_Pointer(axisName);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_AXIS_RAW func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_AXIS_RAW(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_AXIS_RAW func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }



    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_DOWN_INT(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(KeyCode key) => this.m_Pointer(key);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_DOWN_INT func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_DOWN_INT(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_DOWN_INT func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_DOWN_STRING(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(PMonoString name) => this.m_Pointer(name);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_DOWN_STRING func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_DOWN_STRING(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_DOWN_STRING func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_INT(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(KeyCode key) => this.m_Pointer(key);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_INT func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_INT(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_INT func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_STRING(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(PMonoString name) => this.m_Pointer(name);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_STRING func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_STRING(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_STRING func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_UP_INT(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(KeyCode key) => this.m_Pointer(key);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_UP_INT func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_UP_INT(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_UP_INT func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_UP_STRING(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(PMonoString name) => this.m_Pointer(name);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_KEY_UP_STRING func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_KEY_UP_STRING(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_KEY_UP_STRING func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_BUTTON(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(int button) => this.m_Pointer(button);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_MOUSE_BUTTON func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_MOUSE_BUTTON(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_MOUSE_BUTTON func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_BUTTON_DOWN(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(int button) => this.m_Pointer(button);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_MOUSE_BUTTON_DOWN func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_MOUSE_BUTTON_DOWN(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_MOUSE_BUTTON_DOWN func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_BUTTON_UP(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(int button) => this.m_Pointer(button);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_MOUSE_BUTTON_UP func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_MOUSE_BUTTON_UP(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_MOUSE_BUTTON_UP func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_POSITION_INJECTED(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Ref_Vector3>, void> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Ref_Vector3>, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(UnsafeOut<Ref_Vector3> ret) => this.m_Pointer(ret);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_MOUSE_POSITION_INJECTED func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_MOUSE_POSITION_INJECTED(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_MOUSE_POSITION_INJECTED func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Ref_Vector2>, void> m_Pointer =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Ref_Vector2>, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(UnsafeOut<Ref_Vector2> ret) => this.m_Pointer(ret);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_SET_IME_COMPOSITION_MODE(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[SuppressGCTransition]<IMECompositionMode, void> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition]<IMECompositionMode, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(IMECompositionMode value) => this.m_Pointer(value);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_SET_IME_COMPOSITION_MODE func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_SET_IME_COMPOSITION_MODE(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_SET_IME_COMPOSITION_MODE func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }

    internal static PTR_FUNC_GET_AXIS s_PTR_FUNC_GET_AXIS;
    internal static PTR_FUNC_GET_AXIS_RAW s_PTR_FUNC_GET_AXIS_RAW;
    internal static PTR_FUNC_GET_KEY_DOWN_INT s_PTR_FUNC_GET_KEY_DOWN_INT;
    internal static PTR_FUNC_GET_KEY_DOWN_STRING s_PTR_FUNC_GET_KEY_DOWN_STRING;
    internal static PTR_FUNC_GET_KEY_INT s_PTR_FUNC_GET_KEY_INT;
    internal static PTR_FUNC_GET_KEY_STRING s_PTR_FUNC_GET_KEY_STRING;
    internal static PTR_FUNC_GET_KEY_UP_INT s_PTR_FUNC_GET_KEY_UP_INT;
    internal static PTR_FUNC_GET_KEY_UP_STRING s_PTR_FUNC_GET_KEY_UP_STRING;
    internal static PTR_FUNC_GET_MOUSE_BUTTON s_PTR_FUNC_GET_MOUSE_BUTTON;
    internal static PTR_FUNC_GET_MOUSE_BUTTON_DOWN s_PTR_FUNC_GET_MOUSE_BUTTON_DOWN;
    internal static PTR_FUNC_GET_MOUSE_BUTTON_UP s_PTR_FUNC_GET_MOUSE_BUTTON_UP;
    internal static PTR_FUNC_GET_MOUSE_POSITION_INJECTED s_PTR_FUNC_GET_MOUSE_POSITION_INJECTED;
    internal static PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED s_PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED;
    internal static PTR_FUNC_SET_IME_COMPOSITION_MODE s_PTR_FUNC_SET_IME_COMPOSITION_MODE;

    partial struct Ptr_UnityEngine_Input
    {
        public static float GetAxis(PMonoString axisName) => s_PTR_FUNC_GET_AXIS.Delegate(axisName);
        public static float GetAxisRaw(PMonoString axisName) => s_PTR_FUNC_GET_AXIS_RAW.Delegate(axisName);
        public static bool GetKeyDown(KeyCode key) => s_PTR_FUNC_GET_KEY_DOWN_INT.Delegate(key);
        public static bool GetKeyDown(PMonoString name) => s_PTR_FUNC_GET_KEY_DOWN_STRING.Delegate(name);
        public static bool GetKey(KeyCode key) => s_PTR_FUNC_GET_KEY_INT.Delegate(key);
        public static bool GetKey(PMonoString name) => s_PTR_FUNC_GET_KEY_STRING.Delegate(name);
        public static bool GetKeyUp(KeyCode key) => s_PTR_FUNC_GET_KEY_UP_INT.Delegate(key);
        public static bool GetKeyUp(PMonoString name) => s_PTR_FUNC_GET_KEY_UP_STRING.Delegate(name);
        public static bool GetMouseButton(int button) => s_PTR_FUNC_GET_MOUSE_BUTTON.Delegate(button);
        public static bool GetMouseButtonDown(int button) => s_PTR_FUNC_GET_MOUSE_BUTTON_DOWN.Delegate(button);
        public static bool GetMouseButtonUp(int button) => s_PTR_FUNC_GET_MOUSE_BUTTON_UP.Delegate(button);
        public static void GetMousePositionInjected(UnsafeOut<Ref_Vector3> ret) => s_PTR_FUNC_GET_MOUSE_POSITION_INJECTED.Delegate(ret);
        public static void GetMouseScrollDeltaInjected(UnsafeOut<Ref_Vector2> ret) => s_PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED.Delegate(ret);
        public static void SetImeCompositionMode(IMECompositionMode value) => s_PTR_FUNC_SET_IME_COMPOSITION_MODE.Delegate(value);
    }


    public static void Initialize(UnityMetadataSearchService metadataSearchService)
    {
        s_PTR_FUNC_GET_AXIS = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS));
        s_PTR_FUNC_GET_AXIS_RAW = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS_RAW));
        s_PTR_FUNC_GET_KEY_DOWN_INT = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_INT));
        s_PTR_FUNC_GET_KEY_DOWN_STRING = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_STRING));
        s_PTR_FUNC_GET_KEY_INT = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_INT));
        s_PTR_FUNC_GET_KEY_STRING = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_STRING));
        s_PTR_FUNC_GET_KEY_UP_INT = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_INT));
        s_PTR_FUNC_GET_KEY_UP_STRING = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_STRING));
        s_PTR_FUNC_GET_MOUSE_BUTTON = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON));
        s_PTR_FUNC_GET_MOUSE_BUTTON_DOWN = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_DOWN));
        s_PTR_FUNC_GET_MOUSE_BUTTON_UP = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_UP));
        s_PTR_FUNC_GET_MOUSE_POSITION_INJECTED = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_POSITION_INJECTED));
        s_PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED));
        s_PTR_FUNC_SET_IME_COMPOSITION_MODE = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Input.PTR_FUNC_SET_IME_COMPOSITION_MODE));
    }
}
    public enum IMECompositionMode
    {
        Auto,
        On,
        Off,
    }

    public enum KeyCode
    {
        None = 0,
        Backspace = 8,
        Delete = 127,
        Tab = 9,
        Clear = 12,
        Return = 13,
        Pause = 19,
        Escape = 27,
        Space = 32,
        Keypad0 = 256,
        Keypad1 = 257,
        Keypad2 = 258,
        Keypad3 = 259,
        Keypad4 = 260,
        Keypad5 = 261,
        Keypad6 = 262,
        Keypad7 = 263,
        Keypad8 = 264,
        Keypad9 = 265,
        KeypadPeriod = 266,
        KeypadDivide = 267,
        KeypadMultiply = 268,
        KeypadMinus = 269,
        KeypadPlus = 270,
        KeypadEnter = 271,
        KeypadEquals = 272,
        UpArrow = 273,
        DownArrow = 274,
        RightArrow = 275,
        LeftArrow = 276,
        Insert = 277,
        Home = 278,
        End = 279,
        PageUp = 280,
        PageDown = 281,
        F1 = 282,
        F2 = 283,
        F3 = 284,
        F4 = 285,
        F5 = 286,
        F6 = 287,
        F7 = 288,
        F8 = 289,
        F9 = 290,
        F10 = 291,
        F11 = 292,
        F12 = 293,
        F13 = 294,
        F14 = 295,
        F15 = 296,
        Alpha0 = 48,
        Alpha1 = 49,
        Alpha2 = 50,
        Alpha3 = 51,
        Alpha4 = 52,
        Alpha5 = 53,
        Alpha6 = 54,
        Alpha7 = 55,
        Alpha8 = 56,
        Alpha9 = 57,
        Exclaim = 33,
        DoubleQuote = 34,
        Hash = 35,
        Dollar = 36,
        Percent = 37,
        Ampersand = 38,
        Quote = 39,
        LeftParen = 40,
        RightParen = 41,
        Asterisk = 42,
        Plus = 43,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        Colon = 58,
        Semicolon = 59,
        Less = 60,
        Equals = 61,
        Greater = 62,
        Question = 63,
        At = 64,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        Caret = 94,
        Underscore = 95,
        BackQuote = 96,
        A = 97,
        B = 98,
        C = 99,
        D = 100,
        E = 101,
        F = 102,
        G = 103,
        H = 104,
        I = 105,
        J = 106,
        K = 107,
        L = 108,
        M = 109,
        N = 110,
        O = 111,
        P = 112,
        Q = 113,
        R = 114,
        S = 115,
        T = 116,
        U = 117,
        V = 118,
        W = 119,
        X = 120,
        Y = 121,
        Z = 122,
        LeftCurlyBracket = 123,
        Pipe = 124,
        RightCurlyBracket = 125,
        Tilde = 126,
        Numlock = 300,
        CapsLock = 301,
        ScrollLock = 302,
        RightShift = 303,
        LeftShift = 304,
        RightControl = 305,
        LeftControl = 306,
        RightAlt = 307,
        LeftAlt = 308,
        LeftCommand = 310,
        LeftApple = 310,
        LeftWindows = 311,
        RightCommand = 309,
        RightApple = 309,
        RightWindows = 312,
        AltGr = 313,
        Help = 315,
        Print = 316,
        SysReq = 317,
        Break = 318,
        Menu = 319,
        Mouse0 = 323,
        Mouse1 = 324,
        Mouse2 = 325,
        Mouse3 = 326,
        Mouse4 = 327,
        Mouse5 = 328,
        Mouse6 = 329,
        JoystickButton0 = 330,
        JoystickButton1 = 331,
        JoystickButton2 = 332,
        JoystickButton3 = 333,
        JoystickButton4 = 334,
        JoystickButton5 = 335,
        JoystickButton6 = 336,
        JoystickButton7 = 337,
        JoystickButton8 = 338,
        JoystickButton9 = 339,
        JoystickButton10 = 340,
        JoystickButton11 = 341,
        JoystickButton12 = 342,
        JoystickButton13 = 343,
        JoystickButton14 = 344,
        JoystickButton15 = 345,
        JoystickButton16 = 346,
        JoystickButton17 = 347,
        JoystickButton18 = 348,
        JoystickButton19 = 349,
        Joystick1Button0 = 350,
        Joystick1Button1 = 351,
        Joystick1Button2 = 352,
        Joystick1Button3 = 353,
        Joystick1Button4 = 354,
        Joystick1Button5 = 355,
        Joystick1Button6 = 356,
        Joystick1Button7 = 357,
        Joystick1Button8 = 358,
        Joystick1Button9 = 359,
        Joystick1Button10 = 360,
        Joystick1Button11 = 361,
        Joystick1Button12 = 362,
        Joystick1Button13 = 363,
        Joystick1Button14 = 364,
        Joystick1Button15 = 365,
        Joystick1Button16 = 366,
        Joystick1Button17 = 367,
        Joystick1Button18 = 368,
        Joystick1Button19 = 369,
        Joystick2Button0 = 370,
        Joystick2Button1 = 371,
        Joystick2Button2 = 372,
        Joystick2Button3 = 373,
        Joystick2Button4 = 374,
        Joystick2Button5 = 375,
        Joystick2Button6 = 376,
        Joystick2Button7 = 377,
        Joystick2Button8 = 378,
        Joystick2Button9 = 379,
        Joystick2Button10 = 380,
        Joystick2Button11 = 381,
        Joystick2Button12 = 382,
        Joystick2Button13 = 383,
        Joystick2Button14 = 384,
        Joystick2Button15 = 385,
        Joystick2Button16 = 386,
        Joystick2Button17 = 387,
        Joystick2Button18 = 388,
        Joystick2Button19 = 389,
        Joystick3Button0 = 390,
        Joystick3Button1 = 391,
        Joystick3Button2 = 392,
        Joystick3Button3 = 393,
        Joystick3Button4 = 394,
        Joystick3Button5 = 395,
        Joystick3Button6 = 396,
        Joystick3Button7 = 397,
        Joystick3Button8 = 398,
        Joystick3Button9 = 399,
        Joystick3Button10 = 400,
        Joystick3Button11 = 401,
        Joystick3Button12 = 402,
        Joystick3Button13 = 403,
        Joystick3Button14 = 404,
        Joystick3Button15 = 405,
        Joystick3Button16 = 406,
        Joystick3Button17 = 407,
        Joystick3Button18 = 408,
        Joystick3Button19 = 409,
        Joystick4Button0 = 410,
        Joystick4Button1 = 411,
        Joystick4Button2 = 412,
        Joystick4Button3 = 413,
        Joystick4Button4 = 414,
        Joystick4Button5 = 415,
        Joystick4Button6 = 416,
        Joystick4Button7 = 417,
        Joystick4Button8 = 418,
        Joystick4Button9 = 419,
        Joystick4Button10 = 420,
        Joystick4Button11 = 421,
        Joystick4Button12 = 422,
        Joystick4Button13 = 423,
        Joystick4Button14 = 424,
        Joystick4Button15 = 425,
        Joystick4Button16 = 426,
        Joystick4Button17 = 427,
        Joystick4Button18 = 428,
        Joystick4Button19 = 429,
        Joystick5Button0 = 430,
        Joystick5Button1 = 431,
        Joystick5Button2 = 432,
        Joystick5Button3 = 433,
        Joystick5Button4 = 434,
        Joystick5Button5 = 435,
        Joystick5Button6 = 436,
        Joystick5Button7 = 437,
        Joystick5Button8 = 438,
        Joystick5Button9 = 439,
        Joystick5Button10 = 440,
        Joystick5Button11 = 441,
        Joystick5Button12 = 442,
        Joystick5Button13 = 443,
        Joystick5Button14 = 444,
        Joystick5Button15 = 445,
        Joystick5Button16 = 446,
        Joystick5Button17 = 447,
        Joystick5Button18 = 448,
        Joystick5Button19 = 449,
        Joystick6Button0 = 450,
        Joystick6Button1 = 451,
        Joystick6Button2 = 452,
        Joystick6Button3 = 453,
        Joystick6Button4 = 454,
        Joystick6Button5 = 455,
        Joystick6Button6 = 456,
        Joystick6Button7 = 457,
        Joystick6Button8 = 458,
        Joystick6Button9 = 459,
        Joystick6Button10 = 460,
        Joystick6Button11 = 461,
        Joystick6Button12 = 462,
        Joystick6Button13 = 463,
        Joystick6Button14 = 464,
        Joystick6Button15 = 465,
        Joystick6Button16 = 466,
        Joystick6Button17 = 467,
        Joystick6Button18 = 468,
        Joystick6Button19 = 469,
        Joystick7Button0 = 470,
        Joystick7Button1 = 471,
        Joystick7Button2 = 472,
        Joystick7Button3 = 473,
        Joystick7Button4 = 474,
        Joystick7Button5 = 475,
        Joystick7Button6 = 476,
        Joystick7Button7 = 477,
        Joystick7Button8 = 478,
        Joystick7Button9 = 479,
        Joystick7Button10 = 480,
        Joystick7Button11 = 481,
        Joystick7Button12 = 482,
        Joystick7Button13 = 483,
        Joystick7Button14 = 484,
        Joystick7Button15 = 485,
        Joystick7Button16 = 486,
        Joystick7Button17 = 487,
        Joystick7Button18 = 488,
        Joystick7Button19 = 489,
        Joystick8Button0 = 490,
        Joystick8Button1 = 491,
        Joystick8Button2 = 492,
        Joystick8Button3 = 493,
        Joystick8Button4 = 494,
        Joystick8Button5 = 495,
        Joystick8Button6 = 496,
        Joystick8Button7 = 497,
        Joystick8Button8 = 498,
        Joystick8Button9 = 499,
        Joystick8Button10 = 500,
        Joystick8Button11 = 501,
        Joystick8Button12 = 502,
        Joystick8Button13 = 503,
        Joystick8Button14 = 504,
        Joystick8Button15 = 505,
        Joystick8Button16 = 506,
        Joystick8Button17 = 507,
        Joystick8Button18 = 508,
        Joystick8Button19 = 509
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Ref_Vector3
    {
        [MarshalAs(UnmanagedType.R4)]
        public float x;

        [MarshalAs(UnmanagedType.R4)]
        public float y;


        [MarshalAs(UnmanagedType.R4)]
        public float z;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Ref_Vector2
    {
        [MarshalAs(UnmanagedType.R4)]
        public float x;

        [MarshalAs(UnmanagedType.R4)]
        public float y;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Ref_Rect
    {
        [MarshalAs(UnmanagedType.R4)]
        public float m_XMin;

        [MarshalAs(UnmanagedType.R4)]
        public float m_YMin;

        [MarshalAs(UnmanagedType.R4)]
        public float m_Width;

        [MarshalAs(UnmanagedType.R4)]
        public float m_Height;
    }
