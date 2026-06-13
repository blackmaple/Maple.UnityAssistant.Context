using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.UnityAssistant.Context.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetAxisRawHookItem : HookItem<GetAxisRawHookItem, PTR_FUNC_GET_AXIS_RAW, PTR_FUNC_GET_AXIS_RAW>, IUnityHookItem<GetAxisRawHookItem>
    {
        public Func<PMonoString, GetAxisRawHookItem, float>? SyncCallback { get; set; }
        //public float Original(PMonoString axisName)
        //{
        //    return this.OriginalMethod.Delegate(axisName);
        //}

        public static GetAxisRawHookItem? Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_AXIS_RAW));
            //          metadataContext.Logger.LogInformation("GetAxisRawHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return default;
            }
            return hookFactory.Create<GetAxisRawHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, float> _proc = &Hook_GetAxisRaw;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static float Hook_GetAxisRaw(PMonoString axisName)
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
