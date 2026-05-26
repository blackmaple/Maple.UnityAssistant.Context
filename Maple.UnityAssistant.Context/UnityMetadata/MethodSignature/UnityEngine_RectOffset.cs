namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_RectOffset
{
    public const string MONO_AddInjected = "UnityEngine.RectOffset::Add_Injected";
    public const string MONO_GetBottom = "UnityEngine.RectOffset::get_bottom";
    public const string MONO_GetHorizontal = "UnityEngine.RectOffset::get_horizontal";
    public const string MONO_GetLeft = "UnityEngine.RectOffset::get_left";
    public const string MONO_GetRight = "UnityEngine.RectOffset::get_right";
    public const string MONO_GetTop = "UnityEngine.RectOffset::get_top";
    public const string MONO_GetVertical = "UnityEngine.RectOffset::get_vertical";
    public const string MONO_InternalCreate = "UnityEngine.RectOffset::InternalCreate";
    public const string MONO_InternalDestroy = "UnityEngine.RectOffset::InternalDestroy";
    public const string MONO_RemoveInjected = "UnityEngine.RectOffset::Remove_Injected";
    public const string MONO_SetBottom = "UnityEngine.RectOffset::set_bottom";
    public const string MONO_SetLeft = "UnityEngine.RectOffset::set_left";
    public const string MONO_SetRight = "UnityEngine.RectOffset::set_right";
    public const string MONO_SetTop = "UnityEngine.RectOffset::set_top";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_RectOffset : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_RectOffset(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_RectOffset(nint ptr) => new Ptr_UnityEngine_RectOffset(ptr);
        public static implicit operator nint(Ptr_UnityEngine_RectOffset ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_RectOffset ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_bottom = "UnityEngine.RectOffset::get_bottom()";
    public const string IL2CPP_get_horizontal = "UnityEngine.RectOffset::get_horizontal()";
    public const string IL2CPP_get_left = "UnityEngine.RectOffset::get_left()";
    public const string IL2CPP_get_right = "UnityEngine.RectOffset::get_right()";
    public const string IL2CPP_get_top = "UnityEngine.RectOffset::get_top()";
    public const string IL2CPP_get_vertical = "UnityEngine.RectOffset::get_vertical()";
    public const string IL2CPP_InternalCreate = "UnityEngine.RectOffset::InternalCreate()";
    public const string IL2CPP_InternalDestroy = "UnityEngine.RectOffset::InternalDestroy(System.IntPtr)";
    public const string IL2CPP_Remove_Injected = "UnityEngine.RectOffset::Remove_Injected(UnityEngine.Rect&,UnityEngine.Rect&)";
    public const string IL2CPP_set_bottom = "UnityEngine.RectOffset::set_bottom(System.Int32)";
    public const string IL2CPP_set_left = "UnityEngine.RectOffset::set_left(System.Int32)";
    public const string IL2CPP_set_right = "UnityEngine.RectOffset::set_right(System.Int32)";
    public const string IL2CPP_set_top = "UnityEngine.RectOffset::set_top(System.Int32)";
}

