namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_U2D_SpriteAtlas
{
    public const string MONO_CanBindTo = "UnityEngine.U2D.SpriteAtlas::CanBindTo";
    public const string MONO_GetIsVariant = "UnityEngine.U2D.SpriteAtlas::get_isVariant";
    public const string MONO_GetSpriteCount = "UnityEngine.U2D.SpriteAtlas::get_spriteCount";
    public const string MONO_GetTag = "UnityEngine.U2D.SpriteAtlas::get_tag";
    public const string MONO_GetSprite = "UnityEngine.U2D.SpriteAtlas::GetSprite";
    public const string MONO_GetSpritesScripting = "UnityEngine.U2D.SpriteAtlas::GetSpritesScripting";
    public const string MONO_GetSpritesWithNameScripting = "UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting";
    public const string MONO_IsPlaceholder = "UnityEngine.U2D.SpriteAtlas::IsPlaceholder";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_U2D_SpriteAtlas : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_U2D_SpriteAtlas(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_U2D_SpriteAtlas(nint ptr) => new Ptr_UnityEngine_U2D_SpriteAtlas(ptr);
        public static implicit operator nint(Ptr_UnityEngine_U2D_SpriteAtlas ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_U2D_SpriteAtlas ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CanBindTo = "UnityEngine.U2D.SpriteAtlas::CanBindTo(UnityEngine.Sprite)";
    public const string IL2CPP_get_spriteCount = "UnityEngine.U2D.SpriteAtlas::get_spriteCount()";
    public const string IL2CPP_GetSpritesScripting = "UnityEngine.U2D.SpriteAtlas::GetSpritesScripting(UnityEngine.Sprite[])";
}

