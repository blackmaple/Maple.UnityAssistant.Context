namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TextMesh
{
    public const string MONO_GetAlignment = "UnityEngine.TextMesh::get_alignment";
    public const string MONO_GetAnchor = "UnityEngine.TextMesh::get_anchor";
    public const string MONO_GetCharacterSize = "UnityEngine.TextMesh::get_characterSize";
    public const string MONO_GetColorInjected = "UnityEngine.TextMesh::get_color_Injected";
    public const string MONO_GetFont = "UnityEngine.TextMesh::get_font";
    public const string MONO_GetFontSize = "UnityEngine.TextMesh::get_fontSize";
    public const string MONO_GetFontStyle = "UnityEngine.TextMesh::get_fontStyle";
    public const string MONO_GetLineSpacing = "UnityEngine.TextMesh::get_lineSpacing";
    public const string MONO_GetOffsetZ = "UnityEngine.TextMesh::get_offsetZ";
    public const string MONO_GetRichText = "UnityEngine.TextMesh::get_richText";
    public const string MONO_GetTabSize = "UnityEngine.TextMesh::get_tabSize";
    public const string MONO_GetText = "UnityEngine.TextMesh::get_text";
    public const string MONO_SetAlignment = "UnityEngine.TextMesh::set_alignment";
    public const string MONO_SetAnchor = "UnityEngine.TextMesh::set_anchor";
    public const string MONO_SetCharacterSize = "UnityEngine.TextMesh::set_characterSize";
    public const string MONO_SetColorInjected = "UnityEngine.TextMesh::set_color_Injected";
    public const string MONO_SetFont = "UnityEngine.TextMesh::set_font";
    public const string MONO_SetFontSize = "UnityEngine.TextMesh::set_fontSize";
    public const string MONO_SetFontStyle = "UnityEngine.TextMesh::set_fontStyle";
    public const string MONO_SetLineSpacing = "UnityEngine.TextMesh::set_lineSpacing";
    public const string MONO_SetOffsetZ = "UnityEngine.TextMesh::set_offsetZ";
    public const string MONO_SetRichText = "UnityEngine.TextMesh::set_richText";
    public const string MONO_SetTabSize = "UnityEngine.TextMesh::set_tabSize";
    public const string MONO_SetText = "UnityEngine.TextMesh::set_text";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TextMesh : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TextMesh(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TextMesh(nint ptr) => new Ptr_UnityEngine_TextMesh(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TextMesh ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TextMesh ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_characterSize = "UnityEngine.TextMesh::get_characterSize()";
    public const string IL2CPP_get_font = "UnityEngine.TextMesh::get_font()";
    public const string IL2CPP_get_fontSize = "UnityEngine.TextMesh::get_fontSize()";
    public const string IL2CPP_get_fontStyle = "UnityEngine.TextMesh::get_fontStyle()";
    public const string IL2CPP_get_lineSpacing = "UnityEngine.TextMesh::get_lineSpacing()";
    public const string IL2CPP_get_offsetZ = "UnityEngine.TextMesh::get_offsetZ()";
    public const string IL2CPP_get_richText = "UnityEngine.TextMesh::get_richText()";
    public const string IL2CPP_get_tabSize = "UnityEngine.TextMesh::get_tabSize()";
    public const string IL2CPP_get_text = "UnityEngine.TextMesh::get_text()";
    public const string IL2CPP_set_characterSize = "UnityEngine.TextMesh::set_characterSize(System.Single)";
    public const string IL2CPP_set_fontSize = "UnityEngine.TextMesh::set_fontSize(System.Int32)";
    public const string IL2CPP_set_fontStyle = "UnityEngine.TextMesh::set_fontStyle(UnityEngine.FontStyle)";
    public const string IL2CPP_set_lineSpacing = "UnityEngine.TextMesh::set_lineSpacing(System.Single)";
    public const string IL2CPP_set_offsetZ = "UnityEngine.TextMesh::set_offsetZ(System.Single)";
    public const string IL2CPP_set_richText = "UnityEngine.TextMesh::set_richText(System.Boolean)";
    public const string IL2CPP_set_tabSize = "UnityEngine.TextMesh::set_tabSize(System.Single)";
    public const string IL2CPP_set_text = "UnityEngine.TextMesh::set_text(System.String)";
}

