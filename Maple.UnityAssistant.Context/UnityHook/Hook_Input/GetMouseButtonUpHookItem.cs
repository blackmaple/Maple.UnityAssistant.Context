using Maple.Hook.Abstractions;
using Maple.UnityAssistant.Context.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseButtonUpHookItem : HookItem<GetMouseButtonUpHookItem, PTR_FUNC_GET_MOUSE_BUTTON_UP, PTR_FUNC_GET_MOUSE_BUTTON_UP>, IUnityHookItem<GetMouseButtonUpHookItem>
    {
        public Func<int, GetMouseButtonUpHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(int button)
        //{
        //    return this.OriginalMethod.Delegate(button);
        //}

        public static GetMouseButtonUpHookItem? Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_MOUSE_BUTTON_UP));
            //    metadataContext.Logger.LogInformation("GetMouseButtonUpHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return default;
            }
            return hookFactory.Create<GetMouseButtonUpHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<int, bool> _proc = &Hook_GetMouseButtonUp;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetMouseButtonUp(int button)
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
