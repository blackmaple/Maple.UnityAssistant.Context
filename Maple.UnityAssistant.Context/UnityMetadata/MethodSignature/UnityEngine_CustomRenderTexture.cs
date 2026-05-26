namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CustomRenderTexture
{
    public const string MONO_ClearUpdateZones = "UnityEngine.CustomRenderTexture::ClearUpdateZones";
    public const string MONO_EnsureDoubleBufferConsistency = "UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency";
    public const string MONO_GetCubemapFaceMask = "UnityEngine.CustomRenderTexture::get_cubemapFaceMask";
    public const string MONO_GetDoubleBuffered = "UnityEngine.CustomRenderTexture::get_doubleBuffered";
    public const string MONO_GetInitializationColorInjected = "UnityEngine.CustomRenderTexture::get_initializationColor_Injected";
    public const string MONO_GetInitializationMaterial = "UnityEngine.CustomRenderTexture::get_initializationMaterial";
    public const string MONO_GetInitializationMode = "UnityEngine.CustomRenderTexture::get_initializationMode";
    public const string MONO_GetInitializationSource = "UnityEngine.CustomRenderTexture::get_initializationSource";
    public const string MONO_GetInitializationTexture = "UnityEngine.CustomRenderTexture::get_initializationTexture";
    public const string MONO_GetMaterial = "UnityEngine.CustomRenderTexture::get_material";
    public const string MONO_GetShaderPass = "UnityEngine.CustomRenderTexture::get_shaderPass";
    public const string MONO_GetUpdateMode = "UnityEngine.CustomRenderTexture::get_updateMode";
    public const string MONO_GetUpdatePeriod = "UnityEngine.CustomRenderTexture::get_updatePeriod";
    public const string MONO_GetUpdateZoneSpace = "UnityEngine.CustomRenderTexture::get_updateZoneSpace";
    public const string MONO_GetWrapUpdateZones = "UnityEngine.CustomRenderTexture::get_wrapUpdateZones";
    public const string MONO_GetDoubleBufferRenderTexture = "UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture";
    public const string MONO_GetUpdateZonesInternal = "UnityEngine.CustomRenderTexture::GetUpdateZonesInternal";
    public const string MONO_InternalCreateCustomRenderTexture = "UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture";
    public const string MONO_SetCubemapFaceMask = "UnityEngine.CustomRenderTexture::set_cubemapFaceMask";
    public const string MONO_SetDoubleBuffered = "UnityEngine.CustomRenderTexture::set_doubleBuffered";
    public const string MONO_SetInitializationColorInjected = "UnityEngine.CustomRenderTexture::set_initializationColor_Injected";
    public const string MONO_SetInitializationMaterial = "UnityEngine.CustomRenderTexture::set_initializationMaterial";
    public const string MONO_SetInitializationMode = "UnityEngine.CustomRenderTexture::set_initializationMode";
    public const string MONO_SetInitializationSource = "UnityEngine.CustomRenderTexture::set_initializationSource";
    public const string MONO_SetInitializationTexture = "UnityEngine.CustomRenderTexture::set_initializationTexture";
    public const string MONO_SetMaterial = "UnityEngine.CustomRenderTexture::set_material";
    public const string MONO_SetShaderPass = "UnityEngine.CustomRenderTexture::set_shaderPass";
    public const string MONO_SetUpdateMode = "UnityEngine.CustomRenderTexture::set_updateMode";
    public const string MONO_SetUpdatePeriod = "UnityEngine.CustomRenderTexture::set_updatePeriod";
    public const string MONO_SetUpdateZoneSpace = "UnityEngine.CustomRenderTexture::set_updateZoneSpace";
    public const string MONO_SetWrapUpdateZones = "UnityEngine.CustomRenderTexture::set_wrapUpdateZones";
    public const string MONO_SetUpdateZonesInternal = "UnityEngine.CustomRenderTexture::SetUpdateZonesInternal";
    public const string MONO_TriggerInitialization = "UnityEngine.CustomRenderTexture::TriggerInitialization";
    public const string MONO_TriggerUpdate = "UnityEngine.CustomRenderTexture::TriggerUpdate";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CustomRenderTexture : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CustomRenderTexture(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CustomRenderTexture(nint ptr) => new Ptr_UnityEngine_CustomRenderTexture(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CustomRenderTexture ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CustomRenderTexture ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
