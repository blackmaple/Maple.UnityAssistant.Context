using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        public unsafe readonly delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, nint> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, nint>)ptr;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe nint Delegate(nint @this)
        {
            return m_Pointer(@this);
        }
        public static implicit operator PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0(nint ptr) => new(ptr);
        public static implicit operator bool(PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0 value) => new nint(value.m_Pointer) != nint.Zero;

    }

}