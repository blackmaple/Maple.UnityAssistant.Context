namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_VFX_VFXManager
{
    public const string MONO_GetFixedTimeStep = "UnityEngine.VFX.VFXManager::get_fixedTimeStep";
    public const string MONO_GetMaxDeltaTime = "UnityEngine.VFX.VFXManager::get_maxDeltaTime";
    public const string MONO_GetRenderPipeSettingsPath = "UnityEngine.VFX.VFXManager::get_renderPipeSettingsPath";
    public const string MONO_GetRuntimeResources = "UnityEngine.VFX.VFXManager::get_runtimeResources";
    public const string MONO_GetComponents = "UnityEngine.VFX.VFXManager::GetComponents";
    public const string MONO_IsCameraBufferNeeded = "UnityEngine.VFX.VFXManager::IsCameraBufferNeeded";
    public const string MONO_PrepareCameraInjected = "UnityEngine.VFX.VFXManager::PrepareCamera_Injected";
    public const string MONO_ProcessCameraCommandInjected = "UnityEngine.VFX.VFXManager::ProcessCameraCommand_Injected";
    public const string MONO_SetFixedTimeStep = "UnityEngine.VFX.VFXManager::set_fixedTimeStep";
    public const string MONO_SetMaxDeltaTime = "UnityEngine.VFX.VFXManager::set_maxDeltaTime";
    public const string MONO_SetCameraBuffer = "UnityEngine.VFX.VFXManager::SetCameraBuffer";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_VFX_VFXManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_VFX_VFXManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_VFX_VFXManager(nint ptr) => new Ptr_UnityEngine_VFX_VFXManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_VFX_VFXManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_VFX_VFXManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
