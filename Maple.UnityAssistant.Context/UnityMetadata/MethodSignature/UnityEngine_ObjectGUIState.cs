namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ObjectGUIState
{
    public const string MONO_InternalCreate = "UnityEngine.ObjectGUIState::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.ObjectGUIState::Internal_Destroy";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ObjectGUIState : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ObjectGUIState(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ObjectGUIState(nint ptr) => new Ptr_UnityEngine_ObjectGUIState(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ObjectGUIState ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ObjectGUIState ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Internal_Destroy = "UnityEngine.ObjectGUIState::Internal_Destroy(System.IntPtr)";
}

