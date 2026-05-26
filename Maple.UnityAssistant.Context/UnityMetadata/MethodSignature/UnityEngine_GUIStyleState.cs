namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUIStyleState
{
    public const string MONO_Cleanup = "UnityEngine.GUIStyleState::Cleanup";
    public const string MONO_GetBackground = "UnityEngine.GUIStyleState::get_background";
    public const string MONO_GetTextColorInjected = "UnityEngine.GUIStyleState::get_textColor_Injected";
    public const string MONO_Init = "UnityEngine.GUIStyleState::Init";
    public const string MONO_SetBackground = "UnityEngine.GUIStyleState::set_background";
    public const string MONO_SetTextColorInjected = "UnityEngine.GUIStyleState::set_textColor_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUIStyleState : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUIStyleState(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUIStyleState(nint ptr) => new Ptr_UnityEngine_GUIStyleState(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUIStyleState ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUIStyleState ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Cleanup = "UnityEngine.GUIStyleState::Cleanup()";
    public const string IL2CPP_get_background = "UnityEngine.GUIStyleState::get_background()";
    public const string IL2CPP_get_textColor_Injected = "UnityEngine.GUIStyleState::get_textColor_Injected(UnityEngine.Color&)";
    public const string IL2CPP_Init = "UnityEngine.GUIStyleState::Init()";
    public const string IL2CPP_set_background = "UnityEngine.GUIStyleState::set_background(UnityEngine.Texture2D)";
    public const string IL2CPP_set_textColor_Injected = "UnityEngine.GUIStyleState::set_textColor_Injected(UnityEngine.Color&)";
}

