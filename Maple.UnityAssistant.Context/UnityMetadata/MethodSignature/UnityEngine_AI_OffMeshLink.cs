namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_AI_OffMeshLink
{
    public const string MONO_GetActivated = "UnityEngine.AI.OffMeshLink::get_activated";
    public const string MONO_GetArea = "UnityEngine.AI.OffMeshLink::get_area";
    public const string MONO_GetAutoUpdatePositions = "UnityEngine.AI.OffMeshLink::get_autoUpdatePositions";
    public const string MONO_GetBiDirectional = "UnityEngine.AI.OffMeshLink::get_biDirectional";
    public const string MONO_GetCostOverride = "UnityEngine.AI.OffMeshLink::get_costOverride";
    public const string MONO_GetEndTransform = "UnityEngine.AI.OffMeshLink::get_endTransform";
    public const string MONO_GetOccupied = "UnityEngine.AI.OffMeshLink::get_occupied";
    public const string MONO_GetStartTransform = "UnityEngine.AI.OffMeshLink::get_startTransform";
    public const string MONO_SetActivated = "UnityEngine.AI.OffMeshLink::set_activated";
    public const string MONO_SetArea = "UnityEngine.AI.OffMeshLink::set_area";
    public const string MONO_SetAutoUpdatePositions = "UnityEngine.AI.OffMeshLink::set_autoUpdatePositions";
    public const string MONO_SetBiDirectional = "UnityEngine.AI.OffMeshLink::set_biDirectional";
    public const string MONO_SetCostOverride = "UnityEngine.AI.OffMeshLink::set_costOverride";
    public const string MONO_SetEndTransform = "UnityEngine.AI.OffMeshLink::set_endTransform";
    public const string MONO_SetStartTransform = "UnityEngine.AI.OffMeshLink::set_startTransform";
    public const string MONO_UpdatePositions = "UnityEngine.AI.OffMeshLink::UpdatePositions";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_AI_OffMeshLink : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_AI_OffMeshLink(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_AI_OffMeshLink(nint ptr) => new Ptr_UnityEngine_AI_OffMeshLink(ptr);
        public static implicit operator nint(Ptr_UnityEngine_AI_OffMeshLink ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_AI_OffMeshLink ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
