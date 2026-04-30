using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyUpIntHookItem : HookItem<GetKeyUpIntHookItem, PTR_FUNC_GET_KEY_UP_INT_2E27C050DF037639, PTR_FUNC_GET_KEY_UP_INT_2E27C050DF037639>, IUnityHookItem<GetKeyUpIntHookItem>
    {
        public Func<KeyCode, GetKeyUpIntHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(KeyCode key)
        //{
        //    return this.OriginalMethod.Delegate(key);
        //}

        public static GetKeyUpIntHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_KEY_UP_INT_2E27C050DF037639)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
       //     metadataContext.Logger.LogInformation("GetKeyUpIntHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyUpIntHookItem>($"NOT FOUND {nameof(GetKeyUpIntHookItem)}:{code}");
            }
            return hookFactory.Create<GetKeyUpIntHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<KeyCode, bool> _proc = &Hook_GetKeyUpInt;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetKeyUpInt(KeyCode key)
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
