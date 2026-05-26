namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Texture3D
{
    public const string MONO_ApplyImpl = "UnityEngine.Texture3D::ApplyImpl";
    public const string MONO_GetDepth = "UnityEngine.Texture3D::get_depth";
    public const string MONO_GetFormat = "UnityEngine.Texture3D::get_format";
    public const string MONO_GetIsReadable = "UnityEngine.Texture3D::get_isReadable";
    public const string MONO_GetImageDataPointer = "UnityEngine.Texture3D::GetImageDataPointer";
    public const string MONO_GetPixelBilinearImplInjected = "UnityEngine.Texture3D::GetPixelBilinearImpl_Injected";
    public const string MONO_GetPixelImplInjected = "UnityEngine.Texture3D::GetPixelImpl_Injected";
    public const string MONO_GetPixels = "UnityEngine.Texture3D::GetPixels";
    public const string MONO_GetPixels32 = "UnityEngine.Texture3D::GetPixels32";
    public const string MONO_InternalCreateImpl = "UnityEngine.Texture3D::Internal_CreateImpl";
    public const string MONO_SetPixelDataImpl = "UnityEngine.Texture3D::SetPixelDataImpl";
    public const string MONO_SetPixelDataImplArray = "UnityEngine.Texture3D::SetPixelDataImplArray";
    public const string MONO_SetPixelImplInjected = "UnityEngine.Texture3D::SetPixelImpl_Injected";
    public const string MONO_SetPixels = "UnityEngine.Texture3D::SetPixels";
    public const string MONO_SetPixels32 = "UnityEngine.Texture3D::SetPixels32";
    public const string MONO_UpdateExternalTexture = "UnityEngine.Texture3D::UpdateExternalTexture";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Texture3D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Texture3D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Texture3D(nint ptr) => new Ptr_UnityEngine_Texture3D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Texture3D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Texture3D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ApplyImpl = "UnityEngine.Texture3D::ApplyImpl(System.Boolean,System.Boolean)";
    public const string IL2CPP_get_isReadable = "UnityEngine.Texture3D::get_isReadable()";
    public const string IL2CPP_Internal_CreateImpl = "UnityEngine.Texture3D::Internal_CreateImpl(UnityEngine.Texture3D,System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngine.Experimental.Rendering.TextureCreationFlags,System.IntPtr)";
    public const string IL2CPP_SetPixelImpl_Injected = "UnityEngine.Texture3D::SetPixelImpl_Injected(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color&)";
    public const string IL2CPP_SetPixels = "UnityEngine.Texture3D::SetPixels(UnityEngine.Color[],System.Int32)";
}

