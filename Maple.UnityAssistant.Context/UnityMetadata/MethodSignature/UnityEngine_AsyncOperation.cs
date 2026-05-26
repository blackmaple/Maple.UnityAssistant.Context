namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AsyncOperation
{
    public const string MONO_GetAllowSceneActivation = "UnityEngine.AsyncOperation::get_allowSceneActivation";
    public const string MONO_GetIsDone = "UnityEngine.AsyncOperation::get_isDone";
    public const string MONO_GetPriority = "UnityEngine.AsyncOperation::get_priority";
    public const string MONO_GetProgress = "UnityEngine.AsyncOperation::get_progress";
    public const string MONO_InternalDestroy = "UnityEngine.AsyncOperation::InternalDestroy";
    public const string MONO_SetAllowSceneActivation = "UnityEngine.AsyncOperation::set_allowSceneActivation";
    public const string MONO_SetPriority = "UnityEngine.AsyncOperation::set_priority";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AsyncOperation : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AsyncOperation(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AsyncOperation(nint ptr) => new Ptr_UnityEngine_AsyncOperation(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AsyncOperation ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AsyncOperation ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_get_allowSceneActivation = "UnityEngine.AsyncOperation::get_allowSceneActivation()";
    public const string IL2CPP_get_isDone = "UnityEngine.AsyncOperation::get_isDone()";
    public const string IL2CPP_get_priority = "UnityEngine.AsyncOperation::get_priority()";
    public const string IL2CPP_get_progress = "UnityEngine.AsyncOperation::get_progress()";
    public const string IL2CPP_InternalDestroy = "UnityEngine.AsyncOperation::InternalDestroy(System.IntPtr)";
    public const string IL2CPP_set_allowSceneActivation = "UnityEngine.AsyncOperation::set_allowSceneActivation(System.Boolean)";
    public const string IL2CPP_set_priority = "UnityEngine.AsyncOperation::set_priority(System.Int32)";
}

