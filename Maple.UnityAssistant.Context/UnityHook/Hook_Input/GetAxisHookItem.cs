using Maple.Hook.Abstractions;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Ptr_Input;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Hook_Input
{

    public class GetAxisHookItem : HookItem<GetAxisHookItem, PTR_FUNC_GET_AXIS_4AACA73548ECDA60, PTR_FUNC_GET_AXIS_4AACA73548ECDA60>, IUnityHookItem<GetAxisHookItem>
    {
        public Func<PMonoString, GetAxisHookItem, float>? SyncCallback { get; set; }
        public float Original(PMonoString axisName)
        {
            return this.OriginalMethod.Delegate(axisName);
        }

        public static GetAxisHookItem Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, MonoClassMetadataCollection classMetadataCollection, ulong code = Input.Code_FunctionPointerType_GET_AXIS_4AACA73548ECDA60)
        {
            var pointer = metadataContext.GetMethodDelegate(code, classMetadataCollection).MethodPointer;
            if (pointer == nint.Zero)
            {
                return UnityBlockInputException.Throw<GetAxisHookItem>($"NOT FOUND {nameof(GetAxisHookItem)}:{code}");
            }
            return hookFactory.Create<GetAxisHookItem>(pointer, GetHookMethodPointer());

        }

        private static unsafe nint GetHookMethodPointer()
        {
            delegate* unmanaged[Cdecl]<PMonoString, float> _proc = &Hook_GetAxis;
            return new(_proc);
        }
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
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