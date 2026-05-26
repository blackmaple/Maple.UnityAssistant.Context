namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Hash128
{
    public const string MONO_ComputeFromArray = "UnityEngine.Hash128::ComputeFromArray";
    public const string MONO_ComputeFromPtr = "UnityEngine.Hash128::ComputeFromPtr";
    public const string MONO_ComputeFromString = "UnityEngine.Hash128::ComputeFromString";
    public const string MONO_Hash128ToStringImplInjected = "UnityEngine.Hash128::Hash128ToStringImpl_Injected";
    public const string MONO_ParseInjected = "UnityEngine.Hash128::Parse_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Hash128 : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Hash128(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Hash128(nint ptr) => new Ptr_UnityEngine_Hash128(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Hash128 ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Hash128 ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Hash128ToStringImpl_Injected = "UnityEngine.Hash128::Hash128ToStringImpl_Injected(UnityEngine.Hash128&)";
}

