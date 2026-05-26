namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ShaderVariantCollection
{
    public const string MONO_AddVariant = "UnityEngine.ShaderVariantCollection::AddVariant";
    public const string MONO_Clear = "UnityEngine.ShaderVariantCollection::Clear";
    public const string MONO_ContainsVariant = "UnityEngine.ShaderVariantCollection::ContainsVariant";
    public const string MONO_GetIsWarmedUp = "UnityEngine.ShaderVariantCollection::get_isWarmedUp";
    public const string MONO_GetShaderCount = "UnityEngine.ShaderVariantCollection::get_shaderCount";
    public const string MONO_GetVariantCount = "UnityEngine.ShaderVariantCollection::get_variantCount";
    public const string MONO_InternalCreate = "UnityEngine.ShaderVariantCollection::Internal_Create";
    public const string MONO_RemoveVariant = "UnityEngine.ShaderVariantCollection::RemoveVariant";
    public const string MONO_WarmUp = "UnityEngine.ShaderVariantCollection::WarmUp";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ShaderVariantCollection : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ShaderVariantCollection(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ShaderVariantCollection(nint ptr) => new Ptr_UnityEngine_ShaderVariantCollection(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ShaderVariantCollection ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ShaderVariantCollection ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
