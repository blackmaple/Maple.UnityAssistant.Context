namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Procedural
{
    public const string MONO_GetCpucacheSize = "UnityEngine.Rendering.VirtualTexturing.Procedural::GetCPUCacheSize";
    public const string MONO_GetGpucacheSettings = "UnityEngine.Rendering.VirtualTexturing.Procedural::GetGPUCacheSettings";
    public const string MONO_SetCpucacheSize = "UnityEngine.Rendering.VirtualTexturing.Procedural::SetCPUCacheSize";
    public const string MONO_SetGpucacheSettings = "UnityEngine.Rendering.VirtualTexturing.Procedural::SetGPUCacheSettings";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
