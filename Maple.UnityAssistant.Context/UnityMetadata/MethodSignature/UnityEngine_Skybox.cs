namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Skybox
{
    public const string MONO_GetMaterial = "UnityEngine.Skybox::get_material";
    public const string MONO_SetMaterial = "UnityEngine.Skybox::set_material";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Skybox : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Skybox(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Skybox(nint ptr) => new Ptr_UnityEngine_Skybox(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Skybox ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Skybox ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_material = "UnityEngine.Skybox::get_material()";
}

