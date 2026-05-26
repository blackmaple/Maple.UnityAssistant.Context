namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Tree
{
    public const string MONO_GetData = "UnityEngine.Tree::get_data";
    public const string MONO_GetHasSpeedTreeWind = "UnityEngine.Tree::get_hasSpeedTreeWind";
    public const string MONO_SetData = "UnityEngine.Tree::set_data";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Tree : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Tree(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Tree(nint ptr) => new Ptr_UnityEngine_Tree(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Tree ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Tree ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
