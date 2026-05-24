using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataUnity.UnityMetadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        public unsafe readonly delegate* unmanaged[SuppressGCTransition]<IMECompositionMode, void> m_Pointer =
            (delegate* unmanaged[SuppressGCTransition]<IMECompositionMode, void>)ptr;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Delegate(IMECompositionMode value)
        {
            m_Pointer(value);
        }

        public static implicit operator PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736(nint ptr) => new(ptr);
        public static implicit operator bool(PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736 value) => new nint(value.m_Pointer) != nint.Zero;
    }
}