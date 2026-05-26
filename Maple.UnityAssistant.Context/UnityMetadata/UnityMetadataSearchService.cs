using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.MonoGameAssistant.MetadataUnity.UnityMetadata;
using Maple.UnityAssistant.Context.UnityHook.Hook_Input;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.MonoGameAssistant.MetadataUnity.Sprite;

namespace Maple.UnityAssistant.Context.UnityMetadata
{


    public class UnityMetadataSearchService
    {
        public virtual Dictionary<string, string> MethodSignatureCache { get; } = new Dictionary<string, string>
        {
            [nameof(GetAxisHookItem)] = "UnityEngine.Input::GetAxis",
            [nameof(GetAxisRawHookItem)] = "UnityEngine.Input::GetAxisRaw",
            [nameof(GetKeyDownIntHookItem)] = "UnityEngine.Input::GetKeyDownInt",
            [nameof(GetKeyDownStringHookItem)] = "UnityEngine.Input::GetKeyDownString",

            [nameof(GetKeyIntHookItem)] = "UnityEngine.Input::GetKeyInt",
            [nameof(GetKeyStringHookItem)] = "UnityEngine.Input::GetKeyString",
            [nameof(GetKeyUpIntHookItem)] = "UnityEngine.Input::GetKeyUpInt",
            [nameof(GetKeyUpStringHookItem)] = "UnityEngine.Input::GetKeyUpString",
            [nameof(GetMouseButtonDownHookItem)] = "UnityEngine.Input::GetMouseButtonDown",
            [nameof(GetMouseButtonHookItem)] = "UnityEngine.Input::GetMouseButton",
            [nameof(GetMouseButtonUpHookItem)] = "UnityEngine.Input::GetMouseButtonUp",
            [nameof(GetMousePositionInjectedHookItem)] = "UnityEngine.Input::get_mousePosition_Injected",
            [nameof(GetMouseScrollDeltaInjectedHookItem)] = "UnityEngine.Input::get_mouseScrollDelta_Injected",

            [nameof(PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736)] = "UnityEngine.Input::set_imeCompositionMode",


            [nameof(PTR_FUNC_GET_TEXTURE_9E369564B1447B9B)] = "UnityEngine.Sprite::get_texture",
            [nameof(PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F)] = "UnityEngine.Sprite::GetTextureRect_Injected",

            [nameof(PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0)] = "UnityEngine.Texture::GetNativeTexturePtr",
            [nameof(PTR_FUNC_GET_HEIGHT_CCDEA63084F82309)] = "UnityEngine.Texture::GetScriptHeight",
            [nameof(PTR_FUNC_GET_WIDTH_BF4A4D382B19EF20)] = "UnityEngine.Texture::GetScriptWidth",

        };

        protected PTR_FUNC_GET_TEXTURE_9E369564B1447B9B PTR_FUNC_GET_TEXTURE;
        protected PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F PTR_FUNC_GET_TEXTURE_RECT_INJECTED;

        protected PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0 PTR_FUNC_GET_NATIVE_TEXTURE_PTR;
        protected PTR_FUNC_GET_HEIGHT_CCDEA63084F82309 PTR_FUNC_GET_HEIGHT;
        protected PTR_FUNC_GET_WIDTH_BF4A4D382B19EF20 PTR_FUNC_GET_WIDTH;

        protected PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736 PTR_FUNC_SET_IME_COMPOSITION_MODE;

        public UnityMetadataSearchService()
        {
            this.PTR_FUNC_GET_TEXTURE = GetMethodPointer(nameof(PTR_FUNC_GET_TEXTURE_9E369564B1447B9B));
            this.PTR_FUNC_GET_TEXTURE_RECT_INJECTED = GetMethodPointer(nameof(PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F));
            this.PTR_FUNC_GET_NATIVE_TEXTURE_PTR = GetMethodPointer(nameof(PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0));
            this.PTR_FUNC_GET_HEIGHT = GetMethodPointer(nameof(PTR_FUNC_GET_HEIGHT_CCDEA63084F82309));
            this.PTR_FUNC_GET_WIDTH = GetMethodPointer(nameof(PTR_FUNC_GET_WIDTH_BF4A4D382B19EF20));
            this.PTR_FUNC_SET_IME_COMPOSITION_MODE = GetMethodPointer(nameof(PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736));
        }

        public void SetImeCompositionMode()
        {
            PTR_FUNC_SET_IME_COMPOSITION_MODE.Delegate(IMECompositionMode.On);
        }

        public bool TryGetTextureInfo(nint ptr_Sprite, out nint native_ptr, out float u0, out float v0, out float u1, out float v1)
        {
            Unsafe.SkipInit(out native_ptr);
            Unsafe.SkipInit(out u0);
            Unsafe.SkipInit(out v0);
            Unsafe.SkipInit(out u1);
            Unsafe.SkipInit(out v1);
            if (ptr_Sprite == nint.Zero)
            {
                return false;
            }
            Sprite.Ptr_Sprite pSprite = new(ptr_Sprite);
            var pTexture2D = PTR_FUNC_GET_TEXTURE.Delegate(pSprite);
            if (pTexture2D.IsNull())
            {
                return false;
            }
            native_ptr = PTR_FUNC_GET_NATIVE_TEXTURE_PTR.Delegate(pTexture2D);
            if (native_ptr == nint.Zero)
            {
                return false;
            }
            PTR_FUNC_GET_TEXTURE_RECT_INJECTED.Delegate(pSprite, MapleOut<Rect.Ref_Rect>.FromOut(out var ref_Rect));
            var w = PTR_FUNC_GET_WIDTH.Delegate(pTexture2D);
            var h = PTR_FUNC_GET_HEIGHT.Delegate(pTexture2D);
            u0 = ref_Rect.m_XMin / w;
            v0 = ref_Rect.m_YMin / h;
            u1 = (ref_Rect.m_XMin + ref_Rect.m_Width) / w;
            v1 = (ref_Rect.m_YMin + ref_Rect.m_Height) / h;
            return true;
        }

        public virtual nint GetMethodPointer(string code)
        {
            return nint.Zero;
        }
    }

    public sealed class UnityMetadataSearcher_MONO(MonoInternalCallService internalCallService)
        : UnityMetadataSearchService
    {
        private MonoInternalCallService InternalCallService { get; } = internalCallService;

        public override nint GetMethodPointer(string code)
        {
            if (MethodSignatureCache.TryGetValue(code, out var methodSignature)
                && this.InternalCallService.TryGetInternalCall(methodSignature, out var pointer))
            {
                return pointer;
            }
            return default;
        }
    }

    public sealed class UnityMetadataSearcher_IL2CPP(MonoRuntimeContext context)
        : UnityMetadataSearchService
    {
        private MonoRuntimeContext Context { get; } = context;

        public override Dictionary<string, string> MethodSignatureCache { get; } = new Dictionary<string, string>()
        {
            [nameof(GetAxisHookItem)] = "UnityEngine.Input::GetAxis(System.String)",
            [nameof(GetAxisRawHookItem)] = "UnityEngine.Input::GetAxisRaw(System.String)",
            [nameof(GetKeyDownIntHookItem)] = "UnityEngine.Input::GetKeyDownInt(UnityEngine.KeyCode)",
            [nameof(GetKeyDownStringHookItem)] = "UnityEngine.Input::GetKeyDownString(System.String)",
            [nameof(GetKeyIntHookItem)] = "UnityEngine.Input::GetKeyInt(UnityEngine.KeyCode)",
            [nameof(GetKeyStringHookItem)] = "UnityEngine.Input::GetKeyString(System.String)",
            [nameof(GetKeyUpIntHookItem)] = "UnityEngine.Input::GetKeyUpInt(UnityEngine.KeyCode)",
            [nameof(GetKeyUpStringHookItem)] = "UnityEngine.Input::GetKeyUpString(System.String)",
            [nameof(GetMouseButtonDownHookItem)] = "UnityEngine.Input::GetMouseButtonDown(System.Int32)",
            [nameof(GetMouseButtonHookItem)] = "UnityEngine.Input::GetMouseButton(System.Int32)",
            [nameof(GetMouseButtonUpHookItem)] = "UnityEngine.Input::GetMouseButtonUp(System.Int32)",
            [nameof(GetMousePositionInjectedHookItem)] = "UnityEngine.Input::get_mousePosition_Injected(UnityEngine.Vector3&)",
            [nameof(GetMouseScrollDeltaInjectedHookItem)] = "UnityEngine.Input::get_mouseScrollDelta_Injected(UnityEngine.Vector2&)",

            [nameof(PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736)] = "UnityEngine.Input::set_imeCompositionMode(UnityEngine.IMECompositionMode)",


            [nameof(PTR_FUNC_GET_TEXTURE_9E369564B1447B9B)] = "UnityEngine.Sprite::get_texture()",
            [nameof(PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F)] = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)",

            [nameof(PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0)] = "UnityEngine.Texture::GetNativeTexturePtr()",
            [nameof(PTR_FUNC_GET_HEIGHT_CCDEA63084F82309)] = "UnityEngine.Texture::GetDataHeight()",
            [nameof(PTR_FUNC_GET_WIDTH_BF4A4D382B19EF20)] = "UnityEngine.Texture::GetDataWidth()",

        };

        public override nint GetMethodPointer(string code)
        {
            if (MethodSignatureCache.TryGetValue(code, out var methodSignature))
            {
                return this.Context.GetInternalCall(methodSignature);
            }
            return default;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe  readonly partial struct Ptr_XXX(nint ptr) : IPtrMetadata
    {
        [MarshalAs(UnmanagedType.SysInt)]
        private readonly nint m_Pointer = ptr;

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_XXX(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_XXX ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_XXX ptr) => ptr.m_Pointer != nint.Zero;
        public override string ToString()
        {
            return m_Pointer.ToString("X8");
        }

    }
}