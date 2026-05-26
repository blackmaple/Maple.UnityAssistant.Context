namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Display
{
    public const string MONO_ActivateDisplayImpl = "UnityEngine.Display::ActivateDisplayImpl";
    public const string MONO_GetActiveImpl = "UnityEngine.Display::GetActiveImpl";
    public const string MONO_GetRenderingBuffersImpl = "UnityEngine.Display::GetRenderingBuffersImpl";
    public const string MONO_GetRenderingExtImpl = "UnityEngine.Display::GetRenderingExtImpl";
    public const string MONO_GetSystemExtImpl = "UnityEngine.Display::GetSystemExtImpl";
    public const string MONO_RelativeMouseAtImpl = "UnityEngine.Display::RelativeMouseAtImpl";
    public const string MONO_RequiresBlitToBackbufferImpl = "UnityEngine.Display::RequiresBlitToBackbufferImpl";
    public const string MONO_RequiresSrgbBlitToBackbufferImpl = "UnityEngine.Display::RequiresSrgbBlitToBackbufferImpl";
    public const string MONO_SetParamsImpl = "UnityEngine.Display::SetParamsImpl";
    public const string MONO_SetRenderingResolutionImpl = "UnityEngine.Display::SetRenderingResolutionImpl";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Display : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Display(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Display(nint ptr) => new Ptr_UnityEngine_Display(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Display ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Display ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetRenderingExtImpl = "UnityEngine.Display::GetRenderingExtImpl(System.IntPtr,System.Int32&,System.Int32&)";
    public const string IL2CPP_GetSystemExtImpl = "UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)";
    public const string IL2CPP_RelativeMouseAtImpl = "UnityEngine.Display::RelativeMouseAtImpl(System.Int32,System.Int32,System.Int32&,System.Int32&)";
    public const string IL2CPP_RequiresSrgbBlitToBackbufferImpl = "UnityEngine.Display::RequiresSrgbBlitToBackbufferImpl(System.IntPtr)";
}

