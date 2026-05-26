namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SubsystemDescriptorBindings
{
    public const string MONO_Create = "UnityEngine.SubsystemDescriptorBindings::Create";
    public const string MONO_GetId = "UnityEngine.SubsystemDescriptorBindings::GetId";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SubsystemDescriptorBindings : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SubsystemDescriptorBindings(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SubsystemDescriptorBindings(nint ptr) => new Ptr_UnityEngine_SubsystemDescriptorBindings(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SubsystemDescriptorBindings ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SubsystemDescriptorBindings ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetId = "UnityEngine.SubsystemDescriptorBindings::GetId(System.IntPtr)";
}

