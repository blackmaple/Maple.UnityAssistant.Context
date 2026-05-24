using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetKeyStringHookItem : HookItem<GetKeyStringHookItem, PTR_FUNC_GET_KEY_STRING_F5AA5E669534DDF0, PTR_FUNC_GET_KEY_STRING_F5AA5E669534DDF0>, IUnityHookItem<GetKeyStringHookItem>
    {
        public Func<PMonoString, GetKeyStringHookItem, bool>? SyncCallback { get; set; }
        //public bool Original(PMonoString name)
        //{
        //    return this.OriginalMethod.Delegate(name);
        //}

        public static GetKeyStringHookItem Create(IHookFactory hookFactory, UnityMetadataSearcher metadataSearcher)
        {
            var pointer = metadataSearcher.GetMethodPointer(nameof(GetKeyStringHookItem));
            //        metadataContext.Logger.LogInformation("GetKeyStringHookItem code: {code:X8}, pointer: {pointer:X8}", code, pointer);

            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetKeyStringHookItem>($"NOT FOUND {nameof(GetKeyStringHookItem)}");
            }
            return hookFactory.Create<GetKeyStringHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoString, bool> _proc = &Hook_GetKeyString;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        private static bool Hook_GetKeyString(PMonoString name)
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
