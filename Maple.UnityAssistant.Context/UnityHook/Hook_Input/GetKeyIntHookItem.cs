using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyIntHookItem : HookItem<GetKeyIntHookItem, PTR_FUNC_GET_KEY_INT_364226C2278E06B9, PTR_FUNC_GET_KEY_INT_364226C2278E06B9>, IUnityHookItem<GetKeyIntHookItem>
    {
        public Func<KeyCode, GetKeyIntHookItem, bool>? SyncCallback { get; set; }
        public bool Original(KeyCode key)
        {
            return this.OriginalMethod.Delegate(key);
        }

        public static GetKeyIntHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_KEY_INT_364226C2278E06B9)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyIntHookItem>($"NOT FOUND {nameof(GetKeyIntHookItem)}:{code}");
            }
            return hookFactory.Create<GetKeyIntHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<KeyCode, bool> _proc = &Hook_GetKeyInt;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
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
