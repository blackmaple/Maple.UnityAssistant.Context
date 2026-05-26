namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CanvasGroup
{
    public const string MONO_GetAlpha = "UnityEngine.CanvasGroup::get_alpha";
    public const string MONO_GetBlocksRaycasts = "UnityEngine.CanvasGroup::get_blocksRaycasts";
    public const string MONO_GetIgnoreParentGroups = "UnityEngine.CanvasGroup::get_ignoreParentGroups";
    public const string MONO_GetInteractable = "UnityEngine.CanvasGroup::get_interactable";
    public const string MONO_SetAlpha = "UnityEngine.CanvasGroup::set_alpha";
    public const string MONO_SetBlocksRaycasts = "UnityEngine.CanvasGroup::set_blocksRaycasts";
    public const string MONO_SetIgnoreParentGroups = "UnityEngine.CanvasGroup::set_ignoreParentGroups";
    public const string MONO_SetInteractable = "UnityEngine.CanvasGroup::set_interactable";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CanvasGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CanvasGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CanvasGroup(nint ptr) => new Ptr_UnityEngine_CanvasGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CanvasGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CanvasGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_alpha = "UnityEngine.CanvasGroup::get_alpha()";
    public const string IL2CPP_get_blocksRaycasts = "UnityEngine.CanvasGroup::get_blocksRaycasts()";
    public const string IL2CPP_get_ignoreParentGroups = "UnityEngine.CanvasGroup::get_ignoreParentGroups()";
    public const string IL2CPP_get_interactable = "UnityEngine.CanvasGroup::get_interactable()";
    public const string IL2CPP_set_alpha = "UnityEngine.CanvasGroup::set_alpha(System.Single)";
    public const string IL2CPP_set_interactable = "UnityEngine.CanvasGroup::set_interactable(System.Boolean)";
}

