namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystemExtensionsImpl
{
    public const string MONO_GetCollisionEvents = "UnityEngine.ParticleSystemExtensionsImpl::GetCollisionEvents";
    public const string MONO_GetCollisionEventsDeprecated = "UnityEngine.ParticleSystemExtensionsImpl::GetCollisionEventsDeprecated";
    public const string MONO_GetSafeCollisionEventSize = "UnityEngine.ParticleSystemExtensionsImpl::GetSafeCollisionEventSize";
    public const string MONO_GetSafeTriggerParticlesSize = "UnityEngine.ParticleSystemExtensionsImpl::GetSafeTriggerParticlesSize";
    public const string MONO_GetTriggerParticles = "UnityEngine.ParticleSystemExtensionsImpl::GetTriggerParticles";
    public const string MONO_GetTriggerParticlesWithData = "UnityEngine.ParticleSystemExtensionsImpl::GetTriggerParticlesWithData";
    public const string MONO_SetTriggerParticles = "UnityEngine.ParticleSystemExtensionsImpl::SetTriggerParticles";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystemExtensionsImpl : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystemExtensionsImpl(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystemExtensionsImpl(nint ptr) => new Ptr_UnityEngine_ParticleSystemExtensionsImpl(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystemExtensionsImpl ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystemExtensionsImpl ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
