namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TouchScreenKeyboard_Android
{
    public const string MONO_TouchScreenKeyboardGetAndroidKeyboardConsumesOutsideTouches = "UnityEngine.TouchScreenKeyboard/Android::TouchScreenKeyboard_GetAndroidKeyboardConsumesOutsideTouches";
    public const string MONO_TouchScreenKeyboardSetAndroidKeyboardConsumesOutsideTouches = "UnityEngine.TouchScreenKeyboard/Android::TouchScreenKeyboard_SetAndroidKeyboardConsumesOutsideTouches";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TouchScreenKeyboard_Android : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TouchScreenKeyboard_Android(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TouchScreenKeyboard_Android(nint ptr) => new Ptr_UnityEngine_TouchScreenKeyboard_Android(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TouchScreenKeyboard_Android ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TouchScreenKeyboard_Android ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
