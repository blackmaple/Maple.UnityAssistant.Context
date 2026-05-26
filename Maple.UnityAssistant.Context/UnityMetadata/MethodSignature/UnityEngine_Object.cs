namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Object
{
    public const string MONO_CurrentThreadIsMainThread = "UnityEngine.Object::CurrentThreadIsMainThread";
    public const string MONO_Destroy = "UnityEngine.Object::Destroy";
    public const string MONO_DestroyImmediate = "UnityEngine.Object::DestroyImmediate";
    public const string MONO_DoesObjectWithInstanceIdexist = "UnityEngine.Object::DoesObjectWithInstanceIDExist";
    public const string MONO_DontDestroyOnLoad = "UnityEngine.Object::DontDestroyOnLoad";
    public const string MONO_FindObjectFromInstanceId = "UnityEngine.Object::FindObjectFromInstanceID";
    public const string MONO_FindObjectsOfType = "UnityEngine.Object::FindObjectsOfType";
    public const string MONO_FindObjectsOfTypeIncludingAssets = "UnityEngine.Object::FindObjectsOfTypeIncludingAssets";
    public const string MONO_ForceLoadFromInstanceId = "UnityEngine.Object::ForceLoadFromInstanceID";
    public const string MONO_GetHideFlags = "UnityEngine.Object::get_hideFlags";
    public const string MONO_GetName = "UnityEngine.Object::GetName";
    public const string MONO_GetOffsetOfInstanceIdinCplusPlusObject = "UnityEngine.Object::GetOffsetOfInstanceIDInCPlusPlusObject";
    public const string MONO_InternalCloneSingle = "UnityEngine.Object::Internal_CloneSingle";
    public const string MONO_InternalCloneSingleWithParent = "UnityEngine.Object::Internal_CloneSingleWithParent";
    public const string MONO_InternalInstantiateSingleInjected = "UnityEngine.Object::Internal_InstantiateSingle_Injected";
    public const string MONO_InternalInstantiateSingleWithParentInjected = "UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected";
    public const string MONO_IsPersistent = "UnityEngine.Object::IsPersistent";
    public const string MONO_SetHideFlags = "UnityEngine.Object::set_hideFlags";
    public const string MONO_SetName = "UnityEngine.Object::SetName";
    public const string MONO_ToString = "UnityEngine.Object::ToString";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Object : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Object(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Object(nint ptr) => new Ptr_UnityEngine_Object(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Object ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Object ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CurrentThreadIsMainThread = "UnityEngine.Object::CurrentThreadIsMainThread()";
    public const string IL2CPP_Destroy = "UnityEngine.Object::Destroy(UnityEngine.Object,System.Single)";
    public const string IL2CPP_DestroyImmediate = "UnityEngine.Object::DestroyImmediate(UnityEngine.Object,System.Boolean)";
    public const string IL2CPP_DoesObjectWithInstanceIDExist = "UnityEngine.Object::DoesObjectWithInstanceIDExist(System.Int32)";
    public const string IL2CPP_DontDestroyOnLoad = "UnityEngine.Object::DontDestroyOnLoad(UnityEngine.Object)";
    public const string IL2CPP_FindObjectFromInstanceID = "UnityEngine.Object::FindObjectFromInstanceID(System.Int32)";
    public const string IL2CPP_FindObjectsOfType = "UnityEngine.Object::FindObjectsOfType(System.Type,System.Boolean)";
    public const string IL2CPP_FindObjectsOfTypeIncludingAssets = "UnityEngine.Object::FindObjectsOfTypeIncludingAssets(System.Type)";
    public const string IL2CPP_ForceLoadFromInstanceID = "UnityEngine.Object::ForceLoadFromInstanceID(System.Int32)";
    public const string IL2CPP_get_hideFlags = "UnityEngine.Object::get_hideFlags()";
    public const string IL2CPP_GetName = "UnityEngine.Object::GetName(UnityEngine.Object)";
    public const string IL2CPP_GetOffsetOfInstanceIDInCPlusPlusObject = "UnityEngine.Object::GetOffsetOfInstanceIDInCPlusPlusObject()";
    public const string IL2CPP_Internal_CloneSingle = "UnityEngine.Object::Internal_CloneSingle(UnityEngine.Object)";
    public const string IL2CPP_Internal_CloneSingleWithParent = "UnityEngine.Object::Internal_CloneSingleWithParent(UnityEngine.Object,UnityEngine.Transform,System.Boolean)";
    public const string IL2CPP_Internal_InstantiateSingle_Injected = "UnityEngine.Object::Internal_InstantiateSingle_Injected(UnityEngine.Object,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_Internal_InstantiateSingleWithParent_Injected = "UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object,UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_IsPersistent = "UnityEngine.Object::IsPersistent(UnityEngine.Object)";
    public const string IL2CPP_set_hideFlags = "UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)";
    public const string IL2CPP_SetName = "UnityEngine.Object::SetName(UnityEngine.Object,System.String)";
    public const string IL2CPP_ToString = "UnityEngine.Object::ToString(UnityEngine.Object)";
}

