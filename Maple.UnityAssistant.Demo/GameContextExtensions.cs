using Maple.UnityAssistant.Context;
using Maple.UnityAssistant.Context.D3D12;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Demo
{
    public static class GameContextExtensions
    {
  

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            D3D12GameContextExtensions.Run<DemoContextService>(p =>
            {
                p.GameName = "Demo";
                p.QQ = "QQ:75351663";
            },millisecondsTimeout:8000);
            return default;
        }
    }
}
