namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Rendering_GraphicsDeviceSettings
{
    public const string MONO_GetGraphicsJobsSyncPoint = "UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint";
    public const string MONO_GetWaitForPresentSyncPoint = "UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint";
    public const string MONO_SetGraphicsJobsSyncPoint = "UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint";
    public const string MONO_SetWaitForPresentSyncPoint = "UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings(nint ptr) => new Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
