namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LODGroup
{
    public const string MONO_ForceLod = "UnityEngine.LODGroup::ForceLOD";
    public const string MONO_GetAnimateCrossFading = "UnityEngine.LODGroup::get_animateCrossFading";
    public const string MONO_GetCrossFadeAnimationDuration = "UnityEngine.LODGroup::get_crossFadeAnimationDuration";
    public const string MONO_GetEnabled = "UnityEngine.LODGroup::get_enabled";
    public const string MONO_GetFadeMode = "UnityEngine.LODGroup::get_fadeMode";
    public const string MONO_GetLocalReferencePointInjected = "UnityEngine.LODGroup::get_localReferencePoint_Injected";
    public const string MONO_GetLodCount = "UnityEngine.LODGroup::get_lodCount";
    public const string MONO_GetSize = "UnityEngine.LODGroup::get_size";
    public const string MONO_GetWorldReferencePointInjected = "UnityEngine.LODGroup::get_worldReferencePoint_Injected";
    public const string MONO_GetLods = "UnityEngine.LODGroup::GetLODs";
    public const string MONO_RecalculateBounds = "UnityEngine.LODGroup::RecalculateBounds";
    public const string MONO_SetAnimateCrossFading = "UnityEngine.LODGroup::set_animateCrossFading";
    public const string MONO_SetCrossFadeAnimationDuration = "UnityEngine.LODGroup::set_crossFadeAnimationDuration";
    public const string MONO_SetEnabled = "UnityEngine.LODGroup::set_enabled";
    public const string MONO_SetFadeMode = "UnityEngine.LODGroup::set_fadeMode";
    public const string MONO_SetLocalReferencePointInjected = "UnityEngine.LODGroup::set_localReferencePoint_Injected";
    public const string MONO_SetSize = "UnityEngine.LODGroup::set_size";
    public const string MONO_SetLods = "UnityEngine.LODGroup::SetLODs";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LODGroup : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LODGroup(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LODGroup(nint ptr) => new Ptr_UnityEngine_LODGroup(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LODGroup ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LODGroup ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
