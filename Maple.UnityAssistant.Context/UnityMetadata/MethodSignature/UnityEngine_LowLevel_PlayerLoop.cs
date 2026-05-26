namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LowLevel_PlayerLoop
{
    public const string MONO_GetCurrentPlayerLoopInternal = "UnityEngine.LowLevel.PlayerLoop::GetCurrentPlayerLoopInternal";
    public const string MONO_GetDefaultPlayerLoopInternal = "UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal";
    public const string MONO_SetPlayerLoopInternal = "UnityEngine.LowLevel.PlayerLoop::SetPlayerLoopInternal";
    public const string MONO_UiwidgetsWakeUp = "UnityEngine.LowLevel.PlayerLoop::UIWidgetsWakeUp";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LowLevel_PlayerLoop : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LowLevel_PlayerLoop(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LowLevel_PlayerLoop(nint ptr) => new Ptr_UnityEngine_LowLevel_PlayerLoop(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LowLevel_PlayerLoop ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LowLevel_PlayerLoop ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
