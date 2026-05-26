namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_UIElements_TextNative
{
    public const string MONO_DoComputeTextHeightInjected = "UnityEngine.UIElements.TextNative::DoComputeTextHeight_Injected";
    public const string MONO_DoComputeTextWidthInjected = "UnityEngine.UIElements.TextNative::DoComputeTextWidth_Injected";
    public const string MONO_DoGetCursorPositionInjected = "UnityEngine.UIElements.TextNative::DoGetCursorPosition_Injected";
    public const string MONO_DoGetOffsetInjected = "UnityEngine.UIElements.TextNative::DoGetOffset_Injected";
    public const string MONO_GetVerticesInjected = "UnityEngine.UIElements.TextNative::GetVertices_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_UIElements_TextNative : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_UIElements_TextNative(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_UIElements_TextNative(nint ptr) => new Ptr_UnityEngine_UIElements_TextNative(ptr);
        public static implicit operator nint(Ptr_UnityEngine_UIElements_TextNative ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_UIElements_TextNative ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DoComputeTextHeight_Injected = "UnityEngine.UIElements.TextNative::DoComputeTextHeight_Injected(UnityEngine.UIElements.TextNativeSettings&)";
    public const string IL2CPP_DoComputeTextWidth_Injected = "UnityEngine.UIElements.TextNative::DoComputeTextWidth_Injected(UnityEngine.UIElements.TextNativeSettings&)";
    public const string IL2CPP_DoGetCursorPosition_Injected = "UnityEngine.UIElements.TextNative::DoGetCursorPosition_Injected(UnityEngine.UIElements.TextNativeSettings&,UnityEngine.Rect&,System.Int32,UnityEngine.Vector2&)";
    public const string IL2CPP_DoGetOffset_Injected = "UnityEngine.UIElements.TextNative::DoGetOffset_Injected(UnityEngine.UIElements.TextNativeSettings&,UnityEngine.Rect&,UnityEngine.Vector2&)";
    public const string IL2CPP_GetVertices_Injected = "UnityEngine.UIElements.TextNative::GetVertices_Injected(UnityEngine.UIElements.TextNativeSettings&,System.IntPtr,System.Int32,System.Int32&)";
}

