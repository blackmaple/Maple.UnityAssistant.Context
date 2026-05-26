namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Transform
{
    public const string MONO_DetachChildren = "UnityEngine.Transform::DetachChildren";
    public const string MONO_FindRelativeTransformWithPath = "UnityEngine.Transform::FindRelativeTransformWithPath";
    public const string MONO_GetChildCount = "UnityEngine.Transform::get_childCount";
    public const string MONO_GetHasChanged = "UnityEngine.Transform::get_hasChanged";
    public const string MONO_GetLocalPositionInjected = "UnityEngine.Transform::get_localPosition_Injected";
    public const string MONO_GetLocalRotationInjected = "UnityEngine.Transform::get_localRotation_Injected";
    public const string MONO_GetLocalScaleInjected = "UnityEngine.Transform::get_localScale_Injected";
    public const string MONO_GetLocalToWorldMatrixInjected = "UnityEngine.Transform::get_localToWorldMatrix_Injected";
    public const string MONO_GetLossyScaleInjected = "UnityEngine.Transform::get_lossyScale_Injected";
    public const string MONO_GetPositionInjected = "UnityEngine.Transform::get_position_Injected";
    public const string MONO_GetRotationInjected = "UnityEngine.Transform::get_rotation_Injected";
    public const string MONO_GetWorldToLocalMatrixInjected = "UnityEngine.Transform::get_worldToLocalMatrix_Injected";
    public const string MONO_GetChild = "UnityEngine.Transform::GetChild";
    public const string MONO_GetChildCount_2 = "UnityEngine.Transform::GetChildCount";
    public const string MONO_GetLocalEulerAnglesInjected = "UnityEngine.Transform::GetLocalEulerAngles_Injected";
    public const string MONO_GetParent = "UnityEngine.Transform::GetParent";
    public const string MONO_GetRoot = "UnityEngine.Transform::GetRoot";
    public const string MONO_GetRotationOrderInternal = "UnityEngine.Transform::GetRotationOrderInternal";
    public const string MONO_GetSiblingIndex = "UnityEngine.Transform::GetSiblingIndex";
    public const string MONO_InternalGetHierarchyCapacity = "UnityEngine.Transform::internal_getHierarchyCapacity";
    public const string MONO_InternalGetHierarchyCount = "UnityEngine.Transform::internal_getHierarchyCount";
    public const string MONO_InternalLookAtInjected = "UnityEngine.Transform::Internal_LookAt_Injected";
    public const string MONO_InternalSetHierarchyCapacity = "UnityEngine.Transform::internal_setHierarchyCapacity";
    public const string MONO_InverseTransformDirectionInjected = "UnityEngine.Transform::InverseTransformDirection_Injected";
    public const string MONO_InverseTransformPointInjected = "UnityEngine.Transform::InverseTransformPoint_Injected";
    public const string MONO_InverseTransformVectorInjected = "UnityEngine.Transform::InverseTransformVector_Injected";
    public const string MONO_IsChildOf = "UnityEngine.Transform::IsChildOf";
    public const string MONO_IsConstrainProportionsScale = "UnityEngine.Transform::IsConstrainProportionsScale";
    public const string MONO_IsNonUniformScaleTransform = "UnityEngine.Transform::IsNonUniformScaleTransform";
    public const string MONO_MoveAfterSibling = "UnityEngine.Transform::MoveAfterSibling";
    public const string MONO_RotateAroundInjected = "UnityEngine.Transform::RotateAround_Injected";
    public const string MONO_RotateAroundInternalInjected = "UnityEngine.Transform::RotateAroundInternal_Injected";
    public const string MONO_RotateAroundLocalInjected = "UnityEngine.Transform::RotateAroundLocal_Injected";
    public const string MONO_SendTransformChangedScale = "UnityEngine.Transform::SendTransformChangedScale";
    public const string MONO_SetHasChanged = "UnityEngine.Transform::set_hasChanged";
    public const string MONO_SetLocalPositionInjected = "UnityEngine.Transform::set_localPosition_Injected";
    public const string MONO_SetLocalRotationInjected = "UnityEngine.Transform::set_localRotation_Injected";
    public const string MONO_SetLocalScaleInjected = "UnityEngine.Transform::set_localScale_Injected";
    public const string MONO_SetPositionInjected = "UnityEngine.Transform::set_position_Injected";
    public const string MONO_SetRotationInjected = "UnityEngine.Transform::set_rotation_Injected";
    public const string MONO_SetAsFirstSibling = "UnityEngine.Transform::SetAsFirstSibling";
    public const string MONO_SetAsLastSibling = "UnityEngine.Transform::SetAsLastSibling";
    public const string MONO_SetConstrainProportionsScale = "UnityEngine.Transform::SetConstrainProportionsScale";
    public const string MONO_SetLocalEulerAnglesInjected = "UnityEngine.Transform::SetLocalEulerAngles_Injected";
    public const string MONO_SetLocalEulerHintInjected = "UnityEngine.Transform::SetLocalEulerHint_Injected";
    public const string MONO_SetLocalPositionAndRotationInjected = "UnityEngine.Transform::SetLocalPositionAndRotation_Injected";
    public const string MONO_SetParent = "UnityEngine.Transform::SetParent";
    public const string MONO_SetPositionAndRotationInjected = "UnityEngine.Transform::SetPositionAndRotation_Injected";
    public const string MONO_SetRotationOrderInternal = "UnityEngine.Transform::SetRotationOrderInternal";
    public const string MONO_SetSiblingIndex = "UnityEngine.Transform::SetSiblingIndex";
    public const string MONO_TransformDirectionInjected = "UnityEngine.Transform::TransformDirection_Injected";
    public const string MONO_TransformPointInjected = "UnityEngine.Transform::TransformPoint_Injected";
    public const string MONO_TransformVectorInjected = "UnityEngine.Transform::TransformVector_Injected";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Transform : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Transform(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Transform(nint ptr) => new Ptr_UnityEngine_Transform(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Transform ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Transform ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_DetachChildren = "UnityEngine.Transform::DetachChildren()";
    public const string IL2CPP_FindRelativeTransformWithPath = "UnityEngine.Transform::FindRelativeTransformWithPath(UnityEngine.Transform,System.String,System.Boolean)";
    public const string IL2CPP_get_childCount = "UnityEngine.Transform::get_childCount()";
    public const string IL2CPP_get_hasChanged = "UnityEngine.Transform::get_hasChanged()";
    public const string IL2CPP_get_localPosition_Injected = "UnityEngine.Transform::get_localPosition_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_localRotation_Injected = "UnityEngine.Transform::get_localRotation_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_get_localScale_Injected = "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_localToWorldMatrix_Injected = "UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_get_lossyScale_Injected = "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_position_Injected = "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_get_rotation_Injected = "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_get_worldToLocalMatrix_Injected = "UnityEngine.Transform::get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4&)";
    public const string IL2CPP_GetChild = "UnityEngine.Transform::GetChild(System.Int32)";
    public const string IL2CPP_GetChildCount = "UnityEngine.Transform::GetChildCount()";
    public const string IL2CPP_GetLocalEulerAngles_Injected = "UnityEngine.Transform::GetLocalEulerAngles_Injected(UnityEngine.RotationOrder,UnityEngine.Vector3&)";
    public const string IL2CPP_GetParent = "UnityEngine.Transform::GetParent()";
    public const string IL2CPP_GetRoot = "UnityEngine.Transform::GetRoot()";
    public const string IL2CPP_GetRotationOrderInternal = "UnityEngine.Transform::GetRotationOrderInternal()";
    public const string IL2CPP_GetSiblingIndex = "UnityEngine.Transform::GetSiblingIndex()";
    public const string IL2CPP_internal_getHierarchyCapacity = "UnityEngine.Transform::internal_getHierarchyCapacity()";
    public const string IL2CPP_internal_getHierarchyCount = "UnityEngine.Transform::internal_getHierarchyCount()";
    public const string IL2CPP_Internal_LookAt_Injected = "UnityEngine.Transform::Internal_LookAt_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_internal_setHierarchyCapacity = "UnityEngine.Transform::internal_setHierarchyCapacity(System.Int32)";
    public const string IL2CPP_InverseTransformDirection_Injected = "UnityEngine.Transform::InverseTransformDirection_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_InverseTransformPoint_Injected = "UnityEngine.Transform::InverseTransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_InverseTransformVector_Injected = "UnityEngine.Transform::InverseTransformVector_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_IsChildOf = "UnityEngine.Transform::IsChildOf(UnityEngine.Transform)";
    public const string IL2CPP_IsConstrainProportionsScale = "UnityEngine.Transform::IsConstrainProportionsScale()";
    public const string IL2CPP_IsNonUniformScaleTransform = "UnityEngine.Transform::IsNonUniformScaleTransform()";
    public const string IL2CPP_MoveAfterSibling = "UnityEngine.Transform::MoveAfterSibling(UnityEngine.Transform,System.Boolean)";
    public const string IL2CPP_RotateAround_Injected = "UnityEngine.Transform::RotateAround_Injected(UnityEngine.Vector3&,System.Single)";
    public const string IL2CPP_RotateAroundInternal_Injected = "UnityEngine.Transform::RotateAroundInternal_Injected(UnityEngine.Vector3&,System.Single)";
    public const string IL2CPP_RotateAroundLocal_Injected = "UnityEngine.Transform::RotateAroundLocal_Injected(UnityEngine.Vector3&,System.Single)";
    public const string IL2CPP_SendTransformChangedScale = "UnityEngine.Transform::SendTransformChangedScale()";
    public const string IL2CPP_set_hasChanged = "UnityEngine.Transform::set_hasChanged(System.Boolean)";
    public const string IL2CPP_set_localPosition_Injected = "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_localRotation_Injected = "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_set_localScale_Injected = "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_position_Injected = "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_set_rotation_Injected = "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)";
    public const string IL2CPP_SetAsFirstSibling = "UnityEngine.Transform::SetAsFirstSibling()";
    public const string IL2CPP_SetAsLastSibling = "UnityEngine.Transform::SetAsLastSibling()";
    public const string IL2CPP_SetConstrainProportionsScale = "UnityEngine.Transform::SetConstrainProportionsScale(System.Boolean)";
    public const string IL2CPP_SetLocalEulerAngles_Injected = "UnityEngine.Transform::SetLocalEulerAngles_Injected(UnityEngine.Vector3&,UnityEngine.RotationOrder)";
    public const string IL2CPP_SetLocalEulerHint_Injected = "UnityEngine.Transform::SetLocalEulerHint_Injected(UnityEngine.Vector3&)";
    public const string IL2CPP_SetParent = "UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)";
    public const string IL2CPP_SetPositionAndRotation_Injected = "UnityEngine.Transform::SetPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)";
    public const string IL2CPP_SetRotationOrderInternal = "UnityEngine.Transform::SetRotationOrderInternal(UnityEngine.RotationOrder)";
    public const string IL2CPP_SetSiblingIndex = "UnityEngine.Transform::SetSiblingIndex(System.Int32)";
    public const string IL2CPP_TransformDirection_Injected = "UnityEngine.Transform::TransformDirection_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_TransformPoint_Injected = "UnityEngine.Transform::TransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
    public const string IL2CPP_TransformVector_Injected = "UnityEngine.Transform::TransformVector_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)";
}

