using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;
using Maple.UnityAssistant.Resource;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.UnityAssistant.Context.UnityMetadata
{
    public static class UnityMetadataSearchFactory
    {
        static Dictionary<string, string> CreateMethodSignatureCache_MONO()
        {
            return new Dictionary<string, string>()
            {
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS)] = UnityEngine_Input.MONO_GetAxis,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS_RAW)] = UnityEngine_Input.MONO_GetAxisRaw,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_INT)] = UnityEngine_Input.MONO_GetKeyDownInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_STRING)] = UnityEngine_Input.MONO_GetKeyDownString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_INT)] = UnityEngine_Input.MONO_GetKeyInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_STRING)] = UnityEngine_Input.MONO_GetKeyString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_INT)] = UnityEngine_Input.MONO_GetKeyUpInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_STRING)] = UnityEngine_Input.MONO_GetKeyUpString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON)] = UnityEngine_Input.MONO_GetMouseButton,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_DOWN)] = UnityEngine_Input.MONO_GetMouseButtonDown,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_UP)] = UnityEngine_Input.MONO_GetMouseButtonUp,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_POSITION_INJECTED)] = UnityEngine_Input.MONO_GetMousePositionInjected,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED)] = UnityEngine_Input.MONO_GetMouseScrollDeltaInjected,
                [nameof(UnityEngine_Input.PTR_FUNC_SET_IME_COMPOSITION_MODE)] = UnityEngine_Input.MONO_SetImeCompositionMode,

                [nameof(UnityEngine_Texture.PTR_FUNC_GET_HEIGHT)] = UnityEngine_Texture.MONO_GetScriptHeight,
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_WIDTH)] = UnityEngine_Texture.MONO_GetScriptWidth,

                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE)] = UnityEngine_Sprite.MONO_GetTexture,
                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE_RECT_INJECTED)] = UnityEngine_Sprite.MONO_GetTextureRectInjected,

            };
        }
        static Dictionary<string, string> CreateMethodSignatureCache_IL2CPP()
        {
            return new Dictionary<string, string>()
            {
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS)] = UnityEngine_Input.IL2CPP_GetAxis,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS_RAW)] = UnityEngine_Input.IL2CPP_GetAxisRaw,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_INT)] = UnityEngine_Input.IL2CPP_GetKeyDownInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_STRING)] = UnityEngine_Input.IL2CPP_GetKeyDownString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_INT)] = UnityEngine_Input.IL2CPP_GetKeyInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_STRING)] = UnityEngine_Input.IL2CPP_GetKeyString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_INT)] = UnityEngine_Input.IL2CPP_GetKeyUpInt,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_STRING)] = UnityEngine_Input.IL2CPP_GetKeyUpString,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON)] = UnityEngine_Input.IL2CPP_GetMouseButton,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_DOWN)] = UnityEngine_Input.IL2CPP_GetMouseButtonDown,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_UP)] = UnityEngine_Input.IL2CPP_GetMouseButtonUp,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_POSITION_INJECTED)] = UnityEngine_Input.IL2CPP_get_mousePosition_Injected,
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED)] = UnityEngine_Input.IL2CPP_get_mouseScrollDelta_Injected,
                [nameof(UnityEngine_Input.PTR_FUNC_SET_IME_COMPOSITION_MODE)] = UnityEngine_Input.IL2CPP_set_imeCompositionMode,

                [nameof(UnityEngine_Texture.PTR_FUNC_GET_HEIGHT)] = UnityEngine_Texture.IL2CPP_GetDataHeight,
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_WIDTH)] = UnityEngine_Texture.IL2CPP_GetDataWidth,

                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE)] = UnityEngine_Sprite.IL2CPP_get_texture,
                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE_RECT_INJECTED)] = UnityEngine_Sprite.IL2CPP_GetTextureRect_Injected,

            };
        }

        public static Dictionary<EnumMonoRuntimeType, Dictionary<string, string>> MethodSignatureCache { get; }
            = new Dictionary<EnumMonoRuntimeType, Dictionary<string, string>>()
            {
                [EnumMonoRuntimeType.MONO] = CreateMethodSignatureCache_MONO(),
                [EnumMonoRuntimeType.IL2CPP] = CreateMethodSignatureCache_IL2CPP(),
            };

        public static bool TrySetMethodSignatureCache(EnumMonoRuntimeType runtimeType, string code, string methodSignature)
        {
            if (MethodSignatureCache.TryGetValue(runtimeType, out var methodSignatureCache))
            {
                methodSignatureCache[code] = methodSignature;
                return true;
            }
            return false;
        }
        public static bool TrySetMethodSignatureCache_MONO(string code, string methodSignature)
            => TrySetMethodSignatureCache(EnumMonoRuntimeType.MONO, code, methodSignature);
        public static bool TrySetMethodSignatureCache_IL2CPP(string code, string methodSignature)
            => TrySetMethodSignatureCache(EnumMonoRuntimeType.IL2CPP, code, methodSignature);

        public static UnityMetadataSearchService Create(MonoRuntimeContext context, MonoInternalCallService internalCallService)
        {
            if (!MethodSignatureCache.TryGetValue(context.RuntimeType, out var methodSignature))
            {
                return GameException.Throw<UnityMetadataSearchService>($"NOTFOUND RUNTIME TYPE: {context.RuntimeType}");
            }
            return context.RuntimeType switch
            {
                EnumMonoRuntimeType.IL2CPP => new UnityMetadataSearchService_IL2CPP(context, internalCallService, methodSignature),
                EnumMonoRuntimeType.MONO => new UnityMetadataSearchService_MONO(context, internalCallService, methodSignature),
                _ => GameException.Throw<UnityMetadataSearchService>($"UNSUPPORTED RUNTIME TYPE: {context.RuntimeType}")
            };
        }
    }

    public class UnityMetadataSearchService
    {
        public MonoRuntimeContext Context { get; }
        public MonoInternalCallService InternalCallService { get; }
        public Dictionary<string, string> MethodSignatureCache { get; }

        public UnityMetadataSearchService(
        MonoRuntimeContext context,
        MonoInternalCallService internalCallService,
        Dictionary<string, string> methodSignatureCache)
        {
            Context = context;
            InternalCallService = internalCallService;
            MethodSignatureCache = methodSignatureCache;

            UnityEngine_Input.Initialize(this);
            UnityEngine_Texture.Initialize(this);
            UnityEngine_Sprite.Initialize(this);
        }
        public virtual void SetImeCompositionMode()
        {
            UnityEngine_Input.Ptr_UnityEngine_Input.SetImeCompositionMode(IMECompositionMode.On);
        }

        public virtual bool TryGetTextureInfo(UnityEngine_Sprite.Ptr_UnityEngine_Sprite ptr_Sprite, [MaybeNullWhen(false)] out GameImageResource imageRes)
        {
            Unsafe.SkipInit(out imageRes);
            if (ptr_Sprite == nint.Zero)
            {
                return false;
            }

            var pTexture2D = ptr_Sprite.GetTexture();
            if (pTexture2D.IsNull())
            {
                return false;
            }
            var pNative = pTexture2D.GetNativeTexturePtr();
            if (pNative == nint.Zero)
            {
                return false;
            }
            ptr_Sprite.GetTextureRect_Injected(out var ref_Rect);
            var w = pTexture2D.Width;
            var h = pTexture2D.Height;
            var u0 = ref_Rect.m_XMin / w;
            var v0 = (ref_Rect.m_YMin + ref_Rect.m_Height) / h;

            var u1 = (ref_Rect.m_XMin + ref_Rect.m_Width) / w;
            var v1 = ref_Rect.m_YMin / h;
            imageRes = new GameImageResource(pNative, u0, u1, v0, v1);
            return true;
        }

        public virtual nint GetMethodPointer(string code)
        {
            return nint.Zero;
        }
    }

    public sealed class UnityMetadataSearchService_MONO(MonoRuntimeContext context, MonoInternalCallService internalCallService, Dictionary<string, string> methodSignatureCache)
        : UnityMetadataSearchService(context, internalCallService, methodSignatureCache)
    {
        public override nint GetMethodPointer(string code)
        {
            if (this.MethodSignatureCache.TryGetValue(code, out var methodSignature)
                && this.InternalCallService.TryGetInternalCall(methodSignature, out var pointer))
            {
                return pointer;
            }
            return default;
        }
    }

    public sealed class UnityMetadataSearchService_IL2CPP(MonoRuntimeContext context, MonoInternalCallService internalCallService, Dictionary<string, string> methodSignatureCache)
        : UnityMetadataSearchService(context, internalCallService, methodSignatureCache)
    {

        public override nint GetMethodPointer(string code)
        {
            if (this.MethodSignatureCache.TryGetValue(code, out var methodSignature))
            {
                return this.Context.GetInternalCall(methodSignature);
            }
            return default;
        }
    }


}