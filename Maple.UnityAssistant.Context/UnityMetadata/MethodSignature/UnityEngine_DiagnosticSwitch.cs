namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_DiagnosticSwitch
{
    public const string MONO_GetDefaultValue = "UnityEngine.DiagnosticSwitch::get_defaultValue";
    public const string MONO_GetDescription = "UnityEngine.DiagnosticSwitch::get_description";
    public const string MONO_GetEnumInfo = "UnityEngine.DiagnosticSwitch::get_enumInfo";
    public const string MONO_GetFlags = "UnityEngine.DiagnosticSwitch::get_flags";
    public const string MONO_GetMaxValue = "UnityEngine.DiagnosticSwitch::get_maxValue";
    public const string MONO_GetMinValue = "UnityEngine.DiagnosticSwitch::get_minValue";
    public const string MONO_GetName = "UnityEngine.DiagnosticSwitch::get_name";
    public const string MONO_GetOwningModule = "UnityEngine.DiagnosticSwitch::get_owningModule";
    public const string MONO_GetScriptingPersistentValue = "UnityEngine.DiagnosticSwitch::GetScriptingPersistentValue";
    public const string MONO_GetScriptingValue = "UnityEngine.DiagnosticSwitch::GetScriptingValue";
    public const string MONO_SetScriptingValue = "UnityEngine.DiagnosticSwitch::SetScriptingValue";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_DiagnosticSwitch : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_DiagnosticSwitch(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_DiagnosticSwitch(nint ptr) => new Ptr_UnityEngine_DiagnosticSwitch(ptr);
        public static implicit operator nint(Ptr_UnityEngine_DiagnosticSwitch ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_DiagnosticSwitch ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_name = "UnityEngine.DiagnosticSwitch::get_name()";
}

