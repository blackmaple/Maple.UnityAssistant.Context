namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Debug
{
    public const string MONO_Break = "UnityEngine.Debug::Break";
    public const string MONO_ClearDeveloperConsole = "UnityEngine.Debug::ClearDeveloperConsole";
    public const string MONO_DebugBreak = "UnityEngine.Debug::DebugBreak";
    public const string MONO_DrawLineInjected = "UnityEngine.Debug::DrawLine_Injected";
    public const string MONO_ExtractStackTraceNoAlloc = "UnityEngine.Debug::ExtractStackTraceNoAlloc";
    public const string MONO_GetDeveloperConsoleVisible = "UnityEngine.Debug::get_developerConsoleVisible";
    public const string MONO_GetDiagnosticSwitches = "UnityEngine.Debug::get_diagnosticSwitches";
    public const string MONO_GetIsDebugBuild = "UnityEngine.Debug::get_isDebugBuild";
    public const string MONO_OpenConsoleFile = "UnityEngine.Debug::OpenConsoleFile";
    public const string MONO_SetDeveloperConsoleVisible = "UnityEngine.Debug::set_developerConsoleVisible";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Debug : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Debug(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Debug(nint ptr) => new Ptr_UnityEngine_Debug(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Debug ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Debug ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Break = "UnityEngine.Debug::Break()";
    public const string IL2CPP_ClearDeveloperConsole = "UnityEngine.Debug::ClearDeveloperConsole()";
    public const string IL2CPP_DebugBreak = "UnityEngine.Debug::DebugBreak()";
    public const string IL2CPP_DrawLine_Injected = "UnityEngine.Debug::DrawLine_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Color&,System.Single,System.Boolean)";
    public const string IL2CPP_ExtractStackTraceNoAlloc = "UnityEngine.Debug::ExtractStackTraceNoAlloc(System.Byte*,System.Int32,System.String)";
    public const string IL2CPP_get_developerConsoleVisible = "UnityEngine.Debug::get_developerConsoleVisible()";
    public const string IL2CPP_get_diagnosticSwitches = "UnityEngine.Debug::get_diagnosticSwitches()";
    public const string IL2CPP_get_isDebugBuild = "UnityEngine.Debug::get_isDebugBuild()";
    public const string IL2CPP_OpenConsoleFile = "UnityEngine.Debug::OpenConsoleFile()";
    public const string IL2CPP_set_developerConsoleVisible = "UnityEngine.Debug::set_developerConsoleVisible(System.Boolean)";
}

