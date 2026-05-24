using Maple.MonoGameAssistant.MetadataUnity;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_TEXTURE_9E369564B1447B9B(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        public unsafe readonly delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, Texture2D.Ptr_Texture2D> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition, Cdecl]<nint, Texture2D.Ptr_Texture2D>)ptr;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Texture2D.Ptr_Texture2D Delegate(nint @this)
        {
            return m_Pointer(@this);
        }

        public static implicit operator PTR_FUNC_GET_TEXTURE_9E369564B1447B9B(nint ptr) => new(ptr);
        public static implicit operator bool(PTR_FUNC_GET_TEXTURE_9E369564B1447B9B value) => new nint(value.m_Pointer) != nint.Zero;

    }
}