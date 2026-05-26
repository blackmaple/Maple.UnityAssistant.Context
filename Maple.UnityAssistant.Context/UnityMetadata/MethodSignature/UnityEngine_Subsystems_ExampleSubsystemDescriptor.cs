namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Subsystems_ExampleSubsystemDescriptor
{
    public const string MONO_GetDisableBackbufferMsaa = "UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_disableBackbufferMSAA";
    public const string MONO_GetStereoscopicBackbuffer = "UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_stereoscopicBackbuffer";
    public const string MONO_GetSupportsEditorMode = "UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_supportsEditorMode";
    public const string MONO_GetUsePbufferEgl = "UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_usePBufferEGL";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor(nint ptr) => new Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Subsystems_ExampleSubsystemDescriptor ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
