namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Cursor
{
    public const string MONO_GetLockState = "UnityEngine.Cursor::get_lockState";
    public const string MONO_GetVisible = "UnityEngine.Cursor::get_visible";
    public const string MONO_SetLockState = "UnityEngine.Cursor::set_lockState";
    public const string MONO_SetVisible = "UnityEngine.Cursor::set_visible";
    public const string MONO_SetCursorInjected = "UnityEngine.Cursor::SetCursor_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Cursor : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Cursor(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Cursor(nint ptr) => new Ptr_UnityEngine_Cursor(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Cursor ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Cursor ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_lockState = "UnityEngine.Cursor::get_lockState()";
    public const string IL2CPP_get_visible = "UnityEngine.Cursor::get_visible()";
    public const string IL2CPP_set_lockState = "UnityEngine.Cursor::set_lockState(UnityEngine.CursorLockMode)";
    public const string IL2CPP_set_visible = "UnityEngine.Cursor::set_visible(System.Boolean)";
    public const string IL2CPP_SetCursor_Injected = "UnityEngine.Cursor::SetCursor_Injected(UnityEngine.Texture2D,UnityEngine.Vector2&,UnityEngine.CursorMode)";
}

