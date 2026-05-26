namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngineInternal_GraphicsDeviceDebug
{
    public const string MONO_GetSettingsInjected = "UnityEngineInternal.GraphicsDeviceDebug::get_settings_Injected";
    public const string MONO_SetSettingsInjected = "UnityEngineInternal.GraphicsDeviceDebug::set_settings_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngineInternal_GraphicsDeviceDebug : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngineInternal_GraphicsDeviceDebug(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngineInternal_GraphicsDeviceDebug(nint ptr) => new Ptr_UnityEngineInternal_GraphicsDeviceDebug(ptr);
        public static implicit operator nint(Ptr_UnityEngineInternal_GraphicsDeviceDebug ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngineInternal_GraphicsDeviceDebug ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
