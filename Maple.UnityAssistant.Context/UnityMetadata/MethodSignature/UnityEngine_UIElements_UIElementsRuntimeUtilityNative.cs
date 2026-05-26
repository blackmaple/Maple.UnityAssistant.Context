namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_UIElements_UIElementsRuntimeUtilityNative
{
    public const string MONO_RegisterPlayerloopCallback = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::RegisterPlayerloopCallback";
    public const string MONO_UnregisterPlayerloopCallback = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::UnregisterPlayerloopCallback";
    public const string MONO_VisualElementCreation = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::VisualElementCreation";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative(nint ptr) => new Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative(ptr);
        public static implicit operator nint(Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_UIElements_UIElementsRuntimeUtilityNative ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_RegisterPlayerloopCallback = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::RegisterPlayerloopCallback()";
    public const string IL2CPP_UnregisterPlayerloopCallback = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::UnregisterPlayerloopCallback()";
    public const string IL2CPP_VisualElementCreation = "UnityEngine.UIElements.UIElementsRuntimeUtilityNative::VisualElementCreation()";
}

