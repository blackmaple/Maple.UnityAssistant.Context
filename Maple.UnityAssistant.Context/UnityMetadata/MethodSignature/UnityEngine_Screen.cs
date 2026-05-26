namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Screen
{
    public const string MONO_GetBrightness = "UnityEngine.Screen::get_brightness";
    public const string MONO_GetCurrentResolutionInjected = "UnityEngine.Screen::get_currentResolution_Injected";
    public const string MONO_GetCutouts = "UnityEngine.Screen::get_cutouts";
    public const string MONO_GetDpi = "UnityEngine.Screen::get_dpi";
    public const string MONO_GetFullScreen = "UnityEngine.Screen::get_fullScreen";
    public const string MONO_GetFullScreenMode = "UnityEngine.Screen::get_fullScreenMode";
    public const string MONO_GetHeight = "UnityEngine.Screen::get_height";
    public const string MONO_GetResolutions = "UnityEngine.Screen::get_resolutions";
    public const string MONO_GetSafeAreaInjected = "UnityEngine.Screen::get_safeArea_Injected";
    public const string MONO_GetSleepTimeout = "UnityEngine.Screen::get_sleepTimeout";
    public const string MONO_GetWidth = "UnityEngine.Screen::get_width";
    public const string MONO_GetDisplayLayoutImpl = "UnityEngine.Screen::GetDisplayLayoutImpl";
    public const string MONO_GetMainWindowDisplayInfoInjected = "UnityEngine.Screen::GetMainWindowDisplayInfo_Injected";
    public const string MONO_GetMainWindowPositionInjected = "UnityEngine.Screen::GetMainWindowPosition_Injected";
    public const string MONO_GetScreenOrientation = "UnityEngine.Screen::GetScreenOrientation";
    public const string MONO_IsOrientationEnabled = "UnityEngine.Screen::IsOrientationEnabled";
    public const string MONO_MoveMainWindowImplInjected = "UnityEngine.Screen::MoveMainWindowImpl_Injected";
    public const string MONO_RequestOrientation = "UnityEngine.Screen::RequestOrientation";
    public const string MONO_SetBrightness = "UnityEngine.Screen::set_brightness";
    public const string MONO_SetFullScreen = "UnityEngine.Screen::set_fullScreen";
    public const string MONO_SetFullScreenMode = "UnityEngine.Screen::set_fullScreenMode";
    public const string MONO_SetSleepTimeout = "UnityEngine.Screen::set_sleepTimeout";
    public const string MONO_SetOrientationEnabled = "UnityEngine.Screen::SetOrientationEnabled";
    public const string MONO_SetResolution = "UnityEngine.Screen::SetResolution";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Screen : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Screen(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Screen(nint ptr) => new Ptr_UnityEngine_Screen(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Screen ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Screen ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_brightness = "UnityEngine.Screen::get_brightness()";
    public const string IL2CPP_get_currentResolution_Injected = "UnityEngine.Screen::get_currentResolution_Injected(UnityEngine.Resolution&)";
    public const string IL2CPP_get_cutouts = "UnityEngine.Screen::get_cutouts()";
    public const string IL2CPP_get_dpi = "UnityEngine.Screen::get_dpi()";
    public const string IL2CPP_get_fullScreen = "UnityEngine.Screen::get_fullScreen()";
    public const string IL2CPP_get_fullScreenMode = "UnityEngine.Screen::get_fullScreenMode()";
    public const string IL2CPP_get_height = "UnityEngine.Screen::get_height()";
    public const string IL2CPP_get_resolutions = "UnityEngine.Screen::get_resolutions()";
    public const string IL2CPP_get_safeArea_Injected = "UnityEngine.Screen::get_safeArea_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_get_sleepTimeout = "UnityEngine.Screen::get_sleepTimeout()";
    public const string IL2CPP_get_width = "UnityEngine.Screen::get_width()";
    public const string IL2CPP_GetDisplayLayoutImpl = "UnityEngine.Screen::GetDisplayLayoutImpl(System.Collections.Generic.List`1<UnityEngine.DisplayInfo>)";
    public const string IL2CPP_GetMainWindowDisplayInfo_Injected = "UnityEngine.Screen::GetMainWindowDisplayInfo_Injected(UnityEngine.DisplayInfo&)";
    public const string IL2CPP_GetMainWindowPosition_Injected = "UnityEngine.Screen::GetMainWindowPosition_Injected(UnityEngine.Vector2Int&)";
    public const string IL2CPP_GetScreenOrientation = "UnityEngine.Screen::GetScreenOrientation()";
    public const string IL2CPP_IsOrientationEnabled = "UnityEngine.Screen::IsOrientationEnabled(UnityEngine.EnabledOrientation)";
    public const string IL2CPP_MoveMainWindowImpl_Injected = "UnityEngine.Screen::MoveMainWindowImpl_Injected(UnityEngine.DisplayInfo&,UnityEngine.Vector2Int&)";
    public const string IL2CPP_RequestOrientation = "UnityEngine.Screen::RequestOrientation(UnityEngine.ScreenOrientation)";
    public const string IL2CPP_set_brightness = "UnityEngine.Screen::set_brightness(System.Single)";
    public const string IL2CPP_set_fullScreen = "UnityEngine.Screen::set_fullScreen(System.Boolean)";
    public const string IL2CPP_set_fullScreenMode = "UnityEngine.Screen::set_fullScreenMode(UnityEngine.FullScreenMode)";
    public const string IL2CPP_set_sleepTimeout = "UnityEngine.Screen::set_sleepTimeout(System.Int32)";
    public const string IL2CPP_SetOrientationEnabled = "UnityEngine.Screen::SetOrientationEnabled(UnityEngine.EnabledOrientation,System.Boolean)";
    public const string IL2CPP_SetResolution = "UnityEngine.Screen::SetResolution(System.Int32,System.Int32,UnityEngine.FullScreenMode,System.Int32)";
}

