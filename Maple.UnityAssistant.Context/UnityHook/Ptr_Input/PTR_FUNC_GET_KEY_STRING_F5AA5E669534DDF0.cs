using Maple.Hook.Abstractions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_STRING_F5AA5E669534DDF0(nint ptr) : IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.Core.PMonoString, bool> m_Pointer = (delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.Core.PMonoString, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(Maple.MonoGameAssistant.Core.PMonoString name) => this.m_Pointer(name);
        public nint PtrMethod => new(m_Pointer);

    }

}