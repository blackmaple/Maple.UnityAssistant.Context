using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyUpStringHookItem : HookItem<GetKeyUpStringHookItem, PTR_FUNC_GET_KEY_UP_STRING_45B9708814684170, PTR_FUNC_GET_KEY_UP_STRING_45B9708814684170>, IUnityHookItem<GetKeyUpStringHookItem>
    {
        public Func<PMonoString, GetKeyUpStringHookItem, bool>? SyncCallback { get; set; }
        public bool Original(PMonoString name)
        {
            return this.OriginalMethod.Delegate(name);
        }

        public static GetKeyUpStringHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_KEY_UP_STRING_45B9708814684170)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyUpStringHookItem>($"NOT FOUND {nameof(GetKeyUpStringHookItem)}:{code}");
            }
            return hookFactory.Create<GetKeyUpStringHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<PMonoString, bool> _proc = &Hook_GetKeyUpString;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static bool Hook_GetKeyUpString(PMonoString name)
        {
            if (TryGet(out var hookItem))
            {
                if (hookItem.SyncCallback is not null)
                {
                    return hookItem.SyncCallback.Invoke(name, hookItem);
                }
                return hookItem.OriginalMethod.Delegate(name);
            }
            return default;

        }


    }
}
