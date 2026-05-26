namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AnchoredJoint2D
{
    public const string MONO_GetAnchorInjected = "UnityEngine.AnchoredJoint2D::get_anchor_Injected";
    public const string MONO_GetAutoConfigureConnectedAnchor = "UnityEngine.AnchoredJoint2D::get_autoConfigureConnectedAnchor";
    public const string MONO_GetConnectedAnchorInjected = "UnityEngine.AnchoredJoint2D::get_connectedAnchor_Injected";
    public const string MONO_SetAnchorInjected = "UnityEngine.AnchoredJoint2D::set_anchor_Injected";
    public const string MONO_SetAutoConfigureConnectedAnchor = "UnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor";
    public const string MONO_SetConnectedAnchorInjected = "UnityEngine.AnchoredJoint2D::set_connectedAnchor_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AnchoredJoint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AnchoredJoint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AnchoredJoint2D(nint ptr) => new Ptr_UnityEngine_AnchoredJoint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AnchoredJoint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AnchoredJoint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_connectedAnchor_Injected = "UnityEngine.AnchoredJoint2D::get_connectedAnchor_Injected(UnityEngine.Vector2&)";
}

