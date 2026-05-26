namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GUIClip
{
    public const string MONO_ClipVector2Injected = "UnityEngine.GUIClip::Clip_Vector2_Injected";
    public const string MONO_ClipToWindowRectInjected = "UnityEngine.GUIClip::ClipToWindow_Rect_Injected";
    public const string MONO_ClipToWindowVector2Injected = "UnityEngine.GUIClip::ClipToWindow_Vector2_Injected";
    public const string MONO_GetEnabled = "UnityEngine.GUIClip::get_enabled";
    public const string MONO_GetTopmostRectInjected = "UnityEngine.GUIClip::get_topmostRect_Injected";
    public const string MONO_GetVisibleRectInjected = "UnityEngine.GUIClip::get_visibleRect_Injected";
    public const string MONO_GetMatrixInjected = "UnityEngine.GUIClip::GetMatrix_Injected";
    public const string MONO_GetParentMatrixInjected = "UnityEngine.GUIClip::GetParentMatrix_Injected";
    public const string MONO_GetTopRectInjected = "UnityEngine.GUIClip::GetTopRect_Injected";
    public const string MONO_InternalClipRectInjected = "UnityEngine.GUIClip::Internal_Clip_Rect_Injected";
    public const string MONO_InternalGetAbsoluteMousePositionInjected = "UnityEngine.GUIClip::Internal_GetAbsoluteMousePosition_Injected";
    public const string MONO_InternalGetCount = "UnityEngine.GUIClip::Internal_GetCount";
    public const string MONO_InternalPop = "UnityEngine.GUIClip::Internal_Pop";
    public const string MONO_InternalPopParentClip = "UnityEngine.GUIClip::Internal_PopParentClip";
    public const string MONO_InternalPushInjected = "UnityEngine.GUIClip::Internal_Push_Injected";
    public const string MONO_InternalPushParentClipInjected = "UnityEngine.GUIClip::Internal_PushParentClip_Injected";
    public const string MONO_Reapply = "UnityEngine.GUIClip::Reapply";
    public const string MONO_SetMatrixInjected = "UnityEngine.GUIClip::SetMatrix_Injected";
    public const string MONO_UnclipRectInjected = "UnityEngine.GUIClip::Unclip_Rect_Injected";
    public const string MONO_UnclipVector2Injected = "UnityEngine.GUIClip::Unclip_Vector2_Injected";
    public const string MONO_UnclipToWindowRectInjected = "UnityEngine.GUIClip::UnclipToWindow_Rect_Injected";
    public const string MONO_UnclipToWindowVector2Injected = "UnityEngine.GUIClip::UnclipToWindow_Vector2_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GUIClip : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GUIClip(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GUIClip(nint ptr) => new Ptr_UnityEngine_GUIClip(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GUIClip ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GUIClip ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_visibleRect_Injected = "UnityEngine.GUIClip::get_visibleRect_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_GetMatrix_Injected = "UnityEngine.GUIClip::GetMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_Internal_GetCount = "UnityEngine.GUIClip::Internal_GetCount()";
    public const string IL2CPP_Internal_Pop = "UnityEngine.GUIClip::Internal_Pop()";
    public const string IL2CPP_Internal_PopParentClip = "UnityEngine.GUIClip::Internal_PopParentClip()";
    public const string IL2CPP_Internal_Push_Injected = "UnityEngine.GUIClip::Internal_Push_Injected(UnityEngine.Rect&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Boolean)";
    public const string IL2CPP_Internal_PushParentClip_Injected = "UnityEngine.GUIClip::Internal_PushParentClip_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Rect&)";
    public const string IL2CPP_SetMatrix_Injected = "UnityEngine.GUIClip::SetMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_UnclipToWindow_Vector2_Injected = "UnityEngine.GUIClip::UnclipToWindow_Vector2_Injected(UnityEngine.Vector2&,UnityEngine.Vector2&)";
}

