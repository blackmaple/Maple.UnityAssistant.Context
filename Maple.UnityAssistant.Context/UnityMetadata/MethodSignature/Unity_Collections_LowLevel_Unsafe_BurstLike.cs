namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Collections_LowLevel_Unsafe_BurstLike
{
    public const string MONO_NativeFunctionCallIntIntPtrIntPtr = "Unity.Collections.LowLevel.Unsafe.BurstLike::NativeFunctionCall_Int_IntPtr_IntPtr";
    public const string MONO_StaticDataGetOrCreate = "Unity.Collections.LowLevel.Unsafe.BurstLike::StaticDataGetOrCreate";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike(nint ptr) => new Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike(ptr);
        public static implicit operator nint(Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Collections_LowLevel_Unsafe_BurstLike ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
