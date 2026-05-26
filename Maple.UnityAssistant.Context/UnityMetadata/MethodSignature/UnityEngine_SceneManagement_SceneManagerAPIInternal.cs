namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_SceneManagement_SceneManagerAPIInternal
{
    public const string MONO_GetNumScenesInBuildSettings = "UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings";
    public const string MONO_GetSceneByBuildIndexInjected = "UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected";
    public const string MONO_LoadSceneAsyncNameIndexInternalInjected = "UnityEngine.SceneManagement.SceneManagerAPIInternal::LoadSceneAsyncNameIndexInternal_Injected";
    public const string MONO_UnloadSceneNameIndexInternal = "UnityEngine.SceneManagement.SceneManagerAPIInternal::UnloadSceneNameIndexInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal(nint ptr) => new Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_SceneManagement_SceneManagerAPIInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetNumScenesInBuildSettings = "UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings()";
    public const string IL2CPP_GetSceneByBuildIndex_Injected = "UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected(System.Int32,UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_LoadSceneAsyncNameIndexInternal_Injected = "UnityEngine.SceneManagement.SceneManagerAPIInternal::LoadSceneAsyncNameIndexInternal_Injected(System.String,System.Int32,UnityEngine.SceneManagement.LoadSceneParameters&,System.Boolean)";
    public const string IL2CPP_UnloadSceneNameIndexInternal = "UnityEngine.SceneManagement.SceneManagerAPIInternal::UnloadSceneNameIndexInternal(System.String,System.Int32,System.Boolean,UnityEngine.SceneManagement.UnloadSceneOptions,System.Boolean&)";
}

