using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Maple.UnmanagedExtensions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMousePositionInjectedHookItem : HookItem<GetMousePositionInjectedHookItem, PTR_FUNC_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8, PTR_FUNC_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8>, IUnityHookItem<GetMousePositionInjectedHookItem>
    {
        public Action<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, GetMousePositionInjectedHookItem>? SyncCallback { get; set; }
        public void Original(UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3> ret)
        {
            this.OriginalMethod.Delegate(ret);
        }

        public static GetMousePositionInjectedHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMousePositionInjectedHookItem>($"NOT FOUND {nameof(GetMousePositionInjectedHookItem)}:{code}");
            }
            return hookFactory.Create<GetMousePositionInjectedHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, void> _proc = &Hook_GetMousePositionInjected;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static void Hook_GetMousePositionInjected(UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3> ret)
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
