namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_SphericalHarmonicsL2
{
    public const string MONO_AddAmbientLightInjected = "UnityEngine.Rendering.SphericalHarmonicsL2::AddAmbientLight_Injected";
    public const string MONO_AddDirectionalLightInternalInjected = "UnityEngine.Rendering.SphericalHarmonicsL2::AddDirectionalLightInternal_Injected";
    public const string MONO_EvaluateInternal = "UnityEngine.Rendering.SphericalHarmonicsL2::EvaluateInternal";
    public const string MONO_SetZeroInjected = "UnityEngine.Rendering.SphericalHarmonicsL2::SetZero_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_SphericalHarmonicsL2 : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_SphericalHarmonicsL2(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_SphericalHarmonicsL2(nint ptr) => new Ptr_UnityEngine_Rendering_SphericalHarmonicsL2(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_SphericalHarmonicsL2 ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_SphericalHarmonicsL2 ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
