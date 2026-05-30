using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public partial class UnityEngine_Sprite
{
    public const string MONO_CreateSpriteInjected = "UnityEngine.Sprite::CreateSprite_Injected";
    public const string MONO_CreateSpriteWithoutTextureScriptingInjected = "UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected";
    public const string MONO_GetAssociatedAlphaSplitTexture = "UnityEngine.Sprite::get_associatedAlphaSplitTexture";
    public const string MONO_GetBorderInjected = "UnityEngine.Sprite::get_border_Injected";
    public const string MONO_GetBoundsInjected = "UnityEngine.Sprite::get_bounds_Injected";
    public const string MONO_GetIsUsingPlaceholder = "UnityEngine.Sprite::get_isUsingPlaceholder";
    public const string MONO_GetPivotInjected = "UnityEngine.Sprite::get_pivot_Injected";
    public const string MONO_GetPixelsPerUnit = "UnityEngine.Sprite::get_pixelsPerUnit";
    public const string MONO_GetRectInjected = "UnityEngine.Sprite::get_rect_Injected";
    public const string MONO_GetSpriteAtlasTextureScale = "UnityEngine.Sprite::get_spriteAtlasTextureScale";
    public const string MONO_GetTexture = "UnityEngine.Sprite::get_texture";
    public const string MONO_GetTriangles = "UnityEngine.Sprite::get_triangles";
    public const string MONO_GetUv = "UnityEngine.Sprite::get_uv";
    public const string MONO_GetVertices = "UnityEngine.Sprite::get_vertices";
    public const string MONO_GetInnerUvsInjected = "UnityEngine.Sprite::GetInnerUVs_Injected";
    public const string MONO_GetOuterUvsInjected = "UnityEngine.Sprite::GetOuterUVs_Injected";
    public const string MONO_GetPacked = "UnityEngine.Sprite::GetPacked";
    public const string MONO_GetPackingMode = "UnityEngine.Sprite::GetPackingMode";
    public const string MONO_GetPackingRotation = "UnityEngine.Sprite::GetPackingRotation";
    public const string MONO_GetPaddingInjected = "UnityEngine.Sprite::GetPadding_Injected";
    public const string MONO_GetPhysicsShapeCount = "UnityEngine.Sprite::GetPhysicsShapeCount";
    public const string MONO_GetPhysicsShapeImpl = "UnityEngine.Sprite::GetPhysicsShapeImpl";
    public const string MONO_GetSecondaryTexture = "UnityEngine.Sprite::GetSecondaryTexture";
    public const string MONO_GetTextureRectInjected = "UnityEngine.Sprite::GetTextureRect_Injected";
    public const string MONO_GetTextureRectOffsetInjected = "UnityEngine.Sprite::GetTextureRectOffset_Injected";
    public const string MONO_InternalGetPhysicsShapePointCount = "UnityEngine.Sprite::Internal_GetPhysicsShapePointCount";
    public const string MONO_OverrideGeometry = "UnityEngine.Sprite::OverrideGeometry";
    public const string MONO_OverridePhysicsShape = "UnityEngine.Sprite::OverridePhysicsShape";
    public const string MONO_OverridePhysicsShapeCount = "UnityEngine.Sprite::OverridePhysicsShapeCount";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Sprite : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Sprite(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Sprite(nint ptr) => new Ptr_UnityEngine_Sprite(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Sprite ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Sprite ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CreateSprite_Injected = "UnityEngine.Sprite::CreateSprite_Injected(UnityEngine.Texture2D,UnityEngine.Rect&,UnityEngine.Vector2&,System.Single,System.UInt32,UnityEngine.SpriteMeshType,UnityEngine.Vector4&,System.Boolean)";
    public const string IL2CPP_CreateSpriteWithoutTextureScripting_Injected = "UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect&,UnityEngine.Vector2&,System.Single,UnityEngine.Texture2D)";
    public const string IL2CPP_get_associatedAlphaSplitTexture = "UnityEngine.Sprite::get_associatedAlphaSplitTexture()";
    public const string IL2CPP_get_border_Injected = "UnityEngine.Sprite::get_border_Injected(UnityEngine.Vector4&)";
    public const string IL2CPP_get_bounds_Injected = "UnityEngine.Sprite::get_bounds_Injected(UnityEngine.Bounds&)";
    public const string IL2CPP_get_pivot_Injected = "UnityEngine.Sprite::get_pivot_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_get_pixelsPerUnit = "UnityEngine.Sprite::get_pixelsPerUnit()";
    public const string IL2CPP_get_rect_Injected = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_get_spriteAtlasTextureScale = "UnityEngine.Sprite::get_spriteAtlasTextureScale()";
    public const string IL2CPP_get_texture = "UnityEngine.Sprite::get_texture()";
    public const string IL2CPP_get_triangles = "UnityEngine.Sprite::get_triangles()";
    public const string IL2CPP_get_uv = "UnityEngine.Sprite::get_uv()";
    public const string IL2CPP_get_vertices = "UnityEngine.Sprite::get_vertices()";
    public const string IL2CPP_GetInnerUVs_Injected = "UnityEngine.Sprite::GetInnerUVs_Injected(UnityEngine.Vector4&)";
    public const string IL2CPP_GetOuterUVs_Injected = "UnityEngine.Sprite::GetOuterUVs_Injected(UnityEngine.Vector4&)";
    public const string IL2CPP_GetPacked = "UnityEngine.Sprite::GetPacked()";
    public const string IL2CPP_GetPackingMode = "UnityEngine.Sprite::GetPackingMode()";
    public const string IL2CPP_GetPackingRotation = "UnityEngine.Sprite::GetPackingRotation()";
    public const string IL2CPP_GetPadding_Injected = "UnityEngine.Sprite::GetPadding_Injected(UnityEngine.Vector4&)";
    public const string IL2CPP_GetPhysicsShapeCount = "UnityEngine.Sprite::GetPhysicsShapeCount()";
    public const string IL2CPP_GetPhysicsShapeImpl = "UnityEngine.Sprite::GetPhysicsShapeImpl(UnityEngine.Sprite,System.Int32,System.Collections.Generic.List`1<UnityEngine.Vector2>)";
    public const string IL2CPP_GetSecondaryTexture = "UnityEngine.Sprite::GetSecondaryTexture(System.Int32)";
    public const string IL2CPP_GetTextureRect_Injected = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)";
    public const string IL2CPP_GetTextureRectOffset_Injected = "UnityEngine.Sprite::GetTextureRectOffset_Injected(UnityEngine.Vector2&)";
    public const string IL2CPP_Internal_GetPhysicsShapePointCount = "UnityEngine.Sprite::Internal_GetPhysicsShapePointCount(System.Int32)";
    public const string IL2CPP_OverrideGeometry = "UnityEngine.Sprite::OverrideGeometry(UnityEngine.Vector2[],System.UInt16[])";
    public const string IL2CPP_OverridePhysicsShape = "UnityEngine.Sprite::OverridePhysicsShape(UnityEngine.Sprite,UnityEngine.Vector2[],System.Int32)";
    public const string IL2CPP_OverridePhysicsShapeCount = "UnityEngine.Sprite::OverridePhysicsShapeCount(UnityEngine.Sprite,System.Int32)";
}

partial class UnityEngine_Sprite
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_TEXTURE(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[SuppressGCTransition, Cdecl]<nint,  UnityEngine_Texture2D.Ptr_UnityEngine_Texture2D> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, UnityEngine_Texture2D.Ptr_UnityEngine_Texture2D>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public UnityEngine_Texture2D.Ptr_UnityEngine_Texture2D Delegate(nint @this) => this.m_Pointer(@this);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_TEXTURE func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_TEXTURE(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_TEXTURE func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }
    internal static PTR_FUNC_GET_TEXTURE s_PTR_FUNC_GET_TEXTURE;

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_TEXTURE_RECT_INJECTED(nint ptr) : IPtrMetadata, IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, MapleOut<Ref_Rect>, void> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, MapleOut<Ref_Rect>, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(nint @this, MapleOut<Ref_Rect> rect) => this.m_Pointer(@this, rect);
        public nint PtrMethod => new(m_Pointer);

        public nint Ptr => new(m_Pointer);

        public static implicit operator bool(PTR_FUNC_GET_TEXTURE_RECT_INJECTED func) => func.Ptr != nint.Zero;
        public static implicit operator PTR_FUNC_GET_TEXTURE_RECT_INJECTED(nint func) => new(func);
        public static implicit operator nint(PTR_FUNC_GET_TEXTURE_RECT_INJECTED func) => func.Ptr;
        public override string ToString() => Ptr.ToString("X8");
    }
    internal static PTR_FUNC_GET_TEXTURE_RECT_INJECTED s_PTR_FUNC_GET_TEXTURE_RECT_INJECTED;

    partial struct Ptr_UnityEngine_Sprite
    {
        public UnityEngine_Texture2D.Ptr_UnityEngine_Texture2D GetTexture() => s_PTR_FUNC_GET_TEXTURE.Delegate(this);
        private void GetTextureRect_Injected(MapleOut<Ref_Rect> rect) => s_PTR_FUNC_GET_TEXTURE_RECT_INJECTED.Delegate(this, rect);
        public void GetTextureRect_Injected(out Ref_Rect rect) => GetTextureRect_Injected(MapleOut<Ref_Rect>.FromOut(out rect));

    }

    public static void Initialize(UnityMetadataSearchService metadataSearchService)
    {
        s_PTR_FUNC_GET_TEXTURE = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE));
        s_PTR_FUNC_GET_TEXTURE_RECT_INJECTED = metadataSearchService.GetMethodPointer(nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE_RECT_INJECTED));
    }
}