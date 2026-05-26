namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_AnimationStreamHandleUtility
{
    public const string MONO_ReadStreamFloatsInternal = "UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamFloatsInternal";
    public const string MONO_ReadStreamIntsInternal = "UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamIntsInternal";
    public const string MONO_WriteStreamFloatsInternal = "UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamFloatsInternal";
    public const string MONO_WriteStreamIntsInternal = "UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamIntsInternal";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_AnimationStreamHandleUtility : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_AnimationStreamHandleUtility(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_AnimationStreamHandleUtility(nint ptr) => new Ptr_UnityEngine_Animations_AnimationStreamHandleUtility(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_AnimationStreamHandleUtility ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_AnimationStreamHandleUtility ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
