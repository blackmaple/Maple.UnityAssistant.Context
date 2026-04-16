using Maple.Hook.Abstractions;
using Maple.UnmanagedExtensions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F(nint ptr) : IHookMethod
    {
        public readonly delegate* unmanaged[Cdecl]<UnsafeOut<MonoGameAssistant.MetadataUnity.Vector2.Ref_Vector2>, void> m_Pointer = (delegate* unmanaged[Cdecl]<UnsafeOut<MonoGameAssistant.MetadataUnity.Vector2.Ref_Vector2>, void>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Delegate(UnsafeOut<MonoGameAssistant.MetadataUnity.Vector2.Ref_Vector2> ret) => this.m_Pointer(ret);
        public nint PtrMethod => new(m_Pointer);

    }

}