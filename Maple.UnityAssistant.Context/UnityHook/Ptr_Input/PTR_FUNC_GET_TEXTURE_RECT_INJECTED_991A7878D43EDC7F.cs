using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.MetadataUnity;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F(nint ptr)
    {
 
        [MarshalAs(UnmanagedType.SysInt)]
        public unsafe readonly delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, MapleOut<Rect.Ref_Rect>, void> m_Pointer=
            (delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, MapleOut<Rect.Ref_Rect>, void>)ptr;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Delegate(nint @this, MapleOut<Rect.Ref_Rect> rect)
        {
            m_Pointer(@this, rect);
        }
        public static implicit operator PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F(nint ptr) => new(ptr);
        public static implicit operator bool(PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F value) => new nint(value.m_Pointer) != nint.Zero;


    }

}