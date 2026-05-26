namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Scripting_GarbageCollector
{
    public const string MONO_CollectIncremental = "UnityEngine.Scripting.GarbageCollector::CollectIncremental";
    public const string MONO_GetIncrementalTimeSliceNanoseconds = "UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds";
    public const string MONO_GetIsIncremental = "UnityEngine.Scripting.GarbageCollector::get_isIncremental";
    public const string MONO_GetMode = "UnityEngine.Scripting.GarbageCollector::GetMode";
    public const string MONO_SetIncrementalTimeSliceNanoseconds = "UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds";
    public const string MONO_SetMode = "UnityEngine.Scripting.GarbageCollector::SetMode";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Scripting_GarbageCollector : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Scripting_GarbageCollector(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Scripting_GarbageCollector(nint ptr) => new Ptr_UnityEngine_Scripting_GarbageCollector(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Scripting_GarbageCollector ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Scripting_GarbageCollector ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
