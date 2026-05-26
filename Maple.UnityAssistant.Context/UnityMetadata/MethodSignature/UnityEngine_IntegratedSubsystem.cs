namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_IntegratedSubsystem
{
    public const string MONO_IsRunning = "UnityEngine.IntegratedSubsystem::IsRunning";
    public const string MONO_SetHandle = "UnityEngine.IntegratedSubsystem::SetHandle";
    public const string MONO_Start = "UnityEngine.IntegratedSubsystem::Start";
    public const string MONO_Stop = "UnityEngine.IntegratedSubsystem::Stop";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_IntegratedSubsystem : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_IntegratedSubsystem(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_IntegratedSubsystem(nint ptr) => new Ptr_UnityEngine_IntegratedSubsystem(ptr);
        public static implicit operator nint(Ptr_UnityEngine_IntegratedSubsystem ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_IntegratedSubsystem ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_IsRunning = "UnityEngine.IntegratedSubsystem::IsRunning()";
    public const string IL2CPP_SetHandle = "UnityEngine.IntegratedSubsystem::SetHandle(UnityEngine.IntegratedSubsystem)";
}

