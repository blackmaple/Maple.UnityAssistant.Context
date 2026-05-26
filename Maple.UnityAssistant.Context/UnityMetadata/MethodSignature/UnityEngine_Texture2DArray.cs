namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Texture2DArray
{
    public const string MONO_ApplyImpl = "UnityEngine.Texture2DArray::ApplyImpl";
    public const string MONO_GetAllSlices = "UnityEngine.Texture2DArray::get_allSlices";
    public const string MONO_GetDepth = "UnityEngine.Texture2DArray::get_depth";
    public const string MONO_GetFormat = "UnityEngine.Texture2DArray::get_format";
    public const string MONO_GetIsReadable = "UnityEngine.Texture2DArray::get_isReadable";
    public const string MONO_GetImageDataPointer = "UnityEngine.Texture2DArray::GetImageDataPointer";
    public const string MONO_GetPixels = "UnityEngine.Texture2DArray::GetPixels";
    public const string MONO_GetPixels32 = "UnityEngine.Texture2DArray::GetPixels32";
    public const string MONO_InternalCreateImpl = "UnityEngine.Texture2DArray::Internal_CreateImpl";
    public const string MONO_SetPixelDataImpl = "UnityEngine.Texture2DArray::SetPixelDataImpl";
    public const string MONO_SetPixelDataImplArray = "UnityEngine.Texture2DArray::SetPixelDataImplArray";
    public const string MONO_SetPixels = "UnityEngine.Texture2DArray::SetPixels";
    public const string MONO_SetPixels32 = "UnityEngine.Texture2DArray::SetPixels32";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Texture2DArray : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Texture2DArray(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Texture2DArray(nint ptr) => new Ptr_UnityEngine_Texture2DArray(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Texture2DArray ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Texture2DArray ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_allSlices = "UnityEngine.Texture2DArray::get_allSlices()";
    public const string IL2CPP_get_isReadable = "UnityEngine.Texture2DArray::get_isReadable()";
    public const string IL2CPP_Internal_CreateImpl = "UnityEngine.Texture2DArray::Internal_CreateImpl(UnityEngine.Texture2DArray,System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngine.Experimental.Rendering.TextureCreationFlags)";
}

