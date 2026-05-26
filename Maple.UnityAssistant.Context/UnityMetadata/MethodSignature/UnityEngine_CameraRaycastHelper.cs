namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CameraRaycastHelper
{
    public const string MONO_RaycastTryInjected = "UnityEngine.CameraRaycastHelper::RaycastTry_Injected";
    public const string MONO_RaycastTry2DInjected = "UnityEngine.CameraRaycastHelper::RaycastTry2D_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CameraRaycastHelper : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CameraRaycastHelper(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CameraRaycastHelper(nint ptr) => new Ptr_UnityEngine_CameraRaycastHelper(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CameraRaycastHelper ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CameraRaycastHelper ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_RaycastTry_Injected = "UnityEngine.CameraRaycastHelper::RaycastTry_Injected(UnityEngine.Camera,UnityEngine.Ray&,System.Single,System.Int32)";
    public const string IL2CPP_RaycastTry2D_Injected = "UnityEngine.CameraRaycastHelper::RaycastTry2D_Injected(UnityEngine.Camera,UnityEngine.Ray&,System.Single,System.Int32)";
}

