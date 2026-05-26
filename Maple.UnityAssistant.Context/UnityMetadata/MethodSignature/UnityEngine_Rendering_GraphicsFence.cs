namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_GraphicsFence
{
    public const string MONO_GetVersionNumber = "UnityEngine.Rendering.GraphicsFence::GetVersionNumber";
    public const string MONO_HasFencePassedInternal = "UnityEngine.Rendering.GraphicsFence::HasFencePassed_Internal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_GraphicsFence : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_GraphicsFence(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_GraphicsFence(nint ptr) => new Ptr_UnityEngine_Rendering_GraphicsFence(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_GraphicsFence ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_GraphicsFence ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetVersionNumber = "UnityEngine.Rendering.GraphicsFence::GetVersionNumber(System.IntPtr)";
}

