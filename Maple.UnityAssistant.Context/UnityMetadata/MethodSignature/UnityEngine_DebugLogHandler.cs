namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_DebugLogHandler
{
    public const string MONO_InternalLog = "UnityEngine.DebugLogHandler::Internal_Log";
    public const string MONO_InternalLogException = "UnityEngine.DebugLogHandler::Internal_LogException";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_DebugLogHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_DebugLogHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_DebugLogHandler(nint ptr) => new Ptr_UnityEngine_DebugLogHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_DebugLogHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_DebugLogHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_Log = "UnityEngine.DebugLogHandler::Internal_Log(UnityEngine.LogType,UnityEngine.LogOption,System.String,UnityEngine.Object)";
    public const string IL2CPP_Internal_LogException = "UnityEngine.DebugLogHandler::Internal_LogException(System.Exception,UnityEngine.Object)";
}

