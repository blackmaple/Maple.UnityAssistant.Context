namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SceneManagement_Scene
{
    public const string MONO_GetBuildIndexInternal = "UnityEngine.SceneManagement.Scene::GetBuildIndexInternal";
    public const string MONO_GetDirtyId = "UnityEngine.SceneManagement.Scene::GetDirtyID";
    public const string MONO_GetGuidinternal = "UnityEngine.SceneManagement.Scene::GetGUIDInternal";
    public const string MONO_GetIsDirtyInternal = "UnityEngine.SceneManagement.Scene::GetIsDirtyInternal";
    public const string MONO_GetIsLoadedInternal = "UnityEngine.SceneManagement.Scene::GetIsLoadedInternal";
    public const string MONO_GetLoadingStateInternal = "UnityEngine.SceneManagement.Scene::GetLoadingStateInternal";
    public const string MONO_GetNameInternal = "UnityEngine.SceneManagement.Scene::GetNameInternal";
    public const string MONO_GetPathInternal = "UnityEngine.SceneManagement.Scene::GetPathInternal";
    public const string MONO_GetRootCountInternal = "UnityEngine.SceneManagement.Scene::GetRootCountInternal";
    public const string MONO_GetRootGameObjectsInternal = "UnityEngine.SceneManagement.Scene::GetRootGameObjectsInternal";
    public const string MONO_IsSubScene = "UnityEngine.SceneManagement.Scene::IsSubScene";
    public const string MONO_IsValidInternal = "UnityEngine.SceneManagement.Scene::IsValidInternal";
    public const string MONO_SetIsSubScene = "UnityEngine.SceneManagement.Scene::SetIsSubScene";
    public const string MONO_SetNameInternal = "UnityEngine.SceneManagement.Scene::SetNameInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SceneManagement_Scene : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SceneManagement_Scene(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SceneManagement_Scene(nint ptr) => new Ptr_UnityEngine_SceneManagement_Scene(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SceneManagement_Scene ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SceneManagement_Scene ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetBuildIndexInternal = "UnityEngine.SceneManagement.Scene::GetBuildIndexInternal(System.Int32)";
    public const string IL2CPP_GetDirtyID = "UnityEngine.SceneManagement.Scene::GetDirtyID(System.Int32)";
    public const string IL2CPP_GetGUIDInternal = "UnityEngine.SceneManagement.Scene::GetGUIDInternal(System.Int32)";
    public const string IL2CPP_GetIsDirtyInternal = "UnityEngine.SceneManagement.Scene::GetIsDirtyInternal(System.Int32)";
    public const string IL2CPP_GetIsLoadedInternal = "UnityEngine.SceneManagement.Scene::GetIsLoadedInternal(System.Int32)";
    public const string IL2CPP_GetLoadingStateInternal = "UnityEngine.SceneManagement.Scene::GetLoadingStateInternal(System.Int32)";
    public const string IL2CPP_GetNameInternal = "UnityEngine.SceneManagement.Scene::GetNameInternal(System.Int32)";
    public const string IL2CPP_GetPathInternal = "UnityEngine.SceneManagement.Scene::GetPathInternal(System.Int32)";
    public const string IL2CPP_GetRootCountInternal = "UnityEngine.SceneManagement.Scene::GetRootCountInternal(System.Int32)";
    public const string IL2CPP_GetRootGameObjectsInternal = "UnityEngine.SceneManagement.Scene::GetRootGameObjectsInternal(System.Int32,System.Object)";
    public const string IL2CPP_IsSubScene = "UnityEngine.SceneManagement.Scene::IsSubScene(System.Int32)";
    public const string IL2CPP_IsValidInternal = "UnityEngine.SceneManagement.Scene::IsValidInternal(System.Int32)";
    public const string IL2CPP_SetIsSubScene = "UnityEngine.SceneManagement.Scene::SetIsSubScene(System.Int32,System.Boolean)";
    public const string IL2CPP_SetNameInternal = "UnityEngine.SceneManagement.Scene::SetNameInternal(System.Int32,System.String)";
}

