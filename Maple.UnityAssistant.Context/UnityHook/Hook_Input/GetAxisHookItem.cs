using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.UnityAssistant.Context.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetAxisHookItem : HookItem<GetAxisHookItem, PTR_FUNC_GET_AXIS, PTR_FUNC_GET_AXIS>, IUnityHookItem<GetAxisHookItem>
    {
        public Func<PMonoString, GetAxisHookItem, float>? SyncCallback { get; set; }
        //public float Original(PMonoString axisName)
        //{
        //    return this.OriginalMethod.Delegate(axisName);
        //}


        public static GetAxisHookItem? Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_AXIS));

            //     metadataContext.Logger.LogInformation("GetAxisHookItem code:{code:X8}, pointer: {pointer:X8}", code, pointer);
            if (pointer == nint.Zero)
            {
                return default;
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