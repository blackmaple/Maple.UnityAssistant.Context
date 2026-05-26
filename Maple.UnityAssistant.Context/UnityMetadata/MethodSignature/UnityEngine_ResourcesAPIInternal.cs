namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ResourcesAPIInternal
{
    public const string MONO_FindObjectsOfTypeAll = "UnityEngine.ResourcesAPIInternal::FindObjectsOfTypeAll";
    public const string MONO_FindShaderByName = "UnityEngine.ResourcesAPIInternal::FindShaderByName";
    public const string MONO_Load = "UnityEngine.ResourcesAPIInternal::Load";
    public const string MONO_LoadAll = "UnityEngine.ResourcesAPIInternal::LoadAll";
    public const string MONO_LoadAsyncInternal = "UnityEngine.ResourcesAPIInternal::LoadAsyncInternal";
    public const string MONO_UnloadAsset = "UnityEngine.ResourcesAPIInternal::UnloadAsset";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ResourcesAPIInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ResourcesAPIInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ResourcesAPIInternal(nint ptr) => new Ptr_UnityEngine_ResourcesAPIInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ResourcesAPIInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ResourcesAPIInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_FindObjectsOfTypeAll = "UnityEngine.ResourcesAPIInternal::FindObjectsOfTypeAll(System.Type)";
    public const string IL2CPP_FindShaderByName = "UnityEngine.ResourcesAPIInternal::FindShaderByName(System.String)";
    public const string IL2CPP_Load = "UnityEngine.ResourcesAPIInternal::Load(System.String,System.Type)";
    public const string IL2CPP_LoadAll = "UnityEngine.ResourcesAPIInternal::LoadAll(System.String,System.Type)";
    public const string IL2CPP_LoadAsyncInternal = "UnityEngine.ResourcesAPIInternal::LoadAsyncInternal(System.String,System.Type)";
    public const string IL2CPP_UnloadAsset = "UnityEngine.ResourcesAPIInternal::UnloadAsset(UnityEngine.Object)";
}

