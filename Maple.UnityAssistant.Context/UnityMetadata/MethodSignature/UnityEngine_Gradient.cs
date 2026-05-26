namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Gradient
{
    public const string MONO_Cleanup = "UnityEngine.Gradient::Cleanup";
    public const string MONO_EvaluateInjected = "UnityEngine.Gradient::Evaluate_Injected";
    public const string MONO_GetAlphaKeys = "UnityEngine.Gradient::get_alphaKeys";
    public const string MONO_GetColorKeys = "UnityEngine.Gradient::get_colorKeys";
    public const string MONO_GetMode = "UnityEngine.Gradient::get_mode";
    public const string MONO_Init = "UnityEngine.Gradient::Init";
    public const string MONO_InternalEquals = "UnityEngine.Gradient::Internal_Equals";
    public const string MONO_SetAlphaKeys = "UnityEngine.Gradient::set_alphaKeys";
    public const string MONO_SetColorKeys = "UnityEngine.Gradient::set_colorKeys";
    public const string MONO_SetMode = "UnityEngine.Gradient::set_mode";
    public const string MONO_SetKeys = "UnityEngine.Gradient::SetKeys";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Gradient : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Gradient(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Gradient(nint ptr) => new Ptr_UnityEngine_Gradient(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Gradient ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Gradient ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Cleanup = "UnityEngine.Gradient::Cleanup()";
    public const string IL2CPP_Evaluate_Injected = "UnityEngine.Gradient::Evaluate_Injected(System.Single,UnityEngine.Color&)";
    public const string IL2CPP_get_alphaKeys = "UnityEngine.Gradient::get_alphaKeys()";
    public const string IL2CPP_get_colorKeys = "UnityEngine.Gradient::get_colorKeys()";
    public const string IL2CPP_get_mode = "UnityEngine.Gradient::get_mode()";
    public const string IL2CPP_Init = "UnityEngine.Gradient::Init()";
    public const string IL2CPP_Internal_Equals = "UnityEngine.Gradient::Internal_Equals(System.IntPtr)";
    public const string IL2CPP_set_mode = "UnityEngine.Gradient::set_mode(UnityEngine.GradientMode)";
    public const string IL2CPP_SetKeys = "UnityEngine.Gradient::SetKeys(UnityEngine.GradientColorKey[],UnityEngine.GradientAlphaKey[])";
}

