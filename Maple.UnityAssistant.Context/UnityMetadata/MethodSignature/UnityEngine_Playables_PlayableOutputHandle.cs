namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Playables_PlayableOutputHandle
{
    public const string MONO_AddNotificationReceiverInjected = "UnityEngine.Playables.PlayableOutputHandle::AddNotificationReceiver_Injected";
    public const string MONO_GetNotificationReceiversInjected = "UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers_Injected";
    public const string MONO_GetPlayableOutputTypeInjected = "UnityEngine.Playables.PlayableOutputHandle::GetPlayableOutputType_Injected";
    public const string MONO_GetReferenceObjectInjected = "UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected";
    public const string MONO_GetSourceOutputPortInjected = "UnityEngine.Playables.PlayableOutputHandle::GetSourceOutputPort_Injected";
    public const string MONO_GetSourcePlayableInjected = "UnityEngine.Playables.PlayableOutputHandle::GetSourcePlayable_Injected";
    public const string MONO_GetUserDataInjected = "UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected";
    public const string MONO_GetWeightInjected = "UnityEngine.Playables.PlayableOutputHandle::GetWeight_Injected";
    public const string MONO_IsNullInjected = "UnityEngine.Playables.PlayableOutputHandle::IsNull_Injected";
    public const string MONO_IsValidInjected = "UnityEngine.Playables.PlayableOutputHandle::IsValid_Injected";
    public const string MONO_PushNotificationInjected = "UnityEngine.Playables.PlayableOutputHandle::PushNotification_Injected";
    public const string MONO_RemoveNotificationReceiverInjected = "UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver_Injected";
    public const string MONO_SetReferenceObjectInjected = "UnityEngine.Playables.PlayableOutputHandle::SetReferenceObject_Injected";
    public const string MONO_SetSourcePlayableInjected = "UnityEngine.Playables.PlayableOutputHandle::SetSourcePlayable_Injected";
    public const string MONO_SetUserDataInjected = "UnityEngine.Playables.PlayableOutputHandle::SetUserData_Injected";
    public const string MONO_SetWeightInjected = "UnityEngine.Playables.PlayableOutputHandle::SetWeight_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Playables_PlayableOutputHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Playables_PlayableOutputHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Playables_PlayableOutputHandle(nint ptr) => new Ptr_UnityEngine_Playables_PlayableOutputHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Playables_PlayableOutputHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Playables_PlayableOutputHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_AddNotificationReceiver_Injected = "UnityEngine.Playables.PlayableOutputHandle::AddNotificationReceiver_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Playables.INotificationReceiver)";
    public const string IL2CPP_GetPlayableOutputType_Injected = "UnityEngine.Playables.PlayableOutputHandle::GetPlayableOutputType_Injected(UnityEngine.Playables.PlayableOutputHandle&)";
    public const string IL2CPP_GetSourceOutputPort_Injected = "UnityEngine.Playables.PlayableOutputHandle::GetSourceOutputPort_Injected(UnityEngine.Playables.PlayableOutputHandle&)";
    public const string IL2CPP_GetSourcePlayable_Injected = "UnityEngine.Playables.PlayableOutputHandle::GetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Playables.PlayableHandle&)";
    public const string IL2CPP_IsValid_Injected = "UnityEngine.Playables.PlayableOutputHandle::IsValid_Injected(UnityEngine.Playables.PlayableOutputHandle&)";
    public const string IL2CPP_PushNotification_Injected = "UnityEngine.Playables.PlayableOutputHandle::PushNotification_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Playables.PlayableHandle&,UnityEngine.Playables.INotification,System.Object)";
    public const string IL2CPP_SetReferenceObject_Injected = "UnityEngine.Playables.PlayableOutputHandle::SetReferenceObject_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Object)";
    public const string IL2CPP_SetSourcePlayable_Injected = "UnityEngine.Playables.PlayableOutputHandle::SetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Playables.PlayableHandle&,System.Int32)";
    public const string IL2CPP_SetUserData_Injected = "UnityEngine.Playables.PlayableOutputHandle::SetUserData_Injected(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Object)";
    public const string IL2CPP_SetWeight_Injected = "UnityEngine.Playables.PlayableOutputHandle::SetWeight_Injected(UnityEngine.Playables.PlayableOutputHandle&,System.Single)";
}

