namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RectTransformUtility
{
    public const string MONO_PixelAdjustPointInjected = "UnityEngine.RectTransformUtility::PixelAdjustPoint_Injected";
    public const string MONO_PixelAdjustRectInjected = "UnityEngine.RectTransformUtility::PixelAdjustRect_Injected";
    public const string MONO_PointInRectangleInjected = "UnityEngine.RectTransformUtility::PointInRectangle_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RectTransformUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RectTransformUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RectTransformUtility(nint ptr) => new Ptr_UnityEngine_RectTransformUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RectTransformUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RectTransformUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_PixelAdjustPoint_Injected = "UnityEngine.RectTransformUtility::PixelAdjustPoint_Injected(UnityEngine.Vector2&,UnityEngine.Transform,UnityEngine.Canvas,UnityEngine.Vector2&)";
    public const string IL2CPP_PixelAdjustRect_Injected = "UnityEngine.RectTransformUtility::PixelAdjustRect_Injected(UnityEngine.RectTransform,UnityEngine.Canvas,UnityEngine.Rect&)";
    public const string IL2CPP_PointInRectangle_Injected = "UnityEngine.RectTransformUtility::PointInRectangle_Injected(UnityEngine.Vector2&,UnityEngine.RectTransform,UnityEngine.Camera,UnityEngine.Vector4&)";
}

