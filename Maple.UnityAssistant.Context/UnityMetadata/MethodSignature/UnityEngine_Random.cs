namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Random
{
    public const string MONO_GetInsideUnitSphereInjected = "UnityEngine.Random::get_insideUnitSphere_Injected";
    public const string MONO_GetOnUnitSphereInjected = "UnityEngine.Random::get_onUnitSphere_Injected";
    public const string MONO_GetRotationInjected = "UnityEngine.Random::get_rotation_Injected";
    public const string MONO_GetRotationUniformInjected = "UnityEngine.Random::get_rotationUniform_Injected";
    public const string MONO_GetSeed = "UnityEngine.Random::get_seed";
    public const string MONO_GetStateInjected = "UnityEngine.Random::get_state_Injected";
    public const string MONO_GetValue = "UnityEngine.Random::get_value";
    public const string MONO_GetRandomUnitCircle = "UnityEngine.Random::GetRandomUnitCircle";
    public const string MONO_InitState = "UnityEngine.Random::InitState";
    public const string MONO_RandomRangeInt = "UnityEngine.Random::RandomRangeInt";
    public const string MONO_Range = "UnityEngine.Random::Range";
    public const string MONO_SetSeed = "UnityEngine.Random::set_seed";
    public const string MONO_SetStateInjected = "UnityEngine.Random::set_state_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Random : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Random(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Random(nint ptr) => new Ptr_UnityEngine_Random(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Random ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Random ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_insideUnitSphere_Injected = "UnityEngine.Random::get_insideUnitSphere_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_onUnitSphere_Injected = "UnityEngine.Random::get_onUnitSphere_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_rotation_Injected = "UnityEngine.Random::get_rotation_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_get_rotationUniform_Injected = "UnityEngine.Random::get_rotationUniform_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_get_seed = "UnityEngine.Random::get_seed()";
    public const string IL2CPP_get_state_Injected = "UnityEngine.Random::get_state_Injected(UnityEngine.Random/State&)";
    public const string IL2CPP_get_value = "UnityEngine.Random::get_value()";
    public const string IL2CPP_GetRandomUnitCircle = "UnityEngine.Random::GetRandomUnitCircle(UnityEngine.Vector2&)";
    public const string IL2CPP_InitState = "UnityEngine.Random::InitState(System.Int32)";
    public const string IL2CPP_RandomRangeInt = "UnityEngine.Random::RandomRangeInt(System.Int32,System.Int32)";
    public const string IL2CPP_Range = "UnityEngine.Random::Range(System.Single,System.Single)";
    public const string IL2CPP_set_seed = "UnityEngine.Random::set_seed(System.Int32)";
    public const string IL2CPP_set_state_Injected = "UnityEngine.Random::set_state_Injected(UnityEngine.Random/State&)";
}

