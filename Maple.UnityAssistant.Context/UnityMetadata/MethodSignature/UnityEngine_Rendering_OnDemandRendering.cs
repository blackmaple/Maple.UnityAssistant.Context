namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_OnDemandRendering
{
    public const string MONO_GetEffectiveRenderFrameRate = "UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_OnDemandRendering : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_OnDemandRendering(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_OnDemandRendering(nint ptr) => new Ptr_UnityEngine_Rendering_OnDemandRendering(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_OnDemandRendering ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_OnDemandRendering ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
