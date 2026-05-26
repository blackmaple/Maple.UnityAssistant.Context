namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LocalizationAsset
{
    public const string MONO_GetIsEditorAsset = "UnityEngine.LocalizationAsset::get_isEditorAsset";
    public const string MONO_GetLocaleIsoCode = "UnityEngine.LocalizationAsset::get_localeIsoCode";
    public const string MONO_GetLocalizedString = "UnityEngine.LocalizationAsset::GetLocalizedString";
    public const string MONO_InternalCreateInstance = "UnityEngine.LocalizationAsset::Internal_CreateInstance";
    public const string MONO_SetIsEditorAsset = "UnityEngine.LocalizationAsset::set_isEditorAsset";
    public const string MONO_SetLocaleIsoCode = "UnityEngine.LocalizationAsset::set_localeIsoCode";
    public const string MONO_SetLocalizedString = "UnityEngine.LocalizationAsset::SetLocalizedString";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LocalizationAsset : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LocalizationAsset(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LocalizationAsset(nint ptr) => new Ptr_UnityEngine_LocalizationAsset(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LocalizationAsset ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LocalizationAsset ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
