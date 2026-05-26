using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Maple.UnityAssistant.Context.UnityMetadata;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyIntHookItem : HookItem<GetKeyIntHookItem, PTR_FUNC_GET_KEY_INT_364226C2278E06B9, PTR_FUNC_GET_KEY_INT_364226C2278E06B9>, IUnityHookItem<GetKeyIntHookItem>
    {
        public Func<KeyCode, GetKeyIntHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(KeyCode key)
        //{
        //    return this.OriginalMethod.Delegate(key);
        //}

        public static GetKeyIntHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(GetKeyIntHookItem));
            //    metadataContext.Logger.LogInformation("GetKeyIntHookItem code:{code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyIntHookItem>($"NOT FOUND {nameof(GetKeyIntHookItem)}");
            }
            return hookFactory.Create<GetKeyIntHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> _proc = &Hook_GetKeyInt;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetKeyInt(KeyCode key)
        {
            if (TryGet(out var hookItem))
            {
                if (hookItem.SyncCallback is not null)
                {
                    return hookItem.SyncCallback.Invoke(key, hookItem);
                }
                return hookItem.OriginalMethod.Delegate(key);
            }
            return default;

        }


    }
}
