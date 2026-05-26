namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ImageConversion
{
    public const string MONO_EncodeArrayToExr = "UnityEngine.ImageConversion::EncodeArrayToEXR";
    public const string MONO_EncodeArrayToJpg = "UnityEngine.ImageConversion::EncodeArrayToJPG";
    public const string MONO_EncodeArrayToPng = "UnityEngine.ImageConversion::EncodeArrayToPNG";
    public const string MONO_EncodeArrayToTga = "UnityEngine.ImageConversion::EncodeArrayToTGA";
    public const string MONO_EncodeToExr = "UnityEngine.ImageConversion::EncodeToEXR";
    public const string MONO_EncodeToJpg = "UnityEngine.ImageConversion::EncodeToJPG";
    public const string MONO_EncodeToPng = "UnityEngine.ImageConversion::EncodeToPNG";
    public const string MONO_EncodeToTga = "UnityEngine.ImageConversion::EncodeToTGA";
    public const string MONO_GetEnableLegacyPngGammaRuntimeLoadBehavior = "UnityEngine.ImageConversion::GetEnableLegacyPngGammaRuntimeLoadBehavior";
    public const string MONO_LoadImage = "UnityEngine.ImageConversion::LoadImage";
    public const string MONO_SetEnableLegacyPngGammaRuntimeLoadBehavior = "UnityEngine.ImageConversion::SetEnableLegacyPngGammaRuntimeLoadBehavior";
    public const string MONO_UnsafeEncodeNativeArrayToExr = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToEXR";
    public const string MONO_UnsafeEncodeNativeArrayToJpg = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG";
    public const string MONO_UnsafeEncodeNativeArrayToPng = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToPNG";
    public const string MONO_UnsafeEncodeNativeArrayToTga = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToTGA";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ImageConversion : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ImageConversion(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ImageConversion(nint ptr) => new Ptr_UnityEngine_ImageConversion(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ImageConversion ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ImageConversion ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_EncodeArrayToEXR = "UnityEngine.ImageConversion::EncodeArrayToEXR(System.Array,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,UnityEngine.Texture2D/EXRFlags)";
    public const string IL2CPP_EncodeArrayToJPG = "UnityEngine.ImageConversion::EncodeArrayToJPG(System.Array,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,System.Int32)";
    public const string IL2CPP_EncodeArrayToPNG = "UnityEngine.ImageConversion::EncodeArrayToPNG(System.Array,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32)";
    public const string IL2CPP_EncodeArrayToTGA = "UnityEngine.ImageConversion::EncodeArrayToTGA(System.Array,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32)";
    public const string IL2CPP_EncodeToEXR = "UnityEngine.ImageConversion::EncodeToEXR(UnityEngine.Texture2D,UnityEngine.Texture2D/EXRFlags)";
    public const string IL2CPP_EncodeToJPG = "UnityEngine.ImageConversion::EncodeToJPG(UnityEngine.Texture2D,System.Int32)";
    public const string IL2CPP_EncodeToPNG = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)";
    public const string IL2CPP_EncodeToTGA = "UnityEngine.ImageConversion::EncodeToTGA(UnityEngine.Texture2D)";
    public const string IL2CPP_GetEnableLegacyPngGammaRuntimeLoadBehavior = "UnityEngine.ImageConversion::GetEnableLegacyPngGammaRuntimeLoadBehavior()";
    public const string IL2CPP_LoadImage = "UnityEngine.ImageConversion::LoadImage(UnityEngine.Texture2D,System.Byte[],System.Boolean)";
    public const string IL2CPP_SetEnableLegacyPngGammaRuntimeLoadBehavior = "UnityEngine.ImageConversion::SetEnableLegacyPngGammaRuntimeLoadBehavior(System.Boolean)";
    public const string IL2CPP_UnsafeEncodeNativeArrayToEXR = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToEXR(System.Void*,System.Int32&,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,UnityEngine.Texture2D/EXRFlags)";
    public const string IL2CPP_UnsafeEncodeNativeArrayToJPG = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG(System.Void*,System.Int32&,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,System.Int32)";
    public const string IL2CPP_UnsafeEncodeNativeArrayToPNG = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToPNG(System.Void*,System.Int32&,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32)";
    public const string IL2CPP_UnsafeEncodeNativeArrayToTGA = "UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToTGA(System.Void*,System.Int32&,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32)";
}

