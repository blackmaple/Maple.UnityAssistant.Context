namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Font
{
    public const string MONO_GetAscent = "UnityEngine.Font::get_ascent";
    public const string MONO_GetCharacterInfo = "UnityEngine.Font::get_characterInfo";
    public const string MONO_GetDynamic = "UnityEngine.Font::get_dynamic";
    public const string MONO_GetFontNames = "UnityEngine.Font::get_fontNames";
    public const string MONO_GetFontSize = "UnityEngine.Font::get_fontSize";
    public const string MONO_GetLineHeight = "UnityEngine.Font::get_lineHeight";
    public const string MONO_GetMaterial = "UnityEngine.Font::get_material";
    public const string MONO_GetCharacterInfo_2 = "UnityEngine.Font::GetCharacterInfo";
    public const string MONO_GetDefault = "UnityEngine.Font::GetDefault";
    public const string MONO_GetOsinstalledFontNames = "UnityEngine.Font::GetOSInstalledFontNames";
    public const string MONO_GetPathsToOsfonts = "UnityEngine.Font::GetPathsToOSFonts";
    public const string MONO_HasCharacter = "UnityEngine.Font::HasCharacter";
    public const string MONO_InternalCreateDynamicFont = "UnityEngine.Font::Internal_CreateDynamicFont";
    public const string MONO_InternalCreateFont = "UnityEngine.Font::Internal_CreateFont";
    public const string MONO_InternalCreateFontFromPath = "UnityEngine.Font::Internal_CreateFontFromPath";
    public const string MONO_RequestCharactersInTexture = "UnityEngine.Font::RequestCharactersInTexture";
    public const string MONO_SetCharacterInfo = "UnityEngine.Font::set_characterInfo";
    public const string MONO_SetFontNames = "UnityEngine.Font::set_fontNames";
    public const string MONO_SetMaterial = "UnityEngine.Font::set_material";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Font : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Font(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Font(nint ptr) => new Ptr_UnityEngine_Font(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Font ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Font ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_dynamic = "UnityEngine.Font::get_dynamic()";
    public const string IL2CPP_get_fontSize = "UnityEngine.Font::get_fontSize()";
    public const string IL2CPP_get_material = "UnityEngine.Font::get_material()";
    public const string IL2CPP_GetCharacterInfo = "UnityEngine.Font::GetCharacterInfo(System.Char,UnityEngine.CharacterInfo&,System.Int32,UnityEngine.FontStyle)";
    public const string IL2CPP_HasCharacter = "UnityEngine.Font::HasCharacter(System.Int32)";
    public const string IL2CPP_Internal_CreateDynamicFont = "UnityEngine.Font::Internal_CreateDynamicFont(UnityEngine.Font,System.String[],System.Int32)";
    public const string IL2CPP_Internal_CreateFont = "UnityEngine.Font::Internal_CreateFont(UnityEngine.Font,System.String)";
    public const string IL2CPP_Internal_CreateFontFromPath = "UnityEngine.Font::Internal_CreateFontFromPath(UnityEngine.Font,System.String)";
    public const string IL2CPP_RequestCharactersInTexture = "UnityEngine.Font::RequestCharactersInTexture(System.String,System.Int32,UnityEngine.FontStyle)";
    public const string IL2CPP_set_material = "UnityEngine.Font::set_material(UnityEngine.Material)";
}

