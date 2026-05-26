namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_MonoBehaviour
{
    public const string MONO_CancelInvoke = "UnityEngine.MonoBehaviour::CancelInvoke";
    public const string MONO_GetUseGuilayout = "UnityEngine.MonoBehaviour::get_useGUILayout";
    public const string MONO_GetScriptClassName = "UnityEngine.MonoBehaviour::GetScriptClassName";
    public const string MONO_InternalCancelInvokeAll = "UnityEngine.MonoBehaviour::Internal_CancelInvokeAll";
    public const string MONO_InternalIsInvokingAll = "UnityEngine.MonoBehaviour::Internal_IsInvokingAll";
    public const string MONO_InvokeDelayed = "UnityEngine.MonoBehaviour::InvokeDelayed";
    public const string MONO_IsInvoking = "UnityEngine.MonoBehaviour::IsInvoking";
    public const string MONO_IsObjectMonoBehaviour = "UnityEngine.MonoBehaviour::IsObjectMonoBehaviour";
    public const string MONO_SetUseGuilayout = "UnityEngine.MonoBehaviour::set_useGUILayout";
    public const string MONO_StartCoroutineManaged = "UnityEngine.MonoBehaviour::StartCoroutineManaged";
    public const string MONO_StartCoroutineManaged2 = "UnityEngine.MonoBehaviour::StartCoroutineManaged2";
    public const string MONO_StopAllCoroutines = "UnityEngine.MonoBehaviour::StopAllCoroutines";
    public const string MONO_StopCoroutine = "UnityEngine.MonoBehaviour::StopCoroutine";
    public const string MONO_StopCoroutineFromEnumeratorManaged = "UnityEngine.MonoBehaviour::StopCoroutineFromEnumeratorManaged";
    public const string MONO_StopCoroutineManaged = "UnityEngine.MonoBehaviour::StopCoroutineManaged";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_MonoBehaviour : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_MonoBehaviour(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_MonoBehaviour(nint ptr) => new Ptr_UnityEngine_MonoBehaviour(ptr);
        public static implicit operator nint(Ptr_UnityEngine_MonoBehaviour ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_MonoBehaviour ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CancelInvoke = "UnityEngine.MonoBehaviour::CancelInvoke(UnityEngine.MonoBehaviour,System.String)";
    public const string IL2CPP_get_useGUILayout = "UnityEngine.MonoBehaviour::get_useGUILayout()";
    public const string IL2CPP_GetScriptClassName = "UnityEngine.MonoBehaviour::GetScriptClassName()";
    public const string IL2CPP_Internal_CancelInvokeAll = "UnityEngine.MonoBehaviour::Internal_CancelInvokeAll(UnityEngine.MonoBehaviour)";
    public const string IL2CPP_Internal_IsInvokingAll = "UnityEngine.MonoBehaviour::Internal_IsInvokingAll(UnityEngine.MonoBehaviour)";
    public const string IL2CPP_InvokeDelayed = "UnityEngine.MonoBehaviour::InvokeDelayed(UnityEngine.MonoBehaviour,System.String,System.Single,System.Single)";
    public const string IL2CPP_IsInvoking = "UnityEngine.MonoBehaviour::IsInvoking(UnityEngine.MonoBehaviour,System.String)";
    public const string IL2CPP_IsObjectMonoBehaviour = "UnityEngine.MonoBehaviour::IsObjectMonoBehaviour(UnityEngine.Object)";
    public const string IL2CPP_set_useGUILayout = "UnityEngine.MonoBehaviour::set_useGUILayout(System.Boolean)";
    public const string IL2CPP_StartCoroutineManaged = "UnityEngine.MonoBehaviour::StartCoroutineManaged(System.String,System.Object)";
    public const string IL2CPP_StartCoroutineManaged2 = "UnityEngine.MonoBehaviour::StartCoroutineManaged2(System.Collections.IEnumerator)";
    public const string IL2CPP_StopAllCoroutines = "UnityEngine.MonoBehaviour::StopAllCoroutines()";
    public const string IL2CPP_StopCoroutine = "UnityEngine.MonoBehaviour::StopCoroutine(System.String)";
    public const string IL2CPP_StopCoroutineFromEnumeratorManaged = "UnityEngine.MonoBehaviour::StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator)";
    public const string IL2CPP_StopCoroutineManaged = "UnityEngine.MonoBehaviour::StopCoroutineManaged(UnityEngine.Coroutine)";
}

