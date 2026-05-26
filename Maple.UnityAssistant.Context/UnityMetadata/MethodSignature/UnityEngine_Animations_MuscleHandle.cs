namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Animations_MuscleHandle
{
    public const string MONO_GetMuscleHandleCount = "UnityEngine.Animations.MuscleHandle::GetMuscleHandleCount";
    public const string MONO_GetMuscleHandles = "UnityEngine.Animations.MuscleHandle::GetMuscleHandles";
    public const string MONO_GetNameInjected = "UnityEngine.Animations.MuscleHandle::GetName_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Animations_MuscleHandle : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Animations_MuscleHandle(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Animations_MuscleHandle(nint ptr) => new Ptr_UnityEngine_Animations_MuscleHandle(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Animations_MuscleHandle ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Animations_MuscleHandle ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
