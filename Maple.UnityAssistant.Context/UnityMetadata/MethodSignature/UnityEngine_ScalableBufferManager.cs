namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ScalableBufferManager
{
    public const string MONO_GetHeightScaleFactor = "UnityEngine.ScalableBufferManager::get_heightScaleFactor";
    public const string MONO_GetWidthScaleFactor = "UnityEngine.ScalableBufferManager::get_widthScaleFactor";
    public const string MONO_ResizeBuffers = "UnityEngine.ScalableBufferManager::ResizeBuffers";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ScalableBufferManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ScalableBufferManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ScalableBufferManager(nint ptr) => new Ptr_UnityEngine_ScalableBufferManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ScalableBufferManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ScalableBufferManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_heightScaleFactor = "UnityEngine.ScalableBufferManager::get_heightScaleFactor()";
    public const string IL2CPP_get_widthScaleFactor = "UnityEngine.ScalableBufferManager::get_widthScaleFactor()";
    public const string IL2CPP_ResizeBuffers = "UnityEngine.ScalableBufferManager::ResizeBuffers(System.Single,System.Single)";
}

