namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Analytics_ContinuousEvent
{
    public const string MONO_InternalConfigureCustomEvent = "UnityEngine.Analytics.ContinuousEvent::InternalConfigureCustomEvent";
    public const string MONO_InternalConfigureEvent = "UnityEngine.Analytics.ContinuousEvent::InternalConfigureEvent";
    public const string MONO_InternalRegisterCollector = "UnityEngine.Analytics.ContinuousEvent::InternalRegisterCollector";
    public const string MONO_InternalSetCustomEventHistogramThresholds = "UnityEngine.Analytics.ContinuousEvent::InternalSetCustomEventHistogramThresholds";
    public const string MONO_InternalSetEventHistogramThresholds = "UnityEngine.Analytics.ContinuousEvent::InternalSetEventHistogramThresholds";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Analytics_ContinuousEvent : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Analytics_ContinuousEvent(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Analytics_ContinuousEvent(nint ptr) => new Ptr_UnityEngine_Analytics_ContinuousEvent(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Analytics_ContinuousEvent ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Analytics_ContinuousEvent ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
