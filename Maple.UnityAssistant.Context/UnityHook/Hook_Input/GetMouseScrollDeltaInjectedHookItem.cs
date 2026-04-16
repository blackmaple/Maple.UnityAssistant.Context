using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Maple.UnmanagedExtensions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMouseScrollDeltaInjectedHookItem : HookItem<GetMouseScrollDeltaInjectedHookItem, PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F, PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F>, IUnityHookItem<GetMouseScrollDeltaInjectedHookItem>
    {
        public Action<UnsafeOut<Vector2.Ref_Vector2>, GetMouseScrollDeltaInjectedHookItem>? SyncCallback { get; set; }
        public void Original(UnsafeOut<Vector2.Ref_Vector2> ret)
        {
            this.OriginalMethod.Delegate(ret);
        }

        public static GetMouseScrollDeltaInjectedHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMouseScrollDeltaInjectedHookItem>($"NOT FOUND {nameof(GetMouseScrollDeltaInjectedHookItem)}:{code}");
            }
            return hookFactory.Create<GetMouseScrollDeltaInjectedHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<UnsafeOut<Vector2.Ref_Vector2>, void> _proc = &Hook_GetMouseScrollDeltaInjected;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static unsafe void Hook_GetMouseScrollDeltaInjected(UnsafeOut<Vector2.Ref_Vector2> ret)
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
