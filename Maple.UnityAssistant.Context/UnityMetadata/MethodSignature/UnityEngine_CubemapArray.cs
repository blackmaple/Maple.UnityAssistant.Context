namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CubemapArray
{
    public const string MONO_ApplyImpl = "UnityEngine.CubemapArray::ApplyImpl";
    public const string MONO_GetCubemapCount = "UnityEngine.CubemapArray::get_cubemapCount";
    public const string MONO_GetFormat = "UnityEngine.CubemapArray::get_format";
    public const string MONO_GetIsReadable = "UnityEngine.CubemapArray::get_isReadable";
    public const string MONO_GetImageDataPointer = "UnityEngine.CubemapArray::GetImageDataPointer";
    public const string MONO_GetPixels = "UnityEngine.CubemapArray::GetPixels";
    public const string MONO_GetPixels32 = "UnityEngine.CubemapArray::GetPixels32";
    public const string MONO_InternalCreateImpl = "UnityEngine.CubemapArray::Internal_CreateImpl";
    public const string MONO_SetPixelDataImpl = "UnityEngine.CubemapArray::SetPixelDataImpl";
    public const string MONO_SetPixelDataImplArray = "UnityEngine.CubemapArray::SetPixelDataImplArray";
    public const string MONO_SetPixels = "UnityEngine.CubemapArray::SetPixels";
    public const string MONO_SetPixels32 = "UnityEngine.CubemapArray::SetPixels32";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CubemapArray : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CubemapArray(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CubemapArray(nint ptr) => new Ptr_UnityEngine_CubemapArray(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CubemapArray ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CubemapArray ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ApplyImpl = "UnityEngine.CubemapArray::ApplyImpl(System.Boolean,System.Boolean)";
    public const string IL2CPP_get_isReadable = "UnityEngine.CubemapArray::get_isReadable()";
    public const string IL2CPP_Internal_CreateImpl = "UnityEngine.CubemapArray::Internal_CreateImpl(UnityEngine.CubemapArray,System.Int32,System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngine.Experimental.Rendering.TextureCreationFlags)";
    public const string IL2CPP_SetPixels = "UnityEngine.CubemapArray::SetPixels(UnityEngine.Color[],UnityEngine.CubemapFace,System.Int32,System.Int32)";
}

