using Maple.Hook.Abstractions;
using Maple.UnityAssistant.Context.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseButtonHookItem : HookItem<GetMouseButtonHookItem, PTR_FUNC_GET_MOUSE_BUTTON, PTR_FUNC_GET_MOUSE_BUTTON>, IUnityHookItem<GetMouseButtonHookItem>
    {
        public Func<int, GetMouseButtonHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(int button)
        //{
        //    return this.OriginalMethod.Delegate(button);
        //}

        public static GetMouseButtonHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_MOUSE_BUTTON));
            //  metadataContext.Logger.LogInformation("GetMouseButtonHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseButtonHookItem>($"NOT FOUND {nameof(PTR_FUNC_GET_MOUSE_BUTTON)}");
            }
            return hookFactory.Create<GetMouseButtonHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool> _proc = &Hook_GetMouseButton;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetMouseButton(int button)
        {
            if (TryGet(out var hookItem))
            {
                if (hookItem.SyncCallback is not null)
                {
                    return hookItem.SyncCallback.Invoke(button, hookItem);
                }
                return hookItem.OriginalMethod.Delegate(button);
            }
            return default;

        }


    }
}
