using Maple.Hook.Abstractions;
using Maple.ImGui.Backends;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetAxisHookItem : HookItem<GetAxisHookItem, PTR_FUNC_GET_AXIS_4AACA73548ECDA60, PTR_FUNC_GET_AXIS_4AACA73548ECDA60>, IUnityHookItem<GetAxisHookItem>
    {
        public Func<PMonoString, GetAxisHookItem, float>? SyncCallback { get; set; }
        //public float Original(PMonoString axisName)
        //{
        //    return this.OriginalMethod.Delegate(axisName);
        //}


        public static GetAxisHookItem Create(IHookFactory hookFactory, UnityMetadataSearcher metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(GetAxisHookItem));

            //     metadataContext.Logger.LogInformation("GetAxisHookItem code:{code:X8}, pointer: {pointer:X8}", code, pointer);
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetAxisHookItem>($"NOT FOUND {nameof(GetAxisHookItem)}");
            }
            return hookFactory.Create<GetAxisHookItem>(pointer, GetHookMethodPointer());


        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, float> _proc = &Hook_GetAxis;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static float Hook_GetAxis(PMonoString axisName)
        {
            if (TryGet(out var hookItem))
            {
                if (hookItem.SyncCallback is not null)
                {
                    return hookItem.SyncCallback.Invoke(axisName, hookItem);
                }
                return hookItem.OriginalMethod.Delegate(axisName);
            }
            return default;

        }


    }
}