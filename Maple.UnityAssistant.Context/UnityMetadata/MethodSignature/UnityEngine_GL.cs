namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GL
{
    public const string MONO_Begin = "UnityEngine.GL::Begin";
    public const string MONO_ClearWithSkybox = "UnityEngine.GL::ClearWithSkybox";
    public const string MONO_End = "UnityEngine.GL::End";
    public const string MONO_Flush = "UnityEngine.GL::Flush";
    public const string MONO_GetInvertCulling = "UnityEngine.GL::get_invertCulling";
    public const string MONO_GetSRgbwrite = "UnityEngine.GL::get_sRGBWrite";
    public const string MONO_GetWireframe = "UnityEngine.GL::get_wireframe";
    public const string MONO_GetGpuprojectionMatrixInjected = "UnityEngine.GL::GetGPUProjectionMatrix_Injected";
    public const string MONO_GetWorldViewMatrixInjected = "UnityEngine.GL::GetWorldViewMatrix_Injected";
    public const string MONO_GlclearInjected = "UnityEngine.GL::GLClear_Injected";
    public const string MONO_GlissuePluginEvent = "UnityEngine.GL::GLIssuePluginEvent";
    public const string MONO_GlloadPixelMatrixScript = "UnityEngine.GL::GLLoadPixelMatrixScript";
    public const string MONO_ImmediateColor = "UnityEngine.GL::ImmediateColor";
    public const string MONO_InvalidateState = "UnityEngine.GL::InvalidateState";
    public const string MONO_IssuePluginEvent = "UnityEngine.GL::IssuePluginEvent";
    public const string MONO_LoadIdentity = "UnityEngine.GL::LoadIdentity";
    public const string MONO_LoadOrtho = "UnityEngine.GL::LoadOrtho";
    public const string MONO_LoadPixelMatrix = "UnityEngine.GL::LoadPixelMatrix";
    public const string MONO_LoadProjectionMatrixInjected = "UnityEngine.GL::LoadProjectionMatrix_Injected";
    public const string MONO_MultiTexCoord3 = "UnityEngine.GL::MultiTexCoord3";
    public const string MONO_MultMatrixInjected = "UnityEngine.GL::MultMatrix_Injected";
    public const string MONO_PopMatrix = "UnityEngine.GL::PopMatrix";
    public const string MONO_PushMatrix = "UnityEngine.GL::PushMatrix";
    public const string MONO_RenderTargetBarrier = "UnityEngine.GL::RenderTargetBarrier";
    public const string MONO_SetInvertCulling = "UnityEngine.GL::set_invertCulling";
    public const string MONO_SetSRgbwrite = "UnityEngine.GL::set_sRGBWrite";
    public const string MONO_SetWireframe = "UnityEngine.GL::set_wireframe";
    public const string MONO_SetRevertBackfacing = "UnityEngine.GL::SetRevertBackfacing";
    public const string MONO_SetViewMatrixInjected = "UnityEngine.GL::SetViewMatrix_Injected";
    public const string MONO_TexCoord3 = "UnityEngine.GL::TexCoord3";
    public const string MONO_Vertex3 = "UnityEngine.GL::Vertex3";
    public const string MONO_ViewportInjected = "UnityEngine.GL::Viewport_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GL : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GL(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GL(nint ptr) => new Ptr_UnityEngine_GL(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GL ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GL ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Begin = "UnityEngine.GL::Begin(System.Int32)";
    public const string IL2CPP_End = "UnityEngine.GL::End()";
    public const string IL2CPP_get_wireframe = "UnityEngine.GL::get_wireframe()";
    public const string IL2CPP_GetGPUProjectionMatrix_Injected = "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GLClear_Injected = "UnityEngine.GL::GLClear_Injected(System.Boolean,System.Boolean,UnityEngine.Color&,System.Single)";
    public const string IL2CPP_GLLoadPixelMatrixScript = "UnityEngine.GL::GLLoadPixelMatrixScript(System.Single,System.Single,System.Single,System.Single)";
    public const string IL2CPP_ImmediateColor = "UnityEngine.GL::ImmediateColor(System.Single,System.Single,System.Single,System.Single)";
    public const string IL2CPP_LoadOrtho = "UnityEngine.GL::LoadOrtho()";
    public const string IL2CPP_LoadProjectionMatrix_Injected = "UnityEngine.GL::LoadProjectionMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_PopMatrix = "UnityEngine.GL::PopMatrix()";
    public const string IL2CPP_PushMatrix = "UnityEngine.GL::PushMatrix()";
    public const string IL2CPP_set_wireframe = "UnityEngine.GL::set_wireframe(System.Boolean)";
    public const string IL2CPP_SetViewMatrix_Injected = "UnityEngine.GL::SetViewMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_TexCoord3 = "UnityEngine.GL::TexCoord3(System.Single,System.Single,System.Single)";
    public const string IL2CPP_Vertex3 = "UnityEngine.GL::Vertex3(System.Single,System.Single,System.Single)";
    public const string IL2CPP_Viewport_Injected = "UnityEngine.GL::Viewport_Injected(UnityEngine.Rect&)";
}

