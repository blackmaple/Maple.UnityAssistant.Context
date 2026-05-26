namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_VFX_VisualEffectAsset
{
    public const string MONO_GetEvents = "UnityEngine.VFX.VisualEffectAsset::GetEvents";
    public const string MONO_GetExposedProperties = "UnityEngine.VFX.VisualEffectAsset::GetExposedProperties";
    public const string MONO_GetTextureDimension = "UnityEngine.VFX.VisualEffectAsset::GetTextureDimension";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_VFX_VisualEffectAsset : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_VFX_VisualEffectAsset(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_VFX_VisualEffectAsset(nint ptr) => new Ptr_UnityEngine_VFX_VisualEffectAsset(ptr);
        public static implicit operator nint(Ptr_UnityEngine_VFX_VisualEffectAsset ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_VFX_VisualEffectAsset ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
