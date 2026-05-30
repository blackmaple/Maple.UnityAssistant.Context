using Maple.Hook.Abstractions;
using Maple.UnityAssistant.Context.UnityMetadata;
using Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyDownIntHookItem : HookItem<GetKeyDownIntHookItem, PTR_FUNC_GET_KEY_DOWN_INT, PTR_FUNC_GET_KEY_DOWN_INT>, IUnityHookItem<GetKeyDownIntHookItem>
    {
        public Func<KeyCode, GetKeyDownIntHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(KeyCode key)
        //{
        //    return this.OriginalMethod.Delegate(key);
        //}

        public static GetKeyDownIntHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_KEY_DOWN_INT));
            //    metadataContext.Logger.LogInformation("GetKeyDownIntHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyDownIntHookItem>($"NOT FOUND {nameof(PTR_FUNC_GET_KEY_DOWN_INT)}");
            }
            return hookFactory.Create<GetKeyDownIntHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> _proc = &Hook_GetKeyDownInt;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetKeyDownInt(KeyCode key)
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
