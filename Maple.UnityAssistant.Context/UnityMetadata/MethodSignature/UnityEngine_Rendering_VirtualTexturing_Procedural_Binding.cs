namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_VirtualTexturing_Procedural_Binding
{
    public const string MONO_BindGlobally = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::BindGlobally";
    public const string MONO_BindToMaterial = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::BindToMaterial";
    public const string MONO_BindToMaterialPropertyBlock = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::BindToMaterialPropertyBlock";
    public const string MONO_CreateInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::Create_Injected";
    public const string MONO_Destroy = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::Destroy";
    public const string MONO_EvictRegionInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::EvictRegion_Injected";
    public const string MONO_GetRequestParameters = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::GetRequestParameters";
    public const string MONO_InvalidateRegionInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::InvalidateRegion_Injected";
    public const string MONO_PopRequests = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::PopRequests";
    public const string MONO_RequestRegionInjected = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::RequestRegion_Injected";
    public const string MONO_UpdateRequestState = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::UpdateRequestState";
    public const string MONO_UpdateRequestStateWithCommandBuffer = "UnityEngine.Rendering.VirtualTexturing.Procedural/Binding::UpdateRequestStateWithCommandBuffer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding(nint ptr) => new Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_VirtualTexturing_Procedural_Binding ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
