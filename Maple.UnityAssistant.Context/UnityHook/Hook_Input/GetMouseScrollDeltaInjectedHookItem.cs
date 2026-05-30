using Maple.Hook.Abstractions;
using Maple.UnityAssistant.Context.UnityMetadata;
using Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;
using Maple.UnmanagedExtensions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseScrollDeltaInjectedHookItem : HookItem<GetMouseScrollDeltaInjectedHookItem, PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED, PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED>, IUnityHookItem<GetMouseScrollDeltaInjectedHookItem>
    {
        public Action<UnsafeOut<Ref_Vector2>, GetMouseScrollDeltaInjectedHookItem>? SyncCallback { get; set; }
        //public void Original(UnsafeOut<Vector2.Ref_Vector2> ret)
        //{
        //    this.OriginalMethod.Delegate(ret);
        //}

        public static GetMouseScrollDeltaInjectedHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED));
            //      metadataContext.Logger.LogInformation("GetMouseScrollDeltaInjectedHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseScrollDeltaInjectedHookItem>($"NOT FOUND {nameof(PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED)}");
            }
            return hookFactory.Create<GetMouseScrollDeltaInjectedHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Ref_Vector2>, void> _proc = &Hook_GetMouseScrollDeltaInjected;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static unsafe void Hook_GetMouseScrollDeltaInjected(UnsafeOut<Ref_Vector2> ret)
        {
            if (TryGet(out var hookItem))
            {
                if (hookItem.SyncCallback is not null)
                {
                    hookItem.SyncCallback.Invoke(ret, hookItem);
                }
                else
                {
                    hookItem.OriginalMethod.Delegate(ret);
                }

            }


        }


    }
}
