namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Debugging
{
    public const string MONO_GetDebugTilesEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::get_debugTilesEnabled";
    public const string MONO_GetFlushEveryTickEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::get_flushEveryTickEnabled";
    public const string MONO_GetResolvingEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::get_resolvingEnabled";
    public const string MONO_GetInfoDump = "UnityEngine.Rendering.VirtualTexturing.Debugging::GetInfoDump";
    public const string MONO_GetNumHandles = "UnityEngine.Rendering.VirtualTexturing.Debugging::GetNumHandles";
    public const string MONO_GrabHandleInfo = "UnityEngine.Rendering.VirtualTexturing.Debugging::GrabHandleInfo";
    public const string MONO_SetDebugTilesEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::set_debugTilesEnabled";
    public const string MONO_SetFlushEveryTickEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::set_flushEveryTickEnabled";
    public const string MONO_SetResolvingEnabled = "UnityEngine.Rendering.VirtualTexturing.Debugging::set_resolvingEnabled";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Debugging ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
