namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Resources
{
    public const string MONO_GetBuiltinResource = "UnityEngine.Resources::GetBuiltinResource";
    public const string MONO_InstanceIdtoObject = "UnityEngine.Resources::InstanceIDToObject";
    public const string MONO_InstanceIdtoObjectList = "UnityEngine.Resources::InstanceIDToObjectList";
    public const string MONO_UnloadAssetImplResourceManager = "UnityEngine.Resources::UnloadAssetImplResourceManager";
    public const string MONO_UnloadUnusedAssets = "UnityEngine.Resources::UnloadUnusedAssets";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Resources : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Resources(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Resources(nint ptr) => new Ptr_UnityEngine_Resources(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Resources ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Resources ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetBuiltinResource = "UnityEngine.Resources::GetBuiltinResource(System.Type,System.String)";
    public const string IL2CPP_InstanceIDToObject = "UnityEngine.Resources::InstanceIDToObject(System.Int32)";
    public const string IL2CPP_InstanceIDToObjectList = "UnityEngine.Resources::InstanceIDToObjectList(System.IntPtr,System.Int32,System.Collections.Generic.List`1<UnityEngine.Object>)";
    public const string IL2CPP_UnloadAssetImplResourceManager = "UnityEngine.Resources::UnloadAssetImplResourceManager(UnityEngine.Object)";
    public const string IL2CPP_UnloadUnusedAssets = "UnityEngine.Resources::UnloadUnusedAssets()";
}

