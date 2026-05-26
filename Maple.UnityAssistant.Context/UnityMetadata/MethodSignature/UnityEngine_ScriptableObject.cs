namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_ScriptableObject
{
    public const string MONO_CreateScriptableObject = "UnityEngine.ScriptableObject::CreateScriptableObject";
    public const string MONO_CreateScriptableObjectInstanceFromName = "UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName";
    public const string MONO_CreateScriptableObjectInstanceFromType = "UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromType";
    public const string MONO_ResetAndApplyDefaultInstances = "UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances";
    public const string MONO_SetDirty = "UnityEngine.ScriptableObject::SetDirty";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_ScriptableObject : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_ScriptableObject(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_ScriptableObject(nint ptr) => new Ptr_UnityEngine_ScriptableObject(ptr);
        public static implicit operator nint(Ptr_UnityEngine_ScriptableObject ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_ScriptableObject ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateScriptableObject = "UnityEngine.ScriptableObject::CreateScriptableObject(UnityEngine.ScriptableObject)";
    public const string IL2CPP_CreateScriptableObjectInstanceFromName = "UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName(System.String)";
    public const string IL2CPP_CreateScriptableObjectInstanceFromType = "UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromType(System.Type,System.Boolean)";
    public const string IL2CPP_ResetAndApplyDefaultInstances = "UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances(UnityEngine.Object)";
    public const string IL2CPP_SetDirty = "UnityEngine.ScriptableObject::SetDirty()";
}

