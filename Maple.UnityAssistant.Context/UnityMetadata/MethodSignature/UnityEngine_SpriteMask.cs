namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SpriteMask
{
    public const string MONO_GetAlphaCutoff = "UnityEngine.SpriteMask::get_alphaCutoff";
    public const string MONO_GetBackSortingLayerId = "UnityEngine.SpriteMask::get_backSortingLayerID";
    public const string MONO_GetBackSortingOrder = "UnityEngine.SpriteMask::get_backSortingOrder";
    public const string MONO_GetFrontSortingLayerId = "UnityEngine.SpriteMask::get_frontSortingLayerID";
    public const string MONO_GetFrontSortingOrder = "UnityEngine.SpriteMask::get_frontSortingOrder";
    public const string MONO_GetIsCustomRangeActive = "UnityEngine.SpriteMask::get_isCustomRangeActive";
    public const string MONO_GetSprite = "UnityEngine.SpriteMask::get_sprite";
    public const string MONO_GetSpriteSortPoint = "UnityEngine.SpriteMask::get_spriteSortPoint";
    public const string MONO_GetSpriteBoundsInjected = "UnityEngine.SpriteMask::GetSpriteBounds_Injected";
    public const string MONO_SetAlphaCutoff = "UnityEngine.SpriteMask::set_alphaCutoff";
    public const string MONO_SetBackSortingLayerId = "UnityEngine.SpriteMask::set_backSortingLayerID";
    public const string MONO_SetBackSortingOrder = "UnityEngine.SpriteMask::set_backSortingOrder";
    public const string MONO_SetFrontSortingLayerId = "UnityEngine.SpriteMask::set_frontSortingLayerID";
    public const string MONO_SetFrontSortingOrder = "UnityEngine.SpriteMask::set_frontSortingOrder";
    public const string MONO_SetIsCustomRangeActive = "UnityEngine.SpriteMask::set_isCustomRangeActive";
    public const string MONO_SetSprite = "UnityEngine.SpriteMask::set_sprite";
    public const string MONO_SetSpriteSortPoint = "UnityEngine.SpriteMask::set_spriteSortPoint";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SpriteMask : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SpriteMask(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SpriteMask(nint ptr) => new Ptr_UnityEngine_SpriteMask(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SpriteMask ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SpriteMask ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
