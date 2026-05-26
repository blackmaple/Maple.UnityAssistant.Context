namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUILayoutUtility
{
    public const string MONO_GetWindowsBoundsInjected = "UnityEngine.GUILayoutUtility::GetWindowsBounds_Injected";
    public const string MONO_InternalGetWindowRectInjected = "UnityEngine.GUILayoutUtility::Internal_GetWindowRect_Injected";
    public const string MONO_InternalMoveWindowInjected = "UnityEngine.GUILayoutUtility::Internal_MoveWindow_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUILayoutUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUILayoutUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUILayoutUtility(nint ptr) => new Ptr_UnityEngine_GUILayoutUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUILayoutUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUILayoutUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_GetWindowRect_Injected = "UnityEngine.GUILayoutUtility::Internal_GetWindowRect_Injected(System.Int32,UnityEngine.Rect&)";
    public const string IL2CPP_Internal_MoveWindow_Injected = "UnityEngine.GUILayoutUtility::Internal_MoveWindow_Injected(System.Int32,UnityEngine.Rect&)";
}

