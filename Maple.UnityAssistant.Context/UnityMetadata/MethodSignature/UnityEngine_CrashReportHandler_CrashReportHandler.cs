namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CrashReportHandler_CrashReportHandler
{
    public const string MONO_GetEnableCaptureExceptions = "UnityEngine.CrashReportHandler.CrashReportHandler::get_enableCaptureExceptions";
    public const string MONO_GetLogBufferSize = "UnityEngine.CrashReportHandler.CrashReportHandler::get_logBufferSize";
    public const string MONO_GetUserMetadata = "UnityEngine.CrashReportHandler.CrashReportHandler::GetUserMetadata";
    public const string MONO_SetEnableCaptureExceptions = "UnityEngine.CrashReportHandler.CrashReportHandler::set_enableCaptureExceptions";
    public const string MONO_SetLogBufferSize = "UnityEngine.CrashReportHandler.CrashReportHandler::set_logBufferSize";
    public const string MONO_SetUserMetadata = "UnityEngine.CrashReportHandler.CrashReportHandler::SetUserMetadata";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CrashReportHandler_CrashReportHandler : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CrashReportHandler_CrashReportHandler(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CrashReportHandler_CrashReportHandler(nint ptr) => new Ptr_UnityEngine_CrashReportHandler_CrashReportHandler(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CrashReportHandler_CrashReportHandler ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CrashReportHandler_CrashReportHandler ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
