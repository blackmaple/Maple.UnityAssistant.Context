namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Resolver
{
    public const string MONO_FlushInternal = "UnityEngine.Rendering.VirtualTexturing.Resolver::Flush_Internal";
    public const string MONO_InitInternal = "UnityEngine.Rendering.VirtualTexturing.Resolver::Init_Internal";
    public const string MONO_InitNative = "UnityEngine.Rendering.VirtualTexturing.Resolver::InitNative";
    public const string MONO_ReleaseNative = "UnityEngine.Rendering.VirtualTexturing.Resolver::ReleaseNative";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Resolver ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
