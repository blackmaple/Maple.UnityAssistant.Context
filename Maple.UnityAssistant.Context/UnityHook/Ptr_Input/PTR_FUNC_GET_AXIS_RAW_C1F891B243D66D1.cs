using Maple.Hook.Abstractions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_AXIS_RAW_C1F891B243D66D1(nint ptr) : IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.Core.PMonoString, float> m_Pointer = (delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.Core.PMonoString, float>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public float Delegate(Maple.MonoGameAssistant.Core.PMonoString axisName) => this.m_Pointer(axisName);
        public nint PtrMethod => new(m_Pointer);

    }

}