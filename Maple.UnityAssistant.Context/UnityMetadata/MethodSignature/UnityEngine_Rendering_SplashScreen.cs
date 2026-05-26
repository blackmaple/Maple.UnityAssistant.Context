namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Rendering_SplashScreen
{
    public const string MONO_Begin = "UnityEngine.Rendering.SplashScreen::Begin";
    public const string MONO_BeginSplashScreenFade = "UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade";
    public const string MONO_CancelSplashScreen = "UnityEngine.Rendering.SplashScreen::CancelSplashScreen";
    public const string MONO_Draw = "UnityEngine.Rendering.SplashScreen::Draw";
    public const string MONO_GetIsFinished = "UnityEngine.Rendering.SplashScreen::get_isFinished";
    public const string MONO_SetTime = "UnityEngine.Rendering.SplashScreen::SetTime";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Rendering_SplashScreen : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Rendering_SplashScreen(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Rendering_SplashScreen(nint ptr) => new Ptr_UnityEngine_Rendering_SplashScreen(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Rendering_SplashScreen ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Rendering_SplashScreen ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_isFinished = "UnityEngine.Rendering.SplashScreen::get_isFinished()";
}

