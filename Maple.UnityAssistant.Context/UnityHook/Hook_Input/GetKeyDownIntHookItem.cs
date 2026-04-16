using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyDownIntHookItem : HookItem<GetKeyDownIntHookItem, PTR_FUNC_GET_KEY_DOWN_INT_49C8675AD85C932A, PTR_FUNC_GET_KEY_DOWN_INT_49C8675AD85C932A>, IUnityHookItem<GetKeyDownIntHookItem>
    {
        public Func<KeyCode, GetKeyDownIntHookItem, bool>? SyncCallback { get; set; }
        public bool Original(KeyCode key)
        {
            return this.OriginalMethod.Delegate(key);
        }

        public static GetKeyDownIntHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_KEY_DOWN_INT_49C8675AD85C932A)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyDownIntHookItem>($"NOT FOUND {nameof(GetKeyDownIntHookItem)}:{code}");
            }
            return hookFactory.Create<GetKeyDownIntHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<KeyCode, bool> _proc = &Hook_GetKeyDownInt;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
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
