using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseButtonUpHookItem : HookItem<GetMouseButtonUpHookItem, PTR_FUNC_GET_MOUSE_BUTTON_UP_8EE9A0C534915B11, PTR_FUNC_GET_MOUSE_BUTTON_UP_8EE9A0C534915B11>, IUnityHookItem<GetMouseButtonUpHookItem>
    {
        public Func<int, GetMouseButtonUpHookItem, bool>? SyncCallback { get; set; }
        public bool Original(int button)
        {
            return this.OriginalMethod.Delegate(button);
        }

        public static GetMouseButtonUpHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_MOUSE_BUTTON_UP_8EE9A0C534915B11)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseButtonUpHookItem>($"NOT FOUND {nameof(GetMouseButtonUpHookItem)}:{code}");
            }
            return hookFactory.Create<GetMouseButtonUpHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<int, bool> _proc = &Hook_GetMouseButtonUp;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
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
