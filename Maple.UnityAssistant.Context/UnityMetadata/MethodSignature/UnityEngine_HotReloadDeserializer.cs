namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_HotReloadDeserializer
{
    public const string MONO_CreateEmptyAsset = "UnityEngine.HotReloadDeserializer::CreateEmptyAsset";
    public const string MONO_DeserializeAsset = "UnityEngine.HotReloadDeserializer::DeserializeAsset";
    public const string MONO_FinalizeAssetCreation = "UnityEngine.HotReloadDeserializer::FinalizeAssetCreation";
    public const string MONO_FinishHotReload = "UnityEngine.HotReloadDeserializer::FinishHotReload";
    public const string MONO_GetDependencies = "UnityEngine.HotReloadDeserializer::GetDependencies";
    public const string MONO_GetNullDependencies = "UnityEngine.HotReloadDeserializer::GetNullDependencies";
    public const string MONO_PrepareHotReload = "UnityEngine.HotReloadDeserializer::PrepareHotReload";
    public const string MONO_RemapInstanceIds = "UnityEngine.HotReloadDeserializer::RemapInstanceIds";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_HotReloadDeserializer : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_HotReloadDeserializer(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_HotReloadDeserializer(nint ptr) => new Ptr_UnityEngine_HotReloadDeserializer(ptr);
        public static implicit operator nint(Ptr_UnityEngine_HotReloadDeserializer ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_HotReloadDeserializer ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
