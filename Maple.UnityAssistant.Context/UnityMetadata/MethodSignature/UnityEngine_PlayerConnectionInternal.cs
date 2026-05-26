namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PlayerConnectionInternal
{
    public const string MONO_DisconnectAll = "UnityEngine.PlayerConnectionInternal::DisconnectAll";
    public const string MONO_Initialize = "UnityEngine.PlayerConnectionInternal::Initialize";
    public const string MONO_IsConnected = "UnityEngine.PlayerConnectionInternal::IsConnected";
    public const string MONO_PollInternal = "UnityEngine.PlayerConnectionInternal::PollInternal";
    public const string MONO_RegisterInternal = "UnityEngine.PlayerConnectionInternal::RegisterInternal";
    public const string MONO_SendMessage = "UnityEngine.PlayerConnectionInternal::SendMessage";
    public const string MONO_TrySendMessage = "UnityEngine.PlayerConnectionInternal::TrySendMessage";
    public const string MONO_UnregisterInternal = "UnityEngine.PlayerConnectionInternal::UnregisterInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PlayerConnectionInternal : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PlayerConnectionInternal(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PlayerConnectionInternal(nint ptr) => new Ptr_UnityEngine_PlayerConnectionInternal(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PlayerConnectionInternal ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PlayerConnectionInternal ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DisconnectAll = "UnityEngine.PlayerConnectionInternal::DisconnectAll()";
    public const string IL2CPP_Initialize = "UnityEngine.PlayerConnectionInternal::Initialize()";
    public const string IL2CPP_IsConnected = "UnityEngine.PlayerConnectionInternal::IsConnected()";
    public const string IL2CPP_PollInternal = "UnityEngine.PlayerConnectionInternal::PollInternal()";
    public const string IL2CPP_RegisterInternal = "UnityEngine.PlayerConnectionInternal::RegisterInternal(System.String)";
    public const string IL2CPP_SendMessage = "UnityEngine.PlayerConnectionInternal::SendMessage(System.String,System.Byte[],System.Int32)";
    public const string IL2CPP_TrySendMessage = "UnityEngine.PlayerConnectionInternal::TrySendMessage(System.String,System.Byte[],System.Int32)";
    public const string IL2CPP_UnregisterInternal = "UnityEngine.PlayerConnectionInternal::UnregisterInternal(System.String)";
}

