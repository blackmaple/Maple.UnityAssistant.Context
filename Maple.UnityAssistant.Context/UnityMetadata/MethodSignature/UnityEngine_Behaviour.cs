namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Behaviour
{
    public const string MONO_GetEnabled = "UnityEngine.Behaviour::get_enabled";
    public const string MONO_GetIsActiveAndEnabled = "UnityEngine.Behaviour::get_isActiveAndEnabled";
    public const string MONO_SetEnabled = "UnityEngine.Behaviour::set_enabled";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Behaviour : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Behaviour(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Behaviour(nint ptr) => new Ptr_UnityEngine_Behaviour(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Behaviour ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Behaviour ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_enabled = "UnityEngine.Behaviour::get_enabled()";
    public const string IL2CPP_get_isActiveAndEnabled = "UnityEngine.Behaviour::get_isActiveAndEnabled()";
    public const string IL2CPP_set_enabled = "UnityEngine.Behaviour::set_enabled(System.Boolean)";
}

