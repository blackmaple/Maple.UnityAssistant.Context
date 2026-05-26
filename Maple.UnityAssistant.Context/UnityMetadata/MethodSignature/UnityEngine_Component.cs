namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Component
{
    public const string MONO_BroadcastMessage = "UnityEngine.Component::BroadcastMessage";
    public const string MONO_GetGameObject = "UnityEngine.Component::get_gameObject";
    public const string MONO_GetTransform = "UnityEngine.Component::get_transform";
    public const string MONO_GetComponent = "UnityEngine.Component::GetComponent";
    public const string MONO_GetComponentFastPath = "UnityEngine.Component::GetComponentFastPath";
    public const string MONO_GetComponentsForListInternal = "UnityEngine.Component::GetComponentsForListInternal";
    public const string MONO_SendMessage = "UnityEngine.Component::SendMessage";
    public const string MONO_SendMessageUpwards = "UnityEngine.Component::SendMessageUpwards";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Component : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Component(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Component(nint ptr) => new Ptr_UnityEngine_Component(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Component ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Component ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_BroadcastMessage = "UnityEngine.Component::BroadcastMessage(System.String,System.Object,UnityEngine.SendMessageOptions)";
    public const string IL2CPP_get_gameObject = "UnityEngine.Component::get_gameObject()";
    public const string IL2CPP_get_transform = "UnityEngine.Component::get_transform()";
    public const string IL2CPP_GetComponent = "UnityEngine.Component::GetComponent(System.String)";
    public const string IL2CPP_GetComponentFastPath = "UnityEngine.Component::GetComponentFastPath(System.Type,System.IntPtr)";
    public const string IL2CPP_GetComponentsForListInternal = "UnityEngine.Component::GetComponentsForListInternal(System.Type,System.Object)";
    public const string IL2CPP_SendMessage = "UnityEngine.Component::SendMessage(System.String,System.Object,UnityEngine.SendMessageOptions)";
    public const string IL2CPP_SendMessageUpwards = "UnityEngine.Component::SendMessageUpwards(System.String,System.Object,UnityEngine.SendMessageOptions)";
}

