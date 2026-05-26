namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_LightProbes
{
    public const string MONO_AreLightProbesAllowed = "UnityEngine.LightProbes::AreLightProbesAllowed";
    public const string MONO_CalculateInterpolatedLightAndOcclusionProbesInternal = "UnityEngine.LightProbes::CalculateInterpolatedLightAndOcclusionProbes_Internal";
    public const string MONO_GetBakedProbes = "UnityEngine.LightProbes::get_bakedProbes";
    public const string MONO_GetCellCount = "UnityEngine.LightProbes::get_cellCount";
    public const string MONO_GetCount = "UnityEngine.LightProbes::get_count";
    public const string MONO_GetPositions = "UnityEngine.LightProbes::get_positions";
    public const string MONO_GetCount_2 = "UnityEngine.LightProbes::GetCount";
    public const string MONO_GetInterpolatedProbeInjected = "UnityEngine.LightProbes::GetInterpolatedProbe_Injected";
    public const string MONO_SetBakedProbes = "UnityEngine.LightProbes::set_bakedProbes";
    public const string MONO_Tetrahedralize = "UnityEngine.LightProbes::Tetrahedralize";
    public const string MONO_TetrahedralizeAsync = "UnityEngine.LightProbes::TetrahedralizeAsync";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_LightProbes : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_LightProbes(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_LightProbes(nint ptr) => new Ptr_UnityEngine_LightProbes(ptr);
        public static implicit operator nint(Ptr_UnityEngine_LightProbes ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_LightProbes ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
