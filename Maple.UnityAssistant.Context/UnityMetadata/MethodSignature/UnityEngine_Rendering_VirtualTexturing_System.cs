namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_System
{
    public const string MONO_GetEnabled = "UnityEngine.Rendering.VirtualTexturing.System::get_enabled";
    public const string MONO_SetDebugFlag = "UnityEngine.Rendering.VirtualTexturing.System::SetDebugFlag";
    public const string MONO_Update = "UnityEngine.Rendering.VirtualTexturing.System::Update";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_System : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_System(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_System(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_System(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_System ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_System ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
