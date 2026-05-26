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

    public class GetMouseButtonHookItem : HookItem<GetMouseButtonHookItem, PTR_FUNC_GET_MOUSE_BUTTON_25FCDA1BB1401B53, PTR_FUNC_GET_MOUSE_BUTTON_25FCDA1BB1401B53>, IUnityHookItem<GetMouseButtonHookItem>
    {
        public Func<int, GetMouseButtonHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(int button)
        //{
        //    return this.OriginalMethod.Delegate(button);
        //}

        public static GetMouseButtonHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(GetMouseButtonHookItem));
            //  metadataContext.Logger.LogInformation("GetMouseButtonHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseButtonHookItem>($"NOT FOUND {nameof(GetMouseButtonHookItem)}");
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
