using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetAxisRawHookItem : HookItem<GetAxisRawHookItem, PTR_FUNC_GET_AXIS_RAW_C1F891B243D66D1, PTR_FUNC_GET_AXIS_RAW_C1F891B243D66D1>, IUnityHookItem<GetAxisRawHookItem>
    {
        public Func<PMonoString, GetAxisRawHookItem, float>? SyncCallback { get; set; }
        public float Original(PMonoString axisName)
        {
            return this.OriginalMethod.Delegate(axisName);
        }

        public static GetAxisRawHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_AXIS_RAW_C1F891B243D66D1)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetAxisRawHookItem>($"NOT FOUND {nameof(GetAxisRawHookItem)}:{code}");
            }
            return hookFactory.Create<GetAxisRawHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<PMonoString, float> _proc = &Hook_GetAxisRaw;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
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
