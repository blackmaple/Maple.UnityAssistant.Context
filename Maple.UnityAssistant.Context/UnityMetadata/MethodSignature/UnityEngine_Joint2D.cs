namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Joint2D
{
    public const string MONO_GetAttachedRigidbody = "UnityEngine.Joint2D::get_attachedRigidbody";
    public const string MONO_GetBreakForce = "UnityEngine.Joint2D::get_breakForce";
    public const string MONO_GetBreakTorque = "UnityEngine.Joint2D::get_breakTorque";
    public const string MONO_GetConnectedBody = "UnityEngine.Joint2D::get_connectedBody";
    public const string MONO_GetEnableCollision = "UnityEngine.Joint2D::get_enableCollision";
    public const string MONO_GetReactionForceInjected = "UnityEngine.Joint2D::get_reactionForce_Injected";
    public const string MONO_GetReactionTorque = "UnityEngine.Joint2D::get_reactionTorque";
    public const string MONO_GetReactionForceInjected_2 = "UnityEngine.Joint2D::GetReactionForce_Injected";
    public const string MONO_GetReactionTorque_2 = "UnityEngine.Joint2D::GetReactionTorque";
    public const string MONO_SetBreakForce = "UnityEngine.Joint2D::set_breakForce";
    public const string MONO_SetBreakTorque = "UnityEngine.Joint2D::set_breakTorque";
    public const string MONO_SetConnectedBody = "UnityEngine.Joint2D::set_connectedBody";
    public const string MONO_SetEnableCollision = "UnityEngine.Joint2D::set_enableCollision";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Joint2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Joint2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Joint2D(nint ptr) => new Ptr_UnityEngine_Joint2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Joint2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Joint2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_connectedBody = "UnityEngine.Joint2D::get_connectedBody()";
}

