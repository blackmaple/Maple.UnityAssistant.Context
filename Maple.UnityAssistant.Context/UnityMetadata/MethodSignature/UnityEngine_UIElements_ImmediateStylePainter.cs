namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_UIElements_ImmediateStylePainter
{
    public const string MONO_DrawRectInjected = "UnityEngine.UIElements.ImmediateStylePainter::DrawRect_Injected";
    public const string MONO_DrawTextInjected = "UnityEngine.UIElements.ImmediateStylePainter::DrawText_Injected";
    public const string MONO_DrawTextureInjected = "UnityEngine.UIElements.ImmediateStylePainter::DrawTexture_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_UIElements_ImmediateStylePainter : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_UIElements_ImmediateStylePainter(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_UIElements_ImmediateStylePainter(nint ptr) => new Ptr_UnityEngine_UIElements_ImmediateStylePainter(ptr);
        public static implicit operator nint(Ptr_UnityEngine_UIElements_ImmediateStylePainter ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_UIElements_ImmediateStylePainter ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
