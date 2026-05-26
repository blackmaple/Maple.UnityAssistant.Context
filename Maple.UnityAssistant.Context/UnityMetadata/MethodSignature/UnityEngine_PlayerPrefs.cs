namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_PlayerPrefs
{
    public const string MONO_DeleteAll = "UnityEngine.PlayerPrefs::DeleteAll";
    public const string MONO_DeleteKey = "UnityEngine.PlayerPrefs::DeleteKey";
    public const string MONO_GetFloat = "UnityEngine.PlayerPrefs::GetFloat";
    public const string MONO_GetInt = "UnityEngine.PlayerPrefs::GetInt";
    public const string MONO_GetString = "UnityEngine.PlayerPrefs::GetString";
    public const string MONO_HasKey = "UnityEngine.PlayerPrefs::HasKey";
    public const string MONO_Save = "UnityEngine.PlayerPrefs::Save";
    public const string MONO_TrySetFloat = "UnityEngine.PlayerPrefs::TrySetFloat";
    public const string MONO_TrySetInt = "UnityEngine.PlayerPrefs::TrySetInt";
    public const string MONO_TrySetSetString = "UnityEngine.PlayerPrefs::TrySetSetString";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_PlayerPrefs : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_PlayerPrefs(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_PlayerPrefs(nint ptr) => new Ptr_UnityEngine_PlayerPrefs(ptr);
        public static implicit operator nint(Ptr_UnityEngine_PlayerPrefs ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_PlayerPrefs ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DeleteAll = "UnityEngine.PlayerPrefs::DeleteAll()";
    public const string IL2CPP_DeleteKey = "UnityEngine.PlayerPrefs::DeleteKey(System.String)";
    public const string IL2CPP_GetFloat = "UnityEngine.PlayerPrefs::GetFloat(System.String,System.Single)";
    public const string IL2CPP_GetInt = "UnityEngine.PlayerPrefs::GetInt(System.String,System.Int32)";
    public const string IL2CPP_GetString = "UnityEngine.PlayerPrefs::GetString(System.String,System.String)";
    public const string IL2CPP_HasKey = "UnityEngine.PlayerPrefs::HasKey(System.String)";
    public const string IL2CPP_Save = "UnityEngine.PlayerPrefs::Save()";
    public const string IL2CPP_TrySetFloat = "UnityEngine.PlayerPrefs::TrySetFloat(System.String,System.Single)";
    public const string IL2CPP_TrySetInt = "UnityEngine.PlayerPrefs::TrySetInt(System.String,System.Int32)";
    public const string IL2CPP_TrySetSetString = "UnityEngine.PlayerPrefs::TrySetSetString(System.String,System.String)";
}

