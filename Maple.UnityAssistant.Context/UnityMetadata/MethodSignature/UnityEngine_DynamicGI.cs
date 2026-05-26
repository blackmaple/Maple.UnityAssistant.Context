namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_DynamicGI
{
    public const string MONO_GetAsyncMaterialUpdates = "UnityEngine.DynamicGI::get_asyncMaterialUpdates";
    public const string MONO_GetIndirectScale = "UnityEngine.DynamicGI::get_indirectScale";
    public const string MONO_GetIsConverged = "UnityEngine.DynamicGI::get_isConverged";
    public const string MONO_GetMaterialUpdateTimeSlice = "UnityEngine.DynamicGI::get_materialUpdateTimeSlice";
    public const string MONO_GetScheduledMaterialUpdatesCount = "UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount";
    public const string MONO_GetSynchronousMode = "UnityEngine.DynamicGI::get_synchronousMode";
    public const string MONO_GetUpdateThreshold = "UnityEngine.DynamicGI::get_updateThreshold";
    public const string MONO_SetAsyncMaterialUpdates = "UnityEngine.DynamicGI::set_asyncMaterialUpdates";
    public const string MONO_SetIndirectScale = "UnityEngine.DynamicGI::set_indirectScale";
    public const string MONO_SetMaterialUpdateTimeSlice = "UnityEngine.DynamicGI::set_materialUpdateTimeSlice";
    public const string MONO_SetSynchronousMode = "UnityEngine.DynamicGI::set_synchronousMode";
    public const string MONO_SetUpdateThreshold = "UnityEngine.DynamicGI::set_updateThreshold";
    public const string MONO_SetEmissiveInjected = "UnityEngine.DynamicGI::SetEmissive_Injected";
    public const string MONO_SetEnvironmentData = "UnityEngine.DynamicGI::SetEnvironmentData";
    public const string MONO_UpdateEnvironment = "UnityEngine.DynamicGI::UpdateEnvironment";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_DynamicGI : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_DynamicGI(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_DynamicGI(nint ptr) => new Ptr_UnityEngine_DynamicGI(ptr);
        public static implicit operator nint(Ptr_UnityEngine_DynamicGI ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_DynamicGI ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
