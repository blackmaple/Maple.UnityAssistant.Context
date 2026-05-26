namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_NoAllocHelpers
{
    public const string MONO_ExtractArrayFromList = "UnityEngine.NoAllocHelpers::ExtractArrayFromList";
    public const string MONO_InternalResizeList = "UnityEngine.NoAllocHelpers::Internal_ResizeList";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_NoAllocHelpers : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_NoAllocHelpers(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_NoAllocHelpers(nint ptr) => new Ptr_UnityEngine_NoAllocHelpers(ptr);
        public static implicit operator nint(Ptr_UnityEngine_NoAllocHelpers ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_NoAllocHelpers ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ExtractArrayFromList = "UnityEngine.NoAllocHelpers::ExtractArrayFromList(System.Object)";
    public const string IL2CPP_Internal_ResizeList = "UnityEngine.NoAllocHelpers::Internal_ResizeList(System.Object,System.Int32)";
}

