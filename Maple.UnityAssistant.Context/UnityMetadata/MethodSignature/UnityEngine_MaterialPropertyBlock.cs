namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_MaterialPropertyBlock
{
    public const string MONO_Clear = "UnityEngine.MaterialPropertyBlock::Clear";
    public const string MONO_CreateImpl = "UnityEngine.MaterialPropertyBlock::CreateImpl";
    public const string MONO_DestroyImpl = "UnityEngine.MaterialPropertyBlock::DestroyImpl";
    public const string MONO_ExtractFloatArrayImpl = "UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl";
    public const string MONO_ExtractMatrixArrayImpl = "UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl";
    public const string MONO_ExtractVectorArrayImpl = "UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl";
    public const string MONO_GetIsEmpty = "UnityEngine.MaterialPropertyBlock::get_isEmpty";
    public const string MONO_GetColorImplInjected = "UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected";
    public const string MONO_GetFloatArrayCountImpl = "UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl";
    public const string MONO_GetFloatArrayImpl = "UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl";
    public const string MONO_GetFloatImpl = "UnityEngine.MaterialPropertyBlock::GetFloatImpl";
    public const string MONO_GetIntImpl = "UnityEngine.MaterialPropertyBlock::GetIntImpl";
    public const string MONO_GetMatrixArrayCountImpl = "UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl";
    public const string MONO_GetMatrixArrayImpl = "UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl";
    public const string MONO_GetMatrixImplInjected = "UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected";
    public const string MONO_GetTextureImpl = "UnityEngine.MaterialPropertyBlock::GetTextureImpl";
    public const string MONO_GetVectorArrayCountImpl = "UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl";
    public const string MONO_GetVectorArrayImpl = "UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl";
    public const string MONO_GetVectorImplInjected = "UnityEngine.MaterialPropertyBlock::GetVectorImpl_Injected";
    public const string MONO_HasBufferImpl = "UnityEngine.MaterialPropertyBlock::HasBufferImpl";
    public const string MONO_HasConstantBufferImpl = "UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl";
    public const string MONO_HasFloatImpl = "UnityEngine.MaterialPropertyBlock::HasFloatImpl";
    public const string MONO_HasIntImpl = "UnityEngine.MaterialPropertyBlock::HasIntImpl";
    public const string MONO_HasMatrixImpl = "UnityEngine.MaterialPropertyBlock::HasMatrixImpl";
    public const string MONO_HasPropertyImpl = "UnityEngine.MaterialPropertyBlock::HasPropertyImpl";
    public const string MONO_HasTextureImpl = "UnityEngine.MaterialPropertyBlock::HasTextureImpl";
    public const string MONO_HasVectorImpl = "UnityEngine.MaterialPropertyBlock::HasVectorImpl";
    public const string MONO_InternalCopyProbeOcclusionArrayFrom = "UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom";
    public const string MONO_InternalCopyShcoefficientArraysFrom = "UnityEngine.MaterialPropertyBlock::Internal_CopySHCoefficientArraysFrom";
    public const string MONO_SetBufferImpl = "UnityEngine.MaterialPropertyBlock::SetBufferImpl";
    public const string MONO_SetColorImplInjected = "UnityEngine.MaterialPropertyBlock::SetColorImpl_Injected";
    public const string MONO_SetConstantBufferImpl = "UnityEngine.MaterialPropertyBlock::SetConstantBufferImpl";
    public const string MONO_SetConstantGraphicsBufferImpl = "UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl";
    public const string MONO_SetFloatArrayImpl = "UnityEngine.MaterialPropertyBlock::SetFloatArrayImpl";
    public const string MONO_SetFloatImpl = "UnityEngine.MaterialPropertyBlock::SetFloatImpl";
    public const string MONO_SetGraphicsBufferImpl = "UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl";
    public const string MONO_SetIntImpl = "UnityEngine.MaterialPropertyBlock::SetIntImpl";
    public const string MONO_SetMatrixArrayImpl = "UnityEngine.MaterialPropertyBlock::SetMatrixArrayImpl";
    public const string MONO_SetMatrixImplInjected = "UnityEngine.MaterialPropertyBlock::SetMatrixImpl_Injected";
    public const string MONO_SetRenderTextureImpl = "UnityEngine.MaterialPropertyBlock::SetRenderTextureImpl";
    public const string MONO_SetTextureImpl = "UnityEngine.MaterialPropertyBlock::SetTextureImpl";
    public const string MONO_SetVectorArrayImpl = "UnityEngine.MaterialPropertyBlock::SetVectorArrayImpl";
    public const string MONO_SetVectorImplInjected = "UnityEngine.MaterialPropertyBlock::SetVectorImpl_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_MaterialPropertyBlock : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_MaterialPropertyBlock(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_MaterialPropertyBlock(nint ptr) => new Ptr_UnityEngine_MaterialPropertyBlock(ptr);
        public static implicit operator nint(Ptr_UnityEngine_MaterialPropertyBlock ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_MaterialPropertyBlock ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Clear = "UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)";
    public const string IL2CPP_CreateImpl = "UnityEngine.MaterialPropertyBlock::CreateImpl()";
    public const string IL2CPP_DestroyImpl = "UnityEngine.MaterialPropertyBlock::DestroyImpl(System.IntPtr)";
    public const string IL2CPP_SetFloatArrayImpl = "UnityEngine.MaterialPropertyBlock::SetFloatArrayImpl(System.Int32,System.Single[],System.Int32)";
    public const string IL2CPP_SetFloatImpl = "UnityEngine.MaterialPropertyBlock::SetFloatImpl(System.Int32,System.Single)";
    public const string IL2CPP_SetMatrixArrayImpl = "UnityEngine.MaterialPropertyBlock::SetMatrixArrayImpl(System.Int32,UnityEngine.Matrix4x4[],System.Int32)";
    public const string IL2CPP_SetMatrixImpl_Injected = "UnityEngine.MaterialPropertyBlock::SetMatrixImpl_Injected(System.Int32,UnityEngine.Matrix4x4&)";
    public const string IL2CPP_SetRenderTextureImpl = "UnityEngine.MaterialPropertyBlock::SetRenderTextureImpl(System.Int32,UnityEngine.RenderTexture,UnityEngine.Rendering.RenderTextureSubElement)";
    public const string IL2CPP_SetTextureImpl = "UnityEngine.MaterialPropertyBlock::SetTextureImpl(System.Int32,UnityEngine.Texture)";
    public const string IL2CPP_SetVectorArrayImpl = "UnityEngine.MaterialPropertyBlock::SetVectorArrayImpl(System.Int32,UnityEngine.Vector4[],System.Int32)";
    public const string IL2CPP_SetVectorImpl_Injected = "UnityEngine.MaterialPropertyBlock::SetVectorImpl_Injected(System.Int32,UnityEngine.Vector4&)";
}

