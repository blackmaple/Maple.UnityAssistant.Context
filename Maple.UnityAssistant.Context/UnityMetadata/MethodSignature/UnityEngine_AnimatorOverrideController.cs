namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnimatorOverrideController
{
    public const string MONO_GetOverridesCount = "UnityEngine.AnimatorOverrideController::get_overridesCount";
    public const string MONO_GetRuntimeAnimatorController = "UnityEngine.AnimatorOverrideController::get_runtimeAnimatorController";
    public const string MONO_GetClip = "UnityEngine.AnimatorOverrideController::GetClip";
    public const string MONO_GetOriginalClip = "UnityEngine.AnimatorOverrideController::GetOriginalClip";
    public const string MONO_GetOverrideClip = "UnityEngine.AnimatorOverrideController::GetOverrideClip";
    public const string MONO_InternalCreate = "UnityEngine.AnimatorOverrideController::Internal_Create";
    public const string MONO_InternalGetClipByName = "UnityEngine.AnimatorOverrideController::Internal_GetClipByName";
    public const string MONO_InternalSetClipByName = "UnityEngine.AnimatorOverrideController::Internal_SetClipByName";
    public const string MONO_PerformOverrideClipListCleanup = "UnityEngine.AnimatorOverrideController::PerformOverrideClipListCleanup";
    public const string MONO_SendNotification = "UnityEngine.AnimatorOverrideController::SendNotification";
    public const string MONO_SetRuntimeAnimatorController = "UnityEngine.AnimatorOverrideController::set_runtimeAnimatorController";
    public const string MONO_SetClip = "UnityEngine.AnimatorOverrideController::SetClip";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnimatorOverrideController : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnimatorOverrideController(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnimatorOverrideController(nint ptr) => new Ptr_UnityEngine_AnimatorOverrideController(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnimatorOverrideController ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnimatorOverrideController ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
