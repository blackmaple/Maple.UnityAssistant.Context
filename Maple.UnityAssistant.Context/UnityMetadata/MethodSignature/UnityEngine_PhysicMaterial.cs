namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PhysicMaterial
{
    public const string MONO_GetBounceCombine = "UnityEngine.PhysicMaterial::get_bounceCombine";
    public const string MONO_GetBounciness = "UnityEngine.PhysicMaterial::get_bounciness";
    public const string MONO_GetDynamicFriction = "UnityEngine.PhysicMaterial::get_dynamicFriction";
    public const string MONO_GetFrictionCombine = "UnityEngine.PhysicMaterial::get_frictionCombine";
    public const string MONO_GetStaticFriction = "UnityEngine.PhysicMaterial::get_staticFriction";
    public const string MONO_InternalCreateDynamicsMaterial = "UnityEngine.PhysicMaterial::Internal_CreateDynamicsMaterial";
    public const string MONO_SetBounceCombine = "UnityEngine.PhysicMaterial::set_bounceCombine";
    public const string MONO_SetBounciness = "UnityEngine.PhysicMaterial::set_bounciness";
    public const string MONO_SetDynamicFriction = "UnityEngine.PhysicMaterial::set_dynamicFriction";
    public const string MONO_SetFrictionCombine = "UnityEngine.PhysicMaterial::set_frictionCombine";
    public const string MONO_SetStaticFriction = "UnityEngine.PhysicMaterial::set_staticFriction";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PhysicMaterial : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PhysicMaterial(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PhysicMaterial(nint ptr) => new Ptr_UnityEngine_PhysicMaterial(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PhysicMaterial ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PhysicMaterial ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_bounceCombine = "UnityEngine.PhysicMaterial::get_bounceCombine()";
    public const string IL2CPP_get_bounciness = "UnityEngine.PhysicMaterial::get_bounciness()";
    public const string IL2CPP_get_dynamicFriction = "UnityEngine.PhysicMaterial::get_dynamicFriction()";
    public const string IL2CPP_get_frictionCombine = "UnityEngine.PhysicMaterial::get_frictionCombine()";
    public const string IL2CPP_get_staticFriction = "UnityEngine.PhysicMaterial::get_staticFriction()";
    public const string IL2CPP_Internal_CreateDynamicsMaterial = "UnityEngine.PhysicMaterial::Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial,System.String)";
    public const string IL2CPP_set_bounceCombine = "UnityEngine.PhysicMaterial::set_bounceCombine(UnityEngine.PhysicMaterialCombine)";
    public const string IL2CPP_set_bounciness = "UnityEngine.PhysicMaterial::set_bounciness(System.Single)";
    public const string IL2CPP_set_dynamicFriction = "UnityEngine.PhysicMaterial::set_dynamicFriction(System.Single)";
    public const string IL2CPP_set_frictionCombine = "UnityEngine.PhysicMaterial::set_frictionCombine(UnityEngine.PhysicMaterialCombine)";
    public const string IL2CPP_set_staticFriction = "UnityEngine.PhysicMaterial::set_staticFriction(System.Single)";
}

