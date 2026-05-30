using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.UnityAssistant.Context.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.UnityAssistant.Context.UnityMetadata.MethodSignature.UnityEngine_Input;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyDownStringHookItem : HookItem<GetKeyDownStringHookItem, PTR_FUNC_GET_KEY_DOWN_STRING, PTR_FUNC_GET_KEY_DOWN_STRING>, IUnityHookItem<GetKeyDownStringHookItem>
    {
        public Func<PMonoString, GetKeyDownStringHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(PMonoString name)
        //{
        //    return this.OriginalMethod.Delegate(name);
        //}

        public static GetKeyDownStringHookItem Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(PTR_FUNC_GET_KEY_DOWN_STRING));
            //  metadataContext.Logger.LogInformation("GetKeyDownStringHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyDownStringHookItem>($"NOT FOUND {nameof(PTR_FUNC_GET_KEY_DOWN_STRING)}");
            }
            return hookFactory.Create<GetKeyDownStringHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool> _proc = &Hook_GetKeyDownString;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetKeyDownString(PMonoString name)
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
