namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_PropertyStreamHandle
{
    public const string MONO_GetBoolInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal_Injected";
    public const string MONO_GetFloatInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal_Injected";
    public const string MONO_GetIntInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::GetIntInternal_Injected";
    public const string MONO_GetReadMaskInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::GetReadMaskInternal_Injected";
    public const string MONO_ResolveInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::ResolveInternal_Injected";
    public const string MONO_SetBoolInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::SetBoolInternal_Injected";
    public const string MONO_SetFloatInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::SetFloatInternal_Injected";
    public const string MONO_SetIntInternalInjected = "UnityEngine.Animations.PropertyStreamHandle::SetIntInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_PropertyStreamHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_PropertyStreamHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_PropertyStreamHandle(nint ptr) => new Ptr_UnityEngine_Animations_PropertyStreamHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_PropertyStreamHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_PropertyStreamHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
