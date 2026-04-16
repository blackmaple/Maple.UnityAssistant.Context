using Maple.Hook.Abstractions;

namespace Maple.UnityAssistant.Context.UnityHook.Ptr_Input
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly struct PTR_FUNC_GET_KEY_UP_INT_2E27C050DF037639(nint ptr) : IHookMethod
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.MetadataUnity.KeyCode, bool> m_Pointer = (delegate* unmanaged[Cdecl]<Maple.MonoGameAssistant.MetadataUnity.KeyCode, bool>)ptr;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Delegate(Maple.MonoGameAssistant.MetadataUnity.KeyCode key) => this.m_Pointer(key);
        public nint PtrMethod => new(m_Pointer);

    }

}