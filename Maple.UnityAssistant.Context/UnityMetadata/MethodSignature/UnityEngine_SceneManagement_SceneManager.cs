namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SceneManagement_SceneManager
{
    public const string MONO_CreateSceneInjected = "UnityEngine.SceneManagement.SceneManager::CreateScene_Injected";
    public const string MONO_GetSceneCount = "UnityEngine.SceneManagement.SceneManager::get_sceneCount";
    public const string MONO_GetActiveSceneInjected = "UnityEngine.SceneManagement.SceneManager::GetActiveScene_Injected";
    public const string MONO_GetSceneAtInjected = "UnityEngine.SceneManagement.SceneManager::GetSceneAt_Injected";
    public const string MONO_GetSceneByNameInjected = "UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected";
    public const string MONO_GetSceneByPathInjected = "UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected";
    public const string MONO_MergeScenesInjected = "UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected";
    public const string MONO_MoveGameObjectToSceneInjected = "UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected";
    public const string MONO_SetActiveSceneInjected = "UnityEngine.SceneManagement.SceneManager::SetActiveScene_Injected";
    public const string MONO_UnloadSceneAsyncInternalInjected = "UnityEngine.SceneManagement.SceneManager::UnloadSceneAsyncInternal_Injected";
    public const string MONO_UnloadSceneInternalInjected = "UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SceneManagement_SceneManager : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SceneManagement_SceneManager(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SceneManagement_SceneManager(nint ptr) => new Ptr_UnityEngine_SceneManagement_SceneManager(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SceneManagement_SceneManager ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SceneManagement_SceneManager ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateScene_Injected = "UnityEngine.SceneManagement.SceneManager::CreateScene_Injected(System.String,UnityEngine.SceneManagement.CreateSceneParameters&,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_get_sceneCount = "UnityEngine.SceneManagement.SceneManager::get_sceneCount()";
    public const string IL2CPP_GetActiveScene_Injected = "UnityEngine.SceneManagement.SceneManager::GetActiveScene_Injected(UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_GetSceneAt_Injected = "UnityEngine.SceneManagement.SceneManager::GetSceneAt_Injected(System.Int32,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_GetSceneByName_Injected = "UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected(System.String,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_GetSceneByPath_Injected = "UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected(System.String,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_MergeScenes_Injected = "UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected(UnityEngine.SceneManagement.Scene&,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_MoveGameObjectToScene_Injected = "UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected(UnityEngine.GameObject,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_SetActiveScene_Injected = "UnityEngine.SceneManagement.SceneManager::SetActiveScene_Injected(UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_UnloadSceneAsyncInternal_Injected = "UnityEngine.SceneManagement.SceneManager::UnloadSceneAsyncInternal_Injected(UnityEngine.SceneManagement.Scene&,UnityEngine.SceneManagement.UnloadSceneOptions)";
    public const string IL2CPP_UnloadSceneInternal_Injected = "UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected(UnityEngine.SceneManagement.Scene&,UnityEngine.SceneManagement.UnloadSceneOptions)";
}

