namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Gizmos
{
    public const string MONO_DrawCubeInjected = "UnityEngine.Gizmos::DrawCube_Injected";
    public const string MONO_DrawFrustumInjected = "UnityEngine.Gizmos::DrawFrustum_Injected";
    public const string MONO_DrawGuitextureInjected = "UnityEngine.Gizmos::DrawGUITexture_Injected";
    public const string MONO_DrawIconInjected = "UnityEngine.Gizmos::DrawIcon_Injected";
    public const string MONO_DrawLineInjected = "UnityEngine.Gizmos::DrawLine_Injected";
    public const string MONO_DrawMeshInjected = "UnityEngine.Gizmos::DrawMesh_Injected";
    public const string MONO_DrawSphereInjected = "UnityEngine.Gizmos::DrawSphere_Injected";
    public const string MONO_DrawWireCubeInjected = "UnityEngine.Gizmos::DrawWireCube_Injected";
    public const string MONO_DrawWireMeshInjected = "UnityEngine.Gizmos::DrawWireMesh_Injected";
    public const string MONO_DrawWireSphereInjected = "UnityEngine.Gizmos::DrawWireSphere_Injected";
    public const string MONO_GetColorInjected = "UnityEngine.Gizmos::get_color_Injected";
    public const string MONO_GetExposure = "UnityEngine.Gizmos::get_exposure";
    public const string MONO_GetMatrixInjected = "UnityEngine.Gizmos::get_matrix_Injected";
    public const string MONO_GetProbeSize = "UnityEngine.Gizmos::get_probeSize";
    public const string MONO_SetColorInjected = "UnityEngine.Gizmos::set_color_Injected";
    public const string MONO_SetExposure = "UnityEngine.Gizmos::set_exposure";
    public const string MONO_SetMatrixInjected = "UnityEngine.Gizmos::set_matrix_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Gizmos : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Gizmos(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Gizmos(nint ptr) => new Ptr_UnityEngine_Gizmos(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Gizmos ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Gizmos ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DrawCube_Injected = "UnityEngine.Gizmos::DrawCube_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_DrawFrustum_Injected = "UnityEngine.Gizmos::DrawFrustum_Injected(UnityEngine.Vector3&,System.Single,System.Single,System.Single,System.Single)";
    public const string IL2CPP_DrawGUITexture_Injected = "UnityEngine.Gizmos::DrawGUITexture_Injected(UnityEngine.Rect&,UnityEngine.Texture,System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Material)";
    public const string IL2CPP_DrawIcon_Injected = "UnityEngine.Gizmos::DrawIcon_Injected(UnityEngine.Vector3&,System.String,System.Boolean,UnityEngine.Color&)";
    public const string IL2CPP_DrawLine_Injected = "UnityEngine.Gizmos::DrawLine_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_DrawMesh_Injected = "UnityEngine.Gizmos::DrawMesh_Injected(UnityEngine.Mesh,System.Int32,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&)";
    public const string IL2CPP_DrawSphere_Injected = "UnityEngine.Gizmos::DrawSphere_Injected(UnityEngine.Vector3&,System.Single)";
    public const string IL2CPP_DrawWireCube_Injected = "UnityEngine.Gizmos::DrawWireCube_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_DrawWireMesh_Injected = "UnityEngine.Gizmos::DrawWireMesh_Injected(UnityEngine.Mesh,System.Int32,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&)";
    public const string IL2CPP_DrawWireSphere_Injected = "UnityEngine.Gizmos::DrawWireSphere_Injected(UnityEngine.Vector3&,System.Single)";
    public const string IL2CPP_get_color_Injected = "UnityEngine.Gizmos::get_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_get_exposure = "UnityEngine.Gizmos::get_exposure()";
    public const string IL2CPP_get_matrix_Injected = "UnityEngine.Gizmos::get_matrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_get_probeSize = "UnityEngine.Gizmos::get_probeSize()";
    public const string IL2CPP_set_color_Injected = "UnityEngine.Gizmos::set_color_Injected(UnityEngine.Color&)";
    public const string IL2CPP_set_exposure = "UnityEngine.Gizmos::set_exposure(UnityEngine.Texture)";
    public const string IL2CPP_set_matrix_Injected = "UnityEngine.Gizmos::set_matrix_Injected(UnityEngine.Matrix4x4&)";
}

