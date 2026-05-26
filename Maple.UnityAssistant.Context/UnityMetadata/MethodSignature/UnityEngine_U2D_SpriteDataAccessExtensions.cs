namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_U2D_SpriteDataAccessExtensions
{
    public const string MONO_GetBindPoseInfoInjected = "UnityEngine.U2D.SpriteDataAccessExtensions::GetBindPoseInfo_Injected";
    public const string MONO_GetBoneInfo = "UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo";
    public const string MONO_GetChannelInfoInjected = "UnityEngine.U2D.SpriteDataAccessExtensions::GetChannelInfo_Injected";
    public const string MONO_GetIndicesInfoInjected = "UnityEngine.U2D.SpriteDataAccessExtensions::GetIndicesInfo_Injected";
    public const string MONO_GetPrimaryVertexStreamSize = "UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize";
    public const string MONO_GetVertexCount = "UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount";
    public const string MONO_HasVertexAttribute = "UnityEngine.U2D.SpriteDataAccessExtensions::HasVertexAttribute";
    public const string MONO_SetBindPoseData = "UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData";
    public const string MONO_SetBoneData = "UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData";
    public const string MONO_SetChannelData = "UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData";
    public const string MONO_SetIndicesData = "UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData";
    public const string MONO_SetVertexCount = "UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_U2D_SpriteDataAccessExtensions : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_U2D_SpriteDataAccessExtensions(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_U2D_SpriteDataAccessExtensions(nint ptr) => new Ptr_UnityEngine_U2D_SpriteDataAccessExtensions(ptr);
        public static implicit operator nint(Ptr_UnityEngine_U2D_SpriteDataAccessExtensions ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_U2D_SpriteDataAccessExtensions ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_GetChannelInfo_Injected = "UnityEngine.U2D.SpriteDataAccessExtensions::GetChannelInfo_Injected(UnityEngine.Sprite,UnityEngine.Rendering.VertexAttribute,UnityEngine.U2D.SpriteChannelInfo&)";
    public const string IL2CPP_GetIndicesInfo_Injected = "UnityEngine.U2D.SpriteDataAccessExtensions::GetIndicesInfo_Injected(UnityEngine.Sprite,UnityEngine.U2D.SpriteChannelInfo&)";
}

