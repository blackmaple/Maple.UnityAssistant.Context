using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;
using Maple.UnityAssistant.Resource;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.UnityAssistant.Context.UnityMetadata
{

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
            if (ptr_Sprite.IsNull())
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