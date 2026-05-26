namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_GameObject
{
    public const string MONO_AddComponentInternal = "UnityEngine.GameObject::AddComponentInternal";
    public const string MONO_BroadcastMessage = "UnityEngine.GameObject::BroadcastMessage";
    public const string MONO_CompareTag = "UnityEngine.GameObject::CompareTag";
    public const string MONO_CreatePrimitive = "UnityEngine.GameObject::CreatePrimitive";
    public const string MONO_Find = "UnityEngine.GameObject::Find";
    public const string MONO_FindGameObjectsWithTag = "UnityEngine.GameObject::FindGameObjectsWithTag";
    public const string MONO_FindGameObjectWithTag = "UnityEngine.GameObject::FindGameObjectWithTag";
    public const string MONO_GetActive = "UnityEngine.GameObject::get_active";
    public const string MONO_GetActiveInHierarchy = "UnityEngine.GameObject::get_activeInHierarchy";
    public const string MONO_GetActiveSelf = "UnityEngine.GameObject::get_activeSelf";
    public const string MONO_GetIsStatic = "UnityEngine.GameObject::get_isStatic";
    public const string MONO_GetIsStaticBatchable = "UnityEngine.GameObject::get_isStaticBatchable";
    public const string MONO_GetLayer = "UnityEngine.GameObject::get_layer";
    public const string MONO_GetSceneInjected = "UnityEngine.GameObject::get_scene_Injected";
    public const string MONO_GetSceneCullingMask = "UnityEngine.GameObject::get_sceneCullingMask";
    public const string MONO_GetTag = "UnityEngine.GameObject::get_tag";
    public const string MONO_GetTransform = "UnityEngine.GameObject::get_transform";
    public const string MONO_GetComponent = "UnityEngine.GameObject::GetComponent";
    public const string MONO_GetComponentByName = "UnityEngine.GameObject::GetComponentByName";
    public const string MONO_GetComponentFastPath = "UnityEngine.GameObject::GetComponentFastPath";
    public const string MONO_GetComponentInChildren = "UnityEngine.GameObject::GetComponentInChildren";
    public const string MONO_GetComponentInParent = "UnityEngine.GameObject::GetComponentInParent";
    public const string MONO_GetComponentsInternal = "UnityEngine.GameObject::GetComponentsInternal";
    public const string MONO_InternalAddComponentWithType = "UnityEngine.GameObject::Internal_AddComponentWithType";
    public const string MONO_InternalCreateGameObject = "UnityEngine.GameObject::Internal_CreateGameObject";
    public const string MONO_SendMessage = "UnityEngine.GameObject::SendMessage";
    public const string MONO_SendMessageUpwards = "UnityEngine.GameObject::SendMessageUpwards";
    public const string MONO_SetActive = "UnityEngine.GameObject::set_active";
    public const string MONO_SetIsStatic = "UnityEngine.GameObject::set_isStatic";
    public const string MONO_SetLayer = "UnityEngine.GameObject::set_layer";
    public const string MONO_SetTag = "UnityEngine.GameObject::set_tag";
    public const string MONO_SetActive_2 = "UnityEngine.GameObject::SetActive";
    public const string MONO_SetActiveRecursively = "UnityEngine.GameObject::SetActiveRecursively";
    public const string MONO_TryGetComponentFastPath = "UnityEngine.GameObject::TryGetComponentFastPath";
    public const string MONO_TryGetComponentInternal = "UnityEngine.GameObject::TryGetComponentInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_GameObject : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_GameObject(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_GameObject(nint ptr) => new Ptr_UnityEngine_GameObject(ptr);
        public static implicit operator nint(Ptr_UnityEngine_GameObject ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_GameObject ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddComponentInternal = "UnityEngine.GameObject::AddComponentInternal(System.String)";
    public const string IL2CPP_BroadcastMessage = "UnityEngine.GameObject::BroadcastMessage(System.String,System.Object,UnityEngine.SendMessageOptions)";
    public const string IL2CPP_CompareTag = "UnityEngine.GameObject::CompareTag(System.String)";
    public const string IL2CPP_CreatePrimitive = "UnityEngine.GameObject::CreatePrimitive(UnityEngine.PrimitiveType)";
    public const string IL2CPP_Find = "UnityEngine.GameObject::Find(System.String)";
    public const string IL2CPP_FindGameObjectsWithTag = "UnityEngine.GameObject::FindGameObjectsWithTag(System.String)";
    public const string IL2CPP_FindGameObjectWithTag = "UnityEngine.GameObject::FindGameObjectWithTag(System.String)";
    public const string IL2CPP_get_active = "UnityEngine.GameObject::get_active()";
    public const string IL2CPP_get_activeInHierarchy = "UnityEngine.GameObject::get_activeInHierarchy()";
    public const string IL2CPP_get_activeSelf = "UnityEngine.GameObject::get_activeSelf()";
    public const string IL2CPP_get_isStatic = "UnityEngine.GameObject::get_isStatic()";
    public const string IL2CPP_get_isStaticBatchable = "UnityEngine.GameObject::get_isStaticBatchable()";
    public const string IL2CPP_get_layer = "UnityEngine.GameObject::get_layer()";
    public const string IL2CPP_get_scene_Injected = "UnityEngine.GameObject::get_scene_Injected(UnityEngine.SceneManagement.Scene&)";
    public const string IL2CPP_get_sceneCullingMask = "UnityEngine.GameObject::get_sceneCullingMask()";
    public const string IL2CPP_get_tag = "UnityEngine.GameObject::get_tag()";
    public const string IL2CPP_get_transform = "UnityEngine.GameObject::get_transform()";
    public const string IL2CPP_GetComponent = "UnityEngine.GameObject::GetComponent(System.Type)";
    public const string IL2CPP_GetComponentByName = "UnityEngine.GameObject::GetComponentByName(System.String)";
    public const string IL2CPP_GetComponentFastPath = "UnityEngine.GameObject::GetComponentFastPath(System.Type,System.IntPtr)";
    public const string IL2CPP_GetComponentInChildren = "UnityEngine.GameObject::GetComponentInChildren(System.Type,System.Boolean)";
    public const string IL2CPP_GetComponentInParent = "UnityEngine.GameObject::GetComponentInParent(System.Type,System.Boolean)";
    public const string IL2CPP_GetComponentsInternal = "UnityEngine.GameObject::GetComponentsInternal(System.Type,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Object)";
    public const string IL2CPP_Internal_AddComponentWithType = "UnityEngine.GameObject::Internal_AddComponentWithType(System.Type)";
    public const string IL2CPP_Internal_CreateGameObject = "UnityEngine.GameObject::Internal_CreateGameObject(UnityEngine.GameObject,System.String)";
    public const string IL2CPP_SendMessage = "UnityEngine.GameObject::SendMessage(System.String,System.Object,UnityEngine.SendMessageOptions)";
    public const string IL2CPP_SendMessageUpwards = "UnityEngine.GameObject::SendMessageUpwards(System.String,System.Object,UnityEngine.SendMessageOptions)";
    public const string IL2CPP_set_active = "UnityEngine.GameObject::set_active(System.Boolean)";
    public const string IL2CPP_set_isStatic = "UnityEngine.GameObject::set_isStatic(System.Boolean)";
    public const string IL2CPP_set_layer = "UnityEngine.GameObject::set_layer(System.Int32)";
    public const string IL2CPP_set_tag = "UnityEngine.GameObject::set_tag(System.String)";
    public const string IL2CPP_SetActive = "UnityEngine.GameObject::SetActive(System.Boolean)";
    public const string IL2CPP_SetActiveRecursively = "UnityEngine.GameObject::SetActiveRecursively(System.Boolean)";
    public const string IL2CPP_TryGetComponentFastPath = "UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.IntPtr)";
    public const string IL2CPP_TryGetComponentInternal = "UnityEngine.GameObject::TryGetComponentInternal(System.Type)";
}

