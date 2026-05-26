namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_BoxCollider
{
    public const string MONO_GetCenterInjected = "UnityEngine.BoxCollider::get_center_Injected";
    public const string MONO_GetSizeInjected = "UnityEngine.BoxCollider::get_size_Injected";
    public const string MONO_SetCenterInjected = "UnityEngine.BoxCollider::set_center_Injected";
    public const string MONO_SetSizeInjected = "UnityEngine.BoxCollider::set_size_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_BoxCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_BoxCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_BoxCollider(nint ptr) => new Ptr_UnityEngine_BoxCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_BoxCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_BoxCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_center_Injected = "UnityEngine.BoxCollider::get_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_size_Injected = "UnityEngine.BoxCollider::get_size_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_center_Injected = "UnityEngine.BoxCollider::set_center_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_size_Injected = "UnityEngine.BoxCollider::set_size_Injected(UnityEngine.Vector3&)";
}

