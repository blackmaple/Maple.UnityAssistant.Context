namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Analytics_CustomEventData
{
    public const string MONO_AddBool = "UnityEngine.Analytics.CustomEventData::AddBool";
    public const string MONO_AddDouble = "UnityEngine.Analytics.CustomEventData::AddDouble";
    public const string MONO_AddInt32 = "UnityEngine.Analytics.CustomEventData::AddInt32";
    public const string MONO_AddInt64 = "UnityEngine.Analytics.CustomEventData::AddInt64";
    public const string MONO_AddString = "UnityEngine.Analytics.CustomEventData::AddString";
    public const string MONO_AddUint32 = "UnityEngine.Analytics.CustomEventData::AddUInt32";
    public const string MONO_AddUint64 = "UnityEngine.Analytics.CustomEventData::AddUInt64";
    public const string MONO_InternalCreate = "UnityEngine.Analytics.CustomEventData::Internal_Create";
    public const string MONO_InternalDestroy = "UnityEngine.Analytics.CustomEventData::Internal_Destroy";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Analytics_CustomEventData : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Analytics_CustomEventData(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Analytics_CustomEventData(nint ptr) => new Ptr_UnityEngine_Analytics_CustomEventData(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Analytics_CustomEventData ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Analytics_CustomEventData ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
