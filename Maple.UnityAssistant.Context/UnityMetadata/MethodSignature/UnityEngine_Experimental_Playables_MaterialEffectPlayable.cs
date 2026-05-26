namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Experimental_Playables_MaterialEffectPlayable
{
    public const string MONO_GetMaterialInternal = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal";
    public const string MONO_GetPassInternal = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal";
    public const string MONO_InternalCreateMaterialEffectPlayable = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable";
    public const string MONO_SetMaterialInternal = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal";
    public const string MONO_SetPassInternal = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal";
    public const string MONO_ValidateType = "UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable(nint ptr) => new Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Experimental_Playables_MaterialEffectPlayable ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
