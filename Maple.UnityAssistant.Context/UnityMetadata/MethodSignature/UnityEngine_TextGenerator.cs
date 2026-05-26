namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TextGenerator
{
    public const string MONO_GetCharacterCount = "UnityEngine.TextGenerator::get_characterCount";
    public const string MONO_GetFontSizeUsedForBestFit = "UnityEngine.TextGenerator::get_fontSizeUsedForBestFit";
    public const string MONO_GetLineCount = "UnityEngine.TextGenerator::get_lineCount";
    public const string MONO_GetRectExtentsInjected = "UnityEngine.TextGenerator::get_rectExtents_Injected";
    public const string MONO_GetVertexCount = "UnityEngine.TextGenerator::get_vertexCount";
    public const string MONO_GetCharactersArray = "UnityEngine.TextGenerator::GetCharactersArray";
    public const string MONO_GetCharactersInternal = "UnityEngine.TextGenerator::GetCharactersInternal";
    public const string MONO_GetLinesArray = "UnityEngine.TextGenerator::GetLinesArray";
    public const string MONO_GetLinesInternal = "UnityEngine.TextGenerator::GetLinesInternal";
    public const string MONO_GetVerticesArray = "UnityEngine.TextGenerator::GetVerticesArray";
    public const string MONO_GetVerticesInternal = "UnityEngine.TextGenerator::GetVerticesInternal";
    public const string MONO_InternalCreate = "UnityEngine.TextGenerator::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.TextGenerator::Internal_Destroy";
    public const string MONO_PopulateInternalInjected = "UnityEngine.TextGenerator::Populate_Internal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TextGenerator : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TextGenerator(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TextGenerator(nint ptr) => new Ptr_UnityEngine_TextGenerator(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TextGenerator ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TextGenerator ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_characterCount = "UnityEngine.TextGenerator::get_characterCount()";
    public const string IL2CPP_get_lineCount = "UnityEngine.TextGenerator::get_lineCount()";
    public const string IL2CPP_get_rectExtents_Injected = "UnityEngine.TextGenerator::get_rectExtents_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_GetCharactersInternal = "UnityEngine.TextGenerator::GetCharactersInternal(System.Object)";
    public const string IL2CPP_GetLinesInternal = "UnityEngine.TextGenerator::GetLinesInternal(System.Object)";
    public const string IL2CPP_GetVerticesInternal = "UnityEngine.TextGenerator::GetVerticesInternal(System.Object)";
    public const string IL2CPP_Internal_Create = "UnityEngine.TextGenerator::Internal_Create()";
    public const string IL2CPP_Internal_Destroy = "UnityEngine.TextGenerator::Internal_Destroy(System.IntPtr)";
    public const string IL2CPP_Populate_Internal_Injected = "UnityEngine.TextGenerator::Populate_Internal_Injected(System.String,UnityEngine.Font,UnityEngine.Color&,System.Int32,System.Single,System.Single,UnityEngine.FontStyle,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean,UnityEngine.TextAnchor,System.Single,System.Single,System.Single,System.Single,System.Boolean,System.Boolean,System.UInt32&)";
}

