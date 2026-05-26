namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_CustomCollider2D
{
    public const string MONO_ClearCustomShapes = "UnityEngine.CustomCollider2D::ClearCustomShapes";
    public const string MONO_ClearCustomShapesInternal = "UnityEngine.CustomCollider2D::ClearCustomShapes_Internal";
    public const string MONO_GetCustomShapeCount = "UnityEngine.CustomCollider2D::get_customShapeCount";
    public const string MONO_GetCustomVertexCount = "UnityEngine.CustomCollider2D::get_customVertexCount";
    public const string MONO_GetCustomShapesInternal = "UnityEngine.CustomCollider2D::GetCustomShapes_Internal";
    public const string MONO_GetCustomShapesNativeInternal = "UnityEngine.CustomCollider2D::GetCustomShapesNative_Internal";
    public const string MONO_SetCustomShapeInternal = "UnityEngine.CustomCollider2D::SetCustomShape_Internal";
    public const string MONO_SetCustomShapeNativeInternal = "UnityEngine.CustomCollider2D::SetCustomShapeNative_Internal";
    public const string MONO_SetCustomShapesAllInternal = "UnityEngine.CustomCollider2D::SetCustomShapesAll_Internal";
    public const string MONO_SetCustomShapesNativeInternal = "UnityEngine.CustomCollider2D::SetCustomShapesNative_Internal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_CustomCollider2D : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_CustomCollider2D(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_CustomCollider2D(nint ptr) => new Ptr_UnityEngine_CustomCollider2D(ptr);
        public static implicit operator nint(Ptr_UnityEngine_CustomCollider2D ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_CustomCollider2D ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
