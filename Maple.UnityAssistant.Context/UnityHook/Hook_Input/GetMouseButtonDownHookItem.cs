using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseButtonDownHookItem : HookItem<GetMouseButtonDownHookItem, PTR_FUNC_GET_MOUSE_BUTTON_DOWN_BE6A4B41F70F23EE, PTR_FUNC_GET_MOUSE_BUTTON_DOWN_BE6A4B41F70F23EE>, IUnityHookItem<GetMouseButtonDownHookItem>
    {
        public Func<int, GetMouseButtonDownHookItem, bool>? SyncCallback { get; set; }
        public bool Original(int button)
        {
            return this.OriginalMethod.Delegate(button);
        }

        public static GetMouseButtonDownHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_MOUSE_BUTTON_DOWN_BE6A4B41F70F23EE)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseButtonDownHookItem>($"NOT FOUND {nameof(GetMouseButtonDownHookItem)}:{code}");
            }
            return hookFactory.Create<GetMouseButtonDownHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<int, bool> _proc = &Hook_GetMouseButtonDown;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static bool Hook_GetMouseButtonDown(int button)
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
