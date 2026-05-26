using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Maple.UnityAssistant.Context.UnityMetadata;
using Maple.UnmanagedExtensions;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetMousePositionInjectedHookItem : HookItem<GetMousePositionInjectedHookItem, PTR_FUNC_GET_MOUSE_POSITION_INJECTED_99D1FC8E163B2580, PTR_FUNC_GET_MOUSE_POSITION_INJECTED_99D1FC8E163B2580>, IUnityHookItem<GetMousePositionInjectedHookItem>
    {
        public Action<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, GetMousePositionInjectedHookItem>? SyncCallback { get; set; }
        //public void Original(UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3> ret)
        //{
        //    this.OriginalMethod.Delegate(ret);
        //}

        public static GetMousePositionInjectedHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(GetMousePositionInjectedHookItem));
            //      metadataContext.Logger.LogInformation("GetMousePositionInjectedHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetMousePositionInjectedHookItem>($"NOT FOUND {nameof(GetMousePositionInjectedHookItem)}");
            }
            return hookFactory.Create<GetMousePositionInjectedHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, void> _proc = &Hook_GetMousePositionInjected;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
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
