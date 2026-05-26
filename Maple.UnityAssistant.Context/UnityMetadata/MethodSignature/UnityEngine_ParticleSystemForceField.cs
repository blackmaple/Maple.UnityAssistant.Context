namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ParticleSystemForceField
{
    public const string MONO_GetDirectionXInjected = "UnityEngine.ParticleSystemForceField::get_directionX_Injected";
    public const string MONO_GetDirectionYInjected = "UnityEngine.ParticleSystemForceField::get_directionY_Injected";
    public const string MONO_GetDirectionZInjected = "UnityEngine.ParticleSystemForceField::get_directionZ_Injected";
    public const string MONO_GetDragInjected = "UnityEngine.ParticleSystemForceField::get_drag_Injected";
    public const string MONO_GetEndRange = "UnityEngine.ParticleSystemForceField::get_endRange";
    public const string MONO_GetGravityInjected = "UnityEngine.ParticleSystemForceField::get_gravity_Injected";
    public const string MONO_GetGravityFocus = "UnityEngine.ParticleSystemForceField::get_gravityFocus";
    public const string MONO_GetLength = "UnityEngine.ParticleSystemForceField::get_length";
    public const string MONO_GetMultiplyDragByParticleSize = "UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleSize";
    public const string MONO_GetMultiplyDragByParticleVelocity = "UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleVelocity";
    public const string MONO_GetRotationAttractionInjected = "UnityEngine.ParticleSystemForceField::get_rotationAttraction_Injected";
    public const string MONO_GetRotationRandomnessInjected = "UnityEngine.ParticleSystemForceField::get_rotationRandomness_Injected";
    public const string MONO_GetRotationSpeedInjected = "UnityEngine.ParticleSystemForceField::get_rotationSpeed_Injected";
    public const string MONO_GetShape = "UnityEngine.ParticleSystemForceField::get_shape";
    public const string MONO_GetStartRange = "UnityEngine.ParticleSystemForceField::get_startRange";
    public const string MONO_GetVectorField = "UnityEngine.ParticleSystemForceField::get_vectorField";
    public const string MONO_GetVectorFieldAttractionInjected = "UnityEngine.ParticleSystemForceField::get_vectorFieldAttraction_Injected";
    public const string MONO_GetVectorFieldSpeedInjected = "UnityEngine.ParticleSystemForceField::get_vectorFieldSpeed_Injected";
    public const string MONO_SetDirectionXInjected = "UnityEngine.ParticleSystemForceField::set_directionX_Injected";
    public const string MONO_SetDirectionYInjected = "UnityEngine.ParticleSystemForceField::set_directionY_Injected";
    public const string MONO_SetDirectionZInjected = "UnityEngine.ParticleSystemForceField::set_directionZ_Injected";
    public const string MONO_SetDragInjected = "UnityEngine.ParticleSystemForceField::set_drag_Injected";
    public const string MONO_SetEndRange = "UnityEngine.ParticleSystemForceField::set_endRange";
    public const string MONO_SetGravityInjected = "UnityEngine.ParticleSystemForceField::set_gravity_Injected";
    public const string MONO_SetGravityFocus = "UnityEngine.ParticleSystemForceField::set_gravityFocus";
    public const string MONO_SetLength = "UnityEngine.ParticleSystemForceField::set_length";
    public const string MONO_SetMultiplyDragByParticleSize = "UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleSize";
    public const string MONO_SetMultiplyDragByParticleVelocity = "UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleVelocity";
    public const string MONO_SetRotationAttractionInjected = "UnityEngine.ParticleSystemForceField::set_rotationAttraction_Injected";
    public const string MONO_SetRotationRandomnessInjected = "UnityEngine.ParticleSystemForceField::set_rotationRandomness_Injected";
    public const string MONO_SetRotationSpeedInjected = "UnityEngine.ParticleSystemForceField::set_rotationSpeed_Injected";
    public const string MONO_SetShape = "UnityEngine.ParticleSystemForceField::set_shape";
    public const string MONO_SetStartRange = "UnityEngine.ParticleSystemForceField::set_startRange";
    public const string MONO_SetVectorField = "UnityEngine.ParticleSystemForceField::set_vectorField";
    public const string MONO_SetVectorFieldAttractionInjected = "UnityEngine.ParticleSystemForceField::set_vectorFieldAttraction_Injected";
    public const string MONO_SetVectorFieldSpeedInjected = "UnityEngine.ParticleSystemForceField::set_vectorFieldSpeed_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ParticleSystemForceField : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ParticleSystemForceField(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ParticleSystemForceField(nint ptr) => new Ptr_UnityEngine_ParticleSystemForceField(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ParticleSystemForceField ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ParticleSystemForceField ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
