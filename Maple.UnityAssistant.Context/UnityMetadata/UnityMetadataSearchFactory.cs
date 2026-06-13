using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;
using Microsoft.Extensions.Logging;

namespace Maple.UnityAssistant.Context.UnityMetadata
{
    public static class UnityMetadataSearchFactory
    {
        static Dictionary<string, List<string>> CreateMethodSignatureCache_MONO()
        {
            return new Dictionary<string, List<string>>()
            {
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS)] = [UnityEngine_Input.MONO_GetAxis],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS_RAW)] = [UnityEngine_Input.MONO_GetAxisRaw],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_INT)] = [UnityEngine_Input.MONO_GetKeyDownInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_STRING)] = [UnityEngine_Input.MONO_GetKeyDownString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_INT)] = [UnityEngine_Input.MONO_GetKeyInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_STRING)] = [UnityEngine_Input.MONO_GetKeyString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_INT)] = [UnityEngine_Input.MONO_GetKeyUpInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_STRING)] = [UnityEngine_Input.MONO_GetKeyUpString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON)] = [UnityEngine_Input.MONO_GetMouseButton],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_DOWN)] = [UnityEngine_Input.MONO_GetMouseButtonDown],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_UP)] = [UnityEngine_Input.MONO_GetMouseButtonUp],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_POSITION_INJECTED)] = [UnityEngine_Input.MONO_GetMousePositionInjected],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED)] = [UnityEngine_Input.MONO_GetMouseScrollDeltaInjected],
                [nameof(UnityEngine_Input.PTR_FUNC_SET_IME_COMPOSITION_MODE)] = [UnityEngine_Input.MONO_SetImeCompositionMode],

                [nameof(UnityEngine_Texture.PTR_FUNC_GET_HEIGHT)] = [UnityEngine_Texture.MONO_GetScriptHeight],
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_WIDTH)] = [UnityEngine_Texture.MONO_GetScriptWidth],
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_NATIVE_TEXTURE_PTR)] = [UnityEngine_Texture.MONO_GetNativeTexturePtr],

                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE)] = [UnityEngine_Sprite.MONO_GetTexture],
                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE_RECT_INJECTED)] = [UnityEngine_Sprite.MONO_GetTextureRectInjected],

            };
        }
        static Dictionary<string, List<string>> CreateMethodSignatureCache_IL2CPP()
        {
            return new Dictionary<string, List<string>>()
            {
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS)] = [UnityEngine_Input.IL2CPP_GetAxis, UnityEngine_Input.IL2CPP_GetAxis1],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_AXIS_RAW)] = [UnityEngine_Input.IL2CPP_GetAxisRaw, UnityEngine_Input.IL2CPP_GetAxisRaw1],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_INT)] = [UnityEngine_Input.IL2CPP_GetKeyDownInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_DOWN_STRING)] = [UnityEngine_Input.IL2CPP_GetKeyDownString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_INT)] = [UnityEngine_Input.IL2CPP_GetKeyInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_STRING)] = [UnityEngine_Input.IL2CPP_GetKeyString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_INT)] = [UnityEngine_Input.IL2CPP_GetKeyUpInt],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_KEY_UP_STRING)] = [UnityEngine_Input.IL2CPP_GetKeyUpString],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON)] = [UnityEngine_Input.IL2CPP_GetMouseButton],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_DOWN)] = [UnityEngine_Input.IL2CPP_GetMouseButtonDown],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_BUTTON_UP)] = [UnityEngine_Input.IL2CPP_GetMouseButtonUp],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_POSITION_INJECTED)] = [UnityEngine_Input.IL2CPP_get_mousePosition_Injected],
                [nameof(UnityEngine_Input.PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED)] = [UnityEngine_Input.IL2CPP_get_mouseScrollDelta_Injected],
                [nameof(UnityEngine_Input.PTR_FUNC_SET_IME_COMPOSITION_MODE)] = [UnityEngine_Input.IL2CPP_set_imeCompositionMode],

                [nameof(UnityEngine_Texture.PTR_FUNC_GET_HEIGHT)] = [UnityEngine_Texture.IL2CPP_GetDataHeight],
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_WIDTH)] = [UnityEngine_Texture.IL2CPP_GetDataWidth],
                [nameof(UnityEngine_Texture.PTR_FUNC_GET_NATIVE_TEXTURE_PTR)] = [UnityEngine_Texture.IL2CPP_GetNativeTexturePtr],

                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE)] = [UnityEngine_Sprite.IL2CPP_get_texture],
                [nameof(UnityEngine_Sprite.PTR_FUNC_GET_TEXTURE_RECT_INJECTED)] = [UnityEngine_Sprite.IL2CPP_GetTextureRect_Injected],

            };
        }

        public static Dictionary<EnumMonoRuntimeType, Dictionary<string, List<string>>> MethodSignatureCache { get; }
            = new Dictionary<EnumMonoRuntimeType, Dictionary<string, List<string>>>()
            {
                [EnumMonoRuntimeType.MONO] = CreateMethodSignatureCache_MONO(),
                [EnumMonoRuntimeType.IL2CPP] = CreateMethodSignatureCache_IL2CPP(),
            };

        public static bool TrySetMethodSignatureCache(EnumMonoRuntimeType runtimeType, string code, params ReadOnlySpan<string> methodSignature)
        {
            if (MethodSignatureCache.TryGetValue(runtimeType, out var methodSignatureCache))
            {
                if (!methodSignatureCache.TryGetValue(code, out var methodSignatures))
                {
                    methodSignatures = [];
                    methodSignatureCache.Add(code, methodSignatures);
                }
                methodSignatures.AddRange(methodSignature);
                return true;
            }
            return false;
        }
        public static bool TrySetMethodSignatureCache_MONO(string code, string methodSignature)
            => TrySetMethodSignatureCache(EnumMonoRuntimeType.MONO, code, methodSignature);
        public static bool TrySetMethodSignatureCache_IL2CPP(string code, string methodSignature)
            => TrySetMethodSignatureCache(EnumMonoRuntimeType.IL2CPP, code, methodSignature);

        public static UnityMetadataSearchService Create(ILogger logger, MonoRuntimeContext context, MonoInternalCallService internalCallService)
        {
            if (!MethodSignatureCache.TryGetValue(context.RuntimeType, out var methodSignature))
            {
                return GameException.Throw<UnityMetadataSearchService>($"NOTFOUND RUNTIME TYPE: {context.RuntimeType}");
            }
            return context.RuntimeType switch
            {
                EnumMonoRuntimeType.IL2CPP => new UnityMetadataSearchService_IL2CPP(logger, context, internalCallService, methodSignature),
                EnumMonoRuntimeType.MONO => new UnityMetadataSearchService_MONO(logger, context, internalCallService, methodSignature),
                _ => GameException.Throw<UnityMetadataSearchService>($"UNSUPPORTED RUNTIME TYPE: {context.RuntimeType}")
            };
        }
    }


}