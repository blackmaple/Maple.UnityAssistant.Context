using Maple.Hook.Abstractions;
using Maple.UnmanagedExtensions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8(nint ptr) : IHookMethod
    {
        public readonly delegate* unmanaged[Cdecl]<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, void> m_Pointer = (delegate* unmanaged[Cdecl]<UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3>, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(UnsafeOut<Maple.MonoGameAssistant.MetadataUnity.Vector3.Ref_Vector3> ret) => this.m_Pointer(ret);
        public nint PtrMethod => new(m_Pointer);

    }

}