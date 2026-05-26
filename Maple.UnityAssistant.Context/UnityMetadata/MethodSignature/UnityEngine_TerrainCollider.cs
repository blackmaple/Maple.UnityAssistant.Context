namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_TerrainCollider
{
    public const string MONO_GetTerrainData = "UnityEngine.TerrainCollider::get_terrainData";
    public const string MONO_RaycastInjected = "UnityEngine.TerrainCollider::Raycast_Injected";
    public const string MONO_SetTerrainData = "UnityEngine.TerrainCollider::set_terrainData";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_TerrainCollider : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_TerrainCollider(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_TerrainCollider(nint ptr) => new Ptr_UnityEngine_TerrainCollider(ptr);
        public static implicit operator nint(Ptr_UnityEngine_TerrainCollider ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_TerrainCollider ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
