namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_DrivenPropertyManager
{
    public const string MONO_RegisterPropertyPartial = "UnityEngine.DrivenPropertyManager::RegisterPropertyPartial";
    public const string MONO_TryRegisterPropertyPartial = "UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial";
    public const string MONO_UnregisterProperties = "UnityEngine.DrivenPropertyManager::UnregisterProperties";
    public const string MONO_UnregisterPropertyPartial = "UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_DrivenPropertyManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_DrivenPropertyManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_DrivenPropertyManager(nint ptr) => new Ptr_UnityEngine_DrivenPropertyManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_DrivenPropertyManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_DrivenPropertyManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
