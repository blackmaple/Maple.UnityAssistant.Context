using Maple.Hook.Abstractions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_UP_STRING_45B9708814684170(nint ptr) : IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.Core.PMonoString, bool> m_Pointer = 
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.Core.PMonoString, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(Maple.MonoGameAssistant.Core.PMonoString name) => this.m_Pointer(name);
        public nint PtrMethod => new(m_Pointer);

    }

}