namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Jobs_TransformAccessArray
{
    public const string MONO_Add = "UnityEngine.Jobs.TransformAccessArray::Add";
    public const string MONO_Create = "UnityEngine.Jobs.TransformAccessArray::Create";
    public const string MONO_DestroyTransformAccessArray = "UnityEngine.Jobs.TransformAccessArray::DestroyTransformAccessArray";
    public const string MONO_GetCapacity = "UnityEngine.Jobs.TransformAccessArray::GetCapacity";
    public const string MONO_GetLength = "UnityEngine.Jobs.TransformAccessArray::GetLength";
    public const string MONO_GetSortedToUserIndex = "UnityEngine.Jobs.TransformAccessArray::GetSortedToUserIndex";
    public const string MONO_GetSortedTransformAccess = "UnityEngine.Jobs.TransformAccessArray::GetSortedTransformAccess";
    public const string MONO_GetTransform = "UnityEngine.Jobs.TransformAccessArray::GetTransform";
    public const string MONO_RemoveAtSwapBack = "UnityEngine.Jobs.TransformAccessArray::RemoveAtSwapBack";
    public const string MONO_SetCapacity = "UnityEngine.Jobs.TransformAccessArray::SetCapacity";
    public const string MONO_SetTransform = "UnityEngine.Jobs.TransformAccessArray::SetTransform";
    public const string MONO_SetTransforms = "UnityEngine.Jobs.TransformAccessArray::SetTransforms";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Jobs_TransformAccessArray : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Jobs_TransformAccessArray(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Jobs_TransformAccessArray(nint ptr) => new Ptr_UnityEngine_Jobs_TransformAccessArray(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Jobs_TransformAccessArray ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Jobs_TransformAccessArray ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Add = "UnityEngine.Jobs.TransformAccessArray::Add(System.IntPtr,UnityEngine.Transform)";
    public const string IL2CPP_Create = "UnityEngine.Jobs.TransformAccessArray::Create(System.Int32,System.Int32)";
    public const string IL2CPP_DestroyTransformAccessArray = "UnityEngine.Jobs.TransformAccessArray::DestroyTransformAccessArray(System.IntPtr)";
    public const string IL2CPP_GetLength = "UnityEngine.Jobs.TransformAccessArray::GetLength(System.IntPtr)";
    public const string IL2CPP_GetSortedToUserIndex = "UnityEngine.Jobs.TransformAccessArray::GetSortedToUserIndex(System.IntPtr)";
    public const string IL2CPP_GetSortedTransformAccess = "UnityEngine.Jobs.TransformAccessArray::GetSortedTransformAccess(System.IntPtr)";
    public const string IL2CPP_GetTransform = "UnityEngine.Jobs.TransformAccessArray::GetTransform(System.IntPtr,System.Int32)";
    public const string IL2CPP_RemoveAtSwapBack = "UnityEngine.Jobs.TransformAccessArray::RemoveAtSwapBack(System.IntPtr,System.Int32)";
}

