namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LayerMask
{
    public const string MONO_LayerToName = "UnityEngine.LayerMask::LayerToName";
    public const string MONO_NameToLayer = "UnityEngine.LayerMask::NameToLayer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LayerMask : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LayerMask(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LayerMask(nint ptr) => new Ptr_UnityEngine_LayerMask(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LayerMask ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LayerMask ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_LayerToName = "UnityEngine.LayerMask::LayerToName(System.Int32)";
    public const string IL2CPP_NameToLayer = "UnityEngine.LayerMask::NameToLayer(System.String)";
}

