namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUIDebugger
{
    public const string MONO_GetActive = "UnityEngine.GUIDebugger::get_active";
    public const string MONO_LogBeginPropertyInjected = "UnityEngine.GUIDebugger::LogBeginProperty_Injected";
    public const string MONO_LogEndProperty = "UnityEngine.GUIDebugger::LogEndProperty";
    public const string MONO_LogLayoutEndGroup = "UnityEngine.GUIDebugger::LogLayoutEndGroup";
    public const string MONO_LogLayoutEntryInjected = "UnityEngine.GUIDebugger::LogLayoutEntry_Injected";
    public const string MONO_LogLayoutGroupEntryInjected = "UnityEngine.GUIDebugger::LogLayoutGroupEntry_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUIDebugger : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUIDebugger(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUIDebugger(nint ptr) => new Ptr_UnityEngine_GUIDebugger(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUIDebugger ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUIDebugger ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
